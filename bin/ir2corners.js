const fs = require('fs')
const { irToCorners } = require('../lib/corners')

const ir = JSON.parse(fs.readFileSync(process.stdin.fd, 'utf-8'))

const corners = irToCorners(ir)

process.stdout.write(corners)
process.stdout.write('\n')
