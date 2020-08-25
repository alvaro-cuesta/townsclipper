const { decodeSaveString } = require('../lib/codec')
const { getBufferBits } = require('../lib/binary')

// Accepts an arbitrary number of arguments and joins them into a save string
const arguments = process.argv.slice(2)

if (arguments.length === 0) {
  process.stderr.write('decode.js needs arguments\n')
  process.exit(1)
}

const saveString = arguments.join('')

// Decode into a bit string and print
try {
  const buffer = decodeSaveString(saveString)
  const bitString = getBufferBits(buffer)

  process.stdout.write(bitString)
  process.stdout.write('\n')

  process.exit(0)
} catch (err) {
  process.stderr.write(err.message)
  process.stderr.write('\n')

  process.exit(1)
}
