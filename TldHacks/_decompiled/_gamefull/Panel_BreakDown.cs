using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000615")]
public class Panel_BreakDown : Panel_AutoReferenced, IAccelerateTimeProvider
{
	[Token(Token = "0x4003915")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003916")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_BreakdownTopGroup;

	[Token(Token = "0x4003917")]
	[FieldOffset(Offset = "0x40")]
	public float m_SecondsToBreakDown;

	[Token(Token = "0x4003918")]
	[FieldOffset(Offset = "0x48")]
	public BreakDownInfo m_BreakdownInfo;

	[Token(Token = "0x4003919")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_BreakDownNameLabel;

	[Token(Token = "0x400391A")]
	[FieldOffset(Offset = "0x58")]
	public BreakDownInfo m_DestroyInfo;

	[Token(Token = "0x400391B")]
	[FieldOffset(Offset = "0x60")]
	public BreakDownInfo m_CorpseRemovalInfo;

	[Token(Token = "0x400391C")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_ToolToUseLabel;

	[Token(Token = "0x400391D")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_CurrentCaloriesLabel;

	[Token(Token = "0x400391E")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_CurrentCaloriesValLabel;

	[Token(Token = "0x400391F")]
	[FieldOffset(Offset = "0x80")]
	public UITexture m_SelectedToolTexture;

	[Token(Token = "0x4003920")]
	[FieldOffset(Offset = "0x88")]
	public UISprite m_ToolConditionSprite;

	[Token(Token = "0x4003921")]
	[FieldOffset(Offset = "0x90")]
	public UILabel m_ToolConditionLabel;

	[Token(Token = "0x4003922")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_PanelElements;

	[Token(Token = "0x4003923")]
	[FieldOffset(Offset = "0xA0")]
	public string m_NoToolSpriteName;

	[Token(Token = "0x4003924")]
	[FieldOffset(Offset = "0xA8")]
	public Color m_NoToolSpriteColor;

	[Token(Token = "0x4003925")]
	[FieldOffset(Offset = "0xB8")]
	public Vector3 m_NoToolSpriteSizeModifier;

	[Token(Token = "0x4003926")]
	[FieldOffset(Offset = "0xC8")]
	public HarvestRepairMaterial[] m_YieldObjects;

	[Token(Token = "0x4003927")]
	[FieldOffset(Offset = "0xD0")]
	public float m_YieldObjectCenteredX;

	[Token(Token = "0x4003928")]
	[FieldOffset(Offset = "0xD4")]
	public float m_YieldObjectSpacing;

	[Token(Token = "0x4003929")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject m_BreakDownButton;

	[Token(Token = "0x400392A")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_RequiresToolLabel;

	[HideInInspector]
	[Token(Token = "0x400392B")]
	[FieldOffset(Offset = "0xE8")]
	public BreakDown m_BreakDown;

	[Token(Token = "0x400392C")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject m_ToolSelectObject;

	[Token(Token = "0x400392D")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject m_ToolSelectButtons;

	[Token(Token = "0x400392E")]
	[FieldOffset(Offset = "0x100")]
	public GameObject m_YieldGroupObject;

	[Token(Token = "0x400392F")]
	[FieldOffset(Offset = "0x108")]
	public GameObject m_InfoPanelGroupObject;

	[Token(Token = "0x4003930")]
	[FieldOffset(Offset = "0x110")]
	public GameObject m_MouseButtonGroupObject;

	[Token(Token = "0x4003931")]
	[FieldOffset(Offset = "0x118")]
	public GameObject m_BackgroundA;

	[Token(Token = "0x4003932")]
	[FieldOffset(Offset = "0x120")]
	public GameObject m_BackgroundB;

	[Header("Progress icons")]
	[Token(Token = "0x4003933")]
	[FieldOffset(Offset = "0x128")]
	public string m_IconAccelerateTime;

	[Token(Token = "0x4003934")]
	[FieldOffset(Offset = "0x130")]
	private string m_IconAccelerateTimeDestroy;

	[Token(Token = "0x4003935")]
	[FieldOffset(Offset = "0x138")]
	private string m_IconAccelerateTimeCorpseRemoval;

	[Header("Destroy (Safehouse Customization)")]
	[Token(Token = "0x4003936")]
	[FieldOffset(Offset = "0x140")]
	public GameObject m_DestroyGroupObject;

	[Header("Corpse removal (Safehouse Customization)")]
	[Token(Token = "0x4003937")]
	[FieldOffset(Offset = "0x148")]
	public GameObject m_CorpseRevovalGroupObject;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003938")]
	[FieldOffset(Offset = "0x150")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4003939")]
	[FieldOffset(Offset = "0x158")]
	private float m_DurationHours;

	[Token(Token = "0x400393A")]
	[FieldOffset(Offset = "0x15C")]
	private int m_SelectedToolItemIndex;

	[Token(Token = "0x400393B")]
	[FieldOffset(Offset = "0x160")]
	private List<GearItem> m_Tools;

	[Token(Token = "0x400393C")]
	[FieldOffset(Offset = "0x168")]
	private bool m_IsBreakingDown;

	[Token(Token = "0x400393D")]
	[FieldOffset(Offset = "0x16C")]
	private float m_TimeSpentBreakingDown;

	[Token(Token = "0x400393E")]
	[FieldOffset(Offset = "0x170")]
	private bool m_TimeIsAccelerated;

	[Token(Token = "0x400393F")]
	[FieldOffset(Offset = "0x174")]
	private float m_StoredDayLengthScale;

	[Token(Token = "0x4003940")]
	[FieldOffset(Offset = "0x178")]
	private int m_FramesInPanel;

	[Token(Token = "0x4003941")]
	[FieldOffset(Offset = "0x17C")]
	private uint m_BreakDownAudio;

	[Token(Token = "0x4003942")]
	[FieldOffset(Offset = "0x180")]
	private UILocalize m_PanelTitleLocalize;

	[Token(Token = "0x6003003")]
	[Address(RVA = "0x99CDA0", Offset = "0x99BBA0", Length = "0xEF")]
	private bool IsCorpseRemoval()
	{
		return false;
	}

	[Token(Token = "0x6003004")]
	[Address(RVA = "0x99CE90", Offset = "0x99BC90", Length = "0x83")]
	private BreakDownInfo GetPanelInfo()
	{
		return null;
	}

	[Token(Token = "0x6003005")]
	[Address(RVA = "0x67CA50", Offset = "0x67B850", Length = "0x44")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003006")]
	[Address(RVA = "0x99CF20", Offset = "0x99BD20", Length = "0xCE9")]
	private void Update()
	{
	}

	[Token(Token = "0x6003007")]
	[Address(RVA = "0x99DC10", Offset = "0x99CA10", Length = "0x390")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003008")]
	[Address(RVA = "0x99DFB0", Offset = "0x99CDB0", Length = "0x35A")]
	private void ShowRelevantGroups()
	{
	}

	[Token(Token = "0x6003009")]
	[Address(RVA = "0x99E310", Offset = "0x99D110", Length = "0x8")]
	public bool IsTimeAccelerated()
	{
		return false;
	}

	[Token(Token = "0x600300A")]
	[Address(RVA = "0x99E320", Offset = "0x99D120", Length = "0x8")]
	public bool IsBreakingDown()
	{
		return false;
	}

	[Token(Token = "0x600300B")]
	[Address(RVA = "0x7F6DB0", Offset = "0x7F5BB0", Length = "0x13")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x600300C")]
	[Address(RVA = "0x99E330", Offset = "0x99D130", Length = "0xB2")]
	public void OnNextTool()
	{
	}

	[Token(Token = "0x600300D")]
	[Address(RVA = "0x99E3F0", Offset = "0x99D1F0", Length = "0xA8")]
	public void OnPrevTool()
	{
	}

	[Token(Token = "0x600300E")]
	[Address(RVA = "0x99E4A0", Offset = "0x99D2A0", Length = "0x6B")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x600300F")]
	[Address(RVA = "0x99E510", Offset = "0x99D310", Length = "0x471")]
	public void OnBreakDown()
	{
	}

	[Token(Token = "0x6003010")]
	[Address(RVA = "0x99E990", Offset = "0x99D790", Length = "0x1A0")]
	private void BreakDownFinished()
	{
	}

	[Token(Token = "0x6003011")]
	[Address(RVA = "0x99EB40", Offset = "0x99D940", Length = "0x39B")]
	private void UpdateDurationLabel()
	{
	}

	[Token(Token = "0x6003012")]
	[Address(RVA = "0x99EEE0", Offset = "0x99DCE0", Length = "0x1FC")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[Token(Token = "0x6003013")]
	[Address(RVA = "0x99F0E0", Offset = "0x99DEE0", Length = "0x267")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[Token(Token = "0x6003014")]
	[Address(RVA = "0x99F350", Offset = "0x99E150", Length = "0x15C")]
	private void UpdateToolLabel()
	{
	}

	[Token(Token = "0x6003015")]
	[Address(RVA = "0x99F4B0", Offset = "0x99E2B0", Length = "0x5A0")]
	private void UpdateIcons()
	{
	}

	[Token(Token = "0x6003016")]
	[Address(RVA = "0x99FA60", Offset = "0x99E860", Length = "0x6E")]
	private GearItem GetSelectedTool()
	{
		return null;
	}

	[Token(Token = "0x6003017")]
	[Address(RVA = "0x99FAD0", Offset = "0x99E8D0", Length = "0x47F")]
	private void RefreshTools()
	{
	}

	[Token(Token = "0x6003018")]
	[Address(RVA = "0x99FF50", Offset = "0x99ED50", Length = "0x17B")]
	private void MakeDefaultSelections()
	{
	}

	[Token(Token = "0x6003019")]
	[Address(RVA = "0x9A00D0", Offset = "0x99EED0", Length = "0x8F")]
	private string GetSignedInt(int value)
	{
		return null;
	}

	[Token(Token = "0x600301A")]
	[Address(RVA = "0x9A0160", Offset = "0x99EF60", Length = "0x216")]
	private string GetSignedPercentage(float value)
	{
		return null;
	}

	[Token(Token = "0x600301B")]
	[Address(RVA = "0x9A0380", Offset = "0x99F180", Length = "0x7EA")]
	private void RefreshYield()
	{
	}

	[Token(Token = "0x600301C")]
	[Address(RVA = "0x9A0B70", Offset = "0x99F970", Length = "0x28B")]
	private bool ToolIsUsable(GameObject tool)
	{
		return false;
	}

	[Token(Token = "0x600301D")]
	[Address(RVA = "0x9A0E00", Offset = "0x99FC00", Length = "0xD9")]
	private void DegradeToolUsed()
	{
	}

	[Token(Token = "0x600301E")]
	[Address(RVA = "0x9A0EE0", Offset = "0x99FCE0", Length = "0x1A2")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x600301F")]
	[Address(RVA = "0x9A1090", Offset = "0x99FE90", Length = "0xBB")]
	private string GetActionLegendLocId()
	{
		return null;
	}

	[Token(Token = "0x6003020")]
	[Address(RVA = "0x9A1150", Offset = "0x99FF50", Length = "0xCA")]
	private void StartAudioAndRumbleEffects()
	{
	}

	[Token(Token = "0x6003021")]
	[Address(RVA = "0x9A1220", Offset = "0x9A0020", Length = "0x9B")]
	private void StopAudioAndRumbleEffects()
	{
	}

	[Token(Token = "0x6003022")]
	[Address(RVA = "0x9A12C0", Offset = "0x9A00C0", Length = "0xBB")]
	private string GetActionLocId()
	{
		return null;
	}

	[Token(Token = "0x6003023")]
	[Address(RVA = "0x9A1380", Offset = "0x9A0180", Length = "0xAE")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x6003024")]
	[Address(RVA = "0x9A1430", Offset = "0x9A0230", Length = "0xF3")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x6003025")]
	[Address(RVA = "0x9A1530", Offset = "0x9A0330", Length = "0x8C")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6003026")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x6003027")]
	[Address(RVA = "0x9A15C0", Offset = "0x9A03C0", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x6003028")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x6003029")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x600302A")]
	[Address(RVA = "0x9A1640", Offset = "0x9A0440", Length = "0x327")]
	public Panel_BreakDown()
	{
	}
}
