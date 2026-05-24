using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009CF")]
public class PlayMusicTriggerSaveDataProxy
{
	[Token(Token = "0x40063A3")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x40063A4")]
	[FieldOffset(Offset = "0x1C")]
	public int m_NumPlays;

	[Token(Token = "0x40063A5")]
	[FieldOffset(Offset = "0x20")]
	public string m_Guid;

	[Token(Token = "0x40063A6")]
	[FieldOffset(Offset = "0x28")]
	public string m_ObjectLinkGuid;

	[Token(Token = "0x60056A3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayMusicTriggerSaveDataProxy()
	{
	}
}
