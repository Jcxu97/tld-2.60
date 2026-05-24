using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DA8")]
public class fsDictionaryConverter : fsConverter
{
	[Token(Token = "0x6006A69")]
	[Address(RVA = "0x10878E0", Offset = "0x10866E0", Length = "0xE3")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A6A")]
	[Address(RVA = "0x10879D0", Offset = "0x10867D0", Length = "0x7F")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006A6B")]
	[Address(RVA = "0x1087A50", Offset = "0x1086850", Length = "0xA22")]
	public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A6C")]
	[Address(RVA = "0x1088480", Offset = "0x1087280", Length = "0xBEC")]
	public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A6D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsDictionaryConverter()
	{
	}
}
