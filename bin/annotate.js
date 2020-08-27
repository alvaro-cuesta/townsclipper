const { annotateBitString } = require('../lib/format')

// Accepts an arbitrary number of arguments and joins them into a bit string
const arguments = process.argv.slice(2)

if (arguments.length === 0) {
  process.stderr.write('encode.js needs arguments\n')
  process.exit(1)
}

const bitString = arguments.join('')

// Annotate and print
try {
  const annotatedString = annotateBitString(bitString)

  process.stdout.write(annotatedString)
  process.stdout.write('\n')

  process.exit(0)
} catch (err) {
  process.stderr.write(err.message)
  process.stderr.write('\n')

  process.exit(1)
}
