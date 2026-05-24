using System;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DAC")]
public class fsPrimitiveConverter : fsConverter
{
	[Token(Token = "0x6006A81")]
	[Address(RVA = "0x108B220", Offset = "0x108A020", Length = "0x127")]
	public override bool CanProcess(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A82")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x6006A83")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	[Token(Token = "0x6006A84")]
	[Address(RVA = "0x108B350", Offset = "0x108A150", Length = "0x7E")]
	private static bool UseBool(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A85")]
	[Address(RVA = "0x108B3D0", Offset = "0x108A1D0", Length = "0x225")]
	private static bool UseInt64(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A86")]
	[Address(RVA = "0x108B600", Offset = "0x108A400", Length = "0x156")]
	private static bool UseDouble(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A87")]
	[Address(RVA = "0x108B760", Offset = "0x108A560", Length = "0xE0")]
	private static bool UseString(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006A88")]
	[Address(RVA = "0x108B840", Offset = "0x108A640", Length = "0x86C")]
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A89")]
	[Address(RVA = "0x108C0B0", Offset = "0x108AEB0", Length = "0x7F5")]
	public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A8A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public fsPrimitiveConverter()
	{
	}
}
