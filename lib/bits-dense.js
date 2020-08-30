const { removePadding } = require('./util')
const { BITS_PER_CHAR } = require('./clip-bits')
const { MAX_HEIGHT, MAX_TYPE_COUNT, MAX_TYPE, EMPTY_TYPE } = require('./constants')

const REGEX_TEST_BITSTRING = /^[01]+$/

// Read uints in chunks from a bit string in right-to-left order.
class BitReader {
  constructor(bits) {
    if (!REGEX_TEST_BITSTRING.test(bits)) {
      throw new Error('BitReader only accepts strings with 0/1')
    }

    this.bits = bits
    this.cursor = 0
  }

  read(n, lenient = false) {
    if (n === 0) {
      throw new Error('Trying to read zero bytes')
    }

    if (this.remaining < n && !lenient) {
      throw new Error(`Could not read ${n} bits (only ${this.remaining} remaining) at position ${this.cursor}`)
    }

    const bits = this.bits.slice(
      -this.cursor - n,
      this.cursor > 0 ? -this.cursor : undefined,
    )

    this.cursor += n

    if (bits.length === 0) {
      return 0
    }

    return parseInt(bits, 2)
  }

  get remaining() {
    return this.bits.length - this.cursor
  }
}

// Given a signed int bit length, get the number to subtract from the raw uint
// to transform it into its signed value.
//
// https://en.wikipedia.org/wiki/Offset_binary
const getSignOffset = (bitLength) => 1 << (bitLength - 1)

// Get the max value representable with some bit length.
const getMaxValue = (bitLength) => (1 << bitLength) - 1

// Get the bit length needed to represent some max value.
const getBitLength = (maxValue) => Math.ceil(Math.log2(maxValue + 1))

// Get the bit length needed to represent some max value in "offset binary"
// form (see getSignOffset).
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

// Get info for the type list indices. Used in voxel lists to index the types.
const getTypeIndexInfo = (typeCount) => {
  const typeIndexBitLength = getBitLength(typeCount + 1)
  const typeStopIndex = getMaxValue(typeIndexBitLength)

  return {
    typeIndexBitLength,
    typeStopIndex,
  }
}

// Constants
const BIT_LENGTH_BIT_LENGTH = 5
const TYPE_COUNT_BIT_LENGTH = getBitLength(MAX_TYPE_COUNT - 1)
const TYPE_BIT_LENGTH = getBitLength(MAX_TYPE)
const BOOLEAN_BIT_LENGTH = 1

