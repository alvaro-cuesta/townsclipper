#!/usr/bin/env node
const fs = require('fs')
const package = require('../package.json')
const { convertToString } = require('../lib')

const USAGE =
`townsc FROM TO [OPTION ...] [INPUT]
  v${package.version} - https://github.com/alvaro-cuesta/townsclipper/

INPUT
  Read from stdin if not specified.

FROM/TO
  clip      Clipboard save string
  bits      Raw binary data decoded from save string
  dense     JSON of the data inside a save string
  sparse    JSON with voxels in sparse form (similar to Scape files)

OPTIONS
  -h, --help
  -V, --version

  -p, --pretty                Enable pretty output
                                TO =   bits           Enable annotations
                                TO =   dense/sparse   Enable JSON indentation

      --keep-padding          Do not remove padding on output
                                TO =   bits

      --strict-in-padding     Disable autopadding of input
                                FROM = bits

      --strict-in-alphabet    Error on unexpected input characters
                                FROM = clip           base64url characters
                                FROM = bits           0/1 characters`

const VERSION =
`townsc v${package.version} - https://github.com/alvaro-cuesta/townsclipper/`

const FORMATS = [
  'clip',
  'bits',
  'dense',
  'sparse',
]

// Parse arguments
const parseArg = (flags, args) => {
  if (flags.some(flag => args.includes(flag))) {
    return {
      value: true,
      args: args.filter(arg => !flags.includes(arg)),
    }
  }

  return {
    value: false,
    args,
   }
}

let args = process.argv.slice(2)

let showHelp
({
  value: showHelp,
  args,
} = parseArg(['--help', '-h', /* HIDDEN */ '--usage', '-?'], args))

let showVersion
({
  value: showVersion,
  args,
} = parseArg(['--version', '-V', /* HIDDEN */ '-v'], args))

let pretty
({
  value: pretty,
  args,
} = parseArg(['--pretty', '-p', /* HIDDEN */ '-P'], args))

let keepPadding
({
  value: keepPadding,
  args,
} = parseArg(['--keep-padding'], args))

let strictInPadding
({
  value: strictInPadding,
  args,
} = parseArg(['--strict-in-padding'], args))

let strictInAlphabet
({
  value: strictInAlphabet,
  args,
} = parseArg(['--strict-in-alphabet'], args))

if (showHelp) {
  console.log(USAGE)
  process.exit(0)
}

if (showVersion) {
  console.log(VERSION)
  process.exit(0)
}

if (args.length < 2 || args.length > 3) {
  console.error(USAGE)
  process.exit(1)
}

let [ from, to, string ] = args

if (!FORMATS.includes(from) || !FORMATS.includes(to)) {
  console.error(USAGE)
  process.exit(1)
}

// Do the magic
let input = string
  ? string
  : fs.readFileSync(process.stdin.fd, 'utf-8')

input = convertToString(
  from,
  to,
  input,
  {
    pretty,
    keepPadding,
    strictInPadding,
    strictInAlphabet,
  },
)

process.stdout.write(input)
process.stdout.write('\n')

process.exit(0)
