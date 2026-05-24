using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace ParadoxNotion;

[Token(Token = "0x2000D62")]
public static class TypeConverter
{
	[Token(Token = "0x2000D63")]
	public delegate Func<object, object> CustomConverter(Type fromType, Type toType);

	[Token(Token = "0x1400001E")]
	public static event CustomConverter customConverter
	{
		[CompilerGenerated]
		[Token(Token = "0x6006885")]
		[Address(RVA = "0x1067E10", Offset = "0x1066C10", Length = "0x10A")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6006886")]
		[Address(RVA = "0x1067F20", Offset = "0x1066D20", Length = "0x10A")]
		remove
		{
		}
	}

	[Token(Token = "0x6006887")]
	[Address(RVA = "0x1068030", Offset = "0x1066E30", Length = "0x1405")]
	public static Func<object, object> Get(Type fromType, Type toType)
	{
		return null;
	}

	[Token(Token = "0x6006888")]
	[Address(RVA = "0x1069440", Offset = "0x1068240", Length = "0x17")]
	public static bool CanConvert(Type fromType, Type toType)
	{
		return false;
	}
}
