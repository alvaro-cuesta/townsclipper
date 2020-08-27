
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


  char cVar2;
  uint something = bitLength
  do {
    local_88 = uVar5;
    uVar12 = something;
    something = uVar12 - 1;
    cVar2 = this.bitArray.get((ulonglong)something, 0)
  } while ((cVar2 == '\0') && (uVar5 = something, 0 < (int)uVar12));

  int readCount = 0

  uint posOffsetsBitLength = reader.read(this.bitArray, &readCount, 5);
  uint yDeltaBitLength = reader.read(this.bitArray, &readCount, 5);
  undefined4 xOffsetBitLengthPre = reader.read(this.bitArray, &readCount, 5);

  if ((int)uVar12 < (int)(readCount + 1 + posOffsetsBitLength * 2))
    throw ERR_NO_ROOM_VOXELS

  int posOffsetsSignOffset
  if (posOffsetsBitLength == 0) {
    posOffsetsSignOffset = 0
  } else {
    posOffsetsSignOffset = 1 << (posOffsetsBitLength - 1)
  }

  int yInitial = reader.read(this.bitArray, &readCount, posOffsetsBitLength)
    - posOffsetsSignOffset
  int xInitial = reader.read(this.bitArray, &readCount, posOffsetsBitLength)
    - posOffsetsSignOffset

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

  uint typeIndexBitLength = 0;
  if (0 < typeCount + 1) {
    uVar5 = 1;
    do {
      typeIndexBitLength = typeIndexBitLength + 1;
      uVar5 = uVar5 << 1 | (uint)((int)uVar5 < 0);
    } while ((int)uVar5 <= typeCount + 1);
  }

  int yPos = yInitial;
  undefined8 xOffsetBitLength = CONCAT44(xOffsetBitLength._4_4_, xOffsetBitLengthPre); // xOffsetBitLength._4_4_ ?¿?¿?¿? undefined !!
  ushort local_94;

  bool isFirst = true;
  int typeStopIndex = (1 << typeIndexBitLength) - 1;

  while (readCount < (int)local_88) {
    if (!isFirst) {
      int isMoveY = reader.read(this.bitArray, &readCount, 1);

      if (isMoveY == 1) {
        int yDelta = reader.read(this.bitArray, &readCount, yDeltaBitLength);
        yPos += yDelta;
      }
    } else {
      isFirst = false;
    }

    uint xPos = xInitial
      + reader.read(this.bitArray, &readCount, xOffsetBitLength);

    int hasGround = reader.read(this.bitArray, &readCount, 1);
    if (hasGround == 1) {
      local_94 = 0x000f;
      voxelList.push(0x000f)
    }

    byte height = 1;

    while( true ) {
      int typeIndex = reader.read(this.bitArray, &readCount, typeIndexBitLength);

      if (typeIndex == typeStopIndex)
        break

      if (typeIndex != 0) {
        uint typeIndexZeroBased = typeIndex - 1;

        if (typeIndexZeroBased >= typeCount || typeIndexZeroBased < 0) {
          throw "Invalid voxel value ${typeIndexZeroBased}/${typeCount} at ${bHeight} int2(${xPos}, ${yPos})"
        }

        voxelList.push([height, typeList[uVar5]])

        if (height == 0xff)
          break
      }

      height += 1;
    }

    cornerList.push([xPos, yPos])
  }

  return true
}
