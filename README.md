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

- `yarn all`: Outputs a test set into the `test_out` folder.
- `echo <save string> | node bin/save2bs`: Decodes a save string into a bit string. Ignores non-base64
  characters.

  **TODO:** Maybe automatically remove padding?
- `echo <bit string> | node bin/bs2save`: Encodes a bit string into a save string that Townscaper can load.
  Ignores non-0/1 characters, but the final string must be a multiple of 6 bits (i.e., base-64
  characters).

  **TODO:** Maybe automatically pad?
- `echo <bit string> | node bin/bs2ir`: Transforms a bit string into Intermediate Representation,
  a JSON representation of that bit string. Pretty close to the raw deal but more readable and easier
  to edit.

  Ignores non-0/1 characters, but the final string must be a multiple of 6 bits (i.e., base-64
  characters).

  **TODO:** Maybe automatically pad?
- `echo <ir json> | node bin/ir2bs`: Transform Intermediate Representation JSON into its equivalent bit
  string.

  **TODO:** Maybe automatically remove padding?

## To Do

- The grid is irregular and we need it if we want to generate valid coordinates. Chris Love has
  done some research on this
  ([Twitter thread](https://twitter.com/ChrisLuv/status/1280594189412073474)) and the code in
  http://scriptology.de/townscaper.html might have the full list of corners, but I'd rather
  understand the algorithm.

- Decode IR into a corners + voxels data structure.

- Encode from corners + voxels back into IR.

- Usage examples on README

- Post to:

  - Reddit
  - Steam
  - https://steamcommunity.com/app/1291340/discussions/0/4078523564590326814/
  - https://medium.com/@chrisluv/getting-hacky-with-townscaper-5a31cf7f4c6a
