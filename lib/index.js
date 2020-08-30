const {
  clipStringToBitString,
  bitStringToClipString,
  BITS_PER_CHAR,
} = require('./clip-bits')

const {
  bitStringToDense,
  denseToBitString,
} = require('./bits-dense')

const {
  denseToSparse,
  sparseToDense,
} = require('./dense-sparse')

const {
  cleanBitString,
  cleanClipString,
  padInputBitString,
  removePadding,
} = require('./util')

const {
  EMPTY_TYPE,
  GROUND_TYPE,
  MAX_TYPE_COUNT,
  MAX_TYPE,
  MAX_HEIGHT,
} = require('./constants')

const {
  VALID_CORNERS,
} = require('./valid-corners')

module.exports = {
  clipStringToBitString,
  bitStringToClipString,
  BITS_PER_CHAR,

  bitStringToDense,
  denseToBitString,

  denseToSparse,
  sparseToDense,

  cleanBitString,
  cleanClipString,
  padInputBitString,
  removePadding,

  EMPTY_TYPE,
  GROUND_TYPE,
  MAX_TYPE_COUNT,
  MAX_TYPE,
  MAX_HEIGHT,

  VALID_CORNERS,
}
