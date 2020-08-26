// IMPORTANT NOTES:
//
// Input looks like base64url but IT IS NOT! Notice the alphabet's out-of-order "w"
// and the swapped "_" and "-" when compared to RFC 4648 §5.
//
// Townscaper decodes savestrings left-to-right and LSB first (both in BitArray index
// and character bits). This means the "base64" output is reversed too.
//
// We en/decode bit strings MSB to LSB assuming significativity matches BitArray index
// i.e. higher BitArray index to the left.
//
// This is speculatie though. Maybe we don't have to reverse the whole string, but only
// the inidivual characters, but it makes sense like this since color bits can be read
// naturally on the string.
const ALPHABET = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvxyzw0123456789_-'
const BITS_PER_CHAR = 6

// Decode a saveString into a bit field
const decodeSaveString = (string) => string
  .split('')
  .filter(x => ALPHABET.includes(x))
  .reverse()
  .map(x => ALPHABET
    .indexOf(x)
    .toString(2)
    .padStart(BITS_PER_CHAR, '0'))
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
    .reverse()
    .join('')
}

module.exports = {
  decodeSaveString,
  encodeBitString,
}
