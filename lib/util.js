const cleanBitString = (bitString) =>
  bitString
    .replace(/[^01]/g, '')

const cleanSaveString = (saveString) =>
  saveString
    .replace(/[^A-Za-z0-9_\-]/g, '')

module.exports = {
  cleanBitString,
  cleanSaveString,
}
