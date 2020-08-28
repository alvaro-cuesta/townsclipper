const fs = require('fs')
const { irToSparse } = require('../lib/sparse')

const ir = JSON.parse(fs.readFileSync(process.stdin.fd, 'utf-8'))

const sparse = irToSparse(ir)

// TODO: Pretty flag
process.stdout.write(JSON.stringify(sparse, null, 2))
process.stdout.write('\n')
