using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000697")]
public class ClusterCell : MapElementSaveData
{
	[NonSerialized]
	[Token(Token = "0x40044B0")]
	[FieldOffset(Offset = "0x78")]
	public Panel_Map m_Map;

	[NonSerialized]
	[Token(Token = "0x40044B1")]
	[FieldOffset(Offset = "0x80")]
	public int m_MapPosX;

	[NonSerialized]
	[Token(Token = "0x40044B2")]
	[FieldOffset(Offset = "0x84")]
	public int m_MapPosY;

	[NonSerialized]
	[Token(Token = "0x40044B3")]
	[FieldOffset(Offset = "0x88")]
	public float m_Size;

	[NonSerialized]
	[Token(Token = "0x40044B4")]
	[FieldOffset(Offset = "0x8C")]
	public bool m_IsValid;

	[NonSerialized]
	[Token(Token = "0x40044B5")]
	[FieldOffset(Offset = "0x90")]
	public List<MapElementSaveData> m_Elements;

	[Token(Token = "0x6003823")]
	[Address(RVA = "0xAEBFD0", Offset = "0xAEADD0", Length = "0x410")]
	public void UpdateFrom(MapElementSaveData me)
	{
	}

	[Token(Token = "0x6003824")]
	[Address(RVA = "0xAEC3F0", Offset = "0xAEB1F0", Length = "0x5B")]
	public void Remove(MapElementSaveData mesd)
	{
	}

	[Token(Token = "0x6003825")]
	[Address(RVA = "0xAEC450", Offset = "0xAEB250", Length = "0x46F")]
	public void UpdateMapElement()
	{
	}

	[Token(Token = "0x6003826")]
	[Address(RVA = "0xAEC8C0", Offset = "0xAEB6C0", Length = "0xC5")]
	public ClusterCell()
	{
	}
}
