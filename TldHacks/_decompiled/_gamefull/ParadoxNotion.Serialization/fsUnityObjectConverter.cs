using System;
using Cpp2ILInjected;
using ParadoxNotion.Serialization.FullSerializer;

namespace ParadoxNotion.Serialization;

[Token(Token = "0x2000D80")]
public class fsUnityObjectConverter : fsConverter
{
	[Token(Token = "0x600695B")]
	[Address(RVA = "0x1073790", Offset = "0x1072590", Length = "0xCE")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x600695C")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x600695D")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x600695E")]
	[Address(RVA = "0x1073860", Offset = "0x1072660", Length = "0x2A3")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x600695F")]
	[Address(RVA = "0x1073B10", Offset = "0x1072910", Length = "0x247")]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006960")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006961")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsUnityObjectConverter()
	{
	}
}
