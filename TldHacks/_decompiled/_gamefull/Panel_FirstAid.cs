using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;

[Token(Token = "0x2000655")]
public class Panel_FirstAid : Panel_AutoReferenced, INotificationHandler, IMiniTopNav
{
	[Token(Token = "0x2000656")]
	private class AfflictionsAtLocation
	{
		[Token(Token = "0x4003DBC")]
		[FieldOffset(Offset = "0x10")]
		public bool[] m_AfflictionsArray;

		[Token(Token = "0x4003DBD")]
		[FieldOffset(Offset = "0x18")]
		public AfflictionBodyArea m_Location;

		[Token(Token = "0x60033D5")]
		[Address(RVA = "0xA4EE50", Offset = "0xA4DC50", Length = "0xD4")]
		public AfflictionsAtLocation(AfflictionBodyArea location)
		{
		}

		[Token(Token = "0x60033D6")]
		[Address(RVA = "0xA09030", Offset = "0xA07E30", Length = "0x2C")]
		public void AddAffliction(AfflictionType afflictionType)
		{
		}
	}

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003D3D")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Clothing> m_Clothing;

	[SerializeField]
	[Token(Token = "0x4003D3E")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_Crafting> m_CraftingPanel;

	[SerializeField]
	[Token(Token = "0x4003D3F")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4003D40")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4003D41")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x4003D42")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Map> m_Map;

	[Header("Time Widget")]
	[Token(Token = "0x4003D43")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_TimeWidgetPos;

	[Token(Token = "0x4003D44")]
	[FieldOffset(Offset = "0x68")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[HideInInspector]
	[Token(Token = "0x4003D45")]
	[FieldOffset(Offset = "0x70")]
	public bool m_EnableDiaryOnExit;

	[Token(Token = "0x4003D46")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_ClickBlocker;

	[Token(Token = "0x4003D47")]
	[FieldOffset(Offset = "0x80")]
	public string m_OpenFirstAidAudio;

	[Token(Token = "0x4003D48")]
	[FieldOffset(Offset = "0x88")]
	public string m_CloseFirstAidAudio;

	[Token(Token = "0x4003D49")]
	[FieldOffset(Offset = "0x90")]
	public MiniTopNav m_MiniTopNav;

	[Token(Token = "0x4003D4A")]
	[FieldOffset(Offset = "0x98")]
	public string[] m_ColdStatusLocIDs;

	[Token(Token = "0x4003D4B")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel m_ColdStatusLabel;

	[Token(Token = "0x4003D4C")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel m_ColdPercentLabel;

	[Token(Token = "0x4003D4D")]
	[FieldOffset(Offset = "0xB0")]
	public string[] m_FatigueStatusLocIDs;

	[Token(Token = "0x4003D4E")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel m_FatigueStatusLabel;

	[Token(Token = "0x4003D4F")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel m_FatiguePercentLabel;

	[Token(Token = "0x4003D50")]
	[FieldOffset(Offset = "0xC8")]
	public string[] m_HungerStatusLocIDs;

	[Token(Token = "0x4003D51")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel m_HungerStatusLabel;

	[Token(Token = "0x4003D52")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel m_HungerPercentLabel;

	[Token(Token = "0x4003D53")]
	[FieldOffset(Offset = "0xE0")]
	public string[] m_ThirstStatusLocIDs;

	[Token(Token = "0x4003D54")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel m_ThirstStatusLabel;

	[Token(Token = "0x4003D55")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel m_ThirstPercentLabel;

	[Token(Token = "0x4003D56")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel m_CalorieStoreLabel;

	[Token(Token = "0x4003D57")]
	[FieldOffset(Offset = "0x100")]
	public UILabel m_AirTempLabel;

	[Token(Token = "0x4003D58")]
	[FieldOffset(Offset = "0x108")]
	public UILabel m_WindchillLabel;

	[Token(Token = "0x4003D59")]
	[FieldOffset(Offset = "0x110")]
	public UILabel m_FeelsLikeLabel;

	[Token(Token = "0x4003D5A")]
	[FieldOffset(Offset = "0x118")]
	public UILabel m_LabelConditionPercent;

	[Token(Token = "0x4003D5B")]
	[FieldOffset(Offset = "0x120")]
	public GameObject m_PaperDollMale;

	[Token(Token = "0x4003D5C")]
	[FieldOffset(Offset = "0x128")]
	public GameObject m_PaperDollFemale;

	[Token(Token = "0x4003D5D")]
	[FieldOffset(Offset = "0x130")]
	public UISprite m_SpriteStatusLine;

	[Token(Token = "0x4003D5E")]
	[FieldOffset(Offset = "0x138")]
	public Color m_GoodHealthStatusColor;

	[Range(0f, 100f)]
	[Token(Token = "0x4003D5F")]
	[FieldOffset(Offset = "0x148")]
	public float m_GoodHealthThreshold;

	[Token(Token = "0x4003D60")]
	[FieldOffset(Offset = "0x14C")]
	public Color m_FairHealthStatusColor;

	[Range(0f, 100f)]
	[Token(Token = "0x4003D61")]
	[FieldOffset(Offset = "0x15C")]
	public float m_FairHealthThreshold;

	[Token(Token = "0x4003D62")]
	[FieldOffset(Offset = "0x160")]
	public Color m_PoorHealthStatusColor;

	[Range(0f, 100f)]
	[Token(Token = "0x4003D63")]
	[FieldOffset(Offset = "0x170")]
	public float m_PoorHealthThreshold;

	[Token(Token = "0x4003D64")]
	[FieldOffset(Offset = "0x178")]
	public GameObject m_RightPageHealthyObject;

	[Token(Token = "0x4003D65")]
	[FieldOffset(Offset = "0x180")]
	public GameObject m_RightPageObject;

	[Token(Token = "0x4003D66")]
	[FieldOffset(Offset = "0x188")]
	public UILabel m_LabelCause;

	[Token(Token = "0x4003D67")]
	[FieldOffset(Offset = "0x190")]
	public UILabel m_LabelAfflictionDescription;

	[Token(Token = "0x4003D68")]
	[FieldOffset(Offset = "0x198")]
	public UILabel m_LabelAfflictionDescriptionNoRest;

	[Token(Token = "0x4003D69")]
	[FieldOffset(Offset = "0x1A0")]
	public UITexture[] m_SpriteListItemsNeeded;

	[Token(Token = "0x4003D6A")]
	[FieldOffset(Offset = "0x1A8")]
	public UISprite[] m_CheckmarksItemsNeeded;

	[Token(Token = "0x4003D6B")]
	[FieldOffset(Offset = "0x1B0")]
	public UILabel[] m_NumLabelItemsNeeded;

	[Token(Token = "0x4003D6C")]
	[FieldOffset(Offset = "0x1B8")]
	public UILabel m_LabelWaterAmount;

	[Token(Token = "0x4003D6D")]
	[FieldOffset(Offset = "0x1C0")]
	public UILabel m_altLabelWaterAmount;

	[Token(Token = "0x4003D6E")]
	[FieldOffset(Offset = "0x1C8")]
	public Vector2 m_WaterAmountPixelOffset;

	[Token(Token = "0x4003D6F")]
	[FieldOffset(Offset = "0x1D0")]
	public GameObject m_ObjectRestRemaining;

	[Token(Token = "0x4003D70")]
	[FieldOffset(Offset = "0x1D8")]
	public UILabel m_LabelRestRemaining;

	[Token(Token = "0x4003D71")]
	[FieldOffset(Offset = "0x1E0")]
	public UILabel m_LabelRestRequired;

	[Token(Token = "0x4003D72")]
	[FieldOffset(Offset = "0x1E8")]
	public UILabel[] m_LabelOr;

	[Token(Token = "0x4003D73")]
	[FieldOffset(Offset = "0x1F0")]
	public UILabel[] m_LabelPlus;

	[Token(Token = "0x4003D74")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObject m_ItemsNeededOnlyOneObj;

	[Token(Token = "0x4003D75")]
	[FieldOffset(Offset = "0x200")]
	public GameObject m_ItemsNeededMultipleObj;

	[Token(Token = "0x4003D76")]
	[FieldOffset(Offset = "0x208")]
	public GameObject m_FAKObject;

	[Token(Token = "0x4003D77")]
	[FieldOffset(Offset = "0x210")]
	public ScrollList m_ScrollListEffects;

	[Token(Token = "0x4003D78")]
	[FieldOffset(Offset = "0x218")]
	public GameObject m_ButtonScrollUp;

	[Token(Token = "0x4003D79")]
	[FieldOffset(Offset = "0x220")]
	public GameObject m_ButtonScrollDown;

	[Token(Token = "0x4003D7A")]
	[FieldOffset(Offset = "0x228")]
	public GameObject m_ScrollbarObject;

	[Token(Token = "0x4003D7B")]
	[FieldOffset(Offset = "0x230")]
	public GameObject m_SpecialTreatmentWindow;

	[Token(Token = "0x4003D7C")]
	[FieldOffset(Offset = "0x238")]
	public UILabel m_LabelAfflictionName;

	[Token(Token = "0x4003D7D")]
	[FieldOffset(Offset = "0x240")]
	public UILabel m_LabelSpecialTreatment;

	[Token(Token = "0x4003D7E")]
	[FieldOffset(Offset = "0x248")]
	public UILabel m_LabelSpecialTreatmentDescription;

	[Token(Token = "0x4003D7F")]
	[FieldOffset(Offset = "0x250")]
	public GameObject m_BuffWindow;

	[Token(Token = "0x4003D80")]
	[FieldOffset(Offset = "0x258")]
	public UILabel m_LabelRiskDescription;

	[Token(Token = "0x4003D81")]
	[FieldOffset(Offset = "0x260")]
	public UILabel m_LabelBuffDescription;

	[Token(Token = "0x4003D82")]
	[FieldOffset(Offset = "0x268")]
	public UISprite[] m_BodyIconList;

	[Token(Token = "0x4003D83")]
	[FieldOffset(Offset = "0x270")]
	public GameObject m_BodyIconActiveAnimationObj;

	[Token(Token = "0x4003D84")]
	[FieldOffset(Offset = "0x278")]
	public string m_BodyIconSpriteNameAffliction;

	[Token(Token = "0x4003D85")]
	[FieldOffset(Offset = "0x280")]
	public string m_BodyIconSpriteNameBuff;

	[Token(Token = "0x4003D86")]
	[FieldOffset(Offset = "0x288")]
	public GameObject m_MultipleDosesObject;

	[Token(Token = "0x4003D87")]
	[FieldOffset(Offset = "0x290")]
	public UILabel m_LabelDosesRemaining;

	[Token(Token = "0x4003D88")]
	[FieldOffset(Offset = "0x298")]
	public UILabel m_LabelDosesRequired;

	[Token(Token = "0x4003D89")]
	[FieldOffset(Offset = "0x2A0")]
	public GameObject m_ButtonBack;

	[Token(Token = "0x4003D8A")]
	[FieldOffset(Offset = "0x2A8")]
	public Vector3 m_SprainedWristMajorOffset;

	[Token(Token = "0x4003D8B")]
	[FieldOffset(Offset = "0x2B8")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Header("TintedSprites")]
	[Token(Token = "0x4003D8C")]
	[FieldOffset(Offset = "0x2C0")]
	public Color m_ColorAffliction;

	[Token(Token = "0x4003D8D")]
	[FieldOffset(Offset = "0x2D0")]
	public Color m_ColorRiskAffliction;

	[Token(Token = "0x4003D8E")]
	[FieldOffset(Offset = "0x2E0")]
	public Color m_ColorNormal;

	[Token(Token = "0x4003D8F")]
	[FieldOffset(Offset = "0x2F0")]
	public UISprite[] m_TintedSprites;

	[Header("Treatment Icons")]
	[Token(Token = "0x4003D90")]
	[FieldOffset(Offset = "0x2F8")]
	public GameObject m_TreatmentButtonSingle;

	[Token(Token = "0x4003D91")]
	[FieldOffset(Offset = "0x300")]
	public GameObject m_TreatmentButtonMultiLeft;

	[Token(Token = "0x4003D92")]
	[FieldOffset(Offset = "0x308")]
	public GameObject m_TreatmentButtonMultiRight;

	[Token(Token = "0x4003D93")]
	[FieldOffset(Offset = "0x310")]
	public GameObject m_TreatmentSwapIndictorLeft;

	[Token(Token = "0x4003D94")]
	[FieldOffset(Offset = "0x318")]
	public GameObject m_TreatmentSwapIndictorRight;

	[Token(Token = "0x4003D95")]
	[FieldOffset(Offset = "0x320")]
	public UIWidget m_TreatmentWidgetSingle;

	[Token(Token = "0x4003D96")]
	[FieldOffset(Offset = "0x328")]
	public UIWidget m_TreatmentWidgetMultiLeft;

	[Token(Token = "0x4003D97")]
	[FieldOffset(Offset = "0x330")]
	public UIWidget m_TreatmentWidgetMultiRight;

	[Token(Token = "0x4003D98")]
	[FieldOffset(Offset = "0x338")]
	public UISprite m_TreatmentBorderSingle;

	[Token(Token = "0x4003D99")]
	[FieldOffset(Offset = "0x340")]
	public UISprite m_TreatmentBorderMultiLeft;

	[Token(Token = "0x4003D9A")]
	[FieldOffset(Offset = "0x348")]
	public UISprite m_TreatmentBorderMultiRight;

	[Token(Token = "0x4003D9B")]
	[FieldOffset(Offset = "0x350")]
	public UILabel m_TreatmentDontHaveItemsLabel;

	[Token(Token = "0x4003D9C")]
	[FieldOffset(Offset = "0x358")]
	public UILabel m_UsedAntibioticsAlreadyLabel;

	[Range(0f, 1f)]
	[Token(Token = "0x4003D9D")]
	[FieldOffset(Offset = "0x360")]
	public float m_HasTreatmentAlpha;

	[Range(0f, 1f)]
	[Token(Token = "0x4003D9E")]
	[FieldOffset(Offset = "0x364")]
	public float m_MissingTreatmentAlpha;

	[Header("Scent Indicator")]
	[Token(Token = "0x4003D9F")]
	[FieldOffset(Offset = "0x368")]
	public Panel_HUD.ScentIndicator m_ScentIndicator;

	[Token(Token = "0x4003DA0")]
	[FieldOffset(Offset = "0x370")]
	public UILabel m_ScentHeaderLabel;

	[Header("Duration Widget")]
	[Token(Token = "0x4003DA1")]
	[FieldOffset(Offset = "0x378")]
	public GameObject m_DurationWidgetParentObj;

	[Token(Token = "0x4003DA2")]
	[FieldOffset(Offset = "0x380")]
	public UILabel m_DurationWidgetHoursLabel;

	[Token(Token = "0x4003DA3")]
	[FieldOffset(Offset = "0x388")]
	public UILabel m_DurationWidgetMinutesLabel;

	[Header("VitaminC Widget")]
	[Token(Token = "0x4003DA4")]
	[FieldOffset(Offset = "0x390")]
	public GameObject m_VitaminCWidgetParentObj;

	[Token(Token = "0x4003DA5")]
	[FieldOffset(Offset = "0x398")]
	public UILabel m_VitaminCTreatmentLabel;

	[Token(Token = "0x4003DA6")]
	[FieldOffset(Offset = "0x3A0")]
	public UILabel m_LabelVitaminCTreatmentDescription;

	[Token(Token = "0x4003DA7")]
	[FieldOffset(Offset = "0x3A8")]
	public UISprite m_VitaminCAmountSprite;

	[Token(Token = "0x4003DA8")]
	[FieldOffset(Offset = "0x3B0")]
	private FirstAidKitButton[] m_FakButtons;

	[Token(Token = "0x4003DA9")]
	[FieldOffset(Offset = "0x3B8")]
	private FirstAidKitButton m_SelectedFAKButton;

	[Token(Token = "0x4003DAA")]
	[FieldOffset(Offset = "0x3C0")]
	private AfflictionButton m_SelectedAffButton;

	[Token(Token = "0x4003DAB")]
	[FieldOffset(Offset = "0x3C8")]
	private int m_BodyIconWidthOriginal;

	[Token(Token = "0x4003DAC")]
	[FieldOffset(Offset = "0x3CC")]
	private int m_BodyIconHeightOriginal;

	[Token(Token = "0x4003DAD")]
	[FieldOffset(Offset = "0x3D0")]
	private bool m_DoneFirstUpdate;

	[Token(Token = "0x4003DAE")]
	[FieldOffset(Offset = "0x3D4")]
	private uint m_OpenCloseAudioID;

	[Token(Token = "0x4003DAF")]
	[FieldOffset(Offset = "0x3D8")]
	private string m_ItemJustUsed;

	[Token(Token = "0x4003DB0")]
	[FieldOffset(Offset = "0x3E0")]
	private List<string> m_TreatmentItemsToUse;

	[Token(Token = "0x4003DB1")]
	[FieldOffset(Offset = "0x3E8")]
	private List<string> m_MainTreatmentItems;

	[Token(Token = "0x4003DB2")]
	[FieldOffset(Offset = "0x3F0")]
	private List<string> m_AltTreatmentItems;

	[Token(Token = "0x4003DB3")]
	[FieldOffset(Offset = "0x3F8")]
	private List<Affliction> m_AfflictionsLastFrame;

	[Token(Token = "0x4003DB4")]
	[FieldOffset(Offset = "0x400")]
	private List<Affliction> m_AfflictionsThisFrame;

	[Token(Token = "0x4003DB5")]
	[FieldOffset(Offset = "0x408")]
	private NotificationFlag m_NotificationFlag;

	[Token(Token = "0x4003DB6")]
	[FieldOffset(Offset = "0x410")]
	private Transform[] m_NotificationFlagChildren;

	[Token(Token = "0x4003DB7")]
	[FieldOffset(Offset = "0x418")]
	private AfflictionsAtLocation[] m_AfflictionsAtLocationArray;

	[Token(Token = "0x4003DB8")]
	[FieldOffset(Offset = "0x420")]
	private List<Affliction> m_PaperDollAfflictions;

	[Token(Token = "0x4003DB9")]
	[FieldOffset(Offset = "0x428")]
	private List<Affliction> m_ScrollListAfflictions;

	[Token(Token = "0x4003DBA")]
	[FieldOffset(Offset = "0x430")]
	private List<Affliction> m_HasBadAfflictionList;

	[Token(Token = "0x4003DBB")]
	[FieldOffset(Offset = "0x438")]
	private List<Affliction> m_HasRiskAfflictionList;

	[Token(Token = "0x6003399")]
	[Address(RVA = "0xA3D500", Offset = "0xA3C300", Length = "0x42F")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600339A")]
	[Address(RVA = "0xA3D930", Offset = "0xA3C730", Length = "0xD53")]
	private void Update()
	{
	}

	[Token(Token = "0x600339B")]
	[Address(RVA = "0xA3E690", Offset = "0xA3D490", Length = "0x20")]
	public void DoScrollUp()
	{
	}

	[Token(Token = "0x600339C")]
	[Address(RVA = "0xA3E6C0", Offset = "0xA3D4C0", Length = "0x20")]
	public void DoScrollDown()
	{
	}

	[Token(Token = "0x600339D")]
	[Address(RVA = "0xA3E6F0", Offset = "0xA3D4F0", Length = "0x254")]
	public void OnScrollbarChange()
	{
	}

	[Token(Token = "0x600339E")]
	[Address(RVA = "0xA3E950", Offset = "0xA3D750", Length = "0xBA")]
	public void UseItem(GearItem gi)
	{
	}

	[Token(Token = "0x600339F")]
	[Address(RVA = "0xA3EA10", Offset = "0xA3D810", Length = "0x458")]
	public void SelectItem(FirstAidKitButton fakButton)
	{
	}

	[Token(Token = "0x60033A0")]
	[Address(RVA = "0xA3EE70", Offset = "0xA3DC70", Length = "0x1D8")]
	public void UseSelectedItem()
	{
	}

	[Token(Token = "0x60033A1")]
	[Address(RVA = "0xA3F050", Offset = "0xA3DE50", Length = "0x255")]
	public void SelectAffliction(AfflictionButton affButton)
	{
	}

	[Token(Token = "0x60033A2")]
	[Address(RVA = "0xA3F2B0", Offset = "0xA3E0B0", Length = "0x42D")]
	public void FirstAidItemCallback()
	{
	}

	[Token(Token = "0x60033A3")]
	[Address(RVA = "0xA3F6E0", Offset = "0xA3E4E0", Length = "0x7")]
	public void ProgressBarCancel()
	{
	}

	[Token(Token = "0x60033A4")]
	[Address(RVA = "0xA3F6F0", Offset = "0xA3E4F0", Length = "0xCE")]
	public void RefreshAll()
	{
	}

	[Token(Token = "0x60033A5")]
	[Address(RVA = "0xA3F7C0", Offset = "0xA3E5C0", Length = "0x66C")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60033A6")]
	[Address(RVA = "0xA3FE30", Offset = "0xA3EC30", Length = "0xF5")]
	public void OnBack()
	{
	}

	[Token(Token = "0x60033A7")]
	[Address(RVA = "0xA3FF30", Offset = "0xA3ED30", Length = "0x31A")]
	public void SelectPrevFAKItem(bool playAudio = true)
	{
	}

	[Token(Token = "0x60033A8")]
	[Address(RVA = "0xA40250", Offset = "0xA3F050", Length = "0x318")]
	public void SelectNextFAKItem(bool playAudio = true)
	{
	}

	[Token(Token = "0x60033A9")]
	[Address(RVA = "0xA40570", Offset = "0xA3F370", Length = "0xF1")]
	public AfflictionType GetSelectedAfflictionType()
	{
		return default(AfflictionType);
	}

	[Token(Token = "0x60033AA")]
	[Address(RVA = "0xA40670", Offset = "0xA3F470", Length = "0xF4")]
	public int GetSelectedAfflictionIndex()
	{
		return 0;
	}

	[Token(Token = "0x60033AB")]
	[Address(RVA = "0xA40770", Offset = "0xA3F570", Length = "0x17E")]
	public bool SelectFirstAfflictionOfType(AfflictionType affType)
	{
		return false;
	}

	[Token(Token = "0x60033AC")]
	[Address(RVA = "0xA408F0", Offset = "0xA3F6F0", Length = "0x11F")]
	public void SelectMainTreatment()
	{
	}

	[Token(Token = "0x60033AD")]
	[Address(RVA = "0xA40A10", Offset = "0xA3F810", Length = "0x11F")]
	public void SelectAltTreatment()
	{
	}

	[Token(Token = "0x60033AE")]
	[Address(RVA = "0xA40B30", Offset = "0xA3F930", Length = "0xDA")]
	public void DoMainTreatment()
	{
	}

	[Token(Token = "0x60033AF")]
	[Address(RVA = "0xA40C10", Offset = "0xA3FA10", Length = "0xDA")]
	public void DoAltTreatmeant()
	{
	}

	[Token(Token = "0x60033B0")]
	[Address(RVA = "0xA40CF0", Offset = "0xA3FAF0", Length = "0x210")]
	public Color GetColorForStatusLine()
	{
		return default(Color);
	}

	[Token(Token = "0x60033B1")]
	[Address(RVA = "0xA40F10", Offset = "0xA3FD10", Length = "0xFE")]
	public void UpdateDueToAfflictionHealed()
	{
	}

	[Token(Token = "0x60033B2")]
	[Address(RVA = "0xA41010", Offset = "0xA3FE10", Length = "0x135")]
	public void ResetNotificationsData()
	{
	}

	[Token(Token = "0x60033B3")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool CanShowMiniTopNav()
	{
		return false;
	}

	[Token(Token = "0x60033B4")]
	[Address(RVA = "0xA41150", Offset = "0xA3FF50", Length = "0x8E")]
	public bool OnMiniTopNavButtonClick(Panel_Base owner)
	{
		return false;
	}

	[Token(Token = "0x60033B5")]
	[Address(RVA = "0xA411E0", Offset = "0xA3FFE0", Length = "0x128B")]
	private void RefreshStatusLabels()
	{
	}

	[Token(Token = "0x60033B6")]
	[Address(RVA = "0xA42470", Offset = "0xA41270", Length = "0x7E9")]
	private void UpdateBodyIconActiveAnimation(int affLocation, AfflictionType afflictionType)
	{
	}

	[Token(Token = "0x60033B7")]
	[Address(RVA = "0xA42C60", Offset = "0xA41A60", Length = "0x35A")]
	private void UpdateAllButSelectedBodyIconColors()
	{
	}

	[Token(Token = "0x60033B8")]
	[Address(RVA = "0xA42FC0", Offset = "0xA41DC0", Length = "0x64D")]
	private void RefreshPaperDoll()
	{
	}

	[Token(Token = "0x60033B9")]
	[Address(RVA = "0xA43610", Offset = "0xA42410", Length = "0x14A")]
	private void HideRightPage()
	{
	}

	[Token(Token = "0x60033BA")]
	[Address(RVA = "0xA43760", Offset = "0xA42560", Length = "0x11A8")]
	private void RefreshRightPage()
	{
	}

	[Token(Token = "0x60033BB")]
	[Address(RVA = "0xA48C70", Offset = "0xA47A70", Length = "0x5A")]
	private void RefreshKit()
	{
	}

	[Token(Token = "0x60033BC")]
	[Address(RVA = "0xA48CD0", Offset = "0xA47AD0", Length = "0x2B0")]
	private bool CanUpdateColor(AfflictionButton afflictionButton, AfflictionsAtLocation afflictionsAtLocation)
	{
		return false;
	}

	[Token(Token = "0x60033BD")]
	[Address(RVA = "0xA48F90", Offset = "0xA47D90", Length = "0x604")]
	private void UpdateBodyIconColors(AfflictionButton afflictionButton, bool isButtonSelected, int bodyIconIndex)
	{
	}

	[Token(Token = "0x60033BE")]
	[Address(RVA = "0xA495A0", Offset = "0xA483A0", Length = "0x246")]
	private void AddAfflictionAtLocation(int bodyIconIndex, Affliction affliction)
	{
	}

	[Token(Token = "0x60033BF")]
	[Address(RVA = "0xA497F0", Offset = "0xA485F0", Length = "0xC30")]
	private void RefreshScrollList()
	{
	}

	[Token(Token = "0x60033C0")]
	[Address(RVA = "0xA4A430", Offset = "0xA49230", Length = "0x206")]
	private void CheckIfSelectedAfflictionHealed()
	{
	}

	[Token(Token = "0x60033C1")]
	[Address(RVA = "0xA4A640", Offset = "0xA49440", Length = "0xF4")]
	private void CheckIfSelectedItemUsedUp()
	{
	}

	[Token(Token = "0x60033C2")]
	[Address(RVA = "0xA4A740", Offset = "0xA49540", Length = "0x70")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x60033C3")]
	[Address(RVA = "0xA4A7C0", Offset = "0xA495C0", Length = "0x249B")]
	private void SetItemsNeeded(string[] remedySprites, bool[] remedyComplete, int[] remedyNumRequired, string[] altRemedySprites, bool[] altRemedyComplete, int[] altRemedyNumRequired, ItemLiquidVolume waterNeeded, float restNeeded, float restRequired)
	{
	}

	[Token(Token = "0x60033C4")]
	[Address(RVA = "0xA4CC60", Offset = "0xA4BA60", Length = "0x3BD")]
	private void RefreshCheckmarks()
	{
	}

	[Token(Token = "0x60033C5")]
	[Address(RVA = "0xA4D020", Offset = "0xA4BE20", Length = "0x57")]
	private bool HasAnyFirstAidItem()
	{
		return false;
	}

	[Token(Token = "0x60033C6")]
	[Address(RVA = "0xA4D080", Offset = "0xA4BE80", Length = "0x323")]
	private void MaybeUseNextTreatmentItem()
	{
	}

	[Token(Token = "0x60033C7")]
	[Address(RVA = "0xA06B50", Offset = "0xA05950", Length = "0x13")]
	private bool AfflictionTypeNeedsRestAfterItems(AfflictionType affType)
	{
		return false;
	}

	[Token(Token = "0x60033C8")]
	[Address(RVA = "0xA4D3B0", Offset = "0xA4C1B0", Length = "0x22F")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x60033C9")]
	[Address(RVA = "0xA4D5E0", Offset = "0xA4C3E0", Length = "0x218")]
	private bool HasBadAffliction()
	{
		return false;
	}

	[Token(Token = "0x60033CA")]
	[Address(RVA = "0xA4D800", Offset = "0xA4C600", Length = "0x218")]
	private bool HasRiskAffliction()
	{
		return false;
	}

	[Token(Token = "0x60033CB")]
	[Address(RVA = "0xA4DA20", Offset = "0xA4C820", Length = "0x161")]
	private bool HasAfflictionOfCategory(AfflictionsAtLocation afflictionsAtLocation, AfflictionCategory category)
	{
		return false;
	}

	[Token(Token = "0x60033CC")]
	[Address(RVA = "0xA4DB90", Offset = "0xA4C990", Length = "0xF0")]
	private void ClearAfflictionsAtLocationArray()
	{
	}

	[Token(Token = "0x60033CD")]
	[Address(RVA = "0xA4DC90", Offset = "0xA4CA90", Length = "0x23A")]
	private void UpdateScrollbar()
	{
	}

	[Token(Token = "0x60033CE")]
	[Address(RVA = "0xA4DED0", Offset = "0xA4CCD0", Length = "0x2D0")]
	private void RefreshTintedImages()
	{
	}

	[Token(Token = "0x60033CF")]
	[Address(RVA = "0xA4E1B0", Offset = "0xA4CFB0", Length = "0xAA")]
	private void UpdateScentIndicator()
	{
	}

	[Token(Token = "0x60033D0")]
	[Address(RVA = "0xA4E260", Offset = "0xA4D060", Length = "0x33B")]
	private void CheckForAfflictionListChange()
	{
	}

	[Token(Token = "0x60033D1")]
	[Address(RVA = "0xA4E5A0", Offset = "0xA4D3A0", Length = "0x235")]
	private bool AfflictionListHasChanged()
	{
		return false;
	}

	[Token(Token = "0x60033D2")]
	[Address(RVA = "0xA4E7E0", Offset = "0xA4D5E0", Length = "0x3B")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[Token(Token = "0x60033D3")]
	[Address(RVA = "0xA4E820", Offset = "0xA4D620", Length = "0x1C3")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x60033D4")]
	[Address(RVA = "0xA4E9F0", Offset = "0xA4D7F0", Length = "0x451")]
	public Panel_FirstAid()
	{
	}
}
