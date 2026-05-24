using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DAD")]
public class fsReflectedConverter : fsConverter
{
	[Token(Token = "0x6006A8B")]
	[Address(RVA = "0x108C8B0", Offset = "0x108B6B0", Length = "0xDD")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A8C")]
	[Address(RVA = "0x108C990", Offset = "0x108B790", Length = "0x43A")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A8D")]
	[Address(RVA = "0x108CDD0", Offset = "0x108BBD0", Length = "0x40C")]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A8E")]
	[Address(RVA = "0x108D1E0", Offset = "0x108BFE0", Length = "0x7F")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006A8F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsReflectedConverter()
	{
	}
}
