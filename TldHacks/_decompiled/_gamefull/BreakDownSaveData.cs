using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200054F")]
public class BreakDownSaveData
{
	[Token(Token = "0x4003129")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x400312A")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_HasBeenBrokenDown;

	[Token(Token = "0x400312B")]
	[FieldOffset(Offset = "0x20")]
	public string m_Guid;

	[Token(Token = "0x60028C2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BreakDownSaveData()
	{
	}
}
