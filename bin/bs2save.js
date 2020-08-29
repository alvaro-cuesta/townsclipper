#!/usr/bin/env node

const fs = require('fs')
const { bitStringToSaveString } = require('../lib/savestring')
const { cleanBitString } = require('../lib/util')

// TODO: --strict-in-padding
// TODO: --strict-in-bits
const bitString = cleanBitString(fs.readFileSync(process.stdin.fd, 'utf-8'))

const saveString = bitStringToSaveString(bitString)

process.stdout.write(saveString)
process.stdout.write('\n')
