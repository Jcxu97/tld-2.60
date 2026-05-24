using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200064E")]
public class Panel_Extras : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x200064F")]
	public class ExtraMenuItem
	{
		[Token(Token = "0x2000650")]
		public enum ExtraMenuItemType
		{
			[Token(Token = "0x4003CE8")]
			Journals,
			[Token(Token = "0x4003CE9")]
			Migration,
			[Token(Token = "0x4003CEA")]
			Back
		}

		[Token(Token = "0x4003CE5")]
		[FieldOffset(Offset = "0x10")]
		public ExtraMenuItemType m_Type;

		[Token(Token = "0x4003CE6")]
		[FieldOffset(Offset = "0x18")]
		public string m_LabelLocalizationId;

		[Token(Token = "0x6003342")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ExtraMenuItem()
		{
		}
	}

	[Token(Token = "0x4003CDB")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Menu")]
	[Token(Token = "0x4003CDC")]
	[FieldOffset(Offset = "0x38")]
	public string m_TitleLocalizationId;

	[Token(Token = "0x4003CDD")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x4003CDE")]
	[FieldOffset(Offset = "0x48")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x4003CDF")]
	[FieldOffset(Offset = "0x50")]
	public List<ExtraMenuItem> m_MenuItems;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003CE0")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Sandbox> m_Sandbox;

	[SerializeField]
	[Token(Token = "0x4003CE1")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_ChooseSandbox> m_ChooseSandbox;

	[SerializeField]
	[Token(Token = "0x4003CE2")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_SaveMigration> m_SaveMigration;

	[Token(Token = "0x4003CE3")]
	[FieldOffset(Offset = "0x70")]
	private ExtraMenuItem m_JournalMenuItem;

	[Token(Token = "0x4003CE4")]
	[FieldOffset(Offset = "0x78")]
	private int m_CreditsEpisode;

	[Token(Token = "0x6003330")]
	[Address(RVA = "0xA09060", Offset = "0xA07E60", Length = "0x11B")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003331")]
	[Address(RVA = "0xA09180", Offset = "0xA07F80", Length = "0x1DA")]
	private void Update()
	{
	}

	[Token(Token = "0x6003332")]
	[Address(RVA = "0xA09360", Offset = "0xA08160", Length = "0xAE")]
	private Action GetActionFromType(ExtraMenuItem.ExtraMenuItemType type)
	{
		return null;
	}

	[Token(Token = "0x6003333")]
	[Address(RVA = "0xA09410", Offset = "0xA08210", Length = "0x2AD")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Token(Token = "0x6003334")]
	[Address(RVA = "0xA096C0", Offset = "0xA084C0", Length = "0x612")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003335")]
	[Address(RVA = "0xA09CE0", Offset = "0xA08AE0", Length = "0x153")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003336")]
	[Address(RVA = "0xA09E40", Offset = "0xA08C40", Length = "0x87")]
	public bool ShouldShowExtras()
	{
		return false;
	}

	[Token(Token = "0x6003337")]
	[Address(RVA = "0xA09ED0", Offset = "0xA08CD0", Length = "0x215")]
	public void OnClickJournals()
	{
	}

	[Token(Token = "0x6003338")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void OnClickMigration()
	{
	}

	[Token(Token = "0x6003339")]
	[Address(RVA = "0x9A9F30", Offset = "0x9A8D30", Length = "0x13")]
	private void OnDoneMigrating()
	{
	}

	[Token(Token = "0x600333A")]
	[Address(RVA = "0xA0A0F0", Offset = "0xA08EF0", Length = "0x1BB")]
	private void PlayCredits(int episodeIndex)
	{
	}

	[Token(Token = "0x600333B")]
	[Address(RVA = "0xA0A2B0", Offset = "0xA090B0", Length = "0x130")]
	private void HandleOnCreditsLoaded(Panel_Base panel)
	{
	}

	[Token(Token = "0x600333C")]
	[Address(RVA = "0x7F6DB0", Offset = "0x7F5BB0", Length = "0x13")]
	private void OnCreditsFadedIn()
	{
	}

	[Token(Token = "0x600333D")]
	[Address(RVA = "0xA0A3F0", Offset = "0xA091F0", Length = "0xA7")]
	private void OnCreditsEnd()
	{
	}

	[Token(Token = "0x600333E")]
	[Address(RVA = "0xA0A4A0", Offset = "0xA092A0", Length = "0x83")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x600333F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003340")]
	[Address(RVA = "0xA0A530", Offset = "0xA09330", Length = "0xF5")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003341")]
	[Address(RVA = "0xA0A630", Offset = "0xA09430", Length = "0xC3")]
	public Panel_Extras()
	{
	}
}
