using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D8E")]
public abstract class fsBaseConverter
{
	[Token(Token = "0x4008430")]
	[FieldOffset(Offset = "0x10")]
	public fsSerializer Serializer;

	[Token(Token = "0x60069AB")]
	[Address(RVA = "0x1077EE0", Offset = "0x1076CE0", Length = "0x186")]
	public virtual object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x60069AC")]
	[Address(RVA = "0x1078070", Offset = "0x1076E70", Length = "0xCF")]
	public virtual bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x60069AD")]
	[Address(RVA = "0x1078140", Offset = "0x1076F40", Length = "0x34")]
	public virtual bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x60069AE")]
	public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);

	[Token(Token = "0x60069AF")]
	public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);

	[Token(Token = "0x60069B0")]
	[Address(RVA = "0x1078180", Offset = "0x1076F80", Length = "0x496")]
	protected fsResult FailExpectedType(fsData data, params fsDataType[] types)
	{
		return default(fsResult);
	}

	[Token(Token = "0x60069B1")]
	[Address(RVA = "0x1078620", Offset = "0x1077420", Length = "0x26A")]
	protected fsResult CheckType(fsData data, fsDataType type)
	{
		return default(fsResult);
	}

	[Token(Token = "0x60069B2")]
	[Address(RVA = "0x1078890", Offset = "0x1077690", Length = "0x9E")]
	protected fsResult CheckKey(fsData data, string key, out fsData subitem)
	{
		subitem = null;
		return default(fsResult);
	}

	[Token(Token = "0x60069B3")]
	[Address(RVA = "0x1078930", Offset = "0x1077730", Length = "0x1ED")]
	protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
	{
		subitem = null;
		return default(fsResult);
	}

	[Token(Token = "0x60069B4")]
	[Address(RVA = "0x1A5F210", Offset = "0x1A5E010", Length = "0x1A3")]
	protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value)
	{
		return default(fsResult);
	}

	[Token(Token = "0x60069B5")]
	[Address(RVA = "0x1A5DFC0", Offset = "0x1A5CDC0", Length = "0x22C")]
	protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value)
	{
		value = default(T);
		return default(fsResult);
	}

	[Token(Token = "0x60069B6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected fsBaseConverter()
	{
	}
}
