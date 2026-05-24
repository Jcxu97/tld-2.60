using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DAA")]
public class fsForwardConverter : fsConverter
{
	[Token(Token = "0x400846C")]
	[FieldOffset(Offset = "0x18")]
	private string _memberName;

	[Token(Token = "0x6006A76")]
	[Address(RVA = "0x1089FB0", Offset = "0x1088DB0", Length = "0x5C")]
	public fsForwardConverter(fsForwardAttribute attribute)
	{
	}

	[Token(Token = "0x6006A77")]
	[Address(RVA = "0x108A010", Offset = "0x1088E10", Length = "0x4E")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A78")]
	[Address(RVA = "0x108A060", Offset = "0x1088E60", Length = "0x2B3")]
	private fsResult GetProperty(object instance, out fsMetaProperty property)
	{
		property = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A79")]
	[Address(RVA = "0x108A320", Offset = "0x1089120", Length = "0x233")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A7A")]
	[Address(RVA = "0x108A560", Offset = "0x1089360", Length = "0x24C")]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A7B")]
	[Address(RVA = "0x108A7B0", Offset = "0x10895B0", Length = "0x7F")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}
}
