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
//
// EDIT + TODO + NOTE: When reading values the index grows from LSB to MSB :/ I.e.
// values are read in RTL order but seem to have SB in order.
const ALPHABET = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvxyzw0123456789_-'
const BITS_PER_CHAR = 6

// Decode a saveString into a bit field
const decodeSaveString = (string) => {
  const bitString = string
    .split('')
    .filter(x => ALPHABET.includes(x))
    .reverse()
    .map(x =>
      ALPHABET
        .indexOf(x)
        .toString(2)
        .padStart(BITS_PER_CHAR, '0')
    )
    .join('')

  const foo1 = bitString.slice(-5)
  const foo2 = bitString.slice(-10, -5)
  const foo3 = bitString.slice(-15, -10)

  let rightString = `${foo3} ${foo2} ${foo1}`
  let foo1Val

  if (foo1.includes('1')) {
    foo1Val = parseInt(foo1, 2)

    const local_8c = bitString.slice(-15 - foo1Val, -15)
    const local_84 = bitString.slice(-15 - foo1Val * 2, -15 - foo1Val)

    rightString = `${local_84} ${local_8c} - ${rightString}`
  } else {
    foo1Val = 0
    rightString = rightString
  }

  const typeCount = bitString.slice(-15 - foo1Val * 2 - 4, -15 - foo1Val * 2)
  const rest = bitString.slice(0, -15 - foo1Val * 2 - 4)

  return `${rest} | ${typeCount} - ${rightString}`
}

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