const bitsToDense = (bits) => {
  if (bits.length % 6 !== 0) {
    throw new Error(`Bit string length (${bits.length}) must be a multiple of 6`)
  }

  const dense = {}
  const bitReader = new BitReader(removePadding(bits))

  // Bit lengths
  const posBitLength = bitReader.read(BIT_LENGTH_BIT_LENGTH)
  const xDeltaBitLength = bitReader.read(BIT_LENGTH_BIT_LENGTH)
  const yOffsetBitLength = bitReader.read(BIT_LENGTH_BIT_LENGTH)

  // Initial position (optional)
  if (posBitLength > 0) {
    const signOffset = getSignOffset(posBitLength)

    dense.xInitial = bitReader.read(posBitLength) - signOffset
    dense.yInitial = bitReader.read(posBitLength) - signOffset
  } else {
    dense.xInitial = 0
    dense.yInitial = 0
  }

  // Types
  const typeCount = bitReader.read(TYPE_COUNT_BIT_LENGTH)

  dense.types = Array(typeCount)
    .fill()
    .map(_ => {
      const type = bitReader.read(TYPE_BIT_LENGTH)

      if (type > MAX_TYPE) {
        throw new Error(`Invalid voxel type ${type}, max ${MAX_TYPE} near bit ${bitReader.cursor}`)
      }

      return type
    })

  const {
    typeIndexBitLength,
    typeStopIndex,
  } = getTypeIndexInfo(typeCount)

  // Corners
  dense.corners = []

  let xPos = dense.xInitial
  let isFirst = true
  while (bitReader.remaining > 0) {
    const corner = {}

    // First corner does not have xDelta (0 assumed)
    if (isFirst) {
      corner.xDelta = null;
      isFirst = false;
    } else {
      const isMoveX = Boolean(bitReader.read(BOOLEAN_BIT_LENGTH))

      if (isMoveX && xDeltaBitLength > 0) {
        corner.xDelta = bitReader.read(xDeltaBitLength)
        xPos += corner.xDelta
      } else {
        corner.xDelta = 0;
      }
    }

    if (yOffsetBitLength > 0) {
      corner.yOffset = bitReader.read(yOffsetBitLength)
    } else {
      corner.yOffset = 0
    }

    corner.hasGround = Boolean(bitReader.read(BOOLEAN_BIT_LENGTH))

    // Voxels
    corner.voxels = []

    while (corner.voxels.length < MAX_HEIGHT) {
      // Special case: when reading the last voxel in the last corner, if it is located exactly
      // at MAX_HEIGHT, the next typeStopIndex will be omitted. If we're trying to read a
      // typeIndex that has leading zeroes, given that there's no '1' from typeStopIndex, we
      //  might have removed the leading 0s as if they were padding and `.read` will throw.
      //
      // We could always return implicit zeroes from BitReader but then we'd lose the ability to
      // detect wrong reads.
      const typeIndex = bitReader.read(typeIndexBitLength, true)

      if (typeIndex === typeStopIndex) {
        break
      }

      const typeIndexZeroBased = typeIndex - 1

      if (typeIndexZeroBased < EMPTY_TYPE || typeIndexZeroBased >= typeCount) {
        const yPos = dense.yInitial + corner.yOffset
        throw new Error(`Invalid voxel type ${typeIndexZeroBased}/${typeCount} at (${xPos}, ${yPos}, ${corner.voxels.length + 1}) near bit ${bitReader.cursor}`)
      }

      corner.voxels.push(typeIndexZeroBased)
    }

    // Only push the corner if it has voxels
    const nonEmptyVoxels = corner.voxels.filter(x => x !== EMPTY_TYPE)

    if (corner.hasGround || nonEmptyVoxels.length > 0) {
      dense.corners.push(corner)
    }
  }

  return dense
}

// Get the uintN representation of a given value.
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

// Escape a value so we can print it as an annotation without interfering with the actual
// bit string. I.e.: replace 0 and 1 with something similar.
const escape = number =>
  number
    .toString()
    .replace(/0/g, 'O')
    .replace(/1/g, 'l')

