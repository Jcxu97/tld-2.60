using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Platforms.Custom;
using UnityEngine;

namespace Rewired.Demos.CustomPlatform;

[Serializable]
[Token(Token = "0x2000C64")]
public class CustomPlatformHardwareJoystickMapPlatformDataSet : ScriptableObject
{
	[Token(Token = "0x4007D8E")]
	[FieldOffset(Offset = "0x18")]
	public List<HardwareJoystickMapCustomPlatformMapSO> platformMaps;

	[Token(Token = "0x600642F")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public CustomPlatformHardwareJoystickMapPlatformDataSet()
	{
	}
}
