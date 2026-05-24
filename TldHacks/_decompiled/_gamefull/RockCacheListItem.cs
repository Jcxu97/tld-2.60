using System;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000272")]
public class RockCacheListItem : MonoBehaviour
{
	[Token(Token = "0x2000273")]
	public delegate void OnDisplayItemClicked(int index);

	[SerializeField]
	[Token(Token = "0x4001662")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x4001663")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x4001664")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_CustomNameLabel;

	[Token(Token = "0x4001665")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_RegionNameLabel;

	[Token(Token = "0x4001666")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_RegionUndiscoveredLabel;

	[Token(Token = "0x4001667")]
	[FieldOffset(Offset = "0x48")]
	public Color m_RegionDiscoverColor;

	[Token(Token = "0x4001668")]
	[FieldOffset(Offset = "0x58")]
	public Color m_RegionUndiscoverColor;

	[Token(Token = "0x4001669")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_RockCacheCount;

	[Token(Token = "0x400166A")]
	[FieldOffset(Offset = "0x70")]
	public UIButton m_Button;

	[Token(Token = "0x400166B")]
	[FieldOffset(Offset = "0x78")]
	public UISprite m_Background;

	[Token(Token = "0x400166C")]
	[FieldOffset(Offset = "0x80")]
	public UITexture m_RegionBackground;

	[NonSerialized]
	[Token(Token = "0x400166D")]
	[FieldOffset(Offset = "0x88")]
	public int m_Index;

	[Token(Token = "0x400166E")]
	[FieldOffset(Offset = "0x8C")]
	public Color m_Normal;

	[Token(Token = "0x400166F")]
	[FieldOffset(Offset = "0x9C")]
	public Color m_Selected;

	[NonSerialized]
	[Token(Token = "0x4001670")]
	[FieldOffset(Offset = "0xB0")]
	public string m_RockCacheGuid;

	[NonSerialized]
	[Token(Token = "0x4001671")]
	[FieldOffset(Offset = "0xB8")]
	public OnDisplayItemClicked m_ClickedDelegate;

	[Token(Token = "0x600156F")]
	[Address(RVA = "0x6A0CC0", Offset = "0x69FAC0", Length = "0x25F")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001570")]
	[Address(RVA = "0x6A0F20", Offset = "0x69FD20", Length = "0x1F")]
	public void OnRockCacheListClicked()
	{
	}

	[Token(Token = "0x6001571")]
	[Address(RVA = "0x6A0F40", Offset = "0x69FD40", Length = "0x41D")]
	public void SetRegionInfo(int rockCacheCount, string sceneName)
	{
	}

	[Token(Token = "0x6001572")]
	[Address(RVA = "0x6A1360", Offset = "0x6A0160", Length = "0xE1")]
	public void SetItemInfo(RockCacheInfo itemInfo)
	{
	}

	[Token(Token = "0x6001573")]
	[Address(RVA = "0x6A1450", Offset = "0x6A0250", Length = "0x13D")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6001574")]
	[Address(RVA = "0x676860", Offset = "0x675660", Length = "0x4D")]
	public RockCacheListItem()
	{
	}
}
