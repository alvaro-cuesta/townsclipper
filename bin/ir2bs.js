#!/usr/bin/env node

const fs = require('fs')
const { irToBitString } = require('../lib/ir')

const ir = JSON.parse(fs.readFileSync(process.stdin.fd, 'utf-8'))

// TODO: Annotate flag
const bitString = irToBitString(ir)

process.stdout.write(bitString)
process.stdout.write('\n')
