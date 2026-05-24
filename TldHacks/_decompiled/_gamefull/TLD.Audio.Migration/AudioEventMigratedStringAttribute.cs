using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Audio.Migration;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
[Token(Token = "0x20014ED")]
public class AudioEventMigratedStringAttribute : PropertyAttribute
{
	[Token(Token = "0x17000B76")]
	[field: Token(Token = "0x4009752")]
	[field: FieldOffset(Offset = "0x18")]
	public string FormerStringFieldName
	{
		[Token(Token = "0x6008426")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6008427")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6008428")]
	[Address(RVA = "0x4A5700", Offset = "0x4A4500", Length = "0x52")]
	public AudioEventMigratedStringAttribute(string previousStringEventName)
	{
	}
}
