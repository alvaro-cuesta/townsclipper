# Townsclipper [![NPM latest version](https://img.shields.io/npm/v/townsclipper.svg)](https://npmjs.com/package/townsclipper)

[Townscaper](https://store.steampowered.com/app/1291340/Townscaper/) clipboard data format converter.

Encodes and decodes towns in clipboard (text) into various other formats. For example, it can turn
this...

```
FC5ADI3TQN
```

<p align="center">
<a href="./media/FC5ADI3TQN.png">
<img src="./media/FC5ADI3TQN.png" alt="FC5ADI3TQN screenshot">
</a>
</p>

...into this...

```json
[
  {
    "x": -9,
    "y": 9,
    "voxels": {
      "0": 15,
      "1": 0
    }
  },
  {
    "x": 0,
    "y": 0,
    "voxels": {
      "1": 0,
      "2": 0
    }
  }
]
```

...and back again!

- [Concepts](#concepts)
- [CLI](#cli)
- [Library](#library)
- [Contributing](#contributing)

## Concepts

- **Voxels:** Each little cube that we build the town with.

- **Types:** The different colors of voxels. Also empty (air) and ground.

- **Corners:** Each possible construction point in the grid. Contains a column of voxels (or empty
  space) in a specific X and Y coordinate.

- **Clip string:** Clipboard save string, as generated when clicking the "Save to Clipboard"
  button in Townscaper.

- **Bit string:** Raw binary data decoded from clip strings.

- **Dense Representation:** A JSON representation of the data inside a clip string. Some details
  are abstracted away since they can be calculated.

  Although multiple DRs can generate the same bit string (and vice versa) they can be transformed
  univocally as long as the least number of bits is used.

  Internally:

  - Corner positions are represented as deltas (`x`) and offsets (`y`).
  - Voxels are represented as a dense array of types (column in that corner) from lowest to highest.

   ```ts
   type Dense = {
     // The initial X and Y coordinates from corners.
     xInitial: number,
     yInitial: number,
     // Up to 15 colors. Absolute voxel types (0 = red, 14 = white, 15 = ground).
     // This is used as a lookup table later in DenseCorner's `voxels`.
     types: number[],
     // See below.
     corners: DenseCorner[],
   }

   type DenseCorner =  {
     // How much to advance `X` from last corner. Must be `null` on the first `Corner`.
     xDelta: number | null,
     // yPosition = yInitial + yOffset.
     yOffset: number,
     // Whether this corner's column has a ground voxel.
     hasGround: bool,
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

- **Sparse Representation:** JSON representation with voxels in sparse form (similar to Scape
  files).

   ```ts
   type Sparse = SparseCorner[]

   type SparseCorner = {
     // Absolute position
     x: number,
     y: number,
     // Map from height (0 = ground) to absolute voxel type (0 = red, 14 = white, 15 = ground)
     voxels: { [height: number] : number },
   }
   ```

## CLI

Installation requires [Node.js](https://nodejs.org) (latest LTS should work) and NPM or Yarn.
First install globally:

```sh
npm install -g townsclipper
# Or with Yarn
yarn global add townsclipper
```

It will install the `townsc` command-line tool. Use `townsc --help` for instructions.

You can also use it locally without `-g` or `global`, but you'll have to run it in that specific
folder via `./node_modules/.bin/townsc` (or similar).

Windows users (including MinGW apparently) might need to run `node ./node_modules/.bin/townsc`
since shebangs apparenly run a different `node` (at least in my Windows install :/)

### Examples

1. **Inspect a save string as dense representation**

   ```sh
   townsc clip dense --pretty ASJAJ6Za1TAa
   ```

2. **Same, but reading from a file (or any stdin for that matter)**

   ```sh
   cat myFile | townsc clip dense --pretty
   ```

3. **Replace red blocks with blue**

   ```sh
   townsc clip dense ASJAJ6Za1TAa |
   sed 's/"types":\[0]/"types":\[9]/' |
   townsc dense clip
   ```

4. **Edit savestring data as sparse in Vim**

   ```sh
   tmpfile=$(mktemp) &&
   townsc clip sparse --pretty ASJAJ6Za1TAa > $tmpfile &&
   vim $tmpfile &&
   cat $tmpfile | townsc sparse clip &&
   rm $tmpfile
   ```

   (TIP: Make a shell alias out of this!)

## Library

You can programatically use Townsclipper as a library (both NodeJS and browser via bundler should
work). See [`./lib/index.js`](./lib/index.js).

```
npm install --save townsclipper
# Or with Yarn
yarn add townsclipper
```

## Contributing [![MIT License](https://img.shields.io/npm/l/townsclipper)](./LICENSE)

Just test the CLI and library! Use it! Break it! Enjoy it! And
[report any bugs](https://github.com/alvaro-cuesta/townsclipper/issues) :P

Pull requests are welcome. [Fork](https://github.com/alvaro-cuesta/townsclipper/network/members)
this repository! For now we're just working on `master` since were aren't even v1.0.

**Do a global search for `TODO` to see what's pending to do or discuss.**

#### Rules:

- Clipboard strings should match Townscaper's. If you can make them shorter, hide the behavior
  behind a flag (but make it on by default!)

- JSON string output doesn't have to match exactly as long as it parses the same.

- Be explicit in Dense Representation. I'd rather have a `null` value than a missing key (see
  `xDelta`).

- When in doubt, do what Townscaper does.

- `yarn test` outputs a test set into the `test_out` folder. Inspect differences (if any) in
  `git diff` to check that everything is working as intended. Feel free to add tests cases if
  needed. Remember to commit `test_out` so we can use `git diff` with your changes!
