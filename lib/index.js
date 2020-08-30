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

const {
  VALID_CORNERS,
} = require('./valid-corners')


const clipToDense = (clip) =>
  bitsToDense(clipToBits(clip))

const denseToClip = (dense) =>
  bitsToClip(denseToBits(dense))

const bitsToSparse = (bits) =>
  denseToSparse(bitsToDense(bits))

const sparseToBits = (sparse, options) =>
  denseToBits(sparseToDense(sparse), options)

const sparseToClip = (sparse) =>
  bitsToClip(sparseToBits(sparse))

const clipToSparse = (clip) =>
  denseToSparse(clipToDense(clip))

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

  cleanBits,
  cleanClip,
  padInputBits,
  removePadding,

  EMPTY_TYPE,
  GROUND_TYPE,
  MAX_TYPE_COUNT,
  MAX_TYPE,
  MAX_HEIGHT,

  VALID_CORNERS,
}
