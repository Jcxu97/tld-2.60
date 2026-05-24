using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D9C")]
public abstract class fsObjectProcessor
{
	[Token(Token = "0x6006A10")]
	[Address(RVA = "0x107F9D0", Offset = "0x107E7D0", Length = "0x3E")]
	public virtual bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A11")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnBeforeSerialize(Type storageType, object instance)
	{
	}

	[Token(Token = "0x6006A12")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data)
	{
	}

	[Token(Token = "0x6006A13")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnBeforeDeserialize(Type storageType, ref fsData data)
	{
	}

	[Token(Token = "0x6006A14")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
	{
	}

	[Token(Token = "0x6006A15")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnAfterDeserialize(Type storageType, object instance)
	{
	}

	[Token(Token = "0x6006A16")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected fsObjectProcessor()
	{
	}
}
