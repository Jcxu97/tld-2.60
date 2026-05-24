using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000694")]
public class VistaLocationData
{
	[Token(Token = "0x4004493")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4004494")]
	[FieldOffset(Offset = "0x18")]
	public string m_MapRevealMaskPath;

	[Token(Token = "0x4004495")]
	[FieldOffset(Offset = "0x20")]
	public Vector4 m_MaskOffsets;

	[Token(Token = "0x4004496")]
	[FieldOffset(Offset = "0x30")]
	public float m_Time;

	[Token(Token = "0x6003820")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public VistaLocationData()
	{
	}
}
