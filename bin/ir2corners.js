const fs = require('fs')
const { irToCorners } = require('../lib/corners')

const ir = JSON.parse(fs.readFileSync(process.stdin.fd, 'utf-8'))

const corners = irToCorners(ir)

// TODO: Pretty flag
process.stdout.write(JSON.stringify(corners, null, 2))
process.stdout.write('\n')
