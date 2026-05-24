using System;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200028F")]
public class SurveyRegionListItem : MonoBehaviour
{
	[Token(Token = "0x2000290")]
	public delegate void OnDisplayItemClicked(int index);

	[SerializeField]
	[Token(Token = "0x4001721")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Log> m_Log;

	[Token(Token = "0x4001722")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_RegionNameLabel;

	[Token(Token = "0x4001723")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_PercentCompleteLabel;

	[Token(Token = "0x4001724")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_RegionUndiscoveredLabel;

	[Token(Token = "0x4001725")]
	[FieldOffset(Offset = "0x40")]
	public Color m_RegionDiscoverColor;

	[Token(Token = "0x4001726")]
	[FieldOffset(Offset = "0x50")]
	public Color m_RegionUndiscoverColor;

	[Token(Token = "0x4001727")]
	[FieldOffset(Offset = "0x60")]
	public UIButton m_Button;

	[Token(Token = "0x4001728")]
	[FieldOffset(Offset = "0x68")]
	public UISprite m_Background;

	[Token(Token = "0x4001729")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_ProgressBarForeground;

	[Token(Token = "0x400172A")]
	[FieldOffset(Offset = "0x78")]
	public UITexture m_RegionBackground;

	[Token(Token = "0x400172B")]
	[FieldOffset(Offset = "0x80")]
	public Color m_Normal;

	[Token(Token = "0x400172C")]
	[FieldOffset(Offset = "0x90")]
	public Color m_Selected;

	[NonSerialized]
	[Token(Token = "0x400172D")]
	[FieldOffset(Offset = "0xA0")]
	public int m_Index;

	[NonSerialized]
	[Token(Token = "0x400172E")]
	[FieldOffset(Offset = "0xA8")]
	public OnDisplayItemClicked m_ClickedDelegate;

	[Token(Token = "0x6001608")]
	[Address(RVA = "0x6AE9E0", Offset = "0x6AD7E0", Length = "0x3CD")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001609")]
	[Address(RVA = "0x6AEDB0", Offset = "0x6ADBB0", Length = "0x228")]
	public void SetRegionInfo(SurveyRegionInfo sri)
	{
	}

	[Token(Token = "0x600160A")]
	[Address(RVA = "0x6AEFE0", Offset = "0x6ADDE0", Length = "0x1F")]
	public void OnListClicked()
	{
	}

	[Token(Token = "0x600160B")]
	[Address(RVA = "0x6AF000", Offset = "0x6ADE00", Length = "0x13D")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x600160C")]
	[Address(RVA = "0x6AF140", Offset = "0x6ADF40", Length = "0x4D")]
	public SurveyRegionListItem()
	{
	}
}
