const fs = require('fs')
const { saveStringToBitString } = require('../lib/codec')
const { cleanSaveString } = require('../lib/util')

const saveString = cleanSaveString(fs.readFileSync(process.stdin.fd, 'utf-8'))

const bitString = saveStringToBitString(saveString)

process.stdout.write(bitString)
process.stdout.write('\n')
