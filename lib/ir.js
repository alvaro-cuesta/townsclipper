class BitReader {
  constructor(bitString) {
    this.bitString = bitString
    this.cursor = 0
  }

  read(n) {
    if (n === 0) {
      throw new Error('Trying to read zero bytes')
    }

    const bits = this.bitString.slice(
      -this.cursor - n,
      this.cursor > 0 ? -this.cursor : undefined,
    )

    if (bits.length < n) {
      throw new Error(`Could not read ${n} bits (only ${bits.length} left) at position ${this.cursor}`)
    }

    this.cursor += n

    return parseInt(bits, 2)
  }

  get left() {
    return this.bitString.length - this.cursor
  }
}

const getSignOffset = (bitLength) => 1 << (bitLength - 1)

const getMaxValue = (bitLength) => (1 << bitLength) - 1

const getTypeIndexInfo = (typeCount) => {
  const typeIndexBitLength = Math.ceil(Math.log2(typeCount + 2))
  const typeStopIndex = (1 << typeIndexBitLength) - 1

  return {
    typeIndexBitLength,
    typeStopIndex,
  }
}

const bitStringToIR = (bitString) => {
  const ir = {}

  // Remove leading zeroes
  const first1Index = bitString.indexOf('1')
  const shortBitString = bitString.slice(first1Index)

  //
  const bitReader = new BitReader(shortBitString)

  // Bit lengths
  ir.posBitLength = bitReader.read(5)
  ir.xDeltaBitLength = bitReader.read(5)
  ir.yOffsetBitLength = bitReader.read(5)

  // Initial position (optional)
  if (ir.posBitLength > 0) {
    const signOffset = getSignOffset(ir.posBitLength)

    ir.xInitial = bitReader.read(ir.posBitLength) - signOffset
    ir.yInitial = bitReader.read(ir.posBitLength) - signOffset
  } else {
    ir.xInitial = null
    ir.yInitial = null
  }

  // Types
  const typeCount = bitReader.read(4)

  ir.types = Array(typeCount)
    .fill()
    .map(_ => bitReader.read(4))

  const {
    typeIndexBitLength,
    typeStopIndex,
  } = getTypeIndexInfo(typeCount)

  // Corners
  ir.corners = []

  let xPos = ir.xInitial !== null ? ir.xInitial  : 0
  let isFirst = true
  while (bitReader.left > 0) {
    const corner = {}

    if (!isFirst) {
      corner.isMoveX = Boolean(bitReader.read(1))

      if (corner.isMoveX) {
        corner.xDelta = bitReader.read(ir.xDeltaBitLength)
        xPos += corner.xDelta
      } else {
        corner.xDelta = null;
      }
    } else {
      corner.isMoveX = null;
      corner.xDelta = null;
      isFirst = false;
    }

    if (ir.yOffsetBitLength > 0) {
      corner.yOffset = bitReader.read(ir.yOffsetBitLength)
    } else {
      corner.yOffset = null
    }

    corner.hasGround = Boolean(bitReader.read(1))

    // Voxels
    corner.voxels = []

    // TODO: Is this maybe 254? Height starts at 1!
    while (corner.voxels.length <= 255) {
      const typeIndex = bitReader.read(typeIndexBitLength)

      if (typeIndex == typeStopIndex) {
        break
      }

      const typeIndexZeroBased = typeIndex - 1

      if (typeIndex < 0 || typeIndexZeroBased >= typeCount) {
        const yInitial = ir.yInitial !== null ? ir.yInitial : 0
        const yOffset = corner.yOffset !== null ? corner.yOffset : 0
        const yPos = yInitial + yOffset

        throw new Error(`Invalid voxel type ${typeIndexZeroBased}/${typeCount} at (${xPos}, ${yPos}, ${corner.voxels.length}) near bit ${bitReader.cursor}`)
      }

      corner.voxels.push(typeIndexZeroBased)
    }

    ir.corners.push(corner)
  }

  return ir
}

const bits = (value, bitLength) => {
  if (value < 0) {
    throw new Error(`Trying to get bits for negative value ${value}`)
  }

  const maxValue = getMaxValue(bitLength)

  if (value > maxValue) {
    throw new Error(`Trying to get bits for too large value ${value} (max ${maxValue})`)
  }

  return value
    .toString(2)
    .padStart(bitLength, '0')
}

const escape = number =>
  number
    .toString()
    .replace(/0/g, 'O')
    .replace(/1/g, 'l')

