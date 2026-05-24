using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DA9")]
public class fsEnumConverter : fsConverter
{
	[Token(Token = "0x6006A6E")]
	[Address(RVA = "0x1089070", Offset = "0x1087E70", Length = "0x2C")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A6F")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x6006A70")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x6006A71")]
	[Address(RVA = "0x10890A0", Offset = "0x1087EA0", Length = "0xD3")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006A72")]
	[Address(RVA = "0x1089180", Offset = "0x1087F80", Length = "0x766")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A73")]
	[Address(RVA = "0x10898F0", Offset = "0x10886F0", Length = "0x6B0")]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A74")]
	[Address(RVA = "0x1A61510", Offset = "0x1A60310", Length = "0xA2")]
	private static bool ArrayContains<T>(T[] values, T value)
	{
		return false;
	}

	[Token(Token = "0x6006A75")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsEnumConverter()
	{
	}
}
