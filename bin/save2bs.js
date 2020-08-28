#!/usr/bin/env node

const fs = require('fs')
const { saveStringToBitString } = require('../lib/savestring')
const { cleanSaveString } = require('../lib/util')

const saveString = cleanSaveString(fs.readFileSync(process.stdin.fd, 'utf-8'))

const bitString = saveStringToBitString(saveString)

process.stdout.write(bitString)
process.stdout.write('\n')
