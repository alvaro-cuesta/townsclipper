#!/usr/bin/env node
const fs = require('fs')
const package = require('../package.json')
const {
  cleanClipString,
  clipStringToBitString,
  clipStringToDense,
  clipStringToSparse,

  cleanBitString,
  padInputBitString,
  removePadding,
  bitStringToClipString,
  bitStringToDense,
  bitStringToSparse,

  denseToClipString,
  denseToBitString,
  denseToSparse,

  sparseToClipString,
  sparseToBitString,
  sparseToDense,
} = require('../lib')

const FORMATS = [
  'clip',
  'bits',
  'dense',
  'sparse',
]

const CONVERSIONS = {
  clip: {
    bits: clipStringToBitString,
    dense: clipStringToDense,
    sparse: clipStringToSparse,
  },

  bits: {
    clip: bitStringToClipString,
    dense: bitStringToDense,
    sparse: bitStringToSparse,
  },

  dense: {
    clip: denseToClipString,
    bits: denseToBitString,
    sparse: denseToSparse,
  },

  sparse: {
    clip: sparseToClipString,
    bits: sparseToBitString,
    dense: sparseToDense,
  }
}

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

let keepPadding
({
  value: keepPadding,
  args,
} = parseArg(['--keep-padding'], args))

let pretty
({
  value: pretty,
  args,
} = parseArg(['--pretty', '-p', /* HIDDEN */ '-P'], args))

let showVersion
({
  value: showVersion,
  args,
} = parseArg(['--version', '-V', /* HIDDEN */ '-v'], args))

let showHelp
({
  value: showHelp,
  args,
} = parseArg(['--help', '-h', /* HIDDEN */ '--usage', '-?'], args))

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

let input = string
  ? string
  : fs.readFileSync(process.stdin.fd, 'utf-8')

// Input
switch (from) {
  case 'clip': {
    if (strictInAlphabet) {
      input = input.trim()
    } else {
      input = cleanClipString(input)
    }

    break
  }

  case 'bits': {
    if (strictInAlphabet) {
      input = input.trim()
    } else {
      input = cleanBitString(input)
    }

    if (!strictInPadding) {
      input = padInputBitString(input)
    }

    break
  }

  case 'dense':
  case 'sparse': {
    input = JSON.parse(input)

    break
  }

  default: {
    throw new Error('Unreachable')
  }
}

// Conversion
const conversion = CONVERSIONS[from][to]

if (conversion) {
  input = conversion(input)
}

// Output
switch (to) {
  case 'clip': {
    break
  }

  case 'bits': {
    if (pretty) {
      input = bitStringToDense(input)
      input = denseToBitString(input, { pretty: true, pad: keepPadding })
      input = `"${input}"`
    } else if (!keepPadding) {
      input = removePadding(input)
    }

    break
  }

  case 'dense':
  case 'sparse': {
    input = JSON.stringify(input, null, pretty ? 2 : undefined)

    break
  }

  default: {
    throw new Error('Unreachable')
  }
}

process.stdout.write(input)
process.stdout.write('\n')

process.exit(0)
