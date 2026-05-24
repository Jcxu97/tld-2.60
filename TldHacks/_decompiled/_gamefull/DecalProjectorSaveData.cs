using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000724")]
public class DecalProjectorSaveData
{
	[Token(Token = "0x4004BB2")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4004BB3")]
	[FieldOffset(Offset = "0x18")]
	public string m_DecalName;

	[Token(Token = "0x4004BB4")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_Pos;

	[Token(Token = "0x4004BB5")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 m_Normal;

	[Token(Token = "0x4004BB6")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 m_Scale;

	[Token(Token = "0x4004BB7")]
	[FieldOffset(Offset = "0x44")]
	public float m_Yaw;

	[Token(Token = "0x4004BB8")]
	[FieldOffset(Offset = "0x48")]
	public int m_UVRectangleIndex;

	[Token(Token = "0x4004BB9")]
	[FieldOffset(Offset = "0x4C")]
	public DecalProjectorType m_DecalProjectorType;

	[Token(Token = "0x4004BBA")]
	[FieldOffset(Offset = "0x50")]
	public float m_HoursAtCreateTime;

	[Token(Token = "0x4004BBB")]
	[FieldOffset(Offset = "0x54")]
	public float m_LifeTimeHours;

	[Token(Token = "0x4004BBC")]
	[FieldOffset(Offset = "0x58")]
	public bool m_Indoors;

	[Token(Token = "0x4004BBD")]
	[FieldOffset(Offset = "0x5C")]
	public Color m_ColorTint;

	[Token(Token = "0x4004BBE")]
	[FieldOffset(Offset = "0x6C")]
	public bool m_RevealedOnMap;

	[Token(Token = "0x4004BBF")]
	[FieldOffset(Offset = "0x6D")]
	public bool m_FadeOverEntireLifetime;

	[Token(Token = "0x4004BC0")]
	[FieldOffset(Offset = "0x70")]
	public ProjectileType m_ProjectileType;

	[Token(Token = "0x60040B3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DecalProjectorSaveData()
	{
	}
}
