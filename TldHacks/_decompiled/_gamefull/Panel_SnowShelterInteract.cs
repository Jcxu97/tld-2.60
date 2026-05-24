using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006CD")]
public class Panel_SnowShelterInteract : Panel_AutoReferenced, IAccelerateTimeProvider
{
	[Token(Token = "0x20006CE")]
	private delegate void OnMethod();

	[Token(Token = "0x20006CF")]
	private enum ButtonChoice
	{
		[Token(Token = "0x40048AA")]
		Use,
		[Token(Token = "0x40048AB")]
		Repair,
		[Token(Token = "0x40048AC")]
		Dismantle
	}

	[Token(Token = "0x4004879")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400487A")]
	[FieldOffset(Offset = "0x38")]
	public float m_RealtimeSecondsToRepairOrDismantle;

	[Token(Token = "0x400487B")]
	[FieldOffset(Offset = "0x40")]
	public UIButton m_Button_Use;

	[Token(Token = "0x400487C")]
	[FieldOffset(Offset = "0x48")]
	public UIButton m_Button_Repair;

	[Token(Token = "0x400487D")]
	[FieldOffset(Offset = "0x50")]
	public UIButton m_Button_Dismantle;

	[Token(Token = "0x400487E")]
	[FieldOffset(Offset = "0x58")]
	public float m_ButtonSpacing;

	[Token(Token = "0x400487F")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_InteractionPanel;

	[Token(Token = "0x4004880")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_InteractionDescriptionLabel;

	[Token(Token = "0x4004881")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_InteractionMaterialsLabel;

	[Token(Token = "0x4004882")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_BottomRightActionButton;

	[Token(Token = "0x4004883")]
	[FieldOffset(Offset = "0x80")]
	public Color m_RepairLabelColorNormal;

	[Token(Token = "0x4004884")]
	[FieldOffset(Offset = "0x90")]
	public Color m_RepairLabelColorNormalHover;

	[Token(Token = "0x4004885")]
	[FieldOffset(Offset = "0xA0")]
	public Color m_RepairLabelColorNormalSelected;

	[Token(Token = "0x4004886")]
	[FieldOffset(Offset = "0xB0")]
	public Color m_RepairLabelColorDisabled;

	[Token(Token = "0x4004887")]
	[FieldOffset(Offset = "0xC0")]
	public Color m_RepairLabelColorDisabledHover;

	[Token(Token = "0x4004888")]
	[FieldOffset(Offset = "0xD0")]
	public Color m_RepairLabelColorDisabledSelected;

	[Token(Token = "0x4004889")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel m_ErrorLabel;

	[Token(Token = "0x400488A")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel m_TimeForRepairHeaderLabel;

	[Token(Token = "0x400488B")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel m_DurationLabel;

	[Token(Token = "0x400488C")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel m_EstimatedCaloriesBurnedLabel;

	[Token(Token = "0x400488D")]
	[FieldOffset(Offset = "0x100")]
	public UILabel m_CurrentCaloriesLabel;

	[Token(Token = "0x400488E")]
	[FieldOffset(Offset = "0x108")]
	public UILabel m_CurrentCaloriesValLabel;

	[Token(Token = "0x400488F")]
	[FieldOffset(Offset = "0x110")]
	public UILabel m_ConditionLabel;

	[Token(Token = "0x4004890")]
	[FieldOffset(Offset = "0x118")]
	public UISprite m_ConditionSprite;

	[Token(Token = "0x4004891")]
	[FieldOffset(Offset = "0x120")]
	public GameObject m_PanelElements;

	[Token(Token = "0x4004892")]
	[FieldOffset(Offset = "0x128")]
	public HarvestRepairMaterial[] m_RequiredMaterialsObjects;

	[Token(Token = "0x4004893")]
	[FieldOffset(Offset = "0x130")]
	public float m_RequiredMaterialsCenteredX;

	[Token(Token = "0x4004894")]
	[FieldOffset(Offset = "0x134")]
	public float m_RequiredMaterialsSpacing;

	[Token(Token = "0x4004895")]
	[FieldOffset(Offset = "0x138")]
	public GenericButtonMouseSpawner m_MouseButtonInteract;

	[Token(Token = "0x4004896")]
	[FieldOffset(Offset = "0x140")]
	public string m_IconNameRepairingSnowShelter;

	[Token(Token = "0x4004897")]
	[FieldOffset(Offset = "0x148")]
	public string m_IconNameHarvestingSnowShelter;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004898")]
	[FieldOffset(Offset = "0x150")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4004899")]
	[FieldOffset(Offset = "0x158")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x400489A")]
	[FieldOffset(Offset = "0x160")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[HideInInspector]
	[Token(Token = "0x400489B")]
	[FieldOffset(Offset = "0x168")]
	private SnowShelter m_SnowShelter;

	[Token(Token = "0x400489C")]
	[FieldOffset(Offset = "0x170")]
	private List<UIButton> m_Buttons;

	[Token(Token = "0x400489D")]
	[FieldOffset(Offset = "0x178")]
	private List<Panel_Inventory_Examine_MenuItem> m_ButtonsMenuItems;

	[Token(Token = "0x400489E")]
	[FieldOffset(Offset = "0x180")]
	private List<OnMethod> m_ButtonDelegates;

	[Token(Token = "0x400489F")]
	[FieldOffset(Offset = "0x188")]
	private int m_SelectedButtonIndex;

	[Token(Token = "0x40048A0")]
	[FieldOffset(Offset = "0x18C")]
	private bool m_IsRepairing;

	[Token(Token = "0x40048A1")]
	[FieldOffset(Offset = "0x18D")]
	private bool m_IsDismantling;

	[Token(Token = "0x40048A2")]
	[FieldOffset(Offset = "0x190")]
	private float m_RealtimeSecondsElapsed;

	[Token(Token = "0x40048A3")]
	[FieldOffset(Offset = "0x194")]
	private bool m_TimeIsAccelerated;

	[Token(Token = "0x40048A4")]
	[FieldOffset(Offset = "0x198")]
	private float m_StoredDayLengthScale;

	[Token(Token = "0x40048A5")]
	[FieldOffset(Offset = "0x19C")]
	private int m_FramesInPanel;

	[Token(Token = "0x40048A6")]
	[FieldOffset(Offset = "0x1A0")]
	private uint m_InteractionAudioID;

	[Token(Token = "0x40048A7")]
	[FieldOffset(Offset = "0x1A4")]
	private int m_NumSticksUsedForRepair;

	[Token(Token = "0x40048A8")]
	[FieldOffset(Offset = "0x1A8")]
	private int m_NumClothUsedForRepair;

	[Token(Token = "0x6003BBC")]
	[Address(RVA = "0xB6A920", Offset = "0xB69720", Length = "0x8AE")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003BBD")]
	[Address(RVA = "0xB6B1D0", Offset = "0xB69FD0", Length = "0x6CE")]
	private void Update()
	{
	}

	[Token(Token = "0x6003BBE")]
	[Address(RVA = "0xB6B8A0", Offset = "0xB6A6A0", Length = "0x22A")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003BBF")]
	[Address(RVA = "0xB6BAD0", Offset = "0xB6A8D0", Length = "0x52")]
	public void SetSnowShelterInstance(SnowShelter ss)
	{
	}

	[Token(Token = "0x6003BC0")]
	[Address(RVA = "0xB6BB30", Offset = "0xB6A930", Length = "0x11E")]
	public void OnUse()
	{
	}

	[Token(Token = "0x6003BC1")]
	[Address(RVA = "0xB6BC50", Offset = "0xB6AA50", Length = "0x17B")]
	public void OnRepair()
	{
	}

	[Token(Token = "0x6003BC2")]
	[Address(RVA = "0xB6BDD0", Offset = "0xB6ABD0", Length = "0x8A")]
	public void OnDismantle()
	{
	}

	[Token(Token = "0x6003BC3")]
	[Address(RVA = "0x74E480", Offset = "0x74D280", Length = "0x8")]
	public bool IsTimeAccelerated()
	{
		return false;
	}

	[Token(Token = "0x6003BC4")]
	[Address(RVA = "0xB6BE60", Offset = "0xB6AC60", Length = "0x8")]
	public bool IsRepairing()
	{
		return false;
	}

	[Token(Token = "0x6003BC5")]
	[Address(RVA = "0xB6BE70", Offset = "0xB6AC70", Length = "0x8")]
	public bool IsDismantling()
	{
		return false;
	}

	[Token(Token = "0x6003BC6")]
	[Address(RVA = "0xB6BE80", Offset = "0xB6AC80", Length = "0xC2")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x6003BC7")]
	[Address(RVA = "0xB6BF50", Offset = "0xB6AD50", Length = "0x71")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003BC8")]
	[Address(RVA = "0xB6BFD0", Offset = "0xB6ADD0", Length = "0x349")]
	public void OnInteract()
	{
	}

	[Token(Token = "0x6003BC9")]
	[Address(RVA = "0xB6C320", Offset = "0xB6B120", Length = "0x193")]
	public void OnInteractionCommon(string audioEvent)
	{
	}

	[Token(Token = "0x6003BCA")]
	[Address(RVA = "0xB6C4C0", Offset = "0xB6B2C0", Length = "0x39F")]
	private void InteractionFinished()
	{
	}

	[Token(Token = "0x6003BCB")]
	[Address(RVA = "0xB6C860", Offset = "0xB6B660", Length = "0x14D")]
	private void UpdateDurationLabel()
	{
	}

	[Token(Token = "0x6003BCC")]
	[Address(RVA = "0xB6C9B0", Offset = "0xB6B7B0", Length = "0x2F4")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[Token(Token = "0x6003BCD")]
	[Address(RVA = "0xB6CCB0", Offset = "0xB6BAB0", Length = "0x1F4")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[Token(Token = "0x6003BCE")]
	[Address(RVA = "0xB6CEB0", Offset = "0xB6BCB0", Length = "0x2E7")]
	private void UpdateConditionLabel()
	{
	}

	[Token(Token = "0x6003BCF")]
	[Address(RVA = "0xB6D1A0", Offset = "0xB6BFA0", Length = "0x8F")]
	private string GetSignedInt(int value)
	{
		return null;
	}

	[Token(Token = "0x6003BD0")]
	[Address(RVA = "0xB6D230", Offset = "0xB6C030", Length = "0x216")]
	private string GetSignedPercentage(float value)
	{
		return null;
	}

	[Token(Token = "0x6003BD1")]
	[Address(RVA = "0xB6D450", Offset = "0xB6C250", Length = "0x25B")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003BD2")]
	[Address(RVA = "0xB6D6B0", Offset = "0xB6C4B0", Length = "0x95F")]
	public void RefreshMainWindow()
	{
	}

	[Token(Token = "0x6003BD3")]
	[Address(RVA = "0xB6E010", Offset = "0xB6CE10", Length = "0x220")]
	private void SelectButton(int index)
	{
	}

	[Token(Token = "0x6003BD4")]
	[Address(RVA = "0xB6E240", Offset = "0xB6D040", Length = "0x58")]
	public void OnSelectUseButton()
	{
	}

	[Token(Token = "0x6003BD5")]
	[Address(RVA = "0xB6E2A0", Offset = "0xB6D0A0", Length = "0x5A")]
	public void OnSelectRepairButton()
	{
	}

	[Token(Token = "0x6003BD6")]
	[Address(RVA = "0xB6E300", Offset = "0xB6D100", Length = "0x5A")]
	public void OnSelectDismantleButton()
	{
	}

	[Token(Token = "0x6003BD7")]
	[Address(RVA = "0xB6E360", Offset = "0xB6D160", Length = "0x35F")]
	private void UpdateMainWindowNavigation()
	{
	}

	[Token(Token = "0x6003BD8")]
	[Address(RVA = "0xB6E6C0", Offset = "0xB6D4C0", Length = "0x125")]
	private void UpdateUseButton()
	{
	}

	[Token(Token = "0x6003BD9")]
	[Address(RVA = "0xB6E7F0", Offset = "0xB6D5F0", Length = "0x125")]
	private void UpdateDismantleButton()
	{
	}

	[Token(Token = "0x6003BDA")]
	[Address(RVA = "0xB6E920", Offset = "0xB6D720", Length = "0x139")]
	private void UpdateRepairButton()
	{
	}

	[Token(Token = "0x6003BDB")]
	[Address(RVA = "0xB6EA60", Offset = "0xB6D860", Length = "0x1E1")]
	private void UpdatePanelDisplays()
	{
	}

	[Token(Token = "0x6003BDC")]
	[Address(RVA = "0xB6EC50", Offset = "0xB6DA50", Length = "0x4C4")]
	private void RefreshRepairPanel()
	{
	}

	[Token(Token = "0x6003BDD")]
	[Address(RVA = "0xB6F120", Offset = "0xB6DF20", Length = "0x260")]
	private void UpdateRequiredMaterialsObject(int index, float spacingVal, GearItem gi, int count, bool hasItem)
	{
	}

	[Token(Token = "0x6003BDE")]
	[Address(RVA = "0xB6F390", Offset = "0xB6E190", Length = "0x413")]
	private void RefreshDismantlePanel()
	{
	}

	[Token(Token = "0x6003BDF")]
	[Address(RVA = "0xB6F7B0", Offset = "0xB6E5B0", Length = "0x1B6")]
	private float GetTaskDurationInHours()
	{
		return 0f;
	}

	[Token(Token = "0x6003BE0")]
	[Address(RVA = "0xB6F970", Offset = "0xB6E770", Length = "0xB1")]
	private float GetCalorieBurnRate()
	{
		return 0f;
	}

	[Token(Token = "0x6003BE1")]
	[Address(RVA = "0xB6FA30", Offset = "0xB6E830", Length = "0xB1")]
	private ButtonChoice GetButtonChoiceFromIndex(int index)
	{
		return default(ButtonChoice);
	}

	[Token(Token = "0x6003BE2")]
	[Address(RVA = "0xB6FAF0", Offset = "0xB6E8F0", Length = "0x2B7")]
	private void CameraPan(int index)
	{
	}

	[Token(Token = "0x6003BE3")]
	[Address(RVA = "0xB6FDB0", Offset = "0xB6EBB0", Length = "0x65")]
	private bool NeedsRepair()
	{
		return false;
	}

	[Token(Token = "0x6003BE4")]
	[Address(RVA = "0xB6FE20", Offset = "0xB6EC20", Length = "0x152")]
	private bool HasMaterialsForRepair()
	{
		return false;
	}

	[Token(Token = "0x6003BE5")]
	[Address(RVA = "0xB6FF80", Offset = "0xB6ED80", Length = "0xC4")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x6003BE6")]
	[Address(RVA = "0xB70050", Offset = "0xB6EE50", Length = "0xC5")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x6003BE7")]
	[Address(RVA = "0xB70120", Offset = "0xB6EF20", Length = "0x34")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6003BE8")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x6003BE9")]
	[Address(RVA = "0xB70160", Offset = "0xB6EF60", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x6003BEA")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x6003BEB")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x6003BEC")]
	[Address(RVA = "0xB701E0", Offset = "0xB6EFE0", Length = "0x381")]
	public Panel_SnowShelterInteract()
	{
	}
}
