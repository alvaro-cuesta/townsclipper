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

const escape = number =>
  number
    .toString()
    .replace(/0/g, 'O')
    .replace(/1/g, 'l')

const annotateBitString = (bitString) => {
  const first1Index = bitString.indexOf('1')
  const shortBitString = bitString.slice(first1Index)

  const read = makeBitReader(shortBitString)

  let outString = ''

  // Bit counts
  outString = '>' + outString

  const posOffsetsBitLength = read(5)
  outString = `po=${posOffsetsBitLength.bits}[${escape(posOffsetsBitLength.value)}]` + outString

  const xDeltaBitLength = read(5)
  outString = `dx=${xDeltaBitLength.bits}[${escape(xDeltaBitLength.value)}] ` + outString

  const yOffsetBitLength = read(5)
  outString = `+y=${yOffsetBitLength.bits}[${escape(yOffsetBitLength.value)}] ` + outString

  outString = '<' + outString

  // Initial pos (optional)
  if (posOffsetsBitLength.value > 0) {
    outString = '> ' + outString

    const signOffset = 1 << (posOffsetsBitLength.value - 1)

    const xInitial = read(posOffsetsBitLength.value)
    outString = `x=${xInitial.bits}[${escape(xInitial.value - signOffset)}]` + outString

    const yInitial = read(posOffsetsBitLength.value)
    outString = `y=${yInitial.bits}[${escape(yInitial.value - signOffset)}], ` + outString

    outString = '<' + outString
  }

  // Types
  const typeCount = read(4)
  outString = `(${typeCount.bits})> ` + outString

  for (let i = 0; i < typeCount.value; i++) {
    const type = read(4)
    outString = `${type.bits} ` + outString
  }

  outString = `<` + outString

  // Voxels
  const typeIndexBitLength = Math.ceil(Math.log2(typeCount.value + 2))

  let isFirst = true
  const typeStopIndex = (1 << typeIndexBitLength) - 1

  while (read.left > 0) {
    outString = '| ' + outString

    if (!isFirst) {
      const isMoveX = read(1)
      outString = `(dx?${isMoveX.bits}) ` + outString

      if (isMoveX.value == 1) {
        const xDelta = read(xDeltaBitLength.value)
        outString = `(dx${xDelta.bits}[${escape(xDelta.value)}]) ` + outString
      }
    } else {
      isFirst = false;
    }

    if (yOffsetBitLength.value > 0) {
      const yPos = read(yOffsetBitLength.value)
      outString = `(+y${yPos.bits}[${escape(yPos.value)}]) ` + outString
    }

    const hasGround = read(1)
    outString = `(g?${hasGround.bits}) ` + outString

    let height = 1

    while (true) {
      const typeIndex = read(typeIndexBitLength)
      if (typeIndex.bits) {
        if (typeIndex.value == typeStopIndex) {
          outString = `#${typeIndex.bits}# ` + outString
          break
        } else {
          outString = `${typeIndex.bits} ` + outString
        }
      }

      if (height === 0xff) {
        break
      }

      height++
    }
  }

  if (first1Index > 0) {
    outString = `<${bitString.slice(0, first1Index)}> | ` + outString
  }

  return `"${outString}"`
}

module.exports = {
  annotateBitString,
}
