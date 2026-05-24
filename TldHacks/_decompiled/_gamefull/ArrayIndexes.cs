using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000033")]
public class ArrayIndexes
{
	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x10")]
	public int[] indexes;

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ArrayIndexes()
	{
	}
}
