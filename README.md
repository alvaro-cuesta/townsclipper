# Townscaper Clipboard

Townscaper clipboard data format converter.

## Concepts

- **Voxels:** Each little cube that we build the town with.

- **Types:** The different colors of voxels. Also empty (air) and ground.

- **Corners:** Each possible construction point in the grid. Contains a column of voxels (or empty
  space) in a specific X and Y coordinate.

- **Save string:** Clipboard save string, as generated when clicking the "Save to Clipboard"
  button in Townscaper.

- **Bit string:** Raw binary data decoded from save strings.

- **Intermediate Representation (IR):** A JSON representation of the data inside a save string.
  Some details are abstracted away since they can be calculated.

  Although multiple IRs can generate the same bit string (and vice versa) they can be transformed
  univocally as long as the least number of bits is used.

  Internally:

  - Corner positions are represented as deltas (`x`) and offsets (`y`).
  - Voxels are represented as a dense array of types (column in that corner) from lowest to highest.

  ```ts
  type IR = {
    // The initial X and Y coordinates from corners.
    xInitial: number,
    yInitial: number,
    // Up to 15 colors. Absolute voxel types (0 = red, 14 = white, 15 = ground).
    // This is used as a lookup table later in corner's `voxels`.
    types: number[],
    // See below.
    corners: Corner[],
  }

  type IRCorner =  {
    // How much to advance `X` from last corner. Must be `null` on the first `Corner`.
    xDelta: number | null,
    // yPosition = yInitial + yOffset.
    yOffset: 0,
    // Whether this corner's column has a ground voxel.
    hasGround: true,
    // Index in `types` lookup table. `-1` for empty.
    voxels: number[],
  }
  ```

- **Scape files:** Towns as stored in disk, in plain XML format. In Windows they are stored as a
  bunch of `Town*.scape` files in `%appdata%\..\LocalLow\Oskar Stalberg\Townscaper\` (i.e.
  `C:\Users\<username>\AppData\LocalLow\Oskar Stalberg\Townscaper\`). Chris Love has
  [a great writeup](https://medium.com/@chrisluv/getting-hacky-with-townscaper-5a31cf7f4c6a) about
  these.

  Long story short: they are a list of corners `(x, y, number of voxels)` and another list of
  voxels `(height, type)` in order of appearance in corners.

- **Sparse:** JSON representation with voxels in sparse form (similar to Scape files).

  ```ts
  type Sparse = SparseCorner[]

  type SparseCorner = {
    // Absolute position
    x: number,
    y: number,
    // Map from height (0 = ground) to absolute voxel type (0 = red, 14 = white, 15 = ground)
    voxels: { [k: number] : number},
  }
  ```

## Commands

Assumes Node.js (latest LTS should work) and NPM/Yarn are installed. I will assume Yarn but NPM
should work if you prefer it.

- `yarn all`: Outputs a test set into the `test_out` folder.

- `echo <save string> | ./bin/save2bs.js`: Decodes a save string into a bit string. Ignores non-base64
  characters.

  **TODO:** Maybe output without padding? Flag?

- `echo <bit string> | ./bin/bs2ir.js`: Transforms a bit string into Intermediate Representation,
  a JSON representation of that bit string. Pretty close to the raw deal but more readable and easier
  to edit.

  Ignores non-0/1 characters, but the final string must be a multiple of 6 bits (i.e., base-64
  characters).

  **TODO:** Maybe automatically pad? Flag?

- `echo <ir json> | ./bin/ir2corners.js`: Transform IR JSON into Sparse JSON, similar to how it's
  laid out in the `Town*.scape` XML files (see above).

- `echo <corners json> | ./bin/corners2ir.js`: Transform Sparse JSON into IR JSON.

- `echo <ir json> | ./bin/ir2bs.js`: Transform IR JSON into its equivalent bit string.

  **TODO:** Maybe output without padding? Flag?

- `echo <bit string> | ./bin/bs2save.js`: Encodes a bit string into a save string that Townscaper can load.
  Ignores non-0/1 characters, but the final string must be a multiple of 6 bits (i.e., base-64
  characters).

  **TODO:** Maybe automatically pad? Flag?

## To Do

- The grid is irregular and we need it if we want to generate valid coordinates. Chris Love has
  done some research on this
  ([Twitter thread](https://twitter.com/ChrisLuv/status/1280594189412073474)) and the code in
  http://scriptology.de/townscaper.html might have the full list of corners, but I'd rather
  understand the algorithm.

- Make `sparseToIR` behave like it would on Townscaper. Currently `save -> bit -> ir -> sparse ->
  ir -> bit -> save` not always roundtrips properly.

  E.g.:

- Usage examples on README

- Post to:

  - Reddit
  - Steam
  - https://steamcommunity.com/app/1291340/discussions/0/4078523564590326814/
  - https://medium.com/@chrisluv/getting-hacky-with-townscaper-5a31cf7f4c6a