// TODO: Annotate flag
const irToBitString = (ir) => {
  let outString = ''
  let annotatedString = ''

  // Bit lengths
  outString = bits(ir.posBitLength, 5) + outString
  outString = bits(ir.xDeltaBitLength, 5) + outString
  outString = bits(ir.yOffsetBitLength, 5) + outString

  annotatedString = '>' + annotatedString
  annotatedString = `po=${bits(ir.posBitLength, 5)}[${escape(ir.posBitLength)}]` + annotatedString
  annotatedString = `dx=${bits(ir.xDeltaBitLength, 5)}[${escape(ir.xDeltaBitLength)}] ` + annotatedString
  annotatedString = `+y=${bits(ir.yOffsetBitLength, 5)}[${escape(ir.yOffsetBitLength)}] ` + annotatedString
  annotatedString = '<' + annotatedString

  // Initial position (optional)
  if (ir.posBitLength > 0) {
    const signOffset = getSignOffset(ir.posBitLength)

    outString = bits(ir.xInitial + signOffset, ir.posBitLength) + outString
    outString = bits(ir.yInitial + signOffset, ir.posBitLength) + outString

    annotatedString = '> ' + annotatedString
    annotatedString = `x=${bits(ir.xInitial + signOffset, ir.posBitLength)}[${escape(ir.xInitial)}]` + annotatedString
    annotatedString = `x=${bits(ir.yInitial + signOffset, ir.posBitLength)}[${escape(ir.yInitial)}]` + annotatedString
    annotatedString = '<' + annotatedString
  }

  // Types
  // Notice 0b1110 because type 0b1111 (getMaxValue(4)) is reserved for ground
  // TODO: Test what Townscape does with 0b1111 types
  if (ir.types.length > 0b1110) {
    throw new Error(`Invalid types.length ${ir.types.length}, max ${0b1110}`)
  }
  outString = bits(ir.types.length, 4) + outString
  annotatedString = `(${bits(ir.types.length, 4)})> ` + annotatedString

  for (const type of ir.types) {
    // Notice 0b1110 because type 0b1111 (getMaxValue(4)) is reserved for ground
    // TODO: Test what Townscape does with 0b1111 type value
    if (ir.types.length < 0 || ir.types.length > 0b1110) {
      throw new Error(`Invalid types.length[${i}] ${ir.types.length[i]}, max ${0b1110}`)
    }
    outString = bits(type, 4) + outString
    annotatedString = `${bits(type, 4)} ` + annotatedString
  }

  annotatedString = `<` + annotatedString

  const {
    typeIndexBitLength,
    typeStopIndex,
  } = getTypeIndexInfo(ir.types.length)

  // Corners
  let isFirst = true

  for (const corner of ir.corners) {
    annotatedString = '| ' + annotatedString

    if (!isFirst) {
      outString = (corner.isMoveX ? '1' : '0') + outString
      annotatedString = `(dx?${corner.isMoveX ? '1' : '0'}) ` + annotatedString

      if (corner.isMoveX) {
        if (ir.xDeltaBitLength === 0) {
          throw new Error('isMoveX with xDeltaBitLength === 0')
        }

        outString = bits(corner.xDelta, ir.xDeltaBitLength) + outString
        annotatedString = `(dx${bits(corner.xDelta, ir.xDeltaBitLength)}[${escape(corner.xDelta)}]) ` + annotatedString
      }
    } else {
      if (corner.isMoveX) {
        throw new Error('isMoveX on first corner')
      }

      if (corner.xDelta !== null) {
        throw new Error('xDelta on first corner')
      }

      isFirst = false
    }

    if (ir.yOffsetBitLength > 0) {
      outString = bits(corner.yOffset, ir.yOffsetBitLength) + outString
      annotatedString = `(+y${bits(corner.yOffset, ir.yOffsetBitLength)}[${escape(corner.yOffset)}]) ` + annotatedString
    }

    outString = (corner.hasGround ? '1' : '0') + outString
    annotatedString = `(g?${corner.hasGround ? '1' : '0'}) ` + annotatedString

    // Voxels
    // TODO: Is this maybe 254? Height starts at 1!
    if (corner.voxels.length > 255) {
      throw new Error(`Too many voxels (${corner.voxels.length}), max 255`)
    }

    for (const typeIndexZeroBased of corner.voxels) {
      outString = bits(typeIndexZeroBased + 1, typeIndexBitLength) + outString
      annotatedString = `${bits(typeIndexZeroBased + 1, typeIndexBitLength)} ` + annotatedString
    }

    outString = bits(typeStopIndex, typeIndexBitLength) + outString
    annotatedString = `${bits(typeStopIndex, typeIndexBitLength)} ` + annotatedString
  }

  // Padding
  const paddingLength = (6 - (outString.length % 6)) % 6

  if (paddingLength > 0) {
    const padding = Array(paddingLength)
      .fill()
      .map(_ => '0')
      .join('')

    outString = padding + outString
    annotatedString = `<${padding}> | ` + annotatedString
  }

  //
  return `"${annotatedString}"`
}

module.exports = {
  bitStringToIR,
  irToBitString,
  getMaxValue,
}