const denseToBits = (dense, options = {}) => {
  const {
    pretty = false,
    pad = true,
  } = options

  let outString = ''
  let annotatedString = ''

  // Detect bit lengths from values
  const posBitLength = getSignedBitLength(
    Math.min(dense.xInitial, dense.yInitial),
    Math.max(dense.xInitial, dense.yInitial),
  )

  let maxXDelta = 0, maxYOffset = 0

  for (const corner of dense.corners) {
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

  if (pretty) {
    annotatedString =
        '<'
      + `+y=${yOffsetBitLengthBits}[${escape(yOffsetBitLength)}] `
      + `dx=${xDeltaBitLengthBits}[${escape(xDeltaBitLength)}] `
      + `po=${posBitLengthBits}[${escape(posBitLength)}]`
      + '>'
      + annotatedString
  }

  // Initial position (optional)
  if (posBitLength > 0) {
    const signOffset = getSignOffset(posBitLength)

    const xInitialBits = bits(dense.xInitial + signOffset, posBitLength)
    const yInitialBits = bits(dense.yInitial + signOffset, posBitLength)

    outString =
        yInitialBits
      + xInitialBits
      + outString

    if (pretty) {
      annotatedString =
          '<'
        + `y=${yInitialBits}[${escape(dense.yInitial)}] `
        + `x=${xInitialBits}[${escape(dense.xInitial)}]`
        + '> '
        + annotatedString
    }
  }

  // Types
  if (dense.types.length > MAX_TYPE_COUNT) {
    throw new Error(`Invalid types.length ${dense.types.length}, max ${MAX_TYPE_COUNT}`)
  }

  const typeCountBits = bits(dense.types.length, TYPE_COUNT_BIT_LENGTH)
  outString = typeCountBits + outString
  if (pretty) {
    annotatedString = `(${typeCountBits})> ` + annotatedString
  }

  for (const type of dense.types) {
    if (type < 0 || type > MAX_TYPE) {
      throw new Error(`Invalid type ${type}, max ${MAX_TYPE}`)
    }

    const typeBits = bits(type, TYPE_BIT_LENGTH)
    outString = typeBits + outString
    if (pretty) {
      annotatedString = `${typeBits} ` + annotatedString
    }
  }

  if (pretty) {
    annotatedString = '<' + annotatedString
  }

  const {
    typeIndexBitLength,
    typeStopIndex,
  } = getTypeIndexInfo(dense.types.length)

  // Corners
  let isFirst = true

  for (const corner of dense.corners) {
    if (!corner.hasGround && corner.voxels.length === 0) {
      continue
    }

    if (pretty) {
      annotatedString = '| ' + annotatedString
    }

    // First corner does not have xDelta (must be null)
    if (isFirst) {
      if (corner.xDelta !== null) {
        throw new Error('xDelta on first corner')
      }

      isFirst = false
    } else {
      const hasXDeltaBits = bits(corner.xDelta ? 1 : 0, BOOLEAN_BIT_LENGTH)
      outString = hasXDeltaBits + outString
      if (pretty) {
        annotatedString = `(dx?${hasXDeltaBits}) ` + annotatedString
      }

      if (corner.xDelta) {
        const xDeltaBits = bits(corner.xDelta, xDeltaBitLength)
        outString = xDeltaBits + outString
        if (pretty) {
          annotatedString = `(dx${xDeltaBits}[${escape(corner.xDelta)}]) ` + annotatedString
        }
      }
    }

    if (yOffsetBitLength > 0) {
      const yOffsetBits = bits(corner.yOffset, yOffsetBitLength)
      outString = yOffsetBits + outString
      if (pretty) {
        annotatedString = `(+y${yOffsetBits}[${escape(corner.yOffset)}]) ` + annotatedString
      }
    }

    const hasGroundBits = bits(corner.hasGround ? 1 : 0, BOOLEAN_BIT_LENGTH)
    outString = hasGroundBits + outString
    if (pretty) {
      annotatedString = `(g?${hasGroundBits}) ` + annotatedString
    }

    // Voxels
    if (corner.voxels.length > MAX_HEIGHT) {
      throw new Error(`Too many voxels (${corner.voxels.length}), max ${MAX_HEIGHT}`)
    }

    for (const typeIndexZeroBased of corner.voxels) {
      if (typeIndexZeroBased < EMPTY_TYPE || typeIndexZeroBased >= dense.types.length) {
        throw new Error(`Invalid type ${typeIndexZeroBased}, min 0, max ${dense.types.length}`)
      }

      const typeIndexZeroBasedBits = bits(typeIndexZeroBased + 1, typeIndexBitLength)
      outString = typeIndexZeroBasedBits + outString
      if (pretty) {
        annotatedString = `${typeIndexZeroBasedBits} ` + annotatedString
      }
    }

    // Omit typeStopIndexBits if we reached the max height
    if (corner.voxels.length < MAX_HEIGHT) {
      const typeStopIndexBits = bits(typeStopIndex, typeIndexBitLength)
      outString = typeStopIndexBits + outString
      if (pretty) {
        annotatedString = `${typeStopIndexBits} ` + annotatedString
      }
    }
  }

  // Padding
  if (pad) {
    const paddingLength = (BITS_PER_CHAR - (outString.length % BITS_PER_CHAR)) % BITS_PER_CHAR

    if (paddingLength > 0) {
      const paddingBits = Array(paddingLength)
        .fill()
        .map(_ => '0')
        .join('')

      outString = paddingBits + outString
      if (pretty) {
        annotatedString = `<${paddingBits}> | ` + annotatedString
      }
    }
  }

  //
  return pretty
    ? annotatedString
    : outString
}

module.exports = {
  bitsToDense,
  denseToBits,
}
