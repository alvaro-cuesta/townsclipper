#!/usr/bin/env node

const fs = require('fs')
const { sparseToIR } = require('../lib/sparse')

const sparse = JSON.parse(fs.readFileSync(process.stdin.fd, 'utf-8'))

const ir = sparseToIR(sparse)

// TODO: Pretty flag
process.stdout.write(JSON.stringify(ir, null, 2))
process.stdout.write('\n')
