#!/usr/bin/env node

const fs = require('fs')
const { irToSparse } = require('../lib/sparse')

const ir = JSON.parse(fs.readFileSync(process.stdin.fd, 'utf-8'))

const sparse = irToSparse(ir)

const indent = process.argv[2] === '--pretty' ? 2 : undefined

process.stdout.write(JSON.stringify(sparse, null, indent))
process.stdout.write('\n')
