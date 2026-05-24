using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200057A")]
public class ElevatorSaveDataProxy
{
	[Token(Token = "0x4003263")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4003264")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_LastSavedPosition;

	[Token(Token = "0x4003265")]
	[FieldOffset(Offset = "0x24")]
	public int m_LastFloorIndex;

	[Token(Token = "0x6002A24")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ElevatorSaveDataProxy()
	{
	}
}
