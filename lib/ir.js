const { BITS_PER_CHAR } = require('./savestring')
const { MAX_HEIGHT, MAX_TYPE_COUNT, MAX_TYPE, EMPTY_TYPE } = require('./constants')

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
  const typeStopIndex = getMaxValue(typeIndexBitLength)

  return {
    typeIndexBitLength,
    typeStopIndex,
  }
}

const BIT_LENGTH_BIT_LENGTH = 5
const TYPE_COUNT_BIT_LENGTH = getBitLength(MAX_TYPE_COUNT - 1)
const TYPE_BIT_LENGTH = getBitLength(MAX_TYPE)
const BOOLEAN_BIT_LENGTH = 1

const bitStringToIR = (bitString) => {
  const ir = {}

  // Remove leading zeroes
  const first1Index = bitString.indexOf('1')
  const shortBitString = bitString.slice(first1Index)

  //
  const bitReader = new BitReader(shortBitString)

  // Bit lengths
  const posBitLength = bitReader.read(BIT_LENGTH_BIT_LENGTH)
  const xDeltaBitLength = bitReader.read(BIT_LENGTH_BIT_LENGTH)
  const yOffsetBitLength = bitReader.read(BIT_LENGTH_BIT_LENGTH)

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
  const typeCount = bitReader.read(TYPE_COUNT_BIT_LENGTH)

  ir.types = Array(typeCount)
    .fill()
    .map(_ => {
      const type = bitReader.read(TYPE_BIT_LENGTH)

      if (type > MAX_TYPE) {
        throw new Error(`Invalid voxel type ${type}, max ${MAX_TYPE}`)
      }

      return type
    })

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
      const isMoveX = Boolean(bitReader.read(BOOLEAN_BIT_LENGTH))

      if (isMoveX) {
        corner.xDelta = bitReader.read(xDeltaBitLength)
        xPos += corner.xDelta
      } else {
        corner.xDelta = 0;
      }
    } else {
      corner.xDelta = null;
      isFirst = false;
    }

    if (yOffsetBitLength > 0) {
      corner.yOffset = bitReader.read(yOffsetBitLength)
    } else {
      corner.yOffset = 0
    }

    corner.hasGround = Boolean(bitReader.read(BOOLEAN_BIT_LENGTH))

    // Voxels
    corner.voxels = []

    while (true) {
      const typeIndex = bitReader.read(typeIndexBitLength)

      if (typeIndex == typeStopIndex) {
        break
      }

      // Technically the game only rejects if we reach exactly MAX_HEIGHT, otherwise it
      // wraps around. I considered it a nonfeature.
      if (corner.voxels.length === MAX_HEIGHT) {
        throw new Error(`Expected end of voxels, reached max height (${MAX_HEIGHT})`)
      }

      const typeIndexZeroBased = typeIndex - 1

      if (typeIndex < 0 || typeIndexZeroBased >= typeCount) {
        const yPos = ir.yInitial + corner.yOffset
        throw new Error(`Invalid voxel type ${typeIndexZeroBased}/${typeCount} at (${xPos}, ${yPos}, ${corner.voxels.length + 1}) near bit ${bitReader.cursor}`)
      }

      corner.voxels.push(typeIndexZeroBased)
    }

    if (corner.hasGround || corner.voxels.length > 0) {
      ir.corners.push(corner)
    }
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
  const posBitLengthBits = bits(posBitLength, BIT_LENGTH_BIT_LENGTH)
  const xDeltaBitLengthBits = bits(xDeltaBitLength, BIT_LENGTH_BIT_LENGTH)
  const yOffsetBitLengthBits = bits(yOffsetBitLength, BIT_LENGTH_BIT_LENGTH)

  outString =
      yOffsetBitLengthBits
    + xDeltaBitLengthBits
    + posBitLengthBits
    + outString

  annotatedString =
      '<'
    + `+y=${yOffsetBitLengthBits}[${escape(yOffsetBitLength)}] `
    + `dx=${xDeltaBitLengthBits}[${escape(xDeltaBitLength)}] `
    + `po=${posBitLengthBits}[${escape(posBitLength)}]`
    + '>'
    + annotatedString

  // Initial position (optional)
  if (posBitLength > 0) {
    const signOffset = getSignOffset(posBitLength)

    const xInitialBits = bits(ir.xInitial + signOffset, posBitLength)
    const yInitialBits = bits(ir.yInitial + signOffset, posBitLength)

    outString =
        yInitialBits
      + xInitialBits
      + outString

    annotatedString =
        '<'
      + `y=${yInitialBits}[${escape(ir.yInitial)}] `
      + `x=${xInitialBits}[${escape(ir.xInitial)}]`
      + '> '
      + annotatedString
  }

  // Types
  if (ir.types.length > MAX_TYPE_COUNT) {
    throw new Error(`Invalid types.length ${ir.types.length}, max ${MAX_TYPE_COUNT}`)
  }

  const typeCountBits = bits(ir.types.length, TYPE_COUNT_BIT_LENGTH)
  outString = typeCountBits + outString
  annotatedString = `(${typeCountBits})> ` + annotatedString

  for (const type of ir.types) {
    if (type < 0 || type > MAX_TYPE) {
      throw new Error(`Invalid type ${type}, max ${MAX_TYPE}`)
    }

    const typeBits = bits(type, TYPE_BIT_LENGTH)
    outString = typeBits + outString
    annotatedString = `${typeBits} ` + annotatedString
  }

  annotatedString = '<' + annotatedString

  const {
    typeIndexBitLength,
    typeStopIndex,
  } = getTypeIndexInfo(ir.types.length)

  // Corners
  let isFirst = true

  for (const corner of ir.corners) {
    if (!corner.hasGround && corner.voxels.length === 0) {
      continue
    }

    annotatedString = '| ' + annotatedString

    if (!isFirst) {
      const hasXDeltaBits = bits(corner.xDelta ? 1 : 0, BOOLEAN_BIT_LENGTH)
      outString = hasXDeltaBits + outString
      annotatedString = `(dx?${hasXDeltaBits}) ` + annotatedString

      if (corner.xDelta) {
        const xDeltaBits = bits(corner.xDelta, xDeltaBitLength)
        outString = xDeltaBits + outString
        annotatedString = `(dx${xDeltaBits}[${escape(corner.xDelta)}]) ` + annotatedString
      }
    } else {
      if (corner.xDelta !== null) {
        throw new Error('xDelta on first corner')
      }

      isFirst = false
    }

    if (yOffsetBitLength > 0) {
      const yOffsetBits = bits(corner.yOffset, yOffsetBitLength)
      outString = yOffsetBits + outString
      annotatedString = `(+y${yOffsetBits}[${escape(corner.yOffset)}]) ` + annotatedString
    }

    const hasGroundBits = bits(corner.hasGround ? 1 : 0, BOOLEAN_BIT_LENGTH)
    outString = hasGroundBits + outString
    annotatedString = `(g?${hasGroundBits}) ` + annotatedString

    // Voxels
    if (corner.voxels.length > MAX_HEIGHT) {
      throw new Error(`Too many voxels (${corner.voxels.length}), max ${MAX_HEIGHT}`)
    }

    for (const typeIndexZeroBased of corner.voxels) {
      if (typeIndexZeroBased < EMPTY_TYPE || typeIndexZeroBased >= ir.types.length) {
        throw new Error(`Invalid type ${typeIndexZeroBased}, min 0, max ${ir.types.length}`)
      }

      const typeIndexZeroBasedBits = bits(typeIndexZeroBased + 1, typeIndexBitLength)
      outString = typeIndexZeroBasedBits + outString
      annotatedString = `${typeIndexZeroBasedBits} ` + annotatedString
    }

    const typeStopIndexBits = bits(typeStopIndex, typeIndexBitLength)
    outString = typeStopIndexBits + outString
    annotatedString = `${typeStopIndexBits} ` + annotatedString
  }

  // Padding
  const paddingLength = (BITS_PER_CHAR - (outString.length % BITS_PER_CHAR)) % BITS_PER_CHAR

  if (paddingLength > 0) {
    const paddingBits = Array(paddingLength)
      .fill()
      .map(_ => '0')
      .join('')

    outString = paddingBits + outString
    annotatedString = `<${paddingBits}> | ` + annotatedString
  }

  //
  return `"${annotatedString}"`
}

module.exports = {
  bitStringToIR,
  irToBitString,
}
