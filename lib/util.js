const { BITS_PER_CHAR } = require('./clip-bits')

// Remove any non-0/1 characters
const cleanBitString = (bitString) =>
  bitString
    .replace(/[^01]/g, '')

// Remove any non-base64url
const cleanClipString = (clipString) =>
  clipString
    .replace(/[^A-Za-z0-9_\-]/g, '')


// Add zero-padding to a multiple of BITS_PER_CHAR. Ignores non-0/1 characters
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

// Remove zero-padding from a bit string. Assumes no extranous characters.
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
