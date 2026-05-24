using System;
using Cpp2ILInjected;
using TLD.Stats;
using UnityEngine;

[Serializable]
[Token(Token = "0x20006D3")]
public class DetailedStatsView : StatsView
{
	[Token(Token = "0x40048C0")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_GameObject;

	[Token(Token = "0x40048C1")]
	[FieldOffset(Offset = "0x18")]
	public ScrollList m_ScrollList;

	[Token(Token = "0x40048C2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_ScrollBarObject;

	[Token(Token = "0x40048C3")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_Sprite_CurrentExperienceMode;

	[Token(Token = "0x40048C4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_CurrentSandboxName;

	[Token(Token = "0x40048C5")]
	[FieldOffset(Offset = "0x38")]
	public int m_FooterEmptyColumnCount;

	[Token(Token = "0x40048C6")]
	[FieldOffset(Offset = "0x40")]
	private StatID[] m_StatsOrderToShow;

	[Token(Token = "0x40048C7")]
	[FieldOffset(Offset = "0x48")]
	private UISlider m_ScrollBar;

	[Token(Token = "0x40048C8")]
	[FieldOffset(Offset = "0x50")]
	private MonoBehaviour m_OwnerContext;

	[Token(Token = "0x6003C10")]
	[Address(RVA = "0xB72260", Offset = "0xB71060", Length = "0x5EB")]
	public void Start(MonoBehaviour ownerContext, string currentSandboxName = null)
	{
	}

	[Token(Token = "0x6003C11")]
	[Address(RVA = "0xB72850", Offset = "0xB71650", Length = "0x842")]
	private void Populate()
	{
	}

	[Token(Token = "0x6003C12")]
	[Address(RVA = "0xB730A0", Offset = "0xB71EA0", Length = "0xFA")]
	public void Update()
	{
	}

	[Token(Token = "0x6003C13")]
	[Address(RVA = "0xB731A0", Offset = "0xB71FA0", Length = "0xAC")]
	public void RefreshScrollBarPosition()
	{
	}

	[Token(Token = "0x6003C14")]
	[Address(RVA = "0xB73250", Offset = "0xB72050", Length = "0x224")]
	public void OnScrollBarPositionChanged()
	{
	}

	[Token(Token = "0x6003C15")]
	[Address(RVA = "0xB73480", Offset = "0xB72280", Length = "0x82")]
	public void ScrollUp()
	{
	}

	[Token(Token = "0x6003C16")]
	[Address(RVA = "0xB73510", Offset = "0xB72310", Length = "0xA6")]
	public void ScrollDown()
	{
	}

	[Token(Token = "0x6003C17")]
	[Address(RVA = "0xB735C0", Offset = "0xB723C0", Length = "0x18D")]
	public void OnResetAllTimeStats()
	{
	}

	[Token(Token = "0x6003C18")]
	[Address(RVA = "0xB73750", Offset = "0xB72550", Length = "0x32B")]
	public void OnResetAllTimeStatsConfirmed()
	{
	}

	[Token(Token = "0x6003C19")]
	[Address(RVA = "0xB73A80", Offset = "0xB72880", Length = "0xBC")]
	public DetailedStatsView()
	{
	}
}
