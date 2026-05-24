using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000957")]
public struct SnowImprintExpanded
{
	[Token(Token = "0x40060BE")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 m_Position;

	[Token(Token = "0x40060BF")]
	[FieldOffset(Offset = "0xC")]
	public Vector4 m_HeightMapUvInfo;

	[Token(Token = "0x40060C0")]
	[FieldOffset(Offset = "0x1C")]
	public Vector4 m_DecalMainTexUvInfo;

	[Token(Token = "0x40060C1")]
	[FieldOffset(Offset = "0x2C")]
	public Vector4 m_DecalBumpMapUvInfo;

	[Token(Token = "0x40060C2")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 m_HeightMapRenderScalar;

	[Token(Token = "0x40060C3")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 m_NormalMapRenderScalar;

	[Token(Token = "0x40060C4")]
	[FieldOffset(Offset = "0x54")]
	public Quaternion m_UpRot;

	[Token(Token = "0x40060C5")]
	[FieldOffset(Offset = "0x64")]
	public Quaternion m_NormRot;

	[Token(Token = "0x40060C6")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 m_Normal;

	[Token(Token = "0x40060C7")]
	[FieldOffset(Offset = "0x80")]
	public float m_Depth;

	[Token(Token = "0x40060C8")]
	[FieldOffset(Offset = "0x84")]
	public float m_InitialSnowDepth;

	[Token(Token = "0x40060C9")]
	[FieldOffset(Offset = "0x88")]
	public float m_Flip;

	[Token(Token = "0x40060CA")]
	[FieldOffset(Offset = "0x8C")]
	public bool m_HasHeightMap;

	[Token(Token = "0x40060CB")]
	[FieldOffset(Offset = "0x8D")]
	public bool m_HasBumpDecal;

	[Token(Token = "0x600547B")]
	[Address(RVA = "0xE82260", Offset = "0xE81060", Length = "0xA72")]
	public SnowImprintExpanded(SnowImprint im)
	{
		m_Position = default(Vector3);
		m_HeightMapUvInfo = default(Vector4);
		m_DecalMainTexUvInfo = default(Vector4);
		m_DecalBumpMapUvInfo = default(Vector4);
		m_HeightMapRenderScalar = default(Vector3);
		m_NormalMapRenderScalar = default(Vector3);
		m_UpRot = default(Quaternion);
		m_NormRot = default(Quaternion);
		m_Normal = default(Vector3);
		m_Depth = 0f;
		m_InitialSnowDepth = 0f;
		m_Flip = 0f;
		m_HasHeightMap = false;
		m_HasBumpDecal = false;
	}

	[Token(Token = "0x600547C")]
	[Address(RVA = "0xE82CE0", Offset = "0xE81AE0", Length = "0x50")]
	public static explicit operator SnowImprintExpanded(SnowImprint im)
	{
		return default(SnowImprintExpanded);
	}
}
