const fs = require('fs')
const { bitStringToIR } = require('../lib/ir')
const { cleanBitString } = require('../lib/util')

const bitString = cleanBitString(fs.readFileSync(process.stdin.fd, 'utf-8'))

const ir = bitStringToIR(bitString)

process.stdout.write(JSON.stringify(ir, null, 2))
process.stdout.write('\n')
