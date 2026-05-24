using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200028D")]
public class SurveyListItem : MonoBehaviour
{
	[Token(Token = "0x200028E")]
	public delegate void OnDisplayItemClicked(int index);

	[Token(Token = "0x4001718")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_AchievementNameLabel;

	[Token(Token = "0x4001719")]
	[FieldOffset(Offset = "0x28")]
	public UIButton m_Button;

	[Token(Token = "0x400171A")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_Background;

	[Token(Token = "0x400171B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_Complete;

	[Token(Token = "0x400171C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_Incomplete;

	[Token(Token = "0x400171D")]
	[FieldOffset(Offset = "0x48")]
	public Color m_Normal;

	[Token(Token = "0x400171E")]
	[FieldOffset(Offset = "0x58")]
	public Color m_Selected;

	[NonSerialized]
	[Token(Token = "0x400171F")]
	[FieldOffset(Offset = "0x68")]
	public int m_Index;

	[NonSerialized]
	[Token(Token = "0x4001720")]
	[FieldOffset(Offset = "0x70")]
	public OnDisplayItemClicked m_ClickedDelegate;

	[Token(Token = "0x60015FF")]
	[Address(RVA = "0x6AE6D0", Offset = "0x6AD4D0", Length = "0xF1")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001600")]
	[Address(RVA = "0x6AE7D0", Offset = "0x6AD5D0", Length = "0x66")]
	public void SetAchievementInfo(SurveyAchievementInfo sai)
	{
	}

	[Token(Token = "0x6001601")]
	[Address(RVA = "0x6AE840", Offset = "0x6AD640", Length = "0x19")]
	public void OnListClicked()
	{
	}

	[Token(Token = "0x6001602")]
	[Address(RVA = "0x6AE860", Offset = "0x6AD660", Length = "0x12D")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6001603")]
	[Address(RVA = "0x6AE990", Offset = "0x6AD790", Length = "0x4A")]
	public SurveyListItem()
	{
	}
}
