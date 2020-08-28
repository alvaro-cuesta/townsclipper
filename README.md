# Townscaper Clipboard Data Format Reverse Engineering

These are my notes when reverse-engineering the Townscaper clipboard data format/encoding.

The clipboard format is completely understood, but I'm still writing the code to visualize and
manipulate it.

In the meatime you can edit the savegames on `%appdata%\..\LocalLow\Oskar Stalberg\Townscaper\`
(i.e. `C:\Users\<username>\AppData\LocalLow\Oskar Stalberg\Townscaper\`). `Town*.scape` files
contain each town. These are plain XML files. Chris Love has [a great writeup](https://medium.com/@chrisluv/getting-hacky-with-townscaper-5a31cf7f4c6a) about these.

## Commands

Assumes Node.js (latest LTS should work) and NPM/Yarn are installed. I will assume Yarn but NPM
should work if you prefer it.

- `yarn all`: Outputs a test set into the `out` folder.
- `yarn encode <bit string>`: Encodes a bit string into a save string that Townscaper can load.
  Ignores non-0/1 characters, but the final string must be a multiple of 6 bits (i.e., base-64
  characters).

  **TODO:** Maybe automatically pad?
- `yarn decode <save string>`: Decodes a save string into a bit string. Ignores non-base64
  characters.
- `yarn annotate <bit string>`: Annotates a bit string with save information. Ignores non-0/1
  characters.
- `yarn decode-annotate <save string>`: `decode` + `annotate`

## Documentation

There's a crude interpretatation of `Placemaker.TextSaveSystem.LoadFromString` in
[`./docs/disasm.cpp`](./docs/disasm.cpp`). It's missing some things but some of the code isn't
implemented yet in our tool so I keep it for reference.

Everything else is (un)documented in the code itself.

## To Do

- The grid is irregular and we need it if we want to generate valid coordinates. Chris Love has
  done some research on this
  ([Twitter thread](https://twitter.com/ChrisLuv/status/1280594189412073474)) and the code in
  http://scriptology.de/townscaper.html might have the full list of corners, but I'd rather
  understand the algorithm.

- En/decode into an intermediate representation (JSON) close to the bit string.

- Decode into a corners + voxels data structure.

- Encode from corners + voxels back into data string.

- Errors and/or leniency on invalid input.

- Maybe use STDIO for input? Yarn adds crap into STDOUT so it's not pipe-friendly :/

- Post to:

  - Reddit
  - Steam
  - https://steamcommunity.com/app/1291340/discussions/0/4078523564590326814/
  - https://medium.com/@chrisluv/getting-hacky-with-townscaper-5a31cf7f4c6a
