using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.OptionalContent;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20006B8")]
public class Panel_Sandbox : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x20006B9")]
	public class MainSurvivalMenuItem
	{
		[Token(Token = "0x20006BA")]
		public enum MainSurvivalMenuItemType
		{
			[Token(Token = "0x40047D0")]
			New,
			[Token(Token = "0x40047D1")]
			Resume,
			[Token(Token = "0x40047D2")]
			Load,
			[Token(Token = "0x40047D3")]
			Challenges,
			[Token(Token = "0x40047D4")]
			Extras,
			[Token(Token = "0x40047D5")]
			Options
		}

		[Token(Token = "0x40047CB")]
		[FieldOffset(Offset = "0x10")]
		public LocalizedString m_LabelText;

		[Token(Token = "0x40047CC")]
		[FieldOffset(Offset = "0x18")]
		public LocalizedString m_LabelDescription;

		[Token(Token = "0x40047CD")]
		[FieldOffset(Offset = "0x20")]
		public MainSurvivalMenuItemType m_Type;

		[Token(Token = "0x40047CE")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent m_Callback;

		[Token(Token = "0x6003B05")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public MainSurvivalMenuItem()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20006BB")]
	private class GameEditionArt
	{
		[Token(Token = "0x40047D6")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_MainTitle;

		[Token(Token = "0x40047D7")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_UpdateTitle;

		[Token(Token = "0x6003B06")]
		[Address(RVA = "0xAEB860", Offset = "0xAEA660", Length = "0x44")]
		public void SetActive(bool value)
		{
		}

		[Token(Token = "0x6003B07")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public GameEditionArt()
		{
		}
	}

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40047A9")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Badges> m_Badges;

	[SerializeField]
	[Token(Token = "0x40047AA")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_ChooseSandbox> m_ChooseSandbox;

	[SerializeField]
	[Token(Token = "0x40047AB")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x40047AC")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_MainMenu> m_MainMenu;

	[SerializeField]
	[Token(Token = "0x40047AD")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_SelectExperience> m_SelectExperience;

	[SerializeField]
	[Token(Token = "0x40047AE")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Challenges> m_Challenges;

	[SerializeField]
	[Token(Token = "0x40047AF")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_Extras> m_Extras;

	[SerializeField]
	[Token(Token = "0x40047B0")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	[SerializeField]
	[Token(Token = "0x40047B1")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_SurvivalSettings> m_SurvivalSettings;

	[SerializeField]
	[Token(Token = "0x40047B2")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_SaveMigration> m_SaveMigration;

	[Space]
	[Token(Token = "0x40047B3")]
	[FieldOffset(Offset = "0x80")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40047B4")]
	[FieldOffset(Offset = "0x88")]
	public UIPanel m_MainPanel;

	[Token(Token = "0x40047B5")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_MainWindow;

	[Header("Menu")]
	[Token(Token = "0x40047B6")]
	[FieldOffset(Offset = "0x98")]
	public string m_TitleLocalizationId;

	[Token(Token = "0x40047B7")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x40047B8")]
	[FieldOffset(Offset = "0xA8")]
	public List<MainSurvivalMenuItem> m_MenuItems;

	[Header("Steam Cloud")]
	[Token(Token = "0x40047B9")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel m_CloudMessageLabel;

	[Header("Panel Fading")]
	[Token(Token = "0x40047BA")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite m_Sprite_FadeOverlay;

	[Token(Token = "0x40047BB")]
	[FieldOffset(Offset = "0xC0")]
	public float m_InitialScreenFadeInDuration;

	[Token(Token = "0x40047BC")]
	[FieldOffset(Offset = "0xC4")]
	public float m_FadeInTimeSeconds;

	[Token(Token = "0x40047BD")]
	[FieldOffset(Offset = "0xC8")]
	public float m_NoInputTimeBeforeFading;

	[Token(Token = "0x40047BE")]
	[FieldOffset(Offset = "0xCC")]
	public float m_MinDOFFocalLength;

	[Token(Token = "0x40047BF")]
	[FieldOffset(Offset = "0xD0")]
	public float m_MaxDOFFocalLength;

	[Header("Edition Art")]
	[SerializeField]
	[Token(Token = "0x40047C0")]
	[FieldOffset(Offset = "0xD8")]
	private GameEditionArt m_BaseEditionArt;

	[SerializeField]
	[Token(Token = "0x40047C1")]
	[FieldOffset(Offset = "0xE0")]
	private GameEditionArt m_ExpansionPassEditionArt;

	[Header("DLC")]
	[SerializeField]
	[Token(Token = "0x40047C2")]
	[FieldOffset(Offset = "0xE8")]
	private OptionalContentConfig m_ExpansionPassConfig;

	[Token(Token = "0x40047C3")]
	[FieldOffset(Offset = "0xF0")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x40047C4")]
	[FieldOffset(Offset = "0xF8")]
	private CloudMenuExtension m_CloudMenuExtension;

	[Token(Token = "0x40047C5")]
	[FieldOffset(Offset = "0x100")]
	private float m_PanelAlphaTarget;

	[Token(Token = "0x40047C6")]
	[FieldOffset(Offset = "0x104")]
	private float m_ScreenElapsedTime;

	[Token(Token = "0x40047C7")]
	private static float m_AdjustedFadeInDuration;

	[Token(Token = "0x40047C8")]
	[FieldOffset(Offset = "0x108")]
	private float m_PanelAlpha;

	[Token(Token = "0x40047C9")]
	[FieldOffset(Offset = "0x10C")]
	private float m_TimeNoInput;

	[Token(Token = "0x40047CA")]
	private const float MAX_PANEL_ALPHA = 1f;

	[Token(Token = "0x6003AEA")]
	[Address(RVA = "0xB529B0", Offset = "0xB517B0", Length = "0x236")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003AEB")]
	[Address(RVA = "0xB52BF0", Offset = "0xB519F0", Length = "0x4F6")]
	private void Update()
	{
	}

	[Token(Token = "0x6003AEC")]
	[Address(RVA = "0xB530F0", Offset = "0xB51EF0", Length = "0x762")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003AED")]
	[Address(RVA = "0xB53860", Offset = "0xB52660", Length = "0x326")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Token(Token = "0x6003AEE")]
	[Address(RVA = "0xB53B90", Offset = "0xB52990", Length = "0x345")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003AEF")]
	[Address(RVA = "0xB53EE0", Offset = "0xB52CE0", Length = "0x34")]
	public void ResetFadeOverlay()
	{
	}

	[Token(Token = "0x6003AF0")]
	[Address(RVA = "0xB53F20", Offset = "0xB52D20", Length = "0x169")]
	public void OnClickNew()
	{
	}

	[Token(Token = "0x6003AF1")]
	[Address(RVA = "0xB54090", Offset = "0xB52E90", Length = "0xDC")]
	public void OnClickLoad()
	{
	}

	[Token(Token = "0x6003AF2")]
	[Address(RVA = "0xB54170", Offset = "0xB52F70", Length = "0x27C")]
	public void OnClickResume()
	{
	}

	[Token(Token = "0x6003AF3")]
	[Address(RVA = "0x9A9F30", Offset = "0x9A8D30", Length = "0x13")]
	private void OnGoBackInSurvivalSettings()
	{
	}

	[Token(Token = "0x6003AF4")]
	[Address(RVA = "0xB543F0", Offset = "0xB531F0", Length = "0x70")]
	private void OnDoneShowingSurvivalSettings()
	{
	}

	[Token(Token = "0x6003AF5")]
	[Address(RVA = "0xB54470", Offset = "0xB53270", Length = "0x133")]
	public void OnClickChallenges()
	{
	}

	[Token(Token = "0x6003AF6")]
	[Address(RVA = "0xB545B0", Offset = "0xB533B0", Length = "0xFF")]
	public void OnClickFeats()
	{
	}

	[Token(Token = "0x6003AF7")]
	[Address(RVA = "0xB546B0", Offset = "0xB534B0", Length = "0xCA")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6003AF8")]
	[Address(RVA = "0xB54780", Offset = "0xB53580", Length = "0x84")]
	public void OnClickExtras()
	{
	}

	[Token(Token = "0x6003AF9")]
	[Address(RVA = "0xB54810", Offset = "0xB53610", Length = "0xCB")]
	public void OnClickOptions()
	{
	}

	[Token(Token = "0x6003AFA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003AFB")]
	[Address(RVA = "0xB548E0", Offset = "0xB536E0", Length = "0x124")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003AFC")]
	[Address(RVA = "0xB54A10", Offset = "0xB53810", Length = "0xB9")]
	private void OnNewSandbox()
	{
	}

	[Token(Token = "0x6003AFD")]
	[Address(RVA = "0xB54AD0", Offset = "0xB538D0", Length = "0xB")]
	private void FadeInPanel()
	{
	}

	[Token(Token = "0x6003AFE")]
	[Address(RVA = "0x909B60", Offset = "0x908960", Length = "0xB")]
	private void FadeOutPanel()
	{
	}

	[Token(Token = "0x6003AFF")]
	[Address(RVA = "0xB54AE0", Offset = "0xB538E0", Length = "0x270")]
	private void UpdateFading()
	{
	}

	[Token(Token = "0x6003B00")]
	[Address(RVA = "0xB54D60", Offset = "0xB53B60", Length = "0xFE")]
	private void SetGameEditionArt()
	{
	}

	[Token(Token = "0x6003B01")]
	[Address(RVA = "0xB54E60", Offset = "0xB53C60", Length = "0x1D5")]
	private void SetPanelAlpha(float alpha)
	{
	}

	[Token(Token = "0x6003B02")]
	[Address(RVA = "0xB55040", Offset = "0xB53E40", Length = "0x125")]
	private bool IsSubMenuEnabled()
	{
		return false;
	}

	[Token(Token = "0x6003B03")]
	[Address(RVA = "0xB55170", Offset = "0xB53F70", Length = "0x15C")]
	public Panel_Sandbox()
	{
	}
}
