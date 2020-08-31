const {
  clipToBits,
  bitsToClip,
  BITS_PER_CHAR,
} = require('./clip-bits')

const {
  bitsToDense,
  denseToBits,
} = require('./bits-dense')

const {
  denseToSparse,
  sparseToDense,
} = require('./dense-sparse')

const {
  clipToDense,
  denseToClip,
  bitsToSparse,
  sparseToBits,
  sparseToClip,
  clipToSparse,
  convertToString,
} = require('./multistep')

const {
  cleanBits,
  cleanClip,
  padInputBits,
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
  clipToBits,
  bitsToClip,
  BITS_PER_CHAR,

  bitsToDense,
  denseToBits,

  denseToSparse,
  sparseToDense,

  clipToDense,
  denseToClip,
  bitsToSparse,
  sparseToBits,
  sparseToClip,
  clipToSparse,
  convertToString,

  cleanBits,
  cleanClip,
  padInputBits,
  removePadding,

  EMPTY_TYPE,
  GROUND_TYPE,
  MAX_TYPE_COUNT,
  MAX_TYPE,
  MAX_HEIGHT,
}
