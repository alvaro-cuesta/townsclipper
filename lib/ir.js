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

const getBitLength = (maxValue) => Math.ceil(Math.log2(maxValue + 1))

const getSignedBitLength = (minValue, maxValue) => {
  if (minValue === 0 && maxValue === 0) {
    return 0
  }

  const unsignedMaxValue = Math.max(
    minValue < 0 ? Math.abs(minValue) : minValue + 1,
    maxValue < 0 ? Math.abs(maxValue) : maxValue + 1,
  )

  return getBitLength(unsignedMaxValue * 2 - 1)
}

const getTypeIndexInfo = (typeCount) => {
  const typeIndexBitLength = getBitLength(typeCount + 1)
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
  const posBitLength = bitReader.read(5)
  const xDeltaBitLength = bitReader.read(5)
  const yOffsetBitLength = bitReader.read(5)

  // Initial position (optional)
  if (posBitLength > 0) {
    const signOffset = getSignOffset(posBitLength)

    ir.xInitial = bitReader.read(posBitLength) - signOffset
    ir.yInitial = bitReader.read(posBitLength) - signOffset
  } else {
    ir.xInitial = 0
    ir.yInitial = 0
  }

  // Types
  const typeCount = bitReader.read(4)

  // TODO: Maybe check typeCount length? (What happens with 0b1111?)

  ir.types = Array(typeCount)
    .fill()
    // TODO: Maybe check type values? (What happens with 0b1111?)
    .map(_ => bitReader.read(4))

  const {
    typeIndexBitLength,
    typeStopIndex,
  } = getTypeIndexInfo(typeCount)

  // Corners
  ir.corners = []

  let xPos = ir.xInitial
  let isFirst = true
  while (bitReader.left > 0) {
    const corner = {}

    if (!isFirst) {
      const isMoveX = Boolean(bitReader.read(1))

      if (isMoveX) {
        corner.xDelta = bitReader.read(xDeltaBitLength)
        xPos += corner.xDelta
      } else {
        corner.xDelta = null;
      }
    } else {
      corner.xDelta = null;
      isFirst = false;
    }

    if (yOffsetBitLength > 0) {
      corner.yOffset = bitReader.read(yOffsetBitLength)
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
        const yOffset = corner.yOffset !== null ? corner.yOffset : 0
        const yPos = ir.yInitial + yOffset

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

  // Detect bit lengths from values
  const posBitLength = getSignedBitLength(
    Math.min(ir.xInitial, ir.yInitial),
    Math.max(ir.xInitial, ir.yInitial),
  )

  let maxXDelta = 0, maxYOffset = 0

  for (const corner of ir.corners) {
    maxXDelta = Math.max(maxXDelta, corner.xDelta)
    maxYOffset = Math.max(maxYOffset, corner.yOffset)
  }

  const xDeltaBitLength = getBitLength(maxXDelta)
  const yOffsetBitLength = getBitLength(maxYOffset)

  // Bit lengths
  outString = bits(posBitLength, 5) + outString
  outString = bits(xDeltaBitLength, 5) + outString
  outString = bits(yOffsetBitLength, 5) + outString

  annotatedString = '>' + annotatedString
  annotatedString = `po=${bits(posBitLength, 5)}[${escape(posBitLength)}]` + annotatedString
  annotatedString = `dx=${bits(xDeltaBitLength, 5)}[${escape(xDeltaBitLength)}] ` + annotatedString
  annotatedString = `+y=${bits(yOffsetBitLength, 5)}[${escape(yOffsetBitLength)}] ` + annotatedString
  annotatedString = '<' + annotatedString

  // Initial position (optional)
  if (posBitLength > 0) {
    const signOffset = getSignOffset(posBitLength)

    outString = bits(ir.xInitial + signOffset, posBitLength) + outString
    outString = bits(ir.yInitial + signOffset, posBitLength) + outString

    annotatedString = '> ' + annotatedString
    annotatedString = `x=${bits(ir.xInitial + signOffset, posBitLength)}[${escape(ir.xInitial)}]` + annotatedString
    annotatedString = `x=${bits(ir.yInitial + signOffset, posBitLength)}[${escape(ir.yInitial)}]` + annotatedString
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
      outString = (corner.xDelta ? '1' : '0') + outString
      annotatedString = `(dx?${corner.xDelta ? '1' : '0'}) ` + annotatedString

      if (corner.xDelta) {
        if (xDeltaBitLength === 0) {
          throw new Error('xDelta with xDeltaBitLength === 0')
        }

        outString = bits(corner.xDelta, xDeltaBitLength) + outString
        annotatedString = `(dx${bits(corner.xDelta, xDeltaBitLength)}[${escape(corner.xDelta)}]) ` + annotatedString
      }
    } else {
      if (corner.xDelta) {
        throw new Error('xDelta on first corner')
      }

      isFirst = false
    }

    if (yOffsetBitLength > 0) {
      outString = bits(corner.yOffset, yOffsetBitLength) + outString
      annotatedString = `(+y${bits(corner.yOffset, yOffsetBitLength)}[${escape(corner.yOffset)}]) ` + annotatedString
    }

    outString = (corner.hasGround ? '1' : '0') + outString
    annotatedString = `(g?${corner.hasGround ? '1' : '0'}) ` + annotatedString

    // Voxels
    // TODO: Is this maybe 254? Height starts at 1!
    if (corner.voxels.length > 255) {
      throw new Error(`Too many voxels (${corner.voxels.length}), max 255`)
    }

    for (const typeIndexZeroBased of corner.voxels) {
      if (typeIndexZeroBased < -1 || typeIndexZeroBased >= ir.types.length) {
        throw new Error(`Invalid type ${typeIndexZeroBased}, min 0, max ${ir.types.length}`)
      }

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
