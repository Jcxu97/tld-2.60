using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000484")]
public class FlareGunRoundSaveData
{
	[Token(Token = "0x40028EE")]
	[FieldOffset(Offset = "0x10")]
	public int m_InstanceID;

	[Token(Token = "0x40028EF")]
	[FieldOffset(Offset = "0x18")]
	public string m_HostGuid;

	[Token(Token = "0x40028F0")]
	[FieldOffset(Offset = "0x20")]
	public string m_LocalName;

	[Token(Token = "0x40028F1")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_LocalPosition;

	[Token(Token = "0x40028F2")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_LocalAngles;

	[Token(Token = "0x40028F3")]
	[FieldOffset(Offset = "0x40")]
	public float m_EmbeddedDepth;

	[Token(Token = "0x40028F4")]
	[FieldOffset(Offset = "0x44")]
	public float m_BurnTimer;

	[Token(Token = "0x40028F5")]
	[FieldOffset(Offset = "0x48")]
	public float m_HoursPlayed;

	[Token(Token = "0x40028F6")]
	[FieldOffset(Offset = "0x4C")]
	public FlareGunRoundItem.FlightStatus m_FlightStatus;

	[Token(Token = "0x40028F7")]
	[FieldOffset(Offset = "0x50")]
	public int m_ObjectLayer;

	[Token(Token = "0x40028F8")]
	[FieldOffset(Offset = "0x54")]
	public bool m_IsRendererEnabled;

	[Token(Token = "0x6002213")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FlareGunRoundSaveData()
	{
	}
}
