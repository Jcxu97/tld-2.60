using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200061A")]
public class Panel_Challenges : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x200061B")]
	public class ChallengeslMenuItem
	{
		[Token(Token = "0x200061C")]
		public enum MenuType
		{
			[Token(Token = "0x40039A7")]
			NewChallenge,
			[Token(Token = "0x40039A8")]
			LoadChallenge,
			[Token(Token = "0x40039A9")]
			ResumeChallenge,
			[Token(Token = "0x40039AA")]
			AllChallenges
		}

		[Token(Token = "0x40039A4")]
		[FieldOffset(Offset = "0x10")]
		public MenuType m_Type;

		[Token(Token = "0x40039A5")]
		[FieldOffset(Offset = "0x18")]
		public string m_LabelLocalizationId;

		[Token(Token = "0x6003069")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ChallengeslMenuItem()
		{
		}
	}

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003996")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Badges> m_Badges;

	[SerializeField]
	[Token(Token = "0x4003997")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_ChooseChallenge> m_ChooseChallenge;

	[SerializeField]
	[Token(Token = "0x4003998")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x4003999")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_MainMenu> m_MainMenu;

	[SerializeField]
	[Token(Token = "0x400399A")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_SelectChallengeType> m_SelectChallengeType;

	[SerializeField]
	[Token(Token = "0x400399B")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Sandbox> m_Sandbox;

	[SerializeField]
	[Token(Token = "0x400399C")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_SurvivalSettings> m_SurvivalSettings;

	[Space]
	[Token(Token = "0x400399D")]
	[FieldOffset(Offset = "0x68")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Menu")]
	[Token(Token = "0x400399E")]
	[FieldOffset(Offset = "0x70")]
	public string m_TitleLocalizationId;

	[Token(Token = "0x400399F")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x40039A0")]
	[FieldOffset(Offset = "0x80")]
	public List<ChallengeslMenuItem> m_MenuItems;

	[Header("Steam Cloud")]
	[Token(Token = "0x40039A1")]
	[FieldOffset(Offset = "0x88")]
	public UILabel m_CloudMessageLabel;

	[Token(Token = "0x40039A2")]
	[FieldOffset(Offset = "0x90")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x40039A3")]
	[FieldOffset(Offset = "0x98")]
	private CloudMenuExtension m_CloudMenuExtension;

	[Token(Token = "0x6003058")]
	[Address(RVA = "0x9A8980", Offset = "0x9A7780", Length = "0x11B")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003059")]
	[Address(RVA = "0x9A8AA0", Offset = "0x9A78A0", Length = "0x105")]
	public Action GetActionFromType(ChallengeslMenuItem.MenuType type)
	{
		return null;
	}

	[Token(Token = "0x600305A")]
	[Address(RVA = "0x9A8BB0", Offset = "0x9A79B0", Length = "0x6E5")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x600305B")]
	[Address(RVA = "0x9A92A0", Offset = "0x9A80A0", Length = "0x376")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Token(Token = "0x600305C")]
	[Address(RVA = "0x9A9620", Offset = "0x9A8420", Length = "0x200")]
	private void Update()
	{
	}

	[Token(Token = "0x600305D")]
	[Address(RVA = "0x9A9830", Offset = "0x9A8630", Length = "0x22E")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600305E")]
	[Address(RVA = "0x9A9A60", Offset = "0x9A8860", Length = "0x169")]
	public void OnClickNew()
	{
	}

	[Token(Token = "0x600305F")]
	[Address(RVA = "0x9A9BD0", Offset = "0x9A89D0", Length = "0xDC")]
	public void OnClickLoad()
	{
	}

	[Token(Token = "0x6003060")]
	[Address(RVA = "0x9A9CB0", Offset = "0x9A8AB0", Length = "0x27C")]
	public void OnClickResume()
	{
	}

	[Token(Token = "0x6003061")]
	[Address(RVA = "0x9A9F30", Offset = "0x9A8D30", Length = "0x13")]
	private void OnGoBackInSurvivalSettings()
	{
	}

	[Token(Token = "0x6003062")]
	[Address(RVA = "0x9A9F50", Offset = "0x9A8D50", Length = "0x70")]
	private void OnDoneShowingSurvivalSettings()
	{
	}

	[Token(Token = "0x6003063")]
	[Address(RVA = "0x9A9FD0", Offset = "0x9A8DD0", Length = "0x84")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6003064")]
	[Address(RVA = "0x9AA060", Offset = "0x9A8E60", Length = "0xFF")]
	public void OnClickAllChallenges()
	{
	}

	[Token(Token = "0x6003065")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003066")]
	[Address(RVA = "0x9AA160", Offset = "0x9A8F60", Length = "0x115")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003067")]
	[Address(RVA = "0x9AA280", Offset = "0x9A9080", Length = "0xB9")]
	public void OnNewChallenge()
	{
	}

	[Token(Token = "0x6003068")]
	[Address(RVA = "0x9AA340", Offset = "0x9A9140", Length = "0x14A")]
	public Panel_Challenges()
	{
	}
}
