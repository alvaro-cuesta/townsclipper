const fs = require('fs')
const { bitStringToSaveString } = require('../lib/savestring')
const { cleanBitString } = require('../lib/util')

const bitString = cleanBitString(fs.readFileSync(process.stdin.fd, 'utf-8'))

const saveString = bitStringToSaveString(bitString)

process.stdout.write(saveString)
process.stdout.write('\n')
