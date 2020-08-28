const fs = require('fs')
const { irToBitString } = require('../lib/ir')

// TODO: Annotate flag
const ir = JSON.parse(fs.readFileSync(process.stdin.fd, 'utf-8'))

const bitString = irToBitString(ir)

process.stdout.write(bitString)
process.stdout.write('\n')
