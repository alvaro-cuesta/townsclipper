const getBufferBits = (buffer) => {
  return Array.from(buffer.values())
    .map(x => x.toString(2).padStart(8, '0'))
    .join('')
}

module.exports = {
  getBufferBits,
}
