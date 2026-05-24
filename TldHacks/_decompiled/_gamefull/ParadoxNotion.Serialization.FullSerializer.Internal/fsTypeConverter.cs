using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DAE")]
public class fsTypeConverter : fsConverter
{
	[Token(Token = "0x6006A90")]
	[Address(RVA = "0x108D260", Offset = "0x108C060", Length = "0x81")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A91")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestCycleSupport(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A92")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestInheritanceSupport(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A93")]
	[Address(RVA = "0x108D2F0", Offset = "0x108C0F0", Length = "0x1A7")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A94")]
	[Address(RVA = "0x108D4A0", Offset = "0x108C2A0", Length = "0x21C")]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A95")]
	[Address(RVA = "0x108D6C0", Offset = "0x108C4C0", Length = "0x4")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006A96")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsTypeConverter()
	{
	}
}
