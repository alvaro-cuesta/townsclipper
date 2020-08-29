const {
  saveStringToBitString,
  bitStringToSaveString,
  BITS_PER_CHAR,
} = require('./savestring')

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
  cleanSaveString,
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
  saveStringToBitString,
  bitStringToSaveString,
  BITS_PER_CHAR,

  bitStringToDense,
  denseToBitString,

  denseToSparse,
  sparseToDense,

  cleanBitString,
  cleanSaveString,
  padInputBitString,
  removePadding,

  EMPTY_TYPE,
  GROUND_TYPE,
  MAX_TYPE_COUNT,
  MAX_TYPE,
  MAX_HEIGHT,
}
