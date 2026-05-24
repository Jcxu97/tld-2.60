using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008DA")]
public class BrokenIceSaveDataProxy
{
	[Token(Token = "0x4005C9C")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 m_Position;

	[Token(Token = "0x4005C9D")]
	[FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x4005C9E")]
	[FieldOffset(Offset = "0x1C")]
	public float m_PlacementDay;

	[Token(Token = "0x6005155")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BrokenIceSaveDataProxy()
	{
	}
}
