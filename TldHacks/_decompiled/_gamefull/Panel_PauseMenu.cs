using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006AD")]
public class Panel_PauseMenu : Panel_AutoReferenced
{
	[Token(Token = "0x20006AE")]
	public enum PauseMenuItemType
	{
		[Token(Token = "0x40046F8")]
		BackToGame,
		[Token(Token = "0x40046F9")]
		Badges,
		[Token(Token = "0x40046FA")]
		Options,
		[Token(Token = "0x40046FB")]
		Quit,
		[Token(Token = "0x40046FC")]
		Debug
	}

	[Token(Token = "0x40046E6")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40046E7")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_GameModeIcon;

	[Token(Token = "0x40046E8")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_BuyNowObject;

	[Token(Token = "0x40046E9")]
	[FieldOffset(Offset = "0x48")]
	public GameObject[] m_ActiveFeatObjects;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40046EA")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_Badges> m_Badges;

	[SerializeField]
	[Token(Token = "0x40046EB")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x40046EC")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x40046ED")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	[SerializeField]
	[Token(Token = "0x40046EE")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_SaveIcon> m_SaveIcon;

	[SerializeField]
	[Token(Token = "0x40046EF")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_Debug> m_PanelDebug;

	[Header("Life After Death")]
	[SerializeField]
	[Token(Token = "0x40046F0")]
	[FieldOffset(Offset = "0x80")]
	private UIGrid m_CampfireGrid;

	[SerializeField]
	[Token(Token = "0x40046F1")]
	[FieldOffset(Offset = "0x88")]
	private GameObject[] m_Campfires;

	[SerializeField]
	[Token(Token = "0x40046F2")]
	[FieldOffset(Offset = "0x90")]
	private GameObject[] m_LitCampfires;

	[Header("Menu")]
	[Token(Token = "0x40046F3")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x40046F4")]
	[FieldOffset(Offset = "0xA0")]
	public List<PauseMenuItemType> m_MenuItems;

	[Token(Token = "0x40046F5")]
	[FieldOffset(Offset = "0xA8")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x40046F6")]
	public static bool m_NoMenuBlur;

	[Token(Token = "0x6003A3D")]
	[Address(RVA = "0xB40030", Offset = "0xB3EE30", Length = "0x15E")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003A3E")]
	[Address(RVA = "0xB40190", Offset = "0xB3EF90", Length = "0x34F")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A3F")]
	[Address(RVA = "0xB404E0", Offset = "0xB3F2E0", Length = "0x105")]
	public Action GetActionFromType(PauseMenuItemType type)
	{
		return null;
	}

	[Token(Token = "0x6003A40")]
	[Address(RVA = "0xB405F0", Offset = "0xB3F3F0", Length = "0x34D")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Token(Token = "0x6003A41")]
	[Address(RVA = "0xB40940", Offset = "0xB3F740", Length = "0x205")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003A42")]
	[Address(RVA = "0xB40B50", Offset = "0xB3F950", Length = "0x20")]
	private void UpdateMenuNavigation()
	{
	}

	[Token(Token = "0x6003A43")]
	[Address(RVA = "0xB40B80", Offset = "0xB3F980", Length = "0x25F")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003A44")]
	[Address(RVA = "0xB40DE0", Offset = "0xB3FBE0", Length = "0x1AC")]
	public void OnQuitGame()
	{
	}

	[Token(Token = "0x6003A45")]
	[Address(RVA = "0xB40F90", Offset = "0xB3FD90", Length = "0x6B")]
	public void DoQuitGame()
	{
	}

	[Token(Token = "0x6003A46")]
	[Address(RVA = "0xB41000", Offset = "0xB3FE00", Length = "0xCC")]
	public void OnBadges()
	{
	}

	[Token(Token = "0x6003A47")]
	[Address(RVA = "0xB410D0", Offset = "0xB3FED0", Length = "0xE6")]
	public void OnOptions()
	{
	}

	[Token(Token = "0x6003A48")]
	[Address(RVA = "0xB411C0", Offset = "0xB3FFC0", Length = "0x128")]
	public void OnDebugPanel()
	{
	}

	[Token(Token = "0x6003A49")]
	[Address(RVA = "0xB412F0", Offset = "0xB400F0", Length = "0x14A")]
	public void OnDone()
	{
	}

	[Token(Token = "0x6003A4A")]
	[Address(RVA = "0xB41440", Offset = "0xB40240", Length = "0x294")]
	private void SetExperienceModeIcon()
	{
	}

	[Token(Token = "0x6003A4B")]
	[Address(RVA = "0xB416E0", Offset = "0xB404E0", Length = "0x45")]
	public void OnBuyNow()
	{
	}

	[Token(Token = "0x6003A4C")]
	[Address(RVA = "0xB41730", Offset = "0xB40530", Length = "0xF5")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003A4D")]
	[Address(RVA = "0xB41830", Offset = "0xB40630", Length = "0x312")]
	private void UpdateSelectedFeats()
	{
	}

	[Token(Token = "0x6003A4E")]
	[Address(RVA = "0xB41B50", Offset = "0xB40950", Length = "0x2F3")]
	private void CleanupSelectedFeats()
	{
	}

	[Token(Token = "0x6003A4F")]
	[Address(RVA = "0xB41E50", Offset = "0xB40C50", Length = "0x268")]
	private void UpdateLifeAfterDeath()
	{
	}

	[Token(Token = "0x6003A50")]
	[Address(RVA = "0xB420C0", Offset = "0xB40EC0", Length = "0xC3")]
	public Panel_PauseMenu()
	{
	}
}
