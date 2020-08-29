const { BITS_PER_CHAR } = require('./clip-bits')

const cleanBitString = (bitString) =>
  bitString
    .replace(/[^01]/g, '')

const cleanClipString = (clipString) =>
  clipString
    .replace(/[^A-Za-z0-9_\-]/g, '')

const padInputBitString = (bitString) => {
  const inputBits = cleanBitString(bitString)

  const paddingLength = (BITS_PER_CHAR - (inputBits.length % BITS_PER_CHAR)) % BITS_PER_CHAR

  if (paddingLength > 0) {
    const paddingBits = Array(paddingLength)
      .fill()
      .map(_ => '0')
      .join('')

    return paddingBits + bitString
  }

  return bitString
}

const removePadding = (bitString) => {
  const first1Index = bitString.indexOf('1')

  if (first1Index === -1) {
    return ''
  }

  return bitString.slice(first1Index)
}

module.exports = {
  cleanBitString,
  cleanClipString,
  padInputBitString,
  removePadding,
}
