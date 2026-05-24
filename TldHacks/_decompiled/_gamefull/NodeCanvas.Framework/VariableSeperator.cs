using Cpp2ILInjected;

namespace NodeCanvas.Framework;

[Token(Token = "0x200108C")]
public class VariableSeperator
{
	[Token(Token = "0x1700081C")]
	[field: Token(Token = "0x40085DA")]
	[field: FieldOffset(Offset = "0x10")]
	public bool isEditingName
	{
		[Token(Token = "0x60070A0")]
		[Address(RVA = "0x504260", Offset = "0x503060", Length = "0x5")]
		get;
		[Token(Token = "0x60070A1")]
		[Address(RVA = "0x4B7B30", Offset = "0x4B6930", Length = "0x4")]
		set;
	}

	[Token(Token = "0x60070A2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public VariableSeperator()
	{
	}
}
