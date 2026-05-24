using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006B4")]
public class Panel_RecipeBook : Panel_AutoReferenced, IMiniTopNav
{
	[SerializeField]
	[Token(Token = "0x4004747")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Cooking> m_Cooking;

	[Token(Token = "0x4004748")]
	[FieldOffset(Offset = "0x38")]
	public MiniTopNav m_MiniTopNav;

	[Token(Token = "0x6003A86")]
	[Address(RVA = "0xB484A0", Offset = "0xB472A0", Length = "0xDA")]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[Token(Token = "0x6003A87")]
	[Address(RVA = "0xB48580", Offset = "0xB47380", Length = "0x8E")]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[Token(Token = "0x6003A88")]
	[Address(RVA = "0xB48610", Offset = "0xB47410", Length = "0xC9")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003A89")]
	[Address(RVA = "0xB486E0", Offset = "0xB474E0", Length = "0x2D")]
	public void DisableFromCooking()
	{
	}

	[Token(Token = "0x6003A8A")]
	[Address(RVA = "0xB3A450", Offset = "0xB39250", Length = "0x38")]
	public void EnableNavigationTabs(bool enable)
	{
	}

	[Token(Token = "0x6003A8B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_RecipeBook()
	{
	}
}
