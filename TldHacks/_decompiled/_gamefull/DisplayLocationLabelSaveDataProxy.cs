using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005D6")]
public class DisplayLocationLabelSaveDataProxy
{
	[Token(Token = "0x40035DD")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x40035DE")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_Logged;

	[Token(Token = "0x40035DF")]
	[FieldOffset(Offset = "0x1D")]
	public bool m_PlayedStinger;

	[Token(Token = "0x40035E0")]
	[FieldOffset(Offset = "0x20")]
	public float m_CoolDownTimeLeft;

	[Token(Token = "0x40035E1")]
	[FieldOffset(Offset = "0x28")]
	public string m_Guid;

	[Token(Token = "0x6002D40")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DisplayLocationLabelSaveDataProxy()
	{
	}
}
