
ulonglong Placemaker.TextSaveSystem$$LoadFromString
                    (longlong saveString, longlong cornerList, longlong voxelList)

{
  // Hoisted NULL pointer checks (these were intertwined with the code)

  if (saveString == NULL)
    throw ERR_NULL_POINTER

  if (this.bitArray == NULL)
    throw ERR_NULL_POINTER

  if (TextSaveAlphabet.alphabetDict == NULL)
    throw ERR_NULL_POINTER

  if (voxelList == NULL)
    throw ERR_NULL_POINTER

  if (cornerList == NULL)
    throw ERR_NULL_POINTER

  // START

  if (saveString.length == 0)
    return false

  uint bitLength = BITS_PER_CHARACTER * saveString.length

  if (bitLength < 0x14)
    throw ERR_NO_ROOM_BOUNDS_OR_VOXELS

  if (this.bitArray.length < bitLength)
    this.bitArray.setLength(bitLength)

  uint local_88 = bitLength
  uint uVar5 = local_88;
  uint uVar12;

  ulonglong charIndex = 0

  if (0 < saveString.length) {
    do {
      char character = saveString.getChar(charIndex)

      Option<int> charValue = TextSaveAlphabet.alphabetDict.getValue(character)

      if (charValue == None)
        return false

      int iBitCount = 0
      while (iBitCount < BITS_PER_CHARACTER) {
        this.bitArray[iBitCount] = (bool)charValue & 1
        charValue = charValue >> 1
        iBitCount = iBitCount + 1
      }

      uVar12 = (int)charIndex + 1;
      charIndex = (ulonglong)uVar12;
      uVar5 = local_88;
    } while ((int)uVar12 < saveString.length);
  }

  uint something = bitLength

  char cVar2;
  do {
    local_88 = uVar5;
    uVar12 = something;
    something = uVar12 - 1;
    cVar2 = this.bitArray.get((ulonglong)something, 0)
  } while ((cVar2 == '\0') && (uVar5 = something, 0 < (int)uVar12));

  int readCount = 0

  uint someBitLength = reader.read(this.bitArray, &readCount, 5);
  uint local_78 = reader.read(this.bitArray, &readCount, 5);
  undefined4 uVar4 = reader.read(this.bitArray, &readCount, 5);

  if ((int)uVar12 < (int)(readCount + 1 + someBitLength * 2))
    throw ERR_NO_ROOM_VOXELS

  int someIntOffset
  if (someBitLength == 0) {
    someIntOffset = 0;
  } else {
    someIntOffset = 1 << ((char)someBitLength - 1U & 0x1f);
  }

  int local_8c = reader.read(this.bitArray, &readCount, someBitLength);
  local_8c = local_8c - someIntOffset;
  int local_84 = reader.read(this.bitArray, &readCount, someBitLength);
  local_84 = local_84 - someIntOffset;

  if (readCount + 4 > uVar12)
    throw ERR_NO_ROOM_TYPES

  ulonglong typeCount = reader.read(this.bitArray, &readCount, 4);

  if (readCount + typeCount * 4 > uVar12)
    throw ERR_NO_ROOM_TYPES

  longlong typeList = new List<Int>(typeCount)

  int i = 0;
  if (0 < typeCount) {
    do {
      uint typeValue = reader.read(this.bitArray, &readCount, 4);
      typeList.push(typeValue)
      i = i + 1;
    } while (i < typeCount);
  }

  uint uVar16 = 0;
  if (0 < typeCount + 1) {
    uVar5 = 1;
    do {
      uVar16 = uVar16 + 1;
      uVar5 = uVar5 << 1 | (uint)((int)uVar5 < 0);
    } while ((int)uVar5 <= typeCount + 1);
  }

  int iVar11 = (1 << ((byte)uVar16 & 0x1f)) + -1;
  local_res8[0] = 1;
  int iVar10 = local_8c;
  int local_7c = iVar11;
  undefined8 local_70 = CONCAT44(local_70._4_4_, uVar4); // local_70._4_4_ ?¿?¿?¿? undefined !!

  byte local_res8 [8];
  uint local_80;
  ushort local_94;
  int iVar13;
  byte bHeight;

  while (readCount < (int)local_88) {
    if (local_res8[0] == 0) {
      int local_1337 = reader.read(this.bitArray, &readCount, 1);

      if (local_1337 == 1) {
        int local_1338 = reader.read(this.bitArray, &readCount, (ulonglong)local_78);
        iVar10 = iVar10 + local_1338;
        local_8c = iVar10;
      }
    } else {
      local_res8[0] = 0;
    }

    int local_1339 = reader.read(this.bitArray, &readCount, local_70 & 0xffffffff);
    iVar13 = 0;
    local_80 = local_1339 + local_84;
    undefined8 local_68 = CONCAT44(local_80,iVar10);

    int local_1340 = reader.read(this.bitArray, &readCount, 1);
    if (local_1340 == 1) {
      local_94 = 0xf;
      System.Collections.Generic.List<ByteFloat2>$$Add(voxelList, 0xf, Method$System.Collections.Generic.List<SaveData.V>.Add());
      iVar13 = 1;
    }

    bHeight = 1;

    while( true ) {
      int local_1341 = reader.read(this.bitArray, &readCount, (ulonglong)uVar16);

      if (local_1341 == iVar11)
        break

      if (local_1341 != 0) {
        uVar5 = local_1341 - 1;

        if ((typeCount <= (int)uVar5) || ((int)uVar5 < 0)) {
          local_res8[0] = bHeight;

          throw "Invalid voxel value {0}/{1} at {2} {3}".format(
            <int>(uVar5),
            <int>(typeCount),
            <byte>(local_res8),
            <Unity.Mathematics.int2>(local_68),
          )
        }

        local_94 = local_94 & 0xff | (ushort)bHeight << 8;
        byte bVar3 = FUN_180002290(typeList, (ulonglong)uVar5, Method$System.Collections.Generic.List<int>.get_Item());
        local_94 = local_94 & 0xff00 | (ushort)bVar3;
        System.Collections.Generic.List<ByteFloat2>$$Add(voxelList, (ulonglong)local_94);

        iVar13 = iVar13 + 1;
        iVar11 = local_7c;

        if (bHeight == 0xff)
          break
      }

      bHeight = bHeight + 1;
    }

    iVar10 = local_8c;
    uint uStack92 = local_80; // unused?
    int local_60 = local_8c; // unused?
    int local_40 = iVar13;  // unused?

    undefined8 local_48 = CONCAT44(local_80, local_8c);
    System.Collections.Generic.List<SaveData.C>$$Add(cornerList, &local_48);
  }

  return true
}
