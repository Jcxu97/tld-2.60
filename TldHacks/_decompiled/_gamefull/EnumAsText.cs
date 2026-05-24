using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000A00")]
public class EnumAsText<T> where T : Enum
{
	[SerializeField]
	[Token(Token = "0x400659D")]
	[FieldOffset(Offset = "0x0")]
	private string m_EnumValueAsString;

	[SerializeField]
	[Token(Token = "0x400659E")]
	[FieldOffset(Offset = "0x0")]
	private T m_EnumValue;

	[Token(Token = "0x6005824")]
	[Address(RVA = "0x2713120", Offset = "0x2711F20", Length = "0x468")]
	public T GetValue()
	{
		return default(T);
	}

	[Token(Token = "0x6005825")]
	[Address(RVA = "0x2713590", Offset = "0x2712390", Length = "0x1A5")]
	public void SetValue(T value)
	{
	}

	[Token(Token = "0x6005826")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public EnumAsText()
	{
	}
}
