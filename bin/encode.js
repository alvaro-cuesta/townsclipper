const { encodeBitString } = require('../lib/codec')

// Accepts an arbitrary number of arguments and joins them into a bit string
const arguments = process.argv.slice(2)

if (arguments.length === 0) {
  process.stderr.write('encode.js needs arguments\n')
  process.exit(1)
}

const bitString = arguments.join('')

// Encode into a save string and print
try {
  const saveString = encodeBitString(bitString)

  process.stdout.write(saveString)
  process.stdout.write('\n')

  process.exit(0)
} catch (err) {
  process.stderr.write(err.message)
  process.stderr.write('\n')

  process.exit(1)
}
