using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005B4")]
public class StickToGroundSaveData
{
	[Token(Token = "0x40034BF")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x40034C0")]
	[FieldOffset(Offset = "0x20")]
	public string m_Guid;

	[Token(Token = "0x6002C25")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public StickToGroundSaveData()
	{
	}
}
