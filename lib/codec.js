const ALPHABET = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvxyzw0123456789_-'
const BITS_PER_CHAR = 6

// Decode a saveString into a bit field
const decodeSaveString = (string) => string
  .split('')
  .filter(x => ALPHABET.includes(x))
  .map(x => ALPHABET.indexOf(x).toString(2).padStart(BITS_PER_CHAR, '0'))
  .join('')

// Encode a bit string (0s and 1s) into a save string
// Is lenient with input: cleans non-0/1 chars beforehand
const encodeBitString = (bitString) => {
  const cleanBitString = bitString.replace(/[^01]/g, '')

  if ((cleanBitString.length % BITS_PER_CHAR) !== 0) {
    throw new Error(`Bit string length (${cleanBitString.length}) must be a multiple of ${BITS_PER_CHAR}`)
  }

  return Array(cleanBitString.length / BITS_PER_CHAR)
    .fill()
    .map((_, i) => {
      const bits = cleanBitString
        .slice(i * BITS_PER_CHAR, (i + 1) * BITS_PER_CHAR)

      const value = parseInt(bits, 2)

      return ALPHABET[value]
    })
    .join('')
}

module.exports = {
  decodeSaveString,
  encodeBitString,
}
