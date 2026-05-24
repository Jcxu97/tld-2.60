using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000723")]
public class DecalProjectorInstance
{
	[Token(Token = "0x4004B9B")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x4004B9C")]
	[FieldOffset(Offset = "0x18")]
	public string m_DecalName;

	[Token(Token = "0x4004B9D")]
	[FieldOffset(Offset = "0x20")]
	public DecalProjectorType m_DecalProjectorType;

	[Token(Token = "0x4004B9E")]
	[FieldOffset(Offset = "0x24")]
	public float m_HoursAtCreateTime;

	[Token(Token = "0x4004B9F")]
	[FieldOffset(Offset = "0x28")]
	public float m_LifeTimeHours;

	[Token(Token = "0x4004BA0")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_Indoors;

	[Token(Token = "0x4004BA1")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_Pos;

	[Token(Token = "0x4004BA2")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 m_Normal;

	[Token(Token = "0x4004BA3")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 m_Scale;

	[Token(Token = "0x4004BA4")]
	[FieldOffset(Offset = "0x54")]
	public float m_Yaw;

	[Token(Token = "0x4004BA5")]
	[FieldOffset(Offset = "0x58")]
	public int m_CreateUVRectangleIndex;

	[Token(Token = "0x4004BA6")]
	[FieldOffset(Offset = "0x5C")]
	public float m_Alpha;

	[Token(Token = "0x4004BA7")]
	[FieldOffset(Offset = "0x60")]
	public bool m_WasRendered;

	[Token(Token = "0x4004BA8")]
	[FieldOffset(Offset = "0x64")]
	public Color m_ColorTint;

	[Token(Token = "0x4004BA9")]
	[FieldOffset(Offset = "0x74")]
	public bool m_IsPlacing;

	[Token(Token = "0x4004BAA")]
	[FieldOffset(Offset = "0x75")]
	public bool m_IsRevealing;

	[Token(Token = "0x4004BAB")]
	[FieldOffset(Offset = "0x78")]
	public float m_RevealAmount;

	[Token(Token = "0x4004BAC")]
	[FieldOffset(Offset = "0x7C")]
	public float m_EraseAmount;

	[Token(Token = "0x4004BAD")]
	[FieldOffset(Offset = "0x80")]
	public bool m_RevealedOnMap;

	[Token(Token = "0x4004BAE")]
	[FieldOffset(Offset = "0x84")]
	public ProjectileType m_ProjectileType;

	[Token(Token = "0x4004BAF")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_SpawnedObject;

	[Token(Token = "0x4004BB0")]
	[FieldOffset(Offset = "0x90")]
	public List<DecalProjectorMaskData> m_MaskData;

	[Token(Token = "0x4004BB1")]
	[FieldOffset(Offset = "0x98")]
	public bool m_FadeOverEntireLifetime;

	[Token(Token = "0x60040B1")]
	[Address(RVA = "0xC0C2D0", Offset = "0xC0B0D0", Length = "0x57")]
	public Bounds GetBounds()
	{
		return default(Bounds);
	}

	[Token(Token = "0x60040B2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DecalProjectorInstance()
	{
	}
}
