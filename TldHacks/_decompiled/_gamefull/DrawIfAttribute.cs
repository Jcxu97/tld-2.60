using System;
using Cpp2ILInjected;
using UnityEngine;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
[Token(Token = "0x20009FF")]
public class DrawIfAttribute : PropertyAttribute
{
	[Token(Token = "0x1700038B")]
	[field: Token(Token = "0x4006598")]
	[field: FieldOffset(Offset = "0x18")]
	public string m_PropertyName
	{
		[Token(Token = "0x6005816")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6005817")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x1700038C")]
	[field: Token(Token = "0x4006599")]
	[field: FieldOffset(Offset = "0x20")]
	public int m_IntValue
	{
		[Token(Token = "0x6005818")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		get;
		[Token(Token = "0x6005819")]
		[Address(RVA = "0x509350", Offset = "0x508150", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x1700038D")]
	[field: Token(Token = "0x400659A")]
	[field: FieldOffset(Offset = "0x24")]
	public bool m_BoolValue
	{
		[Token(Token = "0x600581A")]
		[Address(RVA = "0x621E50", Offset = "0x620C50", Length = "0x5")]
		get;
		[Token(Token = "0x600581B")]
		[Address(RVA = "0x61D6C0", Offset = "0x61C4C0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x1700038E")]
	[field: Token(Token = "0x400659B")]
	[field: FieldOffset(Offset = "0x28")]
	public float m_FloatValue
	{
		[Token(Token = "0x600581C")]
		[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
		get;
		[Token(Token = "0x600581D")]
		[Address(RVA = "0x5042A0", Offset = "0x5030A0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x1700038F")]
	[field: Token(Token = "0x400659C")]
	[field: FieldOffset(Offset = "0x30")]
	public string m_StringValue
	{
		[Token(Token = "0x600581E")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get;
		[Token(Token = "0x600581F")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6005820")]
	[Address(RVA = "0xEE1640", Offset = "0xEE0440", Length = "0x5B")]
	public DrawIfAttribute(string propertyName, int value)
	{
	}

	[Token(Token = "0x6005821")]
	[Address(RVA = "0xEE16A0", Offset = "0xEE04A0", Length = "0x5B")]
	public DrawIfAttribute(string propertyName, bool value)
	{
	}

	[Token(Token = "0x6005822")]
	[Address(RVA = "0xEE1700", Offset = "0xEE0500", Length = "0x60")]
	public DrawIfAttribute(string propertyName, float value)
	{
	}

	[Token(Token = "0x6005823")]
	[Address(RVA = "0xEE1760", Offset = "0xEE0560", Length = "0xBA")]
	public DrawIfAttribute(string propertyName, string value)
	{
	}
}
