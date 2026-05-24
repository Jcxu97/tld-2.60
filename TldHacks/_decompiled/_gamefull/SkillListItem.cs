using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200027B")]
public class SkillListItem : MonoBehaviour
{
	[Token(Token = "0x200027C")]
	public delegate void OnDisplayItemClicked(int index);

	[Token(Token = "0x40016A4")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget m_FadeOnDeselectWidget;

	[Token(Token = "0x40016A5")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_SkillIcon;

	[Token(Token = "0x40016A6")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_SkillLevel;

	[Token(Token = "0x40016A7")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_ProgressBarName;

	[Token(Token = "0x40016A8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_SkillPoints;

	[Token(Token = "0x40016A9")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_ProgressBarObj;

	[Token(Token = "0x40016AA")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_ProgressBarForeground;

	[Token(Token = "0x40016AB")]
	[FieldOffset(Offset = "0x58")]
	public float m_FillSpriteOffset;

	[Token(Token = "0x40016AC")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_SelectedObj;

	[Token(Token = "0x40016AD")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_UnselectedObj;

	[Token(Token = "0x40016AE")]
	[FieldOffset(Offset = "0x70")]
	public float m_DeslectedAlphaValue;

	[HideInInspector]
	[Token(Token = "0x40016AF")]
	[FieldOffset(Offset = "0x78")]
	public Skill m_Skill;

	[NonSerialized]
	[Token(Token = "0x40016B0")]
	[FieldOffset(Offset = "0x80")]
	public int m_Index;

	[NonSerialized]
	[Token(Token = "0x40016B1")]
	[FieldOffset(Offset = "0x88")]
	public OnDisplayItemClicked m_ClickedDelegate;

	[Token(Token = "0x60015A8")]
	[Address(RVA = "0x6A6A20", Offset = "0x6A5820", Length = "0x1F")]
	public void OnSkillListItemClicked()
	{
	}

	[Token(Token = "0x60015A9")]
	[Address(RVA = "0x6A6A40", Offset = "0x6A5840", Length = "0xB8")]
	public void SetSkillLevel(int level)
	{
	}

	[Token(Token = "0x60015AA")]
	[Address(RVA = "0x6A6B00", Offset = "0x6A5900", Length = "0x1E")]
	public void SetSkillIcon(string icon)
	{
	}

	[Token(Token = "0x60015AB")]
	[Address(RVA = "0x6A6B20", Offset = "0x6A5920", Length = "0x1E")]
	public void SetProgressBarName(string name)
	{
	}

	[Token(Token = "0x60015AC")]
	[Address(RVA = "0x6A6B40", Offset = "0x6A5940", Length = "0x1E")]
	public void SetSkillPoints(string points)
	{
	}

	[Token(Token = "0x60015AD")]
	[Address(RVA = "0x6A6B60", Offset = "0x6A5960", Length = "0x79")]
	public void SetProgress(float normalizedProgress)
	{
	}

	[Token(Token = "0x60015AE")]
	[Address(RVA = "0x6A6BE0", Offset = "0x6A59E0", Length = "0x1E")]
	public void EnableProgressBar(bool enable)
	{
	}

	[Token(Token = "0x60015AF")]
	[Address(RVA = "0x6A6C00", Offset = "0x6A5A00", Length = "0xB3")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60015B0")]
	[Address(RVA = "0x6A6CC0", Offset = "0x6A5AC0", Length = "0x4D")]
	public SkillListItem()
	{
	}
}
