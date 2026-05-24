using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000585")]
public class HarvestableSaveDataProxy
{
	[Token(Token = "0x40032CE")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x40032CF")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_Harvested;

	[Token(Token = "0x40032D0")]
	[FieldOffset(Offset = "0x20")]
	public float m_RefreshTime;

	[Token(Token = "0x40032D1")]
	[FieldOffset(Offset = "0x28")]
	public string m_Guid;

	[Token(Token = "0x6002A88")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HarvestableSaveDataProxy()
	{
	}
}
