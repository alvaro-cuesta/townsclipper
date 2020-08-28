const fs = require('fs')
const { cornersToIR } = require('../lib/corners')

const corners = JSON.parse(fs.readFileSync(process.stdin.fd, 'utf-8'))

const ir = cornersToIR(corners)

// TODO: Pretty flag
process.stdout.write(JSON.stringify(ir, null, 2))
process.stdout.write('\n')
