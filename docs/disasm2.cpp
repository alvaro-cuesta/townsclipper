
ulonglong Placemaker.TextSaveSystem$$LoadFromString
                    (longlong param_1,longlong param_2,longlong param_3)

{
  code *pcVar1;
  char cVar2;
  byte bVar3;
  undefined4 uVar4;
  uint uVar5;
  int iVar6;
  ulonglong in_RAX;
  longlong lVar7;
  longlong lVar8;
  undefined8 uVar9;
  int iVar10;
  int iVar11;
  uint uVar12;
  int iVar13;
  ulonglong uVar14;
  byte bVar15;
  uint uVar16;
  int iVar17;
  byte local_res8 [8];
  longlong local_res10;
  int local_98;
  ushort local_94;
  int local_90;
  int local_8c;
  uint local_88;
  int local_84;
  uint local_80;
  int local_7c;
  uint local_78;
  undefined8 local_70;
  undefined8 local_68;
  int local_60;
  uint uStack92;
  undefined8 local_48;
  int local_40;

  local_res10 = param_2;
  if (DAT_18103bd47 == '\0') {
    in_RAX = thunk_FUN_1800d93d0(0x45db);
    DAT_18103bd47 = '\x01';
  }
  uVar14 = 0;
  local_90 = 0;
  local_68 = 0;
  if (param_1 == 0) goto LAB_180b41983;
  iVar6 = *(int *)(param_1 + 0x10);
  if (iVar6 != 0) {
    uVar16 = *(int *)(*(longlong *)(Placemaker.TextSaveSystem_TypeInfo + 0xb8) + 0x10) * iVar6;
    local_88 = uVar16;
    if ((int)uVar16 < 0x14) {
      uVar9 = StringLiteral_7212;
    }
    else {
      if (**(longlong **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8) == 0) {
LAB_180b41983:
        FUN_1801108e0();
        pcVar1 = (code *)swi(3);
        uVar9 = (*pcVar1)();
        return uVar9;
      }
      if (*(int *)(**(longlong **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8) + 0x18) < (int)uVar16)
      {
        if (**(longlong **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8) == 0) goto LAB_180b41983;
        System.Collections.BitArray$$set_Length
                  (**(longlong **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),(ulonglong)uVar16,0);
      }
      uVar5 = local_88;
      if (0 < iVar6) {
        do {
          System.String$$get_Chars(param_1,uVar14,0);
          if (*(longlong *)(*(longlong *)(Placemaker.TextSaveAlphabet_TypeInfo + 0xb8) + 8) == 0)
          goto LAB_180b41983;
          in_RAX = System.Collections.Generic.Dictionary<char,-int>$$TryGetValue();
          if ((char)in_RAX == '\0') goto LAB_180b418ff;
          iVar10 = 0;
          while( true ) {
            if (*(int *)(*(longlong *)(Placemaker.TextSaveSystem_TypeInfo + 0xb8) + 0x10) <= iVar10)
            break;
            if (**(longlong **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8) == 0) goto LAB_180b41983;
            System.Collections.BitArray$$set_Item();
            local_90 = local_90 >> 1;
            iVar10 = iVar10 + 1;
          }
          uVar12 = (int)uVar14 + 1;
          uVar14 = (ulonglong)uVar12;
          uVar5 = local_88;
        } while ((int)uVar12 < iVar6);
      }
      do {
        local_88 = uVar5;
        uVar12 = uVar16;
        if (**(longlong **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8) == 0) goto LAB_180b41983;
        uVar16 = uVar12 - 1;
        cVar2 = System.Collections.BitArray$$get_Item
                          (**(longlong **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),
                           (ulonglong)uVar16,0);
      } while ((cVar2 == '\0') && (uVar5 = uVar16, 0 < (int)uVar12));
      local_98 = 0;
      uVar16 = Placemaker.TextSaveSystem$$ReadValue
                         (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),&local_98,5);
      local_78 = Placemaker.TextSaveSystem$$ReadValue
                           (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),&local_98,5
                           );
      uVar4 = Placemaker.TextSaveSystem$$ReadValue
                        (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),&local_98,5);
      local_70 = CONCAT44(local_70._4_4_,uVar4);
      if ((int)uVar12 < (int)(local_98 + 1 + uVar16 * 2)) {
        uVar9 = StringLiteral_7213;
      }
      else {
        if (uVar16 == 0) {
          iVar6 = 0;
        }
        else {
          iVar6 = 1 << ((char)uVar16 - 1U & 0x1f);
        }
        local_8c = Placemaker.TextSaveSystem$$ReadValue
                             (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),&local_98
                              ,(ulonglong)uVar16,0);
        local_8c = local_8c - iVar6;
        local_84 = Placemaker.TextSaveSystem$$ReadValue
                             (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),&local_98
                              ,(ulonglong)uVar16,0);
        local_84 = local_84 - iVar6;
        if (local_98 + 4 <= (int)uVar12) {
          uVar14 = Placemaker.TextSaveSystem$$ReadValue
                             (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),&local_98
                              ,4);
          iVar6 = local_98;
          if (local_98 + (int)uVar14 * 4 <= (int)uVar12) {
            iVar17 = (int)(uVar14 & 0xffffffff);
            lVar7 = Os.Utils.ListPool<byte>$$Get
                              (uVar14 & 0xffffffff,Method$Os.Utils.ListPool<int>.Get());
            iVar10 = 0;
            if (0 < iVar17) {
              do {
                uVar16 = Placemaker.TextSaveSystem$$ReadValue
                                   (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),
                                    &local_98,4);
                if (lVar7 == 0) goto LAB_180b41983;
                System.Collections.Generic.List<int>$$Add(lVar7,(ulonglong)uVar16);
                iVar10 = iVar10 + 1;
                iVar6 = local_98;
              } while (iVar10 < iVar17);
            }
            uVar16 = 0;
            if (0 < iVar17 + 1) {
              uVar5 = 1;
              do {
                uVar16 = uVar16 + 1;
                uVar5 = uVar5 << 1 | (uint)((int)uVar5 < 0);
              } while ((int)uVar5 <= iVar17 + 1);
            }
            iVar11 = (1 << ((byte)uVar16 & 0x1f)) + -1;
            local_res8[0] = 1;
            iVar10 = local_8c;
            local_7c = iVar11;
            if (iVar6 < (int)local_88) {
              do {
                if (local_res8[0] == 0) {
                  iVar6 = Placemaker.TextSaveSystem$$ReadValue
                                    (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),
                                     &local_98,1);
                  if (iVar6 == 1) {
                    iVar6 = Placemaker.TextSaveSystem$$ReadValue
                                      (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),
                                       &local_98,(ulonglong)local_78);
                    iVar10 = iVar10 + iVar6;
                    local_8c = iVar10;
                  }
                }
                else {
                  local_res8[0] = 0;
                }
                iVar6 = Placemaker.TextSaveSystem$$ReadValue
                                  (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),
                                   &local_98,local_70 & 0xffffffff);
                iVar13 = 0;
                local_80 = iVar6 + local_84;
                local_68 = CONCAT44(local_80,iVar10);
                iVar6 = Placemaker.TextSaveSystem$$ReadValue
                                  (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),
                                   &local_98,1);
                if (iVar6 == 1) {
                  local_94 = 0xf;
                  if (param_3 == 0) goto LAB_180b41983;
                  System.Collections.Generic.List<ByteFloat2>$$Add
                            (param_3,0xf,Method$System.Collections.Generic.List<SaveData.V>.Add());
                  iVar13 = 1;
                }
                bVar15 = 1;
                while( true ) {
                  iVar6 = Placemaker.TextSaveSystem$$ReadValue
                                    (**(undefined8 **)(Placemaker.TextSaveSystem_TypeInfo + 0xb8),
                                     &local_98,(ulonglong)uVar16);
                  if (iVar6 == iVar11) break;
                  if (iVar6 != 0) {
                    uVar5 = iVar6 - 1;
                    if ((iVar17 <= (int)uVar5) || ((int)uVar5 < 0)) {
                      lVar8 = FUN_180110580(object[]_TypeInfo,4);
                      local_80 = uVar5;
                      uVar9 = il2cpp_value_box(int_TypeInfo,&local_80);
                      if (lVar8 == 0) {
                        FUN_1801108e0();
                        pcVar1 = (code *)swi(3);
                        uVar9 = (*pcVar1)();
                        return uVar9;
                      }
                      FUN_180001ed0(lVar8,uVar9);
                      if (*(int *)(lVar8 + 0x18) == 0) {
                        uVar9 = thunk_FUN_1800cfbf0();
                        FUN_1801108b0(uVar9,0);
                        pcVar1 = (code *)swi(3);
                        uVar9 = (*pcVar1)();
                        return uVar9;
                      }
                      *(undefined8 *)(lVar8 + 0x20) = uVar9;
                      local_84 = iVar17;
                      uVar9 = il2cpp_value_box(int_TypeInfo,&local_84);
                      FUN_180001ed0(lVar8,uVar9);
                      if (*(uint *)(lVar8 + 0x18) < 2) {
                        uVar9 = thunk_FUN_1800cfbf0();
                        FUN_1801108b0(uVar9,0);
                        pcVar1 = (code *)swi(3);
                        uVar9 = (*pcVar1)();
                        return uVar9;
                      }
                      *(undefined8 *)(lVar8 + 0x28) = uVar9;
                      local_res8[0] = bVar15;
                      uVar9 = il2cpp_value_box(byte_TypeInfo,local_res8);
                      FUN_180001ed0(lVar8,uVar9);
                      if (*(uint *)(lVar8 + 0x18) < 3) {
                        uVar9 = thunk_FUN_1800cfbf0();
                        FUN_1801108b0(uVar9,0);
                        pcVar1 = (code *)swi(3);
                        uVar9 = (*pcVar1)();
                        return uVar9;
                      }
                      *(undefined8 *)(lVar8 + 0x30) = uVar9;
                      local_70 = local_68;
                      uVar9 = il2cpp_value_box(Unity.Mathematics.int2_TypeInfo,&local_70);
                      FUN_180001ed0(lVar8,uVar9);
                      if (*(uint *)(lVar8 + 0x18) < 4) {
                        uVar9 = thunk_FUN_1800cfbf0();
                        FUN_1801108b0(uVar9,0);
                        pcVar1 = (code *)swi(3);
                        uVar9 = (*pcVar1)();
                        return uVar9;
                      }
                      *(undefined8 *)(lVar8 + 0x38) = uVar9;
                      uVar9 = System.String$$Format(StringLiteral_7215,lVar8,0);
                      UnityEngine.Debug$$LogError(uVar9,0);
                      in_RAX = Os.Utils.DictPoolExtension$$ReturnToPool<int,-int>
                                         (lVar7,
                                          Method$Os.Utils.ListPoolExtension.ReturnToPool<int>());
                      goto LAB_180b418ff;
                    }
                    if (lVar7 == 0) goto LAB_180b41983;
                    local_94 = local_94 & 0xff | (ushort)bVar15 << 8;
                    bVar3 = FUN_180002290(lVar7,(ulonglong)uVar5,
                                          Method$System.Collections.Generic.List<int>.get_Item());
                    local_94 = local_94 & 0xff00 | (ushort)bVar3;
                    if (param_3 == 0) goto LAB_180b41983;
                    System.Collections.Generic.List<ByteFloat2>$$Add(param_3,(ulonglong)local_94);
                    iVar13 = iVar13 + 1;
                    iVar11 = local_7c;
                    if (bVar15 == 0xff) break;
                  }
                  bVar15 = bVar15 + 1;
                }
                iVar10 = local_8c;
                uStack92 = local_80;
                local_60 = local_8c;
                if (local_res10 == 0) goto LAB_180b41983;
                local_48 = CONCAT44(local_80,local_8c);
                local_40 = iVar13;
                System.Collections.Generic.List<SaveData.C>$$Add(local_res10,&local_48);
              } while (local_98 < (int)local_88);
            }
            uVar9 = Os.Utils.DictPoolExtension$$ReturnToPool<int,-int>
                              (lVar7,Method$Os.Utils.ListPoolExtension.ReturnToPool<int>());
            return CONCAT71((int7)((ulonglong)uVar9 >> 8),1);
          }
        }
        uVar9 = StringLiteral_7214;
      }
    }
    in_RAX = UnityEngine.Debug$$LogError(uVar9,0);
  }
LAB_180b418ff:
  return in_RAX & 0xffffffffffffff00;
}
