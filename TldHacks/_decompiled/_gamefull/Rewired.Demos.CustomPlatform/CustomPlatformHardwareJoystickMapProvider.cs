using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Data.Mapping;
using Rewired.Platforms.Custom;

namespace Rewired.Demos.CustomPlatform;

[Serializable]
[Token(Token = "0x2000C65")]
public class CustomPlatformHardwareJoystickMapProvider : IHardwareJoystickMapCustomPlatformMapProvider
{
	[Serializable]
	[Token(Token = "0x2000C66")]
	public class PlatformDataSet
	{
		[Token(Token = "0x4007D90")]
		[FieldOffset(Offset = "0x10")]
		public CustomPlatformType platformType;

		[Token(Token = "0x4007D91")]
		[FieldOffset(Offset = "0x18")]
		public CustomPlatformHardwareJoystickMapPlatformDataSet dataSet;

		[Token(Token = "0x6006434")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PlatformDataSet()
		{
		}
	}

	[Token(Token = "0x4007D8F")]
	[FieldOffset(Offset = "0x10")]
	public List<PlatformDataSet> platformJoystickDataSets;

	[Token(Token = "0x6006430")]
	[Address(RVA = "0xFE2DD0", Offset = "0xFE1BD0", Length = "0x1DA")]
	public HardwareJoystickMap.Platform GetPlatformMap(int customPlatformId, Guid hardwareTypeGuid)
	{
		return null;
	}

	[Token(Token = "0x6006431")]
	[Address(RVA = "0xFE2FB0", Offset = "0xFE1DB0", Length = "0xE3")]
	private CustomPlatformHardwareJoystickMapPlatformDataSet GetPlatformDataSet(int customPlatformId)
	{
		return null;
	}

	[Token(Token = "0x6006432")]
	[Address(RVA = "0xFE30A0", Offset = "0xFE1EA0", Length = "0x27D")]
	private static HardwareJoystickMap.Platform GetPlatformMap(CustomPlatformHardwareJoystickMapPlatformDataSet platformDataSet, Guid hardwareTypeGuid)
	{
		return null;
	}

	[Token(Token = "0x6006433")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CustomPlatformHardwareJoystickMapProvider()
	{
	}
}
