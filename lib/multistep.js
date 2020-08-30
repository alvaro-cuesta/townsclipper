// Helper multistep conversion functions
const { clipToBits, bitsToClip } = require('./clip-bits')
const { bitsToDense, denseToBits } = require('./bits-dense')
const { denseToSparse, sparseToDense } = require('./dense-sparse')
const {
  cleanBits,
  cleanClip,
  padInputBits,
  removePadding,
} = require('./util')

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

const CONVERSIONS = {
  clip: {
    bits: clipToBits,
    dense: clipToDense,
    sparse: clipToSparse,
  },

  bits: {
    clip: bitsToClip,
    dense: bitsToDense,
    sparse: bitsToSparse,
  },

  dense: {
    clip: denseToClip,
    bits: denseToBits,
    sparse: denseToSparse,
  },

  sparse: {
    clip: sparseToClip,
    bits: sparseToBits,
    dense: sparseToDense,
  }
}

const convertToString = (from, to, input, options = {}) => {
  const {
    pretty = false,
    keepPadding = false,
    strictInPadding = false,
    strictInAlphabet = false,
  } = options

  // Input
  switch (from) {
    case 'clip': {
      if (strictInAlphabet) {
        input = input.trim()
      } else {
        input = cleanClip(input)
      }

      break
    }

    case 'bits': {
      if (strictInAlphabet) {
        input = input.trim()
      } else {
        input = cleanBits(input)
      }

      if (!strictInPadding) {
        input = padInputBits(input)
      }

      break
    }

    case 'dense':
    case 'sparse': {
      input = JSON.parse(input)

      break
    }

    default: {
      throw new Error('Unreachable')
    }
  }

  // Convert
  const conversion = CONVERSIONS[from][to]

  if (conversion) {
    input = conversion(input)
  }

  // Output
  switch (to) {
    case 'clip': {
      return input
    }

    case 'bits': {
      if (pretty) {
        input = bitsToDense(input)
        input = denseToBits(input, { pretty: true, pad: keepPadding })
        return `"${input}"`
      }

      if (!keepPadding) {
        return removePadding(input)
      }

      return input
    }

    case 'dense':
    case 'sparse': {
      return JSON.stringify(input, null, pretty ? 2 : undefined)
    }

    default: {
      throw new Error('Unreachable')
    }
  }
}

module.exports = {
  clipToDense,
  denseToClip,
  bitsToSparse,
  sparseToBits,
  sparseToClip,
  clipToSparse,
  convertToString,
}
