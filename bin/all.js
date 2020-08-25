const fs = require('fs')
const { decodeSaveString } = require('../lib/codec')
const { getBufferBytes, getBufferBits } = require('../lib/binary')

fs.rmdirSync('./out/', { recursive: true })
fs.mkdirSync('./out/')
fs.mkdirSync('./out/separate/')

const all = fs.createWriteStream('./out/all')

const entry = (comment, saveString) => {
  const file = fs.createWriteStream('./out/separate/' + saveString)

  const buffer = decodeSaveString(saveString)

  file.write(comment)
  file.write('\n')
  all.write(comment)
  all.write('\n')

  file.write(saveString)
  file.write('\n')
  all.write(saveString)
  all.write('\n')

  const bufferBytes = getBufferBytes(buffer)
  file.write(bufferBytes)
  file.write('\n')
  all.write(bufferBytes)
  all.write('\n')

  const bufferBits = getBufferBits(buffer)
  file.write(bufferBits)
  file.write('\n')
  all.write(bufferBits)
  all.write('\n')

  file.close()
  all.write('---\n')
}

entry('(0, 0, 1) -> (15, 0)', 'AAAG')
entry('(0, 9, 1) -> (15, 0)', 'FAAmhB')
entry('(9, 0, 1) -> (15, 0)', 'FAIDhB')
entry('(0, 0, 1) -> (0, 1)', 'AAIAN')
entry('(0, 0, 1) -> (2, 1)', 'AAICN')
entry('(0, 0, 1) -> (14, 1)', 'AAIcN')
entry('(0, 0, 1) -> (0, 250)', 'AAIAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAN')
entry('(0, 0, 1) -> (14, 250)', 'AAIcAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAN')
entry('(0, 0, 1) -> (14, 251)', 'AAIcAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA0')
entry('(0, 0, 1) -> (14, 252)', 'AAIcAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAQD')
entry('(0, 0, 1) -> (14, 253)', 'AAIcAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAN')

entry('(0, 0, 2) -> (15, 0), (0, 1)', 'AAIgN')
entry('(0, 0, 2) -> (15, 0), (1, 1)', 'AAIiN')
entry('(0, 0, 2) -> (15, 0), (2, 1)', 'AAIkN')
entry('(0, 0, 2) -> (15, 0), (3, 1)', 'AAImN')

entry('(0, 0, 2) -> (15, 0), (0, 2)', 'AAIg0')
entry('(0, 0, 2) -> (15, 0), (1, 2)', 'AAIi0')
entry('(0, 0, 2) -> (15, 0), (13, 2)', 'AAI60')
entry('(0, 0, 2) -> (15, 0), (14, 2)', 'AAI80')

entry('(0, 0, 2) -> (15, 0), (0, 3)', 'AAIgQD')
entry('(0, 0, 2) -> (15, 0), (14, 3)', 'AAI8QD')

entry('(0, 0, 2) -> (15, 0), (0, 4)', 'AAIgAN')
entry('(0, 0, 2) -> (15, 0), (14, 4)', 'AAI8AN')

entry('(0, 9, 2) -> (15, 0), (0, 1)', 'FAAmDYD')
entry('(0, 9, 2) -> (15, 0), (1, 1)', 'FAAmjYD')
entry('(0, 9, 2) -> (15, 0), (2, 1)', 'FAAmDZD')
entry('(0, 9, 2) -> (15, 0), (3, 1)', 'FAAmjZD')
entry('(0, 9, 2) -> (15, 0), (4, 1)', 'FAAmDaD')
entry('(0, 9, 2) -> (15, 0), (5, 1)', 'FAAmjaD')
entry('(0, 9, 2) -> (15, 0), (6, 1)', 'FAAmDbD')
entry('(0, 9, 2) -> (15, 0), (7, 1)', 'FAAmjbD')

entry('(0, 9, 2) -> (15, 0), (14, 1)', 'FAAmDfD')

entry('(0, 0, 1) -> (15, 0); (0, 9, 1) -> (15, 0)', 'AABglD')
entry('(0, 0, 1) -> (15, 0); (0, 9, 2) -> (15, 0), (0, 1)', 'AAJA4zN')
entry('(0, 0, 1) -> (15, 0); (0, 9, 2) -> (15, 0), (1, 1)', 'AAJC4zN')

all.close()
