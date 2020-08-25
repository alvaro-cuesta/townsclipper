const getBufferBytes = (buffer) => {
  return Array.from(buffer.values())
    .map(x => x.toString(16).padStart(2, '0'))
    .join('')
}

const getBufferBits = (buffer) => {
  return Array.from(buffer.values())
    .map(x => x.toString(2).padStart(8, '0'))
    .join('')
}

module.exports = {
  getBufferBytes,
  getBufferBits,
}
