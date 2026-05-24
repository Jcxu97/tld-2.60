using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Data.Mapping;
using Rewired.Platforms.Custom;

namespace Rewired.Demos.CustomPlatform;

[Token(Token = "0x2000C6C")]
public sealed class MyPlatformHardwareJoystickMapPlatformMap : HardwareJoystickMapCustomPlatformMapSO
{
	[Serializable]
	[Token(Token = "0x2000C6D")]
	public class PlatformMapBase : HardwareJoystickMapCustomPlatformMap<MatchingCriteria>
	{
		[Token(Token = "0x6006444")]
		[Address(RVA = "0xFE3DD0", Offset = "0xFE2BD0", Length = "0x60")]
		protected override object CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6006445")]
		[Address(RVA = "0xFE3E30", Offset = "0xFE2C30", Length = "0x2A")]
		public PlatformMapBase()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C6E")]
	public sealed class PlatformMap : PlatformMapBase
	{
		[Token(Token = "0x4007D99")]
		[FieldOffset(Offset = "0x38")]
		public PlatformMapBase[] variants;

		[Token(Token = "0x6006446")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		public override IList<HardwareJoystickMap.Platform> GetVariants()
		{
			return null;
		}

		[Token(Token = "0x6006447")]
		[Address(RVA = "0xFE3E60", Offset = "0xFE2C60", Length = "0x60")]
		protected override object CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6006448")]
		[Address(RVA = "0xFE3E30", Offset = "0xFE2C30", Length = "0x2A")]
		public PlatformMap()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C6F")]
	public sealed class MatchingCriteria : HardwareJoystickMapCustomPlatformMap.MatchingCriteria
	{
		[Token(Token = "0x4007D9A")]
		[FieldOffset(Offset = "0x40")]
		public uint vendorId;

		[Token(Token = "0x4007D9B")]
		[FieldOffset(Offset = "0x44")]
		public uint productId;

		[Token(Token = "0x6006449")]
		[Address(RVA = "0xFE3EC0", Offset = "0xFE2CC0", Length = "0x8E")]
		public override bool Matches(object customIdentifier)
		{
			return false;
		}

		[Token(Token = "0x600644A")]
		[Address(RVA = "0xFE3F50", Offset = "0xFE2D50", Length = "0x35")]
		protected override object CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x600644B")]
		[Address(RVA = "0xFE3F90", Offset = "0xFE2D90", Length = "0x70")]
		protected override void DeepClone(object destination)
		{
		}

		[Token(Token = "0x600644C")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public MatchingCriteria()
		{
		}
	}

	[Token(Token = "0x4007D98")]
	[FieldOffset(Offset = "0x20")]
	public PlatformMap platformMap;

	[Token(Token = "0x6006442")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public override HardwareJoystickMap.Platform GetPlatformMap()
	{
		return null;
	}

	[Token(Token = "0x6006443")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public MyPlatformHardwareJoystickMapPlatformMap()
	{
	}
}
