using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear.Migration;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
[Token(Token = "0x2001449")]
public class MigratedLootTableAttribute : PropertyAttribute
{
	[Token(Token = "0x17000B2C")]
	[field: Token(Token = "0x40093A0")]
	[field: FieldOffset(Offset = "0x18")]
	public string LegacyFieldName
	{
		[Token(Token = "0x600813C")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x600813D")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x600813E")]
	[Address(RVA = "0x4A5700", Offset = "0x4A4500", Length = "0x52")]
	public MigratedLootTableAttribute(string legacyFieldName)
	{
	}
}
