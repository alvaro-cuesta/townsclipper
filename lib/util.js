const { BITS_PER_CHAR } = require('./clip-bits')

// Remove any non-0/1 characters
const cleanBits = (bits) =>
  bits
    .replace(/[^01]/g, '')

// Remove any non-base64url
const cleanClip = (clip) =>
  clip
    .replace(/[^A-Za-z0-9_\-]/g, '')


// Add zero-padding to a multiple of BITS_PER_CHAR. Ignores non-0/1 characters
const padInputBits = (bits) => {
  const inputBits = cleanBits(bits)

  const paddingLength = (BITS_PER_CHAR - (inputBits.length % BITS_PER_CHAR)) % BITS_PER_CHAR

  if (paddingLength > 0) {
    const paddingBits = Array(paddingLength)
      .fill()
      .map(_ => '0')
      .join('')

    return paddingBits + bits
  }

  return bits
}

// Remove zero-padding from a bit string. Assumes no extranous characters.
const removePadding = (bits) => {
  const first1Index = bits.indexOf('1')

  if (first1Index === -1) {
    return ''
  }

  return bits.slice(first1Index)
}

module.exports = {
  cleanBits,
  cleanClip,
  padInputBits,
  removePadding,
}
