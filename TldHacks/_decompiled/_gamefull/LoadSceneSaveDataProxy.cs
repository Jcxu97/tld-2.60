using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20006F6")]
public class LoadSceneSaveDataProxy
{
	[Token(Token = "0x40049F9")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x40049FA")]
	[FieldOffset(Offset = "0x20")]
	public string m_GUID;

	[Token(Token = "0x40049FB")]
	[FieldOffset(Offset = "0x28")]
	public bool m_Explored;

	[Token(Token = "0x40049FC")]
	[FieldOffset(Offset = "0x30")]
	public string m_GameGuid;

	[Token(Token = "0x40049FD")]
	[FieldOffset(Offset = "0x38")]
	public string m_LockSerialized;

	[Token(Token = "0x6003D10")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LoadSceneSaveDataProxy()
	{
	}
}
