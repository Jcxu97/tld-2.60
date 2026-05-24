using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using ParadoxNotion.Serialization.FullSerializer.Internal;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000DA1")]
public class fsMetaType
{
	[Token(Token = "0x2000DA2")]
	private delegate object ObjectGenerator();

	[Token(Token = "0x4008463")]
	private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> _configMetaTypes;

	[Token(Token = "0x4008464")]
	[FieldOffset(Offset = "0x10")]
	private ObjectGenerator generator;

	[Token(Token = "0x1700074C")]
	[field: Token(Token = "0x4008465")]
	[field: FieldOffset(Offset = "0x18")]
	public Type reflectedType
	{
		[Token(Token = "0x6006A46")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006A47")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x1700074D")]
	[field: Token(Token = "0x4008466")]
	[field: FieldOffset(Offset = "0x20")]
	public fsMetaProperty[] Properties
	{
		[Token(Token = "0x6006A48")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get;
		[Token(Token = "0x6006A49")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6006A44")]
	[Address(RVA = "0x10858A0", Offset = "0x10846A0", Length = "0x21D")]
	public static fsMetaType Get(fsConfig config, Type type)
	{
		return null;
	}

	[Token(Token = "0x6006A45")]
	[Address(RVA = "0x1085AC0", Offset = "0x10848C0", Length = "0xE7")]
	public static void ClearCache()
	{
	}

	[Token(Token = "0x6006A4A")]
	[Address(RVA = "0x1085BB0", Offset = "0x10849B0", Length = "0x1E7")]
	private fsMetaType(fsConfig config, Type reflectedType)
	{
	}

	[Token(Token = "0x6006A4B")]
	[Address(RVA = "0x1085DA0", Offset = "0x1084BA0", Length = "0x30A")]
	private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
	{
	}

	[Token(Token = "0x6006A4C")]
	[Address(RVA = "0x10860B0", Offset = "0x1084EB0", Length = "0x2EA")]
	private static bool CanSerializeField(fsConfig config, FieldInfo field)
	{
		return false;
	}

	[Token(Token = "0x6006A4D")]
	[Address(RVA = "0x10863A0", Offset = "0x10851A0", Length = "0x3DE")]
	private static ObjectGenerator GetGenerator(Type reflectedType)
	{
		return null;
	}

	[Token(Token = "0x6006A4E")]
	[Address(RVA = "0x1086780", Offset = "0x1085580", Length = "0x1C8")]
	private static bool HasDefaultConstructor(Type reflectedType)
	{
		return false;
	}

	[Token(Token = "0x6006A4F")]
	[Address(RVA = "0x1086950", Offset = "0x1085750", Length = "0x2E6")]
	public object CreateInstance()
	{
		return null;
	}
}
