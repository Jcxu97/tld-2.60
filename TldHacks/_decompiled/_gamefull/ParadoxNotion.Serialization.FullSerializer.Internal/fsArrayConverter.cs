using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DA7")]
public class fsArrayConverter : fsConverter
{
	[Token(Token = "0x6006A62")]
	[Address(RVA = "0x1087030", Offset = "0x1085E30", Length = "0x2C")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A63")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x6006A64")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x6006A65")]
	[Address(RVA = "0x1087060", Offset = "0x1085E60", Length = "0x3F4")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A66")]
	[Address(RVA = "0x1087460", Offset = "0x1086260", Length = "0x3F6")]
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A67")]
	[Address(RVA = "0x1087860", Offset = "0x1086660", Length = "0x7F")]
	public override object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[Token(Token = "0x6006A68")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsArrayConverter()
	{
	}
}
