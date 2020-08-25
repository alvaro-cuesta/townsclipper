/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using CielaSpike;
using Os.Utils;
using Placemaker;
using Placemaker.Graphs;
using Placemaker.Life;
using Placemaker.Modules;
using Placemaker.Props;
using Placemaker.Quads;
using Placemaker.Quads.GridGeneration;
using Placemaker.Ui;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.UI;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1606
[assembly: AssemblyCompany] // 0x0000000180117B50-0x0000000180117EA0
[assembly: AssemblyCopyright] // 0x0000000180117B50-0x0000000180117EA0
[assembly: AssemblyDefaultAlias] // 0x0000000180117B50-0x0000000180117EA0
[assembly: AssemblyDelaySign] // 0x0000000180117B50-0x0000000180117EA0
[assembly: AssemblyDescription] // 0x0000000180117B50-0x0000000180117EA0
[assembly: AssemblyFileVersion] // 0x0000000180117B50-0x0000000180117EA0
[assembly: AssemblyInformationalVersion] // 0x0000000180117B50-0x0000000180117EA0
[assembly: AssemblyKeyFile] // 0x0000000180117B50-0x0000000180117EA0
[assembly: AssemblyProduct] // 0x0000000180117B50-0x0000000180117EA0
[assembly: AssemblyTitle] // 0x0000000180117B50-0x0000000180117EA0
[assembly: CLSCompliant] // 0x0000000180117B50-0x0000000180117EA0
[assembly: ComCompatibleVersion] // 0x0000000180117B50-0x0000000180117EA0
[assembly: CompilationRelaxations] // 0x0000000180117B50-0x0000000180117EA0
[assembly: ComVisible] // 0x0000000180117B50-0x0000000180117EA0
[assembly: Debuggable] // 0x0000000180117B50-0x0000000180117EA0
[assembly: DefaultDependency] // 0x0000000180117B50-0x0000000180117EA0
[assembly: Guid] // 0x0000000180117B50-0x0000000180117EA0
[assembly: InternalsVisibleTo] // 0x0000000180117B50-0x0000000180117EA0
[assembly: InternalsVisibleTo] // 0x0000000180117B50-0x0000000180117EA0
[assembly: InternalsVisibleTo] // 0x0000000180117B50-0x0000000180117EA0
[assembly: InternalsVisibleTo] // 0x0000000180117B50-0x0000000180117EA0
[assembly: InternalsVisibleTo] // 0x0000000180117B50-0x0000000180117EA0
[assembly: NeutralResourcesLanguage] // 0x0000000180117B50-0x0000000180117EA0
[assembly: RuntimeCompatibility] // 0x0000000180117B50-0x0000000180117EA0
[assembly: SatelliteContractVersion] // 0x0000000180117B50-0x0000000180117EA0
[assembly: StringFreezing] // 0x0000000180117B50-0x0000000180117EA0

// Image 32: UnityEngine.AndroidJNIModule.dll - Assembly: UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4304-4317
[assembly: CompilationRelaxations] // 0x00000001801348B0-0x0000000180135BA0
[assembly: Debuggable] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: InternalsVisibleTo] // 0x00000001801348B0-0x0000000180135BA0
[assembly: RuntimeCompatibility] // 0x00000001801348B0-0x0000000180135BA0
[assembly: UnityEngineModuleAssembly] // 0x00000001801348B0-0x0000000180135BA0

// Image 30: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4141-4300
[assembly: CompilationRelaxations] // 0x00000001801277F0-0x00000001801278A0
[assembly: Debuggable] // 0x00000001801277F0-0x00000001801278A0
[assembly: InternalsVisibleTo] // 0x00000001801277F0-0x00000001801278A0
[assembly: InternalsVisibleTo] // 0x00000001801277F0-0x00000001801278A0
[assembly: RuntimeCompatibility] // 0x00000001801277F0-0x00000001801278A0

// Image 2: Mono.Security.dll - Assembly: Mono.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1617-1690
[assembly: AssemblyCompany] // 0x000000018011AAE0-0x000000018011AC60
[assembly: AssemblyCopyright] // 0x000000018011AAE0-0x000000018011AC60
[assembly: AssemblyDelaySign] // 0x000000018011AAE0-0x000000018011AC60
[assembly: AssemblyDescription] // 0x000000018011AAE0-0x000000018011AC60
[assembly: AssemblyProduct] // 0x000000018011AAE0-0x000000018011AC60
[assembly: AssemblyTitle] // 0x000000018011AAE0-0x000000018011AC60
[assembly: CLSCompliant] // 0x000000018011AAE0-0x000000018011AC60
[assembly: CompilationRelaxations] // 0x000000018011AAE0-0x000000018011AC60
[assembly: ComVisible] // 0x000000018011AAE0-0x000000018011AC60
[assembly: Debuggable] // 0x000000018011AAE0-0x000000018011AC60
[assembly: InternalsVisibleTo] // 0x000000018011AAE0-0x000000018011AC60
[assembly: NeutralResourcesLanguage] // 0x000000018011AAE0-0x000000018011AC60
[assembly: RuntimeCompatibility] // 0x000000018011AAE0-0x000000018011AC60

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1691-2120
[assembly: AssemblyCompany] // 0x000000018011EDB0-0x000000018011F090
[assembly: AssemblyCopyright] // 0x000000018011EDB0-0x000000018011F090
[assembly: AssemblyDefaultAlias] // 0x000000018011EDB0-0x000000018011F090
[assembly: AssemblyDelaySign] // 0x000000018011EDB0-0x000000018011F090
[assembly: AssemblyDescription] // 0x000000018011EDB0-0x000000018011F090
[assembly: AssemblyFileVersion] // 0x000000018011EDB0-0x000000018011F090
[assembly: AssemblyInformationalVersion] // 0x000000018011EDB0-0x000000018011F090
[assembly: AssemblyKeyFile] // 0x000000018011EDB0-0x000000018011F090
[assembly: AssemblyProduct] // 0x000000018011EDB0-0x000000018011F090
[assembly: AssemblyTitle] // 0x000000018011EDB0-0x000000018011F090
[assembly: CLSCompliant] // 0x000000018011EDB0-0x000000018011F090
[assembly: CompilationRelaxations] // 0x000000018011EDB0-0x000000018011F090
[assembly: ComVisible] // 0x000000018011EDB0-0x000000018011F090
[assembly: Debuggable] // 0x000000018011EDB0-0x000000018011F090
[assembly: InternalsVisibleTo] // 0x000000018011EDB0-0x000000018011F090
[assembly: InternalsVisibleTo] // 0x000000018011EDB0-0x000000018011F090
[assembly: InternalsVisibleTo] // 0x000000018011EDB0-0x000000018011F090
[assembly: InternalsVisibleTo] // 0x000000018011EDB0-0x000000018011F090
[assembly: InternalsVisibleTo] // 0x000000018011EDB0-0x000000018011F090
[assembly: NeutralResourcesLanguage] // 0x000000018011EDB0-0x000000018011F090
[assembly: RuntimeCompatibility] // 0x000000018011EDB0-0x000000018011F090
[assembly: SatelliteContractVersion] // 0x000000018011EDB0-0x000000018011F090

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2121-2604
[assembly: AssemblyCompany] // 0x0000000180126A80-0x0000000180126D30
[assembly: AssemblyCopyright] // 0x0000000180126A80-0x0000000180126D30
[assembly: AssemblyDefaultAlias] // 0x0000000180126A80-0x0000000180126D30
[assembly: AssemblyDelaySign] // 0x0000000180126A80-0x0000000180126D30
[assembly: AssemblyDescription] // 0x0000000180126A80-0x0000000180126D30
[assembly: AssemblyFileVersion] // 0x0000000180126A80-0x0000000180126D30
[assembly: AssemblyInformationalVersion] // 0x0000000180126A80-0x0000000180126D30
[assembly: AssemblyKeyFile] // 0x0000000180126A80-0x0000000180126D30
[assembly: AssemblyProduct] // 0x0000000180126A80-0x0000000180126D30
[assembly: AssemblyTitle] // 0x0000000180126A80-0x0000000180126D30
[assembly: CLSCompliant] // 0x0000000180126A80-0x0000000180126D30
[assembly: CompilationRelaxations] // 0x0000000180126A80-0x0000000180126D30
[assembly: ComVisible] // 0x0000000180126A80-0x0000000180126D30
[assembly: Debuggable] // 0x0000000180126A80-0x0000000180126D30
[assembly: InternalsVisibleTo] // 0x0000000180126A80-0x0000000180126D30
[assembly: InternalsVisibleTo] // 0x0000000180126A80-0x0000000180126D30
[assembly: InternalsVisibleTo] // 0x0000000180126A80-0x0000000180126D30
[assembly: InternalsVisibleTo] // 0x0000000180126A80-0x0000000180126D30
[assembly: NeutralResourcesLanguage] // 0x0000000180126A80-0x0000000180126D30
[assembly: RuntimeCompatibility] // 0x0000000180126A80-0x0000000180126D30
[assembly: SatelliteContractVersion] // 0x0000000180126A80-0x0000000180126D30

// Image 5: System.Core.dll - Assembly: System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2605-2648
[assembly: AssemblyCompany] // 0x000000018012D2E0-0x000000018012D500
[assembly: AssemblyCopyright] // 0x000000018012D2E0-0x000000018012D500
[assembly: AssemblyDefaultAlias] // 0x000000018012D2E0-0x000000018012D500
[assembly: AssemblyDelaySign] // 0x000000018012D2E0-0x000000018012D500
[assembly: AssemblyDescription] // 0x000000018012D2E0-0x000000018012D500
[assembly: AssemblyFileVersion] // 0x000000018012D2E0-0x000000018012D500
[assembly: AssemblyInformationalVersion] // 0x000000018012D2E0-0x000000018012D500
[assembly: AssemblyKeyFile] // 0x000000018012D2E0-0x000000018012D500
[assembly: AssemblyProduct] // 0x000000018012D2E0-0x000000018012D500
[assembly: AssemblyTitle] // 0x000000018012D2E0-0x000000018012D500
[assembly: CLSCompliant] // 0x000000018012D2E0-0x000000018012D500
[assembly: CompilationRelaxations] // 0x000000018012D2E0-0x000000018012D500
[assembly: ComVisible] // 0x000000018012D2E0-0x000000018012D500
[assembly: Debuggable] // 0x000000018012D2E0-0x000000018012D500
[assembly: NeutralResourcesLanguage] // 0x000000018012D2E0-0x000000018012D500
[assembly: RuntimeCompatibility] // 0x000000018012D2E0-0x000000018012D500
[assembly: SatelliteContractVersion] // 0x000000018012D2E0-0x000000018012D500

// Image 26: UnityEngine.UI.dll - Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3399-3594
[assembly: AssemblyCompany] // 0x000000018012DB80-0x000000018012DD40
[assembly: AssemblyConfiguration] // 0x000000018012DB80-0x000000018012DD40
[assembly: AssemblyCopyright] // 0x000000018012DB80-0x000000018012DD40
[assembly: AssemblyDescription] // 0x000000018012DB80-0x000000018012DD40
[assembly: AssemblyFileVersion] // 0x000000018012DB80-0x000000018012DD40
[assembly: AssemblyProduct] // 0x000000018012DB80-0x000000018012DD40
[assembly: AssemblyTitle] // 0x000000018012DB80-0x000000018012DD40
[assembly: AssemblyTrademark] // 0x000000018012DB80-0x000000018012DD40
[assembly: CompilationRelaxations] // 0x000000018012DB80-0x000000018012DD40
[assembly: ComVisible] // 0x000000018012DB80-0x000000018012DD40
[assembly: Debuggable] // 0x000000018012DB80-0x000000018012DD40
[assembly: Guid] // 0x000000018012DB80-0x000000018012DD40
[assembly: InternalsVisibleTo] // 0x000000018012DB80-0x000000018012DD40
[assembly: RuntimeCompatibility] // 0x000000018012DB80-0x000000018012DD40

// Image 45: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4571-4942
[assembly: CompilationRelaxations] // 0x0000000180129220-0x0000000180129290
[assembly: Debuggable] // 0x0000000180129220-0x0000000180129290
[assembly: RuntimeCompatibility] // 0x0000000180129220-0x0000000180129290

// Image 28: Unity.InputSystem.dll - Assembly: Unity.InputSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3599-4111
[assembly: CompilationRelaxations] // 0x000000018014A750-0x000000018014A820
[assembly: Debuggable] // 0x000000018014A750-0x000000018014A820
[assembly: InternalsVisibleTo] // 0x000000018014A750-0x000000018014A820
[assembly: InternalsVisibleTo] // 0x000000018014A750-0x000000018014A820
[assembly: InternalsVisibleTo] // 0x000000018014A750-0x000000018014A820
[assembly: RuntimeCompatibility] // 0x000000018014A750-0x000000018014A820

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 2676-3191
[assembly: CompilationRelaxations] // 0x0000000180138010-0x0000000180139330
[assembly: Debuggable] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: InternalsVisibleTo] // 0x0000000180138010-0x0000000180139330
[assembly: RuntimeCompatibility] // 0x0000000180138010-0x0000000180139330
[assembly: UnityEngineModuleAssembly] // 0x0000000180138010-0x0000000180139330

// Image 18: UnityEngine.UIModule.dll - Assembly: UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3316-3326
[assembly: CompilationRelaxations] // 0x0000000180113900-0x0000000180114BF0
[assembly: Debuggable] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: InternalsVisibleTo] // 0x0000000180113900-0x0000000180114BF0
[assembly: RuntimeCompatibility] // 0x0000000180113900-0x0000000180114BF0
[assembly: UnityEngineModuleAssembly] // 0x0000000180113900-0x0000000180114BF0

// Image 40: UnityEngine.UnityAnalyticsModule.dll - Assembly: UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4520-4530
[assembly: CompilationRelaxations] // 0x0000000180118260-0x0000000180119550
[assembly: Debuggable] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: InternalsVisibleTo] // 0x0000000180118260-0x0000000180119550
[assembly: RuntimeCompatibility] // 0x0000000180118260-0x0000000180119550
[assembly: UnityEngineModuleAssembly] // 0x0000000180118260-0x0000000180119550

// Image 14: UnityEngine.AnimationModule.dll - Assembly: UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3237-3265
[assembly: CompilationRelaxations] // 0x000000018013D750-0x000000018013EA50
[assembly: Debuggable] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: InternalsVisibleTo] // 0x000000018013D750-0x000000018013EA50
[assembly: RuntimeCompatibility] // 0x000000018013D750-0x000000018013EA50
[assembly: UnityEngineModuleAssembly] // 0x000000018013D750-0x000000018013EA50

// Image 33: UnityEngine.AssetBundleModule.dll - Assembly: UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4318-4321
[assembly: CompilationRelaxations] // 0x000000018013B630-0x000000018013C940
[assembly: Debuggable] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: InternalsVisibleTo] // 0x000000018013B630-0x000000018013C940
[assembly: RuntimeCompatibility] // 0x000000018013B630-0x000000018013C940
[assembly: UnityEngineModuleAssembly] // 0x000000018013B630-0x000000018013C940

// Image 6: UnityEngine.SharedInternalsModule.dll - Assembly: UnityEngine.SharedInternalsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 2649-2675
[assembly: CompilationRelaxations] // 0x00000001801302A0-0x0000000180131590
[assembly: Debuggable] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: InternalsVisibleTo] // 0x00000001801302A0-0x0000000180131590
[assembly: RuntimeCompatibility] // 0x00000001801302A0-0x0000000180131590
[assembly: UnityEngineModuleAssembly] // 0x00000001801302A0-0x0000000180131590

// Image 21: UnityEngine.AudioModule.dll - Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3372
[assembly: CompilationRelaxations] // 0x000000018011D390-0x000000018011E700
[assembly: Debuggable] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: InternalsVisibleTo] // 0x000000018011D390-0x000000018011E700
[assembly: RuntimeCompatibility] // 0x000000018011D390-0x000000018011E700
[assembly: UnityEngineModuleAssembly] // 0x000000018011D390-0x000000018011E700

// Image 19: UnityEngine.XRModule.dll - Assembly: UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3327-3354
[assembly: CompilationRelaxations] // 0x00000001801164E0-0x00000001801177D0
[assembly: Debuggable] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: InternalsVisibleTo] // 0x00000001801164E0-0x00000001801177D0
[assembly: RuntimeCompatibility] // 0x00000001801164E0-0x00000001801177D0
[assembly: UnityEngineModuleAssembly] // 0x00000001801164E0-0x00000001801177D0

// Image 39: UnityEngine.UIElementsModule.dll - Assembly: UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4365-4519
[assembly: CompilationRelaxations] // 0x0000000180155F40-0x0000000180157240
[assembly: Debuggable] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: InternalsVisibleTo] // 0x0000000180155F40-0x0000000180157240
[assembly: RuntimeCompatibility] // 0x0000000180155F40-0x0000000180157240
[assembly: UnityEngineModuleAssembly] // 0x0000000180155F40-0x0000000180157240

// Image 11: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3195-3209
[assembly: CompilationRelaxations] // 0x000000018012EB90-0x000000018012FE90
[assembly: Debuggable] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: InternalsVisibleTo] // 0x000000018012EB90-0x000000018012FE90
[assembly: RuntimeCompatibility] // 0x000000018012EB90-0x000000018012FE90
[assembly: UnityEngineModuleAssembly] // 0x000000018012EB90-0x000000018012FE90

// Image 16: UnityEngine.InputLegacyModule.dll - Assembly: UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3298-3306
[assembly: CompilationRelaxations] // 0x00000001801576E0-0x00000001801589D0
[assembly: Debuggable] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: InternalsVisibleTo] // 0x00000001801576E0-0x00000001801589D0
[assembly: RuntimeCompatibility] // 0x00000001801576E0-0x00000001801589D0
[assembly: UnityEngineModuleAssembly] // 0x00000001801576E0-0x00000001801589D0

// Image 41: UnityEngine.UnityWebRequestModule.dll - Assembly: UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4531-4543
[assembly: CompilationRelaxations] // 0x000000018011B720-0x000000018011CA10
[assembly: Debuggable] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: InternalsVisibleTo] // 0x000000018011B720-0x000000018011CA10
[assembly: RuntimeCompatibility] // 0x000000018011B720-0x000000018011CA10
[assembly: UnityEngineModuleAssembly] // 0x000000018011B720-0x000000018011CA10

// Image 17: UnityEngine.Physics2DModule.dll - Assembly: UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3307-3315
[assembly: CompilationRelaxations] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: Debuggable] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: InternalsVisibleTo] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: RuntimeCompatibility] // 0x000000018015A5E0-0x000000018015B8E0
[assembly: UnityEngineModuleAssembly] // 0x000000018015A5E0-0x000000018015B8E0

// Image 1: System.Configuration.dll - Assembly: System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 1607-1616
[assembly: AssemblyCompany] // 0x000000018011A400-0x000000018011A610
[assembly: AssemblyCopyright] // 0x000000018011A400-0x000000018011A610
[assembly: AssemblyDefaultAlias] // 0x000000018011A400-0x000000018011A610
[assembly: AssemblyDescription] // 0x000000018011A400-0x000000018011A610
[assembly: AssemblyFileVersion] // 0x000000018011A400-0x000000018011A610
[assembly: AssemblyInformationalVersion] // 0x000000018011A400-0x000000018011A610
[assembly: AssemblyProduct] // 0x000000018011A400-0x000000018011A610
[assembly: AssemblyTitle] // 0x000000018011A400-0x000000018011A610
[assembly: CLSCompliant] // 0x000000018011A400-0x000000018011A610
[assembly: ComCompatibleVersion] // 0x000000018011A400-0x000000018011A610
[assembly: CompilationRelaxations] // 0x000000018011A400-0x000000018011A610
[assembly: ComVisible] // 0x000000018011A400-0x000000018011A610
[assembly: Debuggable] // 0x000000018011A400-0x000000018011A610
[assembly: DefaultDllImportSearchPaths] // 0x000000018011A400-0x000000018011A610
[assembly: NeutralResourcesLanguage] // 0x000000018011A400-0x000000018011A610
[assembly: RuntimeCompatibility] // 0x000000018011A400-0x000000018011A610
[assembly: SatelliteContractVersion] // 0x000000018011A400-0x000000018011A610

// Image 15: UnityEngine.IMGUIModule.dll - Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3266-3297
[assembly: CompilationRelaxations] // 0x0000000180144EC0-0x00000001801461B0
[assembly: Debuggable] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: InternalsVisibleTo] // 0x0000000180144EC0-0x00000001801461B0
[assembly: RuntimeCompatibility] // 0x0000000180144EC0-0x00000001801461B0
[assembly: UnityEngineModuleAssembly] // 0x0000000180144EC0-0x00000001801461B0

// Image 25: UnityEngine.TextCoreModule.dll - Assembly: UnityEngine.TextCoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3384-3398
[assembly: CompilationRelaxations] // 0x0000000180129790-0x000000018012AC10
[assembly: Debuggable] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: InternalsVisibleTo] // 0x0000000180129790-0x000000018012AC10
[assembly: RuntimeCompatibility] // 0x0000000180129790-0x000000018012AC10
[assembly: UnityEngineModuleAssembly] // 0x0000000180129790-0x000000018012AC10

// Image 29: Unity.Mathematics.dll - Assembly: Unity.Mathematics, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4112-4140
[assembly: CompilationRelaxations] // 0x0000000180127060-0x00000001801270B0
[assembly: Debuggable] // 0x0000000180127060-0x00000001801270B0
[assembly: RuntimeCompatibility] // 0x0000000180127060-0x00000001801270B0

// Image 13: UnityEngine.TextRenderingModule.dll - Assembly: UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3222-3236
[assembly: CompilationRelaxations] // 0x0000000180139540-0x000000018013A830
[assembly: Debuggable] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: InternalsVisibleTo] // 0x0000000180139540-0x000000018013A830
[assembly: RuntimeCompatibility] // 0x0000000180139540-0x000000018013A830
[assembly: UnityEngineModuleAssembly] // 0x0000000180139540-0x000000018013A830

// Image 22: UnityEngine.GridModule.dll - Assembly: UnityEngine.GridModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3373-3374
[assembly: CompilationRelaxations] // 0x0000000180121B80-0x0000000180122E70
[assembly: Debuggable] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: InternalsVisibleTo] // 0x0000000180121B80-0x0000000180122E70
[assembly: RuntimeCompatibility] // 0x0000000180121B80-0x0000000180122E70
[assembly: UnityEngineModuleAssembly] // 0x0000000180121B80-0x0000000180122E70

// Image 35: UnityEngine.ImageConversionModule.dll - Assembly: UnityEngine.ImageConversionModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4324-4325
[assembly: CompilationRelaxations] // 0x0000000180141C00-0x0000000180142F00
[assembly: Debuggable] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: InternalsVisibleTo] // 0x0000000180141C00-0x0000000180142F00
[assembly: RuntimeCompatibility] // 0x0000000180141C00-0x0000000180142F00
[assembly: UnityEngineModuleAssembly] // 0x0000000180141C00-0x0000000180142F00

// Image 12: UnityEngine.SubsystemsModule.dll - Assembly: UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3210-3221
[assembly: CompilationRelaxations] // 0x0000000180135E00-0x00000001801370F0
[assembly: Debuggable] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: InternalsVisibleTo] // 0x0000000180135E00-0x00000001801370F0
[assembly: RuntimeCompatibility] // 0x0000000180135E00-0x00000001801370F0
[assembly: UnityEngineModuleAssembly] // 0x0000000180135E00-0x00000001801370F0

// Image 38: UnityEngine.TilemapModule.dll - Assembly: UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4355-4364
[assembly: CompilationRelaxations] // 0x0000000180152710-0x0000000180153A00
[assembly: Debuggable] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: InternalsVisibleTo] // 0x0000000180152710-0x0000000180153A00
[assembly: RuntimeCompatibility] // 0x0000000180152710-0x0000000180153A00
[assembly: UnityEngineModuleAssembly] // 0x0000000180152710-0x0000000180153A00

// Image 24: UnityEngine.JSONSerializeModule.dll - Assembly: UnityEngine.JSONSerializeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3382-3383
[assembly: CompilationRelaxations] // 0x0000000180127A00-0x0000000180128CF0
[assembly: Debuggable] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: InternalsVisibleTo] // 0x0000000180127A00-0x0000000180128CF0
[assembly: RuntimeCompatibility] // 0x0000000180127A00-0x0000000180128CF0
[assembly: UnityEngineModuleAssembly] // 0x0000000180127A00-0x0000000180128CF0

// Image 23: UnityEngine.InputModule.dll - Assembly: UnityEngine.InputModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3375-3381
[assembly: CompilationRelaxations] // 0x00000001801241B0-0x00000001801254C0
[assembly: Debuggable] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: InternalsVisibleTo] // 0x00000001801241B0-0x00000001801254C0
[assembly: RuntimeCompatibility] // 0x00000001801241B0-0x00000001801254C0
[assembly: UnityEngineModuleAssembly] // 0x00000001801241B0-0x00000001801254C0

// Image 31: UnityEngine.AIModule.dll - Assembly: UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4301-4303
[assembly: CompilationRelaxations] // 0x00000001801325C0-0x00000001801338B0
[assembly: Debuggable] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: InternalsVisibleTo] // 0x00000001801325C0-0x00000001801338B0
[assembly: RuntimeCompatibility] // 0x00000001801325C0-0x00000001801338B0
[assembly: UnityEngineModuleAssembly] // 0x00000001801325C0-0x00000001801338B0

// Image 36: UnityEngine.ParticleSystemModule.dll - Assembly: UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4326-4338
[assembly: CompilationRelaxations] // 0x0000000180147950-0x0000000180148C50
[assembly: Debuggable] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: InternalsVisibleTo] // 0x0000000180147950-0x0000000180148C50
[assembly: RuntimeCompatibility] // 0x0000000180147950-0x0000000180148C50
[assembly: UnityEngineModuleAssembly] // 0x0000000180147950-0x0000000180148C50

// Image 34: UnityEngine.DirectorModule.dll - Assembly: UnityEngine.DirectorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4322-4323
[assembly: CompilationRelaxations] // 0x000000018013F180-0x0000000180140470
[assembly: Debuggable] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: InternalsVisibleTo] // 0x000000018013F180-0x0000000180140470
[assembly: RuntimeCompatibility] // 0x000000018013F180-0x0000000180140470
[assembly: UnityEngineModuleAssembly] // 0x000000018013F180-0x0000000180140470

// Image 37: UnityEngine.TerrainModule.dll - Assembly: UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-4354
[assembly: CompilationRelaxations] // 0x000000018014CB60-0x000000018014DE60
[assembly: Debuggable] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: InternalsVisibleTo] // 0x000000018014CB60-0x000000018014DE60
[assembly: RuntimeCompatibility] // 0x000000018014CB60-0x000000018014DE60
[assembly: UnityEngineModuleAssembly] // 0x000000018014CB60-0x000000018014DE60

// Image 42: UnityEngine.VFXModule.dll - Assembly: UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4544-4554
[assembly: CompilationRelaxations] // 0x00000001801203F0-0x0000000180121770
[assembly: Debuggable] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: InternalsVisibleTo] // 0x00000001801203F0-0x0000000180121770
[assembly: RuntimeCompatibility] // 0x00000001801203F0-0x0000000180121770
[assembly: UnityEngineModuleAssembly] // 0x00000001801203F0-0x0000000180121770

// Image 43: UnityEngine.VideoModule.dll - Assembly: UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4555-4569
[assembly: CompilationRelaxations] // 0x00000001801256E0-0x0000000180126A50
[assembly: Debuggable] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: InternalsVisibleTo] // 0x00000001801256E0-0x0000000180126A50
[assembly: RuntimeCompatibility] // 0x00000001801256E0-0x0000000180126A50
[assembly: UnityEngineModuleAssembly] // 0x00000001801256E0-0x0000000180126A50

// Image 27: UnityEngine.VRModule.dll - Assembly: UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3595-3598
[assembly: CompilationRelaxations] // 0x0000000180146610-0x0000000180147900
[assembly: Debuggable] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: InternalsVisibleTo] // 0x0000000180146610-0x0000000180147900
[assembly: RuntimeCompatibility] // 0x0000000180146610-0x0000000180147900
[assembly: UnityEngineModuleAssembly] // 0x0000000180146610-0x0000000180147900

namespace TMPro
{
	public enum _HorizontalAlignmentOptions // TypeDefIndex: 4248
	{
		Left = 1,
		Center = 2,
		Right = 4,
		Justified = 8,
		Flush = 16,
		Geometry = 32
	}

	public enum _VerticalAlignmentOptions // TypeDefIndex: 4249
	{
		Top = 256,
		Middle = 512,
		Bottom = 1024,
		Baseline = 2048,
		Geometry = 4096,
		Capline = 8192
	}
}

[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
internal sealed class <>f__AnonymousType0<<message>j__TPar> // TypeDefIndex: 1
{
	// Fields
	[DebuggerBrowsable] // 0x0000000180119650-0x0000000180119670
	private readonly <message>j__TPar <message>i__Field;

	// Constructors
	[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
	public <>f__AnonymousType0(<message>j__TPar message);

	// Methods
	[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
	public override bool Equals(object value);
	[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
	public override int GetHashCode();
	[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
	public override string ToString();
}

[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1551
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=256 0392525BCB01691D1F319D89F2C12BF93A478467; // 0x00
	internal static readonly __StaticArrayInitTypeSize=72 0588059ACBD52F7EA2835882F977A9CF72EB9775; // 0x100
	internal static readonly __StaticArrayInitTypeSize=84 0A1ADB22C1D3E1F4B2448EE3F27DF9DE63329C4C; // 0x148
	internal static readonly __StaticArrayInitTypeSize=240 121EC59E23F7559B28D338D562528F6299C2DE22; // 0x19C
	internal static readonly __StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C; // 0x28C
	internal static readonly __StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D; // 0x28F
	internal static readonly __StaticArrayInitTypeSize=24 1730F09044E91DB8371B849EFF5E6D17BDE4AED0; // 0x292
	internal static readonly __StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD; // 0x2AA
	internal static readonly __StaticArrayInitTypeSize=4096 1AEF3D8DF416A46288C91C724CBF7B154D9E5BF3; // 0x2AD
	internal static readonly __StaticArrayInitTypeSize=2048 1E41C4CD0767AEA21C00DEABA2EA9407F1E6CEA5; // 0x12AD
	internal static readonly __StaticArrayInitTypeSize=16 1FE6CE411858B3D864679DE2139FB081F08BFACD; // 0x1AAD
	internal static readonly __StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC; // 0x1ABD
	internal static readonly __StaticArrayInitTypeSize=40 25420D0055076FA8D3E4DD96BC53AE24DE6E619F; // 0x1AC0
	internal static readonly __StaticArrayInitTypeSize=1208 25CF935D2AE9EDF05DD75BCD47FF84D9255D6F6E; // 0x1AE8
	internal static readonly __StaticArrayInitTypeSize=42 29C1A61550F0E3260E1953D4FAD71C256218EF40; // 0x1FA0
	internal static readonly __StaticArrayInitTypeSize=12 2B33BEC8C30DFDC49DAFE20D3BDE19487850D717; // 0x1FCA
	internal static readonly __StaticArrayInitTypeSize=36 2BA840FF6020B8FF623DBCB7188248CF853FAF4F; // 0x1FD6
	internal static readonly __StaticArrayInitTypeSize=72 2C840AFA48C27B9C05593E468C1232CA1CC74AFD; // 0x1FFA
	internal static readonly __StaticArrayInitTypeSize=16 2D1DA5BB407F0C11C3B5116196C0C6374D932B20; // 0x2042
	internal static readonly __StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130; // 0x2052
	internal static readonly __StaticArrayInitTypeSize=72 2F71D2DA12F3CD0A6A112F5A5A75B4FDC6FE8547; // 0x2060
	internal static readonly __StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359; // 0x20A8
	internal static readonly __StaticArrayInitTypeSize=72 34476C29F6F81C989CFCA42F7C06E84C66236834; // 0x20E8
	internal static readonly __StaticArrayInitTypeSize=2382 35EED060772F2748D13B745DAEC8CD7BD3B87604; // 0x2130
	internal static readonly __StaticArrayInitTypeSize=38 375F9AE9769A3D1DA789E9ACFE81F3A1BB14F0D3; // 0x2A7E
	internal static readonly __StaticArrayInitTypeSize=1450 379C06C9E702D31469C29033F0DD63931EB349F5; // 0x2AA4
	internal static readonly __StaticArrayInitTypeSize=10 399BD13E240F33F808CA7940293D6EC4E6FD5A00; // 0x304E
	internal static readonly __StaticArrayInitTypeSize=72 39C9CE73C7B0619D409EF28344F687C1B5C130FE; // 0x3058
	internal static readonly __StaticArrayInitTypeSize=320 3C53AFB51FEC23491684C7BEDBC6D4E0F409F851; // 0x30A0
	internal static readonly __StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68; // 0x31E0
	internal static readonly __StaticArrayInitTypeSize=64 3E4BBF9D0CDD2E34F78AA7A9A3979DCE1F7B02BD; // 0x31E3
	internal static readonly __StaticArrayInitTypeSize=12 3E823444D2DFECF0F90B436B88F02A533CB376F1; // 0x3223
	internal static readonly __StaticArrayInitTypeSize=72 3FE6C283BCF384FD2C8789880DFF59664E2AB4A1; // 0x322F
	internal static readonly __StaticArrayInitTypeSize=1665 40981BAA39513E58B28DCF0103CC04DE2A0A0444; // 0x3277
	internal static readonly __StaticArrayInitTypeSize=40 40E7C49413D261F3F38AD3A870C0AC69C8BDA048; // 0x38F8
	internal static readonly __StaticArrayInitTypeSize=72 421EC7E82F2967DF6CA8C3605514DC6F29EE5845; // 0x3920
	internal static readonly __StaticArrayInitTypeSize=256 433175D38B13FFE177FDD661A309F1B528B3F6E2; // 0x3968
	internal static readonly __StaticArrayInitTypeSize=120 46232052BC757E030490D851F265FB47FA100902; // 0x3A68
	internal static readonly __StaticArrayInitTypeSize=72 4858DB4AA76D3933F1CA9E6712D4FDB16903F628; // 0x3AE0
	internal static readonly __StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195; // 0x3B28
	internal static readonly __StaticArrayInitTypeSize=40 4F7A8890F332B22B8DE0BD29D36FA7364748D76A; // 0x3B58
	internal static readonly __StaticArrayInitTypeSize=72 536422B321459B242ADED7240B7447E904E083E3; // 0x3B80
	internal static readonly __StaticArrayInitTypeSize=1080 5382CEF491F422BFE0D6FC46EFAFF9EF9D4C89F3; // 0x3BC8
	internal static readonly __StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949; // 0x4000
	internal static readonly __StaticArrayInitTypeSize=3 57218C316B6921E2CD61027A2387EDC31A2D9471; // 0x400A
	internal static readonly __StaticArrayInitTypeSize=40 57F320D62696EC99727E0FE2045A05F1289CC0C6; // 0x400D
	internal static readonly __StaticArrayInitTypeSize=212 594A33A00BC4F785DFD43E3C6C44FBA1242CCAF3; // 0x4035
	internal static readonly __StaticArrayInitTypeSize=36 5BBDF8058D4235C33F2E8DCF76004031B6187A2F; // 0x4109
	internal static readonly __StaticArrayInitTypeSize=288 5BCD21C341BE6DDF8FFFAE1A23ABA24DCBB612BF; // 0x412D
	internal static readonly __StaticArrayInitTypeSize=72 5BFE2819B4778217C56416C7585FF0E56EBACD89; // 0x424D
	internal static readonly __StaticArrayInitTypeSize=128 609C0E8D8DA86A09D6013D301C86BA8782C16B8C; // 0x4295
	internal static readonly __StaticArrayInitTypeSize=48 62BAB0F245E66C3EB982CF5A7015F0A7C3382283; // 0x4315
	internal static readonly __StaticArrayInitTypeSize=2048 646036A65DECCD6835C914A46E6E44B729433B60; // 0x4345
	internal static readonly __StaticArrayInitTypeSize=40 65E32B4E150FD8D24B93B0D42A17F1DAD146162B; // 0x4B45
	internal static readonly __StaticArrayInitTypeSize=52 6770974FEF1E98B9C1864370E2B5B786EB0EA39E; // 0x4B6D
	internal static readonly __StaticArrayInitTypeSize=72 67EEAD805D708D9AA4E14BF747E44CED801744F3; // 0x4BA1
	internal static readonly __StaticArrayInitTypeSize=120 6C71197D228427B2864C69B357FEF73D8C9D59DF; // 0x4BE9
	internal static readonly __StaticArrayInitTypeSize=16 6CEE45445AFD150B047A5866FFA76AA651CDB7B7; // 0x4C61
	internal static readonly __StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D; // 0x4C71
	internal static readonly __StaticArrayInitTypeSize=2048 6D797C11E1D4FB68B6570CF2A92B792433527065; // 0x4C7A
	internal static readonly __StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9; // 0x547A
	internal static readonly __StaticArrayInitTypeSize=76 6FC754859E4EC74E447048364B216D825C6F8FE7; // 0x60B6
	internal static readonly __StaticArrayInitTypeSize=40 704939CD172085D1295FCE3F1D92431D685D7AA2; // 0x6102
	internal static readonly __StaticArrayInitTypeSize=24 7088AAE49F0627B72729078DE6E3182DDCF8ED99; // 0x612A
	internal static readonly __StaticArrayInitTypeSize=72 7341C933A70EAE383CC50C4B945ADB8E08F06737; // 0x6142
	internal static readonly __StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57; // 0x618A
	internal static readonly __StaticArrayInitTypeSize=4096 7F42F2EDC974BE29B2746957416ED1AEFA605F47; // 0x618D
	internal static readonly __StaticArrayInitTypeSize=40 7FE820C9CF0F0B90445A71F1D262D22E4F0C4C68; // 0x718D
	internal static readonly __StaticArrayInitTypeSize=21252 811A927B7DADD378BE60BBDE794B9277AA9B50EC; // 0x71B5
	internal static readonly __StaticArrayInitTypeSize=36 81917F1E21F3C22B9F916994547A614FB03E968E; // 0xC4B9
	internal static readonly __StaticArrayInitTypeSize=40 823566DA642D6EA356E15585921F2A4CA23D6760; // 0xC4DD
	internal static readonly __StaticArrayInitTypeSize=12 82C2A59850B2E85BCE1A45A479537A384DF6098D; // 0xC505
	internal static readonly __StaticArrayInitTypeSize=44 82C383F8E6E4D3D87AEBB986A5D0077E8AD157C4; // 0xC511
	internal static readonly __StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A; // 0xC53D
	internal static readonly __StaticArrayInitTypeSize=40 871B9CF85DB352BAADF12BAE8F19857683E385AC; // 0xC540
	internal static readonly __StaticArrayInitTypeSize=16 89A040451C8CC5C8FB268BE44BDD74964C104155; // 0xC568
	internal static readonly __StaticArrayInitTypeSize=40 8CAA092E783257106251246FF5C97F88D28517A6; // 0xC578
	internal static readonly __StaticArrayInitTypeSize=2100 8D231DD55FE1AD7631BBD0905A17D5EB616C2154; // 0xC5A0
	internal static readonly __StaticArrayInitTypeSize=40 8E10AC2F34545DFBBF3FCBC06055D797A8C99991; // 0xCDD4
	internal static readonly __StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3; // 0xCDFC
	internal static readonly __StaticArrayInitTypeSize=640 90A0542282A011472F94E97CEAE59F8B3B1A3291; // 0xCEFC
	internal static readonly __StaticArrayInitTypeSize=12 93A63E90605400F34B49F0EB3361D23C89164BDA; // 0xD17C
	internal static readonly __StaticArrayInitTypeSize=72 94841DD2F330CCB1089BF413E4FA9B04505152E2; // 0xD188
	internal static readonly __StaticArrayInitTypeSize=12 95264589E48F94B7857CFF398FB72A537E13EEE2; // 0xD1D0
	internal static readonly __StaticArrayInitTypeSize=72 95C48758CAE1715783472FB073AB158AB8A0AB2A; // 0xD1DC
	internal static readonly __StaticArrayInitTypeSize=72 973417296623D8DC6961B09664E54039E44CA5D8; // 0xD224
	internal static readonly __StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003; // 0xD26C
	internal static readonly __StaticArrayInitTypeSize=4096 99E2E88877D14C7DDC4E957A0ED7079CA0E9EB24; // 0xD26F
	internal static readonly __StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5; // 0xE26F
	internal static readonly __StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88; // 0xE2AF
	internal static readonly __StaticArrayInitTypeSize=40 A0074C15377C0C870B055927403EA9FA7A349D12; // 0xE2B2
	internal static readonly __StaticArrayInitTypeSize=130 A1319B706116AB2C6D44483F60A7D0ACEA543396; // 0xE2DA
	internal static readonly long A13AA52274D951A18029131A8DDECF76B569A15D; // 0xE360
	internal static readonly __StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B; // 0xE368
	internal static readonly __StaticArrayInitTypeSize=212 A5444763673307F6828C748D4B9708CFC02B0959; // 0xE36B
	internal static readonly __StaticArrayInitTypeSize=72 A6732F8E7FC23766AB329B492D6BF82E3B33233F; // 0xE43F
	internal static readonly __StaticArrayInitTypeSize=174 A705A106D95282BD15E13EEA6B0AF583FF786D83; // 0xE487
	internal static readonly __StaticArrayInitTypeSize=1018 A8A491E4CED49AE0027560476C10D933CE70C8DF; // 0xE535
	internal static readonly __StaticArrayInitTypeSize=72 AC791C4F39504D1184B73478943D0636258DA7B1; // 0xE92F
	internal static readonly __StaticArrayInitTypeSize=52 AFCD4E1211233E99373A3367B23105A3D624B1F2; // 0xE977
	internal static readonly __StaticArrayInitTypeSize=40 B472ED77CB3B2A66D49D179F1EE2081B70A6AB61; // 0xE9AB
	internal static readonly __StaticArrayInitTypeSize=16 B4FBD02AAB5B16E0F4BD858DA5D9E348F3CE501D; // 0xE9D3
	internal static readonly __StaticArrayInitTypeSize=256 B53A2C6DF21FC88B17AEFC40EB895B8D63210CDF; // 0xE9E3
	internal static readonly __StaticArrayInitTypeSize=4096 B6002BBF29B2704922EC3BBF0F9EE40ABF185D6B; // 0xEAE3
	internal static readonly __StaticArrayInitTypeSize=998 B881DA88BE0B68D8A6B6B6893822586B8B2CFC45; // 0xFAE3
	internal static readonly __StaticArrayInitTypeSize=162 B8864ACB9DD69E3D42151513C840AAE270BF21C8; // 0xFEC9
	internal static readonly __StaticArrayInitTypeSize=360 B8F87834C3597B2EEF22BA6D3A392CC925636401; // 0xFF6B
	internal static readonly __StaticArrayInitTypeSize=72 B9B670F134A59FB1107AF01A9FE8F8E3980B3093; // 0x100D3
	internal static readonly __StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8; // 0x1011B
	internal static readonly __StaticArrayInitTypeSize=72 BEBC9ECC660A13EFC359BA3383411F698CFF25DB; // 0x1012F
	internal static readonly __StaticArrayInitTypeSize=40 BEE1CFE5DFAA408E14CE4AF4DCD824FA2E42DCB7; // 0x10177
	internal static readonly __StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A; // 0x1019F
	internal static readonly __StaticArrayInitTypeSize=6 BF5EB60806ECB74EE484105DD9D6F463BF994867; // 0x101A2
	internal static readonly long C1A1100642BA9685B30A84D97348484E14AA1865; // 0x101A8
	internal static readonly __StaticArrayInitTypeSize=16 C6F364A0AD934EFED8909446C215752E565D77C1; // 0x101B0
	internal static readonly __StaticArrayInitTypeSize=174 CE5835130F5277F63D716FC9115526B0AC68FFAD; // 0x101C0
	internal static readonly __StaticArrayInitTypeSize=6 CE93C35B755802BC4B3D180716B048FC61701EF7; // 0x1026E
	internal static readonly __StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814; // 0x10274
	internal static readonly __StaticArrayInitTypeSize=256 D002CBBE1FF33721AF7C4D1D3ECAD1B7DB5258B7; // 0x102B4
	internal static readonly __StaticArrayInitTypeSize=32 D117188BE8D4609C0D531C51B0BB911A4219DEBE; // 0x103B4
	internal static readonly __StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE; // 0x103D4
	internal static readonly __StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F; // 0x103F4
	internal static readonly __StaticArrayInitTypeSize=44 D78D08081C7A5AD6FBA7A8DC86BCD6D7A577C636; // 0x104F4
	internal static readonly __StaticArrayInitTypeSize=76 DA19DB47B583EFCF7825D2E39D661D2354F28219; // 0x10520
	internal static readonly __StaticArrayInitTypeSize=56 DC2B830D8CD59AD6A4E4332D21CA0DCA2821AD82; // 0x1056C
	internal static readonly __StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0; // 0x105A4
	internal static readonly __StaticArrayInitTypeSize=36 E1827270A5FE1C85F5352A66FD87BA747213D006; // 0x105D8
	internal static readonly __StaticArrayInitTypeSize=40 E45BAB43F7D5D038672B3E3431F92E34A7AF2571; // 0x105FC
	internal static readonly __StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17; // 0x10624
	internal static readonly __StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A; // 0x10664
	internal static readonly __StaticArrayInitTypeSize=12 EA9506959484C55CFE0C139C624DF6060E285866; // 0x10698
	internal static readonly __StaticArrayInitTypeSize=262 EB5E9A80A40096AB74D2E226650C7258D7BC5E9D; // 0x106A4
	internal static readonly __StaticArrayInitTypeSize=64 EBF68F411848D603D059DFDEA2321C5A5EA78044; // 0x107AA
	internal static readonly __StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11; // 0x107EA
	internal static readonly __StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3; // 0x107F4
	internal static readonly __StaticArrayInitTypeSize=72 EC89C317EA2BF49A70EFF5E89C691E34733D7C37; // 0x107F7
	internal static readonly __StaticArrayInitTypeSize=40 F06E829E62F3AFBC045D064E10A4F5DF7C969612; // 0x1083F
	internal static readonly __StaticArrayInitTypeSize=11614 F073AA332018FDA0D572E99448FFF1D6422BD520; // 0x10867
	internal static readonly __StaticArrayInitTypeSize=120 F34B0E10653402E8F788F8BC3F7CD7090928A429; // 0x135C5
	internal static readonly __StaticArrayInitTypeSize=72 F37E34BEADB04F34FCC31078A59F49856CA83D5B; // 0x1363D
	internal static readonly __StaticArrayInitTypeSize=94 F512A9ABF88066AAEB92684F95CC05D8101B462B; // 0x13685
	internal static readonly __StaticArrayInitTypeSize=12 F8FAABB821300AA500C2CEC6091B3782A7FB44A4; // 0x136E3
	internal static readonly __StaticArrayInitTypeSize=2350 FCBD2781A933F0828ED4AAF88FD8B08D76DDD49B; // 0x136EF

	// Nested types
	private struct __StaticArrayInitTypeSize=3 // TypeDefIndex: 1552
	{
	}

	private struct __StaticArrayInitTypeSize=6 // TypeDefIndex: 1553
	{
	}

	private struct __StaticArrayInitTypeSize=9 // TypeDefIndex: 1554
	{
	}

	private struct __StaticArrayInitTypeSize=10 // TypeDefIndex: 1555
	{
	}

	private struct __StaticArrayInitTypeSize=12 // TypeDefIndex: 1556
	{
	}

	private struct __StaticArrayInitTypeSize=14 // TypeDefIndex: 1557
	{
	}

	private struct __StaticArrayInitTypeSize=16 // TypeDefIndex: 1558
	{
	}

	private struct __StaticArrayInitTypeSize=20 // TypeDefIndex: 1559
	{
	}

	private struct __StaticArrayInitTypeSize=24 // TypeDefIndex: 1560
	{
	}

	private struct __StaticArrayInitTypeSize=32 // TypeDefIndex: 1561
	{
	}

	private struct __StaticArrayInitTypeSize=36 // TypeDefIndex: 1562
	{
	}

	private struct __StaticArrayInitTypeSize=38 // TypeDefIndex: 1563
	{
	}

	private struct __StaticArrayInitTypeSize=40 // TypeDefIndex: 1564
	{
	}

	private struct __StaticArrayInitTypeSize=42 // TypeDefIndex: 1565
	{
	}

	private struct __StaticArrayInitTypeSize=44 // TypeDefIndex: 1566
	{
	}

	private struct __StaticArrayInitTypeSize=48 // TypeDefIndex: 1567
	{
	}

	private struct __StaticArrayInitTypeSize=52 // TypeDefIndex: 1568
	{
	}

	private struct __StaticArrayInitTypeSize=56 // TypeDefIndex: 1569
	{
	}

	private struct __StaticArrayInitTypeSize=64 // TypeDefIndex: 1570
	{
	}

	private struct __StaticArrayInitTypeSize=72 // TypeDefIndex: 1571
	{
	}

	private struct __StaticArrayInitTypeSize=76 // TypeDefIndex: 1572
	{
	}

	private struct __StaticArrayInitTypeSize=84 // TypeDefIndex: 1573
	{
	}

	private struct __StaticArrayInitTypeSize=94 // TypeDefIndex: 1574
	{
	}

	private struct __StaticArrayInitTypeSize=120 // TypeDefIndex: 1575
	{
	}

	private struct __StaticArrayInitTypeSize=128 // TypeDefIndex: 1576
	{
	}

	private struct __StaticArrayInitTypeSize=130 // TypeDefIndex: 1577
	{
	}

	private struct __StaticArrayInitTypeSize=162 // TypeDefIndex: 1578
	{
	}

	private struct __StaticArrayInitTypeSize=174 // TypeDefIndex: 1579
	{
	}

	private struct __StaticArrayInitTypeSize=212 // TypeDefIndex: 1580
	{
	}

	private struct __StaticArrayInitTypeSize=240 // TypeDefIndex: 1581
	{
	}

	private struct __StaticArrayInitTypeSize=256 // TypeDefIndex: 1582
	{
	}

	private struct __StaticArrayInitTypeSize=262 // TypeDefIndex: 1583
	{
	}

	private struct __StaticArrayInitTypeSize=288 // TypeDefIndex: 1584
	{
	}

	private struct __StaticArrayInitTypeSize=320 // TypeDefIndex: 1585
	{
	}

	private struct __StaticArrayInitTypeSize=360 // TypeDefIndex: 1586
	{
	}

	private struct __StaticArrayInitTypeSize=640 // TypeDefIndex: 1587
	{
	}

	private struct __StaticArrayInitTypeSize=998 // TypeDefIndex: 1588
	{
	}

	private struct __StaticArrayInitTypeSize=1018 // TypeDefIndex: 1589
	{
	}

	private struct __StaticArrayInitTypeSize=1080 // TypeDefIndex: 1590
	{
	}

	private struct __StaticArrayInitTypeSize=1208 // TypeDefIndex: 1591
	{
	}

	private struct __StaticArrayInitTypeSize=1450 // TypeDefIndex: 1592
	{
	}

	private struct __StaticArrayInitTypeSize=1665 // TypeDefIndex: 1593
	{
	}

	private struct __StaticArrayInitTypeSize=2048 // TypeDefIndex: 1594
	{
	}

	private struct __StaticArrayInitTypeSize=2100 // TypeDefIndex: 1595
	{
	}

	private struct __StaticArrayInitTypeSize=2350 // TypeDefIndex: 1596
	{
	}

	private struct __StaticArrayInitTypeSize=2382 // TypeDefIndex: 1597
	{
	}

	private struct __StaticArrayInitTypeSize=3132 // TypeDefIndex: 1598
	{
	}

	private struct __StaticArrayInitTypeSize=4096 // TypeDefIndex: 1599
	{
	}

	private struct __StaticArrayInitTypeSize=11614 // TypeDefIndex: 1600
	{
	}

	private struct __StaticArrayInitTypeSize=21252 // TypeDefIndex: 1601
	{
	}

	// Methods
	internal static uint ComputeStringHash(string s); // 0x000000018051BD70-0x000000018051D2E0
}

[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1680
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=3 12D04472A8285260EA12FD3813CDFA9F2D2B548C; // 0x00
	internal static readonly __StaticArrayInitTypeSize=3 13A35EF1A549297C70E2AD46045BBD2ECA17852D; // 0x03
	internal static readonly long 16968835DEF6DD3BB86EABA9DEC53BF41851CD6D; // 0x08
	internal static readonly __StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD; // 0x10
	internal static readonly __StaticArrayInitTypeSize=3 235D99572263B22ADFEE10FDA0C25E12F4D94FFC; // 0x13
	internal static readonly __StaticArrayInitTypeSize=14 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130; // 0x16
	internal static readonly __StaticArrayInitTypeSize=64 320B018758ECE3752FFEDBAEB1A6DB67C80B9359; // 0x24
	internal static readonly __StaticArrayInitTypeSize=3 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68; // 0x64
	internal static readonly __StaticArrayInitTypeSize=48 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195; // 0x67
	internal static readonly __StaticArrayInitTypeSize=10 56DFA5053B3131883637F53219E7D88CCEF35949; // 0x97
	internal static readonly __StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D; // 0xA1
	internal static readonly __StaticArrayInitTypeSize=3132 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9; // 0xAA
	internal static readonly long 6FA00AC9FFFD87F82A38A7F9ECC8134F4A7052AF; // 0xCE8
	internal static readonly __StaticArrayInitTypeSize=3 736D39815215889F11249D9958F6ED12D37B9F57; // 0xCF0
	internal static readonly __StaticArrayInitTypeSize=3 86F4F563FA2C61798AE6238D789139739428463A; // 0xCF3
	internal static readonly __StaticArrayInitTypeSize=3 97FB30C84FF4A41CD4625B44B2940BFC8DB43003; // 0xCF6
	internal static readonly __StaticArrayInitTypeSize=64 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5; // 0xCF9
	internal static readonly __StaticArrayInitTypeSize=3 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88; // 0xD39
	internal static readonly __StaticArrayInitTypeSize=3 A323DB0813C4D072957BA6FDA79D9776674CD06B; // 0xD3C
	internal static readonly long AEA5F1CC5CFE1660539EDD691FE017F775F63A0D; // 0xD40
	internal static readonly __StaticArrayInitTypeSize=20 BE1BDEC0AA74B4DCB079943E70528096CCA985F8; // 0xD48
	internal static readonly __StaticArrayInitTypeSize=3 BF477463CE2F5EF38FC4C644BBBF4DF109E7670A; // 0xD5C
	internal static readonly __StaticArrayInitTypeSize=64 CF0B42666EF5E37EDEA0AB8E173E42C196D03814; // 0xD5F
	internal static readonly __StaticArrayInitTypeSize=32 D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE; // 0xD9F
	internal static readonly __StaticArrayInitTypeSize=256 D2C5BAE967587C6F3D9F2C4551911E0575A1101F; // 0xDBF
	internal static readonly __StaticArrayInitTypeSize=64 E75835D001C843F156FBA01B001DFE1B8029AC17; // 0xEBF
	internal static readonly __StaticArrayInitTypeSize=10 EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11; // 0xEFF
	internal static readonly __StaticArrayInitTypeSize=3 EC83FB16C20052BEE2B4025159BC2ED45C9C70C3; // 0xF09

	// Nested types
	private struct __StaticArrayInitTypeSize=3 // TypeDefIndex: 1681
	{
	}

	private struct __StaticArrayInitTypeSize=9 // TypeDefIndex: 1682
	{
	}

	private struct __StaticArrayInitTypeSize=10 // TypeDefIndex: 1683
	{
	}

	private struct __StaticArrayInitTypeSize=14 // TypeDefIndex: 1684
	{
	}

	private struct __StaticArrayInitTypeSize=20 // TypeDefIndex: 1685
	{
	}

	private struct __StaticArrayInitTypeSize=32 // TypeDefIndex: 1686
	{
	}

	private struct __StaticArrayInitTypeSize=48 // TypeDefIndex: 1687
	{
	}

	private struct __StaticArrayInitTypeSize=64 // TypeDefIndex: 1688
	{
	}

	private struct __StaticArrayInitTypeSize=256 // TypeDefIndex: 1689
	{
	}

	private struct __StaticArrayInitTypeSize=3132 // TypeDefIndex: 1690
	{
	}

	// Methods
	internal static uint ComputeStringHash(string s); // 0x000000018051BD70-0x000000018051D2E0
}

[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 2113
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=6 5D100A87B697F3AE2015A5D3B2A7B5419E1BCA98; // 0x00
	internal static readonly __StaticArrayInitTypeSize=416 6A0D50D692745A6663128CD315B71079584F3E59; // 0x06
	internal static readonly __StaticArrayInitTypeSize=32 7A32E1A19C182315E4263A65A72066492550D8CD; // 0x1A6
	internal static readonly __StaticArrayInitTypeSize=28 9E31F24F64765FCAA589F589324D17C9FCF6A06D; // 0x1C6
	internal static readonly __StaticArrayInitTypeSize=416 B368804F0C6DAB083B253A6B106D0783D5C32E90; // 0x1E2
	internal static readonly __StaticArrayInitTypeSize=40 B9F0004E3873FDDCABFDA6174EA18F0859B637B4; // 0x382
	internal static readonly __StaticArrayInitTypeSize=20 BAD037B714E1CD1052149B51238A3D4351DD10B5; // 0x3AA
	internal static readonly long EBC658B067B5C785A3F0BB67D73755F6FEE7F70C; // 0x3C0
	internal static readonly __StaticArrayInitTypeSize=64 EE3413A2C088FF9432054D6E60A7CB6A498D25F0; // 0x3C8

	// Nested types
	private struct __StaticArrayInitTypeSize=6 // TypeDefIndex: 2114
	{
	}

	private struct __StaticArrayInitTypeSize=20 // TypeDefIndex: 2115
	{
	}

	private struct __StaticArrayInitTypeSize=28 // TypeDefIndex: 2116
	{
	}

	private struct __StaticArrayInitTypeSize=32 // TypeDefIndex: 2117
	{
	}

	private struct __StaticArrayInitTypeSize=40 // TypeDefIndex: 2118
	{
	}

	private struct __StaticArrayInitTypeSize=64 // TypeDefIndex: 2119
	{
	}

	private struct __StaticArrayInitTypeSize=416 // TypeDefIndex: 2120
	{
	}

	// Methods
	internal static uint ComputeStringHash(string s); // 0x000000018051BD70-0x000000018051D2E0
}

[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 2574
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=14 0283A6AF88802AB45989B29549915BEA0F6CD515; // 0x00
	internal static readonly long 03F4297FCC30D0FD5E420E5D26E7FA711167C7EF; // 0x10
	internal static readonly __StaticArrayInitTypeSize=9 1A39764B112685485A5BA7B2880D878B858C1A7A; // 0x18
	internal static readonly __StaticArrayInitTypeSize=3 1A84029C80CB5518379F199F53FF08A7B764F8FD; // 0x21
	internal static readonly __StaticArrayInitTypeSize=12 3BE77BF818331C2D8400FFFFF9FADD3F16AD89AC; // 0x24
	internal static readonly __StaticArrayInitTypeSize=32 59F5BD34B6C013DEACC784F69C67E95150033A84; // 0x30
	internal static readonly __StaticArrayInitTypeSize=6 5BC3486B05BA8CF4689C7BDB198B3F477BB4E20C; // 0x50
	internal static readonly __StaticArrayInitTypeSize=9 6D49C9D487D7AD3491ECE08732D68A593CC2038D; // 0x56
	internal static readonly __StaticArrayInitTypeSize=128 6F3AD3DC3AF8047587C4C9D696EB68A01FEF796E; // 0x5F
	internal static readonly __StaticArrayInitTypeSize=44 8E0EF3D67A3EB1863224EE3CACB424BC2F8CFBA3; // 0xDF
	internal static readonly long 98A44A6F8606AE6F23FE230286C1D6FBCC407226; // 0x110
	internal static readonly __StaticArrayInitTypeSize=32 C02C28AFEBE998F767E4AF43E3BE8F5E9FA11536; // 0x118
	internal static readonly __StaticArrayInitTypeSize=128 CCEEADA43268372341F81AE0C9208C6856441C04; // 0x138
	internal static readonly long E5BC1BAFADE1862DD6E0B9FB632BFAA6C3873A78; // 0x1B8
	internal static readonly __StaticArrayInitTypeSize=32 EC5842B3154E1AF94500B57220EB9F684BCCC42A; // 0x1C0
	internal static readonly __StaticArrayInitTypeSize=256 EEAFE8C6E1AB017237567305EE925C976CDB6458; // 0x1E0

	// Nested types
	private struct __StaticArrayInitTypeSize=3 // TypeDefIndex: 2575
	{
	}

	private struct __StaticArrayInitTypeSize=6 // TypeDefIndex: 2576
	{
	}

	private struct __StaticArrayInitTypeSize=9 // TypeDefIndex: 2577
	{
	}

	private struct __StaticArrayInitTypeSize=12 // TypeDefIndex: 2578
	{
	}

	private struct __StaticArrayInitTypeSize=14 // TypeDefIndex: 2579
	{
	}

	private struct __StaticArrayInitTypeSize=32 // TypeDefIndex: 2580
	{
	}

	private struct __StaticArrayInitTypeSize=44 // TypeDefIndex: 2581
	{
	}

	private struct __StaticArrayInitTypeSize=128 // TypeDefIndex: 2582
	{
	}

	private struct __StaticArrayInitTypeSize=256 // TypeDefIndex: 2583
	{
	}

	// Methods
	internal static uint ComputeStringHash(string s); // 0x000000018051BD70-0x000000018051D2E0
}

[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 2645
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=120 0AA802CD6847EB893FE786B5EA5168B2FDCD7B93; // 0x00
	internal static readonly __StaticArrayInitTypeSize=256 0C4110BC17D746F018F47B49E0EB0D6590F69939; // 0x78
	internal static readonly __StaticArrayInitTypeSize=1024 20733E1283D873EBE47133A95C233E11B76F5F11; // 0x178
	internal static readonly __StaticArrayInitTypeSize=1024 21F4CBF8283FF1CAEB4A39316A97FC1D6DF1D35E; // 0x578
	internal static readonly __StaticArrayInitTypeSize=1024 23DFDCA6F045D4257BF5AC8CB1CF2EFADAFE9B94; // 0x978
	internal static readonly __StaticArrayInitTypeSize=1024 30A0358B25B1372DD598BB4B1AC56AD6B8F08A47; // 0xD78
	internal static readonly __StaticArrayInitTypeSize=1024 5B5DF5A459E902D96F7DB0FB235A25346CA85C5D; // 0x1178
	internal static readonly __StaticArrayInitTypeSize=1024 5BE411F1438EAEF33726D855E99011D5FECDDD4E; // 0x1578
	internal static readonly __StaticArrayInitTypeSize=256 8F22C9ECE1331718CBD268A9BBFD2F5E451441E3; // 0x1978
	internal static readonly __StaticArrayInitTypeSize=1024 A02DD1D8604EA8EC2D2BDA717A93A4EE85F13E53; // 0x1A78
	internal static readonly __StaticArrayInitTypeSize=1024 AE2F76ECEF8B08F0BC7EA95DCFE945E1727927C9; // 0x1E78

	// Nested types
	private struct __StaticArrayInitTypeSize=120 // TypeDefIndex: 2646
	{
	}

	private struct __StaticArrayInitTypeSize=256 // TypeDefIndex: 2647
	{
	}

	private struct __StaticArrayInitTypeSize=1024 // TypeDefIndex: 2648
	{
	}
}

[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3593
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46; // 0x00

	// Nested types
	private struct __StaticArrayInitTypeSize=12 // TypeDefIndex: 3594
	{
	}
}

[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4298
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=12 7BBE37982E6C057ED87163CAFC7FD6E5E42EEA46; // 0x00
	internal static readonly __StaticArrayInitTypeSize=40 9E6378168821DBABB7EE3D0154346480FAC8AEF1; // 0x0C

	// Nested types
	private struct __StaticArrayInitTypeSize=12 // TypeDefIndex: 4299
	{
	}

	private struct __StaticArrayInitTypeSize=40 // TypeDefIndex: 4300
	{
	}
}

[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4941
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=24 444C0B6D3BA44B0AEC9133CAA7B1EADF170635FD; // 0x00

	// Nested types
	private struct __StaticArrayInitTypeSize=24 // TypeDefIndex: 4942
	{
	}
}

namespace Placemaker.Graphs
{
	[Serializable]
	public struct Action // TypeDefIndex: 4783
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int2 hexPos; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public byte height; // 0x08
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public VoxelType inType; // 0x09
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public VoxelType outType; // 0x0A
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int actionId; // 0x0C
	
		// Constructors
		public Action(int2 hexPos, byte height, VoxelType inType, VoxelType outType, int actionId); // 0x000000018019B2C0-0x000000018019B2E0
	
		// Methods
		public Action GetReverse(); // 0x000000018019B290-0x000000018019B2B0
		public override string ToString(); // 0x000000018019B2B0-0x000000018019B2C0
	}
}

namespace Placemaker
{
	public class AoBaker : MonoBehaviour // TypeDefIndex: 4585
	{
		// Fields
		public const int shadowMeshMaxVertCount = 65532; // Metadata: 0x0021FE23
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public MeshFilter shadowMeshFilter; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public List<ShadowMesh> shadowMeshes; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Shader shader; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Shader spreaderShader; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Shader marchingSquaresShader; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material material; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material spreaderMaterial; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material marchingSquaresMaterial; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public RenderTexture renderTexture0; // 0x60
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public RenderTexture renderTexture1; // 0x68
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public RenderTexture coloredMarchingSquaresTex; // 0x70
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Texture2D marchingSquaresTex; // 0x78
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public float2 size; // 0x80
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Vector4 texParams; // 0x88
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int countX; // 0x98
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int countY; // 0x9C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int totalCount; // 0xA0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Camera cam; // 0xA8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Shader shadowMeshShader; // 0xB0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material shadowMeshMaterial; // 0xB8
		public static readonly Color uncoveredCol; // 0x00
		public static readonly Color32 uncoveredCol32; // 0x10
		public const int texSize = 2048; // Metadata: 0x0021FE27
		public const float texelSize = 0.00048828125f; // Metadata: 0x0021FE2B
		public int4 powers; // 0xC0
		private int tex3dUvSizeId; // 0xD0
		private int tex3dWorldBoundsId; // 0xD4
	
		// Constructors
		public AoBaker(); // 0x0000000180B60C50-0x0000000180B60CB0
		static AoBaker(); // 0x0000000180B60BB0-0x0000000180B60C50
	
		// Methods
		private void OnEnable(); // 0x0000000180B60280-0x0000000180B60390
		public void OnStart(); // 0x0000000180B60480-0x0000000180B60B20
		public ValueTuple<ShadowMesh, int> GetShadowMesh(int shadowIndex); // 0x0000000180B60060-0x0000000180B60280
		private void Restore(); // 0x0000000180B60B20-0x0000000180B60BB0
		[ContextMenu] // 0x000000018012B530-0x000000018012B560
		public void ApplyMaterialColors(); // 0x0000000180B5FA70-0x0000000180B5FAF0
		public void BakeAo(); // 0x0000000180B5FAF0-0x0000000180B60060
		private void OnPostRender(); // 0x0000000180B60390-0x0000000180B60480
	}
}

namespace I2.Loc
{
	internal class ArabicMapping // TypeDefIndex: 4887
	{
		// Fields
		public int from; // 0x10
		public int to; // 0x14
	
		// Constructors
		public ArabicMapping(int from, int to); // 0x00000001805C4640-0x00000001805C4680
	}

	internal class ArabicTable // TypeDefIndex: 4888
	{
		// Fields
		private static List<ArabicMapping> mapList; // 0x00
		private static ArabicTable arabicMapper; // 0x08
	
		// Properties
		internal static ArabicTable ArabicMapper { get; } // 0x00000001805C55B0-0x00000001805C5630 
	
		// Constructors
		private ArabicTable(); // 0x00000001805C47F0-0x00000001805C55B0
	
		// Methods
		internal int Convert(int toBeConverted); // 0x00000001805C4680-0x00000001805C47F0
	}
}

namespace TMPro
{
	public enum AtlasPopulationMode // TypeDefIndex: 4171
	{
		Static = 0,
		Dynamic = 1
	}
}

namespace Placemaker
{
	public class AudioSourcePool : MonoBehaviour // TypeDefIndex: 4586
	{
		// Fields
		private int index; // 0x18
	
		// Constructors
		public AudioSourcePool(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void Start(); // 0x0000000180B60D40-0x0000000180B60E00
		public AudioSource GetAudioSource(); // 0x0000000180B60CB0-0x0000000180B60D40
	}
}

namespace I2.Loc
{
	public class AutoChangeCultureInfo : MonoBehaviour // TypeDefIndex: 4873
	{
		// Constructors
		public AutoChangeCultureInfo(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public void Start(); // 0x00000001805C5630-0x00000001805C5680
	}
}

namespace Placemaker.Ui
{
	public class BaseButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler // TypeDefIndex: 4659
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UnityEvent onClick; // 0x18
		public bool pointerInside; // 0x20
		public bool buttonDown; // 0x21
		public float holdTime; // 0x24
		public PointerEventData eventData; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool _disabled; // 0x30
		public Action<State> onStateChange; // 0x38
		public System.Action onClickAction; // 0x40
		public State state; // 0x48
	
		// Properties
		public float timeHeld { get; } // 0x0000000180B2BF90-0x0000000180B2BFB0 
		public bool disabled { get; set; } // 0x0000000180407B80-0x0000000180407B90 0x0000000180B2BFB0-0x0000000180B2C010
	
		// Nested types
		public enum State : byte // TypeDefIndex: 4660
		{
			None = 0,
			Hover = 1,
			Pressed = 2,
			Disabled = 3
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4661
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action<State> <>9__24_0; // 0x08
			public static System.Action <>9__24_1; // 0x10
	
			// Constructors
			static <>c(); // 0x0000000180B456C0-0x0000000180B45F10
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <.ctor>b__24_0(State <p0>); // 0x00000001801D8E80-0x00000001801D8E90
			internal void <.ctor>b__24_1(); // 0x00000001801D8E80-0x00000001801D8E90
		}
	
		// Constructors
		public BaseButton(); // 0x0000000180B2BE00-0x0000000180B2BF90
	
		// Methods
		private void SetState(State state); // 0x0000000180B2BA90-0x0000000180B2BAF0
		public void Subscribe(Action<State> onStateChangeFunc); // 0x0000000180B2BAF0-0x0000000180B2BB90
		public void PushState(); // 0x0000000180B2BA40-0x0000000180B2BA90
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x0000000180B2BC10-0x0000000180B2BCA0
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x0000000180B2BD80-0x0000000180B2BE00
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData); // 0x0000000180B2BB90-0x0000000180B2BC10
		public void Click(); // 0x0000000180B2B9E0-0x0000000180B2BA40
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x0000000180B2BCA0-0x0000000180B2BD20
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x0000000180B2BD20-0x0000000180B2BD80
	}
}

namespace Placemaker
{
	[Serializable]
	public class BaseModule // TypeDefIndex: 4612
	{
		// Fields
		public short cost; // 0x10
		public List<ushort> profileIndexes; // 0x18
		public List<OrientedModule> orientedModuleMeshes; // 0x20
		public List<PropPlacement> propPlacements; // 0x28
	
		// Constructors
		public BaseModule(); // 0x0000000180B60E00-0x0000000180B60F20
	}
}

namespace I2.Loc
{
	public class BaseSpecializationManager // TypeDefIndex: 4801
	{
		// Fields
		public string[] mSpecializations; // 0x10
		public Dictionary<string, string> mSpecializationsFallbacks; // 0x18
	
		// Constructors
		public BaseSpecializationManager(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public virtual void InitializeSpecializations(); // 0x00000001805C5760-0x00000001805C5CE0
		public virtual string GetCurrentSpecialization(); // 0x00000001805C5680-0x00000001805C56D0
		public virtual string GetFallbackSpecialization(string specialization); // 0x00000001805C56D0-0x00000001805C5760
	}
}

public class Beatbox : MonoBehaviour // TypeDefIndex: 4574
{
	// Fields
	private const float bpm = 100f; // Metadata: 0x0021FE0B
	private const float beatLength = 0.6f; // Metadata: 0x0021FE0F
	private const float beatScale = 1.6666666f; // Metadata: 0x0021FE13

	// Constructors
	public Beatbox(); // 0x00000001801D0210-0x00000001801D0220

	// Methods
	public static bool IsBeat(float divisor = 1f /* Metadata: 0x0021FE03 */, float offset = 0f /* Metadata: 0x0021FE07 */); // 0x00000001805C5D70-0x00000001805C5E40
	public static int GetBeat(float time, float divisor, float offset); // 0x00000001805C5CE0-0x00000001805C5D70
}

namespace Placemaker.Life
{
	public class Bird : MonoBehaviour, IComparable<Bird>, IComparable<Vector3> // TypeDefIndex: 4769
	{
		// Fields
		public Transform body; // 0x18
		public Transform shade; // 0x20
		public MeshFilter mf0; // 0x28
		public MeshFilter mf1; // 0x30
		[Space] // 0x0000000180131590-0x00000001801315A0
		public BirdFlock flock; // 0x38
		public Quaternion rotation0; // 0x40
		public Quaternion rotation1; // 0x50
		public Vector3 posMid; // 0x60
		public Vector3 velocityPrev; // 0x6C
		public Vector3 velocityNext; // 0x78
		public Vector3 pos; // 0x84
		public float time; // 0x90
		public byte preferredNeighbourCount; // 0x94
		public BirdFlock.State statePrev; // 0x95
		public BirdFlock.State stateNext; // 0x96
		public float lastActionTime; // 0x98
		public BirdLanding landing; // 0xA0
	
		// Constructors
		public Bird(); // 0x0000000180297AF0-0x0000000180297B70
	
		// Methods
		int IComparable<Bird>.CompareTo(Bird other); // 0x0000000180297AA0-0x0000000180297AD0
		int IComparable<Vector3>.CompareTo(Vector3 other); // 0x0000000180297AD0-0x0000000180297AF0
		private void OnDrawGizmos(); // 0x00000001802976B0-0x0000000180297AA0
	}

	public class BirdFlock : MonoBehaviour // TypeDefIndex: 4770
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh sitMesh; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh halfSitMesh; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh standMesh; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh landMesh; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh flapMesh; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh flyMesh; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh glideMesh; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ParticleSystem featherEffect; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Bird srcBird; // 0x60
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform activeBirds; // 0x68
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform disabledBirds; // 0x70
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Bird> birds; // 0x78
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int birdLandingCount; // 0x80
		public byte assignedBirdsCount; // 0x84
		public byte activeBirdsCount; // 0x85
		public byte totalBirdCount; // 0x86
		public byte maxBirdCount; // 0x87
		public byte minBirdCount; // 0x88
		public byte idealBirdCount; // 0x89
		public bool optimalBirdCountDirty; // 0x8A
		private const float dt = 0.3f; // Metadata: 0x0021FFFB
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int takeOffCount; // 0x8C
		private Vector3 takeOffPos; // 0x90
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private AudioClip[] flapAudioClips; // 0xA0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private AudioSource audioSource0; // 0xA8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private AudioSource audioSource1; // 0xB0
		private float lastAudioTime; // 0xB8
		private Vector3 orbitPos; // 0xBC
		private Vector3 orbitTarget; // 0xC8
		private float lastOrbitTime; // 0xD4
		private const float landingNeigbourRadius = 1.1f; // Metadata: 0x0021FFFF
		private const float landingNeigbourSqRadius = 1.21f; // Metadata: 0x00220003
	
		// Nested types
		[Serializable]
		private class FlapAudio // TypeDefIndex: 4771
		{
			// Fields
			public AudioSource audioSource; // 0x10
			public float denom; // 0x18
			public float volume; // 0x1C
			public Vector3 pos; // 0x20
	
			// Constructors
			public FlapAudio(); // 0x00000001801D0660-0x00000001801D0670
		}
	
		public enum State : byte // TypeDefIndex: 4772
		{
			Boiding = 0,
			Landing = 1,
			Stopping = 2,
			Stopped = 3,
			Leaving = 4
		}
	
		// Constructors
		public BirdFlock(); // 0x0000000180296F20-0x0000000180296F80
	
		// Methods
		public void CalculateOptimalLandings(); // 0x000000018028FBA0-0x000000018028FCC0
		public void OnReset(); // 0x0000000180291AB0-0x0000000180291C10
		public bool IterateBirdCreation(); // 0x0000000180290850-0x00000001802915C0
		private bool TryGetRandomLanding(out BirdLanding landing); // 0x0000000180296570-0x0000000180296710
		public void OnUpdate(); // 0x0000000180291C10-0x0000000180295CD0
		public void UprootRadius(Vector3 pos, float radius = 1f /* Metadata: 0x0021FFEF */, float speed = 1f /* Metadata: 0x0021FFF3 */); // 0x0000000180296CB0-0x0000000180296F20
		[ContextMenu] // 0x000000018013B5D0-0x000000018013B600
		private void UprootAllBirds(); // 0x0000000180296710-0x0000000180296890
		private Vector3 GetLandingPos(Bird bird); // 0x000000018028FCC0-0x000000018028FDB0
		private void SetState(Bird bird, State state); // 0x0000000180296480-0x0000000180296570
		public void UprootBird(Bird bird, float speed = 1f /* Metadata: 0x0021FFF7 */); // 0x0000000180296890-0x0000000180296CB0
		private BirdLanding GetLanding(Bird bird); // 0x000000018028FDB0-0x0000000180290610
		private ValueTuple<int3, int3> GetSearchCoordinates(Vector3 pos, float radius); // 0x0000000180290610-0x0000000180290850
		private void SetBird(BirdLanding landing, Bird bird); // 0x0000000180295CD0-0x0000000180296340
		public void AddOrRemoveLanding(BirdLanding landing, bool landingAdded); // 0x000000018028F3A0-0x000000018028FBA0
		private void SetLanding(Bird bird, BirdLanding landing); // 0x0000000180296340-0x0000000180296480
		private void OnDrawGizmos(); // 0x00000001802915C0-0x0000000180291AB0
	}

	public class BirdLanding : MonoBehaviour, IPropEnabled, IComparable<BirdLanding>, IComparable<Vector3> // TypeDefIndex: 4773
	{
		// Fields
		public Bird bird; // 0x18
		public byte neighbourCount; // 0x20
		public Vector3 normal; // 0x24
	
		// Properties
		public Vector3 pos { get; } // 0x0000000180297420-0x0000000180297470 
		public Vector3 sortPos { get; } // 0x0000000180297470-0x0000000180297590 
		public Vector3 targetPos { get; } // 0x0000000180297590-0x00000001802976B0 
	
		// Constructors
		public BirdLanding(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		int IComparable<BirdLanding>.CompareTo(BirdLanding other); // 0x0000000180297370-0x00000001802973D0
		int IComparable<Vector3>.CompareTo(Vector3 other); // 0x00000001802973D0-0x0000000180297420
		void IPropEnabled.OnTurnedOff(WorldMaster master); // 0x0000000180297300-0x0000000180297330
		void IPropEnabled.OnTurnedOn(WorldMaster master); // 0x0000000180297330-0x0000000180297360
		void IPropEnabled.OnFirstTurnedOn(WorldMaster master); // 0x0000000180297120-0x0000000180297300
		private void OnDrawGizmos(); // 0x0000000180296FA0-0x0000000180297120
		public void AddNeighbour(BirdLanding landing); // 0x0000000180296F80-0x0000000180296F90
		public void RemoveNeighbour(BirdLanding landing); // 0x0000000180297360-0x0000000180297370
		public void ClearNeighbours(); // 0x0000000180296F90-0x0000000180296FA0
	}

	public struct BirdSpot // TypeDefIndex: 4774
	{
		// Fields
		public Vector3 pos; // 0x00
		public Bird bird; // 0x10
	}
}

namespace Placemaker
{
	[Serializable]
	public struct BitMeshQuadChange : IComparable<BitMeshQuadChange> // TypeDefIndex: 4587
	{
		// Fields
		public byte quadIndex; // 0x00
		public int2 hexPos; // 0x04
		public bool state; // 0x0C
	
		// Methods
		int IComparable<BitMeshQuadChange>.CompareTo(BitMeshQuadChange other); // 0x000000018019B2E0-0x000000018019B390
	}
}

namespace Os.Utils
{
	public static class Bitwise // TypeDefIndex: 4915
	{
		// Methods
		public static bool IsBitSet(byte b, int index); // 0x0000000180B60FD0-0x0000000180B60FF0
		public static bool IsBitSet(int b, int index); // 0x0000000180B60FB0-0x0000000180B60FD0
		public static void SetBit(ref byte b, int index, bool value); // 0x0000000180B60FF0-0x0000000180B61010
		public static byte GetByte(bool bit0 = false /* Metadata: 0x0022035E */, bool bit1 = false /* Metadata: 0x0022035F */, bool bit2 = false /* Metadata: 0x00220360 */, bool bit3 = false /* Metadata: 0x00220361 */, bool bit4 = false /* Metadata: 0x00220362 */, bool bit5 = false /* Metadata: 0x00220363 */, bool bit6 = false /* Metadata: 0x00220364 */, bool bit7 = false /* Metadata: 0x00220365 */); // 0x0000000180B60F20-0x0000000180B60FB0
	}
}

namespace Placemaker
{
	public class BootMaster : MonoBehaviour // TypeDefIndex: 4588
	{
		// Fields
		public static BootMaster instance; // 0x00
		public Dim dim; // 0x18
		public LoadingUi loadingUi; // 0x20
		public AudioListener audioListener; // 0x28
		private AsyncOperation asyncOperation; // 0x30
		public WorldMaster worldMaster; // 0x38
		public UiMaster uiMaster; // 0x40
		private State state; // 0x48
	
		// Nested types
		private enum State // TypeDefIndex: 4589
		{
			Start = 0,
			Loading = 1,
			UiSetup = 2,
			WorldMasterEnable = 3,
			WorldMasterStart = 4,
			Being = 5,
			Done = 6
		}
	
		// Constructors
		public BootMaster(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void Update(); // 0x0000000180B613A0-0x0000000180B616A0
		public static void DoFullscreen(); // 0x0000000180B61010-0x0000000180B610E0
		private void OnEnable(); // 0x0000000180B610E0-0x0000000180B613A0
	}

	public class BorderDrawer : MonoBehaviour // TypeDefIndex: 4590
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh mesh; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material material; // 0x28
		private MaterialPropertyBlock block; // 0x30
	
		// Constructors
		public BorderDrawer(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void OnEnable(); // 0x0000000180B618A0-0x0000000180B61990
		private void SetupBlock(); // 0x0000000180B619F0-0x0000000180B61C30
		public void OnStart(); // 0x0000000180B61990-0x0000000180B619F0
		public void BoundsUpdated(); // 0x00000001801D8E80-0x00000001801D8E90
		public void Draw(); // 0x0000000180B616A0-0x0000000180B618A0
	}
}

namespace Placemaker.Life
{
	public class Butterfly : MonoBehaviour // TypeDefIndex: 4775
	{
		// Fields
		public Quaternion rotation0; // 0x18
		public Quaternion rotation1; // 0x28
		public Vector3 posMid; // 0x38
		public Vector3 velocityPrev; // 0x44
		public Vector3 velocityNext; // 0x50
		public Vector3 pos; // 0x5C
		public float time; // 0x68
		public ButterflyFlock.State state; // 0x6C
		public ButterflyLanding landing; // 0x70
	
		// Constructors
		public Butterfly(); // 0x000000018029A860-0x000000018029A8E0
	}

	public class ButterflyFlock : MonoBehaviour // TypeDefIndex: 4776
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Butterfly srcButterfly; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh flapMesh; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh sitMesh; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh sitFlapMesh; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform activeButterflies; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform disabledButterflies; // 0x48
		private const float dt = 0.3f; // Metadata: 0x0022000C
		public int landingCount; // 0x50
	
		// Nested types
		public enum State : byte // TypeDefIndex: 4777
		{
			Flying = 0,
			Stopping = 1,
			Stopped = 2
		}
	
		// Constructors
		public ButterflyFlock(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public void OnReset(); // 0x0000000180297FD0-0x0000000180298040
		public void OnUpdate(); // 0x0000000180298040-0x000000018029A190
		private void SetButterfly(ButterflyLanding landing, Butterfly butterfly); // 0x000000018029A350-0x000000018029A470
		private void SetLanding(Butterfly butterfly, ButterflyLanding landing); // 0x000000018029A470-0x000000018029A590
		public void AddLanding(ButterflyLanding landing); // 0x0000000180297B70-0x0000000180297FD0
		public void RemoveLanding(ButterflyLanding landing); // 0x000000018029A190-0x000000018029A350
	}

	public class ButterflyLanding : MonoBehaviour, IPropEnabled // TypeDefIndex: 4778
	{
		// Fields
		public Butterfly butterfly; // 0x18
	
		// Constructors
		public ButterflyLanding(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		void IPropEnabled.OnTurnedOn(WorldMaster master); // 0x000000018029A830-0x000000018029A860
		void IPropEnabled.OnFirstTurnedOn(WorldMaster master); // 0x00000001801D8E80-0x00000001801D8E90
		void IPropEnabled.OnTurnedOff(WorldMaster master); // 0x000000018029A800-0x000000018029A830
		private void OnDrawGizmos(); // 0x000000018029A590-0x000000018029A800
	}
}

namespace Placemaker.Ui
{
	public static class ButtonAudio // TypeDefIndex: 4662
	{
		// Nested types
		public struct AudioData // TypeDefIndex: 4663
		{
			// Fields
			public AudioClip clip; // 0x00
			public float pitch; // 0x08
		}
	
		public enum SoundType // TypeDefIndex: 4664
		{
			disabled = 0,
			buttonDown = 1,
			click = 2,
			all = 3
		}
	
		public interface IButtonAudioModifier // TypeDefIndex: 4665
		{
			// Methods
			void ModifyAudioData(ref AudioData audioData, SoundType soundType);
		}
	
		// Methods
		public static void Play(Transform t, SoundType soundType); // 0x0000000180B2C0B0-0x0000000180B2C420
	}

	public class ButtonAudio_Clip : MonoBehaviour, ButtonAudio.IButtonAudioModifier // TypeDefIndex: 4666
	{
		// Fields
		public AudioClip clip; // 0x18
		public ButtonAudio.SoundType soundType; // 0x20
	
		// Constructors
		public ButtonAudio_Clip(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		void Placemaker.Ui.ButtonAudio.IButtonAudioModifier.ModifyAudioData(ref ButtonAudio.AudioData audioData, ButtonAudio.SoundType soundType); // 0x0000000180B2C010-0x0000000180B2C030
	}

	public class ButtonAudio_Pitch : MonoBehaviour, ButtonAudio.IButtonAudioModifier // TypeDefIndex: 4667
	{
		// Fields
		public ButtonAudio.SoundType soundType; // 0x18
		[SerializeField] // 0x0000000180128FC0-0x0000000180128FF0
		[Space] // 0x0000000180128FC0-0x0000000180128FF0
		private Mode mode; // 0x1C
		public float min; // 0x20
		public float max; // 0x24
	
		// Nested types
		private enum Mode // TypeDefIndex: 4668
		{
			Add = 0,
			Set = 1
		}
	
		// Constructors
		public ButtonAudio_Pitch(); // 0x0000000180B2C090-0x0000000180B2C0B0
	
		// Methods
		void Placemaker.Ui.ButtonAudio.IButtonAudioModifier.ModifyAudioData(ref ButtonAudio.AudioData audioData, ButtonAudio.SoundType soundType); // 0x0000000180B2C030-0x0000000180B2C090
	}
}

namespace Os.Utils
{
	[Serializable]
	public struct ByteFloat // TypeDefIndex: 4916
	{
		// Fields
		public byte value; // 0x00
		public const byte max = 255; // Metadata: 0x00220366
		public const int factor = 256; // Metadata: 0x00220367
		public const byte half = 127; // Metadata: 0x0022036B
	
		// Properties
		public float f { get; set; } // 0x000000018019B460-0x000000018019B480 0x000000018019B4A0-0x000000018019B520
	
		// Constructors
		public ByteFloat(float value); // 0x000000018019B970-0x000000018019B980
	
		// Methods
		public static float ByteToFloat(byte b); // 0x0000000180B61FA0-0x0000000180B62040
		public static byte FloatToByte(float f); // 0x0000000180B62040-0x0000000180B62130
		public static explicit operator float(ByteFloat b); // 0x0000000180B61FA0-0x0000000180B62040
		public static explicit operator ByteFloat(float f); // 0x0000000180B62040-0x0000000180B62130
		public override bool Equals(object obj); // 0x000000018019B8E0-0x000000018019B970
		public static bool operator ==(ByteFloat a, ByteFloat b); // 0x0000000180B62130-0x0000000180B62140
		public static bool operator !=(ByteFloat a, ByteFloat b); // 0x0000000180B62140-0x0000000180B629A0
		public override int GetHashCode(); // 0x000000018003E300-0x000000018003E310
	}

	[Serializable]
	public struct ByteFloat2 // TypeDefIndex: 4917
	{
		// Fields
		public byte x; // 0x00
		public byte y; // 0x01
	
		// Properties
		public float fx { get; set; } // 0x000000018019B460-0x000000018019B480 0x000000018019B4A0-0x000000018019B520
		public float fy { get; set; } // 0x000000018019B480-0x000000018019B4A0 0x000000018019B520-0x000000018019B5A0
	
		// Constructors
		public ByteFloat2(float fx, float fy); // 0x000000018019B450-0x000000018019B460
	
		// Methods
		public static explicit operator Vector2(ByteFloat2 b); // 0x0000000180B61CB0-0x0000000180B61D00
		public static explicit operator int2(ByteFloat2 b); // 0x0000000180B61D00-0x0000000180B61D20
		public static explicit operator ByteFloat2(Vector2 f); // 0x0000000180B61C70-0x0000000180B61CB0
		public static explicit operator ByteFloat2(int2 f); // 0x0000000180B61C50-0x0000000180B61C70
		public override bool Equals(object obj); // 0x000000018019B390-0x000000018019B430
		public static bool operator ==(ByteFloat2 a, ByteFloat2 b); // 0x0000000180B61C30-0x0000000180B61C50
		public static bool operator !=(ByteFloat2 a, ByteFloat2 b); // 0x0000000180B61D20-0x0000000180B61EA0
		public override int GetHashCode(); // 0x000000018019B430-0x000000018019B450
	}

	[Serializable]
	public struct ByteFloat3 // TypeDefIndex: 4918
	{
		// Fields
		public byte x; // 0x00
		public byte y; // 0x01
		public byte z; // 0x02
	
		// Properties
		public float fx { get; set; } // 0x000000018019B460-0x000000018019B480 0x000000018019B4A0-0x000000018019B520
		public float fy { get; set; } // 0x000000018019B480-0x000000018019B4A0 0x000000018019B520-0x000000018019B5A0
		public float fz { get; set; } // 0x000000018019B710-0x000000018019B730 0x000000018019B860-0x000000018019B8E0
		public byte this[int key] { get => default; set {} } // 0x000000018019B680-0x000000018019B710 0x000000018019B7B0-0x000000018019B860
		public Vector3 normal { get; } // 0x000000018019B730-0x000000018019B7B0 
	
		// Constructors
		public ByteFloat3(float fx, float fy, float fz); // 0x000000018019B670-0x000000018019B680
	
		// Methods
		public static explicit operator Vector3(ByteFloat3 b); // 0x0000000180B61F00-0x0000000180B61F60
		public static explicit operator ByteFloat3(Vector3 f); // 0x0000000180B61EC0-0x0000000180B61F00
		public override bool Equals(object obj); // 0x000000018019B5A0-0x000000018019B650
		public static bool operator ==(ByteFloat3 a, ByteFloat3 b); // 0x0000000180B61EA0-0x0000000180B61EC0
		public static bool operator !=(ByteFloat3 a, ByteFloat3 b); // 0x0000000180B61F60-0x0000000180B61FA0
		public override int GetHashCode(); // 0x000000018019B650-0x000000018019B670
	}
}

namespace Placemaker
{
	[Serializable]
	public struct ByteQube // TypeDefIndex: 4647
	{
		// Fields
		public byte v0; // 0x00
		public byte v1; // 0x01
		public byte v2; // 0x02
		public byte v3; // 0x03
		public byte v4; // 0x04
		public byte v5; // 0x05
		public byte v6; // 0x06
		public byte v7; // 0x07
		public static readonly ByteQube identity; // 0x00
		public static readonly ByteQube rotateForward; // 0x08
		public static readonly ByteQube rotateBackward; // 0x10
		public static readonly ByteQube mirror; // 0x18
		public static readonly ByteQube tipForward; // 0x20
		public static readonly ByteQube tipBackward; // 0x28
		public static readonly ByteQube upsideDown; // 0x30
		public const byte uniqueOrientationCount = 48; // Metadata: 0x0021FEEC
		public const byte uprightOrientationCount = 8; // Metadata: 0x0021FEED
	
		// Properties
		public int cost { get; } // 0x000000018019BA30-0x000000018019BA90 
		public byte this[int key] { get => default; set {} } // 0x000000018019BB40-0x000000018019BB50 0x000000018019BB50-0x000000018019BC90
	
		// Constructors
		public ByteQube(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6, byte v7); // 0x000000018019BAE0-0x000000018019BB20
		public ByteQube(byte value); // 0x000000018019BB20-0x000000018019BB40
		static ByteQube(); // 0x0000000180B62D60-0x0000000180B63000
	
		// Methods
		public ByteQube GetOriented(ByteQube orientation); // 0x000000018019BAC0-0x000000018019BAD0
		public ByteQube GetOrientedForward(byte orientation); // 0x000000018019BAB0-0x000000018019BAC0
		public ByteQube GetOrientedBackward(byte orientation); // 0x000000018019BAA0-0x000000018019BAB0
		public void GetOptimalOrientation(out ByteQube optimalByteQube, out byte optimalOrientation); // 0x000000018019BA90-0x000000018019BAA0
		public override string ToString(); // 0x000000018019BAD0-0x000000018019BAE0
		public override int GetHashCode(); // 0x000000018019BA30-0x000000018019BA90
		public static int GetWrappedIndex(int corner, int height); // 0x0000000180B629A0-0x0000000180B62D60
		public override bool Equals(object obj); // 0x000000018019B980-0x000000018019BA30
		public static bool operator ==(ByteQube a, ByteQube b); // 0x0000000180B63000-0x0000000180B63090
		public static bool operator !=(ByteQube a, ByteQube b); // 0x0000000180B63090-0x0000000180B63230
	}
}

namespace TMPro
{
	public struct CaretInfo // TypeDefIndex: 4267
	{
		// Fields
		public int index; // 0x00
		public CaretPosition position; // 0x04
	
		// Constructors
		public CaretInfo(int index, CaretPosition position); // 0x0000000180002390-0x00000001800023A0
	}

	public enum CaretPosition // TypeDefIndex: 4266
	{
		None = 0,
		Left = 1,
		Right = 2
	}
}

namespace Placemaker
{
	public class ClickEffect : MonoBehaviour // TypeDefIndex: 4591
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ParticleSystem particle; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ParticleSystem voxelSplash; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ParticleSystem dust; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ParticleSystem colorPickEffect; // 0x38
		private VoxelType lastVoxelType; // 0x40
		private VoxelType lastColorPickType; // 0x41
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<AudioClip> addClips; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<AudioClip> splashClips; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<AudioClip> colorPickClips; // 0x58
		private float lastClick; // 0x60
		private float lastPitch; // 0x64
	
		// Constructors
		public ClickEffect(); // 0x0000000180B64800-0x0000000180B648B0
	
		// Methods
		public void ColorPick(HoverData hover); // 0x0000000180B640E0-0x0000000180B64470
		public void Click(bool add, Vector2 planePos, int height, VoxelType voxelType); // 0x0000000180B639D0-0x0000000180B64010
		public void Click(HoverData hover, bool add, Voxel voxel); // 0x0000000180B64010-0x0000000180B640E0
		public void ClickBig(VoxelType voxelType); // 0x0000000180B63230-0x0000000180B639D0
		private void SetColor(VoxelType voxelType); // 0x0000000180B645E0-0x0000000180B64800
		private void SetColorPickColor(VoxelType voxelType); // 0x0000000180B64470-0x0000000180B645E0
	}

	public class ClickParticleSound : MonoBehaviour // TypeDefIndex: 4592
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ParticleSystem particles; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float lowestSpeed; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<AudioClip> debrisClips; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<AudioClip> splashClips; // 0x38
	
		// Constructors
		public ClickParticleSound(); // 0x0000000180B65090-0x0000000180B65120
	
		// Methods
		public void OnParticleCollision(GameObject other); // 0x0000000180B648B0-0x0000000180B64CB0
		private void OnParticleTrigger(); // 0x0000000180B64CB0-0x0000000180B65090
	}
}

namespace Microsoft.CSharp
{
	internal class CodeDomProvider // TypeDefIndex: 1693
	{
		// Constructors
		public CodeDomProvider(); // 0x00000001801D0660-0x00000001801D0670
	}
}

namespace TMPro
{
	public enum ColorMode // TypeDefIndex: 4152
	{
		Single = 0,
		HorizontalGradient = 1,
		VerticalGradient = 2,
		FourCornersGradient = 3
	}

	internal struct ColorTween : TMPro.ITweenValue // TypeDefIndex: 4155
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private Color m_StartColor; // 0x08
		private Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public Color startColor { get; set; } // 0x0000000180002580-0x0000000180002590 0x00000001800025D0-0x00000001800025E0
		public Color targetColor { get; set; } // 0x0000000180002590-0x00000001800025A0 0x00000001800025E0-0x00000001800025F0
		public ColorTweenMode tweenMode { get; set; } // 0x00000001800025A0-0x00000001800025B0 0x00000001800025F0-0x0000000180002620
		public float duration { get; set; } // 0x0000000180002450-0x0000000180002460 0x00000001800025B0-0x00000001800025C0
		public bool ignoreTimeScale { get; set; } // 0x0000000180002460-0x0000000180002470 0x00000001800025C0-0x00000001800025D0
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 4156
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 4157
		{
			// Constructors
			public ColorTweenCallback(); // 0x00000001801D0000-0x00000001801D0040
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x0000000180002470-0x0000000180002570
		public void AddOnChangedCallback(UnityAction<Color> callback); // 0x00000001800023A0-0x0000000180002450
		public bool GetIgnoreTimescale(); // 0x0000000180002460-0x0000000180002470
		public float GetDuration(); // 0x0000000180002450-0x0000000180002460
		public bool ValidTarget(); // 0x0000000180002570-0x0000000180002580
	}

	public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 4272
	{
		Processing = 0,
		Completed = 1
	}

	public class Compute_DT_EventArgs // TypeDefIndex: 4274
	{
		// Fields
		public Compute_DistanceTransform_EventTypes EventType; // 0x10
		public float ProgressPercentage; // 0x14
		public Color[] Colors; // 0x18
	
		// Constructors
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress); // 0x00000001801D0080-0x00000001801D00C0
		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors); // 0x00000001801D0040-0x00000001801D0080
	}
}

namespace Placemaker.Graphs
{
	[Serializable]
	public class Corner : MonoBehaviour // TypeDefIndex: 4784
	{
		// Fields
		public int2 hexPos; // 0x18
		public List<Square> squares; // 0x20
		public Mesh colliderMesh; // 0x28
		public List<Vector2> blitVerts; // 0x30
		public List<FlowData> flowDatas; // 0x38
		public bool inFlowUpdateQueue; // 0x40
		public float angle; // 0x44
		public byte groundCoverage; // 0x48
	
		// Constructors
		public Corner(); // 0x0000000180B65900-0x0000000180B659B0
	
		// Methods
		private void OnDrawGizmos(); // 0x0000000180B65320-0x0000000180B65900
		public void AddSquare(Square quad0); // 0x0000000180B65120-0x0000000180B65320
	}
}

public class CornerImage : MaskableGraphic // TypeDefIndex: 4584
{
	// Fields
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	private Sprite _sprite; // 0xC8
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	private float innerSize; // 0xD0
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	private bool left; // 0xD4
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	private bool right; // 0xD5
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	private bool bottom; // 0xD6
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	private bool top; // 0xD7
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	private bool center; // 0xD8
	[Range] // 0x000000018012B0F0-0x000000018012B130
	[SerializeField] // 0x000000018012B0F0-0x000000018012B130
	private float _progress; // 0xDC

	// Properties
	public Sprite sprite { get; set; } // 0x00000001801FE630-0x00000001801FE640 0x00000001805C7F80-0x00000001805C8020
	public float progress { get; set; } // 0x00000001805C7F40-0x00000001805C7F50 0x00000001805C7F50-0x00000001805C7F80

	// Constructors
	public CornerImage(); // 0x00000001805C7F10-0x00000001805C7F40

	// Methods
	protected override void OnPopulateMesh(VertexHelper vh); // 0x00000001805C5E40-0x00000001805C7E50
	protected override void UpdateMaterial(); // 0x00000001805C7E50-0x00000001805C7F10
}

namespace Placemaker.Modules
{
	[Serializable]
	public class CornerLookup // TypeDefIndex: 4756
	{
		// Fields
		public ByteQube values; // 0x10
		public List<OrientedModule> orientedModules; // 0x18
	
		// Constructors
		public CornerLookup(); // 0x000000018029A8E0-0x000000018029A940
	}
}

namespace Placemaker.Modules.Processing
{
	public enum CornerState // TypeDefIndex: 4768
	{
		Unknown = 0,
		Outside = 1,
		Inside = 2
	}

	[Serializable]
	public struct CornerTouch // TypeDefIndex: 4763
	{
		// Fields
		public SbyteFloat3 pos; // 0x00
		public byte cornerIndex; // 0x03
		public byte axis; // 0x04
		public bool inside; // 0x05
		public byte distance; // 0x06
	}
}

namespace I2.Loc
{
	public class CoroutineManager : MonoBehaviour // TypeDefIndex: 4874
	{
		// Fields
		private static CoroutineManager mInstance; // 0x00
	
		// Properties
		private static CoroutineManager pInstance { get; } // 0x00000001805C81C0-0x00000001805C82D0 
	
		// Constructors
		public CoroutineManager(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void Awake(); // 0x00000001805C8020-0x00000001805C8090
		public static Coroutine Start(IEnumerator coroutine); // 0x00000001805C8090-0x00000001805C81C0
	}
}

namespace Microsoft.CSharp
{
	internal class CSharpCodeProvider : CodeDomProvider // TypeDefIndex: 1694
	{
		// Constructors
		public CSharpCodeProvider(); // 0x00000001801D0660-0x00000001801D0670
	}
}

public class CustomCameraProjection : MonoBehaviour // TypeDefIndex: 4580
{
	// Fields
	public Matrix4x4 originalProjection; // 0x18
	private Camera cam; // 0x58

	// Constructors
	public CustomCameraProjection(); // 0x00000001805C83A0-0x00000001805C8420

	// Methods
	private void Start(); // 0x00000001805C82D0-0x00000001805C8350
	private void Update(); // 0x00000001805C8350-0x00000001805C83A0
}

namespace I2.Loc
{
	[AddComponentMenu] // 0x0000000180142FC0-0x0000000180142FF0
	public class CustomLocalizeCallback : MonoBehaviour // TypeDefIndex: 4875
	{
		// Fields
		public UnityEvent _OnLocalize; // 0x18
	
		// Constructors
		public CustomLocalizeCallback(); // 0x00000001805C8570-0x00000001805C85D0
	
		// Methods
		public void OnEnable(); // 0x00000001805C84A0-0x00000001805C8550
		public void OnDisable(); // 0x00000001805C8420-0x00000001805C84A0
		public void OnLocalize(); // 0x00000001805C8550-0x00000001805C8570
	}
}

namespace Placemaker
{
	[Serializable]
	public class DecorModule : BaseModule // TypeDefIndex: 4613
	{
		// Constructors
		public DecorModule(); // 0x0000000180B60E00-0x0000000180B60F20
	}
}

namespace Placemaker.Modules.Processing
{
	[Serializable]
	public struct DecorPoint // TypeDefIndex: 4766
	{
		// Fields
		public int3 v; // 0x00
		public Vector3 pos; // 0x0C
		public Vector3 normal; // 0x18
	}

	[Serializable]
	public class DecorProfile // TypeDefIndex: 4765
	{
		// Fields
		private List<DecorPoint> points; // 0x10
	
		// Constructors
		public DecorProfile(); // 0x00000001801D0660-0x00000001801D0670
	}
}

namespace Os.Utils
{
	public static class DictPool<TKey, TValue> // TypeDefIndex: 4920
	{
		// Fields
		private static List<Dictionary<TKey, TValue>> pool;
	
		// Constructors
		static DictPool();
	
		// Methods
		public static Dictionary<TKey, TValue> Get(int capacity = 4 /* Metadata: 0x00220374 */);
		public static void Return(ref Dictionary<TKey, TValue> list);
	}

	public static class DictPoolExtension // TypeDefIndex: 4921
	{
		// Extension methods
		public static void ReturnToPool<K, V>(this Dictionary<K, V> list);
	}
}

namespace Placemaker.Ui
{
	public class Dim : MonoBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4669
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public UpdateState alphaState; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public UpdateState dimOrDark; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Color dimColor; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Color darkColor; // 0x40
	
		// Nested types
		public enum State // TypeDefIndex: 4670
		{
			Clear = 0,
			Dim = 1,
			Dark = 2
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 4671
		{
			// Fields
			public Graphic graphic; // 0x10
			public Dim <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass8_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B45640-0x0000000180B456C0
		}
	
		// Constructors
		public Dim(); // 0x0000000180B2C610-0x0000000180B2C6A0
	
		// Methods
		public void SetState(State state); // 0x0000000180B2C550-0x0000000180B2C610
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D8E80-0x00000001801D8E90
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B2C420-0x0000000180B2C550
	}

	public class DisableableButton : MonoBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4672
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private DistanceFieldSettings icon; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Graphic text; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Graphic background; // 0x28
		public UpdateState disabledState; // 0x30
		private Color bgColor0; // 0x38
		private Color bgColor1; // 0x48
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 4673
		{
			// Fields
			public DisableableButton <>4__this; // 0x10
			public BaseButton baseButton; // 0x18
	
			// Constructors
			public <>c__DisplayClass7_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x0); // 0x0000000180B452E0-0x0000000180B45460
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__1(float x0); // 0x0000000180B45460-0x0000000180B45580
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__2(float x0); // 0x0000000180B45580-0x0000000180B45600
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__3(BaseButton.State s); // 0x0000000180B45600-0x0000000180B45640
		}
	
		// Constructors
		public DisableableButton(); // 0x0000000180B2C9F0-0x0000000180B2CA50
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x0000000180B2C8F0-0x0000000180B2C9F0
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B2C6A0-0x0000000180B2C8F0
	}

	public class DistanceFieldMask : BaseMeshEffect // TypeDefIndex: 4674
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Vector4 offset; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Vector4 anchor; // 0x30
	
		// Constructors
		public DistanceFieldMask(); // 0x0000000180B2CD20-0x0000000180B2CD80
	
		// Methods
		public void SetDirty(); // 0x0000000180B2CCF0-0x0000000180B2CD20
		public override void ModifyMesh(VertexHelper vh); // 0x0000000180B2CA50-0x0000000180B2CCF0
	}

	public class DistanceFieldSettings : BaseMeshEffect // TypeDefIndex: 4675
	{
		// Fields
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		private float _cutoff; // 0x20
		[Range] // 0x0000000180131920-0x0000000180131960
		[SerializeField] // 0x0000000180131920-0x0000000180131960
		private float _outline; // 0x24
		[Range] // 0x0000000180131A30-0x0000000180131A70
		[SerializeField] // 0x0000000180131A30-0x0000000180131A70
		private float _shadow; // 0x28
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		private float _fill; // 0x2C
	
		// Properties
		public float cutoff { get; set; } // 0x00000001803FBE90-0x00000001803FBEA0 0x0000000180B2D0B0-0x0000000180B2D100
		public float outline { get; set; } // 0x00000001803B53C0-0x00000001803B53D0 0x0000000180B2D150-0x0000000180B2D1A0
		public float shadow { get; set; } // 0x00000001803979B0-0x00000001803979C0 0x0000000180B2D1A0-0x0000000180B2D1F0
		public float fill { get; set; } // 0x00000001803979A0-0x00000001803979B0 0x0000000180B2D100-0x0000000180B2D150
	
		// Constructors
		public DistanceFieldSettings(); // 0x0000000180B2D080-0x0000000180B2D0B0
	
		// Methods
		public void SetDirty(); // 0x0000000180B2CCF0-0x0000000180B2CD20
		public override void ModifyMesh(VertexHelper vh); // 0x0000000180B2CD80-0x0000000180B2CF10
		[ContextMenu] // 0x0000000180131B10-0x0000000180131B40
		private void NameAfterSprite(); // 0x0000000180B2CF10-0x0000000180B2D080
	}
}

namespace Os.Utils.InEditor
{
	[AttributeUsage] // 0x000000018014B200-0x000000018014B230
	public sealed class EditorRoutineAttribute : Attribute // TypeDefIndex: 4934
	{
		// Constructors
		public EditorRoutineAttribute(); // 0x00000001801E30B0-0x00000001801E30C0
	}
}

namespace I2.Loc
{
	public enum eLanguageDataFlags // TypeDefIndex: 4821
	{
		DISABLED = 1,
		KEEP_LOADED = 2,
		NOT_LOADED = 4
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated] // 0x0000000180111520-0x0000000180111550
	[Embedded] // 0x0000000180111520-0x0000000180111550
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 4572
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001801E30B0-0x00000001801E30C0
	}
}

namespace Placemaker.Ui
{
	public class EmptyGraphic : Graphic // TypeDefIndex: 4676
	{
		// Constructors
		public EmptyGraphic(); // 0x0000000180B2D210-0x0000000180B2D270
	
		// Methods
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180B2D1F0-0x0000000180B2D210
	}
}

namespace I2.Loc
{
	public enum ePluralType // TypeDefIndex: 4804
	{
		Zero = 0,
		One = 1,
		Two = 2,
		Few = 3,
		Many = 4,
		Plural = 5
	}

	public enum eSpreadsheetUpdateMode // TypeDefIndex: 4834
	{
		None = 0,
		Replace = 1,
		Merge = 2,
		AddNewTerms = 3
	}

	public enum eTermType // TypeDefIndex: 4869
	{
		Text = 0,
		Font = 1,
		Texture = 2,
		AudioClip = 3,
		GameObject = 4,
		Sprite = 5,
		Material = 6,
		Child = 7,
		Mesh = 8,
		TextMeshPFont = 9,
		Object = 10
	}

	[Serializable]
	public class EventCallback // TypeDefIndex: 4803
	{
		// Fields
		public MonoBehaviour Target; // 0x10
		public string MethodName; // 0x18
	
		// Constructors
		public EventCallback(); // 0x00000001805C8730-0x00000001805C8780
	
		// Methods
		public void Execute(UnityEngine.Object Sender = null); // 0x00000001805C85D0-0x00000001805C86A0
		public bool HasCallback(); // 0x00000001805C86A0-0x00000001805C8730
	}
}

public class ExampleScript : MonoBehaviour // TypeDefIndex: 4575
{
	// Nested types
	[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
	private sealed class <StartExamples>d__2 : IEnumerator<object> // TypeDefIndex: 4576
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ExampleScript <>4__this; // 0x20
		private CielaSpike.Task <task>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 

		// Constructors
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		public <StartExamples>d__2(int <>1__state); // 0x00000001801F3440-0x00000001801F3470

		// Methods
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
		private bool MoveNext(); // 0x00000001805DF250-0x00000001805DF530
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		void IEnumerator.Reset(); // 0x00000001805DF530-0x00000001805DF580
	}

	[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
	private sealed class <Blocking>d__3 : IEnumerator<object> // TypeDefIndex: 4577
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ExampleScript <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 

		// Constructors
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		public <Blocking>d__3(int <>1__state); // 0x00000001801F3440-0x00000001801F3470

		// Methods
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
		private bool MoveNext(); // 0x00000001805DEDA0-0x00000001805DEFC0
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		void IEnumerator.Reset(); // 0x00000001805DEFC0-0x00000001805DF010
	}

	[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
	private sealed class <Cancellation>d__4 : IEnumerator<object> // TypeDefIndex: 4578
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ExampleScript <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 

		// Constructors
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		public <Cancellation>d__4(int <>1__state); // 0x00000001801F3440-0x00000001801F3470

		// Methods
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
		private bool MoveNext(); // 0x00000001805DF010-0x00000001805DF0C0
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		void IEnumerator.Reset(); // 0x00000001805DF0C0-0x00000001805DF110
	}

	[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
	private sealed class <ErrorHandling>d__5 : IEnumerator<object> // TypeDefIndex: 4579
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ExampleScript <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
		object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 

		// Constructors
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		public <ErrorHandling>d__5(int <>1__state); // 0x00000001801F3440-0x00000001801F3470

		// Methods
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
		private bool MoveNext(); // 0x00000001805DF110-0x00000001805DF200
		[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
		void IEnumerator.Reset(); // 0x00000001805DF200-0x00000001805DF250
	}

	// Constructors
	public ExampleScript(); // 0x00000001801D0210-0x00000001801D0220

	// Methods
	private void Start(); // 0x00000001805C8B10-0x00000001805C8B80
	private void Update(); // 0x00000001805C8B80-0x00000001805C8C40
	[IteratorStateMachine] // 0x0000000180129330-0x0000000180129380
	private IEnumerator StartExamples(); // 0x00000001805C8AB0-0x00000001805C8B10
	[IteratorStateMachine] // 0x0000000180129380-0x00000001801293D0
	private IEnumerator Blocking(); // 0x00000001805C8780-0x00000001805C87E0
	[IteratorStateMachine] // 0x0000000180129420-0x0000000180129470
	private IEnumerator Cancellation(); // 0x00000001805C87E0-0x00000001805C8840
	[IteratorStateMachine] // 0x00000001801294C0-0x0000000180129510
	private IEnumerator ErrorHandling(); // 0x00000001805C8840-0x00000001805C88A0
	private void LogAsync(string msg); // 0x00000001805C88A0-0x00000001805C8910
	private void LogState(CielaSpike.Task task); // 0x00000001805C8980-0x00000001805C8A40
	private void LogSync(string msg); // 0x00000001805C8A40-0x00000001805C8AB0
	private void LogExample(string msg); // 0x00000001805C8910-0x00000001805C8980
}

namespace Os.Utils
{
	public static class Extensions // TypeDefIndex: 4922
	{
	}
}

namespace TMPro
{
	public struct Extents // TypeDefIndex: 4283
	{
		// Fields
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Constructors
		public Extents(Vector2 min, Vector2 max); // 0x0000000180002640-0x0000000180002650
	
		// Methods
		public override string ToString(); // 0x0000000180002630-0x0000000180002640
	}
}

namespace Os.Utils
{
	public static class ExtraMath // TypeDefIndex: 4923
	{
		// Fields
		public static readonly float toneScale; // 0x00
	
		// Constructors
		static ExtraMath(); // 0x0000000180B67400-0x0000000180B67470
	
		// Methods
		public static void Swap<T>(ref T a, ref T b);
		public static void Swap<T>(ref T a, ref T b, ref T c);
		public static void Swap<T>(ref T a, ref T b, ref T c, ref T d);
		public static float2 Rotate2D(float2 vector, float degrees); // 0x0000000180B67070-0x0000000180B67130
		public static float2 GetRotate2DFactors(float radians); // 0x0000000180B66910-0x0000000180B66950
		public static float2 ApplyRotate2DFactors(float2 vector, float2 factors); // 0x0000000180B659B0-0x0000000180B65A00
		public static Vector3 XZtoXYZ(Vector2 xz, float y = 0f /* Metadata: 0x00220378 */); // 0x0000000180B669B0-0x0000000180B669F0
		public static float3 XZtoXYZ(float2 xz, float y = 0f /* Metadata: 0x0022037C */); // 0x0000000180B66980-0x0000000180B669B0
		public static int Pow(int x, uint pow); // 0x0000000180B66FB0-0x0000000180B66FD0
		public static Vector3 GetBarycentric(Vector3 point, Vector3 p0, Vector3 p1, Vector3 p2); // 0x0000000180B663C0-0x0000000180B666F0
		public static Vector3 ClosestPointOnTriangle(Vector3 point, Vector3 p0, Vector3 p1, Vector3 p2); // 0x0000000180B65B90-0x0000000180B65DA0
		public static float Cross2([IsReadOnly] /* 0x0000000180110980-0x0000000180110990 */ in Vector2 v0, [IsReadOnly] /* 0x0000000180110980-0x0000000180110990 */ in Vector2 v1); // 0x0000000180B66110-0x0000000180B66130
		public static Vector2 InvBilinear(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p); // 0x0000000180B66AE0-0x0000000180B66DC0
		public static float ToneOffsetToPitch(float tone); // 0x0000000180B67360-0x0000000180B67400
	
		// Extension methods
		public static float2 Rotate2D90(this float2 vector); // 0x0000000180B67000-0x0000000180B67030
		public static float2 Rotate2D180(this float2 vector); // 0x0000000180ACB4A0-0x0000000180ACB4D0
		public static float2 Rotate2D270(this float2 vector); // 0x0000000180B66FD0-0x0000000180B67000
		public static Vector2 Rotate2D90(this Vector2 vector); // 0x0000000180B67030-0x0000000180B67070
		public static Vector3 Rotate90Y(this Vector3 vector); // 0x0000000180B67130-0x0000000180B67170
		public static Vector3 GetXYZfromXZ(this Vector2 xz, float y = 0f /* Metadata: 0x00220380 */); // 0x0000000180B669B0-0x0000000180B669F0
		public static float3 GetXYZfromXZ(this float2 xz, float y = 0f /* Metadata: 0x00220384 */); // 0x0000000180B66980-0x0000000180B669B0
		public static float4 GetXYZWfromXZ(this float2 xz, float y = 0f /* Metadata: 0x00220388 */, float w = 0f /* Metadata: 0x0022038C */); // 0x0000000180B66950-0x0000000180B66980
		public static float4 SetW(this float3 xyz, float w = 0f /* Metadata: 0x00220390 */); // 0x0000000180B671B0-0x0000000180B671F0
		public static float3 SetX(this float3 vector, float x = 0f /* Metadata: 0x00220394 */); // 0x0000000180B67230-0x0000000180B67250
		public static float3 SetY(this float3 vector, float y = 0f /* Metadata: 0x00220398 */); // 0x0000000180B672C0-0x0000000180B672E0
		public static float3 SetZ(this float3 vector, float z = 0f /* Metadata: 0x0022039C */); // 0x0000000180B67310-0x0000000180B67330
		public static Vector3 SetX(this Vector3 vector, float x = 0f /* Metadata: 0x002203A0 */); // 0x0000000180B671F0-0x0000000180B67230
		public static Vector3 SetY(this Vector3 vector, float y = 0f /* Metadata: 0x002203A4 */); // 0x0000000180B672E0-0x0000000180B67310
		public static Vector3 SetZ(this Vector3 vector, float z = 0f /* Metadata: 0x002203A8 */); // 0x0000000180B67330-0x0000000180B67360
		public static Vector4 SetW(this Vector3 vector, float w = 0f /* Metadata: 0x002203AC */); // 0x0000000180B67170-0x0000000180B671B0
		public static Color SetA(this Color color, float a = 0f /* Metadata: 0x002203B0 */); // 0x0000000180B67170-0x0000000180B671B0
		public static Vector2 SetX(this Vector2 vector, float x = 0f /* Metadata: 0x002203B4 */); // 0x0000000180B67250-0x0000000180B67280
		public static Vector2 SetY(this Vector2 vector, float y = 0f /* Metadata: 0x002203B8 */); // 0x0000000180B67280-0x0000000180B672C0
		public static float2 GetXZ(this float3 xyz); // 0x0000000180B669F0-0x0000000180B66A10
		public static Vector2 GetXZ(this Vector3 xyz); // 0x0000000180B66A10-0x0000000180B66A40
		public static Vector3 GetClampedMagnitude(this Vector3 vector, float maxMagnitude); // 0x0000000180B667E0-0x0000000180B66910
		public static Vector3 GetClampedMagnitudeOne(this Vector3 vector); // 0x0000000180B666F0-0x0000000180B667E0
		public static float Pow2(this float x); // 0x0000000180B66F90-0x0000000180B66FA0
		public static int Pow2(this int x); // 0x0000000180B66FA0-0x0000000180B66FB0
		public static bool OnEdge(this int3x2 bounds, int3 pos); // 0x0000000180B66DC0-0x0000000180B66F90
		public static bool Contains(this int3x2 bounds, int3 pos); // 0x0000000180B65E60-0x0000000180B65F00
		public static bool Contains(this int3x2 bounds, float3 pos); // 0x0000000180B65F00-0x0000000180B65FE0
		public static bool Contains(this int3x2 bounds0, int3x2 bounds1); // 0x0000000180B65FE0-0x0000000180B66110
		public static bool Intersects(this int3x2 bounds0, int3x2 bounds1); // 0x0000000180B66A40-0x0000000180B66AE0
		public static int3x2 Encapsulate(this int3x2 bounds, int3 hexPos3); // 0x0000000180B662E0-0x0000000180B663C0
		public static int3x2 Encapsulate(this int3x2 bounds0, int3x2 bounds1); // 0x0000000180B66130-0x0000000180B66230
		public static Vector2 Encapsulate(this Vector2 minMax, float value); // 0x0000000180B66230-0x0000000180B662E0
		public static int3 ClosestPoint(this int3x2 bounds0, int3 pos); // 0x0000000180B65DA0-0x0000000180B65E60
		public static int3 Center(this int3x2 bounds0); // 0x0000000180B65AF0-0x0000000180B65B90
		public static int BinarySearch<T, Y>(this List<T> list, Y value)
			where T : IComparable<Y>;
		public static int BinarySearchComponent<T, Y>(this Transform transform, Y item, int marginMin = 0 /* Metadata: 0x002203BC */, int marginMax = 0 /* Metadata: 0x002203C0 */)
			where T : Component, IComparable<Y>;
		public static int BinarySearchComponent<T>(this Transform transform, T item, int marginMin = 0 /* Metadata: 0x002203C4 */, int marginMax = 0 /* Metadata: 0x002203C8 */)
			where T : Component, IComparable<T>;
		public static int BinarySearchTransformX(this Transform transform, float x, int marginMin = 0 /* Metadata: 0x002203CC */, int marginMax = 0 /* Metadata: 0x002203D0 */); // 0x0000000180B65A00-0x0000000180B65AF0
	}
}

namespace TMPro
{
	[Serializable]
	public class FaceInfo_Legacy // TypeDefIndex: 4174
	{
		// Fields
		public string Name; // 0x10
		public float PointSize; // 0x18
		public float Scale; // 0x1C
		public int CharacterCount; // 0x20
		public float LineHeight; // 0x24
		public float Baseline; // 0x28
		public float Ascender; // 0x2C
		public float CapHeight; // 0x30
		public float Descender; // 0x34
		public float CenterLine; // 0x38
		public float SuperscriptOffset; // 0x3C
		public float SubscriptOffset; // 0x40
		public float SubSize; // 0x44
		public float Underline; // 0x48
		public float UnderlineThickness; // 0x4C
		public float strikethrough; // 0x50
		public float strikethroughThickness; // 0x54
		public float TabWidth; // 0x58
		public float Padding; // 0x5C
		public float AtlasWidth; // 0x60
		public float AtlasHeight; // 0x64
	
		// Constructors
		public FaceInfo_Legacy(); // 0x00000001801D0660-0x00000001801D0670
	}

	public class FastAction // TypeDefIndex: 4142
	{
		// Fields
		private LinkedList<System.Action> delegates; // 0x10
		private Dictionary<System.Action, LinkedListNode<System.Action>> lookup; // 0x18
	
		// Constructors
		public FastAction(); // 0x00000001801D0820-0x00000001801D08A0
	
		// Methods
		public void Add(System.Action rhs); // 0x00000001801D0670-0x00000001801D0710
		public void Remove(System.Action rhs); // 0x00000001801D0780-0x00000001801D0820
		public void Call(); // 0x00000001801D0710-0x00000001801D0780
	}

	public class FastAction<A> // TypeDefIndex: 4143
	{
		// Fields
		private LinkedList<Action<A>> delegates;
		private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup;
	
		// Constructors
		public FastAction();
	
		// Methods
		public void Add(Action<A> rhs);
		public void Remove(Action<A> rhs);
		public void Call(A a);
	}

	public class FastAction<A, B> // TypeDefIndex: 4144
	{
		// Fields
		private LinkedList<Action<A, B>> delegates;
		private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup;
	
		// Constructors
		public FastAction();
	
		// Methods
		public void Add(Action<A, B> rhs);
		public void Remove(Action<A, B> rhs);
		public void Call(A a, B b);
	}

	public class FastAction<A, B, C> // TypeDefIndex: 4145
	{
		// Fields
		private LinkedList<Action<A, B, C>> delegates;
		private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup;
	
		// Constructors
		public FastAction();
	
		// Methods
		public void Add(Action<A, B, C> rhs);
		public void Remove(Action<A, B, C> rhs);
		public void Call(A a, B b, C c);
	}

	internal struct FloatTween : TMPro.ITweenValue // TypeDefIndex: 4158
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get; set; } // 0x0000000180002730-0x0000000180002740 0x0000000180002770-0x0000000180002780
		public float targetValue { get; set; } // 0x0000000180002740-0x0000000180002750 0x0000000180002780-0x00000001800027B0
		public float duration { get; set; } // 0x0000000180002660-0x0000000180002670 0x0000000180002750-0x0000000180002760
		public bool ignoreTimeScale { get; set; } // 0x0000000180002670-0x0000000180002680 0x0000000180002760-0x0000000180002770
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 4159
		{
			// Constructors
			public FloatTweenCallback(); // 0x00000001801D08A0-0x00000001801D0A60
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x0000000180002680-0x0000000180002730
		public void AddOnChangedCallback(UnityAction<float> callback); // 0x0000000180002650-0x0000000180002660
		public bool GetIgnoreTimescale(); // 0x0000000180002670-0x0000000180002680
		public float GetDuration(); // 0x0000000180002660-0x0000000180002670
		public bool ValidTarget(); // 0x0000000180002570-0x0000000180002580
	}
}

namespace Placemaker.Graphs
{
	[Serializable]
	public class Flow : MonoBehaviour // TypeDefIndex: 4779
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform test; // 0x20
		private const float amountAdd = 1000000f; // Metadata: 0x00220013
	
		// Nested types
		private struct FlowCalcData // TypeDefIndex: 4780
		{
			// Fields
			public FlowData flowData; // 0x00
			public Corner corner; // 0x38
			public int count; // 0x40
			public int index; // 0x44
			public bool availale; // 0x48
			public bool open; // 0x49
			public Vector3 pos; // 0x4C
		}
	
		// Constructors
		public Flow(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void Update(); // 0x00000001802B7C40-0x00000001802B9A50
		private void FlowTwoFlows(ref FlowCalcData flow0, ref FlowCalcData flow1, float spaceDist); // 0x00000001802B5480-0x00000001802B57B0
		private void SetupFlowData(ref FlowCalcData flow0); // 0x00000001802B7B20-0x00000001802B7C40
		public void AddFlowTarget(float3 worldPos); // 0x00000001802B4890-0x00000001802B5480
		public ValueTuple<Vector3, Vector3, float, float> SampleFlow(Vector3 worldPos); // 0x00000001802B5A90-0x00000001802B7B20
		private void OnDrawGizmos(); // 0x00000001802B57B0-0x00000001802B5A90
	}

	[Serializable]
	public struct FlowData // TypeDefIndex: 4781
	{
		// Fields
		public Voxel voxel; // 0x00
		public byte neighbourCount; // 0x08
		public float dist; // 0x0C
		public float newDist; // 0x10
		public float denom; // 0x14
		public Vector3 dir; // 0x18
		public Vector3 newDir; // 0x24
		public bool target; // 0x30
		public static readonly FlowData empty; // 0x00
	
		// Constructors
		static FlowData(); // 0x00000001802B4810-0x00000001802B4890
	}

	[Serializable]
	public class FlowTarget : MonoBehaviour // TypeDefIndex: 4782
	{
		// Constructors
		public FlowTarget(); // 0x00000001801D0210-0x00000001801D0220
	}
}

namespace Placemaker
{
	public class Focus : MonoBehaviour // TypeDefIndex: 4593
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private AudioListener audioListener; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Camera cam; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Camera skyBoxCam; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Camera mirrorCam; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private BoxCollider groundCollider; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform reflectionPlane; // 0x48
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float zoomTarget; // 0x50
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float zoomCurrent; // 0x54
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float rotationY; // 0x58
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float rotationX; // 0x5C
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float panHexCurrentX; // 0x60
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float panHexCurrentY; // 0x64
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float panHeightCurrent; // 0x68
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float panHexTargetX; // 0x6C
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float panHexTargetY; // 0x70
		[Range] // 0x000000018012B0F0-0x000000018012B130
		[SerializeField] // 0x000000018012B0F0-0x000000018012B130
		public float panHeightTarget; // 0x74
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float rotationSpeedX; // 0x78
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float rotationSpeedY; // 0x7C
		public float3x2 boundsCurrent; // 0x80
		public float3x2 boundsTarget; // 0x98
		public float3 centerTarget; // 0xB0
		public float heightCurrent; // 0xBC
		public float heightTarget; // 0xC0
		public float2 radiusCurrent; // 0xC4
		public float2 radiusTarget; // 0xCC
		public float anyVoxelsCurrent; // 0xD4
		private const float minRadius = 3.5f; // Metadata: 0x0021FE53
		public bool snap; // 0xD8
		public const float maxAngle = 88f; // Metadata: 0x0021FE57
		private float currentDist; // 0xDC
	
		// Properties
		public Rect viewRect { get; set; } // 0x0000000180B6B1A0-0x0000000180B6B1E0 0x0000000180B6B1E0-0x0000000180B6B240
	
		// Constructors
		public Focus(); // 0x0000000180B6B150-0x0000000180B6B1A0
	
		// Methods
		private void OnEnable(); // 0x00000001801D8E80-0x00000001801D8E90
		private float GetMinAngle(float dist); // 0x0000000180B68400-0x0000000180B684B0
		public void SetBounds(float3x2 bounds); // 0x0000000180B6A660-0x0000000180B6AA20
		public void BoundsUpdated(); // 0x0000000180B67470-0x0000000180B679D0
		private void LateUpdate(); // 0x0000000180B686C0-0x0000000180B68DB0
		public void StopRotation(); // 0x0000000180B6AAB0-0x0000000180B6AAC0
		public void SetRotationSpeed(float2 delta); // 0x0000000180B6AA20-0x0000000180B6AAB0
		public void RotateCamera(float2 delta); // 0x0000000180B6A460-0x0000000180B6A580
		public ValueTuple<Vector3, Quaternion, float, float> GetCameraOrientation(float3x2 bounds, float boundsHeight, float rotationX, float rotationY, float panHexX, float panHexY, float panHeight, float zoom, float minFov = 16f /* Metadata: 0x0021FE4B */, float maxFov = 35f /* Metadata: 0x0021FE4F */); // 0x0000000180B679D0-0x0000000180B68400
		public Vector3 GetPanPos(float panHexX, float panHexY, float panHeight); // 0x0000000180B684B0-0x0000000180B686C0
		public void WASDCamera(Vector3 delta); // 0x0000000180B6AAC0-0x0000000180B6B150
		public void PanCamera(Vector2 pos, Vector2 delta2); // 0x0000000180B69780-0x0000000180B6A460
		private void OnGUI(); // 0x0000000180B696C0-0x0000000180B69780
		public void Save(SaveData saveData); // 0x0000000180B6A580-0x0000000180B6A660
		public void Load(SaveData saveData); // 0x0000000180B68DB0-0x0000000180B68EB0
		public void DoneLoading(); // 0x00000001801D8E80-0x00000001801D8E90
		public void OnDrawGizmos(); // 0x0000000180B68EB0-0x0000000180B696C0
	}
}

namespace Placemaker.Ui
{
	public class FocusedSaveCard : MonoBehaviour // TypeDefIndex: 4677
	{
		// Fields
		public RawImage image; // 0x18
		public CanvasGroup canvasGroup; // 0x20
	
		// Constructors
		public FocusedSaveCard(); // 0x00000001801D0210-0x00000001801D0220
	}
}

namespace TMPro
{
	[Serializable]
	public struct FontAssetCreationSettings // TypeDefIndex: 4176
	{
		// Fields
		public string sourceFontFileName; // 0x00
		public string sourceFontFileGUID; // 0x08
		public int pointSizeSamplingMode; // 0x10
		public int pointSize; // 0x14
		public int padding; // 0x18
		public int packingMode; // 0x1C
		public int atlasWidth; // 0x20
		public int atlasHeight; // 0x24
		public int characterSetSelectionMode; // 0x28
		public string characterSequence; // 0x30
		public string referencedFontAssetGUID; // 0x38
		public string referencedTextAssetGUID; // 0x40
		public int fontStyle; // 0x48
		public float fontStyleModifier; // 0x4C
		public int renderMode; // 0x50
		public bool includeFontFeatures; // 0x54
	
		// Constructors
		internal FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode); // 0x00000001800027B0-0x0000000180002A30
	}

	public enum FontFeatureLookupFlags // TypeDefIndex: 4190
	{
		IgnoreLigatures = 4,
		IgnoreSpacingAdjustments = 256
	}

	public enum FontStyles // TypeDefIndex: 4256
	{
		Normal = 0,
		Bold = 1,
		Italic = 2,
		Underline = 4,
		LowerCase = 8,
		UpperCase = 16,
		SmallCaps = 32,
		Strikethrough = 64,
		Superscript = 128,
		Subscript = 256,
		Highlight = 512
	}

	public enum FontWeight // TypeDefIndex: 4257
	{
		Thin = 100,
		ExtraLight = 200,
		Light = 300,
		Regular = 400,
		Medium = 500,
		SemiBold = 600,
		Bold = 700,
		Heavy = 800,
		Black = 900
	}
}

namespace Placemaker.Ui
{
	public class FullscreenButton : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4678
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup tick; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState state; // 0x28
	
		// Constructors
		public FullscreenButton(); // 0x0000000180B2D580-0x0000000180B2D5E0
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B2D2D0-0x0000000180B2D410
		public void Button_Toggle0(); // 0x0000000180B2D270-0x0000000180B2D2D0
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__4_0(float x); // 0x0000000180B2D410-0x0000000180B2D580
	}

	public class GameViewRect : UIBehaviour // TypeDefIndex: 4679
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster uiMaster; // 0x18
	
		// Properties
		public float left { get; set; } // 0x0000000180B2D930-0x0000000180B2D9A0 0x0000000180B2DB40-0x0000000180B2DC00
		public float bottom { get; set; } // 0x0000000180B2D8C0-0x0000000180B2D930 0x0000000180B2DA80-0x0000000180B2DB40
		public float right { get; set; } // 0x0000000180B2D9A0-0x0000000180B2DA10 0x0000000180B2DC00-0x0000000180B2DCC0
		public float top { get; set; } // 0x0000000180B2DA10-0x0000000180B2DA80 0x0000000180B2DCC0-0x0000000180B2DD80
	
		// Constructors
		public GameViewRect(); // 0x00000001802797F0-0x0000000180279800
	
		// Methods
		protected override void OnRectTransformDimensionsChange(); // 0x0000000180B2D750-0x0000000180B2D8C0
		public Rect GetRelativeRect(); // 0x0000000180B2D5E0-0x0000000180B2D750
	}
}

namespace I2.Loc
{
	internal enum GeneralArabicLetters // TypeDefIndex: 4886
	{
		Hamza = 1569,
		AlefMad = 1570,
		AlefHamza = 1571,
		WawHamza = 1572,
		AlefMaksoor = 1573,
		HamzaNabera = 1574,
		Alef = 1575,
		Ba = 1576,
		TaMarboota = 1577,
		Ta = 1578,
		Tha2 = 1579,
		Jeem = 1580,
		H7aa = 1581,
		Khaa2 = 1582,
		Dal = 1583,
		Thal = 1584,
		Ra2 = 1585,
		Zeen = 1586,
		Seen = 1587,
		Sheen = 1588,
		S9a = 1589,
		Dha = 1590,
		T6a = 1591,
		T6ha = 1592,
		Ain = 1593,
		Gain = 1594,
		Fa = 1601,
		Gaf = 1602,
		Kaf = 1603,
		Lam = 1604,
		Meem = 1605,
		Noon = 1606,
		Ha = 1607,
		Waw = 1608,
		AlefMagsora = 1609,
		Ya = 1610,
		PersianPe = 1662,
		PersianChe = 1670,
		PersianZe = 1688,
		PersianGaf2 = 1705,
		PersianGaf = 1711
	}
}

namespace TMPro
{
	public struct GlyphPairKey // TypeDefIndex: 4194
	{
		// Fields
		public uint firstGlyphIndex; // 0x00
		public uint secondGlyphIndex; // 0x04
		public long key; // 0x08
	
		// Constructors
		public GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex); // 0x0000000180002A30-0x0000000180002A50
		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record); // 0x0000000180002A50-0x0000000180002A90
	}

	[Serializable]
	public struct GlyphValueRecord_Legacy // TypeDefIndex: 4179
	{
		// Fields
		public float xPlacement; // 0x00
		public float yPlacement; // 0x04
		public float xAdvance; // 0x08
		public float yAdvance; // 0x0C
	
		// Constructors
		internal GlyphValueRecord_Legacy(GlyphValueRecord valueRecord); // 0x0000000180002A90-0x0000000180002AF0
	
		// Methods
		public static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b); // 0x00000001801D0A60-0x00000001801D0AB0
	}
}

namespace I2.Loc
{
	public static class GoogleLanguages // TypeDefIndex: 4805
	{
		// Fields
		public static Dictionary<string, LanguageCodeDef> mLanguageDef; // 0x00
	
		// Nested types
		public struct LanguageCodeDef // TypeDefIndex: 4806
		{
			// Fields
			public string Code; // 0x00
			public string GoogleCode; // 0x08
			public bool HasJoinedWords; // 0x10
			public int PluralRule; // 0x14
		}
	
		// Constructors
		static GoogleLanguages(); // 0x00000001805CABC0-0x00000001805D03A0
	
		// Methods
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false /* Metadata: 0x0022006B */); // 0x00000001805C91C0-0x00000001805C9450
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude); // 0x00000001805C9700-0x00000001805C9B40
		private static bool LanguageMatchesFilter(string Language, string[] Filters); // 0x00000001805CA8F0-0x00000001805CAA70
		public static string GetFormatedLanguageName(string Language); // 0x00000001805C8EA0-0x00000001805C8FB0
		public static string GetCodedLanguage(string Language, string code); // 0x00000001805C8DF0-0x00000001805C8EA0
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code); // 0x00000001805CAA70-0x00000001805CABC0
		public static string GetGoogleLanguageCode(string InternationalCode); // 0x00000001805C8FB0-0x00000001805C91C0
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false /* Metadata: 0x0022006C */, bool allowDiscardRegion = true /* Metadata: 0x0022006D */); // 0x00000001805C9450-0x00000001805C9700
		public static List<string> GetAllInternationalCodes(); // 0x00000001805C8C40-0x00000001805C8DF0
		public static bool LanguageCode_HasJoinedWord(string languageCode); // 0x00000001805CA570-0x00000001805CA740
		private static int GetPluralRule(string langCode); // 0x00000001805C9B40-0x00000001805C9D20
		public static bool LanguageHasPluralType(string langCode, string pluralType); // 0x00000001805CA740-0x00000001805CA8F0
		public static ePluralType GetPluralType(string langCode, int n); // 0x00000001805C9E30-0x00000001805CA570
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType); // 0x00000001805C9D20-0x00000001805C9E30
		private static bool inRange(int amount, int min, int max); // 0x00000001805D03A0-0x00000001805D03B0
	}

	public static class GoogleTranslation // TypeDefIndex: 4807
	{
		// Fields
		private static List<UnityWebRequest> mCurrentTranslations; // 0x00
		private static List<TranslationJob> mTranslationJobs; // 0x08
	
		// Nested types
		public delegate void fnOnTranslated(string Translation, string Error); // TypeDefIndex: 4808; 0x00000001805B93A0-0x00000001805B9790
	
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error); // TypeDefIndex: 4809; 0x00000001805B93A0-0x00000001805B9790
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 4810
		{
			// Fields
			public fnOnTranslated OnTranslationReady; // 0x10
			public string text; // 0x18
			public Dictionary<string, TranslationQuery> queries; // 0x20
			public string LanguageCodeTo; // 0x28
	
			// Constructors
			public <>c__DisplayClass2_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Translate>b__0(Dictionary<string, TranslationQuery> results, string error); // 0x00000001805DF590-0x00000001805DF680
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <WaitForTranslations>d__11 : IEnumerator<object> // TypeDefIndex: 4811
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <WaitForTranslations>d__11(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x00000001805DF740-0x00000001805DF8E0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001805DF8E0-0x00000001805DF930
		}
	
		// Constructors
		static GoogleTranslation(); // 0x00000001805D3450-0x00000001805D34E0
	
		// Methods
		public static bool CanTranslate(); // 0x00000001805D0780-0x00000001805D0820
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, fnOnTranslated OnTranslationReady); // 0x00000001805D2F40-0x00000001805D3300
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo); // 0x00000001805D15E0-0x00000001805D17D0
		public static void Translate(Dictionary<string, TranslationQuery> requests, fnOnTranslationReady OnTranslationReady, bool usePOST = true /* Metadata: 0x0022006E */); // 0x00000001805D2DD0-0x00000001805D2F40
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true /* Metadata: 0x0022006F */); // 0x00000001805D1560-0x00000001805D15E0
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET); // 0x00000001805D09D0-0x00000001805D0DD0
		private static void AddTranslationJob(TranslationJob job); // 0x00000001805D0680-0x00000001805D0780
		[IteratorStateMachine] // 0x000000018013EE20-0x000000018013EE70
		private static IEnumerator WaitForTranslations(); // 0x00000001805D3400-0x00000001805D3450
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests); // 0x00000001805D2200-0x00000001805D2720
		public static bool IsTranslating(); // 0x00000001805D1CC0-0x00000001805D1D60
		public static void CancelCurrentGoogleTranslations(); // 0x00000001805D0820-0x00000001805D09D0
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict); // 0x00000001805D10B0-0x00000001805D1290
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict); // 0x00000001805D0DD0-0x00000001805D10B0
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict); // 0x00000001805D03B0-0x00000001805D0680
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict); // 0x00000001805D1B60-0x00000001805D1C50
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict); // 0x00000001805D1360-0x00000001805D1560
		public static bool HasParameters(string text); // 0x00000001805D1C50-0x00000001805D1CC0
		public static string GetPluralParameter(string text, bool forceTag); // 0x00000001805D1860-0x00000001805D1930
		public static string GetPluralText(string text, string pluralType); // 0x00000001805D1930-0x00000001805D1A40
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex); // 0x00000001805D1290-0x00000001805D1360
		private static string GetGoogleNoTranslateTag(int tagNumber); // 0x00000001805D17D0-0x00000001805D1860
		private static void ParseNonTranslatableElements(ref TranslationQuery query); // 0x00000001805D1D60-0x00000001805D2200
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict); // 0x00000001805D1A40-0x00000001805D1B60
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo); // 0x00000001805D2AB0-0x00000001805D2D20
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo); // 0x00000001805D2720-0x00000001805D2AB0
		public static string UppercaseFirst(string s); // 0x00000001805D3300-0x00000001805D3400
		public static string TitleCase(string s); // 0x00000001805D2D20-0x00000001805D2DD0
	}
}

namespace Placemaker.Graphs
{
	public class Graph : MonoBehaviour // TypeDefIndex: 4785
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[HideInInspector] // 0x0000000180111520-0x0000000180111550
		[SerializeField] // 0x0000000180111520-0x0000000180111550
		public Transform qubePool; // 0x20
		[HideInInspector] // 0x0000000180111520-0x0000000180111550
		[SerializeField] // 0x0000000180111520-0x0000000180111550
		public Transform corners; // 0x28
		[HideInInspector] // 0x0000000180111520-0x0000000180111550
		[SerializeField] // 0x0000000180111520-0x0000000180111550
		public Transform cornerPool; // 0x30
		[HideInInspector] // 0x0000000180111520-0x0000000180111550
		[SerializeField] // 0x0000000180111520-0x0000000180111550
		public Transform squares; // 0x38
		[HideInInspector] // 0x0000000180111520-0x0000000180111550
		[SerializeField] // 0x0000000180111520-0x0000000180111550
		public Transform squarePool; // 0x40
		[HideInInspector] // 0x0000000180111520-0x0000000180111550
		[SerializeField] // 0x0000000180111520-0x0000000180111550
		public Transform looseVoxels; // 0x48
		[HideInInspector] // 0x0000000180111520-0x0000000180111550
		[SerializeField] // 0x0000000180111520-0x0000000180111550
		public Transform voxelPool; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint qubeIterator; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint cornerIterator; // 0x5C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint squareIterator; // 0x60
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint voxelIterator; // 0x64
		public Dictionary<int2, Corner> cornerDict; // 0x68
		public Dictionary<int2, Square> squareDict; // 0x70
		private Dictionary<int2x2, Square.Relation> edgeDict; // 0x78
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Corner> cornerIntegrationQueue; // 0x80
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Corner> cornerFlowQueue; // 0x88
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Qube> qubeUpdateQueue; // 0x90
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Bounds shadowMeshBounds; // 0x98
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<int> shadowMeshIndexes; // 0xB0
		private const int maxShadowQuadCount = 16381; // Metadata: 0x00220017
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int shadowMeshIndexIterator; // 0xB8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<BitMeshQuadChange> bitMeshQuadChanges; // 0xC0
		public const int maxVertsCount = 65535; // Metadata: 0x0022001B
		public const int quadPerShadowMeshCount = 16383; // Metadata: 0x0022001F
		[SerializeField] // 0x0000000180128FC0-0x0000000180128FF0
		[Space] // 0x0000000180128FC0-0x0000000180128FF0
		public int boundsHeight; // 0xC8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int3x2 bounds; // 0xCC
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int3x2 border; // 0xE4
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int3x2 genBounds; // 0xFC
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int3x2 viewBounds; // 0x114
		public const ushort borderExtent = 256; // Metadata: 0x00220023
		public const ushort genExtent = 96; // Metadata: 0x00220025
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool boundsUpdated; // 0x12C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool recalculateHexBounds; // 0x12D
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool recalculateHeightBounds; // 0x12E
		private LoadState loadState; // 0x130
	
		// Properties
		public bool anyVoxels { get; } // 0x00000001802C9900-0x00000001802C9930 
	
		// Nested types
		private enum LoadState // TypeDefIndex: 4786
		{
			Begin = 0,
			RemoveExistingVoxels = 1,
			ClearQubes = 2,
			LoadNewVoxels = 3,
			ApplyActions = 4
		}
	
		// Constructors
		public Graph(); // 0x00000001802C9790-0x00000001802C9900
	
		// Methods
		public void OnStart(); // 0x00000001802C4AE0-0x00000001802C4D20
		private void OnEnable(); // 0x00000001802C4760-0x00000001802C4AE0
		public Qube.Relation6 GetQubeRelation6(Qube qube, byte mask); // 0x00000001802BAB60-0x00000001802BB140
		public Qube.Relation GetQubeRelation(Qube qube, sbyte index); // 0x00000001802BB140-0x00000001802BB570
		public bool IterateFocus(); // 0x00000001802BE910-0x00000001802BFF40
		public void SetEmptyBoundsCenter(int2 centerPos); // 0x00000001802C9570-0x00000001802C9600
		public bool Iterate(); // 0x00000001802C0CE0-0x00000001802C1D80
		public bool IterateRefillPools(); // 0x00000001802C0B40-0x00000001802C0CE0
		private Corner GetNewCorner(Transform parent); // 0x00000001802BA710-0x00000001802BA750
		private Corner GetOrCreateCorner(int2 hexPos); // 0x00000001802BA900-0x00000001802BAB60
		private Voxel GetNewVoxel(Transform parent); // 0x00000001802BA820-0x00000001802BA900
		private Qube GetNewQube(Transform parent); // 0x00000001802BA750-0x00000001802BA790
		private Square GetNewSquare(Transform parent); // 0x00000001802BA790-0x00000001802BA820
		private bool IntegrateCorner(Corner voxelCorner); // 0x00000001802BC110-0x00000001802BDB80
		public void ApplyAction(Placemaker.Graphs.Action action, bool playEffect); // 0x00000001802BA0A0-0x00000001802BA400
		public bool IsCoordinateAllowed(int2 hexPos); // 0x00000001802BE820-0x00000001802BE910
		public Voxel AddVoxel(int2 hexPos, byte height, VoxelType voxelType, bool instantIntegration); // 0x00000001802B9A50-0x00000001802BA0A0
		private void IntegrateVoxel(Voxel voxel, Corner corner); // 0x00000001802BDB80-0x00000001802BE820
		public void RemoveVoxel(Voxel voxel); // 0x00000001802C50D0-0x00000001802C6470
		public void PaintVoxel(Voxel voxel, VoxelType newType, Corner corner = null); // 0x00000001802C4D20-0x00000001802C5060
		public void QubeUpdated(Qube qube); // 0x00000001802C5060-0x00000001802C50D0
		public int BinaryTreeSearchVoxel(Transform cornerTransform, int height); // 0x00000001802BA5F0-0x00000001802BA710
		public int BinaryTreeSearchCorner(int2 hexPos0); // 0x00000001802BA410-0x00000001802BA500
		public int BinaryTreeSearchSquare(Vector3 pos); // 0x00000001802BA500-0x00000001802BA5F0
		[ContextMenu] // 0x000000018013ED10-0x000000018013ED40
		public void Test(); // 0x00000001802C9600-0x00000001802C9790
		public void Save(SaveData saveData); // 0x00000001802C9280-0x00000001802C9570
		public void BeginLoad(SaveData saveData); // 0x00000001802BA400-0x00000001802BA410
		public bool IterateLoad(SaveData saveData); // 0x00000001802BFF40-0x00000001802C0B40
		public ValueTuple<Qube, Square, Vector2, Vector2, Vector2, Vector2, int> GetQubeWithContext(Vector3 worldPos); // 0x00000001802BB570-0x00000001802BC110
		public Vector3 SampleNormal(Vector3 worldPos); // 0x00000001802C91A0-0x00000001802C9280
		public ValueTuple<Vector3, float> SampleNormalCoverage(Vector3 worldPos); // 0x00000001802C6470-0x00000001802C68A0
		public ValueTuple<Vector3, float> SampleNormalCoverage(Vector3 worldPos, Transform qubeChild); // 0x00000001802C68A0-0x00000001802C69E0
		public ValueTuple<Vector3, float> SampleNormalCoverage(Vector3 worldPos, Qube qube); // 0x00000001802C69E0-0x00000001802C6F40
		public ValueTuple<Vector3, float> SampleNormalDistance(Vector3 worldPos); // 0x00000001802C7B00-0x00000001802C91A0
		public ValueTuple<Vector3, float> SampleNormalDistance2(Vector3 worldPos); // 0x00000001802C6F40-0x00000001802C7B00
		private void OnDrawGizmos(); // 0x00000001802C1D80-0x00000001802C4760
	}
}

namespace Placemaker
{
	[Serializable]
	public class GridBit : MonoBehaviour // TypeDefIndex: 4595
	{
		// Fields
		public int2 hexPos; // 0x18
		public byte motivations; // 0x20
		public byte relaxationSteps; // 0x21
		public byte clusterCount; // 0x22
		public bool patchDone; // 0x23
		public State state; // 0x24
		public List<float2> verts; // 0x28
	
		// Properties
		public bool done { get; } // 0x00000001802C99A0-0x00000001802C99B0 
	
		// Nested types
		public enum State : byte // TypeDefIndex: 4596
		{
			Verts = 0,
			Relax = 1,
			Clusters = 2,
			Compose = 3,
			Mesh = 4,
			Done = 5
		}
	
		// Constructors
		public GridBit(); // 0x00000001802C9930-0x00000001802C99A0
	}
}

namespace Placemaker.Ui
{
	public class GridButtons : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4680
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup tick0; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup tick1; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState gridState0; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState gridState1; // 0x38
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 4681
		{
			// Fields
			public GridButtons <>4__this; // 0x10
			public Camera camera; // 0x18
			public int mask; // 0x20
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B44FC0-0x0000000180B45160
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__1(float x); // 0x0000000180B45160-0x0000000180B452E0
		}
	
		// Constructors
		public GridButtons(); // 0x0000000180B2E030-0x0000000180B2E0B0
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B2DE00-0x0000000180B2E030
		public void Button_Toggle0(); // 0x0000000180B2DD80-0x0000000180B2DDC0
		public void Button_Toggle1(); // 0x0000000180B2DDC0-0x0000000180B2DE00
	}
}

namespace Placemaker.Quads.GridGeneration
{
	public static class GridConstants // TypeDefIndex: 4731
	{
		// Fields
		public const ushort hexScale = 12; // Metadata: 0x0021FFCB
		public const float hexInvScale = 0.083333336f; // Metadata: 0x0021FFCD
		public const float planeToHex = 8.22f; // Metadata: 0x0021FFD1
		public const float hexToPlane = 0.121654496f; // Metadata: 0x0021FFD5
		public const ushort hexDistance = 72; // Metadata: 0x0021FFD9
	}
}

namespace Placemaker
{
	public class GridGenerator : MonoBehaviour // TypeDefIndex: 4597
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Transform bitContainer; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<GridBit> bits; // 0x28
		private Dictionary<int2, GridBit> bitDict; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public List<HexPatch> patches; // 0x38
		public Dictionary<int2, HexPatch> patchDict; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<HexCluster> clusters; // 0x48
		private Dictionary<int2, HexCluster> clusterDict; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ushort bitProcessIndex; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<float2> deltas; // 0x60
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public bool focusUpdated; // 0x68
		private const float bitRadius = 10.510949f; // Metadata: 0x0021FE61
		private const int bitExtent = 84; // Metadata: 0x0021FE65
		private static readonly float diagonal; // 0x00
		private const int relaxIterations = 255; // Metadata: 0x0021FE69
		private const int bitMeshVertCount = 300; // Metadata: 0x0021FE6D
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4598
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<bool> <>9__42_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001802B3A00-0x00000001802B3A60
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <SceneProcessIteration>b__42_0(); // 0x000000018023BF40-0x000000018023BF50
		}
	
		// Constructors
		public GridGenerator(); // 0x00000001802D87F0-0x00000001802D8940
		static GridGenerator(); // 0x00000001802D87A0-0x00000001802D87F0
	
		// Methods
		public static float2 HexToPlane(float3 hexPos); // 0x00000001802CC9C0-0x00000001802CCA50
		public static float2 HexToPlane(float2 hexPos); // 0x00000001802CCB40-0x00000001802CCBD0
		public static float2 HexToPlane(int2 hexPos); // 0x00000001802CCBD0-0x00000001802CCC70
		public static float2 HexToPlane(int3 hexPos); // 0x00000001802CCA50-0x00000001802CCB40
		public static float3 PlaneToHex(float2 planePos); // 0x00000001802D6D20-0x00000001802D6DC0
		private int3 HexToPatchHex(float3 hexPos); // 0x00000001802CBF90-0x00000001802CC190
		public int2 HexToPatchHex(int2 hexPos); // 0x00000001802CC190-0x00000001802CC280
		public float GetVertCost(float2 hexPos); // 0x00000001802CB0C0-0x00000001802CB170
		public void PopulateBorderMesh(Vert vert, Mesh mesh); // 0x00000001802D6DC0-0x00000001802D7D10
		private int3 GetClosestClusterPos(int3 hexPos); // 0x00000001802C99B0-0x00000001802C9CA0
		public void HexToPatchHexes(int3 hexPos, out int3x3 patchPositions, out byte mask); // 0x00000001802CC280-0x00000001802CC9C0
		private int GetSubdivisions(int2 hexPos); // 0x00000001802CB020-0x00000001802CB0C0
		private bool IsBorder(int2 hexPos); // 0x00000001802CCC70-0x00000001802CCF40
		private void OnEnable(); // 0x00000001802D6970-0x00000001802D6D20
		public int2 GetPatchOffset(int2 clusterPos); // 0x00000001802CA030-0x00000001802CA220
		public static int2 GetClusterOffset(); // 0x00000001802C9FE0-0x00000001802CA030
		private GridBit MotivateBit(int2 bitPos); // 0x00000001802D2E60-0x00000001802D33A0
		private void UnmotivateBit(GridBit bit); // 0x00000001802D8520-0x00000001802D8590
		private void UnmotivateBitChildren(GridBit bit); // 0x00000001802D83B0-0x00000001802D8520
		private HexCluster MotivateCluster(int2 clusterPos, int2 sourcePos); // 0x00000001802D33A0-0x00000001802D36A0
		private void UnmotivateCluster(HexCluster cluster, int2 sourcePos); // 0x00000001802D86D0-0x00000001802D8720
		private void UnmotivateClusterChildren(HexCluster cluster); // 0x00000001802D8590-0x00000001802D86D0
		private HexPatch MotivatePatch(int2 patchPos, int2 sourcePos); // 0x00000001802D36A0-0x00000001802D38D0
		private void UnmotivatePatch(int2 patchPos, int2 sourcePos); // 0x00000001802D8720-0x00000001802D87A0
		private void IteratePatch(HexPatch patch); // 0x00000001802D00F0-0x00000001802D1B20
		private void IterateCluster(HexCluster cluster, Func<bool> keepGoing); // 0x00000001802CEED0-0x00000001802CFB90
		[ContextMenu] // 0x000000018012BF70-0x000000018012BFA0
		public void SceneProcessIteration(); // 0x00000001802D7D10-0x00000001802D7F00
		public void IterateBit(GridBit bit, Func<bool> keepGoing); // 0x00000001802CCF40-0x00000001802CEE20
		public bool IterateFocus(); // 0x00000001802CFB90-0x00000001802D00F0
		[ContextMenu] // 0x000000018012C070-0x000000018012C0A0
		private void Measure(); // 0x00000001802D1B20-0x00000001802D2E60
		public bool IterateBits(Func<bool> keepGoing); // 0x00000001802CEE20-0x00000001802CEED0
		public void SetQuadMesh(List<BitMeshQuadChange> changes); // 0x00000001802D7F00-0x00000001802D83B0
		public Quad GetQuad(float2 planePos); // 0x00000001802CA220-0x00000001802CB020
		public Vert GetClostestVertPosition(float2 planePos); // 0x00000001802C9CA0-0x00000001802C9FE0
		public Vert GetVertOrIterate(int2 hexPos, Func<bool> keepGoing = null); // 0x00000001802CB170-0x00000001802CBF90
		private void OnDrawGizmos(); // 0x00000001802D38D0-0x00000001802D6970
	}

	public class GroundClicker : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 4602
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		public VoxelType currentVoxelType; // 0x20
		public bool hovered; // 0x21
		public bool pressed; // 0x22
		public bool pressUsed; // 0x23
		public BobState bobState; // 0x24
		public Vector3 bobPos; // 0x28
		public float bobCurrent; // 0x34
		public float bobVelocity; // 0x38
		public float bobTime; // 0x3C
		public float pressTime; // 0x40
		public int pressPosAmountId; // 0x44
		private const float removeClickThreshold = 0.32f; // Metadata: 0x0021FE71
		private const float colorPickClickThreshold = 2f; // Metadata: 0x0021FE75
		public DragMode dragMode; // 0x48
		private int clickFrame; // 0x4C
		private int hoverFrame; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private HoverHightlight hoverHightlight; // 0x58
		private Plane dragPlane; // 0x60
		public Voxel lastAddedVoxel; // 0x70
		private Vector3[] drags; // 0x78
		private int dragIndex; // 0x80
		private const int dragCount = 5; // Metadata: 0x0021FE79
	
		// Properties
		private Maker maker { get; } // 0x000000018029C450-0x000000018029C470 
	
		// Nested types
		public enum BobState // TypeDefIndex: 4603
		{
			Nothing = 0,
			Pressed = 1,
			Relaxing = 2,
			Bouncing = 3
		}
	
		public enum DragMode // TypeDefIndex: 4604
		{
			NotDragging = 0,
			Undecided = 1,
			Spinning = 2,
			Panning = 3,
			TouchZooming = 4,
			TouchPanning = 5
		}
	
		// Constructors
		public GroundClicker(); // 0x000000018029C400-0x000000018029C450
	
		// Methods
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x000000018029C0A0-0x000000018029C0B0
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x000000018029C0B0-0x000000018029C130
		private void LateUpdate(); // 0x000000018029B110-0x000000018029B1F0
		private void MaybeUpdateHover(Vector2 pos); // 0x000000018029B1F0-0x000000018029B260
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData); // 0x000000018029BEC0-0x000000018029C000
		private void AddClick(); // 0x000000018029A940-0x000000018029A9C0
		private void RemoveClick(); // 0x000000018029B480-0x000000018029B620
		private void PaintClick(); // 0x000000018029B2A0-0x000000018029B480
		private void BucketClick(); // 0x000000018029A9C0-0x000000018029AD00
		private void BulldozeClick(); // 0x000000018029AD00-0x000000018029AFC0
		private void ColorPick(); // 0x000000018029B010-0x000000018029B110
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x000000018029B650-0x000000018029B780
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x000000018029B780-0x000000018029BC90
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x000000018029BC90-0x000000018029BEC0
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x000000018029C000-0x000000018029C0A0
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x000000018029C130-0x000000018029C170
		private void StopPressing(float velocity); // 0x000000018029B620-0x000000018029B650
		public void ClickBobEffect(Vector3 position, bool add); // 0x000000018029AFC0-0x000000018029B010
		private void OnEnable(); // 0x000000018029B260-0x000000018029B2A0
		private void Update(); // 0x000000018029C170-0x000000018029C400
	}
}

namespace Placemaker.Quads.GridGeneration
{
	[Serializable]
	public class HexCluster // TypeDefIndex: 4732
	{
		// Fields
		public int2 hexPos; // 0x10
		public MotivationCounter motivations; // 0x18
		public byte relaxationSteps; // 0x19
		public byte patchCount; // 0x1A
		public bool done; // 0x1B
		public int3 patchVertOffsets; // 0x1C
		public List<short> vertIndexes; // 0x28
		public List<float2> relaxedVerts; // 0x30
	
		// Constructors
		public HexCluster(); // 0x0000000180B2E0B0-0x0000000180B2E140
	}
}

namespace Os.Hex
{
	public static class HexMath // TypeDefIndex: 4911
	{
		// Fields
		public static readonly float hexAxisLength; // 0x00
		public static readonly float2 hexAxisX; // 0x04
		public static readonly float2 hexAxisY; // 0x0C
		public static readonly float2 hexAxisZ; // 0x14
		public static readonly Matrix4x4 hexToPlane; // 0x1C
		public static readonly Matrix4x4 hexToWorld; // 0x5C
		public static readonly Matrix4x4 planeToWorld; // 0x9C
		public static readonly float2 skewAxisX; // 0xDC
		public static readonly float2 skewAxisY; // 0xE4
		public static readonly Matrix4x4 skewToPlane; // 0xEC
		public static readonly Matrix4x4 planeToSkew; // 0x12C
		public static readonly Matrix4x4 hexToSkew; // 0x16C
		public static readonly Matrix4x4 skewToHex; // 0x1AC
	
		// Constructors
		static HexMath(); // 0x0000000180B6BAF0-0x0000000180B6C520
	
		// Methods
		public static float2 HexToPlane(float3 hexPos); // 0x0000000180B6B790-0x0000000180B6B870
		public static float2 HexToPlane(float2 hexPos); // 0x0000000180B6B870-0x0000000180B6B8F0
		public static float3 PlaneToHex(float2 planePos); // 0x0000000180B6B8F0-0x0000000180B6B9B0
		public static float3 PlaneToWorld(float2 planePos, float y = 0f /* Metadata: 0x0022035A */); // 0x0000000180B66980-0x0000000180B669B0
		public static float2 WorldToPlane(float3 worldPos); // 0x0000000180B669F0-0x0000000180B66A10
		public static float3 RotateCW(float3 hexPos); // 0x0000000180B6BA70-0x0000000180B6BAB0
		public static float3 RotateCCW(float3 hexPos); // 0x0000000180B6B9D0-0x0000000180B6BA10
		public static int2 RotateCW(int2 hexPos); // 0x0000000180B6BAB0-0x0000000180B6BAD0
		public static int3 RotateCW(int3 hexPos); // 0x0000000180B6BAD0-0x0000000180B6BAF0
		public static int2 RotateCCW(int2 hexPos); // 0x0000000180B6BA30-0x0000000180B6BA50
		public static int3 RotateCCW(int3 hexPos); // 0x0000000180B6BA10-0x0000000180B6BA30
		public static int2 RotateCW2(int2 hexPos); // 0x0000000180B6BA50-0x0000000180B6BA70
		public static int2 RotateCCW2(int2 hexPos); // 0x0000000180B6B9B0-0x0000000180B6B9D0
		public static int3 HexRound(float3 hexPos); // 0x0000000180B6B670-0x0000000180B6B790
		public static int3 HexRoundX(float3 hexPos); // 0x0000000180B6B5D0-0x0000000180B6B670
		public static float3 HexClamp(float3 hexPos, float3 min, float3 max); // 0x0000000180B6B2C0-0x0000000180B6B5D0
	
		// Extension methods
		public static int3 GetHex3(this int2 hex2); // 0x0000000180B6B2A0-0x0000000180B6B2C0
		public static float3 GetHex3(this float2 hex2); // 0x0000000180B6B270-0x0000000180B6B2A0
		public static int2 GetHex2(this int3 hexPos); // 0x0000000180B6B260-0x0000000180B6B270
		public static float2 GetHex2(this float3 hexPos); // 0x0000000180B6B240-0x0000000180B6B260
	}

	[Serializable]
	public struct HexOnionIterator // TypeDefIndex: 4913
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint _vertIndex; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint _sideIndex; // 0x04
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint _layerIndex; // 0x08
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint _vertIndexInSide; // 0x0C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint _vertCountInSide; // 0x10
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int3 _hexPos; // 0x14
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int3 delta; // 0x20
	
		// Properties
		public uint layerIndex { get; } // 0x0000000180017410-0x0000000180017450 
		public uint vertCountInSide { get; } // 0x000000018001B510-0x000000018001B520 
		public uint vertIndexInSide { get; } // 0x0000000180046BA0-0x0000000180046BB0 
		public uint sideIndex { get; } // 0x0000000180018120-0x0000000180018210 
		public uint vertIndex { get; set; } // 0x0000000180002FB0-0x0000000180002FC0 0x000000018019BD60-0x000000018019BD70
		public int3 hexPos3 { get; } // 0x000000018019BD40-0x000000018019BD60 
		public int2 hexPos2 { get; } // 0x000000018019BD30-0x000000018019BD40 
		public int2 dualPos2 { get; } // 0x000000018019BD10-0x000000018019BD30 
	
		// Methods
		public int3 GetAndIncrement(); // 0x000000018019BCB0-0x000000018019BCF0
		public static HexOnionIterator GetWidthDelta(int3 delta); // 0x0000000180B6CB90-0x0000000180B6D0B0
		public static HexOnionIterator GetAt(uint vertIndex); // 0x0000000180B6CB60-0x0000000180B6CB90
		public int3 Increment(); // 0x000000018019BCF0-0x000000018019BD10
		public int3 Decrement(); // 0x000000018019BC90-0x000000018019BCB0
	}

	internal class HexOnionIteratorGizmo : MonoBehaviour // TypeDefIndex: 4914
	{
		// Constructors
		public HexOnionIteratorGizmo(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void OnDrawGizmos(); // 0x0000000180B6C520-0x0000000180B6CB60
	}

	internal class HexOnionVisualizer : MonoBehaviour // TypeDefIndex: 4912
	{
		// Constructors
		public HexOnionVisualizer(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void OnDrawGizmos(); // 0x0000000180B6D0B0-0x0000000180B6D370
	}
}

namespace Placemaker.Quads.GridGeneration
{
	[Serializable]
	public class HexPatch // TypeDefIndex: 4733
	{
		// Fields
		public int2 hexPos; // 0x10
		public ushort quadTriCutoff; // 0x18
		public bool done; // 0x1A
		public List<byte> quads; // 0x20
		public List<int2> verts; // 0x28
		public MotivationCounter motivations; // 0x30
	
		// Constructors
		public HexPatch(); // 0x0000000180B2E140-0x0000000180B2E1D0
	}
}

namespace I2.Loc
{
	public class HindiFixer // TypeDefIndex: 4876
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4877
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<char, bool> <>9__0_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001805DF6E0-0x00000001805DF740
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <Fix>b__0_0(char x); // 0x00000001805DF580-0x00000001805DF590
		}
	
		// Constructors
		public HindiFixer(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		internal static string Fix(string text); // 0x00000001805D34E0-0x00000001805D3B50
	}
}

namespace Placemaker
{
	public class HoverData : MonoBehaviour // TypeDefIndex: 4605
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int lastId; // 0x20
		public Ray ray; // 0x24
		public Vert srcVert; // 0x3C
		public Vert dstVert; // 0x1EC
		public Voxel voxel; // 0x3A0
		public int dstHeight; // 0x3A8
		public Vector2 lastMousePos; // 0x3AC
		public Vector3 pointerHitPos; // 0x3B4
		public Vector3 pointerHitDir; // 0x3C0
		public byte side; // 0x3CC
		public bool occupied; // 0x3CD
		public bool insideBorders; // 0x3CE
		public bool validPaint; // 0x3CF
		public bool validAdd; // 0x3D0
		public bool validRemove; // 0x3D1
		public bool validBucket; // 0x3D2
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int floodIndex; // 0x3D4
		public List<Voxel> floodVoxels; // 0x3D8
	
		// Properties
		public int srcHeight { get; } // 0x000000018029E6B0-0x000000018029E740 
		public int2 srcHexPos { get; } // 0x000000018029E740-0x000000018029E750 
		public int2 dstHexPos { get; } // 0x000000018029E6A0-0x000000018029E6B0 
		public bool vertical { get; } // 0x000000018029E750-0x000000018029E770 
	
		// Constructors
		public HoverData(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public Vector3 GetSrcPos(); // 0x000000018029C5A0-0x000000018029C670
		public Vector3 GetDstPos(); // 0x000000018029C4D0-0x000000018029C5A0
		public void ClearHover(); // 0x000000018029C470-0x000000018029C4D0
		public void SetHover(Vector2 mousePos, int actionId); // 0x000000018029D5E0-0x000000018029E3E0
		private Vert TryGetVert(float2 planePos); // 0x000000018029E3E0-0x000000018029E6A0
		private void ModifyHoverFromPlane(); // 0x000000018029CBE0-0x000000018029CD00
		private void ModifyHoverFromVoxel(); // 0x000000018029CD00-0x000000018029D400
		public void Finish(); // 0x00000001801D8E80-0x00000001801D8E90
		private void Update(); // 0x00000001801D8E80-0x00000001801D8E90
		private bool Iterate(); // 0x000000018029C670-0x000000018029CBE0
		private void OnDrawGizmos(); // 0x000000018029D400-0x000000018029D5E0
	}

	public class HoverHightlight : MonoBehaviour // TypeDefIndex: 4599
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Mesh> meshes; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material drawMaterial; // 0x28
		private MaterialPropertyBlock block; // 0x30
		private int hoverMatrixId; // 0x38
		private int hoverPosId; // 0x3C
	
		// Constructors
		public HoverHightlight(); // 0x00000001802A05E0-0x00000001802A0640
	
		// Methods
		public void OnStart(); // 0x00000001802A0120-0x00000001802A05E0
		public void OnEnable(); // 0x00000001802A00A0-0x00000001802A0120
		public void Draw(); // 0x000000018029EB80-0x00000001802A00A0
		private void DrawQube(Qube qube, Material material, MaterialPropertyBlock block); // 0x000000018029E770-0x000000018029EB80
	}
}

namespace I2.Loc
{
	public abstract class I2BasePersistentStorage // TypeDefIndex: 4799
	{
		// Constructors
		protected I2BasePersistentStorage(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public virtual void SetSetting_String(string key, string value); // 0x00000001805D4570-0x00000001805D4730
		public virtual string GetSetting_String(string key, string defaultValue); // 0x00000001805D3E70-0x00000001805D3FF0
		public virtual void DeleteSetting(string key); // 0x00000001805D3D10-0x00000001805D3E60
		public virtual void ForceSaveSettings(); // 0x00000001805D3E60-0x00000001805D3E70
		public virtual bool HasSetting(string key); // 0x00000001805D41B0-0x00000001805D41C0
		public virtual bool CanAccessFiles(); // 0x000000018023BF40-0x000000018023BF50
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName); // 0x00000001805D4730-0x00000001805D47C0
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true /* Metadata: 0x0022004F */); // 0x00000001805D4390-0x00000001805D4570
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true /* Metadata: 0x00220050 */); // 0x00000001805D41C0-0x00000001805D4390
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true /* Metadata: 0x00220051 */); // 0x00000001805D3B50-0x00000001805D3D10
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true /* Metadata: 0x00220052 */); // 0x00000001805D3FF0-0x00000001805D41B0
	}

	public class I2CustomPersistentStorage : I2BasePersistentStorage // TypeDefIndex: 4800
	{
		// Constructors
		public I2CustomPersistentStorage(); // 0x00000001801D0660-0x00000001801D0670
	}

	public static class I2Utils // TypeDefIndex: 4878
	{
		// Fields
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_"; // Metadata: 0x00220186
		public const string NumberChars = "0123456789"; // Metadata: 0x002201C9
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&\',^=<>~`"; // Metadata: 0x002201D7
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4879
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<char, bool> <>9__6_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001805DF680-0x00000001805DF6E0
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <SplitLine>b__6_0(char c); // 0x00000001805DF580-0x00000001805DF590
		}
	
		// Methods
		public static string ReverseText(string source); // 0x00000001805D54D0-0x00000001805D55A0
		public static string RemoveNonASCII(string text, bool allowCategory = false /* Metadata: 0x00220184 */); // 0x00000001805D4F80-0x00000001805D51F0
		public static string GetValidTermName(string text, bool allowCategory = false /* Metadata: 0x00220185 */); // 0x00000001805D4ED0-0x00000001805D4F60
		public static string SplitLine(string line, int maxCharacters); // 0x00000001805D55C0-0x00000001805D5890
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd); // 0x00000001805D47C0-0x00000001805D4940
		public static string RemoveTags(string text); // 0x00000001805D5470-0x00000001805D54D0
		public static bool RemoveResourcesPath(ref string sPath); // 0x00000001805D51F0-0x00000001805D5470
		public static bool IsPlaying(); // 0x00000001805D4F60-0x00000001805D4F80
		public static Transform FindObject(string objectPath); // 0x00000001805D4A90-0x00000001805D4BF0
		public static Transform FindObject(Scene scene, string objectPath); // 0x00000001805D4940-0x00000001805D4A90
		public static Transform FindObject(Transform root, string objectPath); // 0x00000001805D4BF0-0x00000001805D4D10
		public static H FindInParents<H>(Transform tr)
			where H : Component;
		public static string GetCaptureMatch(Match match); // 0x00000001805D4D10-0x00000001805D4E10
		public static void SendWebRequest(UnityWebRequest www); // 0x00000001805D55A0-0x00000001805D55C0
	
		// Extension methods
		public static string GetPath(this Transform tr); // 0x00000001805D4E10-0x00000001805D4ED0
	}

	public interface ILanguageSource // TypeDefIndex: 4826
	{
		// Properties
		LanguageSourceData SourceData { get; set; }
	}

	public interface ILocalizationParamsManager // TypeDefIndex: 4880
	{
		// Methods
		string GetParameterValue(string Param);
	}

	public abstract class ILocalizeTarget : ScriptableObject // TypeDefIndex: 4851
	{
		// Constructors
		protected ILocalizeTarget(); // 0x00000001801D5C70-0x00000001801D5C80
	
		// Methods
		public abstract bool IsValid(Localize cmp);
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);
		public abstract bool CanUseSecondaryTerm();
		public abstract bool AllowMainTermToBeRTL();
		public abstract bool AllowSecondTermToBeRTL();
		public abstract eTermType GetPrimaryTermType(Localize cmp);
		public abstract eTermType GetSecondaryTermType(Localize cmp);
	}

	public abstract class ILocalizeTargetDescriptor // TypeDefIndex: 4853
	{
		// Fields
		public string Name; // 0x10
		public int Priority; // 0x18
	
		// Constructors
		protected ILocalizeTargetDescriptor(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public abstract bool CanLocalize(Localize cmp);
		public abstract ILocalizeTarget CreateTarget(Localize cmp);
		public abstract Type GetTargetType();
	}
}

namespace Os.Utils
{
	public static class Intersections // TypeDefIndex: 4924
	{
		// Fields
		public static readonly Vector3[] corners; // 0x00
		private static Stack<HashSet<Vector3>> axisHashSets; // 0x08
	
		// Constructors
		static Intersections(); // 0x0000000180B71E70-0x0000000180B721A0
	
		// Methods
		public static bool TriangleRay(Vector3 p1, Vector3 p2, Vector3 p3, Ray ray); // 0x0000000180B70BE0-0x0000000180B70F60
		public static bool BoxBox(Vector3 min0, Vector3 max0, Vector3 min1, Vector3 max1); // 0x0000000180B6D370-0x0000000180B6D3C0
		public static bool TriangleTriangle(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 v0, Vector3 v1, Vector3 v2, float minDistance = 0f /* Metadata: 0x002203D4 */); // 0x0000000180B71940-0x0000000180B71E70
		private static bool TriangleTriangleInternal(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 v0, Vector3 v1, Vector3 v2, float minDistance); // 0x0000000180B70F60-0x0000000180B71940
		public static bool OrientedBoxOrientedBox(Matrix4x4 box0, Matrix4x4 box1); // 0x0000000180B6ED20-0x0000000180B6EED0
		private static bool OrientedBoxOrientedBoxInternal(Matrix4x4 box0, Matrix4x4 box1, HashSet<Vector3> axisList); // 0x0000000180B6D3C0-0x0000000180B6ED20
		public static bool OrientedBoxTriangle(Matrix4x4 box0, Vector3 p0, Vector3 p1, Vector3 p2); // 0x0000000180B6EED0-0x0000000180B70BE0
	}
}

namespace Placemaker
{
	public interface IOnScenePostProcess // TypeDefIndex: 4600
	{
		// Methods
		void OnScenePostProcess(bool isBuild);
	}
}

namespace Placemaker.Props
{
	public interface IPropEnabled // TypeDefIndex: 4737
	{
		// Methods
		void OnFirstTurnedOn(WorldMaster master);
		void OnTurnedOn(WorldMaster master);
		void OnTurnedOff(WorldMaster master);
	}

	public interface IPropModifier // TypeDefIndex: 4736
	{
		// Methods
		void Apply(WorldMaster master, ref Unity.Mathematics.Random random, Square square, Vector3 ts);
		void Reset(WorldMaster master, Transform srcT);
	}
}

namespace I2.Loc
{
	public interface IResourceManager_Bundles // TypeDefIndex: 4892
	{
		// Methods
		UnityEngine.Object LoadFromBundle(string path, Type assetType);
	}

	internal enum IsolatedArabicLetters // TypeDefIndex: 4885
	{
		PersianPe = 64342,
		PersianChe = 64378,
		PersianZe = 64394,
		PersianGaf2 = 64398,
		PersianGaf = 64402,
		AlefMaksora = 64508,
		Hamza = 65152,
		AlefMad = 65153,
		AlefHamza = 65155,
		WawHamza = 65157,
		AlefMaksoor = 65159,
		HamzaNabera = 65161,
		Alef = 65165,
		Ba = 65167,
		TaMarboota = 65171,
		Ta = 65173,
		Tha2 = 65177,
		Jeem = 65181,
		H7aa = 65185,
		Khaa2 = 65189,
		Dal = 65193,
		Thal = 65195,
		Ra2 = 65197,
		Zeen = 65199,
		Seen = 65201,
		Sheen = 65205,
		S9a = 65209,
		Dha = 65213,
		T6a = 65217,
		T6ha = 65221,
		Ain = 65225,
		Gain = 65229,
		Fa = 65233,
		Gaf = 65237,
		Kaf = 65241,
		Lam = 65245,
		Meem = 65249,
		Noon = 65253,
		Ha = 65257,
		Waw = 65261,
		Ya = 65265
	}
}

namespace TMPro
{
	public interface ITextElement // TypeDefIndex: 4246
	{
		// Properties
		Material sharedMaterial { get; }
	
		// Methods
		void Rebuild(CanvasUpdate update);
		int GetInstanceID();
	}

	internal interface ITweenValue // TypeDefIndex: 4154
	{
		// Properties
		bool ignoreTimeScale { get; }
		float duration { get; }
	
		// Methods
		void TweenValue(float floatPercentage);
		bool ValidTarget();
	}
}

namespace I2.Loc.SimpleJSON
{
	public static class JSON // TypeDefIndex: 4910
	{
		// Methods
		public static JSONNode Parse(string aJSON); // 0x00000001803A1810-0x00000001803A1820
	}

	public class JSONArray : JSONNode, IEnumerable // TypeDefIndex: 4901
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
	
		// Properties
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x00000001803A0200-0x00000001803A02A0 0x00000001803A02A0-0x00000001803A0340
		public override JSONNode this[string aKey] { get => default; set {} } // 0x00000001803A01A0-0x00000001803A0200 0x00000001803A0340-0x00000001803A03A0
		public override int Count { get; } // 0x00000001803A0160-0x00000001803A01A0 
		public override IEnumerable<JSONNode> Childs { [IteratorStateMachine] /* 0x00000001801448D0-0x0000000180144920 */ get; } // 0x00000001803A00F0-0x00000001803A0160 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 4902
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			public JSONArray <>4__this; // 0x28
			private List<JSONNode> <>7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <get_Childs>d__13(int <>1__state); // 0x000000018037A8D0-0x000000018037A900
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001803B4B40-0x00000001803B4BE0
			private bool MoveNext(); // 0x00000001803B4900-0x00000001803B4A50
			private void <>m__Finally1(); // 0x00000001803B4BE0-0x00000001803B4C20
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001803B4AF0-0x00000001803B4B40
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x00000001803B4A50-0x00000001803B4AF0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803B4A50-0x00000001803B4AF0
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <GetEnumerator>d__14 : IEnumerator<object> // TypeDefIndex: 4903
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public JSONArray <>4__this; // 0x20
			private List<JSONNode> <>7__wrap1; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <GetEnumerator>d__14(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001803B3C70-0x00000001803B3D10
			private bool MoveNext(); // 0x00000001803B3AD0-0x00000001803B3C20
			private void <>m__Finally1(); // 0x00000001803B3D10-0x00000001803B3D50
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001803B3C20-0x00000001803B3C70
		}
	
		// Constructors
		public JSONArray(); // 0x00000001803A0090-0x00000001803A00F0
	
		// Methods
		public override void Add(string aKey, JSONNode aItem); // 0x000000018039FA40-0x000000018039FAA0
		public override JSONNode Remove(int aIndex); // 0x000000018039FB60-0x000000018039FC00
		public override JSONNode Remove(JSONNode aNode); // 0x000000018039FB00-0x000000018039FB60
		[IteratorStateMachine] // 0x00000001801449D0-0x0000000180144A20
		public IEnumerator GetEnumerator(); // 0x000000018039FAA0-0x000000018039FB00
		public override string ToString(); // 0x000000018039FD00-0x000000018039FE90
		public override string ToString(string aPrefix); // 0x000000018039FE90-0x00000001803A0090
		public override void Serialize(BinaryWriter aWriter); // 0x000000018039FC00-0x000000018039FD00
	}

	public enum JSONBinaryTag // TypeDefIndex: 4897
	{
		Array = 1,
		Class = 2,
		Value = 3,
		IntValue = 4,
		DoubleValue = 5,
		BoolValue = 6,
		FloatValue = 7
	}

	public class JSONClass : JSONNode, IEnumerable // TypeDefIndex: 4904
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
	
		// Properties
		public override JSONNode this[string aKey] { get => default; set {} } // 0x00000001803A1170-0x00000001803A1220 0x00000001803A12C0-0x00000001803A1370
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x00000001803A10E0-0x00000001803A1170 0x00000001803A1220-0x00000001803A12C0
		public override int Count { get; } // 0x00000001803A1090-0x00000001803A10E0 
		public override IEnumerable<JSONNode> Childs { [IteratorStateMachine] /* 0x0000000180146300-0x0000000180146350 */ get; } // 0x00000001803A1020-0x00000001803A1090 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 4905
		{
			// Fields
			public JSONNode aNode; // 0x10
	
			// Constructors
			public <>c__DisplayClass12_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k); // 0x00000001803B45B0-0x00000001803B4600
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 4906
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			public JSONClass <>4__this; // 0x28
			private Dictionary<string, JSONNode> <>7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <get_Childs>d__14(int <>1__state); // 0x000000018037A8D0-0x000000018037A900
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001803B4E70-0x00000001803B4F10
			private bool MoveNext(); // 0x00000001803B4C20-0x00000001803B4D80
			private void <>m__Finally1(); // 0x00000001803B4F10-0x00000001803B4F50
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001803B4E20-0x00000001803B4E70
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x00000001803B4D80-0x00000001803B4E20
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001803B4D80-0x00000001803B4E20
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <GetEnumerator>d__15 : IEnumerator<object> // TypeDefIndex: 4907
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public JSONClass <>4__this; // 0x20
			private Dictionary<string, JSONNode> <>7__wrap1; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <GetEnumerator>d__15(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001803B3F10-0x00000001803B3FB0
			private bool MoveNext(); // 0x00000001803B3D50-0x00000001803B3EC0
			private void <>m__Finally1(); // 0x00000001803B3FB0-0x00000001803B3FF0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001803B3EC0-0x00000001803B3F10
		}
	
		// Constructors
		public JSONClass(); // 0x00000001803A0F30-0x00000001803A1020
	
		// Methods
		public override void Add(string aKey, JSONNode aItem); // 0x00000001803A03A0-0x00000001803A04B0
		public override JSONNode Remove(string aKey); // 0x00000001803A05B0-0x00000001803A0660
		public override JSONNode Remove(int aIndex); // 0x00000001803A0510-0x00000001803A05B0
		public override JSONNode Remove(JSONNode aNode); // 0x00000001803A0660-0x00000001803A0770
		[IteratorStateMachine] // 0x00000001801463D0-0x0000000180146420
		public IEnumerator GetEnumerator(); // 0x00000001803A04B0-0x00000001803A0510
		public override string ToString(); // 0x00000001803A0940-0x00000001803A0C00
		public override string ToString(string aPrefix); // 0x00000001803A0C00-0x00000001803A0F30
		public override void Serialize(BinaryWriter aWriter); // 0x00000001803A0770-0x00000001803A0940
	}

	public class JSONData : JSONNode // TypeDefIndex: 4908
	{
		// Fields
		private string m_Data; // 0x10
	
		// Properties
		public override string Value { get; set; } // 0x00000001801D2960-0x00000001801D2970 0x00000001801D2970-0x00000001801D2980
	
		// Constructors
		public JSONData(string aData); // 0x00000001803A17A0-0x00000001803A17D0
		public JSONData(float aData); // 0x00000001803A1760-0x00000001803A17A0
		public JSONData(double aData); // 0x00000001803A16E0-0x00000001803A1720
		public JSONData(bool aData); // 0x00000001803A1720-0x00000001803A1760
		public JSONData(int aData); // 0x00000001803A17D0-0x00000001803A1810
	
		// Methods
		public override string ToString(); // 0x00000001803A1690-0x00000001803A16E0
		public override string ToString(string aPrefix); // 0x00000001803A1640-0x00000001803A1690
		public override void Serialize(BinaryWriter aWriter); // 0x00000001803A1370-0x00000001803A1640
	}

	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 4909
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x0000000180B72860-0x0000000180B728C0 0x0000000180B72B90-0x0000000180B72C60
		public override JSONNode this[string aKey] { get => default; set {} } // 0x0000000180B727F0-0x0000000180B72860 0x0000000180B72C60-0x0000000180B72D40
		public override int AsInt { get; set; } // 0x0000000180B726B0-0x0000000180B72750 0x0000000180B72AE0-0x0000000180B72B90
		public override float AsFloat { get; set; } // 0x0000000180B72610-0x0000000180B726B0 0x0000000180B72A30-0x0000000180B72AE0
		public override double AsDouble { get; set; } // 0x0000000180B72570-0x0000000180B72610 0x0000000180B72980-0x0000000180B72A30
		public override bool AsBool { get; set; } // 0x0000000180B724D0-0x0000000180B72570 0x0000000180B728D0-0x0000000180B72980
		public override JSONArray AsArray { get; } // 0x0000000180B72430-0x0000000180B724D0 
		public override JSONClass AsObject { get; } // 0x0000000180B72750-0x0000000180B727F0 
	
		// Constructors
		public JSONLazyCreator(JSONNode aNode); // 0x0000000180A337D0-0x0000000180A33800
		public JSONLazyCreator(JSONNode aNode, string aKey); // 0x00000001801D29E0-0x00000001801D2A20
	
		// Methods
		private void Set(JSONNode aVal); // 0x0000000180B72360-0x0000000180B723D0
		public override void Add(JSONNode aItem); // 0x0000000180B721A0-0x0000000180B72270
		public override void Add(string aKey, JSONNode aItem); // 0x0000000180B72270-0x0000000180B72350
		public static bool operator ==(JSONLazyCreator a, object b); // 0x0000000180B72350-0x0000000180B72360
		public static bool operator !=(JSONLazyCreator a, object b); // 0x0000000180B728C0-0x0000000180B728D0
		public override bool Equals(object obj); // 0x0000000180B72350-0x0000000180B72360
		public override int GetHashCode(); // 0x000000018046FB30-0x000000018046FB40
		public override string ToString(); // 0x0000000180B723D0-0x0000000180B72400
		public override string ToString(string aPrefix); // 0x0000000180B72400-0x0000000180B72430
	}

	public class JSONNode // TypeDefIndex: 4898
	{
		// Properties
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x0000000180207150-0x0000000180207160 0x00000001801D8E80-0x00000001801D8E90
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x0000000180207150-0x0000000180207160 0x00000001801D8E80-0x00000001801D8E90
		public virtual string Value { get; set; } // 0x0000000180B74410-0x0000000180B74440 0x00000001801D8E80-0x00000001801D8E90
		public virtual int Count { get; } // 0x0000000180207150-0x0000000180207160 
		public virtual IEnumerable<JSONNode> Childs { [IteratorStateMachine] /* 0x0000000180143420-0x0000000180143470 */ get; } // 0x0000000180B74340-0x0000000180B743A0 
		public IEnumerable<JSONNode> DeepChilds { [IteratorStateMachine] /* 0x0000000180143B30-0x0000000180143B80 */ get; } // 0x0000000180B743A0-0x0000000180B74410 
		public virtual int AsInt { get; set; } // 0x0000000180B74280-0x0000000180B742C0 0x0000000180B746D0-0x0000000180B74710
		public virtual float AsFloat { get; set; } // 0x0000000180B74230-0x0000000180B74280 0x0000000180B74690-0x0000000180B746D0
		public virtual double AsDouble { get; set; } // 0x0000000180B74190-0x0000000180B74230 0x0000000180B74650-0x0000000180B74690
		public virtual bool AsBool { get; set; } // 0x0000000180B740D0-0x0000000180B74190 0x0000000180B745E0-0x0000000180B74650
		public virtual JSONArray AsArray { get; } // 0x0000000180B74050-0x0000000180B740D0 
		public virtual JSONClass AsObject { get; } // 0x0000000180B742C0-0x0000000180B74340 
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 4899
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
	
			// Properties
			JSONNode IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <get_Childs>d__17(int <>1__state); // 0x000000018037A8D0-0x000000018037A900
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x0000000180B44520-0x0000000180B44530
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x0000000180B781F0-0x0000000180B78240
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000180B78160-0x0000000180B781F0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180B78160-0x0000000180B781F0
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 4900
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			public JSONNode <>4__this; // 0x28
			private IEnumerator<JSONNode> <>7__wrap1; // 0x30
			private IEnumerator<JSONNode> <>7__wrap2; // 0x38
	
			// Properties
			JSONNode IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <get_DeepChilds>d__19(int <>1__state); // 0x000000018037A8D0-0x000000018037A900
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x0000000180B785C0-0x0000000180B786C0
			private bool MoveNext(); // 0x0000000180B78240-0x0000000180B784D0
			private void <>m__Finally1(); // 0x0000000180B786C0-0x0000000180B78710
			private void <>m__Finally2(); // 0x0000000180B78710-0x0000000180B78760
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x0000000180B78570-0x0000000180B785C0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000180B784D0-0x0000000180B78570
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180B784D0-0x0000000180B78570
		}
	
		// Constructors
		public JSONNode(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public virtual void Add(string aKey, JSONNode aItem); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void Add(JSONNode aItem); // 0x0000000180B72D40-0x0000000180B72DA0
		public virtual JSONNode Remove(string aKey); // 0x0000000180207150-0x0000000180207160
		public virtual JSONNode Remove(int aIndex); // 0x0000000180207150-0x0000000180207160
		public virtual JSONNode Remove(JSONNode aNode); // 0x00000001804A1AA0-0x00000001804A1AB0
		public override string ToString(); // 0x0000000180B74020-0x0000000180B74050
		public virtual string ToString(string aPrefix); // 0x0000000180B73FF0-0x0000000180B74020
		public static implicit operator JSONNode(string s); // 0x0000000180B74560-0x0000000180B745C0
		public static implicit operator string(JSONNode d); // 0x0000000180B744D0-0x0000000180B74560
		public static bool operator ==(JSONNode a, object b); // 0x0000000180B74440-0x0000000180B744D0
		public static bool operator !=(JSONNode a, object b); // 0x0000000180B745C0-0x0000000180B745E0
		public override bool Equals(object obj); // 0x000000018031C810-0x000000018031C820
		public override int GetHashCode(); // 0x000000018046FB30-0x000000018046FB40
		internal static string Escape(string aText); // 0x0000000180B730D0-0x0000000180B73200
		public static JSONNode Parse(string aJSON); // 0x0000000180B735A0-0x0000000180B73BD0
		public virtual void Serialize(BinaryWriter aWriter); // 0x00000001801D8E80-0x00000001801D8E90
		public void SaveToStream(Stream aData); // 0x0000000180B73F70-0x0000000180B73FF0
		public void SaveToCompressedStream(Stream aData); // 0x0000000180B73DE0-0x0000000180B73E40
		public void SaveToCompressedFile(string aFileName); // 0x0000000180B73D80-0x0000000180B73DE0
		public string SaveToCompressedBase64(); // 0x0000000180B73D20-0x0000000180B73D80
		public void SaveToFile(string aFileName); // 0x0000000180B73E40-0x0000000180B73F70
		public string SaveToBase64(); // 0x0000000180B73BD0-0x0000000180B73D20
		public static JSONNode Deserialize(BinaryReader aReader); // 0x0000000180B72DA0-0x0000000180B730D0
		public static JSONNode LoadFromCompressedFile(string aFileName); // 0x0000000180B73310-0x0000000180B73370
		public static JSONNode LoadFromCompressedStream(Stream aData); // 0x0000000180B73370-0x0000000180B733D0
		public static JSONNode LoadFromCompressedBase64(string aBase64); // 0x0000000180B732B0-0x0000000180B73310
		public static JSONNode LoadFromStream(Stream aData); // 0x0000000180B734B0-0x0000000180B735A0
		public static JSONNode LoadFromFile(string aFileName); // 0x0000000180B733D0-0x0000000180B734B0
		public static JSONNode LoadFromBase64(string aBase64); // 0x0000000180B73200-0x0000000180B732B0
	}
}

namespace TMPro
{
	[Serializable]
	public class KerningPair // TypeDefIndex: 4180
	{
		// Fields
		[FormerlySerializedAs] // 0x000000018012AC40-0x000000018012AC90
		[SerializeField] // 0x000000018012AC40-0x000000018012AC90
		private uint m_FirstGlyph; // 0x10
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
		[FormerlySerializedAs] // 0x000000018012AD00-0x000000018012AD50
		[SerializeField] // 0x000000018012AD00-0x000000018012AD50
		private uint m_SecondGlyph; // 0x24
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
		[FormerlySerializedAs] // 0x000000018012AD80-0x000000018012ADB0
		public float xOffset; // 0x38
		internal static KerningPair empty; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_IgnoreSpacingAdjustments; // 0x3C
	
		// Properties
		public uint firstGlyph { get; set; } // 0x00000001801D0C20-0x00000001801D0C30 0x00000001801D0C60-0x00000001801D0C70
		public GlyphValueRecord_Legacy firstGlyphAdjustments { get; } // 0x00000001801D0C10-0x00000001801D0C20 
		public uint secondGlyph { get; set; } // 0x00000001801D0C50-0x00000001801D0C60 0x00000001801D0C70-0x00000001801D0C80
		public GlyphValueRecord_Legacy secondGlyphAdjustments { get; } // 0x00000001801D0C40-0x00000001801D0C50 
		public bool ignoreSpacingAdjustments { get; } // 0x00000001801D0C30-0x00000001801D0C40 
	
		// Constructors
		public KerningPair(); // 0x00000001801D0B30-0x00000001801D0B60
		public KerningPair(uint left, uint right, float offset); // 0x00000001801D0B60-0x00000001801D0BB0
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments); // 0x00000001801D0BB0-0x00000001801D0C10
		static KerningPair(); // 0x00000001801D0AC0-0x00000001801D0B30
	
		// Methods
		internal void ConvertLegacyKerningData(); // 0x00000001801D0AB0-0x00000001801D0AC0
	}

	public struct KerningPairKey // TypeDefIndex: 4178
	{
		// Fields
		public uint ascii_Left; // 0x00
		public uint ascii_Right; // 0x04
		public uint key; // 0x08
	
		// Constructors
		public KerningPairKey(uint ascii_left, uint ascii_right); // 0x0000000180002AF0-0x0000000180002B10
	}

	[Serializable]
	public class KerningTable // TypeDefIndex: 4181
	{
		// Fields
		public List<KerningPair> kerningPairs; // 0x10
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 4182
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <AddKerningPair>b__0(KerningPair item); // 0x00000001801F3530-0x00000001801F3560
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 4183
		{
			// Fields
			public uint first; // 0x10
			public uint second; // 0x14
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item); // 0x00000001801F3530-0x00000001801F3560
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 4184
		{
			// Fields
			public int left; // 0x10
			public int right; // 0x14
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <RemoveKerningPair>b__0(KerningPair item); // 0x00000001801F3560-0x00000001801F35A0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4185
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<KerningPair, uint> <>9__7_0; // 0x08
			public static Func<KerningPair, uint> <>9__7_1; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001801F36E0-0x00000001801F3740
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal uint <SortKerningPairs>b__7_0(KerningPair s); // 0x00000001801F34F0-0x00000001801F3510
			internal uint <SortKerningPairs>b__7_1(KerningPair s); // 0x00000001801F3510-0x00000001801F3530
		}
	
		// Constructors
		public KerningTable(); // 0x00000001801D1320-0x00000001801D1380
	
		// Methods
		public void AddKerningPair(); // 0x00000001801D0EE0-0x00000001801D1010
		public int AddKerningPair(uint first, uint second, float offset); // 0x00000001801D0DC0-0x00000001801D0EE0
		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments); // 0x00000001801D0C80-0x00000001801D0DC0
		public void RemoveKerningPair(int left, int right); // 0x00000001801D1070-0x00000001801D1150
		public void RemoveKerningPair(int index); // 0x00000001801D1010-0x00000001801D1070
		public void SortKerningPairs(); // 0x00000001801D1150-0x00000001801D1320
	}
}

namespace Placemaker
{
	public class KeyInputManager : MonoBehaviour // TypeDefIndex: 4606
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
	
		// Constructors
		public KeyInputManager(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void Update(); // 0x00000001802A06C0-0x00000001802A0EE0
		public static bool AnyControl(); // 0x00000001802A0670-0x00000001802A06C0
		public static bool AnyAlt(); // 0x00000001802A0640-0x00000001802A0670
	}
}

namespace Placemaker.Ui
{
	public class LanguageButtons : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4682
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		private List<string> languages; // 0x20
	
		// Nested types
		private struct S : IComparable<S> // TypeDefIndex: 4683
		{
			// Fields
			public string englishName; // 0x00
			public string nativeName; // 0x08
	
			// Methods
			int System.IComparable<Placemaker.Ui.LanguageButtons.S>.CompareTo(S other); // 0x0000000180198AC0-0x0000000180198AF0
		}
	
		// Constructors
		public LanguageButtons(); // 0x00000001802797F0-0x0000000180279800
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B2E1F0-0x0000000180B2E420
		public void Button_Left(); // 0x0000000180B2E1D0-0x0000000180B2E1E0
		public void Button_Right(); // 0x0000000180B2E1E0-0x0000000180B2E1F0
		public void ToggelLanguage(bool left); // 0x0000000180B2E420-0x0000000180B2E510
	}
}

namespace I2.Loc
{
	[Serializable]
	public class LanguageData // TypeDefIndex: 4822
	{
		// Fields
		public string Name; // 0x10
		public string Code; // 0x18
		public byte Flags; // 0x20
		[NonSerialized]
		public bool Compressed; // 0x21
	
		// Constructors
		public LanguageData(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public bool IsEnabled(); // 0x00000001805D58A0-0x00000001805D58B0
		public void SetEnabled(bool bEnabled); // 0x00000001805D58F0-0x00000001805D5920
		public bool IsLoaded(); // 0x00000001805D58B0-0x00000001805D58C0
		public bool CanBeUnloaded(); // 0x00000001805D5890-0x00000001805D58A0
		public void SetLoaded(bool loaded); // 0x00000001805D5920-0x00000001805D5950
		public void SetCanBeUnLoaded(bool allowUnloading); // 0x00000001805D58C0-0x00000001805D58F0
	}

	[AddComponentMenu] // 0x0000000180140530-0x0000000180140580
	[ExecuteInEditMode] // 0x0000000180140530-0x0000000180140580
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource // TypeDefIndex: 4823
	{
		// Fields
		public LanguageSourceData mSource; // 0x18
		public int version; // 0x20
		public bool NeverDestroy; // 0x24
		public bool UserAgreesToHaveItOnTheScene; // 0x25
		public bool UserAgreesToHaveItInsideThePluginsFolder; // 0x26
		public bool GoogleLiveSyncIsUptoDate; // 0x27
		public List<UnityEngine.Object> Assets; // 0x28
		public string Google_WebServiceURL; // 0x30
		public string Google_SpreadsheetKey; // 0x38
		public string Google_SpreadsheetName; // 0x40
		public string Google_LastUpdatedVersion; // 0x48
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency; // 0x50
		public float GoogleUpdateDelay; // 0x54
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private fnOnSourceUpdated Event_OnSourceUpdateFromGoogle; // 0x58
		public List<LanguageData> mLanguages; // 0x60
		public bool IgnoreDeviceLanguage; // 0x68
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages; // 0x6C
		public List<TermData> mTerms; // 0x70
		public bool CaseInsensitiveTerms; // 0x78
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation; // 0x7C
		public string mTerm_AppName; // 0x80
	
		// Properties
		public LanguageSourceData SourceData { get; set; } // 0x00000001801D0240-0x00000001801D0250 0x00000001801D0280-0x00000001801D0290
	
		// Events
		public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle {
			add; // 0x00000001805DE2D0-0x00000001805DE370
			remove; // 0x00000001805DE370-0x00000001805DE410
		}
	
		// Nested types
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg); // TypeDefIndex: 4824; 0x00000001805DFA70-0x00000001805DFFF0
	
		// Constructors
		public LanguageSource(); // 0x00000001805DE1F0-0x00000001805DE2D0
	
		// Methods
		private void Awake(); // 0x00000001805DDBF0-0x00000001805DDC80
		private void OnDestroy(); // 0x00000001805DE180-0x00000001805DE1F0
		public string GetSourceName(); // 0x00000001805DDC80-0x00000001805DDD60
		public void OnBeforeSerialize(); // 0x00000001805DE170-0x00000001805DE180
		public void OnAfterDeserialize(); // 0x00000001805DDD60-0x00000001805DE170
	}

	[CreateAssetMenu] // 0x0000000180140640-0x0000000180140690
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource // TypeDefIndex: 4825
	{
		// Fields
		public LanguageSourceData mSource; // 0x18
	
		// Properties
		public LanguageSourceData SourceData { get; set; } // 0x00000001801D0240-0x00000001801D0250 0x00000001801D0280-0x00000001801D0290
	
		// Constructors
		public LanguageSourceAsset(); // 0x00000001805D5950-0x00000001805D59B0
	}

	[Serializable]
	[ExecuteInEditMode] // 0x0000000180110980-0x0000000180110990
	public class LanguageSourceData // TypeDefIndex: 4827
	{
		// Fields
		[NonSerialized]
		public ILanguageSource owner; // 0x10
		public bool UserAgreesToHaveItOnTheScene; // 0x18
		public bool UserAgreesToHaveItInsideThePluginsFolder; // 0x19
		public bool GoogleLiveSyncIsUptoDate; // 0x1A
		[NonSerialized]
		public bool mIsGlobalSource; // 0x1B
		public List<TermData> mTerms; // 0x20
		public bool CaseInsensitiveTerms; // 0x28
		[NonSerialized]
		public Dictionary<string, TermData> mDictionary; // 0x30
		public MissingTranslationAction OnMissingTranslation; // 0x38
		public string mTerm_AppName; // 0x40
		public List<LanguageData> mLanguages; // 0x48
		public bool IgnoreDeviceLanguage; // 0x50
		public eAllowUnloadLanguages _AllowUnloadingLanguages; // 0x54
		public string Google_WebServiceURL; // 0x58
		public string Google_SpreadsheetKey; // 0x60
		public string Google_SpreadsheetName; // 0x68
		public string Google_LastUpdatedVersion; // 0x70
		public eGoogleUpdateFrequency GoogleUpdateFrequency; // 0x78
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency; // 0x7C
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization; // 0x80
		public float GoogleUpdateDelay; // 0x84
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle; // 0x88
		public List<UnityEngine.Object> Assets; // 0x90
		[NonSerialized]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary; // 0x98
		private string mDelayedGoogleData; // 0xA0
		public static string EmptyCategory; // 0x00
		public static char[] CategorySeparators; // 0x08
	
		// Properties
		public UnityEngine.Object ownerObject { get; } // 0x00000001805DDAD0-0x00000001805DDB50 
	
		// Events
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle {
			add; // 0x00000001805DDA30-0x00000001805DDAD0
			remove; // 0x00000001805DDB50-0x00000001805DDBF0
		}
	
		// Nested types
		public enum MissingTranslationAction // TypeDefIndex: 4828
		{
			Empty = 0,
			Fallback = 1,
			ShowWarning = 2,
			ShowTerm = 3
		}
	
		public enum eAllowUnloadLanguages // TypeDefIndex: 4829
		{
			Never = 0,
			OnlyInDevice = 1,
			EditorAndDevice = 2
		}
	
		public enum eGoogleUpdateFrequency // TypeDefIndex: 4830
		{
			Always = 0,
			Never = 1,
			Daily = 2,
			Weekly = 3,
			Monthly = 4,
			OnlyOnce = 5,
			EveryOtherDay = 6
		}
	
		public enum eGoogleUpdateSynchronization // TypeDefIndex: 4831
		{
			Manual = 0,
			OnSceneLoaded = 1,
			AsSoonAsDownloaded = 2
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4832
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<UnityEngine.Object> <>9__39_0; // 0x08
			public static Func<UnityEngine.Object, string> <>9__39_1; // 0x10
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__39_2; // 0x18
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__39_3; // 0x20
			public static Comparison<TermData> <>9__43_0; // 0x28
			public static Comparison<TermData> <>9__47_0; // 0x30
	
			// Constructors
			static <>c(); // 0x00000001803B48A0-0x00000001803B4900
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <UpdateAssetDictionary>b__39_0(UnityEngine.Object x); // 0x00000001803B43B0-0x00000001803B4410
			internal string <UpdateAssetDictionary>b__39_1(UnityEngine.Object o); // 0x00000001803B4410-0x00000001803B4430
			internal string <UpdateAssetDictionary>b__39_2(IGrouping<string, UnityEngine.Object> g); // 0x00000001803B4430-0x00000001803B4480
			internal UnityEngine.Object <UpdateAssetDictionary>b__39_3(IGrouping<string, UnityEngine.Object> g); // 0x00000001803B4480-0x00000001803B44C0
			internal int <Export_I2CSV>b__43_0(TermData a, TermData b); // 0x00000001803B4380-0x00000001803B43B0
			internal int <Export_CSV>b__47_0(TermData a, TermData b); // 0x00000001803B4380-0x00000001803B43B0
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <Import_Google_Coroutine>d__65 : IEnumerator<object> // TypeDefIndex: 4833
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LanguageSourceData <>4__this; // 0x20
			public bool JustCheck; // 0x28
			private UnityWebRequest <www>5__2; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <Import_Google_Coroutine>d__65(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x00000001803B3FF0-0x00000001803B42D0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001803B42D0-0x00000001803B4320
		}
	
		// Constructors
		public LanguageSourceData(); // 0x00000001805DD840-0x00000001805DDA30
		static LanguageSourceData(); // 0x00000001805DD7D0-0x00000001805DD840
	
		// Methods
		public void Awake(); // 0x00000001805D6BC0-0x00000001805D6C40
		public void OnDestroy(); // 0x00000001805DC180-0x00000001805DC1E0
		public bool IsEqualTo(LanguageSourceData Source); // 0x00000001805DB9F0-0x00000001805DBB90
		internal bool ManagerHasASimilarSource(); // 0x00000001805DC070-0x00000001805DC180
		public void ClearAllData(); // 0x00000001805D6C40-0x00000001805D6CD0
		public bool IsGlobalSource(); // 0x00000001805DBB90-0x00000001805DBBA0
		public void Editor_SetDirty(); // 0x00000001801D8E80-0x00000001801D8E90
		public void UpdateAssetDictionary(); // 0x00000001805DCF80-0x00000001805DD2B0
		public UnityEngine.Object FindAsset(string Name); // 0x00000001805D82C0-0x00000001805D8380
		public bool HasAsset(UnityEngine.Object Obj); // 0x00000001805D9C40-0x00000001805D9CA0
		public void AddAsset(UnityEngine.Object Obj); // 0x00000001805D59B0-0x00000001805D5A30
		public string Export_I2CSV(string Category, char Separator = ',' /* Metadata: 0x00220088 */, bool specializationsAsRows = true /* Metadata: 0x0022008A */); // 0x00000001805D7A00-0x00000001805D8040
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization); // 0x00000001805D5FC0-0x00000001805D6230
		private static void AppendI2Text(StringBuilder Builder, string text); // 0x00000001805D6230-0x00000001805D62E0
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback); // 0x00000001805D8040-0x00000001805D82C0
		public string Export_CSV(string Category, char Separator = ',' /* Metadata: 0x0022008B */, bool specializationsAsRows = true /* Metadata: 0x0022008D */); // 0x00000001805D6F60-0x00000001805D7680
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator); // 0x00000001805D63F0-0x00000001805D6690
		private static void AppendString(StringBuilder Builder, string Text, char Separator); // 0x00000001805D62E0-0x00000001805D63F0
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags); // 0x00000001805D6690-0x00000001805D67D0
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace /* Metadata: 0x0022008E */); // 0x00000001805D7890-0x00000001805D7A00
		private string Export_Google_CreateData(); // 0x00000001805D7680-0x00000001805D7890
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace /* Metadata: 0x00220092 */, char Separator = ',' /* Metadata: 0x00220096 */); // 0x00000001805DAB90-0x00000001805DABF0
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace /* Metadata: 0x00220098 */); // 0x00000001805DB730-0x00000001805DB780
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace /* Metadata: 0x0022009C */); // 0x00000001805D9DE0-0x00000001805DAB90
		private bool ArrayContains(string MainText, params /* 0x0000000180110980-0x0000000180110990 */ string[] texts); // 0x00000001805D6B30-0x00000001805D6BC0
		public static eTermType GetTermType(string type); // 0x00000001805D9900-0x00000001805D99C0
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization); // 0x00000001805DB780-0x00000001805DB950
		public static void FreeUnusedLanguages(); // 0x00000001805D8380-0x00000001805D84E0
		public void Import_Google_FromCache(); // 0x00000001805DAE20-0x00000001805DB030
		private bool IsNewerVersion(string currentVersion, string newVersion); // 0x00000001805DBCD0-0x00000001805DBD70
		public void Import_Google(bool ForceUpdate, bool justCheck); // 0x00000001805DB4C0-0x00000001805DB730
		private string GetSourcePlayerPrefName(); // 0x00000001805D9420-0x00000001805D9620
		[IteratorStateMachine] // 0x00000001801407D0-0x0000000180140820
		private IEnumerator Import_Google_Coroutine(bool JustCheck); // 0x00000001805DABF0-0x00000001805DAC70
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode); // 0x00000001805D6910-0x00000001805D6AA0
		public void ApplyDownloadedDataFromGoogle(); // 0x00000001805D67D0-0x00000001805D6910
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck); // 0x00000001805DAC70-0x00000001805DAE20
		public bool HasGoogleSpreadsheet(); // 0x00000001805D9CA0-0x00000001805D9D30
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false /* Metadata: 0x002200A0 */); // 0x00000001805DB030-0x00000001805DB4C0
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true /* Metadata: 0x002200A1 */, bool SkipDisabled = true /* Metadata: 0x002200A2 */); // 0x00000001805D8CE0-0x00000001805D8EB0
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true /* Metadata: 0x002200A3 */); // 0x00000001805D8A90-0x00000001805D8B30
		public bool IsCurrentLanguage(int languageIndex); // 0x00000001805DB950-0x00000001805DB9F0
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true /* Metadata: 0x002200A4 */, bool ignoreDisabled = false /* Metadata: 0x002200A5 */); // 0x00000001805D8B30-0x00000001805D8CE0
		public static int GetCommonWordInLanguageNames(string Language1, string Language2); // 0x00000001805D87E0-0x00000001805D89A0
		public static bool AreTheSameLanguage(string Language1, string Language2); // 0x00000001805D6AA0-0x00000001805D6B30
		public static string GetLanguageWithoutRegion(string Language); // 0x00000001805D8EB0-0x00000001805D8F40
		public void AddLanguage(string LanguageName); // 0x00000001805D5A30-0x00000001805D5AB0
		public void AddLanguage(string LanguageName, string LanguageCode); // 0x00000001805D5AB0-0x00000001805D5CC0
		public void RemoveLanguage(string LanguageName); // 0x00000001805DC1E0-0x00000001805DC510
		public List<string> GetLanguages(bool skipDisabled = true /* Metadata: 0x002200A6 */); // 0x00000001805D90B0-0x00000001805D91B0
		public List<string> GetLanguagesCode(bool allowRegions = true /* Metadata: 0x002200A7 */, bool skipDisabled = true /* Metadata: 0x002200A8 */); // 0x00000001805D8F40-0x00000001805D90B0
		public bool IsLanguageEnabled(string Language); // 0x00000001805DBBA0-0x00000001805DBCD0
		public void EnableLanguage(string Language, bool bEnabled); // 0x00000001805D6E40-0x00000001805D6F60
		public bool AllowUnloadingLanguages(); // 0x00000001805D5FB0-0x00000001805D5FC0
		private string GetSavedLanguageFileName(int languageIndex); // 0x00000001805D91B0-0x00000001805D9420
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad); // 0x00000001805DBF00-0x00000001805DC070
		public void LoadAllLanguages(bool forceLoad = false /* Metadata: 0x002200A9 */); // 0x00000001805DBD70-0x00000001805DBF00
		public void UnloadLanguage(int languageIndex); // 0x00000001805DCD30-0x00000001805DCF80
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal /* Metadata: 0x002200AA */); // 0x00000001805DC610-0x00000001805DC750
		public bool HasUnloadedLanguages(); // 0x00000001805D9D30-0x00000001805D9DE0
		public List<string> GetCategories(bool OnlyMainCategory = false /* Metadata: 0x002200AE */, List<string> Categories = null); // 0x00000001805D84E0-0x00000001805D86C0
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false /* Metadata: 0x002200AF */); // 0x00000001805D89A0-0x00000001805D8A90
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false /* Metadata: 0x002200B0 */); // 0x00000001805D86C0-0x00000001805D87E0
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false /* Metadata: 0x002200B1 */); // 0x00000001805D6CF0-0x00000001805D6E40
		public void UpdateDictionary(bool force = false /* Metadata: 0x002200B2 */); // 0x00000001805DD2B0-0x00000001805DD590
		public string GetTranslation(string term, string overrideLanguage = null, string overrideSpecialization = null, bool skipDisabled = false /* Metadata: 0x002200B3 */, bool allowCategoryMistmatch = false /* Metadata: 0x002200B4 */); // 0x00000001805D9B90-0x00000001805D9C40
		public bool TryGetTranslation(string term, out string Translation, string overrideLanguage = null, string overrideSpecialization = null, bool skipDisabled = false /* Metadata: 0x002200B5 */, bool allowCategoryMistmatch = false /* Metadata: 0x002200B6 */); // 0x00000001805DCA20-0x00000001805DCD30
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, string overrideSpecialization = null, bool skipDisabled = false /* Metadata: 0x002200B7 */); // 0x00000001805DC750-0x00000001805DCA20
		public TermData AddTerm(string term); // 0x00000001805D5CC0-0x00000001805D5E30
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false /* Metadata: 0x002200B8 */); // 0x00000001805D9620-0x00000001805D9900
		public bool ContainsTerm(string term); // 0x00000001805D6CD0-0x00000001805D6CF0
		public List<string> GetTermsList(string Category = null); // 0x00000001805D99C0-0x00000001805D9B90
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true /* Metadata: 0x002200B9 */); // 0x00000001805D5E30-0x00000001805D5FB0
		public void RemoveTerm(string term); // 0x00000001805DC510-0x00000001805DC610
		public static void ValidateFullTerm(ref string Term); // 0x00000001805DD590-0x00000001805DD7D0
	}
}

namespace Placemaker
{
	public static class LayerMaster // TypeDefIndex: 4601
	{
		// Fields
		public static int voxelLayer; // 0x00
		public static int groundLayer; // 0x04
		public static int gridLayer; // 0x08
		public static int aoLayer; // 0x0C
		public static int clickMask; // 0x10
		public static int propMask; // 0x14
		public static int gridMask; // 0x18
	
		// Constructors
		static LayerMaster(); // 0x00000001802A0EE0-0x00000001802A1190
	}
}

namespace Os.Utils
{
	public static class ListPool<T> // TypeDefIndex: 4926
	{
		// Fields
		private static List<List<T>> pool;
	
		// Constructors
		static ListPool();
	
		// Methods
		public static List<T> Get();
		public static List<T> Get(int capacity);
		public static void Return(ref List<T> list);
	}

	public static class ListPoolExtension // TypeDefIndex: 4927
	{
		// Extension methods
		public static void ReturnToPool<T>(this List<T> list);
		public static List<T> GetListOfComponentsInChildren<T>(this GameObject gameObject)
			where T : Component;
	}
}

namespace Placemaker.Ui
{
	public class LoadingUi : MonoBehaviour, UiMaster.IUiSetup, IOnScenePostProcess // TypeDefIndex: 4684
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState openState; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform logoContainer; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private AudioSource audioSource; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Color> targetColors; // 0x38
		private int counter; // 0x40
		private float timer; // 0x44
		private bool first; // 0x48
		private const float d = 0.55f; // Metadata: 0x0021FF63
		private const float l = 0.15f; // Metadata: 0x0021FF67
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private State state; // 0x4C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int pitcher; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float minWidth; // 0x54
	
		// Properties
		public bool isLoading { get; } // 0x0000000180B2F300-0x0000000180B2F310 
	
		// Nested types
		private enum State // TypeDefIndex: 4685
		{
			Loading = 0,
			LoadingDone = 1,
			Done = 2,
			Gone = 3,
			ReallyGone = 4
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 4686
		{
			// Fields
			public UiMaster master; // 0x10
			public LoadingUi <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass16_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B44A20-0x0000000180B44AD0
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__1(float x); // 0x0000000180B44AD0-0x0000000180B44B50
		}
	
		// Constructors
		public LoadingUi(); // 0x0000000180B2F270-0x0000000180B2F300
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B2E900-0x0000000180B2EA70
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D8E80-0x00000001801D8E90
		private void Update(); // 0x0000000180B2EC10-0x0000000180B2F270
		public void StartLoading(); // 0x0000000180B2EA70-0x0000000180B2EBD0
		public void StopLoading(); // 0x0000000180B2EC00-0x0000000180B2EC10
		public void StopLoadingNow(); // 0x0000000180B2EBD0-0x0000000180B2EC00
		void IOnScenePostProcess.OnScenePostProcess(bool isBuild); // 0x0000000180B2E740-0x0000000180B2E900
		private void OnRectTransformDimensionsChange(); // 0x0000000180B2E510-0x0000000180B2E740
	}
}

internal sealed class Locale // TypeDefIndex: 2
{
	// Methods
	public static string GetText(string msg); // 0x000000018023A380-0x000000018023A390
	public static string GetText(string fmt, params /* 0x0000000180110980-0x0000000180110990 */ object[] args); // 0x00000001806C22F0-0x00000001806C2300
}

internal sealed class Locale // TypeDefIndex: 1618
{
	// Methods
	public static string GetText(string msg); // 0x000000018023A380-0x000000018023A390
}

namespace I2.Loc
{
	public static class LocalizationManager // TypeDefIndex: 4840
	{
		// Fields
		private static string mCurrentLanguage; // 0x00
		private static string mLanguageCode; // 0x08
		private static CultureInfo mCurrentCulture; // 0x10
		private static bool mChangeCultureInfo; // 0x18
		public static bool IsRight2Left; // 0x19
		public static bool HasJoinedWords; // 0x1A
		public static List<ILocalizationParamsManager> ParamManagers; // 0x20
		private static string[] LanguagesRTL; // 0x28
		public static List<LanguageSourceData> Sources; // 0x30
		public static string[] GlobalSources; // 0x38
		private static string mCurrentDeviceLanguage; // 0x40
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets; // 0x48
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private static OnLocalizeCallback OnLocalizeEvent; // 0x50
		private static bool mLocalizeIsScheduled; // 0x58
		private static bool mLocalizeIsScheduledWithForcedValue; // 0x59
		public static bool HighlightLocalizedTargets; // 0x5A
	
		// Properties
		public static string CurrentLanguage { get; set; } // 0x00000001803A78E0-0x00000001803A7940 0x00000001803A7DB0-0x00000001803A7EB0
		public static string CurrentLanguageCode { get; set; } // 0x00000001803A7880-0x00000001803A78E0 0x00000001803A7CC0-0x00000001803A7DB0
		public static string CurrentRegion { get; set; } // 0x00000001803A7A40-0x00000001803A7BC0 0x00000001803A80C0-0x00000001803A8280
		public static string CurrentRegionCode { get; set; } // 0x00000001803A7940-0x00000001803A7A40 0x00000001803A7EB0-0x00000001803A80C0
		public static CultureInfo CurrentCulture { get; } // 0x00000001803A7820-0x00000001803A7880 
	
		// Events
		public static event OnLocalizeCallback OnLocalizeEvent {
			add; // 0x00000001803A7720-0x00000001803A7820
			remove; // 0x00000001803A7BC0-0x00000001803A7CC0
		}
	
		// Nested types
		public delegate object _GetParam(string param); // TypeDefIndex: 4841; 0x00000001803B4F50-0x00000001803B53C0
	
		public delegate void OnLocalizeCallback(); // TypeDefIndex: 4842; 0x00000001803AFAF0-0x00000001803AFCF0
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 4843
		{
			// Fields
			public List<string> Languages; // 0x10
			public Func<string, bool> <>9__0; // 0x18
	
			// Constructors
			public <>c__DisplayClass33_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <GetAllLanguages>b__0(string x); // 0x00000001803B4600-0x00000001803B4660
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass34_0 // TypeDefIndex: 4844
		{
			// Fields
			public List<string> Languages; // 0x10
			public Func<string, bool> <>9__0; // 0x18
	
			// Constructors
			public <>c__DisplayClass34_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <GetAllLanguagesCode>b__0(string x); // 0x00000001803B4660-0x00000001803B46C0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4845
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static _GetParam <>9__41_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001803B4840-0x00000001803B48A0
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal object <ApplyLocalizationParams>b__41_0(string p); // 0x00000001803B4320-0x00000001803B4380
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass42_0 // TypeDefIndex: 4846
		{
			// Fields
			public GameObject root; // 0x10
	
			// Constructors
			public <>c__DisplayClass42_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal object <ApplyLocalizationParams>b__0(string p); // 0x00000001803B46C0-0x00000001803B4730
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass43_0 // TypeDefIndex: 4847
		{
			// Fields
			public Dictionary<string, object> parameters; // 0x10
	
			// Constructors
			public <>c__DisplayClass43_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal object <ApplyLocalizationParams>b__0(string p); // 0x00000001803B4730-0x00000001803B47B0
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <Delayed_Import_Google>d__59 : IEnumerator<object> // TypeDefIndex: 4848
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float delay; // 0x20
			public LanguageSourceData source; // 0x28
			public bool justCheck; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <Delayed_Import_Google>d__59(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x00000001803B39D0-0x00000001803B3A80
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001803B3A80-0x00000001803B3AD0
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass69_0 // TypeDefIndex: 4849
		{
			// Fields
			public ILocalizeTargetDescriptor desc; // 0x10
	
			// Constructors
			public <>c__DisplayClass69_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <RegisterTarget>b__0(ILocalizeTargetDescriptor x); // 0x00000001803B47B0-0x00000001803B47E0
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <Coroutine_LocalizeAll>d__84 : IEnumerator<object> // TypeDefIndex: 4850
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <Coroutine_LocalizeAll>d__84(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x00000001803B38A0-0x00000001803B3980
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001803B3980-0x00000001803B39D0
		}
	
		// Constructors
		static LocalizationManager(); // 0x00000001803A6DD0-0x00000001803A7720
	
		// Methods
		public static void InitializeIfNeeded(); // 0x00000001803A5120-0x00000001803A5370
		public static string GetVersion(); // 0x00000001803A4D00-0x00000001803A4D30
		public static int GetRequiredWebServiceVersion(); // 0x000000018023E800-0x000000018023E810
		public static string GetWebServiceURL(LanguageSourceData source = null); // 0x00000001803A4D30-0x00000001803A4F10
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true /* Metadata: 0x00220125 */, bool Force = false /* Metadata: 0x00220126 */); // 0x00000001803A6630-0x00000001803A68F0
		private static CultureInfo CreateCultureForCode(string code); // 0x00000001803A2800-0x00000001803A28A0
		public static void EnableChangingCultureInfo(bool bEnable); // 0x00000001803A2C20-0x00000001803A2CF0
		private static void SetCurrentCultureInfo(); // 0x00000001803A65B0-0x00000001803A6630
		private static void SelectStartupLanguage(); // 0x00000001803A6070-0x00000001803A65B0
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true /* Metadata: 0x00220127 */, bool Initialize = true /* Metadata: 0x00220128 */, bool SkipDisabled = true /* Metadata: 0x00220129 */); // 0x00000001803A4F10-0x00000001803A5120
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false /* Metadata: 0x0022012A */); // 0x00000001803A42B0-0x00000001803A46C0
		public static string GetLanguageCode(string Language); // 0x00000001803A3890-0x00000001803A3AA0
		public static string GetLanguageFromCode(string Code, bool exactMatch = true /* Metadata: 0x0022012B */); // 0x00000001803A3AA0-0x00000001803A3CB0
		public static List<string> GetAllLanguages(bool SkipDisabled = true /* Metadata: 0x0022012C */); // 0x00000001803A30B0-0x00000001803A32E0
		public static List<string> GetAllLanguagesCode(bool allowRegions = true /* Metadata: 0x0022012D */, bool SkipDisabled = true /* Metadata: 0x0022012E */); // 0x00000001803A2EE0-0x00000001803A30B0
		public static bool IsLanguageEnabled(string Language); // 0x00000001803A53F0-0x00000001803A54F0
		private static void LoadCurrentLanguage(); // 0x00000001803A5570-0x00000001803A56C0
		public static void PreviewLanguage(string NewLanguage); // 0x00000001803A5950-0x00000001803A5A50
		public static void AutoLoadGlobalParamManagers(); // 0x00000001803A2630-0x00000001803A27B0
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true /* Metadata: 0x0022012F */); // 0x00000001803A2110-0x00000001803A2220
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true /* Metadata: 0x00220130 */); // 0x00000001803A1B40-0x00000001803A1C10
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true /* Metadata: 0x00220131 */); // 0x00000001803A2040-0x00000001803A2110
		public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true /* Metadata: 0x00220132 */); // 0x00000001803A1C10-0x00000001803A2040
		internal static string GetLocalizationParam(string ParamName, GameObject root); // 0x00000001803A3CB0-0x00000001803A3EB0
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam); // 0x00000001803A3EB0-0x00000001803A40B0
		public static string ApplyRTLfix(string line); // 0x00000001803A2220-0x00000001803A2280
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers); // 0x00000001803A2280-0x00000001803A2630
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0 /* Metadata: 0x00220133 */, bool ignoreNumber = false /* Metadata: 0x00220137 */); // 0x00000001803A2E30-0x00000001803A2EE0
		public static bool IsRTL(string Code); // 0x00000001803A54F0-0x00000001803A5570
		public static bool UpdateSources(); // 0x00000001803A6C30-0x00000001803A6DD0
		private static void UnregisterDeletededSources(); // 0x00000001803A6B00-0x00000001803A6C30
		private static void RegisterSceneSources(); // 0x00000001803A5A50-0x00000001803A5BF0
		private static void RegisterSourceInResources(); // 0x00000001803A5BF0-0x00000001803A5DB0
		internal static void AddSource(LanguageSourceData Source); // 0x00000001803A1820-0x00000001803A1A60
		[IteratorStateMachine] // 0x0000000180140D50-0x0000000180140DA0
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck); // 0x00000001803A28A0-0x00000001803A2920
		internal static void RemoveSource(LanguageSourceData Source); // 0x00000001803A5FF0-0x00000001803A6070
		public static bool IsGlobalSource(string SourceName); // 0x00000001803A5370-0x00000001803A53F0
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true /* Metadata: 0x00220138 */); // 0x00000001803A40B0-0x00000001803A42B0
		public static UnityEngine.Object FindAsset(string value); // 0x00000001803A2CF0-0x00000001803A2E30
		public static void ApplyDownloadedDataFromGoogle(); // 0x00000001803A1A60-0x00000001803A1B40
		public static string GetCurrentDeviceLanguage(bool force = false /* Metadata: 0x00220139 */); // 0x00000001803A3640-0x00000001803A3890
		private static void DetectDeviceLanguage(); // 0x00000001803A2920-0x00000001803A2AB0
		public static void RegisterTarget(ILocalizeTargetDescriptor desc); // 0x00000001803A5DB0-0x00000001803A5FF0
		public static string GetTranslation(string Term, bool FixForRTL = true /* Metadata: 0x0022013A */, int maxLineLengthForRTL = 0 /* Metadata: 0x0022013B */, bool ignoreRTLnumbers = true /* Metadata: 0x0022013F */, bool applyParameters = false /* Metadata: 0x00220140 */, GameObject localParametersRoot = null, string overrideLanguage = null); // 0x00000001803A4C30-0x00000001803A4D00
		public static string GetTermTranslation(string Term, bool FixForRTL = true /* Metadata: 0x00220141 */, int maxLineLengthForRTL = 0 /* Metadata: 0x00220142 */, bool ignoreRTLnumbers = true /* Metadata: 0x00220146 */, bool applyParameters = false /* Metadata: 0x00220147 */, GameObject localParametersRoot = null, string overrideLanguage = null); // 0x00000001803A4940-0x00000001803A49E0
		public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true /* Metadata: 0x00220148 */, int maxLineLengthForRTL = 0 /* Metadata: 0x00220149 */, bool ignoreRTLnumbers = true /* Metadata: 0x0022014D */, bool applyParameters = false /* Metadata: 0x0022014E */, GameObject localParametersRoot = null, string overrideLanguage = null); // 0x00000001803A68F0-0x00000001803A6B00
		public static T GetTranslatedObject<T>(string AssetName, Localize optionalLocComp = null)
			where T : UnityEngine.Object;
		public static T GetTranslatedObjectByTermName<T>(string Term, Localize optionalLocComp = null)
			where T : UnityEngine.Object;
		public static string GetAppName(string languageCode); // 0x00000001803A32E0-0x00000001803A3540
		public static void LocalizeAll(bool Force = false /* Metadata: 0x0022014F */); // 0x00000001803A56C0-0x00000001803A5950
		[IteratorStateMachine] // 0x0000000180140EA0-0x0000000180140EF0
		private static IEnumerator Coroutine_LocalizeAll(); // 0x00000001803A27B0-0x00000001803A2800
		private static void DoLocalizeAll(bool Force = false /* Metadata: 0x00220150 */); // 0x00000001803A2AB0-0x00000001803A2C20
		public static List<string> GetCategories(); // 0x00000001803A3540-0x00000001803A3640
		public static List<string> GetTermsList(string Category = null); // 0x00000001803A49E0-0x00000001803A4C30
		public static TermData GetTermData(string term); // 0x00000001803A46C0-0x00000001803A47C0
		public static TermData GetTermData(string term, out LanguageSourceData source); // 0x00000001803A47C0-0x00000001803A4940
	}

	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager // TypeDefIndex: 4881
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public List<ParamValue> _Params; // 0x18
		public bool _IsGlobalManager; // 0x20
	
		// Nested types
		[Serializable]
		public struct ParamValue // TypeDefIndex: 4882
		{
			// Fields
			public string Name; // 0x00
			public string Value; // 0x08
		}
	
		// Constructors
		public LocalizationParamsManager(); // 0x00000001803A8830-0x00000001803A8890
	
		// Methods
		public string GetParameterValue(string ParamName); // 0x00000001803A8350-0x00000001803A8450
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true /* Metadata: 0x002201F5 */); // 0x00000001803A8640-0x00000001803A8830
		public void OnLocalize(); // 0x00000001803A85B0-0x00000001803A8640
		public virtual void OnEnable(); // 0x00000001803A84D0-0x00000001803A85B0
		public void DoAutoRegister(); // 0x00000001803A8280-0x00000001803A8350
		public void OnDisable(); // 0x00000001803A8450-0x00000001803A84D0
	}

	public class LocalizationReader // TypeDefIndex: 4835
	{
		// Constructors
		public LocalizationReader(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset); // 0x00000001803A91F0-0x00000001803A9480
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType); // 0x00000001803A9480-0x00000001803A9780
		public static string ReadCSVfile(string Path, Encoding encoding); // 0x00000001803A8EA0-0x00000001803A9010
		public static List<string[]> ReadCSV(string Text, char Separator = ',' /* Metadata: 0x0022010E */); // 0x00000001803A8DE0-0x00000001803A8EA0
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator); // 0x00000001803A8AD0-0x00000001803A8DE0
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart); // 0x00000001803A8890-0x00000001803A89A0
		public static List<string[]> ReadI2CSV(string Text); // 0x00000001803A9010-0x00000001803A91F0
		public static void ValidateFullTerm(ref string Term); // 0x00000001803A9780-0x00000001803A9820
		public static string EncodeString(string str); // 0x00000001803A8A20-0x00000001803A8AD0
		public static string DecodeString(string str); // 0x00000001803A89A0-0x00000001803A8A20
	}

	[AddComponentMenu] // 0x0000000180140BD0-0x0000000180140C00
	public class Localize : MonoBehaviour // TypeDefIndex: 4836
	{
		// Fields
		public string mTerm; // 0x18
		public string mTermSecondary; // 0x20
		[NonSerialized]
		public string FinalTerm; // 0x28
		[NonSerialized]
		public string FinalSecondaryTerm; // 0x30
		public TermModification PrimaryTermModifier; // 0x38
		public TermModification SecondaryTermModifier; // 0x3C
		public string TermPrefix; // 0x40
		public string TermSuffix; // 0x48
		public bool LocalizeOnAwake; // 0x50
		private string LastLocalizedLanguage; // 0x58
		public bool IgnoreRTL; // 0x60
		public int MaxCharactersInRTL; // 0x64
		public bool IgnoreNumbersInRTL; // 0x68
		public bool CorrectAlignmentForRTL; // 0x69
		public bool AddSpacesToJoinedLanguages; // 0x6A
		public bool AllowLocalizedParameters; // 0x6B
		public List<UnityEngine.Object> TranslatedObjects; // 0x70
		[NonSerialized]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary; // 0x78
		public UnityEvent LocalizeEvent; // 0x80
		public static string MainTranslation; // 0x00
		public static string SecondaryTranslation; // 0x08
		public static string CallBackTerm; // 0x10
		public static string CallBackSecondaryTerm; // 0x18
		public static Localize CurrentLocalizeComponent; // 0x20
		public bool AlwaysForceLocalize; // 0x88
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public EventCallback LocalizeCallBack; // 0x90
		public bool mGUI_ShowReferences; // 0x98
		public bool mGUI_ShowTems; // 0x99
		public bool mGUI_ShowCallback; // 0x9A
		public ILocalizeTarget mLocalizeTarget; // 0xA0
		public string mLocalizeTargetName; // 0xA8
	
		// Properties
		public string Term { get; set; } // 0x00000001801D0240-0x00000001801D0250 0x00000001803AF3D0-0x00000001803AF410
		public string SecondaryTerm { get; set; } // 0x00000001801D0220-0x00000001801D0230 0x00000001803AF8D0-0x00000001803AFAC0
	
		// Nested types
		public enum TermModification // TypeDefIndex: 4837
		{
			DontModify = 0,
			ToUpper = 1,
			ToLower = 2,
			ToUpperFirst = 3,
			ToTitle = 4
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4838
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Predicate<UnityEngine.Object> <>9__49_0; // 0x08
			public static Func<UnityEngine.Object, string> <>9__49_1; // 0x10
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__49_2; // 0x18
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__49_3; // 0x20
	
			// Constructors
			static <>c(); // 0x00000001803B47E0-0x00000001803B4840
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <UpdateAssetDictionary>b__49_0(UnityEngine.Object x); // 0x00000001803B44C0-0x00000001803B4520
			internal string <UpdateAssetDictionary>b__49_1(UnityEngine.Object o); // 0x00000001803B4410-0x00000001803B4430
			internal string <UpdateAssetDictionary>b__49_2(IGrouping<string, UnityEngine.Object> g); // 0x00000001803B4520-0x00000001803B4570
			internal UnityEngine.Object <UpdateAssetDictionary>b__49_3(IGrouping<string, UnityEngine.Object> g); // 0x00000001803B4570-0x00000001803B45B0
		}
	
		// Constructors
		public Localize(); // 0x00000001803AF740-0x00000001803AF8D0
	
		// Methods
		private void Awake(); // 0x00000001803ADD90-0x00000001803ADDD0
		private void OnEnable(); // 0x00000001803AE750-0x00000001803AE760
		public bool HasCallback(); // 0x00000001803AE640-0x00000001803AE690
		public void OnLocalize(bool Force = false /* Metadata: 0x00220110 */); // 0x00000001803AE760-0x00000001803AF2B0
		public bool FindTarget(); // 0x00000001803ADEB0-0x00000001803AE400
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm); // 0x00000001803AE400-0x00000001803AE560
		public string GetMainTargetsText(); // 0x00000001803AE560-0x00000001803AE640
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII); // 0x00000001803AF2B0-0x00000001803AF310
		public void SetTerm(string primary); // 0x00000001803AF3D0-0x00000001803AF410
		public void SetTerm(string primary, string secondary); // 0x00000001803AF370-0x00000001803AF3D0
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation)
			where T : UnityEngine.Object;
		public void UpdateAssetDictionary(); // 0x00000001803AF410-0x00000001803AF740
		internal T GetObject<T>(string Translation)
			where T : UnityEngine.Object;
		private T GetTranslatedObject<T>(string Translation)
			where T : UnityEngine.Object;
		private void DeserializeTranslation(string translation, out string value, out string secondary); // 0x00000001803ADDD0-0x00000001803ADEB0
		public T FindTranslatedObject<T>(string value)
			where T : UnityEngine.Object;
		public bool HasTranslatedObject(UnityEngine.Object Obj); // 0x00000001803AE690-0x00000001803AE750
		public void AddTranslatedObject(UnityEngine.Object Obj); // 0x00000001803ADD10-0x00000001803ADD90
		public void SetGlobalLanguage(string Language); // 0x00000001803AF310-0x00000001803AF370
	}

	[AddComponentMenu] // 0x0000000180140C40-0x0000000180140C70
	public class LocalizeDropdown : MonoBehaviour // TypeDefIndex: 4839
	{
		// Fields
		public List<string> _Terms; // 0x18
	
		// Constructors
		public LocalizeDropdown(); // 0x00000001803AA410-0x00000001803AA470
	
		// Methods
		public void Start(); // 0x00000001803A9E00-0x00000001803A9F70
		public void OnDestroy(); // 0x00000001803A9B50-0x00000001803A9CB0
		private void OnEnable(); // 0x00000001803A9CB0-0x00000001803A9D10
		public void OnLocalize(); // 0x00000001803A9D10-0x00000001803A9E00
		private void FillValues(); // 0x00000001803A99B0-0x00000001803A9B50
		public void UpdateLocalization(); // 0x00000001803AA1C0-0x00000001803AA410
		public void UpdateLocalizationTMPro(); // 0x00000001803A9F70-0x00000001803AA1C0
		private void FillValuesTMPro(); // 0x00000001803A9820-0x00000001803A99B0
	}

	[Serializable]
	public struct LocalizedString // TypeDefIndex: 4883
	{
		// Fields
		public string mTerm; // 0x00
		public bool mRTL_IgnoreArabicFix; // 0x08
		public int mRTL_MaxLineLength; // 0x0C
		public bool mRTL_ConvertNumbers; // 0x10
		public bool m_DontLocalizeParameters; // 0x11
	
		// Constructors
		public LocalizedString(LocalizedString str); // 0x000000018001DF30-0x000000018001E300
	
		// Methods
		public static implicit operator string(LocalizedString s); // 0x00000001803AFAC0-0x00000001803AFAD0
		public static implicit operator LocalizedString(string term); // 0x00000001803AFAD0-0x00000001803AFAF0
		public override string ToString(); // 0x000000018001DF20-0x000000018001DF30
	}
}

namespace Placemaker.Ui
{
	public class LocalizeRTLFlipper : MonoBehaviour // TypeDefIndex: 4687
	{
		// Constructors
		public LocalizeRTLFlipper(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void Awake(); // 0x00000001801D8E80-0x00000001801D8E90
		public void OnEnable(); // 0x0000000180B2F390-0x0000000180B2F4C0
		public void OnDisable(); // 0x0000000180B2F310-0x0000000180B2F390
		public void OnLocalize(); // 0x00000001801D8E80-0x00000001801D8E90
	}
}

namespace I2.Loc
{
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro> // TypeDefIndex: 4856
	{
		// Fields
		private TextAlignmentOptions mAlignment_RTL; // 0x20
		private TextAlignmentOptions mAlignment_LTR; // 0x24
		private bool mAlignmentWasRTL; // 0x28
		private bool mInitializeAlignment; // 0x29
	
		// Constructors
		static LocalizeTarget_TextMeshPro_Label(); // 0x00000001803AA530-0x00000001803AA5C0
		public LocalizeTarget_TextMeshPro_Label(); // 0x00000001803AB1C0-0x00000001803AB210
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803AA530-0x00000001803AA5C0
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x00000001801F15A0-0x00000001801F15B0
		public override bool CanUseSecondaryTerm(); // 0x000000018023BF40-0x000000018023BF50
		public override bool AllowMainTermToBeRTL(); // 0x000000018023BF40-0x000000018023BF50
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803AAB50-0x00000001803AAC70
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803AA5C0-0x00000001803AAB50
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName); // 0x00000001803AAC70-0x00000001803AADC0
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL); // 0x00000001803AADC0-0x00000001803AAFA0
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont); // 0x00000001803AAFA0-0x00000001803AB0A0
		internal static void SetMaterial(TMP_Text label, Material newMat); // 0x00000001803AB0A0-0x00000001803AB1C0
	}

	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI> // TypeDefIndex: 4857
	{
		// Fields
		public TextAlignmentOptions mAlignment_RTL; // 0x20
		public TextAlignmentOptions mAlignment_LTR; // 0x24
		public bool mAlignmentWasRTL; // 0x28
		public bool mInitializeAlignment; // 0x29
	
		// Constructors
		static LocalizeTarget_TextMeshPro_UGUI(); // 0x00000001803AB210-0x00000001803AB2A0
		public LocalizeTarget_TextMeshPro_UGUI(); // 0x00000001803AB960-0x00000001803AB9B0
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803AB210-0x00000001803AB2A0
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x00000001803AB950-0x00000001803AB960
		public override bool CanUseSecondaryTerm(); // 0x000000018023BF40-0x000000018023BF50
		public override bool AllowMainTermToBeRTL(); // 0x000000018023BF40-0x000000018023BF50
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803AB830-0x00000001803AB950
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803AB2A0-0x00000001803AB830
	}

	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource> // TypeDefIndex: 4858
	{
		// Constructors
		static LocalizeTarget_UnityStandard_AudioSource(); // 0x00000001803AB9B0-0x00000001803ABA40
		public LocalizeTarget_UnityStandard_AudioSource(); // 0x00000001803ABC80-0x00000001803ABCC0
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803AB9B0-0x00000001803ABA40
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x0000000180261930-0x0000000180261940
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override bool CanUseSecondaryTerm(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowMainTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803ABBB0-0x00000001803ABC80
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803ABA40-0x00000001803ABBB0
	}

	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject> // TypeDefIndex: 4860
	{
		// Constructors
		static LocalizeTarget_UnityStandard_Child(); // 0x00000001803ABCC0-0x00000001803ABD70
		public LocalizeTarget_UnityStandard_Child(); // 0x00000001803ABF20-0x00000001803ABF60
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803ABCC0-0x00000001803ABD70
		public override bool IsValid(Localize cmp); // 0x00000001803AA470-0x00000001803AA4B0
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x00000001803ABF10-0x00000001803ABF20
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override bool CanUseSecondaryTerm(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowMainTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803ABED0-0x00000001803ABF10
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803ABD70-0x00000001803ABED0
	}

	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer> // TypeDefIndex: 4861
	{
		// Constructors
		static LocalizeTarget_UnityStandard_MeshRenderer(); // 0x00000001803ABF60-0x00000001803ABFF0
		public LocalizeTarget_UnityStandard_MeshRenderer(); // 0x00000001803AC3C0-0x00000001803AC400
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803ABF60-0x00000001803ABFF0
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x00000001803AC3B0-0x00000001803AC3C0
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x000000018023EAB0-0x000000018023EAC0
		public override bool CanUseSecondaryTerm(); // 0x000000018023BF40-0x000000018023BF50
		public override bool AllowMainTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803AC1B0-0x00000001803AC3B0
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803ABFF0-0x00000001803AC1B0
	}

	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject> // TypeDefIndex: 4863
	{
		// Constructors
		static LocalizeTarget_UnityStandard_Prefab(); // 0x00000001803AC400-0x00000001803AC4B0
		public LocalizeTarget_UnityStandard_Prefab(); // 0x00000001803AC8C0-0x00000001803AC900
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803AC400-0x00000001803AC4B0
		public override bool IsValid(Localize cmp); // 0x000000018023BF40-0x000000018023BF50
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x00000001803ABF10-0x00000001803ABF20
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override bool CanUseSecondaryTerm(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowMainTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803ABED0-0x00000001803ABF10
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803AC4B0-0x00000001803AC6F0
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation); // 0x00000001803AC6F0-0x00000001803AC8C0
	}

	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer> // TypeDefIndex: 4864
	{
		// Constructors
		static LocalizeTarget_UnityStandard_SpriteRenderer(); // 0x00000001803AC900-0x00000001803AC990
		public LocalizeTarget_UnityStandard_SpriteRenderer(); // 0x00000001803ACB50-0x00000001803ACB90
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803AC900-0x00000001803AC990
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x000000018023E800-0x000000018023E810
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override bool CanUseSecondaryTerm(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowMainTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803ACA80-0x00000001803ACB50
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803AC990-0x00000001803ACA80
	}

	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh> // TypeDefIndex: 4865
	{
		// Fields
		private TextAlignment mAlignment_RTL; // 0x20
		private TextAlignment mAlignment_LTR; // 0x24
		private bool mAlignmentWasRTL; // 0x28
		private bool mInitializeAlignment; // 0x29
	
		// Constructors
		static LocalizeTarget_UnityStandard_TextMesh(); // 0x00000001803ACB90-0x00000001803ACC20
		public LocalizeTarget_UnityStandard_TextMesh(); // 0x00000001803ACFD0-0x00000001803AD020
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803ACB90-0x00000001803ACC20
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x00000001801F15A0-0x00000001801F15B0
		public override bool CanUseSecondaryTerm(); // 0x000000018023BF40-0x000000018023BF50
		public override bool AllowMainTermToBeRTL(); // 0x000000018023BF40-0x000000018023BF50
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803ACEB0-0x00000001803ACFD0
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803ACC20-0x00000001803ACEB0
	}

	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image> // TypeDefIndex: 4866
	{
		// Constructors
		static LocalizeTarget_UnityUI_Image(); // 0x00000001803AD020-0x00000001803AD0B0
		public LocalizeTarget_UnityUI_Image(); // 0x00000001803AD3B0-0x00000001803AD3F0
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803AD020-0x00000001803AD0B0
		public override bool CanUseSecondaryTerm(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowMainTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x00000001803AD330-0x00000001803AD3B0
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803AD1A0-0x00000001803AD330
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803AD0B0-0x00000001803AD1A0
	}

	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage> // TypeDefIndex: 4867
	{
		// Constructors
		static LocalizeTarget_UnityUI_RawImage(); // 0x00000001803AD3F0-0x00000001803AD480
		public LocalizeTarget_UnityUI_RawImage(); // 0x00000001803AD650-0x00000001803AD690
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803AD3F0-0x00000001803AD480
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x00000001803AD640-0x00000001803AD650
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override bool CanUseSecondaryTerm(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowMainTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803AD570-0x00000001803AD640
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803AD480-0x00000001803AD570
	}

	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<UnityEngine.UI.Text> // TypeDefIndex: 4868
	{
		// Fields
		private TextAnchor mAlignment_RTL; // 0x20
		private TextAnchor mAlignment_LTR; // 0x24
		private bool mAlignmentWasRTL; // 0x28
		private bool mInitializeAlignment; // 0x29
	
		// Constructors
		static LocalizeTarget_UnityUI_Text(); // 0x00000001803AD690-0x00000001803AD720
		public LocalizeTarget_UnityUI_Text(); // 0x00000001803ADCC0-0x00000001803ADD10
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x000000018011F500-0x000000018011F520
		private static void AutoRegister(); // 0x00000001803AD690-0x00000001803AD720
		public override eTermType GetPrimaryTermType(Localize cmp); // 0x0000000180207150-0x0000000180207160
		public override eTermType GetSecondaryTermType(Localize cmp); // 0x00000001801F15A0-0x00000001801F15B0
		public override bool CanUseSecondaryTerm(); // 0x000000018023BF40-0x000000018023BF50
		public override bool AllowMainTermToBeRTL(); // 0x000000018023BF40-0x000000018023BF50
		public override bool AllowSecondTermToBeRTL(); // 0x00000001802453D0-0x00000001802453E0
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm); // 0x00000001803ADAB0-0x00000001803ADBE0
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation); // 0x00000001803AD720-0x00000001803ADAB0
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL); // 0x00000001803ADBE0-0x00000001803ADCC0
	}

	public abstract class LocalizeTarget<T> : ILocalizeTarget // TypeDefIndex: 4852
		where T : UnityEngine.Object
	{
		// Fields
		public T mTarget;
	
		// Constructors
		protected LocalizeTarget();
	
		// Methods
		public override bool IsValid(Localize cmp);
	}

	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<I2.Loc.LocalizeTarget_UnityStandard_Child> // TypeDefIndex: 4859
	{
		// Constructors
		public LocalizeTargetDesc_Child(); // 0x00000001803AA4B0-0x00000001803AA4F0
	
		// Methods
		public override bool CanLocalize(Localize cmp); // 0x00000001803AA470-0x00000001803AA4B0
	}

	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<I2.Loc.LocalizeTarget_UnityStandard_Prefab> // TypeDefIndex: 4862
	{
		// Constructors
		public LocalizeTargetDesc_Prefab(); // 0x00000001803AA4F0-0x00000001803AA530
	
		// Methods
		public override bool CanLocalize(Localize cmp); // 0x000000018023BF40-0x000000018023BF50
	}

	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> // TypeDefIndex: 4855
		where T : UnityEngine.Object
		where G : LocalizeTarget<T>
	{
		// Constructors
		public LocalizeTargetDesc_Type();
	
		// Methods
		public override bool CanLocalize(Localize cmp);
		public override ILocalizeTarget CreateTarget(Localize cmp);
	}

	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor // TypeDefIndex: 4854
		where T : ILocalizeTarget
	{
		// Constructors
		protected LocalizeTargetDesc();
	
		// Methods
		public override ILocalizeTarget CreateTarget(Localize cmp);
		public override Type GetTargetType();
	}
}

namespace Placemaker
{
	public class Maker : MonoBehaviour // TypeDefIndex: 4607
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public List<Placemaker.Graphs.Action> actions; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Voxel> voxels; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int actionIndex; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int actionCount; // 0x34
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int actionRedoMax; // 0x38
		private const int maxActionCount = 999; // Metadata: 0x0021FEA5
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int actionId; // 0x3C
		public Action<int, int> onQueueChange; // 0x40
	
		// Properties
		private GridGenerator grid { get; } // 0x00000001802A24F0-0x00000001802A2510 
		private GroundClicker groundClicker { get; } // 0x00000001802A2510-0x00000001802A2530 
		private Graph graph { get; } // 0x00000001802A24D0-0x00000001802A24F0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4608
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action<int, int> <>9__34_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001802B3A60-0x00000001802B3D30
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <.ctor>b__34_0(int <p0>, int <p1>); // 0x00000001801D8E80-0x00000001801D8E90
		}
	
		// Constructors
		public Maker(); // 0x00000001802A23A0-0x00000001802A24D0
	
		// Methods
		public void ActionQueueChanged(); // 0x00000001802A1190-0x00000001802A11E0
		public void OnEnable(); // 0x00000001801D8E80-0x00000001801D8E90
		public void PaintClick(HoverData hover, VoxelType voxelType); // 0x00000001802A1B00-0x00000001802A1C70
		public Voxel AddClick(HoverData hover, VoxelType voxelType); // 0x00000001802A12A0-0x00000001802A1580
		public Voxel RemoveClick(HoverData hover); // 0x00000001802A1EC0-0x00000001802A1FF0
		public void ClearUndoQueue(); // 0x00000001802A1810-0x00000001802A18A0
		public void TrimActionList(); // 0x00000001802A1FF0-0x00000001802A2160
		public Placemaker.Graphs.Action AddAction(int2 hexPos, byte height, VoxelType inType, VoxelType outType); // 0x00000001802A11E0-0x00000001802A12A0
		public void BeginNewAction(); // 0x00000001802A1580-0x00000001802A1770
		public void EndAction(); // 0x00000001802A1AE0-0x00000001802A1B00
		public bool CanUndo(); // 0x00000001802A17F0-0x00000001802A1800
		public bool CanRedo(); // 0x00000001802A17A0-0x00000001802A17F0
		public bool CanClear(); // 0x00000001802A1770-0x00000001802A17A0
		public void RedoCommand(); // 0x00000001802A1C70-0x00000001802A1C80
		public void UndoCommand(); // 0x00000001802A2160-0x00000001802A2170
		public void ClearCommand(); // 0x00000001802A1800-0x00000001802A1810
		[ContextMenu] // 0x000000018012C700-0x000000018012C730
		public bool Undo(); // 0x00000001802A2170-0x00000001802A23A0
		[ContextMenu] // 0x000000018012C780-0x000000018012C7B0
		public bool Redo(); // 0x00000001802A1C80-0x00000001802A1EC0
		public bool Clear(); // 0x00000001802A18A0-0x00000001802A1AE0
	}
}

namespace Placemaker.Modules.Processing
{
	[Serializable]
	public struct MappedMaterial // TypeDefIndex: 4764
	{
		// Fields
		public string srcName; // 0x00
		public Material targetMaterial; // 0x08
		public bool replaceableColor; // 0x10
		public bool softNormalsInTangent; // 0x11
		public bool edgeProfile; // 0x12
		public bool onlyMergeAdjecent; // 0x13
		public bool attachment; // 0x14
		public bool attachee; // 0x15
		public bool outputMesh; // 0x16
		public bool blocker; // 0x17
		public bool combineBlocker; // 0x18
		public bool outlineUvs; // 0x19
		public float normalSideMultiplier; // 0x1C
		public MaterialType materialType; // 0x20
	}

	[CreateAssetMenu] // 0x0000000180110980-0x0000000180110990
	public class MappedMaterialSettings : ScriptableObject // TypeDefIndex: 4759
	{
		// Fields
		public List<MappedMaterial> mappedMaterials; // 0x18
	
		// Constructors
		public MappedMaterialSettings(); // 0x00000001801D5C70-0x00000001801D5C80
	}
}

namespace TMPro
{
	public enum MaskingOffsetMode // TypeDefIndex: 4254
	{
		Percentage = 0,
		Pixel = 1
	}

	public enum MaskingTypes // TypeDefIndex: 4252
	{
		MaskOff = 0,
		MaskHard = 1,
		MaskSoft = 2
	}
}

namespace Placemaker.Modules.Processing
{
	[Serializable]
	public class MaterialCluster // TypeDefIndex: 4767
	{
		// Fields
		public List<int> meshes; // 0x10
		public List<int> corners; // 0x18
	
		// Constructors
		public MaterialCluster(); // 0x00000001802A2530-0x00000001802A25B0
	}
}

namespace Placemaker
{
	public class MaterialMaster : MonoBehaviour, WorldMaster.IOnOnEnable // TypeDefIndex: 4609
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material windowMaterial; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material groundMaterial; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material houseMaterial; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material waterMaterial; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material hole0; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material propMaterial; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material doorMaterial; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material mirrorHouseMaterial; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material fenceMaterial; // 0x60
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material gridMaterial; // 0x68
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Material borderMaterial; // 0x70
		public Color backgroundColor; // 0x78
		public Color grassColor; // 0x88
		public Color roofColor; // 0x98
		public Color plateColor; // 0xA8
		public Color stoneColor; // 0xB8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Texture2D materialTexture; // 0xC8
	
		// Nested types
		[Serializable]
		public class VoxelMaterial // TypeDefIndex: 4610
		{
			// Fields
			[SerializeField] // 0x0000000180110980-0x0000000180110990
			public Color32 color; // 0x10
	
			// Constructors
			public VoxelMaterial(); // 0x00000001801D0660-0x00000001801D0670
		}
	
		// Constructors
		public MaterialMaster(); // 0x00000001802A2CE0-0x00000001802A2D70
	
		// Methods
		public void MaybeCreateTexture(); // 0x00000001802A27F0-0x00000001802A28F0
		void Placemaker.WorldMaster.IOnOnEnable.OnOnEnable(WorldMaster worldMaster); // 0x00000001802A2960-0x00000001802A2970
		public void OnStart(); // 0x00000001802A28F0-0x00000001802A2960
		public Color GetVoxelColor(VoxelType voxelType); // 0x00000001802A27A0-0x00000001802A27F0
		private void SetupTexture(); // 0x00000001802A2970-0x00000001802A2CE0
		public void ChangeVoxelColor(int index, Color color); // 0x00000001802A25B0-0x00000001802A27A0
	}
}

namespace TMPro
{
	public struct MaterialReference // TypeDefIndex: 4147
	{
		// Fields
		public int index; // 0x00
		public TMP_FontAsset fontAsset; // 0x08
		public TMP_SpriteAsset spriteAsset; // 0x10
		public Material material; // 0x18
		public bool isDefaultMaterial; // 0x20
		public bool isFallbackMaterial; // 0x21
		public Material fallbackMaterial; // 0x28
		public float padding; // 0x30
		public int referenceCount; // 0x34
	
		// Constructors
		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding); // 0x0000000180002B10-0x0000000180002BC0
	
		// Methods
		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset); // 0x00000001801D23A0-0x00000001801D2900
		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x00000001801D1FE0-0x00000001801D21C0
		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup); // 0x00000001801D21C0-0x00000001801D23A0
	}

	public class MaterialReferenceManager // TypeDefIndex: 4146
	{
		// Fields
		private static MaterialReferenceManager s_Instance; // 0x00
		private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28
	
		// Properties
		public static MaterialReferenceManager instance { get; } // 0x00000001801D1EB0-0x00000001801D1FE0 
	
		// Constructors
		public MaterialReferenceManager(); // 0x00000001801D1DE0-0x00000001801D1EB0
	
		// Methods
		public static void AddFontAsset(TMP_FontAsset fontAsset); // 0x00000001801D1530-0x00000001801D15D0
		private void AddFontAssetInternal(TMP_FontAsset fontAsset); // 0x00000001801D1490-0x00000001801D1530
		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset); // 0x00000001801D1800-0x00000001801D18A0
		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset); // 0x00000001801D1760-0x00000001801D1800
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset); // 0x00000001801D18A0-0x00000001801D1960
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset); // 0x00000001801D16B0-0x00000001801D1760
		public static void AddFontMaterial(int hashCode, Material material); // 0x00000001801D1640-0x00000001801D16B0
		private void AddFontMaterialInternal(int hashCode, Material material); // 0x00000001801D15D0-0x00000001801D1640
		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset); // 0x00000001801D1400-0x00000001801D1490
		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset); // 0x00000001801D1380-0x00000001801D1400
		public bool Contains(TMP_FontAsset font); // 0x00000001801D1960-0x00000001801D19C0
		public bool Contains(TMP_SpriteAsset sprite); // 0x00000001801D19C0-0x00000001801D1A20
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset); // 0x00000001801D1B80-0x00000001801D1C00
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset); // 0x00000001801D1B10-0x00000001801D1B80
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x00000001801D1D60-0x00000001801D1DE0
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset); // 0x00000001801D1CF0-0x00000001801D1D60
		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset); // 0x00000001801D1A90-0x00000001801D1B10
		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset); // 0x00000001801D1A20-0x00000001801D1A90
		public static bool TryGetMaterial(int hashCode, out Material material); // 0x00000001801D1C70-0x00000001801D1CF0
		private bool TryGetMaterialInternal(int hashCode, out Material material); // 0x00000001801D1C00-0x00000001801D1C70
	}
}

namespace Placemaker
{
	public enum MaterialType : byte // TypeDefIndex: 4650
	{
		None = 0,
		Ground = 1,
		Dirt = 2,
		Water = 3
	}
}

namespace TMPro
{
	[Serializable]
	public struct Mesh_Extents // TypeDefIndex: 4284
	{
		// Fields
		public Vector2 min; // 0x00
		public Vector2 max; // 0x08
	
		// Constructors
		public Mesh_Extents(Vector2 min, Vector2 max); // 0x0000000180002640-0x0000000180002650
	
		// Methods
		public override string ToString(); // 0x0000000180002BC0-0x0000000180002D00
	}
}

namespace Placemaker
{
	[CreateAssetMenu] // 0x0000000180110980-0x0000000180110990
	public class MiscReferences : ScriptableObject // TypeDefIndex: 4614
	{
		// Fields
		public Mesh[] italianMeshes; // 0x18
	
		// Constructors
		public MiscReferences(); // 0x00000001801D5C70-0x00000001801D5C80
	}

	[Serializable]
	public class Module : BaseModule // TypeDefIndex: 4615
	{
		// Fields
		public List<OrientedModule> decorModules; // 0x30
		public int cornerLinks; // 0x38
	
		// Constructors
		public Module(); // 0x00000001802AA6A0-0x00000001802AACB0
	}

	public class ModuleBuilder : MonoBehaviour // TypeDefIndex: 4611
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Transform moduleContainerPool; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Transform moduleContainersToDeconstruct; // 0x28
		public List<Qube> qubesToGrass; // 0x30
	
		// Constructors
		public ModuleBuilder(); // 0x00000001802A69D0-0x00000001802A6A30
	
		// Methods
		public static Vector4 GetTs(Vector3 srcVert); // 0x00000001802A5E20-0x00000001802A5F20
		public static Vector3 MultiplyVector(Square square, Vector4 ts, Vector3 vector); // 0x00000001802A6680-0x00000001802A68F0
		public static Vector3 MultiplyPoint(Square square, Vector4 ts, Vector3 vector); // 0x00000001802A63F0-0x00000001802A6680
		private ModuleContainer GetModuleContainer(); // 0x00000001802A5DA0-0x00000001802A5E20
		public void ApplyModule(Qube qube, OrientedModuleSides possibleModule); // 0x00000001802A3F40-0x00000001802A5B60
		public void ApplyDecor(Qube qube); // 0x00000001802A2D70-0x00000001802A3F40
		public bool Iterate(); // 0x00000001802A5FF0-0x00000001802A6110
		public void MaybeAddToGrassQueue(Qube qube); // 0x00000001802A6380-0x00000001802A63F0
		public void OnStart(); // 0x00000001802A68F0-0x00000001802A69D0
		public void MarkQubeForDeconstruction(Qube qube); // 0x00000001802A6280-0x00000001802A6380
		public void MarkModuleContainerForDeconstruction(ModuleContainer container); // 0x00000001802A6110-0x00000001802A6280
		public void DeconstructModuleContainer(ModuleContainer container); // 0x00000001802A5B60-0x00000001802A5DA0
		public bool IterateDeconstructQubes(); // 0x00000001802A5F20-0x00000001802A5FF0
	}
}

namespace Placemaker.Graphs
{
	public class ModuleContainer : MonoBehaviour // TypeDefIndex: 4787
	{
		// Fields
		public OrientedModule orientedModule; // 0x18
		public bool hasProps; // 0x1C
	
		// Constructors
		public ModuleContainer(); // 0x00000001801D0210-0x00000001801D0220
	}
}

namespace Placemaker.Modules.Processing
{
	[SelectionBase] // 0x0000000180110980-0x0000000180110990
	public class ModuleImporter : MonoBehaviour // TypeDefIndex: 4760
	{
		// Fields
		public GameObject input; // 0x18
		public GameObject toDisable; // 0x20
		public ModuleLibrary moduleLibrary; // 0x28
		public MappedMaterialSettings mappedMaterialSettings; // 0x30
		public MeshFilter debugMeshFilter; // 0x38
		public Transform prefabContainer; // 0x40
		[Space] // 0x0000000180131590-0x00000001801315A0
		public int3 waterModule; // 0x48
		[Header] // 0x000000018013AFC0-0x000000018013AFF0
		public int srcModuleCount; // 0x54
		public uint sideHashCount; // 0x58
		public List<ProtoModuleMesh> protoModuleMeshes; // 0x60
		public List<ProtoModule> protoModules; // 0x68
		public ProtoModule selectedProtoModule; // 0x70
		public Placemaker.Module selectedModule; // 0x78
		public DecorModule selectedDecor; // 0x80
	
		// Constructors
		public ModuleImporter(); // 0x00000001802A6B20-0x00000001802A6B80
	
		// Methods
		private void Awake(); // 0x00000001802A6A30-0x00000001802A6B20
	}
}

namespace Placemaker.Modules
{
	[CreateAssetMenu] // 0x0000000180110980-0x0000000180110990
	public class ModuleLibrary : ScriptableObject // TypeDefIndex: 4755
	{
		// Fields
		public List<uint> waterSides; // 0x18
		public List<Placemaker.Module> modules; // 0x20
		public List<DecorModule> decorModules; // 0x28
		public List<CornerLookup> cornerLookups; // 0x30
		public List<SideProfile> sideLookups; // 0x38
		public List<ModuleMesh> moduleMeshes; // 0x40
		public List<int> decorOverlaps; // 0x48
		public ByteFloat2 groundUv0; // 0x50
		public ByteFloat2 groundUv1; // 0x52
		public Dictionary<ByteQube, int> cornerDict; // 0x58
	
		// Constructors
		public ModuleLibrary(); // 0x00000001802A6DB0-0x00000001802A6EC0
	
		// Methods
		private void OnEnable(); // 0x00000001802A6C90-0x00000001802A6DB0
		public void Setup(); // 0x00000001802A6C90-0x00000001802A6DB0
		public bool GetDecorOverlap(OrientedModule decor0, OrientedModule decor1); // 0x00000001802A6B80-0x00000001802A6C90
	}
}

namespace Placemaker
{
	public static class ModuleMath // TypeDefIndex: 4648
	{
		// Fields
		public const byte uprightOrientationCount = 8; // Metadata: 0x0021FEEE
		public const int voxelMaterialCount = 15; // Metadata: 0x0021FEEF
		public const float arbitraryGroundOffset = 0.2f; // Metadata: 0x0021FEF3
		public const float arbitraryWaterOffset = -0.1f; // Metadata: 0x0021FEF7
		public static readonly SbyteFloat3[] corners; // 0x00
		public static readonly ByteQube qubeForward; // 0x08
		public static readonly ByteQube qubeBackward; // 0x10
		public static readonly ByteQube qubeUpsideDown; // 0x18
		public static readonly List<Orientation> orientations; // 0x20
		public static readonly byte[,] orientationMulLookup; // 0x28
		public static readonly byte[] orientationInverseLookup; // 0x30
		public static readonly int4x4[] sideMatrices; // 0x38
		public static readonly int4x4[] invSideMatrices; // 0x40
		public static readonly int[,] cornerLinkLookup; // 0x48
		public static readonly float2[] baryVectors; // 0x50
		public static readonly ByteQube groundByteQube; // 0x58
		public static readonly ByteQube anyByteQube; // 0x60
		public const byte emptyByte = 18; // Metadata: 0x0021FEFB
		public const byte waterByte = 17; // Metadata: 0x0021FEFC
		public const byte groundByte = 15; // Metadata: 0x0021FEFD
		public const byte anyByte = 16; // Metadata: 0x0021FEFE
	
		// Constructors
		static ModuleMath(); // 0x00000001802A7C90-0x00000001802AA570
	
		// Methods
		public static int GetCornerLinkIndex(int cornerA, int cornerB); // 0x00000001802A7030-0x00000001802A70F0
		public static bool AreCornersLinked(int cornerA, int cornerB, int link); // 0x00000001802A6EC0-0x00000001802A6FA0
		public static Orientation Mul(Orientation parent, Orientation child); // 0x00000001802A75F0-0x00000001802A7790
		public static byte MulOrientations(byte orientationIndex0, byte orientationIndex1); // 0x00000001802A7530-0x00000001802A75F0
		public static byte MulOrientations(int orientationIndex0, int orientationIndex1); // 0x00000001802A7470-0x00000001802A7530
		public static byte InvertOrientation(int orientationIndex0); // 0x00000001802A72B0-0x00000001802A7340
		public static ByteQube MarkHiddenCornersAmbigous(ByteQube byteQube); // 0x00000001802A7340-0x00000001802A7470
		public static ByteQube GetIndexedMaterials(ByteQube materials); // 0x00000001802A7130-0x00000001802A7230
		public static int GetMaterialCount(ByteQube materials); // 0x00000001802A7230-0x00000001802A72B0
		public static int3 MultiplyPoint(int4x4 m, int3 p); // 0x00000001802A7A20-0x00000001802A7B00
		public static SbyteFloat3 MultiplyPoint(int4x4 m, SbyteFloat3 p); // 0x00000001802A7970-0x00000001802A7A20
		public static int3 MultiplyVector(int4x4 m, int3 p); // 0x00000001802A7BB0-0x00000001802A7C90
		public static SbyteFloat3 MultiplyVector(int4x4 m, SbyteFloat3 p); // 0x00000001802A7B00-0x00000001802A7BB0
		public static int3x2 MultiplyBounds(int4x4 m, int3x2 bounds); // 0x00000001802A7790-0x00000001802A7970
	
		// Extension methods
		public static int GetBidirectionalHash(this OrientedModule orientedModule0, OrientedModule orientedModule1); // 0x00000001802A6FA0-0x00000001802A7030
		public static int GetDoubleHash(this OrientedModule orientedModule0, OrientedModule orientedModule1); // 0x00000001802A70F0-0x00000001802A7130
	}

	[Serializable]
	public class ModuleMesh // TypeDefIndex: 4616
	{
		// Fields
		public Material material; // 0x10
		public List<SbyteFloat3> verts; // 0x18
		public List<SbyteFloat3> normals; // 0x20
		public List<SbyteFloat3> tangents; // 0x28
		public List<ByteFloat> concavity; // 0x30
		public List<ByteFloat2> uvs; // 0x38
		public List<OutlineUv> outlineUvs; // 0x40
		public List<byte> tris; // 0x48
		public MaterialType materialType; // 0x50
		public byte corner; // 0x51
	
		// Constructors
		public ModuleMesh(); // 0x00000001802AA570-0x00000001802AA6A0
	}
}

namespace Placemaker.Quads.GridGeneration
{
	[Serializable]
	public struct MotivationCounter : IEnumerable<int2> // TypeDefIndex: 4734
	{
		// Fields
		public byte count; // 0x00
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <GetEnumerator>d__3 : IEnumerator<int2> // TypeDefIndex: 4735
		{
			// Fields
			private int <>1__state; // 0x10
			private int2 <>2__current; // 0x14
			public MotivationCounter <>4__this; // 0x1C
	
			// Properties
			int2 IEnumerator<Unity.Mathematics.int2>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x0000000180B44530-0x0000000180B44540 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x0000000180B44590-0x0000000180B445E0 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <GetEnumerator>d__3(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x0000000180B44520-0x0000000180B44530
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x0000000180B44540-0x0000000180B44590
		}
	
		// Methods
		public int AddMotivation(int2 source); // 0x0000000180198770-0x0000000180198780
		public int RemoveMotivation(int2 source); // 0x00000001801987E0-0x00000001801987F0
		[IteratorStateMachine] // 0x000000018013A830-0x000000018013A880
		public IEnumerator<int2> GetEnumerator(); // 0x0000000180198780-0x00000001801987E0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180198780-0x00000001801987E0
	}
}

namespace CielaSpike
{
	public static class Ninja // TypeDefIndex: 4935
	{
		// Fields
		public static readonly object JumpToUnity; // 0x00
		public static readonly object JumpBack; // 0x08
	
		// Constructors
		static Ninja(); // 0x00000001805DE410-0x00000001805DE4F0
	}
}

namespace Os.Utils
{
	public static class NumberStrings // TypeDefIndex: 4925
	{
		// Fields
		private static Dictionary<int, string> dict; // 0x00
	
		// Constructors
		static NumberStrings(); // 0x0000000180B74800-0x0000000180B74A00
	
		// Methods
		public static string Get(int number); // 0x0000000180B74710-0x0000000180B74800
	}
}

namespace Placemaker
{
	[Serializable]
	public struct Orientation // TypeDefIndex: 4652
	{
		// Fields
		public int4x4 int4x4; // 0x00
		public ByteQube cornerTransform0; // 0x40
		public ByteQube cornerTransform1; // 0x48
		public ByteQube sideTransform; // 0x50
		public bool inverted; // 0x58
	
		// Properties
		public Matrix4x4 matrix { get; } // 0x0000000180006C50-0x0000000180006D00 
	
		// Methods
		public byte GetSideTransform0(int index); // 0x00000001800067F0-0x00000001800068D0
		public byte GetSideTransform1(int index); // 0x00000001800068D0-0x00000001800069B0
		public SbyteFloat3 MultiplyPoint(SbyteFloat3 point); // 0x0000000180006BD0-0x0000000180006C10
		public SbyteFloat3 MultiplyVector(SbyteFloat3 vector); // 0x0000000180006C10-0x0000000180006C50
		public int3x2 MultiplyBounds(int3x2 bounds); // 0x00000001800069B0-0x0000000180006BD0
	}
}

namespace Placemaker.Modules
{
	[Serializable]
	public struct OrientedModule // TypeDefIndex: 4757
	{
		// Fields
		public ushort moduleIndex; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private byte flags; // 0x02
		public static readonly OrientedModule empty; // 0x00
	
		// Properties
		public int orientation { get; set; } // 0x0000000180006EE0-0x0000000180006EF0 0x0000000180006F30-0x0000000180006F40
		public bool isDecor { get; set; } // 0x0000000180006EC0-0x0000000180006ED0 0x0000000180006EF0-0x0000000180006F10
		public bool isEmpty { get; set; } // 0x0000000180006ED0-0x0000000180006EE0 0x0000000180006F10-0x0000000180006F30
	
		// Constructors
		static OrientedModule(); // 0x00000001802AACB0-0x00000001802AAD20
	
		// Methods
		public static bool operator ==(OrientedModule a, OrientedModule b); // 0x00000001802AAD20-0x00000001802AAD40
		public static bool operator !=(OrientedModule a, OrientedModule b); // 0x00000001802AAD40-0x00000001802AADD0
		public override bool Equals(object obj); // 0x0000000180006D00-0x0000000180006DF0
		public override int GetHashCode(); // 0x0000000180006DF0-0x0000000180006E10
		public override string ToString(); // 0x0000000180006E10-0x0000000180006EC0
	}
}

namespace Placemaker.Graphs
{
	[Serializable]
	public struct OrientedModuleSides : IComparable<OrientedModuleSides> // TypeDefIndex: 4791
	{
		// Fields
		public SideProfile sides; // 0x00
		public OrientedModule orientedModule; // 0x14
		public float cost; // 0x18
	
		// Methods
		int IComparable<OrientedModuleSides>.CompareTo(OrientedModuleSides other); // 0x00000001800070E0-0x0000000180007110
	}
}

namespace Placemaker.Modules
{
	[Serializable]
	public class OutlineUv // TypeDefIndex: 4758
	{
		// Fields
		public byte b; // 0x10
	
		// Properties
		public int x { get; set; } // 0x00000001802AAE50-0x00000001802AAE70 0x00000001802AAE90-0x00000001802AAF30
		public int y { get; set; } // 0x00000001802AAE70-0x00000001802AAE90 0x00000001802AAF30-0x00000001802AAFD0
		public Vector2 uv { get; } // 0x00000001802AADE0-0x00000001802AAE50 
		public bool border { get; } // 0x00000001802AADD0-0x00000001802AADE0 
	
		// Constructors
		public OutlineUv(); // 0x00000001801D0660-0x00000001801D0670
	}
}

namespace Placemaker
{
	[CreateAssetMenu] // 0x0000000180110980-0x0000000180110990
	public class Palette : ScriptableObject // TypeDefIndex: 4617
	{
		// Fields
		public Color32[] voxelColors; // 0x18
	
		// Constructors
		public Palette(); // 0x00000001802AAFD0-0x00000001802AB020
	}
}

namespace Placemaker.Ui
{
	public class PaletteMenu : UIBehaviour, UiMaster.IUiSetup, IDragHandler, IEndDragHandler, IBeginDragHandler // TypeDefIndex: 4688
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Palette palette; // 0x20
		public sbyte selectedPickerIndex; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public List<PalettePicker> palettePickers; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState openState; // 0x38
		private const float pickerSize = 40f; // Metadata: 0x0021FF83
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float targetScroll; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float currentScroll; // 0x44
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Rect rect; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool horizontal; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool updating; // 0x59
	
		// Nested types
		public interface IPaletteSetup // TypeDefIndex: 4689
		{
			// Methods
			void OnSetup();
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass17_0 // TypeDefIndex: 4690
		{
			// Fields
			public Transform slider; // 0x10
			public CanvasGroup canvasGroup; // 0x18
	
			// Constructors
			public <>c__DisplayClass17_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B44B50-0x0000000180B44C50
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__1(float x); // 0x0000000180B44C50-0x0000000180B44C80
		}
	
		// Constructors
		public PaletteMenu(); // 0x0000000180B308B0-0x0000000180B30940
	
		// Methods
		private void Update(); // 0x0000000180B30290-0x0000000180B308B0
		private void SetNewTargetScroll(float newTargetScroll); // 0x0000000180B30140-0x0000000180B30160
		public void PushColor(PalettePicker picker); // 0x0000000180B2FD00-0x0000000180B2FDC0
		public void ColorPick(Voxel voxel); // 0x0000000180B2F5F0-0x0000000180B2F670
		private void SelectPicker(PalettePicker picker); // 0x0000000180B2FE20-0x0000000180B30080
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x0000000180B2FAC0-0x0000000180B2FD00
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B2F880-0x0000000180B2FAC0
		public void SelectPicker(int index); // 0x0000000180B30080-0x0000000180B30140
		public void SelectNextPicker(int delta = 1 /* Metadata: 0x0021FF7F */); // 0x0000000180B2FDC0-0x0000000180B2FE20
		public void PickerClicked(PalettePicker picker); // 0x0000000180B2F870-0x0000000180B2F880
		protected override void OnRectTransformDimensionsChange(); // 0x0000000180B2F7E0-0x0000000180B2F870
		private void OnDrawGizmos(); // 0x0000000180B2F670-0x0000000180B2F7E0
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x0000000180B30160-0x0000000180B30280
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x0000000180B30280-0x0000000180B30290
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x00000001801D8E80-0x00000001801D8E90
		private void ClampTargetScroll(); // 0x0000000180B2F4C0-0x0000000180B2F5F0
	}

	public class PalettePicker : MonoBehaviour, PaletteMenu.IPaletteSetup // TypeDefIndex: 4691
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Graphic fg; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Graphic bg; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public UpdateState selectedState; // 0x28
	
		// Constructors
		public PalettePicker(); // 0x0000000180B30E20-0x0000000180B30E80
	
		// Methods
		void Placemaker.Ui.PaletteMenu.IPaletteSetup.OnSetup(); // 0x0000000180B309A0-0x0000000180B30AE0
		public void OnClicked(); // 0x0000000180B30940-0x0000000180B309A0
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private void <Placemaker.Ui.PaletteMenu.IPaletteSetup.OnSetup>b__3_0(float x); // 0x0000000180B30AE0-0x0000000180B30DC0
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private void <Placemaker.Ui.PaletteMenu.IPaletteSetup.OnSetup>b__3_1(); // 0x0000000180B30DC0-0x0000000180B30E20
	}
}

namespace I2.Loc
{
	public static class PersistentStorage // TypeDefIndex: 4797
	{
		// Fields
		private static I2CustomPersistentStorage mStorage; // 0x00
	
		// Nested types
		public enum eFileType // TypeDefIndex: 4798
		{
			Raw = 0,
			Persistent = 1,
			Temporal = 2,
			Streaming = 3
		}
	
		// Methods
		public static void SetSetting_String(string key, string value); // 0x00000001803B0390-0x00000001803B0440
		public static string GetSetting_String(string key, string defaultValue); // 0x00000001803AFFB0-0x00000001803B0060
		public static void DeleteSetting(string key); // 0x00000001803AFE60-0x00000001803AFF10
		public static bool HasSetting(string key); // 0x00000001803B0130-0x00000001803B01E0
		public static void ForceSaveSettings(); // 0x00000001803AFF10-0x00000001803AFFB0
		public static bool CanAccessFiles(); // 0x00000001803AFCF0-0x00000001803AFD90
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true /* Metadata: 0x0022003B */); // 0x00000001803B02B0-0x00000001803B0390
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true /* Metadata: 0x0022003C */); // 0x00000001803B01E0-0x00000001803B02B0
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true /* Metadata: 0x0022003D */); // 0x00000001803AFD90-0x00000001803AFE60
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true /* Metadata: 0x0022003E */); // 0x00000001803B0060-0x00000001803B0130
	}
}

namespace Placemaker.Ui
{
	public class PinnedUi : UIBehaviour, UiMaster.IUiSetup, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 4694
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState state; // 0x18
		public bool pinned; // 0x20
		public bool hovered; // 0x21
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 4695
		{
			// Fields
			public CanvasGroup canvasGroup; // 0x10
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B44E20-0x0000000180B44E40
		}
	
		// Constructors
		public PinnedUi(); // 0x0000000180B31310-0x0000000180B31380
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D8E80-0x00000001801D8E90
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B31150-0x0000000180B31270
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x0000000180B312B0-0x0000000180B312E0
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x0000000180B312E0-0x0000000180B31310
		public void Check(); // 0x0000000180B31110-0x0000000180B31150
		public void SetPinned(bool pinned); // 0x0000000180B31270-0x0000000180B312B0
	}

	public class PinUiButton : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4692
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup tick; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState state; // 0x28
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 4693
		{
			// Fields
			public PinUiButton <>4__this; // 0x10
			public PinnedUi palettePin; // 0x18
			public PinnedUi sidePin; // 0x20
			public UiMaster master; // 0x28
	
			// Constructors
			public <>c__DisplayClass4_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B44C80-0x0000000180B44E20
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__1(float x); // 0x0000000180B44E40-0x0000000180B44F30
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__2(float x); // 0x0000000180B44F30-0x0000000180B44FC0
		}
	
		// Constructors
		public PinUiButton(); // 0x0000000180B310A0-0x0000000180B31110
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B30EC0-0x0000000180B310A0
		public void Button_Toggle0(); // 0x0000000180B30E80-0x0000000180B30EC0
	}
}

namespace Placemaker
{
	public class PlatformDependent : MonoBehaviour, IOnScenePostProcess // TypeDefIndex: 4618
	{
		// Fields
		public List<RuntimePlatform> platforms; // 0x18
	
		// Constructors
		public PlatformDependent(); // 0x00000001802AB0D0-0x00000001802AB340
	
		// Methods
		void IOnScenePostProcess.OnScenePostProcess(bool isBuild); // 0x00000001802AB020-0x00000001802AB0D0
	}
}

namespace Os.Utils
{
	public struct PooledList<T> : IDisposable, IList<T> // TypeDefIndex: 4928
	{
		// Fields
		public List<T> list;
	
		// Properties
		public T this[int index] { get => default; set {} }
		public int Count { get; }
		public bool IsReadOnly { get; }
	
		// Constructors
		public PooledList(int capacity);
	
		// Methods
		public void Dispose();
		public void Add(T item);
		public void Clear();
		public bool Contains(T item);
		public void CopyTo(T[] array, int arrayIndex);
		public IEnumerator<T> GetEnumerator();
		public int IndexOf(T item);
		public void Insert(int index, T item);
		public bool Remove(T item);
		public void RemoveAt(int index);
		IEnumerator IEnumerable.GetEnumerator();
	}
}

namespace Placemaker.Ui
{
	public class ProgressBarButton : MonoBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4696
	{
		// Fields
		public float holdTime; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UnityEvent onFull; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RectTransform bar; // 0x28
		public UpdateState pressed; // 0x30
	
		// Constructors
		public ProgressBarButton(); // 0x0000000180B31640-0x0000000180B316C0
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x0000000180B31470-0x0000000180B31480
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B31380-0x0000000180B31470
		private void Update(); // 0x0000000180B314F0-0x0000000180B31640
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__5_0(BaseButton.State state); // 0x0000000180B31480-0x0000000180B314F0
	}
}

namespace Placemaker
{
	public class Prop : MonoBehaviour // TypeDefIndex: 4619
	{
		// Fields
		public Prop srcProp; // 0x18
		public byte voxelTypeMask; // 0x20
	
		// Constructors
		public Prop(); // 0x00000001802B34E0-0x00000001802B34F0
	}
}

namespace Placemaker.Props
{
	[RequireComponent] // 0x000000018013AA40-0x000000018013AA90
	public class PropCollider : MonoBehaviour // TypeDefIndex: 4738
	{
		// Fields
		public Layer layer; // 0x18
		public Bounds localBounds; // 0x1C
		public Bounds worldBounds; // 0x34
	
		// Nested types
		public enum Layer : byte // TypeDefIndex: 4739
		{
			Object = 0,
			Door = 1,
			Path = 2,
			Anchor = 3,
			InWall = 4,
			Step = 5,
			Unclear6 = 6,
			Self = 7
		}
	
		// Constructors
		public PropCollider(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public static bool Collides(Layer layer0, Layer layer1); // 0x0000000180B31900-0x0000000180B31990
		public Matrix4x4 GetMatrix(); // 0x0000000180B31990-0x0000000180B31D80
		[ContextMenu] // 0x000000018013AB90-0x000000018013ABC0
		public void CalculateWorldBounds(); // 0x0000000180B316C0-0x0000000180B31900
	}

	[RequireComponent] // 0x000000018013AC10-0x000000018013AC60
	public class PropColoredMesh : MonoBehaviour // TypeDefIndex: 4740
	{
		// Constructors
		public PropColoredMesh(); // 0x00000001801D0210-0x00000001801D0220
	}

	public class PropMeshAnimator : MonoBehaviour // TypeDefIndex: 4742
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
	
		// Constructors
		public PropMeshAnimator(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public void OnLateUpdate(); // 0x0000000180B31F40-0x0000000180B32250
		public void OnReset(); // 0x0000000180B32250-0x0000000180B32460
		public void OnTurnedOff(PropMeshReference propMeshReference); // 0x0000000180B32460-0x0000000180B32940
		public void OnTurnedOn(PropMeshReference propMeshReference); // 0x0000000180B32940-0x0000000180B33050
		public void OnDone(PropMeshReference propMeshReference); // 0x0000000180B31D80-0x0000000180B31F40
	}

	public class PropMeshOutline : MonoBehaviour // TypeDefIndex: 4743
	{
		// Constructors
		public PropMeshOutline(); // 0x00000001801D0210-0x00000001801D0220
	}

	[DisallowMultipleComponent] // 0x0000000180110980-0x0000000180110990
	public class PropMeshReference : MonoBehaviour, IPropEnabled // TypeDefIndex: 4744
	{
		// Fields
		public List<MeshFilter> myMfs; // 0x18
		public WorldMaster worldMaster; // 0x20
		public float time; // 0x28
	
		// Constructors
		public PropMeshReference(); // 0x0000000180B333D0-0x0000000180B33430
	
		// Methods
		void IPropEnabled.OnFirstTurnedOn(WorldMaster master); // 0x00000001801D0260-0x00000001801D0270
		void IPropEnabled.OnTurnedOn(WorldMaster master); // 0x0000000180B33080-0x0000000180B330B0
		void IPropEnabled.OnTurnedOff(WorldMaster master); // 0x0000000180B33050-0x0000000180B33080
		private void Update(); // 0x0000000180B330B0-0x0000000180B333D0
	}

	public class PropNgonScaler : MonoBehaviour, IPropModifier // TypeDefIndex: 4745
	{
		// Constructors
		public PropNgonScaler(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		void IPropModifier.Apply(WorldMaster master, ref Unity.Mathematics.Random random, Square square, Vector3 ts); // 0x0000000180B33430-0x0000000180B33850
		void IPropModifier.Reset(WorldMaster master, Transform srcT); // 0x0000000180B33850-0x0000000180B33950
	}

	public class PropNode : MonoBehaviour, IComparable<PropNode>, IComparer<PropNode> // TypeDefIndex: 4746
	{
		// Fields
		public float priority; // 0x18
		public bool turnedOn; // 0x1C
		public bool inDict; // 0x1D
		public bool hasBeenTurnedOn; // 0x1E
		public byte hideCount; // 0x1F
		public byte motivations; // 0x20
		public List<PropNode> relations; // 0x28
		public byte parentCount; // 0x30
		public byte childCount; // 0x31
		public byte overlapCount; // 0x32
		public byte moteveeCount; // 0x33
		public byte anchorCount; // 0x34
	
		// Properties
		public int parentIndex { get; } // 0x0000000180207150-0x0000000180207160 
		public int childIndex { get; } // 0x0000000180407B80-0x0000000180407B90 
		public int overlapIndex { get; } // 0x0000000180B33F00-0x0000000180B33F10 
		public int moteveeIndex { get; } // 0x0000000180B33EE0-0x0000000180B33F00 
		public int anchorIndex { get; } // 0x0000000180B33EC0-0x0000000180B33EE0 
	
		// Constructors
		public PropNode(); // 0x0000000180B33E50-0x0000000180B33EC0
	
		// Methods
		int IComparable<PropNode>.CompareTo(PropNode other); // 0x0000000180B33E20-0x0000000180B33E50
		public void AddParent(PropNode node); // 0x0000000180B33B20-0x0000000180B33B80
		public void AddChild(PropNode node); // 0x0000000180B339D0-0x0000000180B33A40
		public void AddOverlap(PropNode node); // 0x0000000180B33AB0-0x0000000180B33B20
		public void AddMotevee(PropNode node); // 0x0000000180B33A40-0x0000000180B33AB0
		public void AddAnchor(PropNode node); // 0x0000000180B33950-0x0000000180B339D0
		public void RemoveParent(PropNode node); // 0x0000000180B33D90-0x0000000180B33DF0
		public void RemoveChild(PropNode node); // 0x0000000180B33C70-0x0000000180B33CD0
		public void RemoveOverlap(PropNode node); // 0x0000000180B33D30-0x0000000180B33D90
		public void RemoveMotevee(PropNode node); // 0x0000000180B33CD0-0x0000000180B33D30
		public void RemoveAnchor(PropNode node); // 0x0000000180B33C10-0x0000000180B33C70
		int IComparer<PropNode>.Compare(PropNode x, PropNode y); // 0x0000000180B33DF0-0x0000000180B33E20
		public void InserOverlap(PropNode node); // 0x0000000180B33B80-0x0000000180B33C10
	}
}

namespace Placemaker
{
	[Serializable]
	public struct PropPlacement // TypeDefIndex: 4620
	{
		// Fields
		public SbyteFloat3 pos; // 0x00
		public ByteFloat3 scale; // 0x03
		public ByteFloat3 rotationByte; // 0x06
		private const float byteToAngle = 1.40625f; // Metadata: 0x0021FEA9
		private const float angleToByte = 0.7111111f; // Metadata: 0x0021FEAD
		public Prop prop; // 0x10
		public sbyte corner; // 0x18
		public byte prioAdd; // 0x19
	
		// Properties
		public Vector3 rotation { get; set; } // 0x0000000180006F60-0x0000000180006FC0 0x0000000180006FC0-0x00000001800070E0
	
		// Methods
		public Matrix4x4 GetMatrix(); // 0x0000000180006F40-0x0000000180006F60
	}

	public class PropPlacer : MonoBehaviour // TypeDefIndex: 4621
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Prop> srcProps; // 0x20
		private Dictionary<Prop, Transform> propPools; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform propPoolContainer; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform secondaryPropsContainer; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform deconstructionContainer; // 0x40
		public readonly Dictionary<int3, List<PropCollider>> colliderDict; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Mesh> materialMeshes; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<PropNode> propNodeQueue; // 0x58
		private Dictionary<Sprite, Mesh> spriteMeshes; // 0x60
		public const float chunkSize = 2f; // Metadata: 0x0021FEB1
		public const float chunkHalfSize = 1f; // Metadata: 0x0021FEB5
		public const float chunkInvSize = 0.5f; // Metadata: 0x0021FEB9
	
		// Constructors
		public PropPlacer(); // 0x00000001802B3410-0x00000001802B34E0
	
		// Methods
		private Matrix4x4 GetChunkMatrix(int3 coordinate); // 0x00000001802AD310-0x00000001802AD4A0
		private void OnEnable(); // 0x00000001802ADEA0-0x00000001802AE070
		private void AddColliderToDict(PropNode node0); // 0x00000001802AB340-0x00000001802AC200
		private void RemoveColliderFromDict(PropNode node0); // 0x00000001802B22C0-0x00000001802B2C70
		public PropRadiusIterator<T> GetPropIterator<T>(Vector3 pos, float radius)
			where T : Component;
		private void HideCountMinus(PropNode node); // 0x00000001802AD940-0x00000001802AD950
		private void HideCountPlus(PropNode node); // 0x00000001802AD950-0x00000001802AD960
		private void ChangeHideCount(PropNode node, bool add); // 0x00000001802AD240-0x00000001802AD2F0
		private bool RecursiveCheck(PropNode node0, PropNode inNode = null); // 0x00000001802B1830-0x00000001802B1FD0
		public Mesh GetMeshWithVoxelType(Mesh srcMesh, byte voxelType); // 0x00000001802AD4A0-0x00000001802AD750
		private Prop GetProp(Prop srcProp, Transform parent); // 0x00000001802AD750-0x00000001802AD940
		private void FirstTurnOn(PropNode node); // 0x00000001802AD2F0-0x00000001802AD310
		public void ReturnProp(Prop prop); // 0x00000001802B2D90-0x00000001802B3410
		private void RecursivePropNodeSetup(PropNode parentNode, Transform srcT, Transform dstT); // 0x00000001802B1FD0-0x00000001802B22C0
		public void RemovePropsFromContainer(ModuleContainer moduleContainer); // 0x00000001802B2C70-0x00000001802B2D90
		public bool IterateDeconstructProps(); // 0x00000001802AD960-0x00000001802ADA20
		public void PlacePropsInQube(Qube qube); // 0x00000001802AE0A0-0x00000001802B1830
		public void OnReset(); // 0x00000001802AE070-0x00000001802AE0A0
		public void OnDoneResetting(); // 0x00000001802ADA20-0x00000001802ADA50
		private void AddSmoothTangentsToMesh(Mesh mesh); // 0x00000001802AC200-0x00000001802AD240
		private void OnDrawGizmos(); // 0x00000001802ADA50-0x00000001802ADEA0
	}
}

namespace Placemaker.Props
{
	public struct PropRadiusIterator<T> : IEnumerator<T>, IEnumerable<T> // TypeDefIndex: 4741
		where T : Component
	{
		// Fields
		private PropPlacer propPlacer;
		private float sqRadius;
		private Vector3 pos;
		private int x;
		private int y;
		private int z;
		private int i;
		private List<PropCollider> propColliders;
		private int3 min;
		private int3 max;
		private T current;
	
		// Properties
		T IEnumerator<T>.Current { get; }
		object IEnumerator.Current { get; }
	
		// Constructors
		public PropRadiusIterator(Vector3 pos, float radius, PropPlacer propPlacer);
	
		// Methods
		private bool MoveNext();
		bool IEnumerator.MoveNext();
		void IDisposable.Dispose();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		void IEnumerator.Reset();
	}

	public class PropReference : MonoBehaviour // TypeDefIndex: 4747
	{
		// Fields
		public Prop prop; // 0x18
		public byte prioAdd; // 0x20
	
		// Constructors
		public PropReference(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		[ContextMenu] // 0x000000018013AD00-0x000000018013AD30
		private void NameAfterProps(); // 0x0000000180B33F10-0x0000000180B33FA0
		private void OnDrawGizmos(); // 0x0000000180B33FA0-0x0000000180B34650
		private void RecursiveDraw(Transform t); // 0x00000001801D8E80-0x00000001801D8E90
	}

	public class PropTransformer : MonoBehaviour, IPropModifier // TypeDefIndex: 4748
	{
		// Fields
		public bool fitInSquare; // 0x18
		public float scaleVariance; // 0x1C
		public float rotationVariance; // 0x20
		public float3 posVariance; // 0x24
	
		// Constructors
		public PropTransformer(); // 0x0000000180B34BE0-0x0000000180B34C10
	
		// Methods
		void IPropModifier.Apply(WorldMaster master, ref Unity.Mathematics.Random random, Square square, Vector3 ts); // 0x0000000180B34650-0x0000000180B34BE0
		void IPropModifier.Reset(WorldMaster master, Transform srcT); // 0x0000000180B33850-0x0000000180B33950
	}

	[RequireComponent] // 0x000000018013AD80-0x000000018013AE00
	[RequireComponent] // 0x000000018013AD80-0x000000018013AE00
	public class PropWire : MonoBehaviour // TypeDefIndex: 4749
	{
		// Fields
		public PropWireAnchor anchor0; // 0x18
		public PropWireAnchor anchor1; // 0x20
	
		// Constructors
		public PropWire(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public void Setup(); // 0x00000001801D8E80-0x00000001801D8E90
	}

	[RequireComponent] // 0x000000018013AE00-0x000000018013AE50
	public class PropWireAnchor : MonoBehaviour // TypeDefIndex: 4750
	{
		// Fields
		public PropWire srcWire; // 0x18
		public List<PropWire> propWires; // 0x20
		public byte voxelType; // 0x28
		public PropNode wireConnectorNode; // 0x30
		public Vector3 connectPos; // 0x38
	
		// Constructors
		public PropWireAnchor(); // 0x0000000180B34DD0-0x0000000180B34E30
	
		// Methods
		private void OnDrawGizmos(); // 0x0000000180B34C10-0x0000000180B34DD0
	}

	[RequireComponent] // 0x000000018013AE50-0x000000018013AEA0
	public class PropWireFlagMesh : MonoBehaviour, IPropModifier // TypeDefIndex: 4751
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Vector4 uv; // 0x18
	
		// Constructors
		public PropWireFlagMesh(); // 0x0000000180B358C0-0x0000000180B35930
	
		// Methods
		public void Setup(WorldMaster master, PropWire wire, float length); // 0x0000000180B34EC0-0x0000000180B358C0
		void IPropModifier.Apply(WorldMaster master, ref Unity.Mathematics.Random random, Square square, Vector3 ts); // 0x00000001801D8E80-0x00000001801D8E90
		void IPropModifier.Reset(WorldMaster master, Transform srcT); // 0x0000000180B34E30-0x0000000180B34EC0
	}

	[RequireComponent] // 0x000000018013AEA0-0x000000018013AEF0
	public class PropWireItalianMesh : MonoBehaviour, IPropModifier // TypeDefIndex: 4752
	{
		// Constructors
		public PropWireItalianMesh(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public void Setup(WorldMaster master, PropWire wire, float length); // 0x0000000180B35930-0x0000000180B35F70
		void IPropModifier.Apply(WorldMaster master, ref Unity.Mathematics.Random random, Square square, Vector3 ts); // 0x00000001801D8E80-0x00000001801D8E90
		void IPropModifier.Reset(WorldMaster master, Transform srcT); // 0x00000001801D8E80-0x00000001801D8E90
	}
}

namespace Placemaker.Modules.Processing
{
	[Serializable]
	public class ProtoModule // TypeDefIndex: 4761
	{
		// Fields
		public int3 coordinate; // 0x10
		public int cost; // 0x1C
		public bool isDecor; // 0x20
		public bool canBeJoined; // 0x21
		public ushort moduleIndex; // 0x22
		public int totalHash; // 0x24
		public int3x2 bounds; // 0x28
		public ByteQube cornerStates; // 0x40
		public List<int> anyCorners; // 0x48
		public List<SbyteFloat3> cornerTouches; // 0x50
		public int unknownCount; // 0x58
		public int insideCount; // 0x5C
		public int outsideCount; // 0x60
		public int cornerLinks; // 0x64
		public List<ProtoModuleMesh> moduleMeshes; // 0x68
		public List<MaterialCluster> materialClusters; // 0x70
		public List<OrientedModule> decorModules; // 0x78
		public List<DecorPoint> decorPoints; // 0x80
		public List<SideProfile> sideProfiles; // 0x88
		public List<PropPlacement> propPlacements; // 0x90
		public List<OrientedModule> orientedProtoMeshes; // 0x98
		public int permutationCount; // 0xA0
		public ByteQube defaultQube; // 0xA4
	
		// Properties
		public Vector3 worldPos { get; } // 0x00000001802B38C0-0x00000001802B3A00 
	
		// Constructors
		public ProtoModule(); // 0x00000001802B3740-0x00000001802B38C0
	}

	[Serializable]
	public class ProtoModuleMesh // TypeDefIndex: 4762
	{
		// Fields
		public ModuleMesh moduleMesh; // 0x10
		[NonSerialized]
		public MappedMaterial mappedMaterial; // 0x18
		public int3x2 bounds; // 0x40
		public List<int3> corners; // 0x58
		public List<CornerTouch> cornerTouches; // 0x60
		public List<SideProfile> sideProfiles; // 0x68
		public List<DecorPoint> decorPoints; // 0x70
		public int decorPointMaskTarget; // 0x78
		public ushort realMeshIndex; // 0x7C
	
		// Constructors
		public ProtoModuleMesh(); // 0x00000001802B34F0-0x00000001802B3740
	}
}

namespace Placemaker.Quads
{
	[Serializable]
	public struct Quad // TypeDefIndex: 4729
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public byte quadIndex; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int2 v0; // 0x04
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int2 v1; // 0x0C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int2 v2; // 0x14
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int2 v3; // 0x1C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public float2 p0; // 0x24
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public float2 p1; // 0x2C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public float2 p2; // 0x34
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public float2 p3; // 0x3C
	
		// Properties
		public int2 hexPosSum { get; } // 0x00000001801989E0-0x0000000180198A70 
		public float2 planePos { get; } // 0x0000000180198A70-0x0000000180198AC0 
	
		// Methods
		public int2 GetVert(int index); // 0x0000000180198910-0x00000001801989C0
		public float2 GetPlanePos(int index); // 0x0000000180198860-0x0000000180198910
		public bool ContainsVert(int2 v); // 0x00000001801987F0-0x0000000180198860
		public bool IsValid(); // 0x00000001801989C0-0x00000001801989E0
	}
}

namespace Placemaker.Graphs
{
	[SelectionBase] // 0x0000000180110980-0x0000000180110990
	public class Qube : MonoBehaviour // TypeDefIndex: 4788
	{
		// Fields
		public byte voxelCount; // 0x18
		public byte sideVariationMask; // 0x19
		public byte decorSideVariationMask; // 0x1A
		public int shadowIndex; // 0x1C
		public int possibleModuleListIndex; // 0x20
		public uint existanceIndex; // 0x24
		public ushort lastFillIndex; // 0x28
		public ushort lastPropagation; // 0x2A
		public ByteQube cornerValues; // 0x2C
		public bool awaitingRebuilding; // 0x34
		public bool awaitingGrass; // 0x35
		public bool awaitingGraphUpdate; // 0x36
		public bool awaitingModuleClearing; // 0x37
		public List<OrientedModuleSides> possibleModules; // 0x38
	
		// Properties
		public bool empty { get; } // 0x00000001802DB8A0-0x00000001802DB8B0 
		public bool fullyCovered { get; } // 0x00000001802DB8B0-0x00000001802DBB50 
	
		// Nested types
		[Serializable]
		public struct Relation // TypeDefIndex: 4789
		{
			// Fields
			public Qube qube; // 0x00
			public sbyte indexInOther; // 0x08
			public static readonly Relation empty; // 0x00
	
			// Constructors
			public Relation(Qube qube, sbyte indexInOther); // 0x0000000180007360-0x0000000180007450
			static Relation(); // 0x00000001802DBBA0-0x00000001802DBBF0
	
			// Methods
			public override int GetHashCode(); // 0x0000000180007220-0x00000001800072C0
		}
	
		[Serializable]
		public struct Relation6 // TypeDefIndex: 4790
		{
			// Fields
			public Relation r0; // 0x00
			public Relation r1; // 0x10
			public Relation r2; // 0x20
			public Relation r3; // 0x30
			public Relation r4; // 0x40
			public Relation r5; // 0x50
	
			// Properties
			public Relation this[int key] { get => default; set {} } // 0x0000000180007110-0x00000001800071E0 0x00000001800071E0-0x0000000180007220
		}
	
		// Constructors
		public Qube(); // 0x00000001802DB810-0x00000001802DB8A0
	
		// Methods
		private void OnDrawGizmosSelected(); // 0x00000001802D8940-0x00000001802DA050
		private void OnDrawGizmos(); // 0x00000001801D8E80-0x00000001801D8E90
		public ValueTuple<Vector3, float> SampleNormalCoverage(Vector3 ts); // 0x00000001802DA050-0x00000001802DB460
		private void Test(); // 0x00000001802DB460-0x00000001802DB810
	}
}

namespace I2.Loc
{
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager // TypeDefIndex: 4891
	{
		// Constructors
		public RegisterGlobalParameters(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public virtual void OnEnable(); // 0x00000001803B2C90-0x00000001803B2D60
		public virtual void OnDisable(); // 0x00000001803B2C10-0x00000001803B2C90
		public virtual string GetParameterValue(string ParamName); // 0x0000000180207150-0x0000000180207160
	}

	public class ResourceManager : MonoBehaviour // TypeDefIndex: 4893
	{
		// Fields
		private static ResourceManager mInstance; // 0x00
		public List<IResourceManager_Bundles> mBundleManagers; // 0x18
		public UnityEngine.Object[] Assets; // 0x20
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache; // 0x28
	
		// Properties
		public static ResourceManager pInstance { get; } // 0x00000001803B3140-0x00000001803B3480 
	
		// Constructors
		public ResourceManager(); // 0x00000001803B3030-0x00000001803B3140
	
		// Methods
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode); // 0x00000001803B2F80-0x00000001803B3030
		public T GetAsset<T>(string Name)
			where T : UnityEngine.Object;
		private UnityEngine.Object FindAsset(string Name); // 0x00000001803B2DC0-0x00000001803B2F20
		public bool HasAsset(UnityEngine.Object Obj); // 0x00000001803B2F20-0x00000001803B2F80
		public T LoadFromResources<T>(string Path)
			where T : UnityEngine.Object;
		public T LoadFromBundle<T>(string path)
			where T : UnityEngine.Object;
		public void CleanResourceCache(); // 0x00000001803B2D60-0x00000001803B2DC0
	}
}

namespace TMPro
{
	internal enum RichTextTag : uint // TypeDefIndex: 4226
	{
		PERCENTAGE = 37,
		PLUS = 43,
		MINUS = 45,
		BOLD = 66,
		ITALIC = 73,
		STRIKETHROUGH = 83,
		UNDERLINE = 85,
		PLUS_PERCENTAGE = 1454,
		MINUS_PERCENTAGE = 1512,
		SLASH_ITALIC = 1606,
		SLASH_BOLD = 1613,
		SLASH_UNDERLINE = 1626,
		SLASH_STRIKETHROUGH = 1628,
		EM = 2216,
		BR = 2256,
		PX = 2568,
		MINUS_EM = 46789,
		MINUS_PX = 47461,
		PLUS_EM = 49091,
		PLUS_PX = 49507,
		PCT = 85031,
		RED = 91635,
		MINUS_PCT = 1567082,
		PLUS_PCT = 1634348,
		ANIM = 2283339,
		BLUE = 2457214,
		FONT = 2586451,
		FRAC = 2598518,
		LIGA = 2655971,
		LINK = 2656128,
		NAME = 2875623,
		TRUE = 2932022,
		TINT = 2960519,
		SIZE = 3061285,
		SLASH_LINK = 57686191,
		SLASH_LIGA = 57686604,
		SLASH_FONT = 57747708,
		SLASH_FRAC = 57774681,
		SLASH_SIZE = 58429962,
		COLOR = 81999901,
		INDEX = 84268030,
		FALSE = 85422813,
		GREEN = 87065851,
		STYLE = 100252951,
		MATERIAL = 825491659,
		SLASH_COLOR = 1909026194,
		SLASH_STYLE = 1927738392,
		FONT_WEIGHT = 2405071134,
		ORANGE = 3186379376,
		SPRITE = 3303439849,
		YELLOW = 3412522628,
		SLASH_FONT_WEIGHT = 3536990865,
		DEFAULT = 3673993291
	}

	public struct RichTextTagAttribute // TypeDefIndex: 4287
	{
		// Fields
		public int nameHashCode; // 0x00
		public int valueHashCode; // 0x04
		public TagValueType valueType; // 0x08
		public int valueStartIndex; // 0x0C
		public int valueLength; // 0x10
		public TagUnitType unitType; // 0x14
	}
}

namespace I2.Loc
{
	public class RTLFixer // TypeDefIndex: 4884
	{
		// Constructors
		public RTLFixer(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public static string Fix(string str); // 0x00000001803B2710-0x00000001803B2720
		public static string Fix(string str, bool rtl); // 0x00000001803B2720-0x00000001803B2940
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers); // 0x00000001803B2940-0x00000001803B2C10
	}

	internal class RTLFixerTool // TypeDefIndex: 4890
	{
		// Fields
		internal static bool showTashkeel; // 0x00
		internal static bool useHinduNumbers; // 0x01
	
		// Constructors
		public RTLFixerTool(); // 0x00000001801D0660-0x00000001801D0670
		static RTLFixerTool(); // 0x00000001803B26C0-0x00000001803B2710
	
		// Methods
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation); // 0x00000001803B1F50-0x00000001803B2480
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation); // 0x00000001803B2480-0x00000001803B26C0
		internal static string FixLine(string str); // 0x00000001803B0440-0x00000001803B1590
		internal static bool IsIgnoredCharacter(char ch); // 0x00000001803B16F0-0x00000001803B1840
		internal static bool IsLeadingLetter(char[] letters, int index); // 0x00000001803B1840-0x00000001803B1BE0
		internal static bool IsFinishingLetter(char[] letters, int index); // 0x00000001803B1590-0x00000001803B16F0
		internal static bool IsMiddleLetter(char[] letters, int index); // 0x00000001803B1BE0-0x00000001803B1F50
	}
}

namespace Placemaker
{
	public class Sandbanker : MonoBehaviour // TypeDefIndex: 4622
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		public List<float> coverage; // 0x20
		public List<Vector3> verts; // 0x28
		public List<int> tris; // 0x30
		private State state; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private MeshFilter sandMf; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private MeshFilter waterMf; // 0x48
	
		// Nested types
		private enum State : byte // TypeDefIndex: 4623
		{
			Reset = 0,
			Gather = 1,
			Smooth = 2,
			ApplyWater = 3,
			ApplySand = 4,
			Done = 5
		}
	
		// Constructors
		public Sandbanker(); // 0x0000000180B3D010-0x0000000180B3D0C0
	
		// Methods
		public void Reset(); // 0x00000001808BDB90-0x00000001808BDBA0
		public void Clear(); // 0x0000000180B35F70-0x0000000180B35FD0
		private void OnEnable(); // 0x00000001808BDB90-0x00000001808BDBA0
		public void OnStart(); // 0x0000000180B3CF90-0x0000000180B3D010
		public bool Iterate(); // 0x0000000180B35FD0-0x0000000180B3CA80
		private void OnDrawGizmos(); // 0x0000000180B3CA80-0x0000000180B3CF90
	}

	public class SaveCamera : MonoBehaviour // TypeDefIndex: 4624
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Camera cam; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Texture bgTex; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RenderTexture renderTexture; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RenderTexture targetTexture; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Texture2D smallTex; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Texture2D bigTex; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RawImage targetImage; // 0x50
	
		// Constructors
		public SaveCamera(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		[ContextMenu] // 0x000000018012DD40-0x000000018012DD70
		public void Clear(); // 0x0000000180B3D0C0-0x0000000180B3D0D0
		public void Save(SaveData saveData); // 0x0000000180B3D0D0-0x0000000180B3DE20
	}
}

namespace Placemaker.Ui
{
	public class SaveCard : MonoBehaviour, IComparable<SaveCard>, UiMaster.IUiSetup // TypeDefIndex: 4697
	{
		// Fields
		public RawImage image; // 0x18
		public Texture2D smallTexture; // 0x20
		public Texture2D bigTexture; // 0x28
		public CanvasGroup canvasGroup; // 0x30
		public SaveData saveData; // 0x38
		public DateTime lastTime; // 0x40
		public string filePath; // 0x48
		public bool isSetup; // 0x50
		private UpdateState scaleZ; // 0x58
		private UpdateState scaleXY; // 0x60
		[NonSerialized]
		[HideInInspector] // 0x0000000180110980-0x0000000180110990
		private bool hasBeenEnabled; // 0x68
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 4698
		{
			// Fields
			public SaveCard <>4__this; // 0x10
			public UiMaster master; // 0x18
	
			// Constructors
			public <>c__DisplayClass14_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Setup>b__1(BaseButton.State state); // 0x0000000180B44760-0x0000000180B448C0
			internal void <Setup>b__2(); // 0x0000000180B448C0-0x0000000180B44900
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass14_1 // TypeDefIndex: 4699
		{
			// Fields
			public DistanceFieldSettings settings0; // 0x10
			public DistanceFieldSettings settings1; // 0x18
	
			// Constructors
			public <>c__DisplayClass14_1(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Setup>b__0(float x); // 0x0000000180B44900-0x0000000180B44A20
		}
	
		// Constructors
		public SaveCard(); // 0x0000000180B3E210-0x0000000180B3E2A0
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D8E80-0x00000001801D8E90
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B3DE30-0x0000000180B3DE40
		private void OnEnable(); // 0x0000000180B3DE20-0x0000000180B3DE30
		private void Setup(UiMaster master = null); // 0x0000000180B3DE40-0x0000000180B3E1A0
		int IComparable<SaveCard>.CompareTo(SaveCard other); // 0x0000000180B3E1A0-0x0000000180B3E210
	}
}

namespace Placemaker
{
	[Serializable]
	public class SaveData // TypeDefIndex: 4625
	{
		// Fields
		public string saveString; // 0x10
		public Cam cam; // 0x18
		public List<C> corners; // 0x20
		public List<V> voxels; // 0x28
		[HideInInspector] // 0x0000000180110980-0x0000000180110990
		public byte[] smallJpg; // 0x30
		[HideInInspector] // 0x0000000180110980-0x0000000180110990
		public byte[] bigJpg; // 0x38
	
		// Nested types
		[Serializable]
		public struct C // TypeDefIndex: 4626
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int count; // 0x08
	
			// Methods
			public override string ToString(); // 0x00000001801986D0-0x0000000180198770
		}
	
		[Serializable]
		public struct V // TypeDefIndex: 4627
		{
			// Fields
			public byte t; // 0x00
			public byte h; // 0x01
		}
	
		[Serializable]
		public struct Cam // TypeDefIndex: 4628
		{
			// Fields
			public byte x; // 0x00
			public byte y; // 0x01
			public byte z; // 0x02
		}
	
		// Constructors
		public SaveData(); // 0x0000000180B3E3B0-0x0000000180B3E450
	
		// Methods
		public void Clear(); // 0x0000000180B3E2A0-0x0000000180B3E300
		public void ReadNonImageDataFrom(SaveData other); // 0x0000000180B3E300-0x0000000180B3E3B0
	}

	[CreateAssetMenu] // 0x0000000180110980-0x0000000180110990
	public class SaveDataScripableObject : ScriptableObject // TypeDefIndex: 4629
	{
		// Fields
		public SaveData defaultSaveData; // 0x18
	
		// Constructors
		public SaveDataScripableObject(); // 0x00000001801D5C70-0x00000001801D5C80
	}
}

namespace Placemaker.Ui
{
	public class SaveMenu : MonoBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4700
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private SaveCard srcSaveCard; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform activeCards; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform cardPool; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform scaleAnim; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup canvasGroup; // 0x40
		[SerializeField] // 0x0000000180134260-0x0000000180134290
		[Space] // 0x0000000180134260-0x0000000180134290
		private RawImage focusedImage; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup focusCanvasGroup; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform focusScaleAnim; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_Text focusInputField; // 0x60
		[SerializeField] // 0x0000000180134260-0x0000000180134290
		[Space] // 0x0000000180134260-0x0000000180134290
		public SettingsData settingsData; // 0x68
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private SaveCard focusedCard; // 0x70
		private FileInfo[] fileInfos; // 0x78
		private int fileInfoFrame; // 0x80
		private int fileIndex; // 0x84
		public const string settingsFileName = "Sett.ings"; // Metadata: 0x0021FF87
		public const string saveFilePrefix = "Town"; // Metadata: 0x0021FF94
		public const string saveFileExtension = ".scape"; // Metadata: 0x0021FF9C
		public UpdateState openState; // 0x88
		public UpdateState focusCardState; // 0x90
		public UpdateState menuScaleState; // 0x98
		private bool done; // 0xA0
		private XmlSerializer saveXmlSerializer; // 0xA8
		private XmlSerializer settingsXmlSerializer; // 0xB0
		private static char[] charArray; // 0x00
		private static string saveChars; // 0x08
		private static int saveCharsLen; // 0x10
	
		// Nested types
		public enum State : byte // TypeDefIndex: 4701
		{
			Closed = 0,
			Open = 1,
			Focus = 2
		}
	
		public enum CancelMode : byte // TypeDefIndex: 4702
		{
			Cant = 0,
			Close = 1,
			OpenSideMenu = 2
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 4703
		{
			// Fields
			public SaveMenu <>4__this; // 0x10
			public UiMaster master; // 0x18
	
			// Constructors
			public <>c__DisplayClass33_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__1(float x); // 0x0000000180B7D0D0-0x0000000180B7D150
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__2(float x); // 0x0000000180B7D150-0x0000000180B7DA20
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B7D090-0x0000000180B7D0D0
		}
	
		// Constructors
		public SaveMenu(); // 0x0000000180B40050-0x0000000180B401B0
		static SaveMenu(); // 0x0000000180B3FFC0-0x0000000180B40050
	
		// Methods
		public bool RefreshFileInfo(); // 0x0000000180B3F990-0x0000000180B3FA50
		public void LoadOrCreateSettingsData(); // 0x0000000180B3EE70-0x0000000180B3F080
		public void OnStart(); // 0x0000000180B3F220-0x0000000180B3F5E0
		public void SaveSettings(); // 0x0000000180B3FC40-0x0000000180B3FD00
		[ContextMenu] // 0x0000000180134550-0x0000000180134580
		public void Toggle(); // 0x0000000180B3FF70-0x0000000180B3FFC0
		public void SetState(State state); // 0x0000000180B3FD00-0x0000000180B3FE10
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x0000000180B3F940-0x0000000180B3F990
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B3F5F0-0x0000000180B3F940
		public void Open(); // 0x0000000180B3F5E0-0x0000000180B3F5F0
		public void Close(); // 0x0000000180B3EAC0-0x0000000180B3EAD0
		public void Button_SideCancel(BaseButton button); // 0x0000000180B3E860-0x0000000180B3E8C0
		private void LateUpdate(); // 0x0000000180B3ED50-0x0000000180B3EE70
		private void SetupCard(SaveCard card); // 0x0000000180B3FE10-0x0000000180B3FF50
		public void Clicked(SaveCard card); // 0x0000000180B3E900-0x0000000180B3EAC0
		public void CancelFocusClicked(); // 0x0000000180B3E8C0-0x0000000180B3E900
		public void StartNew(); // 0x0000000180B3FF50-0x0000000180B3FF70
		public void NewButton(); // 0x0000000180B3F1D0-0x0000000180B3F220
		public void Button_Focus_Load(); // 0x0000000180B3E7D0-0x0000000180B3E860
		public void Button_Focus_CopyToClipboard(); // 0x0000000180B3E450-0x0000000180B3E480
		public void Button_Focus_Duplicate(); // 0x0000000180B3E540-0x0000000180B3E7D0
		public void Button_Focus_Delete_Down(); // 0x00000001801D8E80-0x00000001801D8E90
		public void Button_Focus_Delete_Full(); // 0x0000000180B3E480-0x0000000180B3E540
		private string GetUniqueSaveName(); // 0x0000000180B3EAD0-0x0000000180B3ED50
		[ContextMenu] // 0x0000000180134580-0x00000001801345B0
		public void SaveCurrent(); // 0x0000000180B3FA50-0x0000000180B3FC40
		private void Load(SaveCard card); // 0x0000000180B3F080-0x0000000180B3F1D0
	}
}

namespace Placemaker
{
	[Serializable]
	public static class SaveSystem // TypeDefIndex: 4630
	{
		// Fields
		public const string defaultSaveName = "Save"; // Metadata: 0x0021FEC3
		public const string fileEnding = "place"; // Metadata: 0x0021FECB
	
		// Methods
		public static string GetSavePath(string name); // 0x0000000180B401B0-0x0000000180B40210
		public static void Save(SaveData saveData); // 0x0000000180B403B0-0x0000000180B404C0
		public static SaveData Load(); // 0x0000000180B40210-0x0000000180B403B0
	}
}

namespace Os.Utils
{
	[Serializable]
	public struct SbyteFloat3 // TypeDefIndex: 4919
	{
		// Fields
		public const int max = 254; // Metadata: 0x0022036C
		public const float maxf = 254f; // Metadata: 0x00220370
		public sbyte x; // 0x00
		public sbyte y; // 0x01
		public sbyte z; // 0x02
	
		// Properties
		public float fx { get; set; } // 0x000000018019BFA0-0x000000018019BFC0 0x000000018019C120-0x000000018019C190
		public float fy { get; set; } // 0x000000018019BFC0-0x000000018019BFE0 0x000000018019C190-0x000000018019C200
		public float fz { get; set; } // 0x000000018019BFE0-0x000000018019C000 0x000000018019C200-0x000000018019C2B0
		public sbyte this[int key] { get => default; set {} } // 0x000000018019BF10-0x000000018019BFA0 0x000000018019C070-0x000000018019C120
		public Vector3 normal { get; } // 0x000000018019C000-0x000000018019C070 
	
		// Constructors
		public SbyteFloat3(float fx, float fy, float fz); // 0x000000018019BF00-0x000000018019BF10
		public SbyteFloat3(int x, int y, int z); // 0x000000018019BEF0-0x000000018019BF00
	
		// Methods
		public static explicit operator Vector3(SbyteFloat3 b); // 0x0000000180B74AB0-0x0000000180B74B10
		public static explicit operator float3(SbyteFloat3 b); // 0x0000000180B74A40-0x0000000180B74A90
		public static explicit operator int3(SbyteFloat3 b); // 0x0000000180B74A90-0x0000000180B74AB0
		public static explicit operator SbyteFloat3(Vector3 f); // 0x0000000180B74A00-0x0000000180B74A40
		public static explicit operator SbyteFloat3(int3 f); // 0x0000000180B74B10-0x0000000180B74B30
		public override bool Equals(object obj); // 0x000000018019BD70-0x000000018019BE20
		public static bool operator ==(SbyteFloat3 a, SbyteFloat3 b); // 0x0000000180B61EA0-0x0000000180B61EC0
		public static bool operator !=(SbyteFloat3 a, SbyteFloat3 b); // 0x0000000180B61F60-0x0000000180B61FA0
		public static SbyteFloat3 operator *(int3x3 a, SbyteFloat3 b); // 0x0000000180B74B30-0x0000000180B74C60
		public override int GetHashCode(); // 0x000000018019BE20-0x000000018019BE50
		public override string ToString(); // 0x000000018019BE50-0x000000018019BEF0
	}

	public struct ScopedProfiler : IDisposable // TypeDefIndex: 4929
	{
		// Constructors
		public ScopedProfiler(string name); // 0x0000000180002620-0x0000000180002630
		public ScopedProfiler(string name, UnityEngine.Object targetObject); // 0x0000000180002620-0x0000000180002630
	
		// Methods
		void IDisposable.Dispose(); // 0x0000000180002620-0x0000000180002630
	}
}

namespace Placemaker.Ui
{
	public class ScreenshotButtons : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4704
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup frameCanvasGroup; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup tick; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ScreenshotFrame frame; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState frameState; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private BaseButton screenshotButton; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_InputField widthInput; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_InputField heightInput; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int width; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int height; // 0x5C
		private const int maxWidth = 4096; // Metadata: 0x0021FFAC
		private const int maxHeight = 4096; // Metadata: 0x0021FFB0
	
		// Constructors
		public ScreenshotButtons(); // 0x0000000180B78E40-0x0000000180B78EB0
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B78DB0-0x0000000180B78E40
		public void Button_ToggleFrame(); // 0x0000000180B78D60-0x0000000180B78DB0
		public void Button_ScreenshotJPG(); // 0x0000000180B78BC0-0x0000000180B78C90
		public void Button_ScreenshotPNG(); // 0x0000000180B78C90-0x0000000180B78D60
		public void Button_InputUpdated(); // 0x0000000180B78AD0-0x0000000180B78BC0
	}
}

namespace Placemaker
{
	public class ScreenshotCamera : MonoBehaviour // TypeDefIndex: 4636
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Camera cam; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Camera skyboxCam; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Camera noiseCam; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Texture2D outTex; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material noAlphaBlit; // 0x40
		private ScreenshotFrame screenshotFrame; // 0x48
	
		// Nested types
		public enum Format // TypeDefIndex: 4637
		{
			Jpg = 0,
			Png = 1,
			Clipboard = 2
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <CaptureRoutine>d__9 : IEnumerator<object> // TypeDefIndex: 4638
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ScreenshotCamera <>4__this; // 0x20
			public RectTransform rt; // 0x28
			public int width; // 0x30
			public int height; // 0x34
			public Format format; // 0x38
			private RenderTexture <smallTex>5__2; // 0x40
			private RenderTexture <bigTex>5__3; // 0x48
			private int <aaFactorId>5__4; // 0x50
			private Rect <readRect>5__5; // 0x54
			private byte[] <bytes>5__6; // 0x68
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <CaptureRoutine>d__9(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x0000000180B435A0-0x0000000180B444D0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x0000000180B444D0-0x0000000180B44520
		}
	
		// Constructors
		public ScreenshotCamera(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public void Capture(RectTransform rt, int width, int height, Format format); // 0x0000000180B40560-0x0000000180B40600
		[IteratorStateMachine] // 0x000000018012E280-0x000000018012E2D0
		public IEnumerator CaptureRoutine(RectTransform rt, int width, int height, Format format); // 0x0000000180B404C0-0x0000000180B40560
	}
}

namespace Placemaker.Ui
{
	public class ScreenshotFrame : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4705
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		public RectTransform center; // 0x20
		public RectTransform margins; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RectTransform top; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RectTransform bottom; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RectTransform left; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RectTransform right; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int width; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int height; // 0x54
	
		// Constructors
		public ScreenshotFrame(); // 0x0000000180B793F0-0x0000000180B79410
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x00000001801D8E80-0x00000001801D8E90
		protected override void OnRectTransformDimensionsChange(); // 0x0000000180B78EB0-0x0000000180B78EC0
		public void SetSize(int width, int height); // 0x0000000180B78FE0-0x0000000180B78FF0
		public void UpdateSize(); // 0x0000000180B78FF0-0x0000000180B793F0
		private void SetRect(RectTransform rt, float minX, float maxX, float minY, float maxY); // 0x0000000180B78EC0-0x0000000180B78FE0
	}
}

namespace I2.Loc
{
	[AddComponentMenu] // 0x0000000180143250-0x0000000180143280
	public class SetLanguage : MonoBehaviour // TypeDefIndex: 4894
	{
		// Fields
		public string _Language; // 0x18
	
		// Constructors
		public SetLanguage(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void OnClick(); // 0x00000001803B3790-0x00000001803B38A0
		public void ApplyLanguage(); // 0x00000001803B3790-0x00000001803B38A0
	}

	[AddComponentMenu] // 0x0000000180143280-0x00000001801432B0
	public class SetLanguageDropdown : MonoBehaviour // TypeDefIndex: 4895
	{
		// Constructors
		public SetLanguageDropdown(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void OnEnable(); // 0x00000001803B3480-0x00000001803B36C0
		private void OnValueChanged(int index); // 0x00000001803B36C0-0x00000001803B3790
	}
}

namespace TMPro
{
	internal static class SetPropertyUtility // TypeDefIndex: 4209
	{
		// Methods
		public static bool SetColor(ref Color currentValue, Color newValue); // 0x00000001801D2A20-0x00000001801D2A60
		public static bool SetEquatableStruct<T>(ref T currentValue, T newValue)
			where T : IEquatable<T>;
		public static bool SetStruct<T>(ref T currentValue, T newValue)
			where T : struct;
		public static bool SetClass<T>(ref T currentValue, T newValue)
			where T : class;
	}
}

namespace Placemaker
{
	[Serializable]
	public class SettingsData // TypeDefIndex: 4631
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public string lastSave; // 0x10
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public ulong saveIterator; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public byte currentColor; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public byte audioVolume; // 0x21
	
		// Constructors
		public SettingsData(); // 0x0000000180B40600-0x0000000180B40610
	}
}

namespace TMPro
{
	public static class ShaderUtilities // TypeDefIndex: 4234
	{
		// Fields
		public static int ID_MainTex; // 0x00
		public static int ID_FaceTex; // 0x04
		public static int ID_FaceColor; // 0x08
		public static int ID_FaceDilate; // 0x0C
		public static int ID_Shininess; // 0x10
		public static int ID_UnderlayColor; // 0x14
		public static int ID_UnderlayOffsetX; // 0x18
		public static int ID_UnderlayOffsetY; // 0x1C
		public static int ID_UnderlayDilate; // 0x20
		public static int ID_UnderlaySoftness; // 0x24
		public static int ID_WeightNormal; // 0x28
		public static int ID_WeightBold; // 0x2C
		public static int ID_OutlineTex; // 0x30
		public static int ID_OutlineWidth; // 0x34
		public static int ID_OutlineSoftness; // 0x38
		public static int ID_OutlineColor; // 0x3C
		public static int ID_Padding; // 0x40
		public static int ID_GradientScale; // 0x44
		public static int ID_ScaleX; // 0x48
		public static int ID_ScaleY; // 0x4C
		public static int ID_PerspectiveFilter; // 0x50
		public static int ID_Sharpness; // 0x54
		public static int ID_TextureWidth; // 0x58
		public static int ID_TextureHeight; // 0x5C
		public static int ID_BevelAmount; // 0x60
		public static int ID_GlowColor; // 0x64
		public static int ID_GlowOffset; // 0x68
		public static int ID_GlowPower; // 0x6C
		public static int ID_GlowOuter; // 0x70
		public static int ID_LightAngle; // 0x74
		public static int ID_EnvMap; // 0x78
		public static int ID_EnvMatrix; // 0x7C
		public static int ID_EnvMatrixRotation; // 0x80
		public static int ID_MaskCoord; // 0x84
		public static int ID_ClipRect; // 0x88
		public static int ID_MaskSoftnessX; // 0x8C
		public static int ID_MaskSoftnessY; // 0x90
		public static int ID_VertexOffsetX; // 0x94
		public static int ID_VertexOffsetY; // 0x98
		public static int ID_UseClipRect; // 0x9C
		public static int ID_StencilID; // 0xA0
		public static int ID_StencilOp; // 0xA4
		public static int ID_StencilComp; // 0xA8
		public static int ID_StencilReadMask; // 0xAC
		public static int ID_StencilWriteMask; // 0xB0
		public static int ID_ShaderFlags; // 0xB4
		public static int ID_ScaleRatio_A; // 0xB8
		public static int ID_ScaleRatio_B; // 0xBC
		public static int ID_ScaleRatio_C; // 0xC0
		public static string Keyword_Bevel; // 0xC8
		public static string Keyword_Glow; // 0xD0
		public static string Keyword_Underlay; // 0xD8
		public static string Keyword_Ratios; // 0xE0
		public static string Keyword_MASK_SOFT; // 0xE8
		public static string Keyword_MASK_HARD; // 0xF0
		public static string Keyword_MASK_TEX; // 0xF8
		public static string Keyword_Outline; // 0x100
		public static string ShaderTag_ZTestMode; // 0x108
		public static string ShaderTag_CullMode; // 0x110
		private static float m_clamp; // 0x118
		public static bool isInitialized; // 0x11C
		private static Shader k_ShaderRef_MobileSDF; // 0x120
		private static Shader k_ShaderRef_MobileBitmap; // 0x128
	
		// Properties
		internal static Shader ShaderRef_MobileSDF { get; } // 0x00000001801D5810-0x00000001801D5C70 
		internal static Shader ShaderRef_MobileBitmap { get; } // 0x00000001801D5700-0x00000001801D5810 
	
		// Constructors
		static ShaderUtilities(); // 0x00000001801D5590-0x00000001801D5700
	
		// Methods
		public static void GetShaderPropertyIDs(); // 0x00000001801D4550-0x00000001801D4D40
		public static void UpdateShaderRatios(Material mat); // 0x00000001801D4F10-0x00000001801D5590
		public static Vector4 GetFontExtent(Material material); // 0x00000001801D2A60-0x00000001801D2AC0
		public static bool IsMaskingEnabled(Material material); // 0x00000001801D4D40-0x00000001801D4F10
		public static float GetPadding(Material material, bool enableExtraPadding, bool isBold); // 0x00000001801D3A70-0x00000001801D4550
		public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold); // 0x00000001801D2AC0-0x00000001801D3A70
	}
}

namespace Placemaker.Graphs
{
	[SelectionBase] // 0x0000000180110980-0x0000000180110990
	public class ShadowMesh : MonoBehaviour // TypeDefIndex: 4793
	{
		// Fields
		public List<Vector3> shadowMeshVerts; // 0x18
		public List<Vector2> shadowMeshUvs; // 0x20
		public List<int> shadowMeshTris; // 0x28
		public bool dirty; // 0x30
		public Mesh mesh; // 0x38
	
		// Constructors
		public ShadowMesh(); // 0x00000001802DBBF0-0x00000001802DBCA0
	}
}

namespace Placemaker.Props
{
	public class ShiftingMesh : MonoBehaviour, IComparable<Vector3>, IComparable<ShiftingMesh> // TypeDefIndex: 4753
	{
		// Fields
		public MeshFilter targetMeshFilter; // 0x18
	
		// Constructors
		public ShiftingMesh(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		int IComparable<Vector3>.CompareTo(Vector3 other); // 0x0000000180B40690-0x0000000180B40C20
		int IComparable<ShiftingMesh>.CompareTo(ShiftingMesh other); // 0x0000000180B40610-0x0000000180B40690
	}
}

namespace Placemaker.Graphs
{
	[Serializable]
	public struct SideCounts // TypeDefIndex: 4792
	{
		// Fields
		public ushort side; // 0x00
		public uint count; // 0x04
	}
}

namespace Placemaker.Ui
{
	public class SideMenu : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4706
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RectTransform sideTransform; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RectTransform contentTransform; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public UpdateState openState; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState sideButtonState; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Graphic sideButtonOpen; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Graphic sideButtonClose; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup tabCanvasGroup; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup sideCanvasGroup; // 0x58
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 4707
		{
			// Fields
			public SideMenu <>4__this; // 0x10
			public UiMaster master; // 0x18
			public CanvasGroup rootCanvasGroup; // 0x20
	
			// Constructors
			public <>c__DisplayClass10_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B7C560-0x0000000180B7C800
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__4(float x); // 0x0000000180B7CC50-0x0000000180B7CCB0
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__1(float x); // 0x0000000180B7C800-0x0000000180B7CBA0
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__2(float x); // 0x0000000180B7CBA0-0x0000000180B7CC20
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__3(float x); // 0x0000000180B7CC20-0x0000000180B7CC50
		}
	
		// Constructors
		public SideMenu(); // 0x0000000180B79850-0x0000000180B798D0
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D8E80-0x00000001801D8E90
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B79590-0x0000000180B79800
		public void Button_Load(); // 0x0000000180B79410-0x0000000180B79460
		public void Button_New(); // 0x0000000180B79460-0x0000000180B79490
		public void Button_Quit_Down(); // 0x00000001801D8E80-0x00000001801D8E90
		public void Button_Quit_Full(); // 0x0000000180B79490-0x0000000180B794E0
		public void Button_SideButton(); // 0x0000000180B794E0-0x0000000180B79530
		public void Toggle(); // 0x0000000180B79800-0x0000000180B79850
		public void Open(); // 0x0000000180B79560-0x0000000180B79590
		public void Close(); // 0x0000000180B79530-0x0000000180B79560
		public void RemoveLayouts(bool isBuild); // 0x00000001801D8E80-0x00000001801D8E90
	}
}

namespace Placemaker
{
	[Serializable]
	public struct SideProfile // TypeDefIndex: 4653
	{
		// Fields
		public ushort v00; // 0x00
		public ushort v01; // 0x02
		public ushort v10; // 0x04
		public ushort v11; // 0x06
		public ushort v20; // 0x08
		public ushort v21; // 0x0A
		public ushort v30; // 0x0C
		public ushort v31; // 0x0E
		public ushort v4; // 0x10
		public ushort v5; // 0x12
	
		// Methods
		public void Set(int index, ushort value0, ushort value1); // 0x0000000180198E40-0x0000000180198F20
		public void Add(SideProfile s); // 0x0000000180198AF0-0x0000000180198BC0
		public ushort Get0(int index); // 0x0000000180198BC0-0x0000000180198CA0
		public ushort Get1(int index); // 0x0000000180198CA0-0x0000000180198D80
		public bool IsEmtpy(); // 0x0000000180198E10-0x0000000180198E40
		public override string ToString(); // 0x0000000180198F20-0x0000000180198F30
		public override int GetHashCode(); // 0x0000000180198D80-0x0000000180198E10
	}
}

namespace Placemaker.Ui
{
	public class SimpleMessage : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4708
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_Text text; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState openState; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float timer; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Vector3 startPos; // 0x2C
	
		// Constructors
		public SimpleMessage(); // 0x0000000180B79F30-0x0000000180B79F90
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x0000000180B79960-0x0000000180B799A0
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B798D0-0x0000000180B79960
		public void SetParam(string param, string value); // 0x0000000180B799A0-0x0000000180B79A60
		public void ShowMessage(string message, float time = 2f /* Metadata: 0x0021FFB4 */); // 0x0000000180B79A60-0x0000000180B79BD0
		public void ShowTerm(string message, float time = 2f /* Metadata: 0x0021FFB8 */); // 0x0000000180B79BD0-0x0000000180B79DA0
		protected override void OnEnable(); // 0x00000001801D0660-0x00000001801D0670
		public void Update(); // 0x0000000180B79DA0-0x0000000180B79F30
	}

	public class Slider : UIBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, UiMaster.IUiSetup // TypeDefIndex: 4709
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public UnityEvent_Float onValueChange; // 0x18
		public bool pointerInside; // 0x20
		public bool buttonDown; // 0x21
		public bool dragging; // 0x22
		public RectTransform sliderContainer; // 0x28
		public RectTransform sliderHandle; // 0x30
		public RectTransform sliderBackground0; // 0x38
		public RectTransform sliderBackground1; // 0x40
		private float oldValue; // 0x48
		private float newValue; // 0x4C
		private UpdateState pressedState; // 0x50
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 4710
		{
			// Fields
			public Slider <>4__this; // 0x10
			public Vector3 scale; // 0x18
	
			// Constructors
			public <>c__DisplayClass21_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B7CDB0-0x0000000180B7CF00
		}
	
		// Constructors
		public Slider(); // 0x0000000180B7ABD0-0x0000000180B7AC30
	
		// Methods
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x0000000180B7AB20-0x0000000180B7AB70
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x0000000180B7AB80-0x0000000180B7ABD0
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData); // 0x0000000180B7A730-0x0000000180B7AB20
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x0000000180B7AB70-0x0000000180B7AB80
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x0000000180296F90-0x0000000180296FA0
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x0000000180B7A320-0x0000000180B7A6F0
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x0000000180B7A310-0x0000000180B7A320
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x0000000180B7A6F0-0x0000000180B7A730
		public void SetValue(float value); // 0x0000000180B7A0A0-0x0000000180B7A310
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D8E80-0x00000001801D8E90
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B79F90-0x0000000180B7A0A0
	}

	public class SoundButton : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4711
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private DistanceFieldSettings distanceField0; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private DistanceFieldSettings distanceField1; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState soundState; // 0x30
		public AudioMixer mixer; // 0x38
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 4712
		{
			// Fields
			public SoundButton <>4__this; // 0x10
			public Placemaker.Ui.Slider slider; // 0x18
			public DistanceFieldSettings bg0; // 0x20
			public DistanceFieldSettings bg1; // 0x28
	
			// Constructors
			public <>c__DisplayClass6_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(float x); // 0x0000000180B7DCC0-0x0000000180B7E050
		}
	
		// Constructors
		public SoundButton(); // 0x0000000180B7B100-0x0000000180B7B170
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B7ADB0-0x0000000180B7B000
		public void Button_Toggle(); // 0x0000000180B7AD10-0x0000000180B7ADB0
		public void Button_Slider(float value); // 0x0000000180B7AC30-0x0000000180B7AD10
		public void UpdateVolume(); // 0x0000000180B7B000-0x0000000180B7B100
	}
}

namespace I2.Loc
{
	public class SpecializationManager : BaseSpecializationManager // TypeDefIndex: 4802
	{
		// Fields
		public static SpecializationManager Singleton; // 0x00
	
		// Constructors
		private SpecializationManager(); // 0x0000000180B75570-0x0000000180B755A0
		static SpecializationManager(); // 0x0000000180B75500-0x0000000180B75570
	
		// Methods
		public static string GetSpecializedText(string text, string specialization = null); // 0x0000000180B74F50-0x0000000180B75140
		public static string SetSpecializedText(string text, string newText, string specialization); // 0x0000000180B75140-0x0000000180B75240
		public static string SetSpecializedText(Dictionary<string, string> specializations); // 0x0000000180B75240-0x0000000180B75500
		public static Dictionary<string, string> GetSpecializations(string text, Dictionary<string, string> buffer = null); // 0x0000000180B74DB0-0x0000000180B74F50
		public static void AppendSpecializations(string text, List<string> list = null); // 0x0000000180B74C60-0x0000000180B74DB0
	}
}

namespace TMPro.SpriteAssetUtilities
{
	public enum SpriteAssetImportFormats // TypeDefIndex: 4292
	{
		None = 0,
		TexturePacker = 1
	}
}

namespace Placemaker.Graphs
{
	[Serializable]
	public class Square : MonoBehaviour // TypeDefIndex: 4794
	{
		// Fields
		public Relation q0; // 0x18
		public Relation q1; // 0x28
		public Relation q2; // 0x38
		public Relation q3; // 0x48
		public Corner c0; // 0x58
		public Corner c1; // 0x60
		public Corner c2; // 0x68
		public Corner c3; // 0x70
		public Matrix4x4 m0; // 0x78
		public Matrix4x4 m1; // 0xB8
		public Matrix4x4 m2; // 0xF8
		public Matrix4x4 m3; // 0x138
		public byte motivations; // 0x178
		public byte quadIndex; // 0x179
	
		// Properties
		public int3 bitQuadId { get; } // 0x00000001802DC850-0x00000001802DC890 
	
		// Nested types
		[Serializable]
		public struct Relation // TypeDefIndex: 4795
		{
			// Fields
			public Square square; // 0x00
			public sbyte indexInOther; // 0x08
			public static readonly Relation empty; // 0x00
	
			// Constructors
			public Relation(Square qube, sbyte indexInOther); // 0x0000000180007360-0x0000000180007450
			static Relation(); // 0x00000001802DBB50-0x00000001802DBBA0
	
			// Methods
			public override int GetHashCode(); // 0x00000001800072C0-0x0000000180007360
		}
	
		// Constructors
		public Square(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public Corner GetCorner(sbyte index); // 0x00000001802DBCA0-0x00000001802DBD50
		public void SetCorner(sbyte index, Corner value); // 0x00000001802DC670-0x00000001802DC740
		public Relation GetRelation(sbyte index); // 0x00000001802DBD50-0x00000001802DBE00
		public void SetRelation(sbyte index, sbyte indexInOther, Square value); // 0x00000001802DC740-0x00000001802DC850
		private void OnDrawGizmos(); // 0x00000001802DBE00-0x00000001802DC670
	}
}

internal static class SR // TypeDefIndex: 3
{
	// Methods
	internal static string Format(string resourceFormat, object p1); // 0x0000000180746510-0x0000000180746580
	internal static string Format(string resourceFormat, object p1, object p2); // 0x0000000180746480-0x0000000180746510
}

internal static class SR // TypeDefIndex: 1692
{
	// Methods
	internal static string GetString(string name, params /* 0x0000000180110980-0x0000000180110990 */ object[] args); // 0x000000018064DDD0-0x000000018064DE40
	internal static string GetString(CultureInfo culture, string name, params /* 0x0000000180110980-0x0000000180110990 */ object[] args); // 0x0000000180630240-0x0000000180630250
}

internal static class SR // TypeDefIndex: 2122
{
	// Methods
	internal static string GetString(string name, params /* 0x0000000180110980-0x0000000180110990 */ object[] args); // 0x00000001806301D0-0x0000000180630240
	internal static string GetString(CultureInfo culture, string name, params /* 0x0000000180110980-0x0000000180110990 */ object[] args); // 0x0000000180630240-0x0000000180630250
	internal static string GetString(string name); // 0x000000018023A380-0x000000018023A390
}

internal static class SR // TypeDefIndex: 2606
{
	// Methods
	internal static string GetString(string name); // 0x000000018023A380-0x000000018023A390
}

namespace Placemaker.Ui
{
	public class StandardButton : MonoBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4713
	{
		// Fields
		public UpdateState scaleZ; // 0x18
		public UpdateState scaleXY; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 4714
		{
			// Fields
			public StandardButton <>4__this; // 0x10
			public BaseButton baseButton; // 0x18
	
			// Constructors
			public <>c__DisplayClass3_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__0(BaseButton.State state); // 0x0000000180B7DB40-0x0000000180B7DCC0
		}
	
		// Constructors
		public StandardButton(); // 0x0000000180B7B480-0x0000000180B7B520
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D8E80-0x00000001801D8E90
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B7B170-0x0000000180B7B480
	}
}

public class StoreAssetExporter : MonoBehaviour // TypeDefIndex: 4581
{
	// Fields
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	public Camera cam; // 0x18
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	public Canvas canvas; // 0x20
	[SerializeField] // 0x0000000180110980-0x0000000180110990
	public List<Texture2D> outputTextures; // 0x28

	// Constructors
	public StoreAssetExporter(); // 0x0000000180B7B520-0x0000000180B7B580
}

public class StoreAssetFrame : MonoBehaviour // TypeDefIndex: 4582
{
	// Fields
	public Format format; // 0x18

	// Nested types
	public enum Format // TypeDefIndex: 4583
	{
		Png = 0,
		Jpg = 1,
		Tga = 2
	}

	// Constructors
	public StoreAssetFrame(); // 0x00000001801D0210-0x00000001801D0220
}

namespace I2.Loc
{
	public class StringObfucator // TypeDefIndex: 4896
	{
		// Fields
		public static char[] StringObfuscatorPassword; // 0x00
	
		// Constructors
		public StringObfucator(); // 0x00000001801D0660-0x00000001801D0670
		static StringObfucator(); // 0x0000000180B759F0-0x0000000180B75A40
	
		// Methods
		public static string Encode(string NormalString); // 0x0000000180B756A0-0x0000000180B75780
		public static string Decode(string ObfucatedString); // 0x0000000180B755A0-0x0000000180B756A0
		private static string ToBase64(string regularString); // 0x0000000180B75810-0x0000000180B75890
		private static string FromBase64(string base64string); // 0x0000000180B75780-0x0000000180B75810
		private static string XoREncode(string NormalString); // 0x0000000180B75890-0x0000000180B759F0
	}
}

namespace TMPro
{
	public struct TagAttribute // TypeDefIndex: 4286
	{
		// Fields
		public int startIndex; // 0x00
		public int length; // 0x04
		public int hashCode; // 0x08
	}

	public enum TagUnitType // TypeDefIndex: 4228
	{
		Pixels = 0,
		FontUnits = 1,
		Percentage = 2
	}

	public enum TagValueType // TypeDefIndex: 4227
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4
	}
}

namespace I2.Loc
{
	internal class TashkeelLocation // TypeDefIndex: 4889
	{
		// Fields
		public char tashkeel; // 0x10
		public int position; // 0x14
	
		// Constructors
		public TashkeelLocation(char tashkeel, int position); // 0x0000000180B75A40-0x0000000180B75A80
	}
}

namespace CielaSpike
{
	public class Task : IEnumerator // TypeDefIndex: 4936
	{
		// Fields
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private object <Current>k__BackingField; // 0x10
		private readonly IEnumerator _innerRoutine; // 0x18
		private RunningState _state; // 0x20
		private RunningState _previousState; // 0x24
		private object _pendingCurrent; // 0x28
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private Exception <Exception>k__BackingField; // 0x30
	
		// Properties
		public object Current { [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ get; [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ private set; } // 0x00000001801D2960-0x00000001801D2970 0x00000001801D2970-0x00000001801D2980
		public TaskState State { get; } // 0x00000001805DEC50-0x00000001805DEC90 
		public Exception Exception { [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ get; [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ private set; } // 0x00000001801D0250-0x00000001801D0260 0x00000001801D0290-0x00000001801D0660
	
		// Nested types
		private enum RunningState // TypeDefIndex: 4937
		{
			Init = 0,
			RunningAsync = 1,
			PendingYield = 2,
			ToBackground = 3,
			RunningSync = 4,
			CancellationRequested = 5,
			Done = 6,
			Error = 7
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <Wait>d__19 : IEnumerator<object> // TypeDefIndex: 4938
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Task <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <Wait>d__19(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x00000001805DF930-0x00000001805DF990
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001805DF990-0x00000001805DF9E0
		}
	
		// Constructors
		public Task(IEnumerator routine); // 0x00000001805DEC20-0x00000001805DEC50
	
		// Methods
		public bool MoveNext(); // 0x00000001805DE860-0x00000001805DE870
		public void Reset(); // 0x00000001805DEAB0-0x00000001805DEB10
		public void Cancel(); // 0x00000001805DE500-0x00000001805DE530
		[IteratorStateMachine] // 0x000000018014B600-0x000000018014B650
		public IEnumerator Wait(); // 0x00000001805DEBC0-0x00000001805DEC20
		private void GotoState(RunningState state); // 0x00000001805DE530-0x00000001805DE5E0
		private void SetPendingCurrentObject(object current); // 0x00000001805DEB10-0x00000001805DEBC0
		private bool OnMoveNext(); // 0x00000001805DE870-0x00000001805DEAB0
		private void MoveNextAsync(); // 0x00000001805DE5E0-0x00000001805DE640
		private void BackgroundRunner(object state); // 0x00000001805DE4F0-0x00000001805DE500
		private void MoveNextUnity(); // 0x00000001805DE640-0x00000001805DE860
	}

	public enum TaskState // TypeDefIndex: 4939
	{
		Init = 0,
		Running = 1,
		Done = 2,
		Cancelled = 3,
		Error = 4
	}
}

namespace I2.Loc
{
	[Serializable]
	public class TermData // TypeDefIndex: 4871
	{
		// Fields
		public string Term; // 0x10
		public eTermType TermType; // 0x18
		[NonSerialized]
		public string Description; // 0x20
		public string[] Languages; // 0x28
		public byte[] Flags; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string[] Languages_Touch; // 0x38
	
		// Constructors
		public TermData(); // 0x0000000180B76560-0x0000000180B765D0
	
		// Methods
		public string GetTranslation(int idx, string specialization = null, bool editMode = false /* Metadata: 0x0022017F */); // 0x0000000180B75B70-0x0000000180B75C70
		public void SetTranslation(int idx, string translation, string specialization = null); // 0x0000000180B76160-0x0000000180B76310
		public void RemoveSpecialization(string specialization); // 0x0000000180B75E30-0x0000000180B75FE0
		public void RemoveSpecialization(int idx, string specialization); // 0x0000000180B75FE0-0x0000000180B76160
		public bool IsAutoTranslated(int idx, bool IsTouch); // 0x0000000180B75D60-0x0000000180B75DA0
		public void Validate(); // 0x0000000180B76310-0x0000000180B76560
		public bool IsTerm(string name, bool allowCategoryMistmatch); // 0x0000000180B75DA0-0x0000000180B75E30
		public bool HasSpecializations(); // 0x0000000180B75C70-0x0000000180B75D60
		public List<string> GetAllSpecializations(); // 0x0000000180B75A80-0x0000000180B75B70
	}

	public class TermsPopup : PropertyAttribute // TypeDefIndex: 4872
	{
		// Fields
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private string <Filter>k__BackingField; // 0x10
	
		// Properties
		public string Filter { [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ get; [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ private set; } // 0x00000001801D2960-0x00000001801D2970 0x00000001801D2970-0x00000001801D2980
	
		// Constructors
		public TermsPopup(string filter = "" /* Metadata: 0x00220180 */); // 0x0000000180B765D0-0x0000000180B76600
	}
}

namespace TMPro
{
	public enum TextAlignmentOptions // TypeDefIndex: 4247
	{
		TopLeft = 257,
		Top = 258,
		TopRight = 260,
		TopJustified = 264,
		TopFlush = 272,
		TopGeoAligned = 288,
		Left = 513,
		Center = 514,
		Right = 516,
		Justified = 520,
		Flush = 528,
		CenterGeoAligned = 544,
		BottomLeft = 1025,
		Bottom = 1026,
		BottomRight = 1028,
		BottomJustified = 1032,
		BottomFlush = 1040,
		BottomGeoAligned = 1056,
		BaselineLeft = 2049,
		Baseline = 2050,
		BaselineRight = 2052,
		BaselineJustified = 2056,
		BaselineFlush = 2064,
		BaselineGeoAligned = 2080,
		MidlineLeft = 4097,
		Midline = 4098,
		MidlineRight = 4100,
		MidlineJustified = 4104,
		MidlineFlush = 4112,
		MidlineGeoAligned = 4128,
		CaplineLeft = 8193,
		Capline = 8194,
		CaplineRight = 8196,
		CaplineJustified = 8200,
		CaplineFlush = 8208,
		CaplineGeoAligned = 8224
	}

	[AddComponentMenu] // 0x00000001801322C0-0x0000000180132340
	[RequireComponent] // 0x00000001801322C0-0x0000000180132340
	public class TextContainer : UIBehaviour // TypeDefIndex: 4291
	{
		// Fields
		private bool m_hasChanged; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Vector2 m_pivot; // 0x1C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TextContainerAnchors m_anchorPosition; // 0x24
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Rect m_rect; // 0x28
		private bool m_isDefaultWidth; // 0x38
		private bool m_isDefaultHeight; // 0x39
		private bool m_isAutoFitting; // 0x3A
		private Vector3[] m_corners; // 0x40
		private Vector3[] m_worldCorners; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Vector4 m_margins; // 0x50
		private RectTransform m_rectTransform; // 0x60
		private static Vector2 k_defaultSize; // 0x00
		private TextMeshPro m_textMeshPro; // 0x68
	
		// Properties
		public bool hasChanged { get; set; } // 0x000000018034F960-0x000000018034F970 0x00000001803BFB20-0x00000001803BFB30
		public Vector2 pivot { get; set; } // 0x00000001803BF840-0x00000001803BF860 0x00000001803BFCC0-0x00000001803BFD80
		public TextContainerAnchors anchorPosition { get; set; } // 0x00000001801D0C50-0x00000001801D0C60 0x00000001803BF9D0-0x00000001803BFB20
		public Rect rect { get; set; } // 0x00000001801D0C40-0x00000001801D0C50 0x00000001803BFD80-0x00000001803BFDE0
		public Vector2 size { get; set; } // 0x00000001803BF8E0-0x00000001803BF940 0x00000001803BFDE0-0x00000001803BFF10
		public float width { get; set; } // 0x00000001803BF9C0-0x00000001803BF9D0 0x00000001803BFF10-0x00000001803BFFF0
		public float height { get; set; } // 0x00000001803BF7F0-0x00000001803BF800 0x00000001803BFB30-0x00000001803BFC10
		public bool isDefaultWidth { get; } // 0x00000001803BF820-0x00000001803BF830 
		public bool isDefaultHeight { get; } // 0x00000001803BF810-0x00000001803BF820 
		public bool isAutoFitting { get; set; } // 0x00000001803BF800-0x00000001803BF810 0x00000001803BFC10-0x00000001803BFC20
		public Vector3[] corners { get; } // 0x00000001801E2210-0x00000001801E2220 
		public Vector3[] worldCorners { get; } // 0x00000001801FC9E0-0x00000001801FC9F0 
		public Vector4 margins { get; set; } // 0x00000001803BF830-0x00000001803BF840 0x00000001803BFC20-0x00000001803BFCC0
		public RectTransform rectTransform { get; } // 0x00000001803BF860-0x00000001803BF8E0 
		public TextMeshPro textMeshPro { get; } // 0x00000001803BF940-0x00000001803BF9C0 
	
		// Constructors
		public TextContainer(); // 0x00000001803BF780-0x00000001803BF7F0
		static TextContainer(); // 0x00000001803BF710-0x00000001803BF780
	
		// Methods
		protected override void Awake(); // 0x00000001803BE8D0-0x00000001803BE970
		protected override void OnEnable(); // 0x00000001803BEFB0-0x00000001803BEFC0
		protected override void OnDisable(); // 0x00000001801D8E80-0x00000001801D8E90
		private void OnContainerChanged(); // 0x00000001803BEDE0-0x00000001803BEFB0
		protected override void OnRectTransformDimensionsChange(); // 0x00000001803BEFC0-0x00000001803BF350
		private void SetRect(Vector2 size); // 0x00000001803BF350-0x00000001803BF3D0
		private void UpdateCorners(); // 0x00000001803BF3D0-0x00000001803BF710
		private Vector2 GetPivot(TextContainerAnchors anchor); // 0x00000001803BECC0-0x00000001803BEDE0
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot); // 0x00000001803BE970-0x00000001803BECC0
	}

	public enum TextContainerAnchors // TypeDefIndex: 4290
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Middle = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8,
		Custom = 9
	}

	public enum TextElementType : byte // TypeDefIndex: 4261
	{
		Character = 1,
		Sprite = 2
	}

	[AddComponentMenu] // 0x0000000180131B70-0x0000000180131C30
	[DisallowMultipleComponent] // 0x0000000180131B70-0x0000000180131C30
	[ExecuteAlways] // 0x0000000180131B70-0x0000000180131C30
	[RequireComponent] // 0x0000000180131B70-0x0000000180131C30
	[RequireComponent] // 0x0000000180131B70-0x0000000180131C30
	public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 4288
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_hasFontAssetChanged; // 0xB38
		private float m_previousLossyScaleY; // 0xB3C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Renderer m_renderer; // 0xB40
		private MeshFilter m_meshFilter; // 0xB48
		private bool m_isFirstAllocation; // 0xB50
		private int m_max_characters; // 0xB54
		private int m_max_numberOfLines; // 0xB58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_SubMesh[] m_subTextObjects; // 0xB60
		private bool m_isMaskingEnabled; // 0xB68
		private bool isMaskUpdateRequired; // 0xB69
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private MaskingTypes m_maskType; // 0xB6C
		private Matrix4x4 m_EnvMapMatrix; // 0xB70
		private Vector3[] m_RectTransformCorners; // 0xBB0
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBB8
		private int loopCountA; // 0xBBC
		private bool m_currentAutoSizeMode; // 0xBC0
	
		// Properties
		public int sortingLayerID { get; set; } // 0x00000001803D3770-0x00000001803D37A0 0x00000001803D3950-0x00000001803D3980
		public int sortingOrder { get; set; } // 0x00000001803D37A0-0x00000001803D37D0 0x00000001803D3980-0x00000001803D39B0
		public override bool autoSizeTextContainer { get; set; } // 0x00000001803D3560-0x00000001803D3570 0x00000001803D3860-0x00000001803D3940
		[Obsolete] // 0x0000000180131E80-0x0000000180131EB0
		public TextContainer textContainer { get; } // 0x0000000180207150-0x0000000180207160 
		public new Transform transform { get; } // 0x00000001803D37D0-0x00000001803D3860 
		public Renderer renderer { get; } // 0x00000001803D36E0-0x00000001803D3770 
		public override Mesh mesh { get; } // 0x00000001803D3610-0x00000001803D36E0 
		public MeshFilter meshFilter { get; } // 0x00000001803D3580-0x00000001803D3610 
		public MaskingTypes maskType { get; set; } // 0x00000001803D3570-0x00000001803D3580 0x00000001803D3940-0x00000001803D3950
	
		// Constructors
		public TextMeshPro(); // 0x00000001803D34C0-0x00000001803D3560
	
		// Methods
		protected override void Awake(); // 0x00000001803C0640-0x00000001803C0BA0
		protected override void OnEnable(); // 0x00000001803CDF20-0x00000001803CE080
		protected override void OnDisable(); // 0x00000001803CDEB0-0x00000001803CDF20
		protected override void OnDestroy(); // 0x00000001803CDDC0-0x00000001803CDE90
		protected override void LoadFontAsset(); // 0x00000001803CD7F0-0x00000001803CDDC0
		private void UpdateEnvMapMatrix(); // 0x00000001803D25E0-0x00000001803D2940
		private void SetMask(MaskingTypes maskType); // 0x00000001803D1540-0x00000001803D1700
		private void SetMaskCoordinates(Vector4 coords); // 0x00000001803D1380-0x00000001803D1420
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY); // 0x00000001803D1420-0x00000001803D1540
		private void EnableMasking(); // 0x00000001803C1460-0x00000001803C15B0
		private void DisableMasking(); // 0x00000001803C1310-0x00000001803C1460
		private void UpdateMask(); // 0x00000001803D2980-0x00000001803D2AB0
		protected override Material GetMaterial(Material mat); // 0x00000001803CCF20-0x00000001803CD040
		protected override Material[] GetMaterials(Material[] mats); // 0x00000001803CD040-0x00000001803CD200
		protected override void SetSharedMaterial(Material mat); // 0x00000001803D2020-0x00000001803D2070
		protected override Material[] GetSharedMaterials(); // 0x00000001803CD430-0x00000001803CD5D0
		protected override void SetSharedMaterials(Material[] materials); // 0x00000001803D2070-0x00000001803D24B0
		protected override void SetOutlineThickness(float thickness); // 0x00000001803D1C90-0x00000001803D1E00
		protected override void SetFaceColor(Color32 color); // 0x00000001803D11B0-0x00000001803D12E0
		protected override void SetOutlineColor(Color32 color); // 0x00000001803D1B60-0x00000001803D1C90
		private void CreateMaterialInstance(); // 0x00000001803C1250-0x00000001803C1310
		protected override void SetShaderDepth(); // 0x00000001803D1ED0-0x00000001803D2020
		protected override void SetCulling(); // 0x00000001803D0E00-0x00000001803D11B0
		private void SetPerspectiveCorrection(); // 0x00000001803D1E00-0x00000001803D1ED0
		protected override float GetPaddingForMaterial(Material mat); // 0x00000001803CD200-0x00000001803CD2E0
		protected override float GetPaddingForMaterial(); // 0x00000001803CD2E0-0x00000001803CD430
		protected override int SetArraySizes(UnicodeChar[] chars); // 0x00000001803CE570-0x00000001803D0E00
		public override void ComputeMarginSize(); // 0x00000001803C1120-0x00000001803C1250
		protected override void OnDidApplyAnimationProperties(); // 0x00000001803CDE90-0x00000001803CDEB0
		protected override void OnTransformParentChanged(); // 0x00000001803CE280-0x00000001803CE2C0
		protected override void OnRectTransformDimensionsChange(); // 0x00000001803CE230-0x00000001803CE280
		internal override void InternalUpdate(); // 0x00000001803CD710-0x00000001803CD7F0
		private void OnPreRenderObject(); // 0x00000001803CE080-0x00000001803CE230
		protected override void GenerateTextMesh(); // 0x00000001803C15E0-0x00000001803CCA80
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x00000001803CD5D0-0x00000001803CD680
		private void SetMeshFilters(bool state); // 0x00000001803D18B0-0x00000001803D1B60
		protected override void SetActiveSubMeshes(bool state); // 0x00000001803CE3B0-0x00000001803CE520
		protected override void ClearSubMeshObjects(); // 0x00000001803C0F80-0x00000001803C1120
		protected override Bounds GetCompoundBounds(); // 0x00000001803CCA80-0x00000001803CCF20
		private void UpdateSDFScale(float scaleDelta); // 0x00000001803D2D50-0x00000001803D3050
		protected override void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x00000001803BFFF0-0x00000001803C0640
		public void SetMask(MaskingTypes type, Vector4 maskCoords); // 0x00000001803D1810-0x00000001803D18B0
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY); // 0x00000001803D1700-0x00000001803D1810
		public override void SetVerticesDirty(); // 0x00000001803D24B0-0x00000001803D25E0
		public override void SetLayoutDirty(); // 0x00000001803D12E0-0x00000001803D1380
		public override void SetMaterialDirty(); // 0x00000001801FE170-0x00000001801FE190
		public override void SetAllDirty(); // 0x00000001803CE520-0x00000001803CE570
		public override void Rebuild(CanvasUpdate update); // 0x00000001803CE2C0-0x00000001803CE3B0
		protected override void UpdateMaterial(); // 0x00000001803D2AB0-0x00000001803D2C20
		public override void UpdateMeshPadding(); // 0x00000001803D2C20-0x00000001803D2D50
		public override void ForceMeshUpdate(); // 0x00000001803C15B0-0x00000001803C15C0
		public override void ForceMeshUpdate(bool ignoreInactive); // 0x00000001803C15C0-0x00000001803C15E0
		public override TMP_TextInfo GetTextInfo(string text); // 0x00000001803CD680-0x00000001803CD710
		public override void ClearMesh(bool updateMesh); // 0x00000001803C0E20-0x00000001803C0F80
		public override void UpdateGeometry(Mesh mesh, int index); // 0x00000001803D2960-0x00000001803D2980
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x00000001803D3050-0x00000001803D3290
		public override void UpdateVertexData(); // 0x00000001803D3290-0x00000001803D34C0
		public void UpdateFontAsset(); // 0x00000001803D2940-0x00000001803D2960
		public void CalculateLayoutInputHorizontal(); // 0x00000001803C0BA0-0x00000001803C0CF0
		public void CalculateLayoutInputVertical(); // 0x00000001803C0CF0-0x00000001803C0E20
	}

	[AddComponentMenu] // 0x0000000180131F70-0x0000000180132030
	[DisallowMultipleComponent] // 0x0000000180131F70-0x0000000180132030
	[ExecuteAlways] // 0x0000000180131F70-0x0000000180132030
	[RequireComponent] // 0x0000000180131F70-0x0000000180132030
	[RequireComponent] // 0x0000000180131F70-0x0000000180132030
	public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 4289
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_hasFontAssetChanged; // 0xB38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_SubMeshUI[] m_subTextObjects; // 0xB40
		private float m_previousLossyScaleY; // 0xB48
		private Vector3[] m_RectTransformCorners; // 0xB50
		private CanvasRenderer m_canvasRenderer; // 0xB58
		private Canvas m_canvas; // 0xB60
		private bool m_isFirstAllocation; // 0xB68
		private int m_max_characters; // 0xB6C
		private bool m_isMaskingEnabled; // 0xB70
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material m_baseMaterial; // 0xB78
		private bool m_isScrollRegionSet; // 0xB80
		private int m_stencilID; // 0xB84
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Vector4 m_maskOffset; // 0xB88
		private Matrix4x4 m_EnvMapMatrix; // 0xB98
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0xBD8
		private int m_recursiveCountA; // 0xBDC
		private int loopCountA; // 0xBE0
		private bool m_isRebuildingLayout; // 0xBE4
	
		// Properties
		public override Material materialForRendering { get; } // 0x0000000180877C60-0x0000000180877CD0 
		public override bool autoSizeTextContainer { get; set; } // 0x00000001803D3560-0x00000001803D3570 0x0000000180877CD0-0x0000000180877D60
		public override Mesh mesh { get; } // 0x0000000180217310-0x0000000180217320 
		public new CanvasRenderer canvasRenderer { get; } // 0x0000000180877BC0-0x0000000180877C50 
		public Vector4 maskOffset { get; set; } // 0x0000000180877C50-0x0000000180877C60 0x0000000180877D60-0x0000000180877DB0
	
		// Constructors
		public TextMeshProUGUI(); // 0x0000000180877B20-0x0000000180877BC0
	
		// Methods
		protected override void Awake(); // 0x00000001808643F0-0x00000001808647D0
		protected override void OnEnable(); // 0x0000000180871FD0-0x0000000180872200
		protected override void OnDisable(); // 0x0000000180871E10-0x0000000180871FD0
		protected override void OnDestroy(); // 0x0000000180871C80-0x0000000180871DD0
		protected override void LoadFontAsset(); // 0x0000000180871580-0x0000000180871C50
		private Canvas GetCanvas(); // 0x00000001808703C0-0x0000000180870500
		private void UpdateEnvMapMatrix(); // 0x0000000180876430-0x0000000180876790
		private void EnableMasking(); // 0x0000000180864CC0-0x0000000180864EF0
		private void DisableMasking(); // 0x0000000180864B80-0x0000000180864CC0
		private void UpdateMask(); // 0x0000000180876830-0x0000000180876E70
		protected override Material GetMaterial(Material mat); // 0x00000001808709A0-0x0000000180870AF0
		protected override Material[] GetMaterials(Material[] mats); // 0x0000000180870AF0-0x0000000180870CB0
		protected override void SetSharedMaterial(Material mat); // 0x00000001803D2020-0x00000001803D2070
		protected override Material[] GetSharedMaterials(); // 0x0000000180870FB0-0x0000000180871150
		protected override void SetSharedMaterials(Material[] materials); // 0x0000000180875E00-0x0000000180876340
		protected override void SetOutlineThickness(float thickness); // 0x00000001808759A0-0x0000000180875BC0
		protected override void SetFaceColor(Color32 color); // 0x00000001808754E0-0x0000000180875610
		protected override void SetOutlineColor(Color32 color); // 0x0000000180875870-0x00000001808759A0
		protected override void SetShaderDepth(); // 0x0000000180875C90-0x0000000180875E00
		protected override void SetCulling(); // 0x00000001808750F0-0x00000001808754E0
		private void SetPerspectiveCorrection(); // 0x0000000180875BC0-0x0000000180875C90
		protected override float GetPaddingForMaterial(Material mat); // 0x0000000180870ED0-0x0000000180870FB0
		protected override float GetPaddingForMaterial(); // 0x0000000180870E00-0x0000000180870ED0
		private void SetMeshArrays(int size); // 0x00000001808757E0-0x0000000180875870
		protected override int SetArraySizes(UnicodeChar[] chars); // 0x0000000180872850-0x00000001808750F0
		public override void ComputeMarginSize(); // 0x0000000180864A20-0x0000000180864B50
		protected override void OnDidApplyAnimationProperties(); // 0x0000000180871DD0-0x0000000180871E10
		protected override void OnCanvasHierarchyChanged(); // 0x0000000180871C50-0x0000000180871C80
		protected override void OnTransformParentChanged(); // 0x00000001808725A0-0x00000001808725F0
		protected override void OnRectTransformDimensionsChange(); // 0x0000000180872410-0x00000001808725A0
		internal override void InternalUpdate(); // 0x00000001808714A0-0x0000000180871580
		private void OnPreRenderCanvas(); // 0x0000000180872200-0x0000000180872410
		protected override void GenerateTextMesh(); // 0x0000000180864F20-0x00000001808703C0
		protected override Vector3[] GetTextContainerLocalCorners(); // 0x0000000180871150-0x0000000180871200
		protected override void SetActiveSubMeshes(bool state); // 0x00000001808726E0-0x0000000180872850
		protected override Bounds GetCompoundBounds(); // 0x0000000180870500-0x00000001808709A0
		private void UpdateSDFScale(float scaleDelta); // 0x0000000180877100-0x00000001808774B0
		protected override void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x0000000180863DA0-0x00000001808643F0
		public void CalculateLayoutInputHorizontal(); // 0x00000001808647D0-0x0000000180864850
		public void CalculateLayoutInputVertical(); // 0x0000000180864850-0x00000001808648E0
		public override void SetVerticesDirty(); // 0x0000000180876340-0x0000000180876430
		public override void SetLayoutDirty(); // 0x0000000180875610-0x0000000180875700
		public override void SetMaterialDirty(); // 0x0000000180875700-0x00000001808757E0
		public override void SetAllDirty(); // 0x00000001803CE520-0x00000001803CE570
		public override void Rebuild(CanvasUpdate update); // 0x00000001808725F0-0x00000001808726E0
		private void UpdateSubObjectPivot(); // 0x00000001808774B0-0x00000001808775E0
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x0000000180870CB0-0x0000000180870E00
		protected override void UpdateMaterial(); // 0x0000000180876E70-0x0000000180876FD0
		public override void RecalculateClipping(); // 0x00000001801FE140-0x00000001801FE150
		public override void RecalculateMasking(); // 0x00000001801FE150-0x00000001801FE170
		public override void Cull(Rect clipRect, bool validRect); // 0x0000000180864B50-0x0000000180864B80
		public override void UpdateMeshPadding(); // 0x0000000180876FD0-0x0000000180877100
		protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x00000001808713C0-0x00000001808714A0
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x0000000180871300-0x00000001808713C0
		public override void ForceMeshUpdate(); // 0x0000000180864F10-0x0000000180864F20
		public override void ForceMeshUpdate(bool ignoreInactive); // 0x0000000180864EF0-0x0000000180864F10
		public override TMP_TextInfo GetTextInfo(string text); // 0x0000000180871200-0x0000000180871300
		public override void ClearMesh(); // 0x00000001808648E0-0x0000000180864A20
		public override void UpdateGeometry(Mesh mesh, int index); // 0x0000000180876790-0x0000000180876830
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x00000001808775E0-0x0000000180877880
		public override void UpdateVertexData(); // 0x0000000180877880-0x0000000180877B20
		public void UpdateFontAsset(); // 0x00000001803D2940-0x00000001803D2960
	}

	public enum TextOverflowModes // TypeDefIndex: 4253
	{
		Overflow = 0,
		Ellipsis = 1,
		Masking = 2,
		Truncate = 3,
		ScrollRect = 4,
		Page = 5,
		Linked = 6
	}

	public enum TextRenderFlags // TypeDefIndex: 4250
	{
		DontRender = 0,
		Render = 255
	}
}

namespace Placemaker
{
	public static class TextSaveAlphabet // TypeDefIndex: 4632
	{
		// Fields
		public static readonly string alphabet; // 0x00
		public const int baseLength = 64; // Metadata: 0x0021FED4
		public static readonly Dictionary<char, int> alphabetDict; // 0x08
	
		// Constructors
		static TextSaveAlphabet(); // 0x0000000180B40C20-0x0000000180B40D00
	}
}

namespace Placemaker.Ui
{
	public class TextSaveButtons : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4715
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string lastSaveString; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private SimpleMessage copyMessage; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private SimpleMessage loadMessage; // 0x30
	
		// Constructors
		public TextSaveButtons(); // 0x00000001802797F0-0x0000000180279800
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		public void Button_CopyToClipboard(); // 0x0000000180B7B580-0x0000000180B7B820
		public void Button_LoadFromClipboard(); // 0x0000000180B7B820-0x0000000180B7BB00
	}
}

namespace Placemaker
{
	public class TextSaveSystem : MonoBehaviour // TypeDefIndex: 4633
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		private static BitArray bitArray; // 0x00
		private static char[] chars; // 0x08
		private static readonly int bitsPerCharacter; // 0x10
		private const int bitCountBitCount = 5; // Metadata: 0x0021FED8
		private const int typeCountBitCount = 4; // Metadata: 0x0021FEDC
	
		// Nested types
		public interface ITextSaver // TypeDefIndex: 4634
		{
			// Methods
			void SaveToText(List<int> values);
			void LoadFromText(BitArray bitArray, ref int bitIndex);
		}
	
		// Constructors
		public TextSaveSystem(); // 0x00000001801D0210-0x00000001801D0220
		static TextSaveSystem(); // 0x0000000180B42C80-0x0000000180B42D30
	
		// Methods
		public static string GetSpacedString(string srcString); // 0x0000000180B40DB0-0x0000000180B41010
		private static int GetBitsPerCharacter(); // 0x0000000180B40D90-0x0000000180B40DB0
		public static void AddValue(List<int> values, int value, int bitCount); // 0x0000000180B40D00-0x0000000180B40D70
		public static int ReadValue(BitArray bitArray, ref int index, int bitCount); // 0x0000000180B41AC0-0x0000000180B41DF0
		private static int GetBitCount(int biggestValue); // 0x0000000180B40D70-0x0000000180B40D90
		public static string SaveToString(List<SaveData.C> corners, List<SaveData.V> voxels); // 0x0000000180B41DF0-0x0000000180B42C80
		public static bool LoadFromString(string saveString, List<SaveData.C> corners, List<SaveData.V> voxels); // 0x0000000180B41010-0x0000000180B419D0
		private void LogBitArray(int bitCount); // 0x0000000180B419D0-0x0000000180B41AC0
	}
}

namespace TMPro
{
	public enum TextureMappingOptions // TypeDefIndex: 4255
	{
		Character = 0,
		Line = 1,
		Paragraph = 2,
		MatchAspect = 3
	}
}

namespace TMPro.SpriteAssetUtilities
{
	public class TexturePacker // TypeDefIndex: 4293
	{
		// Nested types
		[Serializable]
		public struct SpriteFrame // TypeDefIndex: 4294
		{
			// Fields
			public float x; // 0x00
			public float y; // 0x04
			public float w; // 0x08
			public float h; // 0x0C
	
			// Methods
			public override string ToString(); // 0x0000000180002D00-0x0000000180002D10
		}
	
		[Serializable]
		public struct SpriteSize // TypeDefIndex: 4295
		{
			// Fields
			public float w; // 0x00
			public float h; // 0x04
	
			// Methods
			public override string ToString(); // 0x0000000180002D10-0x0000000180002DB0
		}
	
		[Serializable]
		public struct SpriteData // TypeDefIndex: 4296
		{
			// Fields
			public string filename; // 0x00
			public SpriteFrame frame; // 0x08
			public bool rotated; // 0x18
			public bool trimmed; // 0x19
			public SpriteFrame spriteSourceSize; // 0x1C
			public SpriteSize sourceSize; // 0x2C
			public Vector2 pivot; // 0x34
		}
	
		[Serializable]
		public class SpriteDataObject // TypeDefIndex: 4297
		{
			// Fields
			public List<SpriteData> frames; // 0x10
	
			// Constructors
			public SpriteDataObject(); // 0x00000001801D0660-0x00000001801D0670
		}
	
		// Constructors
		public TexturePacker(); // 0x00000001801D0660-0x00000001801D0670
	}
}

namespace CielaSpike
{
	public static class ThreadNinjaMonoBehaviourExtensions // TypeDefIndex: 4940
	{
		// Extension methods
		public static Coroutine StartCoroutineAsync(this MonoBehaviour behaviour, IEnumerator routine, out CielaSpike.Task task); // 0x00000001805DED10-0x00000001805DEDA0
		public static Coroutine StartCoroutineAsync(this MonoBehaviour behaviour, IEnumerator routine); // 0x00000001805DEC90-0x00000001805DED10
	}
}

namespace Placemaker.Ui
{
	public class TimescaleButton : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4716
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasGroup tick; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UpdateState state; // 0x28
	
		// Constructors
		public TimescaleButton(); // 0x0000000180B7BDA0-0x0000000180B7BE00
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x00000001801D0280-0x00000001801D0290
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B7BB80-0x0000000180B7BC30
		public void Button_Toggle0(); // 0x0000000180B7BB00-0x0000000180B7BB80
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private void <Placemaker.Ui.UiMaster.IUiSetup.OnSetup>b__4_0(float x); // 0x0000000180B7BC30-0x0000000180B7BDA0
	}
}

namespace TMPro
{
	[Serializable]
	public class TMP_Asset : ScriptableObject // TypeDefIndex: 4148
	{
		// Fields
		public int hashCode; // 0x18
		public Material material; // 0x20
		public int materialHashCode; // 0x28
	
		// Constructors
		public TMP_Asset(); // 0x00000001801D5C70-0x00000001801D5C80
	}

	[Serializable]
	public class TMP_Character : TMP_TextElement // TypeDefIndex: 4149
	{
		// Constructors
		public TMP_Character(); // 0x00000001801D5CE0-0x00000001801D5D10
		public TMP_Character(uint unicode, Glyph glyph); // 0x00000001801D5C80-0x00000001801D5CE0
		internal TMP_Character(uint unicode, uint glyphIndex); // 0x00000001801D5D10-0x00000001801D5D60
	}

	public struct TMP_CharacterInfo // TypeDefIndex: 4151
	{
		// Fields
		public char character; // 0x00
		public int index; // 0x04
		public int stringLength; // 0x08
		public TMP_TextElementType elementType; // 0x0C
		public TMP_TextElement textElement; // 0x10
		public TMP_FontAsset fontAsset; // 0x18
		public TMP_SpriteAsset spriteAsset; // 0x20
		public int spriteIndex; // 0x28
		public Material material; // 0x30
		public int materialReferenceIndex; // 0x38
		public bool isUsingAlternateTypeface; // 0x3C
		public float pointSize; // 0x40
		public int lineNumber; // 0x44
		public int pageNumber; // 0x48
		public int vertexIndex; // 0x4C
		public TMP_Vertex vertex_BL; // 0x50
		public TMP_Vertex vertex_TL; // 0x78
		public TMP_Vertex vertex_TR; // 0xA0
		public TMP_Vertex vertex_BR; // 0xC8
		public Vector3 topLeft; // 0xF0
		public Vector3 bottomLeft; // 0xFC
		public Vector3 topRight; // 0x108
		public Vector3 bottomRight; // 0x114
		public float origin; // 0x120
		public float ascender; // 0x124
		public float baseLine; // 0x128
		public float descender; // 0x12C
		public float xAdvance; // 0x130
		public float aspectRatio; // 0x134
		public float scale; // 0x138
		public Color32 color; // 0x13C
		public Color32 underlineColor; // 0x140
		public Color32 strikethroughColor; // 0x144
		public Color32 highlightColor; // 0x148
		public FontStyles style; // 0x14C
		public bool isVisible; // 0x150
	}

	[Serializable]
	public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 4153
	{
		// Fields
		public ColorMode colorMode; // 0x18
		public Color topLeft; // 0x1C
		public Color topRight; // 0x2C
		public Color bottomLeft; // 0x3C
		public Color bottomRight; // 0x4C
		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient; // Metadata: 0x0021F3FD
		private static readonly Color k_DefaultColor; // 0x00
	
		// Constructors
		public TMP_ColorGradient(); // 0x00000001801D5E70-0x00000001801D5F30
		public TMP_ColorGradient(Color color); // 0x00000001801D5DB0-0x00000001801D5E00
		public TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3); // 0x00000001801D5E00-0x00000001801D5E70
		static TMP_ColorGradient(); // 0x00000001801D5D60-0x00000001801D5DB0
	}

	public static class TMP_DefaultControls // TypeDefIndex: 4162
	{
		// Fields
		private const float kWidth = 160f; // Metadata: 0x0021F40D
		private const float kThickHeight = 30f; // Metadata: 0x0021F411
		private const float kThinHeight = 20f; // Metadata: 0x0021F415
		private static Vector2 s_ThickElementSize; // 0x00
		private static Vector2 s_ThinElementSize; // 0x08
		private static Color s_DefaultSelectableColor; // 0x10
		private static Color s_TextColor; // 0x20
	
		// Nested types
		public struct Resources // TypeDefIndex: 4163
		{
			// Fields
			public Sprite standard; // 0x00
			public Sprite background; // 0x08
			public Sprite inputField; // 0x10
			public Sprite knob; // 0x18
			public Sprite checkmark; // 0x20
			public Sprite dropdown; // 0x28
			public Sprite mask; // 0x30
		}
	
		// Constructors
		static TMP_DefaultControls(); // 0x00000001801D7F80-0x00000001801D80D0
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size); // 0x00000001801D7B20-0x00000001801D7BC0
		private static GameObject CreateUIObject(string name, GameObject parent); // 0x00000001801D7BC0-0x00000001801D7C70
		private static void SetDefaultTextValues(TMP_Text lbl); // 0x00000001801D7D10-0x00000001801D7DB0
		private static void SetDefaultColorTransitionValues(Selectable slider); // 0x00000001801D7C70-0x00000001801D7D10
		private static void SetParentAndAlign(GameObject child, GameObject parent); // 0x00000001801D7E90-0x00000001801D7F80
		private static void SetLayerRecursively(GameObject go, int layer); // 0x00000001801D7DB0-0x00000001801D7E90
		public static GameObject CreateScrollbar(Resources resources); // 0x00000001801D7750-0x00000001801D7A50
		public static GameObject CreateButton(Resources resources); // 0x00000001801D5F30-0x00000001801D6170
		public static GameObject CreateText(Resources resources); // 0x00000001801D7A50-0x00000001801D7B20
		public static GameObject CreateInputField(Resources resources); // 0x00000001801D7090-0x00000001801D7750
		public static GameObject CreateDropdown(Resources resources); // 0x00000001801D6170-0x00000001801D7090
	}

	[AddComponentMenu] // 0x0000000180128EB0-0x0000000180128F30
	[RequireComponent] // 0x0000000180128EB0-0x0000000180128F30
	public class TMP_Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 4164
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RectTransform m_Template; // 0xF0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_Text m_CaptionText; // 0xF8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Image m_CaptionImage; // 0x100
		[SerializeField] // 0x0000000180128FC0-0x0000000180128FF0
		[Space] // 0x0000000180128FC0-0x0000000180128FF0
		private TMP_Text m_ItemText; // 0x108
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Image m_ItemImage; // 0x110
		[SerializeField] // 0x0000000180128FC0-0x0000000180128FF0
		[Space] // 0x0000000180128FC0-0x0000000180128FF0
		private int m_Value; // 0x118
		[SerializeField] // 0x0000000180128FC0-0x0000000180128FF0
		[Space] // 0x0000000180128FC0-0x0000000180128FF0
		private OptionDataList m_Options; // 0x120
		[SerializeField] // 0x0000000180128FC0-0x0000000180128FF0
		[Space] // 0x0000000180128FC0-0x0000000180128FF0
		private DropdownEvent m_OnValueChanged; // 0x128
		private GameObject m_Dropdown; // 0x130
		private GameObject m_Blocker; // 0x138
		private List<DropdownItem> m_Items; // 0x140
		private TMPro.TweenRunner<TMPro.FloatTween> m_AlphaTweenRunner; // 0x148
		private bool validTemplate; // 0x150
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get; set; } // 0x00000001801DAE50-0x00000001801DAE60 0x00000001801DAEF0-0x00000001801DAF00
		public TMP_Text captionText { get; set; } // 0x00000001801DADF0-0x00000001801DAE00 0x00000001801DAE80-0x00000001801DAE90
		public Image captionImage { get; set; } // 0x00000001801DADE0-0x00000001801DADF0 0x00000001801DAE70-0x00000001801DAE80
		public TMP_Text itemText { get; set; } // 0x00000001801DAE10-0x00000001801DAE20 0x00000001801DAEA0-0x00000001801DAEB0
		public Image itemImage { get; set; } // 0x00000001801DAE00-0x00000001801DAE10 0x00000001801DAE90-0x00000001801DAEA0
		public List<OptionData> options { get; set; } // 0x00000001801DAE30-0x00000001801DAE50 0x00000001801DAEC0-0x00000001801DAEF0
		public DropdownEvent onValueChanged { get; set; } // 0x00000001801DAE20-0x00000001801DAE30 0x00000001801DAEB0-0x00000001801DAEC0
		public int value { get; set; } // 0x00000001801DAE60-0x00000001801DAE70 0x00000001801DAF00-0x00000001801DAF10
		public bool IsExpanded { get; } // 0x00000001801DAD80-0x00000001801DADE0 
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 4165
		{
			// Fields
			[SerializeField] // 0x0000000180110980-0x0000000180110990
			private TMP_Text m_Text; // 0x18
			[SerializeField] // 0x0000000180110980-0x0000000180110990
			private Image m_Image; // 0x20
			[SerializeField] // 0x0000000180110980-0x0000000180110990
			private RectTransform m_RectTransform; // 0x28
			[SerializeField] // 0x0000000180110980-0x0000000180110990
			private Toggle m_Toggle; // 0x30
	
			// Properties
			public TMP_Text text { get; set; } // 0x00000001801D0240-0x00000001801D0250 0x00000001801D0280-0x00000001801D0290
			public Image image { get; set; } // 0x00000001801D0220-0x00000001801D0230 0x00000001801D0260-0x00000001801D0270
			public RectTransform rectTransform { get; set; } // 0x00000001801D0230-0x00000001801D0240 0x00000001801D0270-0x00000001801D0280
			public Toggle toggle { get; set; } // 0x00000001801D0250-0x00000001801D0260 0x00000001801D0290-0x00000001801D0660
	
			// Constructors
			public DropdownItem(); // 0x00000001801D0210-0x00000001801D0220
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData); // 0x00000001801D0190-0x00000001801D0210
			public virtual void OnCancel(BaseEventData eventData); // 0x00000001801D0100-0x00000001801D0190
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 4166
		{
			// Fields
			[SerializeField] // 0x0000000180110980-0x0000000180110990
			private string m_Text; // 0x10
			[SerializeField] // 0x0000000180110980-0x0000000180110990
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get; set; } // 0x00000001801D2960-0x00000001801D2970 0x00000001801D2970-0x00000001801D2980
			public Sprite image { get; set; } // 0x00000001801D0240-0x00000001801D0250 0x00000001801D0280-0x00000001801D0290
	
			// Constructors
			public OptionData(); // 0x00000001801D0660-0x00000001801D0670
			public OptionData(string text); // 0x00000001801D29B0-0x00000001801D29E0
			public OptionData(Sprite image); // 0x00000001801D2980-0x00000001801D29B0
			public OptionData(string text, Sprite image); // 0x00000001801D29E0-0x00000001801D2A20
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 4167
		{
			// Fields
			[SerializeField] // 0x0000000180110980-0x0000000180110990
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get; set; } // 0x00000001801D2960-0x00000001801D2970 0x00000001801D2970-0x00000001801D2980
	
			// Constructors
			public OptionDataList(); // 0x00000001801D2900-0x00000001801D2960
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 4168
		{
			// Constructors
			public DropdownEvent(); // 0x00000001801D00C0-0x00000001801D0100
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass60_0 // TypeDefIndex: 4169
		{
			// Fields
			public DropdownItem item; // 0x10
			public TMP_Dropdown <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass60_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Show>b__0(bool x); // 0x00000001801F35A0-0x00000001801F36E0
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <DelayedDestroyDropdownList>d__72 : IEnumerator<object> // TypeDefIndex: 4170
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float delay; // 0x20
			public TMP_Dropdown <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <DelayedDestroyDropdownList>d__72(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x00000001801F3340-0x00000001801F33F0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x00000001801F33F0-0x00000001801F3440
		}
	
		// Constructors
		protected TMP_Dropdown(); // 0x00000001801DAC50-0x00000001801DAD80
		static TMP_Dropdown(); // 0x00000001801DABF0-0x00000001801DAC50
	
		// Methods
		public void SetValueWithoutNotify(int input); // 0x00000001801D9690-0x00000001801D96A0
		private void SetValue(int value, bool sendCallback = true /* Metadata: 0x0021F419 */); // 0x00000001801D96A0-0x00000001801D97D0
		protected override void Awake(); // 0x00000001801D8820-0x00000001801D8970
		protected override void Start(); // 0x00000001801DABD0-0x00000001801DABF0
		protected override void OnDisable(); // 0x00000001801D91F0-0x00000001801D9290
		public void RefreshShownValue(); // 0x00000001801D93D0-0x00000001801D95E0
		public void AddOptions(List<OptionData> options); // 0x00000001801D8380-0x00000001801D83F0
		public void AddOptions(List<string> options); // 0x00000001801D84E0-0x00000001801D85D0
		public void AddOptions(List<Sprite> options); // 0x00000001801D83F0-0x00000001801D84E0
		public void ClearOptions(); // 0x00000001801D8970-0x00000001801D89E0
		private void SetupTemplate(); // 0x00000001801D97D0-0x00000001801D9CB0
		private static T GetOrAddComponent<T>(GameObject go)
			where T : Component;
		public virtual void OnPointerClick(PointerEventData eventData); // 0x00000001801D9290-0x00000001801D92A0
		public virtual void OnSubmit(BaseEventData eventData); // 0x00000001801D9290-0x00000001801D92A0
		public virtual void OnCancel(BaseEventData eventData); // 0x00000001801D91E0-0x00000001801D91F0
		public void Show(); // 0x00000001801D9CB0-0x00000001801DABD0
		protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x00000001801D89E0-0x00000001801D8C90
		protected virtual void DestroyBlocker(GameObject blocker); // 0x00000001801D8DC0-0x00000001801D8E20
		protected virtual GameObject CreateDropdownList(GameObject template); // 0x00000001801D8C90-0x00000001801D8CF0
		protected virtual void DestroyDropdownList(GameObject dropdownList); // 0x00000001801D8E20-0x00000001801D8E80
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate); // 0x00000001801D8CF0-0x00000001801D8D50
		protected virtual void DestroyItem(DropdownItem item); // 0x00000001801D8E80-0x00000001801D8E90
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items); // 0x00000001801D80D0-0x00000001801D8380
		private void AlphaFadeList(float duration, float alpha); // 0x00000001801D8790-0x00000001801D8820
		private void AlphaFadeList(float duration, float start, float end); // 0x00000001801D85D0-0x00000001801D8790
		private void SetAlpha(float alpha); // 0x00000001801D95E0-0x00000001801D9690
		public void Hide(); // 0x00000001801D8E90-0x00000001801D9050
		[IteratorStateMachine] // 0x0000000180128FF0-0x0000000180129040
		private IEnumerator DelayedDestroyDropdownList(float delay); // 0x00000001801D8D50-0x00000001801D8DC0
		private void ImmediateDestroyDropdownList(); // 0x00000001801D9050-0x00000001801D91E0
		private void OnSelectItem(Toggle toggle); // 0x00000001801D92A0-0x00000001801D93D0
	}

	[Serializable]
	public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 4172
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_Version; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		internal string m_SourceFontFileGUID; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Font m_SourceFontFile; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private FaceInfo m_FaceInfo; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Glyph> m_GlyphTable; // 0xA8
		private Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<TMP_Character> m_CharacterTable; // 0xB8
		private Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC0
		private Texture2D m_AtlasTexture; // 0xC8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Texture2D[] m_AtlasTextures; // 0xD0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		internal int m_AtlasTextureIndex; // 0xD8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<GlyphRect> m_UsedGlyphRects; // 0xE0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<GlyphRect> m_FreeGlyphRects; // 0xE8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private FaceInfo_Legacy m_fontInfo; // 0xF0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Texture2D atlas; // 0xF8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int m_AtlasWidth; // 0x100
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int m_AtlasHeight; // 0x104
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int m_AtlasPadding; // 0x108
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private GlyphRenderMode m_AtlasRenderMode; // 0x10C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		internal List<TMP_Glyph> m_glyphInfoList; // 0x110
		[FormerlySerializedAs] // 0x00000001801295E0-0x0000000180129620
		[SerializeField] // 0x00000001801295E0-0x0000000180129620
		internal KerningTable m_KerningTable; // 0x118
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_FontFeatureTable m_FontFeatureTable; // 0x120
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<TMP_FontAsset> fallbackFontAssets; // 0x128
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x130
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		internal FontAssetCreationSettings m_CreationSettings; // 0x138
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_FontWeightPair[] fontWeights; // 0x198
		public float normalStyle; // 0x1A0
		public float normalSpacingOffset; // 0x1A4
		public float boldStyle; // 0x1A8
		public float boldSpacing; // 0x1AC
		public byte italicStyle; // 0x1B0
		public byte tabSize; // 0x1B1
		private byte m_oldTabSize; // 0x1B2
		internal bool m_IsFontAssetLookupTablesDirty; // 0x1B3
		private List<Glyph> m_GlyphsToPack; // 0x1B8
		private List<Glyph> m_GlyphsPacked; // 0x1C0
		private List<Glyph> m_GlyphsToRender; // 0x1C8
		private List<uint> m_GlyphIndexList; // 0x1D0
		private List<TMP_Character> m_CharactersToAdd; // 0x1D8
		internal static uint[] s_GlyphIndexArray; // 0x00
		internal static List<uint> s_MissingCharacterList; // 0x08
	
		// Properties
		public string version { get; internal set; } // 0x00000001801D0250-0x00000001801D0260 0x00000001801D0290-0x00000001801D0660
		public Font sourceFontFile { get; internal set; } // 0x00000001801E2210-0x00000001801E2220 0x00000001801E2380-0x00000001801E2390
		public AtlasPopulationMode atlasPopulationMode { get; set; } // 0x00000001801E1FD0-0x00000001801E1FE0 0x00000001801E2250-0x00000001801E2260
		public FaceInfo faceInfo { get; internal set; } // 0x00000001801E2150-0x00000001801E2190 0x00000001801E22F0-0x00000001801E2330
		public List<Glyph> glyphTable { get; internal set; } // 0x00000001801E2200-0x00000001801E2210 0x00000001801E2370-0x00000001801E2380
		public Dictionary<uint, Glyph> glyphLookupTable { get; } // 0x00000001801E21D0-0x00000001801E2200 
		public List<TMP_Character> characterTable { get; internal set; } // 0x00000001801E20F0-0x00000001801E2100 0x00000001801E2290-0x00000001801E22A0
		public Dictionary<uint, TMP_Character> characterLookupTable { get; } // 0x00000001801E20C0-0x00000001801E20F0 
		public Texture2D atlasTexture { get; } // 0x00000001801E1FF0-0x00000001801E20A0 
		public Texture2D[] atlasTextures { get; set; } // 0x00000001801E20A0-0x00000001801E20B0 0x00000001801E2270-0x00000001801E2280
		internal List<GlyphRect> usedGlyphRects { get; set; } // 0x00000001801E2220-0x00000001801E2230 0x00000001801E2390-0x00000001801E23A0
		internal List<GlyphRect> freeGlyphRects { get; set; } // 0x00000001801E21C0-0x00000001801E21D0 0x00000001801E2360-0x00000001801E2370
		[Obsolete] // 0x000000018012AC10-0x000000018012AC40
		public FaceInfo_Legacy fontInfo { get; } // 0x00000001801DAE50-0x00000001801DAE60 
		public int atlasWidth { get; internal set; } // 0x00000001801E20B0-0x00000001801E20C0 0x00000001801E2280-0x00000001801E2290
		public int atlasHeight { get; internal set; } // 0x00000001801E1FB0-0x00000001801E1FC0 0x00000001801E2230-0x00000001801E2240
		public int atlasPadding { get; internal set; } // 0x00000001801E1FC0-0x00000001801E1FD0 0x00000001801E2240-0x00000001801E2250
		public GlyphRenderMode atlasRenderMode { get; internal set; } // 0x00000001801E1FE0-0x00000001801E1FF0 0x00000001801E2260-0x00000001801E2270
		public TMP_FontFeatureTable fontFeatureTable { get; internal set; } // 0x00000001801E21A0-0x00000001801E21B0 0x00000001801E2340-0x00000001801E2350
		public List<TMP_FontAsset> fallbackFontAssetTable { get; set; } // 0x00000001801E2190-0x00000001801E21A0 0x00000001801E2330-0x00000001801E2340
		public FontAssetCreationSettings creationSettings { get; set; } // 0x00000001801E2100-0x00000001801E2150 0x00000001801E22A0-0x00000001801E22F0
		public TMP_FontWeightPair[] fontWeightTable { get; internal set; } // 0x00000001801E21B0-0x00000001801E21C0 0x00000001801E2350-0x00000001801E2360
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4173
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<TMP_Character, uint> <>9__100_0; // 0x08
			public static Func<Glyph, uint> <>9__101_0; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001801F3740-0x00000001801F37A0
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal uint <SortCharacterTable>b__100_0(TMP_Character c); // 0x00000001801F3470-0x00000001801F3490
			internal uint <SortGlyphTable>b__101_0(Glyph c); // 0x00000001801F34D0-0x00000001801F34F0
		}
	
		// Constructors
		public TMP_FontAsset(); // 0x00000001801E1DB0-0x00000001801E1FB0
		static TMP_FontAsset(); // 0x00000001801E1D30-0x00000001801E1DB0
	
		// Methods
		public static TMP_FontAsset CreateFontAsset(Font font); // 0x00000001801DC670-0x00000001801DC6F0
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic /* Metadata: 0x0021F422 */); // 0x00000001801DC6F0-0x00000001801DCD70
		private void Awake(); // 0x00000001801DC060-0x00000001801DC0E0
		internal void InitializeDictionaryLookupTables(); // 0x00000001801DD830-0x00000001801DDC50
		public void ReadFontAssetDefinition(); // 0x00000001801DDC50-0x00000001801DE600
		internal void SortCharacterTable(); // 0x00000001801DE600-0x00000001801DE720
		internal void SortGlyphTable(); // 0x00000001801DE940-0x00000001801DEA60
		internal void SortGlyphAndCharacterTables(); // 0x00000001801DE720-0x00000001801DE940
		public bool HasCharacter(int character); // 0x00000001801DD5F0-0x00000001801DD660
		public bool HasCharacter(char character); // 0x00000001801DD580-0x00000001801DD5F0
		public bool HasCharacter(char character, bool searchFallbacks); // 0x00000001801DD170-0x00000001801DD580
		private bool HasCharacter_Internal(char character, bool searchFallbacks); // 0x00000001801DCFF0-0x00000001801DD170
		public bool HasCharacters(string text, out List<char> missingCharacters); // 0x00000001801DD710-0x00000001801DD830
		public bool HasCharacters(string text); // 0x00000001801DD660-0x00000001801DD710
		public static string GetCharacters(TMP_FontAsset fontAsset); // 0x00000001801DCE60-0x00000001801DCF30
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset); // 0x00000001801DCD70-0x00000001801DCE60
		public bool TryAddCharacters(uint[] unicodes); // 0x00000001801E0490-0x00000001801E04B0
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes); // 0x00000001801DF520-0x00000001801DFD30
		public bool TryAddCharacters(string characters); // 0x00000001801DFD30-0x00000001801DFD50
		public bool TryAddCharacters(string characters, out string missingCharacters); // 0x00000001801DFD50-0x00000001801E0490
		internal bool TryAddCharacter_Internal(uint unicode); // 0x00000001801DF130-0x00000001801DF520
		internal TMP_Character AddCharacter_Internal(uint unicode, Glyph glyph); // 0x00000001801DBC60-0x00000001801DC060
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character); // 0x00000001801DEA60-0x00000001801DF130
		internal uint GetGlyphIndex(uint unicode); // 0x00000001801DCF30-0x00000001801DCFF0
		internal void UpdateAtlasTexture(); // 0x00000001801E04B0-0x00000001801E0860
		internal void UpdateGlyphAdjustmentRecords(uint unicode, uint glyphIndex); // 0x00000001801E0860-0x00000001801E0D10
		public void ClearFontAssetData(bool setAtlasSizeToZero = false /* Metadata: 0x0021F426 */); // 0x00000001801DC0E0-0x00000001801DC670
		private void UpgradeFontAsset(); // 0x00000001801E0D10-0x00000001801E19B0
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable(); // 0x00000001801E19B0-0x00000001801E1D30
	}

	public class TMP_FontAssetUtilities // TypeDefIndex: 4187
	{
		// Fields
		private static readonly TMP_FontAssetUtilities s_Instance; // 0x00
		private static List<int> k_SearchedFontAssets; // 0x08
		private static bool k_IsFontEngineInitialized; // 0x10
	
		// Properties
		public static TMP_FontAssetUtilities instance { get; } // 0x00000001801DBC00-0x00000001801DBC60 
	
		// Constructors
		static TMP_FontAssetUtilities(); // 0x00000001801DBBA0-0x00000001801DBC00
		public TMP_FontAssetUtilities(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset); // 0x00000001801DB3A0-0x00000001801DB510
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset); // 0x00000001801DAF10-0x00000001801DB3A0
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset); // 0x00000001801DB510-0x00000001801DB780
		private static bool TryGetCharacterFromFontFile(uint unicode, TMP_FontAsset fontAsset, out TMP_Character character); // 0x00000001801DB780-0x00000001801DB9C0
		public static bool TryGetGlyphFromFontFile(uint glyphIndex, TMP_FontAsset fontAsset, out Glyph glyph); // 0x00000001801DB9C0-0x00000001801DBBA0
	}

	[Serializable]
	public class TMP_FontFeatureTable // TypeDefIndex: 4188
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
		internal Dictionary<long, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18
	
		// Properties
		internal List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; } // 0x00000001801D2960-0x00000001801D2970 0x00000001801D2970-0x00000001801D2980
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4189
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x08
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001801F37A0-0x00000001801F3800
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s); // 0x00000001801F3490-0x00000001801F34B0
			internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s); // 0x00000001801F34B0-0x00000001801F34D0
		}
	
		// Constructors
		public TMP_FontFeatureTable(); // 0x00000001801E2570-0x00000001801E27B0
	
		// Methods
		public void SortGlyphPairAdjustmentRecords(); // 0x00000001801E23A0-0x00000001801E2570
	}

	public struct TMP_FontStyleStack // TypeDefIndex: 4224
	{
		// Fields
		public byte bold; // 0x00
		public byte italic; // 0x01
		public byte underline; // 0x02
		public byte strikethrough; // 0x03
		public byte highlight; // 0x04
		public byte superscript; // 0x05
		public byte subscript; // 0x06
		public byte uppercase; // 0x07
		public byte lowercase; // 0x08
		public byte smallcaps; // 0x09
	
		// Methods
		public void Clear(); // 0x0000000180002E30-0x0000000180002E40
		public byte Add(FontStyles style); // 0x0000000180002DB0-0x0000000180002E30
		public byte Remove(FontStyles style); // 0x0000000180002E40-0x0000000180002F70
	}

	public static class TMP_FontUtilities // TypeDefIndex: 4186
	{
		// Fields
		private static List<int> k_searchedFontAssets; // 0x00
	
		// Methods
		public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x00000001801E2BC0-0x00000001801E2D60
		public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x00000001801E2AE0-0x00000001801E2BC0
		private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character); // 0x00000001801E2890-0x00000001801E2AE0
		private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character); // 0x00000001801E27B0-0x00000001801E2890
	}

	[Serializable]
	public struct TMP_FontWeightPair // TypeDefIndex: 4177
	{
		// Fields
		public TMP_FontAsset regularTypeface; // 0x00
		public TMP_FontAsset italicTypeface; // 0x08
	}

	[Serializable]
	public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 4175
	{
		// Constructors
		public TMP_Glyph(); // 0x00000001801E30B0-0x00000001801E30C0
	
		// Methods
		public static TMP_Glyph Clone(TMP_Glyph source); // 0x00000001801E3010-0x00000001801E30B0
	}

	[Serializable]
	public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 4192
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint m_GlyphIndex; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_GlyphValueRecord m_GlyphValueRecord; // 0x04
	
		// Properties
		public uint glyphIndex { get; set; } // 0x0000000180002FB0-0x0000000180002FC0 0x0000000180002FD0-0x0000000180002FE0
		public TMP_GlyphValueRecord glyphValueRecord { get; set; } // 0x0000000180002FC0-0x0000000180002FD0 0x0000000180002FE0-0x0000000180002FF0
	
		// Constructors
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord); // 0x0000000180002F70-0x0000000180002F80
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord); // 0x0000000180002F80-0x0000000180002FB0
	}

	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 4193
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38
	
		// Properties
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; } // 0x00000001801E2F80-0x00000001801E2FA0 0x00000001801E2FD0-0x00000001801E2FE0
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; } // 0x00000001801E2FA0-0x00000001801E2FC0 0x00000001801E2FE0-0x00000001801E2FF0
		public FontFeatureLookupFlags featureLookupFlags { get; set; } // 0x00000001801E2F70-0x00000001801E2F80 0x00000001801E2FC0-0x00000001801E2FD0
	
		// Constructors
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord); // 0x00000001801E2F20-0x00000001801E2F70
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord); // 0x00000001801E2D60-0x00000001801E2F20
	}

	[Serializable]
	public struct TMP_GlyphValueRecord // TypeDefIndex: 4191
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_XPlacement; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_YPlacement; // 0x04
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_XAdvance; // 0x08
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_YAdvance; // 0x0C
	
		// Properties
		public float xPlacement { get; set; } // 0x0000000180003040-0x0000000180003050 0x0000000180003060-0x0000000180003070
		public float yPlacement { get; set; } // 0x0000000180003050-0x0000000180003060 0x0000000180003070-0x0000000180003450
		public float xAdvance { get; set; } // 0x0000000180002730-0x0000000180002740 0x0000000180002770-0x0000000180002780
		public float yAdvance { get; set; } // 0x0000000180002740-0x0000000180002750 0x0000000180002780-0x00000001800027B0
	
		// Constructors
		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance); // 0x0000000180002FF0-0x0000000180003010
		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord); // 0x0000000180003010-0x0000000180003040
		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord); // 0x0000000180002A90-0x0000000180002AF0
	
		// Methods
		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b); // 0x00000001801E2FF0-0x00000001801E3010
	}

	[AddComponentMenu] // 0x000000018012B280-0x000000018012B2B0
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 4195
	{
		// Fields
		protected TouchScreenKeyboard m_SoftKeyboard; // 0xF0
		private static readonly char[] kSeparators; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected RectTransform m_TextViewport; // 0xF8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_Text m_TextComponent; // 0x100
		protected RectTransform m_TextComponentRectTransform; // 0x108
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Graphic m_Placeholder; // 0x110
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Scrollbar m_VerticalScrollbar; // 0x118
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x120
		private bool m_IsDrivenByLayoutComponents; // 0x128
		private float m_ScrollPosition; // 0x12C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_ScrollSensitivity; // 0x130
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ContentType m_ContentType; // 0x134
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private InputType m_InputType; // 0x138
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private char m_AsteriskChar; // 0x13C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TouchScreenKeyboardType m_KeyboardType; // 0x140
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private LineType m_LineType; // 0x144
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_HideMobileInput; // 0x148
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_HideSoftKeyboard; // 0x149
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CharacterValidation m_CharacterValidation; // 0x14C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_RegexValue; // 0x150
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_GlobalPointSize; // 0x158
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int m_CharacterLimit; // 0x15C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private SubmitEvent m_OnEndEdit; // 0x160
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private SubmitEvent m_OnSubmit; // 0x168
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private SelectionEvent m_OnSelect; // 0x170
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private SelectionEvent m_OnDeselect; // 0x178
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TextSelectionEvent m_OnTextSelection; // 0x180
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TextSelectionEvent m_OnEndTextSelection; // 0x188
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private OnChangeEvent m_OnValueChanged; // 0x190
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x198
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private OnValidateInput m_OnValidateInput; // 0x1A0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Color m_CaretColor; // 0x1A8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_CustomCaretColor; // 0x1B8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Color m_SelectionColor; // 0x1BC
		[SerializeField] // 0x000000018012B600-0x000000018012B640
		[TextArea] // 0x000000018012B600-0x000000018012B640
		protected string m_Text; // 0x1D0
		[Range] // 0x000000018012B670-0x000000018012B6B0
		[SerializeField] // 0x000000018012B670-0x000000018012B6B0
		private float m_CaretBlinkRate; // 0x1D8
		[Range] // 0x000000018012B6B0-0x000000018012B6F0
		[SerializeField] // 0x000000018012B6B0-0x000000018012B6F0
		private int m_CaretWidth; // 0x1DC
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_ReadOnly; // 0x1E0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_RichText; // 0x1E1
		protected int m_StringPosition; // 0x1E4
		protected int m_StringSelectPosition; // 0x1E8
		protected int m_CaretPosition; // 0x1EC
		protected int m_CaretSelectPosition; // 0x1F0
		private RectTransform caretRectTrans; // 0x1F8
		protected UIVertex[] m_CursorVerts; // 0x200
		private CanvasRenderer m_CachedInputRenderer; // 0x208
		private Vector2 m_LastPosition; // 0x210
		[NonSerialized]
		protected Mesh m_Mesh; // 0x218
		private bool m_AllowInput; // 0x220
		private bool m_ShouldActivateNextUpdate; // 0x221
		private bool m_UpdateDrag; // 0x222
		private bool m_DragPositionOutOfBounds; // 0x223
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x0021F431
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x0021F435
		protected bool m_CaretVisible; // 0x224
		private Coroutine m_BlinkCoroutine; // 0x228
		private float m_BlinkStartTime; // 0x230
		private Coroutine m_DragCoroutine; // 0x238
		private string m_OriginalText; // 0x240
		private bool m_WasCanceled; // 0x248
		private bool m_HasDoneFocusTransition; // 0x249
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x250
		private bool m_PreventCallback; // 0x258
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x259
		private bool m_IsTextComponentUpdateRequired; // 0x25A
		private bool m_IsScrollbarUpdateRequired; // 0x25B
		private bool m_IsUpdatingScrollbarValues; // 0x25C
		private bool m_isLastKeyBackspace; // 0x25D
		private float m_PointerDownClickStartTime; // 0x260
		private float m_KeyDownStartTime; // 0x264
		private float m_DoubleClickDelay; // 0x268
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x0021F439
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_FontAsset m_GlobalFontAsset; // 0x270
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_OnFocusSelectAll; // 0x278
		protected bool m_isSelectAll; // 0x279
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_ResetOnDeActivation; // 0x27A
		private bool m_SelectionStillActive; // 0x27B
		private bool m_ReleaseSelection; // 0x27C
		private GameObject m_SelectedObject; // 0x280
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_RestoreOriginalTextOnEscape; // 0x288
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_isRichTextEditingAllowed; // 0x289
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected int m_LineLimit; // 0x28C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_InputValidator m_InputValidator; // 0x290
		private bool m_isSelected; // 0x298
		private bool m_IsStringPositionDirty; // 0x299
		private bool m_IsCaretPositionDirty; // 0x29A
		private bool m_forceRectTransformAdjustment; // 0x29B
		private Event m_ProcessingEvent; // 0x2A0
	
		// Properties
		private BaseInput inputSystem { get; } // 0x00000001801F1430-0x00000001801F1550 
		private string compositionString { get; } // 0x00000001801F12D0-0x00000001801F1380 
		protected Mesh mesh { get; } // 0x00000001801F15D0-0x00000001801F1670 
		public bool shouldHideMobileInput { get; set; } // 0x00000001801F1970-0x00000001801F19A0 0x00000001801F2E10-0x00000001801F2E90
		public bool shouldHideSoftKeyboard { get; set; } // 0x00000001801F19A0-0x00000001801F19F0 0x00000001801F2E90-0x00000001801F2F80
		public string text { get; set; } // 0x00000001801F19F0-0x00000001801F1A00 0x00000001801F31A0-0x00000001801F31B0
		public bool isFocused { get; } // 0x00000001801F1570-0x00000001801F1580 
		public float caretBlinkRate { get; set; } // 0x00000001801F11C0-0x00000001801F11D0 0x00000001801F1AB0-0x00000001801F1B20
		public int caretWidth { get; set; } // 0x00000001801F1290-0x00000001801F12A0 0x00000001801F1D80-0x00000001801F1E20
		public RectTransform textViewport { get; set; } // 0x00000001801DADF0-0x00000001801DAE00 0x00000001801F3150-0x00000001801F31A0
		public TMP_Text textComponent { get; set; } // 0x00000001801DADE0-0x00000001801DADF0 0x00000001801F30F0-0x00000001801F3150
		public Graphic placeholder { get; set; } // 0x00000001801DAE00-0x00000001801DAE10 0x00000001801F2830-0x00000001801F2880
		public Scrollbar verticalScrollbar { get; set; } // 0x00000001801F1A00-0x00000001801F1A10 0x00000001801F31B0-0x00000001801F3340
		public float scrollSensitivity { get; set; } // 0x00000001801F18F0-0x00000001801F1900 0x00000001801F2AA0-0x00000001801F2B40
		public Color caretColor { get; set; } // 0x00000001801F11D0-0x00000001801F1230 0x00000001801F1B20-0x00000001801F1BD0
		public bool customCaretColor { get; set; } // 0x00000001801F1390-0x00000001801F13A0 0x00000001801F2100-0x00000001801F2170
		public Color selectionColor { get; set; } // 0x00000001801F1900-0x00000001801F1910 0x00000001801F2BD0-0x00000001801F2C80
		public SubmitEvent onEndEdit { get; set; } // 0x00000001801F16B0-0x00000001801F16C0 0x00000001801F25A0-0x00000001801F25F0
		public SubmitEvent onSubmit { get; set; } // 0x00000001801F16F0-0x00000001801F1700 0x00000001801F26A0-0x00000001801F26F0
		public SelectionEvent onSelect { get; set; } // 0x00000001801F16E0-0x00000001801F16F0 0x00000001801F2650-0x00000001801F26A0
		public SelectionEvent onDeselect { get; set; } // 0x00000001801F16A0-0x00000001801F16B0 0x00000001801F2550-0x00000001801F25A0
		public TextSelectionEvent onTextSelection { get; set; } // 0x00000001801F1700-0x00000001801F1710 0x00000001801F26F0-0x00000001801F2740
		public TextSelectionEvent onEndTextSelection { get; set; } // 0x00000001801F16C0-0x00000001801F16D0 0x00000001801F25F0-0x00000001801F2640
		public OnChangeEvent onValueChanged { get; set; } // 0x00000001801E21B0-0x00000001801E21C0 0x00000001801F27E0-0x00000001801F2830
		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; } // 0x00000001801F1710-0x00000001801F1720 0x00000001801F2740-0x00000001801F2790
		public OnValidateInput onValidateInput { get; set; } // 0x00000001801F1720-0x00000001801F1730 0x00000001801F2790-0x00000001801F27E0
		public int characterLimit { get; set; } // 0x00000001801F12A0-0x00000001801F12B0 0x00000001801F1E20-0x00000001801F1ED0
		public float pointSize { get; set; } // 0x00000001801F1730-0x00000001801F1740 0x00000001801F2880-0x00000001801F29E0
		public TMP_FontAsset fontAsset { get; set; } // 0x00000001801F13B0-0x00000001801F13C0 0x00000001801F2170-0x00000001801F22A0
		public bool onFocusSelectAll { get; set; } // 0x00000001801F16D0-0x00000001801F16E0 0x00000001801F2640-0x00000001801F2650
		public bool resetOnDeActivation { get; set; } // 0x00000001801F18C0-0x00000001801F18D0 0x00000001801F29F0-0x00000001801F2A00
		public bool restoreOriginalTextOnEscape { get; set; } // 0x00000001801F18D0-0x00000001801F18E0 0x00000001801F2A00-0x00000001801F2A10
		public bool isRichTextEditingAllowed { get; set; } // 0x00000001801F1580-0x00000001801F1590 0x00000001801F2380-0x00000001801F2390
		public ContentType contentType { get; set; } // 0x00000001801F1380-0x00000001801F1390 0x00000001801F1F50-0x00000001801F2100
		public LineType lineType { get; set; } // 0x00000001801F15C0-0x00000001801F15D0 0x00000001801F2470-0x00000001801F2550
		public int lineLimit { get; set; } // 0x00000001801F15B0-0x00000001801F15C0 0x00000001801F2400-0x00000001801F2470
		public InputType inputType { get; set; } // 0x00000001801F1550-0x00000001801F1560 0x00000001801F22A0-0x00000001801F2310
		public TouchScreenKeyboardType keyboardType { get; set; } // 0x00000001801F1590-0x00000001801F15A0 0x00000001801F2390-0x00000001801F2400
		public CharacterValidation characterValidation { get; set; } // 0x00000001801F12B0-0x00000001801F12C0 0x00000001801F1ED0-0x00000001801F1F40
		public TMP_InputValidator inputValidator { get; set; } // 0x00000001801F1560-0x00000001801F1570 0x00000001801F2310-0x00000001801F2380
		public bool readOnly { get; set; } // 0x00000001801F18B0-0x00000001801F18C0 0x00000001801F29E0-0x00000001801F29F0
		public bool richText { get; set; } // 0x00000001801F18E0-0x00000001801F18F0 0x00000001801F2A10-0x00000001801F2AA0
		public bool multiLine { get; } // 0x00000001801F1680-0x00000001801F16A0 
		public char asteriskChar { get; set; } // 0x00000001801F11B0-0x00000001801F11C0 0x00000001801F1A50-0x00000001801F1AB0
		public bool wasCanceled { get; } // 0x00000001801F1A10-0x00000001801F1A20 
		protected int caretPositionInternal { get; set; } // 0x00000001801F1230-0x00000001801F1260 0x00000001801F1BD0-0x00000001801F1C30
		protected int stringPositionInternal { get; set; } // 0x00000001801F1910-0x00000001801F1940 0x00000001801F2F80-0x00000001801F2FD0
		protected int caretSelectPositionInternal { get; set; } // 0x00000001801F1260-0x00000001801F1290 0x00000001801F1D20-0x00000001801F1D80
		protected int stringSelectPositionInternal { get; set; } // 0x00000001801F1940-0x00000001801F1970 0x00000001801F30A0-0x00000001801F30F0
		private new bool hasSelection { get; } // 0x00000001801F13C0-0x00000001801F1430 
		public int caretPosition { get; set; } // 0x00000001801F1260-0x00000001801F1290 0x00000001801F1C30-0x00000001801F1D20
		public int selectionAnchorPosition { get; set; } // 0x00000001801F1230-0x00000001801F1260 0x00000001801F2B40-0x00000001801F2BD0
		public int selectionFocusPosition { get; set; } // 0x00000001801F1260-0x00000001801F1290 0x00000001801F2C80-0x00000001801F2D10
		public int stringPosition { get; set; } // 0x00000001801F1940-0x00000001801F1970 0x00000001801F2FD0-0x00000001801F30A0
		public int selectionStringAnchorPosition { get; set; } // 0x00000001801F1910-0x00000001801F1940 0x00000001801F2D10-0x00000001801F2D90
		public int selectionStringFocusPosition { get; set; } // 0x00000001801F1940-0x00000001801F1970 0x00000001801F2D90-0x00000001801F2E10
		private static string clipboard { get; set; } // 0x00000001801F12C0-0x00000001801F12D0 0x00000001801F1F40-0x00000001801F1F50
		public virtual float minWidth { get; } // 0x00000001801F1670-0x00000001801F1680 
		public virtual float preferredWidth { get; } // 0x00000001801F17F0-0x00000001801F18B0 
		public virtual float flexibleWidth { get; } // 0x00000001801F13A0-0x00000001801F13B0 
		public virtual float minHeight { get; } // 0x00000001801F1670-0x00000001801F1680 
		public virtual float preferredHeight { get; } // 0x00000001801F1740-0x00000001801F17F0 
		public virtual float flexibleHeight { get; } // 0x00000001801F13A0-0x00000001801F13B0 
		public virtual int layoutPriority { get; } // 0x00000001801F15A0-0x00000001801F15B0 
		Transform ICanvasElement.transform { get; } // 0x00000001801EFE60-0x00000001801EFE70 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 4196
		{
			Standard = 0,
			Autocorrected = 1,
			IntegerNumber = 2,
			DecimalNumber = 3,
			Alphanumeric = 4,
			Name = 5,
			EmailAddress = 6,
			Password = 7,
			Pin = 8,
			Custom = 9
		}
	
		public enum InputType // TypeDefIndex: 4197
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 4198
		{
			None = 0,
			Digit = 1,
			Integer = 2,
			Decimal = 3,
			Alphanumeric = 4,
			Name = 5,
			Regex = 6,
			EmailAddress = 7,
			CustomValidator = 8
		}
	
		public enum LineType // TypeDefIndex: 4199
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 4200; 0x00000001801F3910-0x00000001801F3EB0
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 4201
		{
			// Constructors
			public SubmitEvent(); // 0x00000001801F3F00-0x00000001801F4010
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 4202
		{
			// Constructors
			public OnChangeEvent(); // 0x00000001801F3800-0x00000001801F3840
		}
	
		[Serializable]
		public class SelectionEvent : UnityEvent<string> // TypeDefIndex: 4203
		{
			// Constructors
			public SelectionEvent(); // 0x00000001801F3EC0-0x00000001801F3F00
		}
	
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 4204
		{
			// Constructors
			public TextSelectionEvent(); // 0x0000000180219080-0x00000001802190C0
		}
	
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 4205
		{
			// Constructors
			public TouchScreenKeyboardEvent(); // 0x00000001802190C0-0x0000000180219100
		}
	
		protected enum EditState // TypeDefIndex: 4206
		{
			Continue = 0,
			Finish = 1
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <CaretBlink>d__267 : IEnumerator<object> // TypeDefIndex: 4207
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TMP_InputField <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <CaretBlink>d__267(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x0000000180219100-0x0000000180219230
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x0000000180219230-0x0000000180219280
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <MouseDragOutsideRect>d__285 : IEnumerator<object> // TypeDefIndex: 4208
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TMP_InputField <>4__this; // 0x20
			public PointerEventData eventData; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <MouseDragOutsideRect>d__285(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x0000000180219F20-0x000000018021A1C0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x000000018021A1C0-0x000000018021A210
		}
	
		// Constructors
		protected TMP_InputField(); // 0x00000001801F0F00-0x00000001801F11B0
		static TMP_InputField(); // 0x00000001801F0EA0-0x00000001801F0F00
	
		// Methods
		private bool isKeyboardUsingEvents(); // 0x00000001801F1A20-0x00000001801F1A50
		public void SetTextWithoutNotify(string input); // 0x00000001801EFC70-0x00000001801EFC80
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x0021F42F */); // 0x00000001801EFC80-0x00000001801EFDD0
		protected void ClampStringPos(ref int pos); // 0x00000001801E5210-0x00000001801E5250
		protected void ClampCaretPos(ref int pos); // 0x00000001801E51C0-0x00000001801E5210
		protected override void OnEnable(); // 0x00000001801ECEF0-0x00000001801ED520
		protected override void OnDisable(); // 0x00000001801EC640-0x00000001801EC950
		private void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x00000001801EC3C0-0x00000001801EC5A0
		[IteratorStateMachine] // 0x000000018012B940-0x000000018012B990
		private IEnumerator CaretBlink(); // 0x00000001801E5150-0x00000001801E51C0
		private void SetCaretVisible(); // 0x00000001801EF900-0x00000001801EF940
		private void SetCaretActive(); // 0x00000001801EF850-0x00000001801EF900
		protected void OnFocus(); // 0x00000001801EDAE0-0x00000001801EDB50
		protected void SelectAll(); // 0x00000001801EF3E0-0x00000001801EF440
		public void MoveTextEnd(bool shift); // 0x00000001801EB650-0x00000001801EB8B0
		public void MoveTextStart(bool shift); // 0x00000001801EB8B0-0x00000001801EBAE0
		public void MoveToEndOfLine(bool shift, bool ctrl); // 0x00000001801EBAE0-0x00000001801EBD90
		public void MoveToStartOfLine(bool shift, bool ctrl); // 0x00000001801EBD90-0x00000001801EC030
		private bool InPlaceEditing(); // 0x00000001801E7FD0-0x00000001801E80C0
		private void UpdateStringPositionFromKeyboard(); // 0x00000001801F0480-0x00000001801F0760
		protected virtual void LateUpdate(); // 0x00000001801E87B0-0x00000001801E8E40
		private bool MayDrag(PointerEventData eventData); // 0x00000001801E94A0-0x00000001801E95B0
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x00000001801EC5A0-0x00000001801EC5D0
		public virtual void OnDrag(PointerEventData eventData); // 0x00000001801EC950-0x00000001801ECEF0
		[IteratorStateMachine] // 0x000000018012B9E0-0x000000018012BA30
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData); // 0x00000001801E95B0-0x00000001801E9630
		public virtual void OnEndDrag(PointerEventData eventData); // 0x00000001801ED520-0x00000001801ED550
		public override void OnPointerDown(PointerEventData eventData); // 0x00000001801EDB80-0x00000001801EE6A0
		protected EditState KeyPressed(Event evt); // 0x00000001801E8350-0x00000001801E87B0
		protected virtual bool IsValidChar(char c); // 0x00000001801E8340-0x00000001801E8350
		public void ProcessEvent(Event e); // 0x00000001801EF2A0-0x00000001801EF2B0
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x00000001801EE9A0-0x00000001801EEB00
		public virtual void OnScroll(PointerEventData eventData); // 0x00000001801EE6A0-0x00000001801EE850
		private string GetSelectedString(); // 0x00000001801E7E50-0x00000001801E7F50
		private int FindNextWordBegin(); // 0x00000001801E6290-0x00000001801E63A0
		private void MoveRight(bool shift, bool ctrl); // 0x00000001801EADB0-0x00000001801EB650
		private int FindPrevWordBegin(); // 0x00000001801E63A0-0x00000001801E6490
		private void MoveLeft(bool shift, bool ctrl); // 0x00000001801E99E0-0x00000001801EA230
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x00000001801E9140-0x00000001801E9440
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar); // 0x00000001801E8E40-0x00000001801E9140
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x00000001801EEEE0-0x00000001801EF2A0
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar); // 0x00000001801EEB00-0x00000001801EEEE0
		private void MoveDown(bool shift); // 0x00000001801E99D0-0x00000001801E99E0
		private void MoveDown(bool shift, bool goToLastChar); // 0x00000001801E9630-0x00000001801E99D0
		private void MoveUp(bool shift); // 0x00000001801EC3B0-0x00000001801EC3C0
		private void MoveUp(bool shift, bool goToFirstChar); // 0x00000001801EC030-0x00000001801EC3B0
		private void MovePageUp(bool shift); // 0x00000001801EA800-0x00000001801EA810
		private void MovePageUp(bool shift, bool goToFirstChar); // 0x00000001801EA810-0x00000001801EADB0
		private void MovePageDown(bool shift); // 0x00000001801EA7F0-0x00000001801EA800
		private void MovePageDown(bool shift, bool goToLastChar); // 0x00000001801EA230-0x00000001801EA7F0
		private void Delete(); // 0x00000001801E5950-0x00000001801E60F0
		private void DeleteKey(); // 0x00000001801E5610-0x00000001801E5950
		private void Backspace(); // 0x00000001801E4BE0-0x00000001801E5150
		protected virtual void Append(string input); // 0x00000001801E4220-0x00000001801E42D0
		protected virtual void Append(char input); // 0x00000001801E42D0-0x00000001801E4440
		private void Insert(char c); // 0x00000001801E80C0-0x00000001801E8340
		private void UpdateTouchKeyboardFromEditChanges(); // 0x00000001801F0760-0x00000001801F07B0
		private void SendOnValueChangedAndUpdateLabel(); // 0x00000001801EF730-0x00000001801EF790
		private void SendOnValueChanged(); // 0x00000001801EF790-0x00000001801EF7E0
		protected void SendOnEndEdit(); // 0x00000001801EF440-0x00000001801EF490
		protected void SendOnSubmit(); // 0x00000001801EF610-0x00000001801EF660
		protected void SendOnFocus(); // 0x00000001801EF5C0-0x00000001801EF610
		protected void SendOnFocusLost(); // 0x00000001801EF570-0x00000001801EF5C0
		protected void SendOnTextSelection(); // 0x00000001801EF660-0x00000001801EF730
		protected void SendOnEndTextSelection(); // 0x00000001801EF490-0x00000001801EF570
		protected void SendTouchScreenKeyboardStatusChanged(); // 0x00000001801EF7E0-0x00000001801EF850
		protected void UpdateLabel(); // 0x00000001801EFF30-0x00000001801F02D0
		private void UpdateScrollbar(); // 0x00000001801F02D0-0x00000001801F0480
		private void OnScrollbarValueChange(float value); // 0x00000001801EE850-0x00000001801EE8B0
		private void AdjustTextPositionRelativeToViewport(float relativePosition); // 0x00000001801E4070-0x00000001801E4220
		private int GetCaretPositionFromStringIndex(int stringIndex); // 0x00000001801E7D50-0x00000001801E7DD0
		private int GetMinCaretPositionFromStringIndex(int stringIndex); // 0x00000001801E7DD0-0x00000001801E7E50
		private int GetMaxCaretPositionFromStringIndex(int stringIndex); // 0x00000001801E7D50-0x00000001801E7DD0
		private int GetStringIndexFromCaretPosition(int caretPosition); // 0x00000001801E7F50-0x00000001801E7FD0
		public void ForceLabelUpdate(); // 0x00000001801E6490-0x00000001801E64A0
		private void MarkGeometryAsDirty(); // 0x00000001801E9440-0x00000001801E94A0
		public virtual void Rebuild(CanvasUpdate update); // 0x00000001801EF2B0-0x00000001801EF380
		public virtual void LayoutComplete(); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void GraphicUpdateComplete(); // 0x00000001801D8E80-0x00000001801D8E90
		private void UpdateGeometry(); // 0x00000001801EFE70-0x00000001801EFF30
		private void AssignPositioningIfNeeded(); // 0x00000001801E4440-0x00000001801E4BE0
		private void OnFillVBO(Mesh vbo); // 0x00000001801ED550-0x00000001801EDAE0
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset); // 0x00000001801E64A0-0x00000001801E6F40
		private void CreateCursorVerts(); // 0x00000001801E5250-0x00000001801E53E0
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset); // 0x00000001801E6F40-0x00000001801E7D50
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible); // 0x00000001801E3750-0x00000001801E4070
		protected char Validate(string text, int pos, char ch); // 0x00000001801F07B0-0x00000001801F0EA0
		public void ActivateInputField(); // 0x00000001801E3600-0x00000001801E3750
		private void ActivateInputFieldInternal(); // 0x00000001801E30C0-0x00000001801E3600
		public override void OnSelect(BaseEventData eventData); // 0x00000001801EE8B0-0x00000001801EE910
		public virtual void OnPointerClick(PointerEventData eventData); // 0x00000001801EDB50-0x00000001801EDB80
		public void OnControlClick(); // 0x00000001801D8E80-0x00000001801D8E90
		public void ReleaseSelection(); // 0x00000001801EF380-0x00000001801EF3E0
		public void DeactivateInputField(bool clearSelection = false /* Metadata: 0x0021F430 */); // 0x00000001801E53E0-0x00000001801E5610
		public override void OnDeselect(BaseEventData eventData); // 0x00000001801EC5D0-0x00000001801EC640
		public virtual void OnSubmit(BaseEventData eventData); // 0x00000001801EE910-0x00000001801EE9A0
		private void EnforceContentType(); // 0x00000001801E6120-0x00000001801E6290
		private void SetTextComponentWrapMode(); // 0x00000001801EFBB0-0x00000001801EFC70
		private void SetTextComponentRichTextMode(); // 0x00000001801EFB20-0x00000001801EFBB0
		private void SetToCustomIfContentTypeIsNot(params /* 0x0000000180110980-0x0000000180110990 */ ContentType[] allowedContentTypes); // 0x00000001801EFDD0-0x00000001801EFE40
		private void SetToCustom(); // 0x00000001801EFE40-0x00000001801EFE60
		private void SetToCustom(CharacterValidation characterValidation); // 0x00000001801EFE40-0x00000001801EFE60
		protected override void DoStateTransition(SelectionState state, bool instant); // 0x00000001801E60F0-0x00000001801E6120
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void CalculateLayoutInputVertical(); // 0x00000001801D8E80-0x00000001801D8E90
		public void SetGlobalPointSize(float pointSize); // 0x00000001801EFA30-0x00000001801EFB20
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset); // 0x00000001801EF940-0x00000001801EFA30
	}

	[Serializable]
	public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 4210
	{
		// Constructors
		protected TMP_InputValidator(); // 0x00000001801D5C70-0x00000001801D5C80
	
		// Methods
		public abstract char Validate(ref string text, ref int pos, char ch);
	}

	public struct TMP_LineInfo // TypeDefIndex: 4211
	{
		// Fields
		internal int controlCharacterCount; // 0x00
		public int characterCount; // 0x04
		public int visibleCharacterCount; // 0x08
		public int spaceCount; // 0x0C
		public int wordCount; // 0x10
		public int firstCharacterIndex; // 0x14
		public int firstVisibleCharacterIndex; // 0x18
		public int lastCharacterIndex; // 0x1C
		public int lastVisibleCharacterIndex; // 0x20
		public float length; // 0x24
		public float lineHeight; // 0x28
		public float ascender; // 0x2C
		public float baseline; // 0x30
		public float descender; // 0x34
		public float maxAdvance; // 0x38
		public float width; // 0x3C
		public float marginLeft; // 0x40
		public float marginRight; // 0x44
		public TextAlignmentOptions alignment; // 0x48
		public Extents lineExtents; // 0x4C
	}

	public struct TMP_LinkInfo // TypeDefIndex: 4280
	{
		// Fields
		public TMP_Text textComponent; // 0x00
		public int hashCode; // 0x08
		public int linkIdFirstCharacterIndex; // 0x0C
		public int linkIdLength; // 0x10
		public int linkTextfirstCharacterIndex; // 0x14
		public int linkTextLength; // 0x18
		internal char[] linkID; // 0x20
	
		// Methods
		internal void SetLinkID(char[] text, int startIndex, int length); // 0x00000001800035D0-0x0000000180003600
		public string GetLinkText(); // 0x00000001800034F0-0x00000001800035D0
		public string GetLinkID(); // 0x0000000180003450-0x00000001800034F0
	}

	internal static class TMP_ListPool<T> // TypeDefIndex: 4212
	{
		// Fields
		private static readonly TMP_ObjectPool<List<T>> s_ListPool;
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4213
		{
			// Fields
			public static readonly <>c<T> <>9;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal void <.cctor>b__3_0(List<T> l);
		}
	
		// Constructors
		static TMP_ListPool();
	
		// Methods
		public static List<T> Get();
		public static void Release(List<T> toRelease);
	}

	public static class TMP_MaterialManager // TypeDefIndex: 4214
	{
		// Fields
		private static List<MaskingMaterial> m_materialList; // 0x00
		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials; // 0x08
		private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
		private static List<FallbackMaterial> m_fallbackCleanupList; // 0x18
		private static bool isFallbackListDirty; // 0x20
	
		// Nested types
		private class FallbackMaterial // TypeDefIndex: 4215
		{
			// Fields
			public int baseID; // 0x10
			public Material baseMaterial; // 0x18
			public long fallbackID; // 0x20
			public Material fallbackMaterial; // 0x28
			public int count; // 0x30
	
			// Constructors
			public FallbackMaterial(); // 0x00000001801D0660-0x00000001801D0670
		}
	
		private class MaskingMaterial // TypeDefIndex: 4216
		{
			// Fields
			public Material baseMaterial; // 0x10
			public Material stencilMaterial; // 0x18
			public int count; // 0x20
			public int stencilID; // 0x24
	
			// Constructors
			public MaskingMaterial(); // 0x00000001801D0660-0x00000001801D0670
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 4217
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass10_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <GetBaseMaterial>b__0(MaskingMaterial item); // 0x000000018021A210-0x000000018021A290
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 4218
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass12_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <AddMaskingMaterial>b__0(MaskingMaterial item); // 0x000000018021A290-0x000000018021A310
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 4219
		{
			// Fields
			public Material stencilMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass13_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <RemoveStencilMaterial>b__0(MaskingMaterial item); // 0x000000018021A310-0x000000018021A390
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 4220
		{
			// Fields
			public Material baseMaterial; // 0x10
	
			// Constructors
			public <>c__DisplayClass14_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal bool <ReleaseBaseMaterial>b__0(MaskingMaterial item); // 0x000000018021A390-0x000000018021A410
		}
	
		// Constructors
		static TMP_MaterialManager(); // 0x00000001801F6B50-0x00000001801F6CF0
	
		// Methods
		private static void OnPreRender(Camera cam); // 0x00000001801F5B40-0x00000001801F5BD0
		private static void OnPreRenderCanvas(); // 0x00000001801F5AB0-0x00000001801F5B40
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID); // 0x00000001801F56F0-0x00000001801F5AB0
		public static void ReleaseStencilMaterial(Material stencilMaterial); // 0x00000001801F6520-0x00000001801F6770
		public static Material GetBaseMaterial(Material stencilMaterial); // 0x00000001801F4B90-0x00000001801F4CE0
		public static Material SetStencil(Material material, int stencilID); // 0x00000001801F6A40-0x00000001801F6B50
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID); // 0x00000001801F4140-0x00000001801F4370
		public static void RemoveStencilMaterial(Material stencilMaterial); // 0x00000001801F6910-0x00000001801F6A40
		public static void ReleaseBaseMaterial(Material baseMaterial); // 0x00000001801F5BD0-0x00000001801F6350
		public static void ClearMaterials(); // 0x00000001801F45A0-0x00000001801F4740
		public static int GetStencilID(GameObject obj); // 0x00000001801F5300-0x00000001801F56F0
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial); // 0x00000001801F5130-0x00000001801F5300
		private static Transform FindRootSortOverrideCanvas(Transform start); // 0x00000001801F4A30-0x00000001801F4B90
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial); // 0x00000001801F4CE0-0x00000001801F5130
		public static void AddFallbackMaterialReference(Material targetMaterial); // 0x00000001801F4010-0x00000001801F4140
		public static void RemoveFallbackMaterialReference(Material targetMaterial); // 0x00000001801F6770-0x00000001801F6910
		public static void CleanupFallbackMaterials(); // 0x00000001801F4370-0x00000001801F45A0
		public static void ReleaseFallbackMaterial(Material fallackMaterial); // 0x00000001801F6350-0x00000001801F6520
		public static void CopyMaterialPresetProperties(Material source, Material destination); // 0x00000001801F4740-0x00000001801F4A30
	}

	public static class TMP_Math // TypeDefIndex: 4276
	{
		// Fields
		public const float FLOAT_MAX = 32767f; // Metadata: 0x0021F96E
		public const float FLOAT_MIN = -32767f; // Metadata: 0x0021F972
		public const int INT_MAX = 2147483647; // Metadata: 0x0021F976
		public const int INT_MIN = -2147483647; // Metadata: 0x0021F97A
		public const float FLOAT_UNSET = -32767f; // Metadata: 0x0021F97E
		public const int INT_UNSET = -32767; // Metadata: 0x0021F982
		public static Vector2 MAX_16BIT; // 0x00
		public static Vector2 MIN_16BIT; // 0x08
	
		// Constructors
		static TMP_Math(); // 0x00000001801F6D20-0x00000001801F8E60
	
		// Methods
		public static bool Approximately(float a, float b); // 0x00000001801F6CF0-0x00000001801F6D20
	}

	public struct TMP_MeshInfo // TypeDefIndex: 4222
	{
		// Fields
		private static readonly Color32 s_DefaultColor; // 0x00
		private static readonly Vector3 s_DefaultNormal; // 0x04
		private static readonly Vector4 s_DefaultTangent; // 0x10
		private static readonly Bounds s_DefaultBounds; // 0x20
		public Mesh mesh; // 0x00
		public int vertexCount; // 0x08
		public Vector3[] vertices; // 0x10
		public Vector3[] normals; // 0x18
		public Vector4[] tangents; // 0x20
		public Vector2[] uvs0; // 0x28
		public Vector2[] uvs2; // 0x30
		public Color32[] colors32; // 0x38
		public int[] triangles; // 0x40
	
		// Constructors
		public TMP_MeshInfo(Mesh mesh, int size); // 0x0000000180003B30-0x0000000180003E40
		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric); // 0x0000000180003B20-0x0000000180003B30
		static TMP_MeshInfo(); // 0x00000001801F8E60-0x00000001801FA100
	
		// Methods
		public void ResizeMeshInfo(int size); // 0x0000000180003920-0x0000000180003930
		public void ResizeMeshInfo(int size, bool isVolumetric); // 0x0000000180003930-0x0000000180003940
		public void Clear(); // 0x0000000180003730-0x00000001800037E0
		public void Clear(bool uploadChanges); // 0x00000001800037E0-0x0000000180003920
		public void ClearUnusedVertices(); // 0x0000000180003630-0x0000000180003670
		public void ClearUnusedVertices(int startIndex); // 0x0000000180003600-0x0000000180003630
		public void ClearUnusedVertices(int startIndex, bool updateMesh); // 0x0000000180003670-0x0000000180003730
		public void SortGeometry(VertexSortingOrder order); // 0x0000000180003A90-0x0000000180003B10
		public void SortGeometry(IList<int> sortingOrder); // 0x0000000180003940-0x0000000180003A90
		public void SwapVertexData(int src, int dst); // 0x0000000180003B10-0x0000000180003B20
	}

	internal class TMP_ObjectPool<T> // TypeDefIndex: 4223
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private readonly UnityAction<T> m_ActionOnGet;
		private readonly UnityAction<T> m_ActionOnRelease;
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private int <countAll>k__BackingField;
	
		// Properties
		public int countAll { [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ get; [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ private set; }
		public int countActive { get; }
		public int countInactive { get; }
	
		// Constructors
		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease);
	
		// Methods
		public T Get();
		public void Release(T element);
	}

	public struct TMP_PageInfo // TypeDefIndex: 4279
	{
		// Fields
		public int firstCharacterIndex; // 0x00
		public int lastCharacterIndex; // 0x04
		public float ascender; // 0x08
		public float baseLine; // 0x0C
		public float descender; // 0x10
	}

	public struct TMP_RichTextTagStack<T> // TypeDefIndex: 4225
	{
		// Fields
		public T[] m_ItemStack;
		public int m_Index;
		private int m_Capacity;
		private T m_DefaultItem;
		private const int k_DefaultCapacity = 4; // Metadata: 0x0021F4C4
	
		// Constructors
		public TMP_RichTextTagStack(T[] tagStack);
		public TMP_RichTextTagStack(int capacity);
	
		// Methods
		public void Clear();
		public void SetDefault(T item);
		public void Add(T item);
		public T Remove();
		public void Push(T item);
		public T Pop();
		public T Peek();
		public T CurrentItem();
		public T PreviousItem();
	}

	public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 4230
	{
		// Fields
		public bool isSelected; // 0x18
	
		// Constructors
		public TMP_ScrollbarEventHandler(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		public void OnPointerClick(PointerEventData eventData); // 0x00000001801FA160-0x00000001801FA1B0
		public void OnSelect(BaseEventData eventData); // 0x00000001801FA1B0-0x00000001801FA210
		public void OnDeselect(BaseEventData eventData); // 0x00000001801FA100-0x00000001801FA160
	}

	public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 4231
	{
		// Constructors
		public TMP_SelectionCaret(); // 0x00000001801FA210-0x00000001801FA220
	
		// Methods
		public override void Cull(Rect clipRect, bool validRect); // 0x00000001801D8E80-0x00000001801D8E90
	}

	[Serializable]
	public class TMP_Settings : ScriptableObject // TypeDefIndex: 4232
	{
		// Fields
		private static TMP_Settings s_Instance; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_enableWordWrapping; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_enableKerning; // 0x19
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_enableExtraPadding; // 0x1A
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_enableTintAllSprites; // 0x1B
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_enableParseEscapeCharacters; // 0x1C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_EnableRaycastTarget; // 0x1D
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_GetFontFeaturesAtRuntime; // 0x1E
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int m_missingGlyphCharacter; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_warningsDisabled; // 0x24
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_FontAsset m_defaultFontAsset; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_defaultFontAssetPath; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_defaultFontSize; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_defaultAutoSizeMinRatio; // 0x3C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_defaultAutoSizeMaxRatio; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_autoSizeTextContainer; // 0x54
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_matchMaterialPreset; // 0x60
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_SpriteAsset m_defaultSpriteAsset; // 0x68
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_defaultSpriteAssetPath; // 0x70
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_defaultColorGradientPresetsPath; // 0x78
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_enableEmojiSupport; // 0x80
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_StyleSheet m_defaultStyleSheet; // 0x88
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TextAsset m_leadingCharacters; // 0x90
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TextAsset m_followingCharacters; // 0x98
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private LineBreakingTable m_linebreakingRules; // 0xA0
	
		// Properties
		public static string version { get; } // 0x00000001801FAC70-0x00000001801FACA0 
		public static bool enableWordWrapping { get; } // 0x00000001801FA980-0x00000001801FA9A0 
		public static bool enableKerning { get; } // 0x00000001801FA900-0x00000001801FA920 
		public static bool enableExtraPadding { get; } // 0x00000001801FA8E0-0x00000001801FA900 
		public static bool enableTintAllSprites { get; } // 0x00000001801FA960-0x00000001801FA980 
		public static bool enableParseEscapeCharacters { get; } // 0x00000001801FA920-0x00000001801FA940 
		public static bool enableRaycastTarget { get; } // 0x00000001801FA940-0x00000001801FA960 
		public static bool getFontFeaturesAtRuntime { get; } // 0x00000001801FA9F0-0x00000001801FAA10 
		public static int missingGlyphCharacter { get; set; } // 0x00000001801FAC50-0x00000001801FAC70 0x00000001801FACF0-0x00000001801FAD20
		public static bool warningsDisabled { get; } // 0x00000001801FACA0-0x00000001801FACC0 
		public static TMP_FontAsset defaultFontAsset { get; } // 0x00000001801FA760-0x00000001801FA780 
		public static string defaultFontAssetPath { get; } // 0x00000001801FA740-0x00000001801FA760 
		public static float defaultFontSize { get; } // 0x00000001801FA780-0x00000001801FA7A0 
		public static float defaultTextAutoSizingMinRatio { get; } // 0x00000001801FA830-0x00000001801FA850 
		public static float defaultTextAutoSizingMaxRatio { get; } // 0x00000001801FA810-0x00000001801FA830 
		public static Vector2 defaultTextMeshProTextContainerSize { get; } // 0x00000001801FA850-0x00000001801FA880 
		public static Vector2 defaultTextMeshProUITextContainerSize { get; } // 0x00000001801FA880-0x00000001801FA8B0 
		public static bool autoSizeTextContainer { get; } // 0x00000001801FA700-0x00000001801FA720 
		public static List<TMP_FontAsset> fallbackFontAssets { get; } // 0x00000001801FA9A0-0x00000001801FA9C0 
		public static bool matchMaterialPreset { get; } // 0x00000001801FAC30-0x00000001801FAC50 
		public static TMP_SpriteAsset defaultSpriteAsset { get; } // 0x00000001801FA7C0-0x00000001801FA7E0 
		public static string defaultSpriteAssetPath { get; } // 0x00000001801FA7A0-0x00000001801FA7C0 
		public static string defaultColorGradientPresetsPath { get; } // 0x00000001801FA720-0x00000001801FA740 
		public static bool enableEmojiSupport { get; set; } // 0x00000001801FA8B0-0x00000001801FA8E0 0x00000001801FACC0-0x00000001801FACF0
		public static TMP_StyleSheet defaultStyleSheet { get; } // 0x00000001801FA7E0-0x00000001801FA810 
		public static TextAsset leadingCharacters { get; } // 0x00000001801FAAB0-0x00000001801FAAE0 
		public static TextAsset followingCharacters { get; } // 0x00000001801FA9C0-0x00000001801FA9F0 
		public static LineBreakingTable linebreakingRules { get; } // 0x00000001801FAAE0-0x00000001801FAC30 
		public static TMP_Settings instance { get; } // 0x00000001801FAA10-0x00000001801FAAB0 
	
		// Nested types
		public class LineBreakingTable // TypeDefIndex: 4233
		{
			// Fields
			public Dictionary<int, char> leadingCharacters; // 0x10
			public Dictionary<int, char> followingCharacters; // 0x18
	
			// Constructors
			public LineBreakingTable(); // 0x00000001801D0660-0x00000001801D0670
		}
	
		// Constructors
		public TMP_Settings(); // 0x00000001801FA6F0-0x00000001801FA700
	
		// Methods
		public static TMP_Settings LoadDefaultSettings(); // 0x00000001801FA500-0x00000001801FA5D0
		public static TMP_Settings GetSettings(); // 0x00000001801FA380-0x00000001801FA3F0
		public static TMP_FontAsset GetFontAsset(); // 0x00000001801FA300-0x00000001801FA380
		public static TMP_SpriteAsset GetSpriteAsset(); // 0x00000001801FA3F0-0x00000001801FA470
		public static TMP_StyleSheet GetStyleSheet(); // 0x00000001801FA470-0x00000001801FA500
		public static void LoadLinebreakingRules(); // 0x00000001801FA5D0-0x00000001801FA6F0
		private static Dictionary<int, char> GetCharacters(TextAsset file); // 0x00000001801FA220-0x00000001801FA300
	}

	[Serializable]
	public class TMP_Sprite : TMP_TextElement_Legacy // TypeDefIndex: 4235
	{
		// Fields
		public string name; // 0x38
		public int hashCode; // 0x40
		public int unicode; // 0x44
		public Vector2 pivot; // 0x48
		public Sprite sprite; // 0x50
	
		// Constructors
		public TMP_Sprite(); // 0x00000001801E30B0-0x00000001801E30C0
	}

	[DisallowMultipleComponent] // 0x0000000180110980-0x0000000180110990
	public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 4236
	{
		// Fields
		private Dictionary<int, bool> m_animations; // 0x18
		private TMP_Text m_TextComponent; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <DoSpriteAnimationInternal>d__7 : IEnumerator<object> // TypeDefIndex: 4237
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TMP_SpriteAnimator <>4__this; // 0x20
			public int start; // 0x28
			public int end; // 0x2C
			public TMP_SpriteAsset spriteAsset; // 0x30
			public int currentCharacter; // 0x38
			public int framerate; // 0x3C
			private int <currentFrame>5__2; // 0x40
			private TMP_CharacterInfo <charInfo>5__3; // 0x48
			private int <materialIndex>5__4; // 0x1A0
			private int <vertexIndex>5__5; // 0x1A4
			private TMP_MeshInfo <meshInfo>5__6; // 0x1A8
			private float <elapsedTime>5__7; // 0x1F0
			private float <targetTime>5__8; // 0x1F4
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; } // 0x00000001801D0240-0x00000001801D0250 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <DoSpriteAnimationInternal>d__7(int <>1__state); // 0x00000001801F3440-0x00000001801F3470
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
			private bool MoveNext(); // 0x0000000180219280-0x0000000180219ED0
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset(); // 0x0000000180219ED0-0x0000000180219F20
		}
	
		// Constructors
		public TMP_SpriteAnimator(); // 0x00000001801FAF50-0x00000001801FAFC0
	
		// Methods
		private void Awake(); // 0x00000001801FAD20-0x00000001801FAD60
		private void OnEnable(); // 0x00000001801D8E80-0x00000001801D8E90
		private void OnDisable(); // 0x00000001801D8E80-0x00000001801D8E90
		public void StopAllAnimations(); // 0x00000001801FAF00-0x00000001801FAF50
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x00000001801FAE00-0x00000001801FAF00
		[IteratorStateMachine] // 0x000000018012C9C0-0x000000018012CA10
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x00000001801FAD60-0x00000001801FAE00
	}

	public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 4238
	{
		// Fields
		internal Dictionary<uint, int> m_UnicodeLookup; // 0x30
		internal Dictionary<int, int> m_NameLookup; // 0x38
		internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_Version; // 0x48
		public Texture spriteSheet; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<TMP_SpriteGlyph> m_SpriteGlyphTable; // 0x60
		public List<TMP_Sprite> spriteInfoList; // 0x68
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0x70
		internal bool m_IsSpriteAssetLookupTablesDirty; // 0x78
		private static List<int> k_searchedSpriteAssets; // 0x00
	
		// Properties
		public string version { get; internal set; } // 0x00000001801FC9E0-0x00000001801FC9F0 0x00000001801FCA10-0x00000001801FCA20
		public List<TMP_SpriteCharacter> spriteCharacterTable { get; internal set; } // 0x00000001801FC9A0-0x00000001801FC9D0 0x00000001801FC9F0-0x00000001801FCA00
		public List<TMP_SpriteGlyph> spriteGlyphTable { get; internal set; } // 0x00000001801FC9D0-0x00000001801FC9E0 0x00000001801FCA00-0x00000001801FCA10
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4239
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<TMP_SpriteGlyph, uint> <>9__32_0; // 0x08
			public static Func<TMP_SpriteCharacter, uint> <>9__33_0; // 0x10
	
			// Constructors
			static <>c(); // 0x000000018021A410-0x000000018021A470
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal uint <SortGlyphTable>b__32_0(TMP_SpriteGlyph item); // 0x00000001801F34D0-0x00000001801F34F0
			internal uint <SortCharacterTable>b__33_0(TMP_SpriteCharacter c); // 0x00000001801F3470-0x00000001801F3490
		}
	
		// Constructors
		public TMP_SpriteAsset(); // 0x00000001801FC920-0x00000001801FC9A0
	
		// Methods
		private void Awake(); // 0x00000001801FAFC0-0x00000001801FB040
		private Material GetDefaultSpriteMaterial(); // 0x00000001801FB040-0x00000001801FB110
		public void UpdateLookupTables(); // 0x00000001801FC020-0x00000001801FC3B0
		public int GetSpriteIndexFromHashcode(int hashCode); // 0x00000001801FB110-0x00000001801FB1A0
		public int GetSpriteIndexFromUnicode(uint unicode); // 0x00000001801FB280-0x00000001801FB310
		public int GetSpriteIndexFromName(string name); // 0x00000001801FB1A0-0x00000001801FB280
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x00000001801FB9D0-0x00000001801FBBD0
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x00000001801FB770-0x00000001801FB920
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex); // 0x00000001801FB920-0x00000001801FB9D0
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex); // 0x00000001801FB570-0x00000001801FB770
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x00000001801FB3C0-0x00000001801FB570
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex); // 0x00000001801FB310-0x00000001801FB3C0
		public void SortGlyphTable(); // 0x00000001801FBF00-0x00000001801FC020
		internal void SortCharacterTable(); // 0x00000001801FBBD0-0x00000001801FBCF0
		internal void SortGlyphAndCharacterTables(); // 0x00000001801FBCF0-0x00000001801FBF00
		private void UpgradeSpriteAsset(); // 0x00000001801FC3B0-0x00000001801FC920
	}

	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 4240
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_Name; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int m_HashCode; // 0x30
	
		// Properties
		public string name { get; set; } // 0x00000001801D0230-0x00000001801D0240 0x00000001801FCAB0-0x00000001801FCB30
		public int hashCode { get; } // 0x00000001801FCAA0-0x00000001801FCAB0 
	
		// Constructors
		public TMP_SpriteCharacter(); // 0x00000001801FCA80-0x00000001801FCAA0
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph); // 0x00000001801FCA20-0x00000001801FCA80
	}

	[Serializable]
	public class TMP_SpriteGlyph : Glyph // TypeDefIndex: 4241
	{
		// Fields
		public Sprite sprite; // 0x40
	
		// Constructors
		public TMP_SpriteGlyph(); // 0x00000001801FCB30-0x00000001801FCB40
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex); // 0x00000001801FCB40-0x00000001801FCBE0
		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite); // 0x00000001801FCBE0-0x00000001801FCC90
	}

	public struct TMP_SpriteInfo // TypeDefIndex: 4282
	{
		// Fields
		public int spriteIndex; // 0x00
		public int characterIndex; // 0x04
		public int vertexIndex; // 0x08
	}

	[Serializable]
	public class TMP_Style // TypeDefIndex: 4242
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_Name; // 0x10
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int m_HashCode; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_OpeningDefinition; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string m_ClosingDefinition; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int[] m_OpeningTagArray; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int[] m_ClosingTagArray; // 0x38
	
		// Properties
		public string name { get; set; } // 0x00000001801D2960-0x00000001801D2970 0x00000001801FD440-0x00000001801FD480
		public int hashCode { get; set; } // 0x00000001801FD410-0x00000001801FD420 0x00000001801FD430-0x00000001801FD440
		public string styleOpeningDefinition { get; } // 0x00000001801D0220-0x00000001801D0230 
		public string styleClosingDefinition { get; } // 0x00000001801D0230-0x00000001801D0240 
		public int[] styleOpeningTagArray { get; } // 0x00000001801D0250-0x00000001801D0260 
		public int[] styleClosingTagArray { get; } // 0x00000001801FD420-0x00000001801FD430 
	
		// Constructors
		public TMP_Style(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public void RefreshStyle(); // 0x00000001801FD280-0x00000001801FD410
	}

	[Serializable]
	public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 4243
	{
		// Fields
		private static TMP_StyleSheet s_Instance; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<TMP_Style> m_StyleList; // 0x18
		private Dictionary<int, TMP_Style> m_StyleDictionary; // 0x20
	
		// Properties
		public static TMP_StyleSheet instance { get; } // 0x00000001801FD100-0x00000001801FD280 
	
		// Constructors
		public TMP_StyleSheet(); // 0x00000001801FD070-0x00000001801FD100
	
		// Methods
		public static TMP_StyleSheet LoadDefaultStyleSheet(); // 0x00000001801FCDA0-0x00000001801FCDB0
		public static TMP_Style GetStyle(int hashCode); // 0x00000001801FCD10-0x00000001801FCDA0
		private TMP_Style GetStyleInternal(int hashCode); // 0x00000001801FCC90-0x00000001801FCD10
		public void UpdateStyleDictionaryKey(int old_key, int new_key); // 0x00000001801FCF60-0x00000001801FD010
		public static void UpdateStyleSheet(); // 0x00000001801FD010-0x00000001801FD070
		public static void RefreshStyles(); // 0x00000001801FCF30-0x00000001801FCF60
		private void LoadStyleDictionaryInternal(); // 0x00000001801FCDB0-0x00000001801FCF30
	}

	[ExecuteAlways] // 0x000000018012D840-0x000000018012D8D0
	[RequireComponent] // 0x000000018012D840-0x000000018012D8D0
	[RequireComponent] // 0x000000018012D840-0x000000018012D8D0
	public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 4244
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_FontAsset m_fontAsset; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_SpriteAsset m_spriteAsset; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material m_material; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material m_sharedMaterial; // 0x30
		private Material m_fallbackMaterial; // 0x38
		private Material m_fallbackSourceMaterial; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_isDefaultMaterial; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_padding; // 0x4C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Renderer m_renderer; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private MeshFilter m_meshFilter; // 0x58
		private Mesh m_mesh; // 0x60
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TextMeshPro m_TextComponent; // 0x68
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x70
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x00000001801D0240-0x00000001801D0250 0x00000001801D0280-0x00000001801D0290
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x00000001801D0220-0x00000001801D0230 0x00000001801D0260-0x00000001801D0270
		public Material material { get; set; } // 0x00000001801FFA90-0x00000001801FFAA0 0x00000001801FFDE0-0x00000001801FFE60
		public Material sharedMaterial { get; set; } // 0x00000001801D0250-0x00000001801D0260 0x00000001801FF8F0-0x00000001801FF920
		public Material fallbackMaterial { get; set; } // 0x00000001801FD420-0x00000001801FD430 0x00000001801FFC70-0x00000001801FFDD0
		public Material fallbackSourceMaterial { get; set; } // 0x00000001801E2210-0x00000001801E2220 0x00000001801E2380-0x00000001801E2390
		public bool isDefaultMaterial { get; set; } // 0x00000001801FFA80-0x00000001801FFA90 0x00000001801FFDD0-0x00000001801FFDE0
		public float padding { get; set; } // 0x00000001801FFBE0-0x00000001801FFBF0 0x00000001801FFE60-0x00000001801FFE70
		public Renderer renderer { get; } // 0x00000001801FFBF0-0x00000001801FFC70 
		public MeshFilter meshFilter { get; } // 0x00000001801FFAA0-0x00000001801FFB20 
		public Mesh mesh { get; set; } // 0x00000001801FFB20-0x00000001801FFBE0 0x00000001801FCA00-0x00000001801FCA10
	
		// Constructors
		public TMP_SubMesh(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void OnEnable(); // 0x00000001801FF610-0x00000001801FF800
		private void OnDisable(); // 0x00000001801FF550-0x00000001801FF610
		private void OnDestroy(); // 0x00000001801FF450-0x00000001801FF550
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference); // 0x00000001801FECB0-0x00000001801FF060
		public void DestroySelf(); // 0x00000001801FF110-0x00000001801FF180
		private Material GetMaterial(Material mat); // 0x00000001801FF180-0x00000001801FF330
		private Material CreateMaterialInstance(Material source); // 0x00000001801FF060-0x00000001801FF110
		private Material GetSharedMaterial(); // 0x00000001801FF3C0-0x00000001801FF450
		private void SetSharedMaterial(Material mat); // 0x00000001801FF8F0-0x00000001801FF920
		public float GetPaddingForMaterial(); // 0x00000001801FF330-0x00000001801FF3C0
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x00000001801FF9F0-0x00000001801FFA80
		public void SetVerticesDirty(); // 0x00000001801FF920-0x00000001801FF9F0
		public void SetMaterialDirty(); // 0x00000001801FF800-0x00000001801FF8F0
		protected void UpdateMaterial(); // 0x00000001801FF800-0x00000001801FF8F0
	}

	[ExecuteAlways] // 0x0000000180110980-0x0000000180110990
	public class TMP_SubMeshUI : MaskableGraphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 4245
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_FontAsset m_fontAsset; // 0xC8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_SpriteAsset m_spriteAsset; // 0xD0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material m_material; // 0xD8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Material m_sharedMaterial; // 0xE0
		private Material m_fallbackMaterial; // 0xE8
		private Material m_fallbackSourceMaterial; // 0xF0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool m_isDefaultMaterial; // 0xF8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_padding; // 0xFC
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private CanvasRenderer m_canvasRenderer; // 0x100
		private Mesh m_mesh; // 0x108
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TextMeshProUGUI m_TextComponent; // 0x110
		[NonSerialized]
		private bool m_isRegisteredForEvents; // 0x118
		private bool m_materialDirty; // 0x119
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int m_materialReferenceIndex; // 0x11C
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x00000001801FE630-0x00000001801FE640 0x00000001801FEB80-0x00000001801FEB90
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x00000001801E20A0-0x00000001801E20B0 0x00000001801E2270-0x00000001801E2280
		public override Texture mainTexture { get; } // 0x00000001801FE650-0x00000001801FE720 
		public override Material material { get; set; } // 0x00000001801FE790-0x00000001801FE930 0x00000001801FEBA0-0x00000001801FEC90
		public Material sharedMaterial { get; set; } // 0x00000001801E2220-0x00000001801E2230 0x00000001801FE250-0x00000001801FE290
		public Material fallbackMaterial { get; set; } // 0x00000001801E21C0-0x00000001801E21D0 0x00000001801FE9F0-0x00000001801FEB70
		public Material fallbackSourceMaterial { get; set; } // 0x00000001801DAE50-0x00000001801DAE60 0x00000001801FEB70-0x00000001801FEB80
		public override Material materialForRendering { get; } // 0x00000001801FE720-0x00000001801FE790 
		public bool isDefaultMaterial { get; set; } // 0x00000001801FE640-0x00000001801FE650 0x00000001801FEB90-0x00000001801FEBA0
		public float padding { get; set; } // 0x00000001801FE9E0-0x00000001801FE9F0 0x00000001801FECA0-0x00000001801FECB0
		public new CanvasRenderer canvasRenderer { get; } // 0x00000001801FE5A0-0x00000001801FE630 
		public Mesh mesh { get; set; } // 0x00000001801FE930-0x00000001801FE9E0 0x00000001801FEC90-0x00000001801FECA0
	
		// Constructors
		public TMP_SubMeshUI(); // 0x00000001801FA210-0x00000001801FA220
	
		// Methods
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x00000001801FD480-0x00000001801FD7F0
		protected override void OnEnable(); // 0x00000001801FE050-0x00000001801FE0A0
		protected override void OnDisable(); // 0x00000001801FDF20-0x00000001801FE050
		protected override void OnDestroy(); // 0x00000001801FDD90-0x00000001801FDF20
		protected override void OnTransformParentChanged(); // 0x00000001801FE0A0-0x00000001801FE100
		public override Material GetModifiedMaterial(Material baseMaterial); // 0x00000001801FDA70-0x00000001801FDBC0
		public float GetPaddingForMaterial(); // 0x00000001801FDC50-0x00000001801FDCF0
		public float GetPaddingForMaterial(Material mat); // 0x00000001801FDBC0-0x00000001801FDC50
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold); // 0x00000001801FE510-0x00000001801FE5A0
		public override void SetAllDirty(); // 0x00000001801D8E80-0x00000001801D8E90
		public override void SetVerticesDirty(); // 0x00000001801FE290-0x00000001801FE370
		public override void SetLayoutDirty(); // 0x00000001801D8E80-0x00000001801D8E90
		public override void SetMaterialDirty(); // 0x00000001801FE190-0x00000001801FE1D0
		public void SetPivotDirty(); // 0x00000001801FE1D0-0x00000001801FE250
		public override void Cull(Rect clipRect, bool validRect); // 0x00000001801FD8A0-0x00000001801FD8E0
		protected override void UpdateGeometry(); // 0x00000001801FE370-0x00000001801FE3C0
		public override void Rebuild(CanvasUpdate update); // 0x00000001801FE100-0x00000001801FE140
		public void RefreshMaterial(); // 0x00000001801FE170-0x00000001801FE190
		protected override void UpdateMaterial(); // 0x00000001801FE3C0-0x00000001801FE510
		public override void RecalculateClipping(); // 0x00000001801FE140-0x00000001801FE150
		public override void RecalculateMasking(); // 0x00000001801FE150-0x00000001801FE170
		private Material GetMaterial(); // 0x00000001801E2220-0x00000001801E2230
		private Material GetMaterial(Material mat); // 0x00000001801FD8E0-0x00000001801FDA70
		private Material CreateMaterialInstance(Material source); // 0x00000001801FD7F0-0x00000001801FD8A0
		private Material GetSharedMaterial(); // 0x00000001801FDCF0-0x00000001801FDD90
		private void SetSharedMaterial(Material mat); // 0x00000001801FE250-0x00000001801FE290
	}

	public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 4258
	{
		// Fields
		[SerializeField] // 0x000000018012B600-0x000000018012B640
		[TextArea] // 0x000000018012B600-0x000000018012B640
		protected string m_text; // 0xC8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_isRightToLeft; // 0xD0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_FontAsset m_fontAsset; // 0xD8
		protected TMP_FontAsset m_currentFontAsset; // 0xE0
		protected bool m_isSDFShader; // 0xE8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Material m_sharedMaterial; // 0xF0
		protected Material m_currentMaterial; // 0xF8
		protected MaterialReference[] m_materialReferences; // 0x100
		protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
		protected TMP_RichTextTagStack<MaterialReference> m_materialReferenceStack; // 0x110
		protected int m_currentMaterialIndex; // 0x158
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Material[] m_fontSharedMaterials; // 0x160
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Material m_fontMaterial; // 0x168
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Material[] m_fontMaterials; // 0x170
		protected bool m_isMaterialDirty; // 0x178
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Color32 m_fontColor32; // 0x17C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Color m_fontColor; // 0x180
		protected static Color32 s_colorWhite; // 0x00
		protected Color32 m_underlineColor; // 0x190
		protected Color32 m_strikethroughColor; // 0x194
		protected Color32 m_highlightColor; // 0x198
		protected Vector4 m_highlightPadding; // 0x19C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_enableVertexGradient; // 0x1AC
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected ColorMode m_colorMode; // 0x1B0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected VertexGradient m_fontColorGradient; // 0x1B4
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_SpriteAsset m_spriteAsset; // 0x200
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_tintAllSprites; // 0x208
		protected bool m_tintSprite; // 0x209
		protected Color32 m_spriteColor; // 0x20C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_overrideHtmlColors; // 0x210
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Color32 m_faceColor; // 0x214
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Color32 m_outlineColor; // 0x218
		protected float m_outlineWidth; // 0x21C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_fontSize; // 0x220
		protected float m_currentFontSize; // 0x224
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_fontSizeBase; // 0x228
		protected TMP_RichTextTagStack<float> m_sizeStack; // 0x230
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected FontWeight m_fontWeight; // 0x248
		protected FontWeight m_FontWeightInternal; // 0x24C
		protected TMP_RichTextTagStack<FontWeight> m_FontWeightStack; // 0x250
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_enableAutoSizing; // 0x268
		protected float m_maxFontSize; // 0x26C
		protected float m_minFontSize; // 0x270
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_fontSizeMin; // 0x274
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_fontSizeMax; // 0x278
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected FontStyles m_fontStyle; // 0x27C
		protected FontStyles m_FontStyleInternal; // 0x280
		protected TMP_FontStyleStack m_fontStyleStack; // 0x284
		protected bool m_isUsingBold; // 0x28E
		[FormerlySerializedAs] // 0x000000018012FE90-0x000000018012FED0
		[SerializeField] // 0x000000018012FE90-0x000000018012FED0
		protected TextAlignmentOptions m_textAlignment; // 0x290
		protected TextAlignmentOptions m_lineJustification; // 0x294
		protected TMP_RichTextTagStack<TextAlignmentOptions> m_lineJustificationStack; // 0x298
		protected Vector3[] m_textContainerLocalCorners; // 0x2B0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_characterSpacing; // 0x2B8
		protected float m_cSpacing; // 0x2BC
		protected float m_monoSpacing; // 0x2C0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_wordSpacing; // 0x2C4
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_lineSpacing; // 0x2C8
		protected float m_lineSpacingDelta; // 0x2CC
		protected float m_lineHeight; // 0x2D0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_lineSpacingMax; // 0x2D4
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_paragraphSpacing; // 0x2D8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_charWidthMaxAdj; // 0x2DC
		protected float m_charWidthAdjDelta; // 0x2E0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_enableWordWrapping; // 0x2E4
		protected bool m_isCharacterWrappingEnabled; // 0x2E5
		protected bool m_isNonBreakingSpace; // 0x2E6
		protected bool m_isIgnoringAlignment; // 0x2E7
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_wordWrappingRatios; // 0x2E8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TextOverflowModes m_overflowMode; // 0x2EC
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected int m_firstOverflowCharacterIndex; // 0x2F0
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_Text m_linkedTextComponent; // 0x2F8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_isLinkedTextComponent; // 0x300
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_isTextTruncated; // 0x301
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_enableKerning; // 0x302
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_enableExtraPadding; // 0x303
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool checkPaddingRequired; // 0x304
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_isRichText; // 0x305
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_parseCtrlCharacters; // 0x306
		protected bool m_isOverlay; // 0x307
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_isOrthographic; // 0x308
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_isCullingEnabled; // 0x309
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_ignoreRectMaskCulling; // 0x30A
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_ignoreCulling; // 0x30B
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TextureMappingOptions m_horizontalMapping; // 0x30C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TextureMappingOptions m_verticalMapping; // 0x310
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected float m_uvLineOffset; // 0x314
		protected TextRenderFlags m_renderMode; // 0x318
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected VertexSortingOrder m_geometrySortingOrder; // 0x31C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_VertexBufferAutoSizeReduction; // 0x320
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected int m_firstVisibleCharacter; // 0x324
		protected int m_maxVisibleCharacters; // 0x328
		protected int m_maxVisibleWords; // 0x32C
		protected int m_maxVisibleLines; // 0x330
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_useMaxVisibleDescender; // 0x334
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected int m_pageToDisplay; // 0x338
		protected bool m_isNewPage; // 0x33C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected Vector4 m_margin; // 0x340
		protected float m_marginLeft; // 0x350
		protected float m_marginRight; // 0x354
		protected float m_marginWidth; // 0x358
		protected float m_marginHeight; // 0x35C
		protected float m_width; // 0x360
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_TextInfo m_textInfo; // 0x368
		protected bool m_havePropertiesChanged; // 0x370
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_isUsingLegacyAnimationComponent; // 0x371
		protected Transform m_transform; // 0x378
		protected RectTransform m_rectTransform; // 0x380
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private bool <autoSizeTextContainer>k__BackingField; // 0x388
		protected bool m_autoSizeTextContainer; // 0x389
		protected Mesh m_mesh; // 0x390
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected bool m_isVolumetricText; // 0x398
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TMP_SpriteAnimator m_spriteAnimator; // 0x3A0
		protected float m_flexibleHeight; // 0x3A8
		protected float m_flexibleWidth; // 0x3AC
		protected float m_minWidth; // 0x3B0
		protected float m_minHeight; // 0x3B4
		protected float m_maxWidth; // 0x3B8
		protected float m_maxHeight; // 0x3BC
		protected LayoutElement m_LayoutElement; // 0x3C0
		protected float m_preferredWidth; // 0x3C8
		protected float m_renderedWidth; // 0x3CC
		protected bool m_isPreferredWidthDirty; // 0x3D0
		protected float m_preferredHeight; // 0x3D4
		protected float m_renderedHeight; // 0x3D8
		protected bool m_isPreferredHeightDirty; // 0x3DC
		protected bool m_isCalculatingPreferredValues; // 0x3DD
		private int m_recursiveCount; // 0x3E0
		protected int m_layoutPriority; // 0x3E4
		protected bool m_isCalculateSizeRequired; // 0x3E8
		protected bool m_isLayoutDirty; // 0x3E9
		protected bool m_verticesAlreadyDirty; // 0x3EA
		protected bool m_layoutAlreadyDirty; // 0x3EB
		protected bool m_isAwake; // 0x3EC
		internal bool m_isWaitingOnResourceLoad; // 0x3ED
		internal bool m_isInputParsingRequired; // 0x3EE
		internal TextInputSources m_inputSource; // 0x3F0
		protected string old_text; // 0x3F8
		protected float m_fontScale; // 0x400
		protected float m_fontScaleMultiplier; // 0x404
		protected char[] m_htmlTag; // 0x408
		protected RichTextTagAttribute[] m_xmlAttribute; // 0x410
		protected float[] m_attributeParameterValues; // 0x418
		protected float tag_LineIndent; // 0x420
		protected float tag_Indent; // 0x424
		protected TMP_RichTextTagStack<float> m_indentStack; // 0x428
		protected bool tag_NoParsing; // 0x440
		protected bool m_isParsingText; // 0x441
		protected Matrix4x4 m_FXMatrix; // 0x444
		protected bool m_isFXMatrixSet; // 0x484
		protected UnicodeChar[] m_TextParsingBuffer; // 0x488
		private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x490
		protected char[] m_input_CharArray; // 0x498
		private int m_charArray_Length; // 0x4A0
		protected int m_totalCharacterCount; // 0x4A4
		protected WordWrapState m_SavedWordWrapState; // 0x4A8
		protected WordWrapState m_SavedLineState; // 0x738
		protected int m_characterCount; // 0x9C8
		protected int m_firstCharacterOfLine; // 0x9CC
		protected int m_firstVisibleCharacterOfLine; // 0x9D0
		protected int m_lastCharacterOfLine; // 0x9D4
		protected int m_lastVisibleCharacterOfLine; // 0x9D8
		protected int m_lineNumber; // 0x9DC
		protected int m_lineVisibleCharacterCount; // 0x9E0
		protected int m_pageNumber; // 0x9E4
		protected float m_maxAscender; // 0x9E8
		protected float m_maxCapHeight; // 0x9EC
		protected float m_maxDescender; // 0x9F0
		protected float m_maxLineAscender; // 0x9F4
		protected float m_maxLineDescender; // 0x9F8
		protected float m_startOfLineAscender; // 0x9FC
		protected float m_lineOffset; // 0xA00
		protected Extents m_meshExtents; // 0xA04
		protected Color32 m_htmlColor; // 0xA14
		protected TMP_RichTextTagStack<Color32> m_colorStack; // 0xA18
		protected TMP_RichTextTagStack<Color32> m_underlineColorStack; // 0xA30
		protected TMP_RichTextTagStack<Color32> m_strikethroughColorStack; // 0xA48
		protected TMP_RichTextTagStack<Color32> m_highlightColorStack; // 0xA60
		protected TMP_ColorGradient m_colorGradientPreset; // 0xA78
		protected TMP_RichTextTagStack<TMP_ColorGradient> m_colorGradientStack; // 0xA80
		protected float m_tabSpacing; // 0xA98
		protected float m_spacing; // 0xA9C
		protected TMP_RichTextTagStack<int> m_styleStack; // 0xAA0
		protected TMP_RichTextTagStack<int> m_actionStack; // 0xAB8
		protected float m_padding; // 0xAD0
		protected float m_baselineOffset; // 0xAD4
		protected TMP_RichTextTagStack<float> m_baselineOffsetStack; // 0xAD8
		protected float m_xAdvance; // 0xAF0
		protected TMP_TextElementType m_textElementType; // 0xAF4
		protected TMP_TextElement m_cached_TextElement; // 0xAF8
		protected TMP_Character m_cached_Underline_Character; // 0xB00
		protected TMP_Character m_cached_Ellipsis_Character; // 0xB08
		protected TMP_SpriteAsset m_defaultSpriteAsset; // 0xB10
		protected TMP_SpriteAsset m_currentSpriteAsset; // 0xB18
		protected int m_spriteCount; // 0xB20
		protected int m_spriteIndex; // 0xB24
		protected int m_spriteAnimationID; // 0xB28
		protected bool m_ignoreActiveState; // 0xB2C
		private readonly float[] k_Power; // 0xB30
		protected static Vector2 k_LargePositiveVector2; // 0x04
		protected static Vector2 k_LargeNegativeVector2; // 0x0C
		protected static float k_LargePositiveFloat; // 0x14
		protected static float k_LargeNegativeFloat; // 0x18
		protected static int k_LargePositiveInt; // 0x1C
		protected static int k_LargeNegativeInt; // 0x20
	
		// Properties
		public string text { get; set; } // 0x00000001801FE630-0x00000001801FE640 0x0000000180218E80-0x0000000180218F10
		public bool isRightToLeftText { get; set; } // 0x0000000180217170-0x0000000180217180 0x0000000180218600-0x0000000180218660
		public TMP_FontAsset font { get; set; } // 0x00000001802170E0-0x00000001802170F0 0x0000000180218390-0x0000000180218460
		public virtual Material fontSharedMaterial { get; set; } // 0x00000001801DAE50-0x00000001801DAE60 0x00000001802180F0-0x00000001802181C0
		public virtual Material[] fontSharedMaterials { get; set; } // 0x0000000180217070-0x0000000180217090 0x0000000180218090-0x00000001802180F0
		public Material fontMaterial { get; set; } // 0x0000000180217020-0x0000000180217040 0x0000000180217F90-0x0000000180218090
		public virtual Material[] fontMaterials { get; set; } // 0x0000000180217040-0x0000000180217060 0x0000000180218090-0x00000001802180F0
		public override Color color { get; set; } // 0x0000000180216E80-0x0000000180216E90 0x0000000180217CA0-0x0000000180217D10
		public float alpha { get; set; } // 0x0000000180216D30-0x0000000180216D40 0x0000000180217B30-0x0000000180217B60
		public bool enableVertexGradient { get; set; } // 0x0000000180216EC0-0x0000000180216ED0 0x0000000180217E00-0x0000000180217E30
		public VertexGradient colorGradient { get; set; } // 0x0000000180216E50-0x0000000180216E80 0x0000000180217C50-0x0000000180217CA0
		public TMP_ColorGradient colorGradientPreset { get; set; } // 0x0000000180216E40-0x0000000180216E50 0x0000000180217C30-0x0000000180217C50
		public TMP_SpriteAsset spriteAsset { get; set; } // 0x0000000180217990-0x00000001802179A0 0x0000000180218E30-0x0000000180218E80
		public bool tintAllSprites { get; set; } // 0x0000000180217A10-0x0000000180217A20 0x0000000180218F10-0x0000000180218F40
		public bool overrideColorTags { get; set; } // 0x0000000180217520-0x0000000180217530 0x0000000180218C90-0x0000000180218CC0
		public Color32 faceColor { get; set; } // 0x0000000180216EF0-0x0000000180216FE0 0x0000000180217EE0-0x0000000180217F60
		public Color32 outlineColor { get; set; } // 0x0000000180217340-0x0000000180217430 0x0000000180218B60-0x0000000180218BD0
		public float outlineWidth { get; set; } // 0x0000000180217430-0x0000000180217510 0x0000000180218BD0-0x0000000180218C30
		public float fontSize { get; set; } // 0x00000001802170B0-0x00000001802170C0 0x0000000180218260-0x00000001802182D0
		public float fontScale { get; } // 0x0000000180217060-0x0000000180217070 
		public FontWeight fontWeight { get; set; } // 0x00000001802170D0-0x00000001802170E0 0x0000000180218330-0x0000000180218390
		public float pixelsPerUnit { get; } // 0x0000000180217560-0x0000000180217770 
		public bool enableAutoSizing { get; set; } // 0x0000000180216E90-0x0000000180216EA0 0x0000000180217D10-0x0000000180217D60
		public float fontSizeMin { get; set; } // 0x00000001802170A0-0x00000001802170B0 0x0000000180218210-0x0000000180218260
		public float fontSizeMax { get; set; } // 0x0000000180217090-0x00000001802170A0 0x00000001802181C0-0x0000000180218210
		public FontStyles fontStyle { get; set; } // 0x00000001802170C0-0x00000001802170D0 0x00000001802182D0-0x0000000180218330
		public bool isUsingBold { get; } // 0x00000001802171A0-0x00000001802171B0 
		public TextAlignmentOptions alignment { get; set; } // 0x0000000180216D20-0x0000000180216D30 0x0000000180217B00-0x0000000180217B30
		public float characterSpacing { get; set; } // 0x0000000180216E20-0x0000000180216E30 0x0000000180217B70-0x0000000180217BD0
		public float wordSpacing { get; set; } // 0x0000000180217AE0-0x0000000180217AF0 0x0000000180218FC0-0x0000000180219020
		public float lineSpacing { get; set; } // 0x0000000180217280-0x0000000180217290 0x0000000180218740-0x00000001802187A0
		public float lineSpacingAdjustment { get; set; } // 0x0000000180217270-0x0000000180217280 0x00000001802186E0-0x0000000180218740
		public float paragraphSpacing { get; set; } // 0x0000000180217540-0x0000000180217550 0x0000000180218CF0-0x0000000180218D50
		public float characterWidthAdjustment { get; set; } // 0x0000000180216E30-0x0000000180216E40 0x0000000180217BD0-0x0000000180217C30
		public bool enableWordWrapping { get; set; } // 0x0000000180216ED0-0x0000000180216EE0 0x0000000180217E30-0x0000000180217E90
		public float wordWrappingRatios { get; set; } // 0x0000000180217AF0-0x0000000180217B00 0x0000000180219020-0x0000000180219080
		public TextOverflowModes overflowMode { get; set; } // 0x0000000180217510-0x0000000180217520 0x0000000180218C30-0x0000000180218C90
		public bool isTextOverflowing { get; } // 0x0000000180217180-0x0000000180217190 
		public int firstOverflowCharacterIndex { get; } // 0x0000000180216FE0-0x0000000180216FF0 
		public TMP_Text linkedTextComponent { get; set; } // 0x0000000180217290-0x00000001802172A0 0x00000001802187A0-0x00000001802189E0
		public bool isLinkedTextComponent { get; set; } // 0x0000000180217140-0x0000000180217150 0x0000000180218520-0x0000000180218580
		public bool isTextTruncated { get; } // 0x0000000180217190-0x00000001802171A0 
		public bool enableKerning { get; set; } // 0x0000000180216EB0-0x0000000180216EC0 0x0000000180217DA0-0x0000000180217E00
		public bool extraPadding { get; set; } // 0x0000000180216EE0-0x0000000180216EF0 0x0000000180217E90-0x0000000180217EE0
		public bool richText { get; set; } // 0x0000000180217890-0x00000001802178A0 0x0000000180218DD0-0x0000000180218E30
		public bool parseCtrlCharacters { get; set; } // 0x0000000180217550-0x0000000180217560 0x0000000180218D50-0x0000000180218DB0
		public bool isOverlay { get; set; } // 0x0000000180217160-0x0000000180217170 0x00000001802185B0-0x0000000180218600
		public bool isOrthographic { get; set; } // 0x0000000180217150-0x0000000180217160 0x0000000180218580-0x00000001802185B0
		public bool enableCulling { get; set; } // 0x0000000180216EA0-0x0000000180216EB0 0x0000000180217D60-0x0000000180217DA0
		public bool ignoreRectMaskCulling { get; set; } // 0x0000000180217120-0x0000000180217130 0x00000001802184E0-0x0000000180218500
		public bool ignoreVisibility { get; set; } // 0x0000000180217130-0x0000000180217140 0x0000000180218500-0x0000000180218520
		public TextureMappingOptions horizontalMapping { get; set; } // 0x0000000180217110-0x0000000180217120 0x00000001802184B0-0x00000001802184E0
		public TextureMappingOptions verticalMapping { get; set; } // 0x0000000180217AD0-0x0000000180217AE0 0x0000000180218F90-0x0000000180218FC0
		public float mappingUvLineOffset { get; set; } // 0x00000001802172A0-0x00000001802172B0 0x00000001802189E0-0x0000000180218A10
		public TextRenderFlags renderMode { get; set; } // 0x0000000180217880-0x0000000180217890 0x0000000180218DB0-0x0000000180218DD0
		public VertexSortingOrder geometrySortingOrder { get; set; } // 0x00000001802170F0-0x0000000180217100 0x0000000180218460-0x0000000180218480
		public bool vertexBufferAutoSizeReduction { get; set; } // 0x0000000180217AC0-0x0000000180217AD0 0x0000000180218F70-0x0000000180218F90
		public int firstVisibleCharacter { get; set; } // 0x0000000180216FF0-0x0000000180217000 0x0000000180217F60-0x0000000180217F90
		public int maxVisibleCharacters { get; set; } // 0x00000001802172D0-0x00000001802172E0 0x0000000180218AD0-0x0000000180218B00
		public int maxVisibleWords { get; set; } // 0x00000001802172F0-0x0000000180217300 0x0000000180218B30-0x0000000180218B60
		public int maxVisibleLines { get; set; } // 0x00000001802172E0-0x00000001802172F0 0x0000000180218B00-0x0000000180218B30
		public bool useMaxVisibleDescender { get; set; } // 0x0000000180217AB0-0x0000000180217AC0 0x0000000180218F40-0x0000000180218F70
		public int pageToDisplay { get; set; } // 0x0000000180217530-0x0000000180217540 0x0000000180218CC0-0x0000000180218CF0
		public virtual Vector4 margin { get; set; } // 0x00000001802172B0-0x00000001802172C0 0x0000000180218A10-0x0000000180218AD0
		public TMP_TextInfo textInfo { get; } // 0x0000000180217A00-0x0000000180217A10 
		public bool havePropertiesChanged { get; set; } // 0x0000000180217100-0x0000000180217110 0x0000000180218480-0x00000001802184B0
		public bool isUsingLegacyAnimationComponent { get; set; } // 0x00000001802171B0-0x00000001802171C0 0x0000000180218660-0x0000000180218670
		public new Transform transform { get; } // 0x0000000180217A20-0x0000000180217AB0 
		public new RectTransform rectTransform { get; } // 0x00000001802177F0-0x0000000180217880 
		public virtual bool autoSizeTextContainer { [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ get; [CompilerGenerated] /* 0x0000000180110980-0x0000000180110990 */ set; } // 0x0000000180216D40-0x0000000180216D50 0x0000000180217B60-0x0000000180217B70
		public virtual Mesh mesh { get; } // 0x0000000180217310-0x0000000180217320 
		public bool isVolumetricText { get; set; } // 0x00000001802171C0-0x00000001802171D0 0x0000000180218670-0x00000001802186E0
		public Bounds bounds { get; } // 0x0000000180216D50-0x0000000180216E20 
		public Bounds textBounds { get; } // 0x00000001802179A0-0x0000000180217A00 
		protected TMP_SpriteAnimator spriteAnimator { get; } // 0x00000001802178A0-0x0000000180217990 
		public float flexibleHeight { get; } // 0x0000000180217000-0x0000000180217010 
		public float flexibleWidth { get; } // 0x0000000180217010-0x0000000180217020 
		public float minWidth { get; } // 0x0000000180217330-0x0000000180217340 
		public float minHeight { get; } // 0x0000000180217320-0x0000000180217330 
		public float maxWidth { get; } // 0x0000000180217300-0x0000000180217310 
		public float maxHeight { get; } // 0x00000001802172C0-0x00000001802172D0 
		protected LayoutElement layoutElement { get; } // 0x00000001802171D0-0x0000000180217260 
		public virtual float preferredWidth { get; } // 0x00000001802177B0-0x00000001802177F0 
		public virtual float preferredHeight { get; } // 0x0000000180217770-0x00000001802177B0 
		public virtual float renderedWidth { get; } // 0x0000000180207B70-0x0000000180207B90 
		public virtual float renderedHeight { get; } // 0x00000001802079C0-0x00000001802079E0 
		public int layoutPriority { get; } // 0x0000000180217260-0x0000000180217270 
	
		// Nested types
		internal enum TextInputSources // TypeDefIndex: 4259
		{
			Text = 0,
			SetText = 1,
			SetCharArray = 2,
			String = 3
		}
	
		protected struct UnicodeChar // TypeDefIndex: 4260
		{
			// Fields
			public int unicode; // 0x00
			public int stringIndex; // 0x04
			public int length; // 0x08
		}
	
		// Constructors
		protected TMP_Text(); // 0x0000000180216520-0x0000000180216D20
		static TMP_Text(); // 0x0000000180216400-0x0000000180216520
	
		// Methods
		protected virtual void LoadFontAsset(); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual void SetSharedMaterial(Material mat); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual Material GetMaterial(Material mat); // 0x0000000180207150-0x0000000180207160
		protected virtual void SetFontBaseMaterial(Material mat); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual Material[] GetSharedMaterials(); // 0x0000000180207150-0x0000000180207160
		protected virtual void SetSharedMaterials(Material[] materials); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual Material[] GetMaterials(Material[] mats); // 0x0000000180207150-0x0000000180207160
		protected virtual Material CreateMaterialInstance(Material source); // 0x0000000180202E60-0x0000000180202F10
		protected void SetVertexColorGradient(TMP_ColorGradient gradient); // 0x000000018020F730-0x000000018020F7E0
		protected void SetTextSortingOrder(VertexSortingOrder order); // 0x00000001801D8E80-0x00000001801D8E90
		protected void SetTextSortingOrder(int[] order); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual void SetFaceColor(Color32 color); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual void SetOutlineColor(Color32 color); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual void SetOutlineThickness(float thickness); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual void SetShaderDepth(); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual void SetCulling(); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual float GetPaddingForMaterial(); // 0x00000001801F1670-0x00000001801F1680
		protected virtual float GetPaddingForMaterial(Material mat); // 0x00000001801F1670-0x00000001801F1680
		protected virtual Vector3[] GetTextContainerLocalCorners(); // 0x0000000180207150-0x0000000180207160
		public virtual void ForceMeshUpdate(); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void ForceMeshUpdate(bool ignoreActiveState); // 0x00000001801D8E80-0x00000001801D8E90
		internal void SetTextInternal(string text); // 0x000000018020F390-0x000000018020F3E0
		public virtual void UpdateGeometry(Mesh mesh, int index); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void UpdateVertexData(); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void SetVertices(Vector3[] vertices); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void UpdateMeshPadding(); // 0x00000001801D8E80-0x00000001801D8E90
		public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000180202F80-0x0000000180203020
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x0000000180202F10-0x0000000180202F80
		protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x00000001801D8E80-0x00000001801D8E90
		protected void ParseInputText(); // 0x000000018020A340-0x000000018020A3C0
		public void SetText(string text); // 0x000000018020F3E0-0x000000018020F450
		public void SetText(string text, bool syncTextInputBox); // 0x000000018020F3E0-0x000000018020F450
		public void SetText(string text, float arg0); // 0x000000018020F4F0-0x000000018020F520
		public void SetText(string text, float arg0, float arg1); // 0x000000018020F4C0-0x000000018020F4F0
		public void SetText(string text, float arg0, float arg1, float arg2); // 0x000000018020F520-0x000000018020F730
		public void SetText(StringBuilder text); // 0x000000018020F450-0x000000018020F4C0
		public void SetCharArray(char[] sourceText); // 0x000000018020E070-0x000000018020E540
		public void SetCharArray(char[] sourceText, int start, int length); // 0x000000018020EA10-0x000000018020EEE0
		public void SetCharArray(int[] sourceText, int start, int length); // 0x000000018020E540-0x000000018020EA10
		protected void SetTextArrayToCharArray(char[] sourceText, ref UnicodeChar[] charBuffer); // 0x000000018020EEE0-0x000000018020F390
		protected void StringToCharArray(string sourceText, ref UnicodeChar[] charBuffer); // 0x0000000180210020-0x0000000180210B80
		protected void StringBuilderToIntArray(StringBuilder sourceText, ref UnicodeChar[] charBuffer); // 0x000000018020F7E0-0x0000000180210020
		private bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018020B0F0-0x000000018020B400
		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018020B710-0x000000018020BA00
		private bool ReplaceOpeningStyleTag(ref char[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018020AE10-0x000000018020B0F0
		private bool ReplaceOpeningStyleTag(ref StringBuilder sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018020B400-0x000000018020B710
		private bool ReplaceClosingStyleTag(ref string sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018020A660-0x000000018020A8F0
		private bool ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018020A3C0-0x000000018020A660
		private bool ReplaceClosingStyleTag(ref char[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018020AB80-0x000000018020AE10
		private bool ReplaceClosingStyleTag(ref StringBuilder sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex); // 0x000000018020A8F0-0x000000018020AB80
		private bool IsTagName(ref string text, string tag, int index); // 0x0000000180209E70-0x0000000180209F60
		private bool IsTagName(ref char[] text, string tag, int index); // 0x0000000180209F60-0x000000018020A060
		private bool IsTagName(ref int[] text, string tag, int index); // 0x0000000180209C80-0x0000000180209D80
		private bool IsTagName(ref StringBuilder text, string tag, int index); // 0x0000000180209D80-0x0000000180209E70
		private int GetTagHashCode(ref string text, int index, out int closeIndex); // 0x0000000180207FD0-0x0000000180208080
		private int GetTagHashCode(ref char[] text, int index, out int closeIndex); // 0x0000000180207F60-0x0000000180207FD0
		private int GetTagHashCode(ref int[] text, int index, out int closeIndex); // 0x0000000180207E20-0x0000000180207E90
		private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex); // 0x0000000180207E90-0x0000000180207F60
		private void ResizeInternalArray<T>(ref T[] array);
		protected void AddFloatToCharArray(double number, ref int index, int precision); // 0x00000001801FFE70-0x0000000180200080
		protected void AddIntToCharArray(double number, ref int index, int precision); // 0x0000000180200080-0x0000000180200250
		protected virtual int SetArraySizes(UnicodeChar[] chars); // 0x0000000180207150-0x0000000180207160
		protected virtual void GenerateTextMesh(); // 0x00000001801D8E80-0x00000001801D8E90
		public Vector2 GetPreferredValues(); // 0x00000001802074A0-0x0000000180207520
		public Vector2 GetPreferredValues(float width, float height); // 0x0000000180207630-0x00000001802076E0
		public Vector2 GetPreferredValues(string text); // 0x0000000180207520-0x0000000180207630
		public Vector2 GetPreferredValues(string text, float width, float height); // 0x00000001802076E0-0x00000001802077B0
		protected float GetPreferredWidth(); // 0x0000000180207830-0x00000001802079A0
		protected float GetPreferredWidth(Vector2 margin); // 0x00000001802077B0-0x0000000180207830
		protected float GetPreferredHeight(); // 0x0000000180207250-0x0000000180207420
		protected float GetPreferredHeight(Vector2 margin); // 0x0000000180207420-0x00000001802074A0
		public Vector2 GetRenderedValues(); // 0x0000000180207AA0-0x0000000180207B50
		public Vector2 GetRenderedValues(bool onlyVisibleCharacters); // 0x00000001802079E0-0x0000000180207AA0
		protected float GetRenderedWidth(); // 0x0000000180207B70-0x0000000180207B90
		protected float GetRenderedWidth(bool onlyVisibleCharacters); // 0x0000000180207B50-0x0000000180207B70
		protected float GetRenderedHeight(); // 0x00000001802079C0-0x00000001802079E0
		protected float GetRenderedHeight(bool onlyVisibleCharacters); // 0x00000001802079A0-0x00000001802079C0
		protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing); // 0x0000000180200250-0x0000000180202C80
		protected virtual Bounds GetCompoundBounds(); // 0x0000000180207080-0x0000000180207090
		protected Bounds GetTextBounds(); // 0x0000000180208520-0x0000000180208930
		protected Bounds GetTextBounds(bool onlyVisibleCharacters); // 0x0000000180208080-0x0000000180208520
		protected virtual void AdjustLineOffset(int startIndex, int endIndex, float offset); // 0x00000001801D8E80-0x00000001801D8E90
		protected void ResizeLineExtents(int size); // 0x000000018020BA80-0x000000018020BD00
		public virtual TMP_TextInfo GetTextInfo(string text); // 0x0000000180207150-0x0000000180207160
		public virtual void ComputeMarginSize(); // 0x00000001801D8E80-0x00000001801D8E90
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count); // 0x000000018020DC90-0x000000018020E070
		protected int RestoreWordWrappingState(ref WordWrapState state); // 0x000000018020BD00-0x000000018020C120
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor); // 0x000000018020C120-0x000000018020D140
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor); // 0x000000018020D140-0x000000018020DC90
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4); // 0x0000000180205060-0x0000000180205A70
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric); // 0x0000000180205A70-0x0000000180206FA0
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4); // 0x0000000180205060-0x0000000180205A70
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor); // 0x0000000180203790-0x0000000180205060
		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor); // 0x0000000180203020-0x0000000180203790
		protected void LoadDefaultSettings(); // 0x000000018020A060-0x000000018020A2C0
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset); // 0x0000000180207B90-0x0000000180207E20
		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c); // 0x000000018020BA00-0x000000018020BA80
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight); // 0x0000000180207090-0x0000000180207150
		protected virtual void SetActiveSubMeshes(bool state); // 0x00000001801D8E80-0x00000001801D8E90
		protected virtual void ClearSubMeshObjects(); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void ClearMesh(); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual void ClearMesh(bool uploadGeometry); // 0x00000001801D8E80-0x00000001801D8E90
		public virtual string GetParsedText(); // 0x0000000180207160-0x0000000180207250
		protected Vector2 PackUV(float x, float y, float scale); // 0x000000018020A2C0-0x000000018020A300
		protected float PackUV(float x, float y); // 0x000000018020A300-0x000000018020A340
		internal virtual void InternalUpdate(); // 0x00000001801D8E80-0x00000001801D8E90
		protected int HexToInt(char hex); // 0x0000000180209B70-0x0000000180209C80
		protected int GetUTF16(string text, int i); // 0x0000000180208A10-0x0000000180208AF0
		protected int GetUTF16(StringBuilder text, int i); // 0x0000000180208930-0x0000000180208A10
		protected int GetUTF32(string text, int i); // 0x0000000180208AF0-0x0000000180208C80
		protected int GetUTF32(StringBuilder text, int i); // 0x0000000180208C80-0x0000000180208E10
		protected Color32 HexCharsToColor(char[] hexChars, int tagCount); // 0x0000000180208E10-0x0000000180209780
		protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length); // 0x0000000180209780-0x0000000180209B70
		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters); // 0x0000000180206FA0-0x0000000180207080
		protected float ConvertToFloat(char[] chars, int startIndex, int length); // 0x0000000180202C80-0x0000000180202CB0
		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex); // 0x0000000180202CB0-0x0000000180202E60
		protected bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex); // 0x0000000180210B80-0x0000000180216400
	}

	[Serializable]
	public class TMP_TextElement // TypeDefIndex: 4262
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		protected TextElementType m_ElementType; // 0x10
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint m_Unicode; // 0x14
		private Glyph m_Glyph; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private uint m_GlyphIndex; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float m_Scale; // 0x24
	
		// Properties
		public TextElementType elementType { get; } // 0x000000018038C130-0x000000018038C170 
		public uint unicode { get; set; } // 0x00000001803627D0-0x00000001803627E0 0x0000000180362800-0x0000000180362810
		public Glyph glyph { get; set; } // 0x00000001801D0240-0x00000001801D0250 0x00000001801D0280-0x00000001801D0290
		public uint glyphIndex { get; set; } // 0x0000000180289FB0-0x0000000180289FC0 0x000000018034F760-0x000000018034F770
		public float scale { get; set; } // 0x00000001803B53C0-0x00000001803B53D0 0x00000001803B53D0-0x00000001803B53E0
	
		// Constructors
		public TMP_TextElement(); // 0x00000001801D0660-0x00000001801D0670
	}

	[Serializable]
	public class TMP_TextElement_Legacy // TypeDefIndex: 4263
	{
		// Fields
		public int id; // 0x10
		public float x; // 0x14
		public float y; // 0x18
		public float width; // 0x1C
		public float height; // 0x20
		public float xOffset; // 0x24
		public float yOffset; // 0x28
		public float xAdvance; // 0x2C
		public float scale; // 0x30
	
		// Constructors
		public TMP_TextElement_Legacy(); // 0x00000001801D0660-0x00000001801D0670
	}

	public enum TMP_TextElementType // TypeDefIndex: 4251
	{
		Character = 0,
		Sprite = 1
	}

	[Serializable]
	public class TMP_TextInfo // TypeDefIndex: 4264
	{
		// Fields
		private static Vector2 k_InfinityVectorPositive; // 0x00
		private static Vector2 k_InfinityVectorNegative; // 0x08
		public TMP_Text textComponent; // 0x10
		public int characterCount; // 0x18
		public int spriteCount; // 0x1C
		public int spaceCount; // 0x20
		public int wordCount; // 0x24
		public int linkCount; // 0x28
		public int lineCount; // 0x2C
		public int pageCount; // 0x30
		public int materialCount; // 0x34
		public TMP_CharacterInfo[] characterInfo; // 0x38
		public TMP_WordInfo[] wordInfo; // 0x40
		public TMP_LinkInfo[] linkInfo; // 0x48
		public TMP_LineInfo[] lineInfo; // 0x50
		public TMP_PageInfo[] pageInfo; // 0x58
		public TMP_MeshInfo[] meshInfo; // 0x60
		private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68
	
		// Constructors
		public TMP_TextInfo(); // 0x00000001803B6000-0x00000001803B60B0
		public TMP_TextInfo(TMP_Text textComponent); // 0x00000001803B5EE0-0x00000001803B6000
		static TMP_TextInfo(); // 0x00000001803B5E30-0x00000001803B5EE0
	
		// Methods
		public void Clear(); // 0x00000001803B5810-0x00000001803B5890
		public void ClearMeshInfo(bool updateMesh); // 0x00000001803B5700-0x00000001803B5790
		public void ClearAllMeshInfo(); // 0x00000001803B53E0-0x00000001803B5460
		public void ResetVertexLayout(bool isVolumetric); // 0x00000001803B5DA0-0x00000001803B5E30
		public void ClearUnusedVertices(MaterialReference[] materials); // 0x00000001803B5790-0x00000001803B5810
		public void ClearLineInfo(); // 0x00000001803B5460-0x00000001803B5700
		public TMP_MeshInfo[] CopyMeshInfoVertexData(); // 0x00000001803B5890-0x00000001803B5DA0
		public static void Resize<T>(ref T[] array, int size);
		public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
	}

	public class TMP_TextParsingUtilities // TypeDefIndex: 4265
	{
		// Fields
		private static readonly TMP_TextParsingUtilities s_Instance; // 0x00
		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x0021F74A
		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x0021F7CE
	
		// Properties
		public static TMP_TextParsingUtilities instance { get; } // 0x00000001803B63E0-0x00000001803B6440 
	
		// Constructors
		static TMP_TextParsingUtilities(); // 0x00000001803B6380-0x00000001803B63E0
		public TMP_TextParsingUtilities(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public static uint GetHashCode(string s); // 0x00000001803B6110-0x00000001803B61C0
		public static int GetHashCodeCaseSensitive(string s); // 0x00000001803B60B0-0x00000001803B6110
		public static char ToLowerASCIIFast(char c); // 0x00000001803B6260-0x00000001803B62C0
		public static char ToUpperASCIIFast(char c); // 0x00000001803B62C0-0x00000001803B6320
		public static uint ToUpperASCIIFast(uint c); // 0x00000001803B6320-0x00000001803B6380
		public static uint ToLowerASCIIFast(uint c); // 0x00000001803B6200-0x00000001803B6260
		public static bool IsHighSurrogate(uint c); // 0x00000001803B61C0-0x00000001803B61E0
		public static bool IsLowSurrogate(uint c); // 0x00000001803B61E0-0x00000001803B6200
	}

	public static class TMP_TextUtilities // TypeDefIndex: 4268
	{
		// Fields
		private static Vector3[] m_rectWorldCorners; // 0x00
		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x0021F85E
		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x0021F8E2
	
		// Nested types
		private struct LineSegment // TypeDefIndex: 4269
		{
			// Fields
			public Vector3 Point1; // 0x00
			public Vector3 Point2; // 0x0C
	
			// Constructors
			public LineSegment(Vector3 p1, Vector3 p2); // 0x000000018001E300-0x000000018001E330
		}
	
		// Constructors
		static TMP_TextUtilities(); // 0x00000001803BBDF0-0x00000001803BBE40
	
		// Methods
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera); // 0x00000001803BAEE0-0x00000001803BB0E0
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor); // 0x00000001803BAC40-0x00000001803BAEE0
		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803B8E90-0x00000001803B9190
		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly); // 0x00000001803B83D0-0x00000001803B8950
		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera); // 0x00000001803BB540-0x00000001803BB750
		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x00000001803B6740-0x00000001803B6AB0
		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x00000001803B8950-0x00000001803B8E90
		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803B7560-0x00000001803B83D0
		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803B9EE0-0x00000001803BAC40
		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803B6AB0-0x00000001803B6D00
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803B6D00-0x00000001803B7560
		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera); // 0x00000001803B9190-0x00000001803B9EE0
		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d); // 0x00000001803BB750-0x00000001803BB9E0
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint); // 0x00000001803BB9E0-0x00000001803BBC20
		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint); // 0x00000001803BB2A0-0x00000001803BB540
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point); // 0x00000001803B6440-0x00000001803B6740
		public static char ToLowerFast(char c); // 0x00000001803BBD30-0x00000001803BBD90
		public static char ToUpperFast(char c); // 0x00000001803BBD90-0x00000001803BBDF0
		public static int GetSimpleHashCode(string s); // 0x00000001803B60B0-0x00000001803B6110
		public static uint GetSimpleHashCodeLowercase(string s); // 0x00000001803BB0E0-0x00000001803BB190
		public static int HexToInt(char hex); // 0x00000001803BB190-0x00000001803BB2A0
		public static int StringHexToInt(string s); // 0x00000001803BBC20-0x00000001803BBD30
	}

	public class TMP_UpdateManager // TypeDefIndex: 4270
	{
		// Fields
		private static TMP_UpdateManager s_Instance; // 0x00
		private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x10
		private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
		private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x20
		private Dictionary<int, int> m_GraphicQueueLookup; // 0x28
		private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x30
		private Dictionary<int, int> m_InternalUpdateLookup; // 0x38
	
		// Properties
		public static TMP_UpdateManager instance { get; } // 0x00000001803BC9F0-0x00000001803BCA70 
	
		// Constructors
		protected TMP_UpdateManager(); // 0x00000001803BC810-0x00000001803BC9F0
	
		// Methods
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001803BC5E0-0x00000001803BC6A0
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001803BC1C0-0x00000001803BC270
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element); // 0x00000001803BC520-0x00000001803BC5E0
		private bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x00000001803BC100-0x00000001803BC1C0
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element); // 0x00000001803BC460-0x00000001803BC520
		private bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x00000001803BC040-0x00000001803BC100
		private void OnBeginFrameRendering(ScriptableRenderContext renderContext, Camera[] cameras); // 0x00000001803BC450-0x00000001803BC460
		private void OnCameraPreCull(Camera cam); // 0x00000001803BC450-0x00000001803BC460
		private void DoRebuilds(); // 0x00000001803BBE40-0x00000001803BC040
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001803BC7E0-0x00000001803BC810
		public static void UnRegisterTextElementForRebuild(TMP_Text element); // 0x00000001803BC6A0-0x00000001803BC7E0
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element); // 0x00000001803BC270-0x00000001803BC310
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element); // 0x00000001803BC310-0x00000001803BC3B0
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject); // 0x00000001803BC3B0-0x00000001803BC450
	}

	public class TMP_UpdateRegistry // TypeDefIndex: 4271
	{
		// Fields
		private static TMP_UpdateRegistry s_Instance; // 0x00
		private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
		private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
		private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
		private Dictionary<int, int> m_GraphicQueueLookup; // 0x28
	
		// Properties
		public static TMP_UpdateRegistry instance { get; } // 0x00000001803BD730-0x00000001803BD890 
	
		// Constructors
		protected TMP_UpdateRegistry(); // 0x00000001803BD630-0x00000001803BD730
	
		// Methods
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001803BD2F0-0x00000001803BD420
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001803BCBA0-0x00000001803BCCD0
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001803BD1C0-0x00000001803BD2F0
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001803BCA70-0x00000001803BCBA0
		private void PerformUpdateForCanvasRendererObjects(); // 0x00000001803BCED0-0x00000001803BD170
		private void PerformUpdateForMeshRendererObjects(); // 0x00000001803BD170-0x00000001803BD1C0
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element); // 0x00000001803BD420-0x00000001803BD630
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001803BCDD0-0x00000001803BCED0
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001803BCCD0-0x00000001803BCDD0
	}

	public struct TMP_Vertex // TypeDefIndex: 4150
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector2 uv; // 0x0C
		public Vector2 uv2; // 0x14
		public Vector2 uv4; // 0x1C
		public Color32 color; // 0x24
	}

	public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 4277
	{
		None = 0,
		Vertices = 1,
		Uv0 = 2,
		Uv2 = 4,
		Uv4 = 8,
		Colors32 = 16,
		All = 255
	}

	public struct TMP_WordInfo // TypeDefIndex: 4281
	{
		// Fields
		public TMP_Text textComponent; // 0x00
		public int firstCharacterIndex; // 0x08
		public int lastCharacterIndex; // 0x0C
		public int characterCount; // 0x10
	
		// Methods
		public string GetWord(); // 0x000000018001E330-0x000000018001E7A0
	}

	public static class TMPro_EventManager // TypeDefIndex: 4273
	{
		// Fields
		public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x00
		public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x08
		public static readonly FastAction<bool, TMP_FontAsset> FONT_PROPERTY_EVENT; // 0x10
		public static readonly FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
		public static readonly FastAction<bool, TextMeshPro> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
		public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
		public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
		public static readonly FastAction<TMP_ColorGradient> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
		public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
		public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
		public static readonly FastAction<bool, TextMeshProUGUI> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
		public static readonly FastAction OnPreRenderObject_Event; // 0x58
		public static readonly FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT; // 0x60
	
		// Constructors
		static TMPro_EventManager(); // 0x00000001803BDF60-0x00000001803BE1F0
	
		// Methods
		public static void ON_PRE_RENDER_OBJECT_CHANGED(); // 0x00000001803BDB60-0x00000001803BDBD0
		public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat); // 0x00000001803BDAD0-0x00000001803BDB60
		public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, TMP_FontAsset font); // 0x00000001803BDA40-0x00000001803BDAD0
		public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj); // 0x00000001803BDC40-0x00000001803BDCD0
		public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, TextMeshPro obj); // 0x00000001803BDCD0-0x00000001803BDD60
		public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial); // 0x00000001803BD9A0-0x00000001803BDA40
		public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged); // 0x00000001803BDE70-0x00000001803BDEF0
		public static void ON_COLOR_GRAIDENT_PROPERTY_CHANGED(TMP_ColorGradient gradient); // 0x00000001803BD890-0x00000001803BD910
		public static void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x00000001803BDDF0-0x00000001803BDE70
		public static void ON_TMP_SETTINGS_CHANGED(); // 0x00000001803BDEF0-0x00000001803BDF60
		public static void ON_RESOURCES_LOADED(); // 0x00000001803BDBD0-0x00000001803BDC40
		public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, TextMeshProUGUI obj); // 0x00000001803BDD60-0x00000001803BDDF0
		public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e); // 0x00000001803BD910-0x00000001803BD9A0
	}

	public static class TMPro_ExtensionMethods // TypeDefIndex: 4275
	{
		// Extension methods
		public static string ArrayToString(this char[] chars); // 0x00000001803BE1F0-0x00000001803BE2A0
		public static string IntToString(this int[] unicodes); // 0x00000001803BE490-0x00000001803BE530
		public static string IntToString(this int[] unicodes, int start, int length); // 0x00000001803BE530-0x00000001803BE650
		public static int FindInstanceID<T>(this List<T> list, T target)
			where T : UnityEngine.Object;
		public static bool Compare(this Color32 a, Color32 b); // 0x00000001803BE340-0x00000001803BE380
		public static bool CompareRGB(this Color32 a, Color32 b); // 0x00000001803BE2A0-0x00000001803BE2D0
		public static bool Compare(this Color a, Color b); // 0x00000001803BE300-0x00000001803BE340
		public static bool CompareRGB(this Color a, Color b); // 0x00000001803BE2D0-0x00000001803BE300
		public static Color32 Multiply(this Color32 c1, Color32 c2); // 0x00000001803BE650-0x00000001803BE740
		public static Color32 Tint(this Color32 c1, Color32 c2); // 0x00000001803BE650-0x00000001803BE740
		public static Color32 Tint(this Color32 c1, float tint); // 0x00000001803BE740-0x00000001803BE8D0
		public static bool Compare(this Vector3 v1, Vector3 v2, int accuracy); // 0x00000001803BE380-0x00000001803BE3F0
		public static bool Compare(this Quaternion q1, Quaternion q2, int accuracy); // 0x00000001803BE3F0-0x00000001803BE490
	}
}

namespace Placemaker
{
	public class Toolbox : MonoBehaviour // TypeDefIndex: 4639
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		public ToolType currentTool; // 0x20
		public VoxelType currentVoxelType; // 0x21
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ToolsButton undoButton; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ToolsButton redoButton; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ToolsButton clearButton; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ToolsButton[] toolsButtons; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ToolsButton[] colorButtons; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform toolArrow; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform colorArrow; // 0x58
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 4640
		{
			// Fields
			public int index; // 0x10
			public ToolsButton button; // 0x18
			public Toolbox <>4__this; // 0x20
	
			// Constructors
			public <>c__DisplayClass11_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <OnEnable>b__3(); // 0x0000000180B445E0-0x0000000180B446A0
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass11_1 // TypeDefIndex: 4641
		{
			// Fields
			public int index; // 0x10
			public ToolsButton button; // 0x18
			public Toolbox <>4__this; // 0x20
	
			// Constructors
			public <>c__DisplayClass11_1(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <OnEnable>b__4(); // 0x0000000180B446A0-0x0000000180B44760
		}
	
		// Constructors
		public Toolbox(); // 0x0000000180B43540-0x0000000180B435A0
	
		// Methods
		public void SetVoxelType(VoxelType voxelType); // 0x0000000180B430D0-0x0000000180B43120
		private void OnEnable(); // 0x0000000180B42E60-0x0000000180B430D0
		private void Start(); // 0x0000000180B43120-0x0000000180B432F0
		private void LateUpdate(); // 0x0000000180B42D30-0x0000000180B42E60
		private static void UpdateArrow(Transform arrow, float t); // 0x0000000180B43380-0x0000000180B43540
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private void <OnEnable>b__11_0(); // 0x0000000180B432F0-0x0000000180B43320
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private void <OnEnable>b__11_1(); // 0x0000000180B43320-0x0000000180B43350
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private void <OnEnable>b__11_2(); // 0x0000000180B43350-0x0000000180B43380
	}
}

namespace Placemaker.Ui
{
	public class ToolsButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDropHandler // TypeDefIndex: 4717
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public bool hovered; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public bool down; // 0x19
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public bool selected; // 0x1A
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public bool disabled; // 0x1B
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float hoverLerp; // 0x1C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float downLerp; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float selectedLerp; // 0x24
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float disabledLerp; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private DistanceFieldSettings backround; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private DistanceFieldSettings foreground; // 0x38
		public System.Action onClicked; // 0x40
	
		// Constructors
		public ToolsButton(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		void IDropHandler.OnDrop(PointerEventData eventData); // 0x0000000180B7C040-0x0000000180B7C050
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData); // 0x0000000180B7C050-0x0000000180B7C060
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x0000000180B7C060-0x0000000180B7C070
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x0000000180B7C070-0x0000000180B7C0A0
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x0000000180565F10-0x0000000180565F20
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x0000000180B7C0A0-0x0000000180B7C0E0
		private void Start(); // 0x00000001801D8E80-0x00000001801D8E90
		[ContextMenu] // 0x0000000180137940-0x0000000180137970
		private void Setup(); // 0x0000000180B7BE00-0x0000000180B7C040
		private void Update(); // 0x0000000180B7C0E0-0x0000000180B7C560
	}
}

namespace Placemaker
{
	public enum ToolType : sbyte // TypeDefIndex: 4651
	{
		Throwel = 0,
		Paintbrush = 1,
		Bucket = 2,
		Bulldozer = 3
	}
}

namespace I2.Loc
{
	public enum TranslationFlag : byte // TypeDefIndex: 4870
	{
		Normal = 1,
		AutoTranslated = 2
	}

	public class TranslationJob : IDisposable // TypeDefIndex: 4813
	{
		// Fields
		public eJobState mJobState; // 0x10
	
		// Nested types
		public enum eJobState // TypeDefIndex: 4814
		{
			Running = 0,
			Succeeded = 1,
			Failed = 2
		}
	
		// Constructors
		public TranslationJob(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public virtual eJobState GetState(); // 0x00000001801D0C20-0x00000001801D0C30
		public virtual void Dispose(); // 0x00000001801D8E80-0x00000001801D8E90
	}

	public class TranslationJob_GET : TranslationJob_WWW // TypeDefIndex: 4816
	{
		// Fields
		private Dictionary<string, TranslationQuery> _requests; // 0x20
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady; // 0x28
		private List<string> mQueries; // 0x30
		public string mErrorMessage; // 0x38
	
		// Constructors
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady); // 0x0000000180B76A70-0x0000000180B76B10
	
		// Methods
		private void ExecuteNextQuery(); // 0x0000000180B76600-0x0000000180B76700
		public override eJobState GetState(); // 0x0000000180B76700-0x0000000180B76960
		public void ProcessResult(byte[] bytes, string errorMsg); // 0x0000000180B76960-0x0000000180B76A70
	}

	public class TranslationJob_Main : TranslationJob // TypeDefIndex: 4817
	{
		// Fields
		private TranslationJob_WEB mWeb; // 0x18
		private TranslationJob_POST mPost; // 0x20
		private TranslationJob_GET mGet; // 0x28
		private Dictionary<string, TranslationQuery> _requests; // 0x30
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady; // 0x38
		public string mErrorMessage; // 0x40
	
		// Constructors
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady); // 0x0000000180B76DB0-0x0000000180B76E40
	
		// Methods
		public override eJobState GetState(); // 0x0000000180B76B60-0x0000000180B76DB0
		public override void Dispose(); // 0x0000000180B76B10-0x0000000180B76B60
	}

	public class TranslationJob_POST : TranslationJob_WWW // TypeDefIndex: 4818
	{
		// Fields
		private Dictionary<string, TranslationQuery> _requests; // 0x20
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady; // 0x28
	
		// Constructors
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady); // 0x0000000180B770B0-0x0000000180B771F0
	
		// Methods
		public override eJobState GetState(); // 0x0000000180B76E40-0x0000000180B76FB0
		public void ProcessResult(byte[] bytes, string errorMsg); // 0x0000000180B76FB0-0x0000000180B770B0
	}

	public class TranslationJob_WEB : TranslationJob_WWW // TypeDefIndex: 4819
	{
		// Fields
		private Dictionary<string, TranslationQuery> _requests; // 0x20
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady; // 0x28
		public string mErrorMessage; // 0x30
		private string mCurrentBatch_ToLanguageCode; // 0x38
		private string mCurrentBatch_FromLanguageCode; // 0x40
		private List<string> mCurrentBatch_Text; // 0x48
		private List<KeyValuePair<string, string>> mQueries; // 0x50
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4820
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<KeyValuePair<string, string>> <>9__8_0; // 0x08
			public static MatchEvaluator <>9__12_0; // 0x10
			public static MatchEvaluator <>9__12_1; // 0x18
	
			// Constructors
			static <>c(); // 0x0000000180B78100-0x0000000180B78160
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal int <FindAllQueries>b__8_0(KeyValuePair<string, string> a, KeyValuePair<string, string> b); // 0x0000000180B77F60-0x0000000180B77FB0
			internal string <ParseTranslationResult>b__12_0(Match match); // 0x0000000180B77FB0-0x0000000180B78060
			internal string <ParseTranslationResult>b__12_1(Match match); // 0x0000000180B78060-0x0000000180B78100
		}
	
		// Constructors
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady); // 0x0000000180B77EE0-0x0000000180B77F30
	
		// Methods
		private void FindAllQueries(); // 0x0000000180B77550-0x0000000180B77840
		private void ExecuteNextBatch(); // 0x0000000180B771F0-0x0000000180B77550
		public override eJobState GetState(); // 0x0000000180B77840-0x0000000180B779D0
		public void ProcessResult(byte[] bytes, string errorMsg); // 0x0000000180B77DC0-0x0000000180B77EE0
		private string ParseTranslationResult(string html, string OriginalText); // 0x0000000180B779D0-0x0000000180B77DC0
	}

	public class TranslationJob_WWW : TranslationJob // TypeDefIndex: 4815
	{
		// Fields
		public UnityWebRequest www; // 0x18
	
		// Constructors
		public TranslationJob_WWW(); // 0x00000001801D0660-0x00000001801D0670
	
		// Methods
		public override void Dispose(); // 0x0000000180B77F30-0x0000000180B77F60
	}

	public struct TranslationQuery // TypeDefIndex: 4812
	{
		// Fields
		public string OrigText; // 0x00
		public string Text; // 0x08
		public string LanguageCode; // 0x10
		public string[] TargetLanguagesCode; // 0x18
		public string[] Results; // 0x20
		public string[] Tags; // 0x28
	}
}

namespace Os.Utils
{
	[Serializable]
	public struct Triplet<T> // TypeDefIndex: 4930
	{
		// Fields
		public T v0;
		public T v1;
		public T v2;
	
		// Properties
		public T this[int key] { get => default; set {} }
	
		// Constructors
		public Triplet(T v0, T v1, T v2);
	}
}

namespace TMPro
{
	internal class TweenRunner<T> // TypeDefIndex: 4160
		where T : struct, TMPro.ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <Start>d__2 : IEnumerator<object> // TypeDefIndex: 4161
		{
			// Fields
			private int <>1__state;
			private object <>2__current;
			public T tweenInfo;
			private float <elapsedTime>5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180110980-0x0000000180110990 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			public <Start>d__2(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden] // 0x0000000180110980-0x0000000180110990
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TweenRunner();
	
		// Methods
		[IteratorStateMachine] // 0x0000000180128CF0-0x0000000180128D40
		private static IEnumerator Start(T tweenInfo);
		public void Init(MonoBehaviour coroutineContainer);
		public void StartTween(T info);
		public void StopTween();
	}
}

namespace Placemaker
{
	public class UiAudio : MonoBehaviour // TypeDefIndex: 4642
	{
		// Fields
		private int index; // 0x18
		public AudioClip buttonDown; // 0x20
		public AudioClip buttonUp; // 0x28
	
		// Constructors
		public UiAudio(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void Start(); // 0x0000000180B7E210-0x0000000180B7E2D0
		public AudioSource GetAudioSource(); // 0x0000000180B7E0B0-0x0000000180B7E140
		public AudioSource Play(AudioClip clip); // 0x0000000180B7E140-0x0000000180B7E210
	}
}

namespace Placemaker.Ui
{
	public class UiMaster : UIBehaviour, IOnScenePostProcess // TypeDefIndex: 4718
	{
		// Fields
		public WorldMaster worldMaster; // 0x18
		public SaveMenu saveMenu; // 0x20
		public SideMenu sideMenu; // 0x28
		public PaletteMenu paletteMenu; // 0x30
		public Dim dim; // 0x38
		public GameViewRect gameViewRect; // 0x40
		public LoadingUi loadingUi; // 0x48
		public CanvasGroup visibleUi; // 0x50
		public PlayerInput worldInputs; // 0x58
		public PlayerInput uiInputs; // 0x60
		public static UiMaster instance; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform dimSibling; // 0x68
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform loadingUiSibling; // 0x70
		[NonSerialized]
		private List<IUiSetup> uiSetups; // 0x78
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool hasStarted; // 0x80
		[NonSerialized]
		private bool hasSetup; // 0x81
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public UpdateState keyFocus; // 0x88
		[NonSerialized]
		private static List<UpdateState> states; // 0x08
	
		// Nested types
		public interface IUiSetup // TypeDefIndex: 4719
		{
			// Methods
			void OnStart(UiMaster master);
			void OnSetup(UiMaster master);
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 4720
		{
			// Fields
			public UpdateState state; // 0x10
	
			// Constructors
			public <>c__DisplayClass21_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <AddState>b__0(); // 0x0000000180B7CCB0-0x0000000180B7CD30
			internal void <AddState>b__1(); // 0x0000000180B7CD30-0x0000000180B7CDB0
		}
	
		// Constructors
		public UiMaster(); // 0x0000000180B7EDC0-0x0000000180B7EE50
		static UiMaster(); // 0x0000000180B7ED60-0x0000000180B7EDC0
	
		// Methods
		private void OnApplicationQuit(); // 0x0000000180B7EAC0-0x0000000180B7EB00
		public void MaybeSetup(); // 0x0000000180B7E540-0x0000000180B7EAC0
		public void Update(); // 0x0000000180B7EC40-0x0000000180B7ED60
		public static void AddState(UpdateState state); // 0x0000000180B7E300-0x0000000180B7E510
		void IOnScenePostProcess.OnScenePostProcess(bool isBuild); // 0x0000000180B7EB00-0x0000000180B7EB30
		public void AddKeyFocus(); // 0x0000000180B7E2D0-0x0000000180B7E300
		public void RemoveKeyFocus(); // 0x0000000180B7EB30-0x0000000180B7EB60
		public void SubscribeToKeyFocus(UpdateState updateState); // 0x0000000180B7EB60-0x0000000180B7EBE0
		public bool HasKeyFocus(); // 0x0000000180B7E510-0x0000000180B7E540
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private void <SubscribeToKeyFocus>b__26_0(float x); // 0x0000000180B7EBE0-0x0000000180B7EC40
	}

	public class UiScaler : MonoBehaviour // TypeDefIndex: 4721
	{
		// Constructors
		public UiScaler(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		private void OnEnable(); // 0x0000000180B7EEF0-0x0000000180B7EFD0
		[ContextMenu] // 0x0000000180137A20-0x0000000180137A50
		private void SetScale(); // 0x0000000180B7EEF0-0x0000000180B7EFD0
		public static float GetScale(); // 0x0000000180B7EE50-0x0000000180B7EEF0
	}
}

internal static class UISupport // TypeDefIndex: 3600
{
	// Methods
	public static void Initialize(); // 0x0000000180389B80-0x0000000180389BF0
}

namespace Placemaker.Ui
{
	public class UndoRedoButtons : UIBehaviour, UiMaster.IUiSetup // TypeDefIndex: 4722
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private UiMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_Text undoSteps; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private TMP_Text redoSteps; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private BaseButton undoButton; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private BaseButton redoButton; // 0x38
	
		// Constructors
		public UndoRedoButtons(); // 0x00000001802797F0-0x0000000180279800
	
		// Methods
		void Placemaker.Ui.UiMaster.IUiSetup.OnStart(UiMaster master); // 0x0000000180B7F220-0x0000000180B7F2E0
		private void OnQueueChange(int undoCount, int redoCount); // 0x0000000180B7F030-0x0000000180B7F150
		void Placemaker.Ui.UiMaster.IUiSetup.OnSetup(UiMaster master); // 0x0000000180B7F150-0x0000000180B7F220
		public void Button_Undo(); // 0x0000000180B7F000-0x0000000180B7F030
		public void Button_Redo(); // 0x0000000180B7EFD0-0x0000000180B7F000
	}
}

namespace TMPro
{
	internal enum UnicodeCharacter : uint // TypeDefIndex: 4229
	{
		APOSTROPHE = 39,
		HYPHEN_MINUS = 45,
		SOFT_HYPHEN = 173,
		ZERO_WIDTH_SPACE = 8203,
		HYPHEN = 8208,
		NON_BREAKING_HYPHEN = 8209,
		RIGHT_SINGLE_QUOTATION = 8217,
		WORD_JOINER = 8288
	}
}

namespace Os.Utils
{
	[Serializable]
	public class UnityEvent_Float : UnityEvent<float> // TypeDefIndex: 4931
	{
		// Constructors
		public UnityEvent_Float(); // 0x0000000180B78760-0x0000000180B787A0
	}

	[Serializable]
	public class UnityEvent_Int : UnityEvent<int> // TypeDefIndex: 4932
	{
		// Constructors
		public UnityEvent_Int(); // 0x0000000180B787A0-0x0000000180B787E0
	}

	public static class UnityFunctions // TypeDefIndex: 4933
	{
		// Methods
		public static T GetNewObject<T>(string name, Transform parent)
			where T : Component;
		public static T GetNewObject<T>(Transform parent)
			where T : Component;
		public static GameObject GetNewGameObject(string name, Transform parent); // 0x0000000180B787E0-0x0000000180B78AD0
	}
}

namespace Placemaker.Ui
{
	[Serializable]
	public class UpdateState // TypeDefIndex: 4723
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float _current; // 0x10
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float _target; // 0x14
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public bool isUpdating; // 0x18
		public Action<float> onValueChanged; // 0x20
		public Action<float> onTargetChange; // 0x28
		public System.Action onStart; // 0x30
		public System.Action onStop; // 0x38
		public float speed; // 0x40
	
		// Properties
		public bool targetBool { get; set; } // 0x0000000180B7FD30-0x0000000180B7FD50 0x0000000180B7FDB0-0x0000000180B7FDE0
		public bool currentBool { get; set; } // 0x0000000180B7FD10-0x0000000180B7FD30 0x0000000180B7FD50-0x0000000180B7FD90
		public float current { get; set; } // 0x0000000180AE89B0-0x0000000180AE89C0 0x0000000180B7FD90-0x0000000180B7FDB0
		public float target { get; set; } // 0x0000000180395E10-0x0000000180395E20 0x0000000180B7FDE0-0x0000000180B7FE50
	
		// Nested types
		public enum Axis : byte // TypeDefIndex: 4724
		{
			X = 1,
			Y = 2,
			XY = 3,
			Z = 4,
			XZ = 5,
			YZ = 6
		}
	
		[Serializable]
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c // TypeDefIndex: 4725
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action<float> <>9__14_0; // 0x08
			public static Action<float> <>9__14_1; // 0x10
			public static System.Action <>9__14_2; // 0x18
			public static System.Action <>9__14_3; // 0x20
	
			// Constructors
			static <>c(); // 0x0000000180B7E050-0x0000000180B7E0B0
			public <>c(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <.ctor>b__14_0(float <p0>); // 0x00000001801D8E80-0x00000001801D8E90
			internal void <.ctor>b__14_1(float <p0>); // 0x00000001801D8E80-0x00000001801D8E90
			internal void <.ctor>b__14_2(); // 0x00000001801D8E80-0x00000001801D8E90
			internal void <.ctor>b__14_3(); // 0x00000001801D8E80-0x00000001801D8E90
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 4726
		{
			// Fields
			public CanvasGroup canvasGroup; // 0x10
	
			// Constructors
			public <>c__DisplayClass29_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Subscribe>b__0(float x); // 0x0000000180B7CF00-0x0000000180B7CF60
			internal void <Subscribe>b__1(float x); // 0x0000000180B7CF60-0x0000000180B7CF90
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 4727
		{
			// Fields
			public Graphic graphic; // 0x10
	
			// Constructors
			public <>c__DisplayClass30_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <Subscribe>b__0(float x); // 0x0000000180B7CF90-0x0000000180B7D090
		}
	
		[CompilerGenerated] // 0x0000000180110980-0x0000000180110990
		private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 4728
		{
			// Fields
			public Transform transform; // 0x10
			public float scale0; // 0x18
			public float scale1; // 0x1C
			public bool x; // 0x20
			public bool y; // 0x21
			public bool z; // 0x22
	
			// Constructors
			public <>c__DisplayClass33_0(); // 0x00000001801D0660-0x00000001801D0670
	
			// Methods
			internal void <SubscribeScale>b__0(float v); // 0x0000000180B7DA20-0x0000000180B7DB40
		}
	
		// Constructors
		public UpdateState(float value); // 0x0000000180B7FA30-0x0000000180B7FD10
	
		// Methods
		public UpdateState SnapTo(float newValue); // 0x0000000180B7F4C0-0x0000000180B7F4F0
		public UpdateState Follow(float newValue); // 0x0000000180B7F3E0-0x0000000180B7F450
		public UpdateState Snap(); // 0x0000000180B7F4F0-0x0000000180B7F520
		public UpdateState PushValue(); // 0x0000000180B7F450-0x0000000180B7F4C0
		public void Update(); // 0x0000000180B7F970-0x0000000180B7FA30
		private void CheckUpdating(); // 0x0000000180B7F2E0-0x0000000180B7F3E0
		public UpdateState Subscribe(Action<float> action); // 0x0000000180B7F6B0-0x0000000180B7F750
		public UpdateState SubscribeToTarget(Action<float> action); // 0x0000000180B7F610-0x0000000180B7F6B0
		public UpdateState Subscribe(CanvasGroup canvasGroup); // 0x0000000180B7F750-0x0000000180B7F8C0
		public UpdateState Subscribe(Graphic graphic); // 0x0000000180B7F8C0-0x0000000180B7F970
		public void Subscribe(GameObject gameObject); // 0x00000001801D8E80-0x00000001801D8E90
		public UpdateState SubscribeScale(Transform transform, Axis axis = Axis.XY /* Metadata: 0x0021FFBC */, float scale0 = 0f /* Metadata: 0x0021FFBD */, float scale1 = 1f /* Metadata: 0x0021FFC1 */); // 0x0000000180B7F520-0x0000000180B7F610
	}
}

namespace Placemaker.Quads
{
	[Serializable]
	public struct Vert // TypeDefIndex: 4730
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int2 hexPos; // 0x00
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public float2 planePos; // 0x08
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Quad q0; // 0x10
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Quad q1; // 0x54
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Quad q2; // 0x98
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Quad q3; // 0xDC
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Quad q4; // 0x120
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Quad q5; // 0x164
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public sbyte quadCount; // 0x1A8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public float angle; // 0x1AC
	
		// Properties
		public float3 worldPos { get; } // 0x0000000180199290-0x00000001801993B0 
		public bool full { get; } // 0x0000000180199260-0x0000000180199280 
		public bool validPosition { get; } // 0x0000000180199280-0x0000000180199290 
	
		// Methods
		public void AddQuad(Quad quad); // 0x0000000180198F30-0x00000001801991E0
		public void SetQuad(int index, Quad quad); // 0x0000000180199210-0x0000000180199260
		public Quad GetQuad(int index); // 0x00000001801991F0-0x0000000180199210
		public bool ContainsVert(int2 v); // 0x00000001801991E0-0x00000001801991F0
	}
}

namespace TMPro
{
	[Serializable]
	public struct VertexGradient // TypeDefIndex: 4278
	{
		// Fields
		public Color topLeft; // 0x00
		public Color topRight; // 0x10
		public Color bottomLeft; // 0x20
		public Color bottomRight; // 0x30
	
		// Constructors
		public VertexGradient(Color color); // 0x00000001800736E0-0x0000000180073700
		public VertexGradient(Color color0, Color color1, Color color2, Color color3); // 0x0000000180073700-0x0000000180075EC0
	}

	public enum VertexSortingOrder // TypeDefIndex: 4221
	{
		Normal = 0,
		Reverse = 1
	}
}

namespace Placemaker
{
	public class Voxel : MonoBehaviour, IComparable<Voxel> // TypeDefIndex: 4594
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public VoxelType type; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public byte height; // 0x19
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int cost; // 0x1C
	
		// Constructors
		public Voxel(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		int IComparable<Voxel>.CompareTo(Voxel other); // 0x0000000180B80820-0x0000000180B80850
	}

	public class VoxelBounceEffect : MonoBehaviour // TypeDefIndex: 4643
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private MeshFilter mf; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Shader shader; // 0x20
		[SerializeField] // 0x0000000180128FC0-0x0000000180128FF0
		[Space] // 0x0000000180128FC0-0x0000000180128FF0
		private Material material; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private RenderTexture tex; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int count; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int voxelBounceTimeId; // 0x3C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Vector3> verts; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Color32> colors; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<int> tris; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Mesh voxelBounceMesh; // 0x58
	
		// Constructors
		public VoxelBounceEffect(); // 0x0000000180B80770-0x0000000180B80820
	
		// Methods
		public void OnEnable(); // 0x00000001801D8E80-0x00000001801D8E90
		public void OnStart(); // 0x0000000180B805F0-0x0000000180B80710
		public void VoxelPainted(Voxel voxel, Corner corner); // 0x0000000180B80710-0x0000000180B80740
		public void VoxelAdded(Voxel voxel, Corner corner); // 0x0000000180B80710-0x0000000180B80740
		public void VoxelRemoved(Voxel voxel, Corner corner); // 0x0000000180B80740-0x0000000180B80770
		private void AddVoxel(Voxel voxel, Corner corner, bool sign); // 0x0000000180B7FE50-0x0000000180B80300
		public void Begin(); // 0x0000000180B804E0-0x0000000180B80570
		public void MaybeExecute(); // 0x0000000180B80570-0x0000000180B805F0
		public void AppendBuffer(CommandBuffer buffer); // 0x0000000180B80300-0x0000000180B804E0
	}

	[Serializable]
	public struct VoxelData // TypeDefIndex: 4635
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public byte h; // 0x08
		public byte t; // 0x09
	}
}

namespace Placemaker.Graphs
{
	public class VoxelMesh // TypeDefIndex: 4796
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public int2 hexPos; // 0x10
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public byte uses; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		public Mesh mesh; // 0x20
	
		// Constructors
		public VoxelMesh(); // 0x00000001801D0660-0x00000001801D0670
	}
}

namespace Placemaker
{
	public enum VoxelType : sbyte // TypeDefIndex: 4649
	{
		Red = 0,
		Green = 1,
		Blue = 2,
		Yellow = 3,
		Color4 = 4,
		Color5 = 5,
		Color6 = 6,
		Color7 = 7,
		Color8 = 8,
		Color9 = 9,
		Color10 = 10,
		Color11 = 11,
		Color12 = 12,
		Color13 = 13,
		Color14 = 14,
		Ground = 15,
		Any = 16,
		Water = 17,
		Empty = 18
	}

	public class WaveFunctionCollapse : MonoBehaviour // TypeDefIndex: 4644
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private WorldMaster master; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ushort propagationCounter; // 0x20
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private ushort lastStartedPropagation; // 0x22
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Propagation> removeNeighbors; // 0x28
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Propagation> updates; // 0x30
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Propagation> propagations; // 0x38
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Propagation> validations; // 0x40
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Propagation> toCollapse; // 0x48
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Propagation> decorUpdates; // 0x50
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Propagation> decorPropagations; // 0x58
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Propagation> decorToCollapse; // 0x60
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Propagation> decorToBuild; // 0x68
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<LastRemovedStruct> lastRemovals; // 0x70
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<LastRemovedStruct> lastDecorRemovals; // 0x78
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Qube> qubesToRebuild; // 0x80
		private HashSet<int> hashset; // 0x88
		private bool collapseNeedsSorting; // 0x90
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private bool doDebugBreak; // 0x91
	
		// Nested types
		[Serializable]
		private struct LastRemovedStruct // TypeDefIndex: 4645
		{
			// Fields
			public Qube qube; // 0x00
			public ushort side; // 0x08
			public sbyte sideIndex; // 0x0A
			public ushort propagationIndex; // 0x0C
		}
	
		[Serializable]
		private struct Propagation : IComparable<Propagation> // TypeDefIndex: 4646
		{
			// Fields
			public Qube qube; // 0x00
			public ushort propagationIndex; // 0x08
			public uint existanceIndex; // 0x0C
			public byte sideVariationMask; // 0x10
	
			// Methods
			int System.IComparable<Placemaker.WaveFunctionCollapse.Propagation>.CompareTo(Propagation p1); // 0x000000018019C2B0-0x000000018019C4C0
		}
	
		// Constructors
		public WaveFunctionCollapse(); // 0x0000000180B86080-0x0000000180B86280
	
		// Methods
		public void QubeRemoved(Qube qube, byte sideMask); // 0x0000000180B85530-0x0000000180B85770
		public void IteratePropagationCount(); // 0x0000000180B83520-0x0000000180B83540
		public void QubeUpdated(Qube qube); // 0x0000000180B85770-0x0000000180B85840
		public void LaterUpdate(); // 0x0000000180B84AD0-0x0000000180B85030
		public bool Iterate(); // 0x0000000180B83540-0x0000000180B847F0
		public bool IterateDecor(); // 0x0000000180B82AF0-0x0000000180B83520
		public void ResetPropagationCounter(); // 0x0000000180B85F50-0x0000000180B86080
		private bool MaybeQueueQubeForRebuilding(Qube qube); // 0x0000000180B85030-0x0000000180B850B0
		private bool RemovePossibleModule(Qube qube, OrientedModuleSides possibleModule, int index, Qube.Relation6 relations); // 0x0000000180B85A90-0x0000000180B85F50
		private void RemovePossibleDecor(Qube qube, OrientedModuleSides possibleModule, int index, Qube.Relation6 relations); // 0x0000000180B85840-0x0000000180B85A90
		private byte FillQubePossibilities(Qube qube); // 0x0000000180B81E70-0x0000000180B82AF0
		private byte FillDecorPossibilities(Qube qube); // 0x0000000180B81090-0x0000000180B81E70
		private void LastRemoved(Qube qube, ushort side, sbyte sideIndex); // 0x0000000180B847F0-0x0000000180B84AD0
		private void OnDrawGizmos(); // 0x0000000180B850B0-0x0000000180B85530
		private void DrawPropagationGizmo(Propagation propagation); // 0x0000000180B80850-0x0000000180B81090
	}
}

namespace Placemaker.Props
{
	public class WindVane : MonoBehaviour, IPropModifier // TypeDefIndex: 4754
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform compass; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private Transform rotator; // 0x20
	
		// Constructors
		public WindVane(); // 0x00000001801D0210-0x00000001801D0220
	
		// Methods
		void IPropModifier.Apply(WorldMaster master, ref Unity.Mathematics.Random random, Square square, Vector3 ts); // 0x0000000180B45F10-0x0000000180B45FE0
		void IPropModifier.Reset(WorldMaster master, Transform srcT); // 0x00000001801D8E80-0x00000001801D8E90
	}
}

namespace TMPro
{
	public struct WordWrapState // TypeDefIndex: 4285
	{
		// Fields
		public int previous_WordBreak; // 0x00
		public int total_CharacterCount; // 0x04
		public int visible_CharacterCount; // 0x08
		public int visible_SpriteCount; // 0x0C
		public int visible_LinkCount; // 0x10
		public int firstCharacterIndex; // 0x14
		public int firstVisibleCharacterIndex; // 0x18
		public int lastCharacterIndex; // 0x1C
		public int lastVisibleCharIndex; // 0x20
		public int lineNumber; // 0x24
		public float maxCapHeight; // 0x28
		public float maxAscender; // 0x2C
		public float maxDescender; // 0x30
		public float maxLineAscender; // 0x34
		public float maxLineDescender; // 0x38
		public float previousLineAscender; // 0x3C
		public float xAdvance; // 0x40
		public float preferredWidth; // 0x44
		public float preferredHeight; // 0x48
		public float previousLineScale; // 0x4C
		public int wordCount; // 0x50
		public FontStyles fontStyle; // 0x54
		public float fontScale; // 0x58
		public float fontScaleMultiplier; // 0x5C
		public float currentFontSize; // 0x60
		public float baselineOffset; // 0x64
		public float lineOffset; // 0x68
		public TMP_TextInfo textInfo; // 0x70
		public TMP_LineInfo lineInfo; // 0x78
		public Color32 vertexColor; // 0xD4
		public Color32 underlineColor; // 0xD8
		public Color32 strikethroughColor; // 0xDC
		public Color32 highlightColor; // 0xE0
		public TMP_FontStyleStack basicStyleStack; // 0xE4
		public TMP_RichTextTagStack<Color32> colorStack; // 0xF0
		public TMP_RichTextTagStack<Color32> underlineColorStack; // 0x108
		public TMP_RichTextTagStack<Color32> strikethroughColorStack; // 0x120
		public TMP_RichTextTagStack<Color32> highlightColorStack; // 0x138
		public TMP_RichTextTagStack<TMP_ColorGradient> colorGradientStack; // 0x150
		public TMP_RichTextTagStack<float> sizeStack; // 0x168
		public TMP_RichTextTagStack<float> indentStack; // 0x180
		public TMP_RichTextTagStack<FontWeight> fontWeightStack; // 0x198
		public TMP_RichTextTagStack<int> styleStack; // 0x1B0
		public TMP_RichTextTagStack<float> baselineStack; // 0x1C8
		public TMP_RichTextTagStack<int> actionStack; // 0x1E0
		public TMP_RichTextTagStack<MaterialReference> materialReferenceStack; // 0x1F8
		public TMP_RichTextTagStack<TextAlignmentOptions> lineJustificationStack; // 0x240
		public int spriteAnimationID; // 0x258
		public TMP_FontAsset currentFontAsset; // 0x260
		public TMP_SpriteAsset currentSpriteAsset; // 0x268
		public Material currentMaterial; // 0x270
		public int currentMaterialIndex; // 0x278
		public Extents meshExtents; // 0x27C
		public bool tagNoParsing; // 0x28C
		public bool isNonBreakingSpace; // 0x28D
	}
}

namespace Placemaker
{
	public class WorldMaster : MonoBehaviour, IOnScenePostProcess // TypeDefIndex: 4654
	{
		// Fields
		public UiMaster uiMaster; // 0x18
		public GridGenerator grid; // 0x20
		public GroundClicker groundClicker; // 0x28
		public Maker maker; // 0x30
		public Graph graph; // 0x38
		public ModuleLibrary moduleLibrary; // 0x40
		public WorldMeshes worldMeshes; // 0x48
		public WaveFunctionCollapse waveFunctionCollapse; // 0x50
		public Focus focus; // 0x58
		public AoBaker aoBaker; // 0x60
		public HoverHightlight hoverHightlight; // 0x68
		public MaterialMaster materialMaster; // 0x70
		public ClickEffect clickEffect; // 0x78
		public ModuleBuilder moduleBuilder; // 0x80
		public TextSaveSystem textSaveSystem; // 0x88
		public HoverData hoverData; // 0x90
		public PropPlacer propPlacer; // 0x98
		public BorderDrawer borderDrawer; // 0xA0
		public BirdFlock flock; // 0xA8
		public Sandbanker sandbanker; // 0xB0
		public AudioSourcePool audioSourcePool; // 0xB8
		public UiAudio uiAudioSourcePool; // 0xC0
		public SaveCamera saveCamera; // 0xC8
		public ScreenshotCamera screenshotCamera; // 0xD0
		public SaveDataScripableObject defaultSaveData; // 0xD8
		public PropMeshAnimator propMeshAnimator; // 0xE0
		public MiscReferences miscReferences; // 0xE8
		public ButterflyFlock butterflyFlock; // 0xF0
		public KeyInputManager keyInputManager; // 0xF8
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private string lastSaveString; // 0x100
		[Space] // 0x0000000180131590-0x00000001801315A0
		public bool stopFrame; // 0x108
		public Stopwatch stopwatch; // 0x110
		public bool startedCounting; // 0x118
		private SaveData saveData; // 0x120
		private static WorldMaster instance; // 0x00
		public static float expTFast; // 0x08
		public static float expTFaster; // 0x0C
		private bool doGo; // 0x128
		private bool pause; // 0x129
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private float milliseconds; // 0x12C
		public State state; // 0x130
		private List<string> stateStrings; // 0x138
		public bool anyChange; // 0x140
	
		// Properties
		public bool keeepGoing { get; } // 0x0000000180B868D0-0x0000000180B86910 
		public bool notLoading { get; } // 0x0000000180B87370-0x0000000180B873A0 
	
		// Nested types
		public enum YieldType : byte // TypeDefIndex: 4655
		{
			KeepGoing = 0,
			SkipFrame = 1
		}
	
		public enum State : byte // TypeDefIndex: 4656
		{
			DoNothing = 0,
			StartLoad = 1,
			PreLoad = 2,
			LoadCleanupQubes0 = 3,
			LoadCleanupProps0 = 4,
			ResetPropAnimator = 5,
			AwaitDim = 6,
			BeginLoadGraph = 7,
			LoadGraph = 8,
			LoadGraphFocus = 9,
			LoadOthers = 10,
			LoadCleanupQubes1 = 11,
			LoadCleanupProps1 = 12,
			NormalStart = 13,
			GraphFocus = 14,
			GridFocus = 15,
			Graph = 16,
			WaveFunctionCollapse = 17,
			WaveFunctionCollapseDecor = 18,
			WaveFunctionCollapseReset = 19,
			Sandbanker = 20,
			GraphRefillPools = 21,
			Grass = 22,
			SpawnBirds = 23,
			CleanupRemovedQubes = 24,
			CleanupProps = 25,
			ResetPropPlacer = 26,
			IterateRefillWorldMeshPools = 27,
			SaveToUrl = 28,
			GridBits = 29,
			Done = 30
		}
	
		public interface IOnOnEnable // TypeDefIndex: 4657
		{
			// Methods
			void OnOnEnable(WorldMaster worldMaster);
		}
	
		// Constructors
		public WorldMaster(); // 0x0000000180B872F0-0x0000000180B87370
	
		// Methods
		public bool KeepGoing(); // 0x0000000180B868D0-0x0000000180B86910
		public void StartCounting(); // 0x0000000180B86FF0-0x0000000180B87040
		public void StopGoing(); // 0x0000000180B87040-0x0000000180B87050
		public void Pause(); // 0x0000000180B86DB0-0x0000000180B86DC0
		public void OnOnEnable(); // 0x0000000180B86B00-0x0000000180B86D20
		public void SetDirty(); // 0x0000000180B86FE0-0x0000000180B86FF0
		public void ResetState(); // 0x0000000180B86EA0-0x0000000180B86EB0
		public void OnStart(); // 0x0000000180B86D20-0x0000000180B86DB0
		public void Begin(); // 0x0000000180B86280-0x0000000180B862B0
		private void Update(); // 0x0000000180B87050-0x0000000180B872F0
		private bool Iterate(); // 0x0000000180B86370-0x0000000180B868D0
		private void LaterUpdate(); // 0x0000000180B86940-0x0000000180B86960
		private void LateUpdate(); // 0x0000000180B86910-0x0000000180B86940
		public void PopulateSaveData(SaveData saveData); // 0x0000000180B86DC0-0x0000000180B86EA0
		public string GetSaveString(); // 0x0000000180B862B0-0x0000000180B86370
		public void Load(SaveData saveData); // 0x0000000180B86A50-0x0000000180B86AB0
		public bool SaveCurrentAndLoadAsNew(string saveString); // 0x0000000180B86EB0-0x0000000180B86FE0
		public bool Load(string saveString); // 0x0000000180B86960-0x0000000180B86A50
		public void New(); // 0x0000000180B86AB0-0x0000000180B86B00
		void IOnScenePostProcess.OnScenePostProcess(bool isBuild); // 0x0000000180B7EB00-0x0000000180B7EB30
	}

	public class WorldMeshes : MonoBehaviour // TypeDefIndex: 4658
	{
		// Fields
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int mfIterator; // 0x18
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private int meshIterator; // 0x1C
		[SerializeField] // 0x0000000180110980-0x0000000180110990
		private List<Mesh> meshStack; // 0x20
	
		// Constructors
		public WorldMeshes(); // 0x0000000180B88000-0x0000000180B88060
	
		// Methods
		private Mesh GetNewMesh(); // 0x0000000180B878B0-0x0000000180B87910
		public Mesh GetMesh(); // 0x0000000180B87760-0x0000000180B87840
		private MeshFilter GetNewMeshFilter(Transform parent); // 0x0000000180B87840-0x0000000180B878B0
		public MeshFilter GetMeshFilterOnly(Transform parent); // 0x0000000180B873A0-0x0000000180B87510
		public MeshFilter GetMeshFilter(Transform parent); // 0x0000000180B87510-0x0000000180B87760
		public void ReturnMesh(Mesh mesh); // 0x0000000180B87F90-0x0000000180B88000
		public void ReturnMeshFilterOnly(MeshFilter mf); // 0x0000000180B87AA0-0x0000000180B87C50
		public void ReturnMeshFilter(MeshFilter mf); // 0x0000000180B87C50-0x0000000180B87EC0
		public void ReturnMeshFilters(Transform container); // 0x0000000180B87EC0-0x0000000180B87F90
		public bool IterateRefillPools(WorldMaster master); // 0x0000000180B87910-0x0000000180B87AA0
	}
}

namespace MS.Internal.Xml.Cache
{
	internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 1695
	{
		// Fields
		private XPathNode[] pageCurrent; // 0x10
		private XPathNode[] pageParent; // 0x18
		private int idxCurrent; // 0x20
		private int idxParent; // 0x24
	
		// Properties
		public override string Value { get; } // 0x000000018064E9E0-0x000000018064EC80 
		public override XPathNodeType NodeType { get; } // 0x000000018064E950-0x000000018064E990 
		public override string LocalName { get; } // 0x000000018064E860-0x000000018064E8B0 
		public override string NamespaceURI { get; } // 0x000000018064E900-0x000000018064E950 
		public override string Prefix { get; } // 0x000000018064E990-0x000000018064E9E0 
		public override XmlNameTable NameTable { get; } // 0x000000018064E8B0-0x000000018064E900 
		public override object UnderlyingObject { get; } // 0x0000000180457E20-0x0000000180457E40 
		public int LineNumber { get; } // 0x000000018064E700-0x000000018064E7A0 
		public int LinePosition { get; } // 0x000000018064E7A0-0x000000018064E860 
	
		// Constructors
		public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent); // 0x000000018064E670-0x000000018064E700
	
		// Methods
		public override XPathNavigator Clone(); // 0x000000018064E080-0x000000018064E150
		public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope); // 0x000000018064E1F0-0x000000018064E430
		public override bool MoveToNextNamespace(XPathNamespaceScope scope); // 0x000000018064E430-0x000000018064E5E0
		public override bool MoveToParent(); // 0x000000018064E5E0-0x000000018064E670
		public override bool IsSamePosition(XPathNavigator other); // 0x000000018064E160-0x000000018064E1F0
		public int GetPositionHashCode(); // 0x000000018064E150-0x000000018064E160
	}

	internal struct XPathNode // TypeDefIndex: 1696
	{
		// Fields
		private XPathNodeInfoAtom info; // 0x00
		private ushort idxSibling; // 0x08
		private ushort idxParent; // 0x0A
		private ushort idxSimilar; // 0x0C
		private ushort posOffset; // 0x0E
		private uint props; // 0x10
		private string value; // 0x18
	
		// Properties
		public XPathNodeType NodeType { get; } // 0x0000000180058AE0-0x0000000180058AF0 
		public string Prefix { get; } // 0x0000000180058B10-0x0000000180058BC0 
		public string LocalName { get; } // 0x000000018001BAB0-0x000000018001BAD0 
		public string NamespaceUri { get; } // 0x0000000180058AC0-0x0000000180058AE0 
		public XPathDocument Document { get; } // 0x0000000180058950-0x0000000180058970 
		public int LineNumber { get; } // 0x0000000180058A70-0x0000000180058AA0 
		public int LinePosition { get; } // 0x0000000180058AA0-0x0000000180058AC0 
		public int CollapsedLinePosition { get; } // 0x0000000180058920-0x0000000180058950 
		public XPathNodePageInfo PageInfo { get; } // 0x0000000180058AF0-0x0000000180058B10 
		public bool IsXmlNamespaceNode { get; } // 0x0000000180058A00-0x0000000180058A70 
		public bool HasSibling { get; } // 0x0000000180058990-0x00000001800589A0 
		public bool HasCollapsedText { get; } // 0x0000000180058970-0x0000000180058980 
		public bool IsText { get; } // 0x00000001800589A0-0x0000000180058A00 
		public bool HasNamespaceDecls { get; } // 0x0000000180058980-0x0000000180058990 
		public string Value { get; } // 0x0000000180017450-0x0000000180017460 
	
		// Methods
		public int GetParent(out XPathNode[] pageNode); // 0x00000001800588C0-0x00000001800588F0
		public int GetSibling(out XPathNode[] pageNode); // 0x00000001800588F0-0x0000000180058920
	}

	internal abstract class XPathNodeHelper // TypeDefIndex: 1698
	{
		// Methods
		public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp); // 0x000000018064ED70-0x000000018064EDF0
		public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp); // 0x000000018064EC80-0x000000018064ED70
		public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode); // 0x000000018064EF10-0x000000018064EF70
		public static int GetLocation(XPathNode[] pageNode, int idxNode); // 0x000000018064EDF0-0x000000018064EE40
		public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd); // 0x000000018064EF70-0x000000018064F660
		public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode); // 0x000000018064EE40-0x000000018064EF10
	}

	internal sealed class XPathNodeInfoAtom // TypeDefIndex: 1700
	{
		// Fields
		private string localName; // 0x10
		private string namespaceUri; // 0x18
		private string prefix; // 0x20
		private XPathNode[] pageParent; // 0x28
		private XPathNode[] pageSibling; // 0x30
		private XPathDocument doc; // 0x38
		private int lineNumBase; // 0x40
		private int linePosBase; // 0x44
		private XPathNodePageInfo pageInfo; // 0x48
	
		// Properties
		public XPathNodePageInfo PageInfo { get; } // 0x00000001801FC9E0-0x00000001801FC9F0 
		public string LocalName { get; } // 0x00000001801D2960-0x00000001801D2970 
		public string NamespaceUri { get; } // 0x00000001801D0240-0x00000001801D0250 
		public string Prefix { get; } // 0x00000001801D0220-0x00000001801D0230 
		public XPathNode[] SiblingPage { get; } // 0x00000001801D0250-0x00000001801D0260 
		public XPathNode[] ParentPage { get; } // 0x00000001801D0230-0x00000001801D0240 
		public XPathDocument Document { get; } // 0x00000001801FD420-0x00000001801FD430 
		public int LineNumberBase { get; } // 0x00000001803EDC50-0x00000001803EDC60 
		public int LinePositionBase { get; } // 0x0000000180385630-0x0000000180385640 
	}

	internal sealed class XPathNodePageInfo // TypeDefIndex: 1699
	{
		// Fields
		private int pageNum; // 0x10
		private int nodeCount; // 0x14
		private XPathNode[] pageNext; // 0x18
	
		// Properties
		public int PageNumber { get; } // 0x00000001801D0C20-0x00000001801D0C30 
		public int NodeCount { get; } // 0x00000001803627D0-0x00000001803627E0 
		public XPathNode[] NextPage { get; } // 0x00000001801D0240-0x00000001801D0250 
	}

	internal struct XPathNodeRef // TypeDefIndex: 1697
	{
		// Fields
		private XPathNode[] page; // 0x00
		private int idx; // 0x08
	
		// Properties
		public XPathNode[] Page { get; } // 0x0000000180004900-0x0000000180004940 
		public int Index { get; } // 0x0000000180017410-0x0000000180017450 
	
		// Constructors
		public XPathNodeRef(XPathNode[] page, int idx); // 0x00000001800468E0-0x00000001800468F0
	
		// Methods
		public override int GetHashCode(); // 0x0000000180058850-0x00000001800588C0
	}
}
