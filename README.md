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
First install globally (you might need root/admin permissions):

```sh
npm install -g townsclipper
# Or with Yarn
yarn global add townsclipper
```

It will install the `townsc` command-line tool. Use `townsc --help` for instructions.

You can also use it locally without `-g` or `global`, but you'll have to run it in that specific
folder via `./node_modules/.bin/townsc.js`.

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

- `yarn test` shouldn't break, and you should add the relevant tests (if any) to your changes.

- `yarn test:diff` outputs a test set into the `test_out` folder. Inspect differences (if any) in
  `git diff` to check that everything is working as intended. Feel free to add tests cases if
  needed. Remember to commit `test_out` so we can use `git diff` with your changes!

### TODO

- The grid is irregular and we need it if we want to generate valid coordinates. Chris Love has
  done some research on this ([Twitter thread](https://twitter.com/ChrisLuv/status/1280594189412073474)).

  Even though eventually the grid size is locked when you build enough, it's actually infinite. To
  see it in action, scroll before building any blocks.

  Some people have shared filled patches, and the code in http://scriptology.de/townscaper.html
  has a list of valid corners, but they are just a limited set. This library
  [used to have a `VALID_CORNERS` list too](https://github.com/alvaro-cuesta/townsclipper/blob/bf646487f3efb7dfa0566d130db60d0ccdbfb27b/lib/valid-corners.js)
  but it was from a specific filled patch (before I realized the grid limits were arbitrary and
  procedurally infinite).

  I'd rather not encourage using a specific patch, hence why I removed the `VALID_CORNERS`. For now
  you'll have to generate your own list of valid corners if needed, but ideally we'd understand the
  algorithm.

  See https://www.youtube.com/watch?v=1hqt8JkYRdI for more info.

  - Maybe use this to check if corners are valid in dense and sparse (from and to)?

- Automated tests. Jest?

- Maybe don't implicitly remove empty corners and warn intead? Applies to various conversions in
  dense, sparse, bits.

  - This might require having a warning system versus just throwing.

- Maybe be more lenient with input as long as it doesn't break output (e.g. from dense to sparse,
  why not accept too many `types`?) On the other hand, it might help catch bugs.

  More instances: accept `0` or `undefined` when expecting `null`, etc.

- Online version for people that can't/won't use the CLI.

- Some kind of random generator to showcase the possibilities.

- /dev/clipboard example (what about MINGW64? I've been unable to make Node's stdout work)

- BUG: `{"xInitial":0,"yInitial":0,"types":[],"corners":[]}` outputs AAAA but Townscaper uses AAAE

- Move `test:diff` to Jest

- Remove trailing `-1`s in `bitsToDense` and `denseToBits`?

  - Can of worms? It would make sense to also do things like sort types in Townscaper order

  - OTOH we're already removing empty corners

  - Annotate might already be broken since `bitsToDense` might lose information

  - Maybe hide behind `--optimize` flag, or `--no-optimize`
