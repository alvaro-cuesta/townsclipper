const makeBitReader = (bitString) => {
  let readCount = 0

  const retFn = (n) => {
    if (n === 0) {
      return {
        bits: '',
        value: 0,
      }
    }

    if (n === undefined) {
      n = retFn.left
    }

    const bits = bitString.slice(
      -readCount - n,
      readCount ? -readCount : undefined,
    )

    readCount += n
    retFn.left = bitString.length - readCount

    return {
      bits,
      value: parseInt(bits, 2) || 0,
    }
  }

  retFn.left = bitString.length

  return retFn
}

const annotateBitString = (bitString) => {
  const read = makeBitReader(bitString)

  let outString = ''

  // Bit counts
  const posOffsetsBitLength = read(5)
  outString = posOffsetsBitLength.bits + outString

  const yDeltaBitLength = read(5)
  outString = yDeltaBitLength.bits + ' ' + outString

  const xOffsetBitLength = read(5)
  outString = xOffsetBitLength.bits + ' ' + outString

  outString = '| ' + outString

  // Initial pos (optional)
  if (posOffsetsBitLength.value > 0) {
    const yInitial = read(posOffsetsBitLength.value)
    outString = yInitial.bits + ' ' + outString

    const xInitial = read(posOffsetsBitLength.value)
    outString = xInitial.bits + ' ' + outString

    outString = '| ' + outString
  }

  // Types
  const typeCount = read(4)
  outString = '(' + typeCount.bits + ') ' + outString

  for (let i = 0; i < typeCount.value; i++) {
    const type = read(4)
    outString = type.bits + ' ' + outString
  }

  outString = '| ' + outString

  // Voxels
  const typeIndexBitLength = Math.ceil(Math.log2(typeCount.value + 2)) || 1

  if (typeIndexBitLength === 0) {
    throw new Error('Bad')
  }

  let isFirst = true
  const typeStopIndex = (1 << typeIndexBitLength) - 1

  while (read.left > 0) {
    if (!isFirst) {
      const isMoveY = read(1)
      outString = '(dy?' + isMoveY.bits + ') ' + outString

      if (isMoveY.value == 1) {
        const yDelta = read(yDeltaBitLength.value)
        outString = '(dy' + yDelta.bits + ') ' + outString
      }
    } else {
      isFirst = false;
    }

    if (xOffsetBitLength.value > 0) {
      const xPos = read(xOffsetBitLength.value)
      outString = '(+x' + xPos.bits + ') ' + outString
    }

    const hasGround = read(1)
    outString = '(gnd?' + hasGround.bits + ') ' + outString

    let height = 1

    while (true) {
      const typeIndex = read(typeIndexBitLength)
      if (typeIndex.bits) {
        outString = typeIndex.bits + ' ' + outString
      }

      if (typeIndex.value == typeStopIndex || height === 0xff)
        break

      height++
    }

    outString = '| ' + outString
  }

  return outString
}

module.exports = {
  annotateBitString,
}
