using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.SaveState;
using TLD.Scenes;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006CB")]
public class Panel_SelectWorldMap : Panel_AutoReferenced
{
	[Header("Target Panels")]
	[SerializeField]
	[Token(Token = "0x4004856")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_SelectSurvivor> m_SelectSurvivor;

	[SerializeField]
	[Token(Token = "0x4004857")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_SelectRegion_Map> m_SelectRegion;

	[Header("Buttons")]
	[SerializeField]
	[Token(Token = "0x4004858")]
	[FieldOffset(Offset = "0x40")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[SerializeField]
	[Token(Token = "0x4004859")]
	[FieldOffset(Offset = "0x48")]
	private LocalizedString m_BackButtonText;

	[SerializeField]
	[Token(Token = "0x400485A")]
	[FieldOffset(Offset = "0x50")]
	private LocalizedString m_ConfirmButtonText;

	[SerializeField]
	[Token(Token = "0x400485B")]
	[FieldOffset(Offset = "0x58")]
	private LocalizedString m_TitleLocalizationText;

	[SerializeField]
	[Token(Token = "0x400485C")]
	[FieldOffset(Offset = "0x60")]
	private LocalizedString m_HeaderTitleLocalizationText;

	[SerializeField]
	[Token(Token = "0x400485D")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_TitleHeaderOffset;

	[SerializeField]
	[Token(Token = "0x400485E")]
	[FieldOffset(Offset = "0x78")]
	private GameObject m_BasicMenuRoot;

	[Header("Map Data")]
	[SerializeField]
	[Token(Token = "0x400485F")]
	[FieldOffset(Offset = "0x80")]
	private WorldMapChangedEvent m_WorldMapChanged;

	[Header("Visuals")]
	[SerializeField]
	[Token(Token = "0x4004860")]
	[FieldOffset(Offset = "0x88")]
	private Transform m_BaseMapParent;

	[SerializeField]
	[Token(Token = "0x4004861")]
	[FieldOffset(Offset = "0x90")]
	private float m_FadeDuration;

	[SerializeField]
	[Token(Token = "0x4004862")]
	[FieldOffset(Offset = "0x94")]
	private Vector2 m_FadeAlphaBounds;

	[Token(Token = "0x4004863")]
	[FieldOffset(Offset = "0xA0")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x4004864")]
	[FieldOffset(Offset = "0xA8")]
	private IList<WorldMapSpecification> m_AvailableMaps;

	[Token(Token = "0x4004865")]
	[FieldOffset(Offset = "0xB0")]
	private Panel_Base m_TargetPanel;

	[Token(Token = "0x6003B8D")]
	[Address(RVA = "0xB66290", Offset = "0xB65090", Length = "0x291")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003B8E")]
	[Address(RVA = "0xB66530", Offset = "0xB65330", Length = "0xCC")]
	public bool ShouldBePartOfFlow()
	{
		return false;
	}

	[Token(Token = "0x6003B8F")]
	[Address(RVA = "0x9EEEF0", Offset = "0x9EDCF0", Length = "0x52")]
	public void SetTargetPanel(Panel_Base target)
	{
	}

	[Token(Token = "0x6003B90")]
	[Address(RVA = "0xB66600", Offset = "0xB65400", Length = "0xBD")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003B91")]
	[Address(RVA = "0xB666C0", Offset = "0xB654C0", Length = "0x473")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003B92")]
	[Address(RVA = "0xB66B40", Offset = "0xB65940", Length = "0x46E")]
	public void OnFadeOutFinished()
	{
	}

	[Token(Token = "0x6003B93")]
	[Address(RVA = "0xB66FB0", Offset = "0xB65DB0", Length = "0x1CA")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B94")]
	[Address(RVA = "0xB67180", Offset = "0xB65F80", Length = "0x598")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003B95")]
	[Address(RVA = "0xB67720", Offset = "0xB66520", Length = "0x30D")]
	private void RestoreSelection()
	{
	}

	[Token(Token = "0x6003B96")]
	[Address(RVA = "0xB67A30", Offset = "0xB66830", Length = "0x1E7")]
	private void AddMenuItem(WorldMapSpecification worldMapSpecification, int itemIndex)
	{
	}

	[Token(Token = "0x6003B97")]
	[Address(RVA = "0xB67C20", Offset = "0xB66A20", Length = "0x400")]
	private void OnWorldMapClicked()
	{
	}

	[Token(Token = "0x6003B98")]
	[Address(RVA = "0xB68030", Offset = "0xB66E30", Length = "0xE3")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003B99")]
	[Address(RVA = "0xB68120", Offset = "0xB66F20", Length = "0x221")]
	private UIWorldMap GetActiveMap()
	{
		return null;
	}

	[Token(Token = "0x6003B9A")]
	[Address(RVA = "0xB68350", Offset = "0xB67150", Length = "0x3A7")]
	private void OnSelectionUpdate(string id, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003B9B")]
	[Address(RVA = "0xB68700", Offset = "0xB67500", Length = "0x61")]
	private void OnClickBack()
	{
	}

	[Token(Token = "0x6003B9C")]
	[Address(RVA = "0xB68770", Offset = "0xB67570", Length = "0x1E7")]
	private void SwapBackgroundWithoutFades(string id, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003B9D")]
	[Address(RVA = "0xB68960", Offset = "0xB67760", Length = "0x36")]
	private UIWorldMap GetWorldMap(WorldMapSpecification specification)
	{
		return null;
	}

	[Token(Token = "0x6003B9E")]
	[Address(RVA = "0xB689A0", Offset = "0xB677A0", Length = "0xED")]
	private void PlayFadeOut(UIWorldMap map)
	{
	}

	[Token(Token = "0x6003B9F")]
	[Address(RVA = "0xB68A90", Offset = "0xB67890", Length = "0x134")]
	private void PlayFadeIn(UIWorldMap map)
	{
	}

	[Token(Token = "0x6003BA0")]
	[Address(RVA = "0xB68BD0", Offset = "0xB679D0", Length = "0x8C")]
	private void HandleProfileLoaded(ProfileState _)
	{
	}

	[Token(Token = "0x6003BA1")]
	[Address(RVA = "0xB68C60", Offset = "0xB67A60", Length = "0x58")]
	public Panel_SelectWorldMap()
	{
	}
}
