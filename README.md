# Townscaper Clipboard Format Reverse Engineering

These are my notes when reverse-engineering the Townscaper clipboard format.

## Game files

Savegames and log files are present at `%appdata%\..\LocalLow\Oskar Stalberg\Townscaper\`
(i.e. `C:\Users\<username>\AppData\LocalLow\Oskar Stalberg\Townscaper\`).

- `Town*.scape` files contain each town. These are plain XML files. Chris Love has
  [a great writeup](https://medium.com/@chrisluv/getting-hacky-with-townscaper-5a31cf7f4c6a)
  about these. See `F2` below.
- `Player.log` is the current log file. Some information can be acquired via error logs.

## Commands

Assumes Node.js (latest LTS should work) and NPM/Yarn are installed. I will assume Yarn but NPM
should work if you prefer it.

First you need to install the required dependencies using `yarn install` to access these commands!

- `yarn all`: Runs a huge test set into the `out` folder.
- `yarn encode <bit string>`: Encodes a bit string into a save string that Townscaper can load.
  Ignores non-0/1 characters, but the final string must be a multiple of 8 bits (i.e., bytes)
- `yarn decode <save string>`: Decodes a save string into a bit string. Ignores non-base64 characters.

## Documentation

Findings are classified as `Facts` and `Musings` (see below). Each one should have an identifier
for reference. Use `Fxx` for facts and `Mxx` for musings.

A dummy dissambly (as of Aug 21st version) is available in [`./docs/types.cs`](./docs/types.cs),
generated with [Il2CppInspector](https://github.com/djkaty/Il2CppInspector). It does not contain
any code, but the debug symbols are there.

There's also a dummy DLL in [`./docs/DummyDll/`](./docs/DummyDll/`) (generated with
[Il2CppDumper](https://github.com/Perfare/Il2CppDumper), only dummy implementation) which can be
inspected with tools like [ILSpy](https://github.com/icsharpcode/ILSpy). If I'm not mistaken you
can use this debug symbols with a disassembler like IDA to inspect the ASM code, but I haven't
done so (for now).

### Facts

- `(F1)` The clipboard format seems to be just some base64url
  ([RFC 4648 §5](https://tools.ietf.org/html/rfc4648#section-5)) encoded binary data.

- `(F2)` The save data (in the XML files, also in class `SaveData`) is:

  - A list of corners (`x`, `y`, `n`), where `n` is the number of voxels in that corner.
    `C` in the class.
  - A list of voxels (`t`,  `h`) where `t` is 0-15 (0-14 = colors, 15 = ground) and `h` is height.
    `V` in the class. If you edit ground into the air, weird things happen!

  Voxels are ordered by corner, which is needed to read the corner's `n` voxels.

  There's also some more data (`saveString`, which we're trying to reverse-engineer),
  JPEG screenshots, and the camera position. Can be safely ignored.

- `(F3)` The implementation of the save system is on the `TextSaveSystem` class. See also `M5`.

  Interesting bits:

  - `const bitCountBitCount = 5`
  - `const typeCountBitCount = 4`
  - Internally it's a bit array, so we can be pretty sure the save string is a bit field.
  - There is a `static int GetBitCount(int biggestValue)` that's probably used to encode
    values into the minimum number of bits required.
  - See `F4` (`string SaveToString(List<SaveData.C> corners, List<SaveData.V> voxels)`)
  - Some more things that might or might not be useful and haven't been mentioned:

    ```cs
    public class TextSaveSystem : MonoBehaviour
      {
        // Fields
        // <snip>
        private static BitArray bitArray;
        private static char[] chars;
        private static readonly int bitsPerCharacter;
        // </snip>

        // Nested types
        public interface ITextSaver // TypeDefIndex: 4634
        {
          // Methods
          void SaveToText(List<int> values);
          void LoadFromText(BitArray bitArray, ref int bitIndex);
        }

        // Methods
        // <snip>
        public static string GetSpacedString(string srcString);
        private static int GetBitsPerCharacter();
        public static void AddValue(List<int> values, int value, int bitCount);
        public static int ReadValue(BitArray bitArray, ref int index, int bitCount);
        private void LogBitArray(int bitCount);
        // </snip>
      }
      ```

- `(F4)` The save is a list of corners and voxels too (see `F2`). Also evidenced by `TextSaveSystem`
  having a `SaveToString(List<SaveData.C> corners, List<SaveData.V> voxels)` method.

- `(F5)` There is a `WorldMaster.GetSaveString` method but it's not been seen in logs.

### Musings

- `(M1)` According to Oskar Stålberg ([source](https://twitter.com/ChrisLuv/status/1280448543145197569))
  himself, the first couple of bits "The first couple of bits is just to let me know how many bits
  I need for the different value types".

  I'm not sure if it's literally "a couple" (two) or just the first few bits. See `F3` bit counts.

- `(M2)` Loading string `AAAA` logs has no error but logs:

  ```
  ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection.
  Parameter name: index
    at System.Collections.BitArray.Get (System.Int32 index) [0x00000] in <00000000000000000000000000000000>:0
    at Placemaker.TextSaveSystem.LoadFromString (System.String saveString, System.Collections.Generic.List`1[T] corners, System.Collections.Generic.List`1[T] voxels) [0x00000] in <00000000000000000000000000000000>:0
    at Placemaker.Ui.TextSaveButtons.Button_LoadFromClipboard () [0x00000] in <00000000000000000000000000000000>:0
  <snip>
  ```

  ```
  AAAA = 000000000000000000000000
  ```

- `(M3)` Loading strings (see below) shows the load error message and logs:

  ```
  Bit array has no room for types
  UnityEngine.Logger:Log(LogType, Object)
  UnityEngine.Debug:LogError(Object)
  Placemaker.TextSaveSystem:LoadFromString(String, List`1, List`1)
  Placemaker.Ui.TextSaveButtons:Button_LoadFromClipboard()
  <snip>
  ```

  ```
  AAAB = 000000000000000000000001
  AAAD = 000000000000000000000011
  AAAF = 000000000000000000000101
  AAAH = 000000000000000000000111
  AAAJ = 000000000000000000001001
  AAAL = 000000000000000000001011
  AAAN = 000000000000000000001101
  AAAP = 000000000000000000001111
  AAAR = 000000000000000000010001
  AAAT = 000000000000000000010011
  AAAV = 000000000000000000010101
  AAAX = 000000000000000000010111
  AAAZ = 000000000000000000011001
  AAAb = 000000000000000000011011
  AAAd = 000000000000000000011101
  AAAf = 000000000000000000011111
  ```

- `(M4)` The grid is irregular and we need it to generate valid coordinates. Chris Love has
  done some research on this (([Twitter thread](https://twitter.com/ChrisLuv/status/1280594189412073474))).
  We'll eventually need to solve this.

- `(M5)` There is also a `TextSaveAlphabet` class that might (or might not!) be just a base64 helper.

- `(M6)` Loading string `AAAC` shows the load error message and logs:

  ```
  Invalid voxel value -2/0 at 235 int2(0, 0)
  UnityEngine.Logger:Log(LogType, Object)
  UnityEngine.Debug:LogError(Object)
  Placemaker.TextSaveSystem:LoadFromString(String, List`1, List`1)
  Placemaker.Ui.TextSaveButtons:Button_LoadFromClipboard()
  <snip>
  ```

  ```
  AAAC = 000000000000000000000010
  ```

- `(M7)` Loading strings (see below) loads an empty field that saves again as `AAAE`.

  ```
  AAAE = 000000000000000000000100
  AAAI = 000000000000000000001000
  AAAQ = 000000000000000000010000
  AAAY = 000000000000000000011000
  AAAg = 000000000000000000100000
  ```

- `(M8)` Loading strings (see below) loads a single ground voxel at `(0, 0)` that saves as `AAAG`

  ```
  AAAG = 000000000000000000000110
  AAAK = 000000000000000000001010
  AAAS = 000000000000000000010010
  AAAU = 000000000000000000010100
  AAAa = 000000000000000000011010
  AAAc = 000000000000000000011100
  ```

- `(M9)` Loading a non-base64 string shows the load error message and logs:

  ```
  Bit array has no room for bounds or voxels
  UnityEngine.Logger:Log(LogType, Object)
  UnityEngine.Debug:LogError(Object)
  Placemaker.TextSaveSystem:LoadFromString(String, List`1, List`1)
  Placemaker.Ui.TextSaveButtons:Button_LoadFromClipboard()
  <snip>
  ```

- `(M10)` Loading `AAAE?`, `AAAE¿?`, ... shows the load error message but only logs the wrong string.

- `(M11)` Loading strings (see below) shows the load error message and logs:

  ```
  Not enough bits 2046 1 2046
  UnityEngine.Logger:Log(LogType, Object)
  UnityEngine.Debug:LogError(Object)
  Placemaker.TextSaveSystem:ReadValue(BitArray, Int32&, Int32)
  Placemaker.TextSaveSystem:LoadFromString(String, List`1, List`1)
  Placemaker.Ui.TextSaveButtons:Button_LoadFromClipboard()
  <snip>

  Invalid voxel value -2/0 at 232 int2(0, 0)
  UnityEngine.Logger:Log(LogType, Object)
  UnityEngine.Debug:LogError(Object)
  Placemaker.TextSaveSystem:LoadFromString(String, List`1, List`1)
  Placemaker.Ui.TextSaveButtons:Button_LoadFromClipboard()
  <snip>
  ```

  ```
  AAAM = 000000000000000000001100
  AAAO = 000000000000000000001110
  ```

- `(M12)` At some point I had this log when serially testing `AAAO`-`AAAR` but cannot reproduce:

  ```
  Save int3(0, 0, 0)
  UnityEngine.Logger:Log(LogType, Object)
  UnityEngine.Debug:Log(Object)
  Placemaker.Graphs.Graph:Save(SaveData)
  Placemaker.Ui.TextSaveButtons:Button_CopyToClipboard()
  <snip>
  ```

- `(M13)` Loading strings (see below) logs this but loads fine as `AAAG` (see `M8`):

  ```
  Voxel already exists at int2(0, 0) 0
  UnityEngine.Logger:Log(LogType, Object)
  UnityEngine.Debug:LogError(Object)
  Placemaker.Graphs.Graph:AddVoxel(int2, Byte, VoxelType, Boolean)
  Placemaker.Graphs.Graph:ApplyAction(Action, Boolean)
  Placemaker.Graphs.Graph:IterateLoad(SaveData)
  Placemaker.WorldMaster:Iterate()
  Placemaker.WorldMaster:Update()
  ```

  ```
  AAAW = 000000000000000000010110
  AAAe = 000000000000000000011110
  ```
