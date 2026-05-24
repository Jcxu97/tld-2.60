using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay.Fishing;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000666")]
public class Panel_IceFishing : Panel_AutoReferenced
{
	[Token(Token = "0x2000667")]
	private enum IceFishingAction
	{
		[Token(Token = "0x400400D")]
		ActiveFishing,
		[Token(Token = "0x400400E")]
		TipupFishing
	}

	[Header("Action Select")]
	[SerializeField]
	[Token(Token = "0x4003FE4")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_ActiveFishingButton;

	[SerializeField]
	[Token(Token = "0x4003FE5")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_PlaceTipupButton;

	[SerializeField]
	[Token(Token = "0x4003FE6")]
	[FieldOffset(Offset = "0x40")]
	private Color m_InactiveActionColor;

	[Header("Bait and Lure")]
	[SerializeField]
	[Token(Token = "0x4003FE7")]
	[FieldOffset(Offset = "0x50")]
	private IceFishingSelectionRow m_LureSelection;

	[SerializeField]
	[Token(Token = "0x4003FE8")]
	[FieldOffset(Offset = "0x58")]
	private IceFishingSelectionRow m_BaitSelection;

	[Header("Active Fishing")]
	[SerializeField]
	[Token(Token = "0x4003FE9")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_ActiveFishingParent;

	[SerializeField]
	[Token(Token = "0x4003FEA")]
	[FieldOffset(Offset = "0x68")]
	private int m_MaxHoursToFish;

	[SerializeField]
	[Token(Token = "0x4003FEB")]
	[FieldOffset(Offset = "0x6C")]
	private int m_MinHoursToFish;

	[SerializeField]
	[Token(Token = "0x4003FEC")]
	[FieldOffset(Offset = "0x70")]
	private int m_HoursToFishDefault;

	[SerializeField]
	[Token(Token = "0x4003FED")]
	[FieldOffset(Offset = "0x74")]
	private float m_SecondsProgressBarPerHour;

	[SerializeField]
	[Token(Token = "0x4003FEE")]
	[FieldOffset(Offset = "0x78")]
	private Transform m_TimeWidgetPos;

	[SerializeField]
	[Token(Token = "0x4003FEF")]
	[FieldOffset(Offset = "0x80")]
	private UILabel m_HoursToFishLabel;

	[SerializeField]
	[Token(Token = "0x4003FF0")]
	[FieldOffset(Offset = "0x88")]
	private UILabel m_EstimatedCaloriesBurnedLabel;

	[SerializeField]
	[Token(Token = "0x4003FF1")]
	[FieldOffset(Offset = "0x90")]
	private UILabel m_CurrentCaloriesLabel;

	[SerializeField]
	[Token(Token = "0x4003FF2")]
	[FieldOffset(Offset = "0x98")]
	private UILabel m_FeelsLikeLabel;

	[SerializeField]
	[Token(Token = "0x4003FF3")]
	[FieldOffset(Offset = "0xA0")]
	private Color m_FreezingTempLabelColor;

	[SerializeField]
	[Token(Token = "0x4003FF4")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject m_ButtonHoursIncrease;

	[SerializeField]
	[Token(Token = "0x4003FF5")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject m_ButtonHoursDecrease;

	[SerializeField]
	[Token(Token = "0x4003FF6")]
	[FieldOffset(Offset = "0xC0")]
	private AssetReferenceT<GearItemData> m_TackleDataReference;

	[Header("Tipup Fishing")]
	[SerializeField]
	[Token(Token = "0x4003FF7")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject m_TipupFishingParent;

	[SerializeField]
	[Token(Token = "0x4003FF8")]
	[FieldOffset(Offset = "0xD0")]
	private AssetReferenceT<GearItemData> m_TipupDataReference;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003FF9")]
	[FieldOffset(Offset = "0xD8")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4003FFA")]
	[FieldOffset(Offset = "0xE0")]
	private PanelReference<Panel_Crafting> m_Crafting;

	[Header("Controller")]
	[SerializeField]
	[Token(Token = "0x4003FFB")]
	[FieldOffset(Offset = "0xE8")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[SerializeField]
	[Token(Token = "0x4003FFC")]
	[FieldOffset(Offset = "0xF0")]
	private GameObject m_ToggleFishingHoursButton;

	[SerializeField]
	[Token(Token = "0x4003FFD")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject m_ToggleTackleButton;

	[Token(Token = "0x4003FFE")]
	[FieldOffset(Offset = "0x100")]
	private IceFishingAction m_Action;

	[Token(Token = "0x4003FFF")]
	[FieldOffset(Offset = "0x108")]
	private IceFishingSelectionRow m_ActiveRow;

	[Token(Token = "0x4004000")]
	[FieldOffset(Offset = "0x110")]
	private int m_HoursToFish;

	[Token(Token = "0x4004001")]
	[FieldOffset(Offset = "0x118")]
	private IceFishingHole m_IceFishingHole;

	[Token(Token = "0x4004002")]
	[FieldOffset(Offset = "0x120")]
	private GearItemData m_TackleData;

	[Token(Token = "0x4004003")]
	[FieldOffset(Offset = "0x128")]
	private GearItemData m_TipupData;

	[Token(Token = "0x4004004")]
	[FieldOffset(Offset = "0x130")]
	private AsyncOperationHandle<GearItemData> m_TackleDataHandle;

	[Token(Token = "0x4004005")]
	[FieldOffset(Offset = "0x148")]
	private AsyncOperationHandle<GearItemData> m_TipupDataHandle;

	[Token(Token = "0x4004006")]
	[FieldOffset(Offset = "0x160")]
	private GearItem m_BestTackle;

	[Token(Token = "0x4004007")]
	[FieldOffset(Offset = "0x168")]
	private GearItem m_BestTipup;

	[Token(Token = "0x4004008")]
	[FieldOffset(Offset = "0x170")]
	private bool m_FocusedOnTackle;

	[Token(Token = "0x4004009")]
	[FieldOffset(Offset = "0x178")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Token(Token = "0x400400A")]
	[FieldOffset(Offset = "0x180")]
	private List<UIButton> m_ActiveFishingSelectButtons;

	[Token(Token = "0x400400B")]
	[FieldOffset(Offset = "0x188")]
	private List<UIButton> m_PlaceTipupSelectButtons;

	[Token(Token = "0x60034CD")]
	[Address(RVA = "0xA6DCC0", Offset = "0xA6CAC0", Length = "0x3FA")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60034CE")]
	[Address(RVA = "0xA6E0C0", Offset = "0xA6CEC0", Length = "0x1B6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60034CF")]
	[Address(RVA = "0xA6E280", Offset = "0xA6D080", Length = "0x664")]
	private void Update()
	{
	}

	[Token(Token = "0x60034D0")]
	[Address(RVA = "0xA6E8F0", Offset = "0xA6D6F0", Length = "0x2E8")]
	private void UpdateTackleController(float menuHorizontal, float menuVertical)
	{
	}

	[Token(Token = "0x60034D1")]
	[Address(RVA = "0xA6EBE0", Offset = "0xA6D9E0", Length = "0x28")]
	private void UpdateFishingHoursController(float menuHorizontal)
	{
	}

	[Token(Token = "0x60034D2")]
	[Address(RVA = "0xA6EC10", Offset = "0xA6DA10", Length = "0x2B6")]
	public bool CanDoFishing()
	{
		return false;
	}

	[Token(Token = "0x60034D3")]
	[Address(RVA = "0xA6EED0", Offset = "0xA6DCD0", Length = "0x13E")]
	private void UpdateBestGear()
	{
	}

	[Token(Token = "0x60034D4")]
	[Address(RVA = "0xA6F010", Offset = "0xA6DE10", Length = "0x93")]
	public void Launch(IceFishingHole ifh)
	{
	}

	[Token(Token = "0x60034D5")]
	[Address(RVA = "0xA6F0B0", Offset = "0xA6DEB0", Length = "0x633")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60034D6")]
	[Address(RVA = "0xA6F6F0", Offset = "0xA6E4F0", Length = "0xD")]
	public void OnShowActiveFishing()
	{
	}

	[Token(Token = "0x60034D7")]
	[Address(RVA = "0xA6F700", Offset = "0xA6E500", Length = "0xF")]
	public void OnShowPlaceTipup()
	{
	}

	[Token(Token = "0x60034D8")]
	[Address(RVA = "0xA6F710", Offset = "0xA6E510", Length = "0x10A")]
	private void SwitchAction(IceFishingAction action, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x60034D9")]
	[Address(RVA = "0xA6F820", Offset = "0xA6E620", Length = "0x1A5")]
	private void UpdateButtonColor(List<UIButton> buttons, Color color)
	{
	}

	[Token(Token = "0x60034DA")]
	[Address(RVA = "0xA6F9D0", Offset = "0xA6E7D0", Length = "0x163")]
	private void UpdateButtonState(List<UIButton> buttons, bool isEnabled)
	{
	}

	[Token(Token = "0x60034DB")]
	[Address(RVA = "0xA6FB40", Offset = "0xA6E940", Length = "0x178")]
	private void SwitchFocus(bool focusedOnTackle)
	{
	}

	[Token(Token = "0x60034DC")]
	[Address(RVA = "0xA6FCC0", Offset = "0xA6EAC0", Length = "0x28B")]
	private void RefreshRows()
	{
	}

	[Token(Token = "0x60034DD")]
	[Address(RVA = "0xA6FF50", Offset = "0xA6ED50", Length = "0x61")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x60034DE")]
	[Address(RVA = "0xA6FFC0", Offset = "0xA6EDC0", Length = "0xD0")]
	public void OnOpenCrafting()
	{
	}

	[Token(Token = "0x60034DF")]
	[Address(RVA = "0xA700A0", Offset = "0xA6EEA0", Length = "0x207")]
	public void OnFish()
	{
	}

	[Token(Token = "0x60034E0")]
	[Address(RVA = "0xA702B0", Offset = "0xA6F0B0", Length = "0xC")]
	public void OnIncreaseHours()
	{
	}

	[Token(Token = "0x60034E1")]
	[Address(RVA = "0xA702C0", Offset = "0xA6F0C0", Length = "0xC")]
	public void OnDecreaseHours()
	{
	}

	[Token(Token = "0x60034E2")]
	[Address(RVA = "0xA702D0", Offset = "0xA6F0D0", Length = "0x9E")]
	private void ChangeFishingHours(int change)
	{
	}

	[Token(Token = "0x60034E3")]
	[Address(RVA = "0xA70370", Offset = "0xA6F170", Length = "0xF5")]
	public bool IsFishing()
	{
		return false;
	}

	[Token(Token = "0x60034E4")]
	[Address(RVA = "0xA70470", Offset = "0xA6F270", Length = "0xAE")]
	private void UpdateHoursToFishLabel()
	{
	}

	[Token(Token = "0x60034E5")]
	[Address(RVA = "0xA70520", Offset = "0xA6F320", Length = "0x1F4")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[Token(Token = "0x60034E6")]
	[Address(RVA = "0xA70720", Offset = "0xA6F520", Length = "0x1B2")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[Token(Token = "0x60034E7")]
	[Address(RVA = "0xA708E0", Offset = "0xA6F6E0", Length = "0x1E0")]
	private void UpdateFeelsLikeLabel()
	{
	}

	[Token(Token = "0x60034E8")]
	[Address(RVA = "0xA70AD0", Offset = "0xA6F8D0", Length = "0x15B")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x60034E9")]
	[Address(RVA = "0xA70C30", Offset = "0xA6FA30", Length = "0x457")]
	private GearItem GetBestTipup()
	{
		return null;
	}

	[Token(Token = "0x60034EA")]
	[Address(RVA = "0xA71090", Offset = "0xA6FE90", Length = "0x1EF")]
	public Panel_IceFishing()
	{
	}
}
