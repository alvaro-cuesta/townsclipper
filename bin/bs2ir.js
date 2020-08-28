#!/usr/bin/env node

const fs = require('fs')
const { bitStringToIR } = require('../lib/ir')
const { cleanBitString } = require('../lib/util')

const bitString = cleanBitString(fs.readFileSync(process.stdin.fd, 'utf-8'))

const ir = bitStringToIR(bitString)

const indent = process.argv[2] === '--pretty' ? 2 : undefined

process.stdout.write(JSON.stringify(ir, null, indent))
process.stdout.write('\n')
