const base64url = require('base64url')

// Decode a saveString into a buffer
const decodeSaveString = (saveString) => {
  const cleanSaveString = saveString.replace(/[^A-Za-z0-9\-_]/g, '')

  return base64url.toBuffer(cleanSaveString)
}

// Encode a Buffer into a save string
const encodeBuffer = (buffer) => {
  return base64url.encode(buffer)
}

// Encode a bit string (0s and 1s) into a save string
// Is lenient with input: cleans non-0/1 chars beforehand
const encodeBitString = (bitString) => {
  const cleanBitString = bitString.replace(/[^01]/g, '')

  if ((cleanBitString.length % 8) !== 0) {
    throw new Error(`Bit string length (${cleanBitString.length}) must be a multiple of 8`)
  }

  const bytes = Array(cleanBitString.length / 8)
    .fill()
    .map((_, i) => {
      const byteBits = cleanBitString.slice(i * 8, (i + 1) * 8)
      return parseInt(byteBits, 2)
    })

  const buffer = Buffer.from(bytes)

  return encodeBuffer(buffer)
}

module.exports = {
  decodeSaveString,
  encodeBuffer,
  encodeBitString,
}
