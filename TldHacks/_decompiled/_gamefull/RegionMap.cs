using System;
using Cpp2ILInjected;
using TLD.Scenes;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000699")]
public class RegionMap
{
	[Token(Token = "0x40044BA")]
	[FieldOffset(Offset = "0x10")]
	public string m_RegionName;

	[Token(Token = "0x40044BB")]
	[FieldOffset(Offset = "0x18")]
	public ZoneSpecification m_Zone;

	[Token(Token = "0x40044BC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_RegionMapObject;

	[Token(Token = "0x40044BD")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_CenterOfScene;

	[Token(Token = "0x40044BE")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_RadiusOfScene;

	[Token(Token = "0x40044BF")]
	[FieldOffset(Offset = "0x40")]
	public float m_Angle;

	[Token(Token = "0x6003828")]
	[Address(RVA = "0xAEC990", Offset = "0xAEB790", Length = "0xC7")]
	public bool IsRegionMatch(string regionName)
	{
		return false;
	}

	[Token(Token = "0x6003829")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RegionMap()
	{
	}
}
