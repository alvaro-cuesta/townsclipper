#!/usr/bin/env node

const fs = require('fs')
const { sparseToIR } = require('../lib/sparse')

const sparse = JSON.parse(fs.readFileSync(process.stdin.fd, 'utf-8'))

const ir = sparseToIR(sparse)

const indent = process.argv[2] === '--pretty' ? 2 : undefined

process.stdout.write(JSON.stringify(ir, null, indent))
process.stdout.write('\n')
