const {
  clipStringToBitString,
  bitStringToClipString,
  BITS_PER_CHAR,
} = require('./clipstring')

const {
  bitStringToDense,
  denseToBitString,
} = require('./dense')

const {
  denseToSparse,
  sparseToDense,
} = require('./sparse')

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
}
