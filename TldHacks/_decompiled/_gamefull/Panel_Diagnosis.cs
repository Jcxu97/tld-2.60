using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using TLD.IntBackedUnit;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000648")]
public class Panel_Diagnosis : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x2000649")]
	public class OutlineInfoUI
	{
		[Token(Token = "0x4003CC6")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_GameObject;

		[Token(Token = "0x4003CC7")]
		[FieldOffset(Offset = "0x18")]
		public NPCAfflictions.UIOutlineType m_Outline;

		[Token(Token = "0x600332A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public OutlineInfoUI()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200064A")]
	public class RemedyUI
	{
		[Token(Token = "0x4003CC8")]
		[FieldOffset(Offset = "0x10")]
		public UITexture m_Sprite;

		[Token(Token = "0x4003CC9")]
		[FieldOffset(Offset = "0x18")]
		public UISprite m_Checkmark;

		[Token(Token = "0x4003CCA")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_NumLabelItemsNeeded;

		[Token(Token = "0x4003CCB")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_DisplayName;

		[Token(Token = "0x600332B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RemedyUI()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200064B")]
	public class TreatmentUI
	{
		[Token(Token = "0x4003CCC")]
		[FieldOffset(Offset = "0x10")]
		public RemedyUI m_Remedy1;

		[Token(Token = "0x4003CCD")]
		[FieldOffset(Offset = "0x18")]
		public RemedyUI m_Remedy2;

		[Token(Token = "0x4003CCE")]
		[FieldOffset(Offset = "0x20")]
		public RemedyUI m_SingleRemedy;

		[Token(Token = "0x4003CCF")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_LabelPlus;

		[Token(Token = "0x4003CD0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject m_Background;

		[Token(Token = "0x4003CD1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject m_ObjectSelect;

		[Token(Token = "0x4003CD2")]
		[FieldOffset(Offset = "0x40")]
		public GameObject m_ObjectSelected;

		[Token(Token = "0x4003CD3")]
		[FieldOffset(Offset = "0x48")]
		public GenericButtonMouseSpawner m_MouseSelectionButtonSpawner;

		[Token(Token = "0x600332C")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public TreatmentUI()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200064C")]
	public class ApplyTreatmentUI
	{
		[Token(Token = "0x4003CD4")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_ApplyTreatmentButtonsRoot;

		[Token(Token = "0x4003CD5")]
		[FieldOffset(Offset = "0x18")]
		public UILabel m_ApplyTreatmentLabel;

		[Range(0f, 1f)]
		[Token(Token = "0x4003CD6")]
		[FieldOffset(Offset = "0x20")]
		public float m_LabelDisabledAlpha;

		[NonSerialized]
		[Token(Token = "0x4003CD7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton[] m_Buttons;

		[NonSerialized]
		[Token(Token = "0x4003CD8")]
		[FieldOffset(Offset = "0x30")]
		public float m_LabelOriginalAlpha;

		[Token(Token = "0x600332D")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ApplyTreatmentUI()
		{
		}
	}

	[Token(Token = "0x200064D")]
	private class AfflictionsAtLocation
	{
		[Token(Token = "0x4003CD9")]
		[FieldOffset(Offset = "0x10")]
		public bool[] m_AfflictionsArray;

		[Token(Token = "0x4003CDA")]
		[FieldOffset(Offset = "0x18")]
		public AfflictionBodyArea m_Location;

		[Token(Token = "0x600332E")]
		[Address(RVA = "0xA08F50", Offset = "0xA07D50", Length = "0xD4")]
		public AfflictionsAtLocation(AfflictionBodyArea location)
		{
		}

		[Token(Token = "0x600332F")]
		[Address(RVA = "0xA09030", Offset = "0xA07E30", Length = "0x2C")]
		public void AddAffliction(AfflictionType afflictionType)
		{
		}
	}

	[Header("Time Widget")]
	[Token(Token = "0x4003C63")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_TimeWidgetPos;

	[Token(Token = "0x4003C64")]
	[FieldOffset(Offset = "0x38")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003C65")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_ClickBlocker;

	[Token(Token = "0x4003C66")]
	[FieldOffset(Offset = "0x48")]
	public string m_OpenFirstAidAudio;

	[Token(Token = "0x4003C67")]
	[FieldOffset(Offset = "0x50")]
	public string m_CloseFirstAidAudio;

	[Token(Token = "0x4003C68")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_LabelConditionPercent;

	[Token(Token = "0x4003C69")]
	[FieldOffset(Offset = "0x60")]
	public string[] m_ColdStatusLocIDs;

	[Token(Token = "0x4003C6A")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_ColdStatusLabel;

	[Token(Token = "0x4003C6B")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_SpriteStatusLine;

	[Token(Token = "0x4003C6C")]
	[FieldOffset(Offset = "0x78")]
	public Color m_GoodHealthStatusColor;

	[Range(0f, 100f)]
	[Token(Token = "0x4003C6D")]
	[FieldOffset(Offset = "0x88")]
	public float m_GoodHealthThreshold;

	[Token(Token = "0x4003C6E")]
	[FieldOffset(Offset = "0x8C")]
	public Color m_FairHealthStatusColor;

	[Range(0f, 100f)]
	[Token(Token = "0x4003C6F")]
	[FieldOffset(Offset = "0x9C")]
	public float m_FairHealthThreshold;

	[Token(Token = "0x4003C70")]
	[FieldOffset(Offset = "0xA0")]
	public Color m_PoorHealthStatusColor;

	[Range(0f, 100f)]
	[Token(Token = "0x4003C71")]
	[FieldOffset(Offset = "0xB0")]
	public float m_PoorHealthThreshold;

	[Token(Token = "0x4003C72")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_RightPageHealthyObject;

	[Token(Token = "0x4003C73")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_RightPageObject;

	[Token(Token = "0x4003C74")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel m_LabelCause;

	[Token(Token = "0x4003C75")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel m_LabelAfflictionDescription;

	[Token(Token = "0x4003C76")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel m_LabelAfflictionDescriptionNoRest;

	[Token(Token = "0x4003C77")]
	[FieldOffset(Offset = "0xE0")]
	public UITexture[] m_SpriteListItemsNeeded;

	[Token(Token = "0x4003C78")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite[] m_CheckmarksItemsNeeded;

	[Token(Token = "0x4003C79")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel[] m_NumLabelItemsNeeded;

	[Token(Token = "0x4003C7A")]
	[FieldOffset(Offset = "0xF8")]
	public UILabel m_LabelWaterAmount;

	[Token(Token = "0x4003C7B")]
	[FieldOffset(Offset = "0x100")]
	public UILabel m_altLabelWaterAmount;

	[Token(Token = "0x4003C7C")]
	[FieldOffset(Offset = "0x108")]
	public Vector2 m_WaterAmountPixelOffset;

	[Token(Token = "0x4003C7D")]
	[FieldOffset(Offset = "0x110")]
	public GameObject m_ObjectRestRemaining;

	[Token(Token = "0x4003C7E")]
	[FieldOffset(Offset = "0x118")]
	public UILabel m_LabelRestRemaining;

	[Token(Token = "0x4003C7F")]
	[FieldOffset(Offset = "0x120")]
	public UILabel m_LabelRestRequired;

	[Token(Token = "0x4003C80")]
	[FieldOffset(Offset = "0x128")]
	public UILabel[] m_LabelPlus;

	[Token(Token = "0x4003C81")]
	[FieldOffset(Offset = "0x130")]
	public GameObject m_ItemsNeededOnlyOneObj;

	[Token(Token = "0x4003C82")]
	[FieldOffset(Offset = "0x138")]
	public GameObject m_ItemsNeededMultipleObj;

	[Token(Token = "0x4003C83")]
	[FieldOffset(Offset = "0x140")]
	public GameObject m_TreatAfflictionObj;

	[Token(Token = "0x4003C84")]
	[FieldOffset(Offset = "0x148")]
	public GameObject m_SingleTreatmentBG;

	[Token(Token = "0x4003C85")]
	[FieldOffset(Offset = "0x150")]
	public GameObject m_MultipleTreatmentsBG;

	[Token(Token = "0x4003C86")]
	[FieldOffset(Offset = "0x158")]
	public TreatmentUI m_StandardTreatment;

	[Token(Token = "0x4003C87")]
	[FieldOffset(Offset = "0x160")]
	public TreatmentUI m_AlternateTreatment;

	[Header("Misc")]
	[Token(Token = "0x4003C88")]
	[FieldOffset(Offset = "0x168")]
	public ScrollList m_ScrollListEffects;

	[Token(Token = "0x4003C89")]
	[FieldOffset(Offset = "0x170")]
	public GameObject m_ScrollbarObject;

	[Token(Token = "0x4003C8A")]
	[FieldOffset(Offset = "0x178")]
	public GameObject m_SpecialTreatmentWindow;

	[Token(Token = "0x4003C8B")]
	[FieldOffset(Offset = "0x180")]
	public UILabel m_LabelAfflictionName;

	[Token(Token = "0x4003C8C")]
	[FieldOffset(Offset = "0x188")]
	public UILabel m_LabelSpecialTreatment;

	[Token(Token = "0x4003C8D")]
	[FieldOffset(Offset = "0x190")]
	public UILabel m_LabelSpecialTreatmentDescription;

	[Token(Token = "0x4003C8E")]
	[FieldOffset(Offset = "0x198")]
	public GameObject m_BuffWindow;

	[Token(Token = "0x4003C8F")]
	[FieldOffset(Offset = "0x1A0")]
	public UISprite[] m_BodyIconList;

	[Token(Token = "0x4003C90")]
	[FieldOffset(Offset = "0x1A8")]
	public GameObject m_BodyIconActiveAnimationObj;

	[Token(Token = "0x4003C91")]
	[FieldOffset(Offset = "0x1B0")]
	public string m_BodyIconSpriteNameAffliction;

	[Token(Token = "0x4003C92")]
	[FieldOffset(Offset = "0x1B8")]
	public GameObject m_MultipleDosesObject;

	[Token(Token = "0x4003C93")]
	[FieldOffset(Offset = "0x1C0")]
	public GameObject m_ButtonBack;

	[Header("TintedSprites")]
	[Token(Token = "0x4003C94")]
	[FieldOffset(Offset = "0x1C8")]
	public Color m_ColorAffliction;

	[Token(Token = "0x4003C95")]
	[FieldOffset(Offset = "0x1D8")]
	public Color m_ColorNormal;

	[Token(Token = "0x4003C96")]
	[FieldOffset(Offset = "0x1E8")]
	public UISprite[] m_TintedSprites;

	[Header("Treatment Icons")]
	[Token(Token = "0x4003C97")]
	[FieldOffset(Offset = "0x1F0")]
	public GameObject m_TreatmentButtonSingle;

	[Token(Token = "0x4003C98")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObject m_TreatmentButtonMultiLeft;

	[Token(Token = "0x4003C99")]
	[FieldOffset(Offset = "0x200")]
	public GameObject m_TreatmentButtonMultiRight;

	[Token(Token = "0x4003C9A")]
	[FieldOffset(Offset = "0x208")]
	public GameObject m_TreatmentSwapIndictorLeft;

	[Token(Token = "0x4003C9B")]
	[FieldOffset(Offset = "0x210")]
	public GameObject m_TreatmentSwapIndictorRight;

	[Token(Token = "0x4003C9C")]
	[FieldOffset(Offset = "0x218")]
	public UIWidget m_TreatmentWidgetSingle;

	[Token(Token = "0x4003C9D")]
	[FieldOffset(Offset = "0x220")]
	public UIWidget m_TreatmentWidgetMultiLeft;

	[Token(Token = "0x4003C9E")]
	[FieldOffset(Offset = "0x228")]
	public UIWidget m_TreatmentWidgetMultiRight;

	[Token(Token = "0x4003C9F")]
	[FieldOffset(Offset = "0x230")]
	public UISprite m_TreatmentBorderSingle;

	[Token(Token = "0x4003CA0")]
	[FieldOffset(Offset = "0x238")]
	public UISprite m_TreatmentBorderMultiLeft;

	[Token(Token = "0x4003CA1")]
	[FieldOffset(Offset = "0x240")]
	public UISprite m_TreatmentBorderMultiRight;

	[Token(Token = "0x4003CA2")]
	[FieldOffset(Offset = "0x248")]
	public UILabel m_TreatmentDontHaveItemsLabel;

	[Token(Token = "0x4003CA3")]
	[FieldOffset(Offset = "0x250")]
	public UILabel m_UsedAntibioticsAlreadyLabel;

	[Token(Token = "0x4003CA4")]
	[FieldOffset(Offset = "0x258")]
	public GameObject m_DoingTreatmentOverlay;

	[Range(0f, 1f)]
	[Token(Token = "0x4003CA5")]
	[FieldOffset(Offset = "0x260")]
	public float m_DoingTreatmentAlpha;

	[Range(0f, 1f)]
	[Token(Token = "0x4003CA6")]
	[FieldOffset(Offset = "0x264")]
	public float m_HasTreatmentAlpha;

	[Range(0f, 1f)]
	[Token(Token = "0x4003CA7")]
	[FieldOffset(Offset = "0x268")]
	public float m_MissingTreatmentAlpha;

	[Header("Duration Widget")]
	[Token(Token = "0x4003CA8")]
	[FieldOffset(Offset = "0x270")]
	public GameObject m_DurationWidgetParentObj;

	[Token(Token = "0x4003CA9")]
	[FieldOffset(Offset = "0x278")]
	public UILabel m_DurationWidgetHoursLabel;

	[Token(Token = "0x4003CAA")]
	[FieldOffset(Offset = "0x280")]
	public UILabel m_DurationWidgetMinutesLabel;

	[Header("Gamepad Sprites")]
	[Token(Token = "0x4003CAB")]
	[FieldOffset(Offset = "0x288")]
	public UISprite m_SelectStandardGamepadButtonSprite;

	[Token(Token = "0x4003CAC")]
	[FieldOffset(Offset = "0x290")]
	public UISprite m_SelectAlternateGamepadButtonSprite;

	[Token(Token = "0x4003CAD")]
	[FieldOffset(Offset = "0x298")]
	public List<OutlineInfoUI> m_OutlineInfos;

	[Token(Token = "0x4003CAE")]
	[FieldOffset(Offset = "0x2A0")]
	public ApplyTreatmentUI m_ApplyTreatmentUI;

	[Token(Token = "0x4003CAF")]
	[FieldOffset(Offset = "0x2A8")]
	private FirstAidKitButton[] m_FakButtons;

	[Token(Token = "0x4003CB0")]
	[FieldOffset(Offset = "0x2B0")]
	private FirstAidKitButton m_SelectedFAKButton;

	[Token(Token = "0x4003CB1")]
	[FieldOffset(Offset = "0x2B8")]
	private NPCAfflictionButton m_SelectedAffButton;

	[Header("Audio")]
	[Token(Token = "0x4003CB2")]
	[FieldOffset(Offset = "0x2C0")]
	public string m_TreatmentSuccessVO;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003CB3")]
	[FieldOffset(Offset = "0x2C8")]
	private PanelReference<Panel_Clothing> m_Clothing;

	[SerializeField]
	[Token(Token = "0x4003CB4")]
	[FieldOffset(Offset = "0x2D0")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[Token(Token = "0x4003CB5")]
	[FieldOffset(Offset = "0x2D8")]
	private int m_BodyIconWidthOriginal;

	[Token(Token = "0x4003CB6")]
	[FieldOffset(Offset = "0x2DC")]
	private int m_BodyIconHeightOriginal;

	[Token(Token = "0x4003CB7")]
	[FieldOffset(Offset = "0x2E0")]
	private bool m_DoneFirstUpdate;

	[Token(Token = "0x4003CB8")]
	[FieldOffset(Offset = "0x2E4")]
	private uint m_OpenCloseAudioID;

	[Token(Token = "0x4003CB9")]
	[FieldOffset(Offset = "0x2E8")]
	private string m_ItemJustUsed;

	[Token(Token = "0x4003CBA")]
	[FieldOffset(Offset = "0x2F0")]
	private List<NPCAffliction> m_AfflictionsLastFrame;

	[Token(Token = "0x4003CBB")]
	[FieldOffset(Offset = "0x2F8")]
	private List<NPCAffliction> m_AfflictionsThisFrame;

	[Token(Token = "0x4003CBC")]
	[FieldOffset(Offset = "0x300")]
	private List<FirstAidKitButton> m_FakList;

	[Token(Token = "0x4003CBD")]
	[FieldOffset(Offset = "0x308")]
	private AfflictionsAtLocation[] m_AfflictionsAtLocationArray;

	[Token(Token = "0x4003CBE")]
	[FieldOffset(Offset = "0x310")]
	private NPCStatusBar[] m_SatusBars;

	[Token(Token = "0x4003CBF")]
	[FieldOffset(Offset = "0x318")]
	private NPC m_NPCComponent;

	[Token(Token = "0x4003CC0")]
	[FieldOffset(Offset = "0x320")]
	private NPCAffliction m_AfflictionTreatedInProgress;

	[Token(Token = "0x4003CC1")]
	[FieldOffset(Offset = "0x328")]
	private bool m_IsTreatmentInProgressSandard;

	[Token(Token = "0x4003CC2")]
	[FieldOffset(Offset = "0x330")]
	private ItemLiquidVolume m_TreatmentTotalWaterVolumeLiters;

	[Token(Token = "0x4003CC3")]
	[FieldOffset(Offset = "0x338")]
	private bool m_IsWaterTreatmentInProgress;

	[Token(Token = "0x4003CC4")]
	[FieldOffset(Offset = "0x340")]
	private ItemLiquidVolume m_CurrentWaterTreatmentVolumeUsedLiters;

	[Token(Token = "0x4003CC5")]
	[FieldOffset(Offset = "0x348")]
	private List<NPCAffliction> m_ScrollListAfflictions;

	[Token(Token = "0x60032D0")]
	[Address(RVA = "0x9FA260", Offset = "0x9F9060", Length = "0x4C1")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60032D1")]
	[Address(RVA = "0x9FA730", Offset = "0x9F9530", Length = "0x1071")]
	private void Update()
	{
	}

	[Token(Token = "0x60032D2")]
	[Address(RVA = "0x9FB7B0", Offset = "0x9FA5B0", Length = "0xA3")]
	private void ApplyWaterTreatment(float progress)
	{
	}

	[Token(Token = "0x60032D3")]
	[Address(RVA = "0x9FB860", Offset = "0x9FA660", Length = "0x20")]
	public void DoScrollUp()
	{
	}

	[Token(Token = "0x60032D4")]
	[Address(RVA = "0x9FB890", Offset = "0x9FA690", Length = "0x20")]
	public void DoScrollDown()
	{
	}

	[Token(Token = "0x60032D5")]
	[Address(RVA = "0x9FB8C0", Offset = "0x9FA6C0", Length = "0x254")]
	public void OnScrollbarChange()
	{
	}

	[Token(Token = "0x60032D6")]
	[Address(RVA = "0x9FBB20", Offset = "0x9FA920", Length = "0xBA")]
	public void UseItem(GearItem gi)
	{
	}

	[Token(Token = "0x60032D7")]
	[Address(RVA = "0x9FBBE0", Offset = "0x9FA9E0", Length = "0x458")]
	public void SelectItem(FirstAidKitButton fakButton)
	{
	}

	[Token(Token = "0x60032D8")]
	[Address(RVA = "0x9FC040", Offset = "0x9FAE40", Length = "0x1D8")]
	public void UseSelectedItem()
	{
	}

	[Token(Token = "0x60032D9")]
	[Address(RVA = "0x9FC220", Offset = "0x9FB020", Length = "0x349")]
	public void SelectNPCAffliction(NPCAfflictionButton affButton)
	{
	}

	[Token(Token = "0x60032DA")]
	[Address(RVA = "0x9FC570", Offset = "0x9FB370", Length = "0x214")]
	public void RefreshAll()
	{
	}

	[Token(Token = "0x60032DB")]
	[Address(RVA = "0x9FC790", Offset = "0x9FB590", Length = "0xC")]
	public bool TreatmentInProgress()
	{
		return false;
	}

	[Token(Token = "0x60032DC")]
	[Address(RVA = "0x9FC7A0", Offset = "0x9FB5A0", Length = "0xB")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60032DD")]
	[Address(RVA = "0x9FC7B0", Offset = "0x9FB5B0", Length = "0x89C")]
	public void Enable(bool enable, NPC npc)
	{
	}

	[Token(Token = "0x60032DE")]
	[Address(RVA = "0x9FD050", Offset = "0x9FBE50", Length = "0xF2")]
	public void OnBack()
	{
	}

	[Token(Token = "0x60032DF")]
	[Address(RVA = "0x9FD150", Offset = "0x9FBF50", Length = "0x384")]
	public void SelectPrevFAKItem(bool playAudio = true)
	{
	}

	[Token(Token = "0x60032E0")]
	[Address(RVA = "0x9FD4E0", Offset = "0x9FC2E0", Length = "0x388")]
	public void SelectNextFAKItem(bool playAudio = true)
	{
	}

	[Token(Token = "0x60032E1")]
	[Address(RVA = "0x9FD870", Offset = "0x9FC670", Length = "0xF1")]
	public AfflictionType GetSelectedAfflictionType()
	{
		return default(AfflictionType);
	}

	[Token(Token = "0x60032E2")]
	[Address(RVA = "0x9FD970", Offset = "0x9FC770", Length = "0x20D")]
	public Color GetColorForStatusLine()
	{
		return default(Color);
	}

	[Token(Token = "0x60032E3")]
	[Address(RVA = "0x9FDB80", Offset = "0x9FC980", Length = "0x44")]
	public bool IsSameAffliction(NPCAffliction afflictiona, NPCAffliction afflictionb)
	{
		return false;
	}

	[Token(Token = "0x60032E4")]
	[Address(RVA = "0x9FDBD0", Offset = "0x9FC9D0", Length = "0x42")]
	public bool IsSameAffliction(NPCAffliction afflictiona, NPCAfflictionButton afflictionButtonb)
	{
		return false;
	}

	[Token(Token = "0x60032E5")]
	[Address(RVA = "0x9FDC20", Offset = "0x9FCA20", Length = "0x3EB")]
	private void PostTreatment(NPCAffliction affliction)
	{
	}

	[Token(Token = "0x60032E6")]
	[Address(RVA = "0x9FE010", Offset = "0x9FCE10", Length = "0x1C7")]
	private void MaybeReplaceExitAnimation(NPCAffliction affliction)
	{
	}

	[Token(Token = "0x60032E7")]
	[Address(RVA = "0x9FE1E0", Offset = "0x9FCFE0", Length = "0x11C")]
	private void ReplaceAnimation(AssetReferenceTimeline timelineExitRef, AnimatedInteraction animatedInteraction)
	{
	}

	[Token(Token = "0x60032E8")]
	[Address(RVA = "0x9FE300", Offset = "0x9FD100", Length = "0x870")]
	private void ApplyStandardTreatment()
	{
	}

	[Token(Token = "0x60032E9")]
	[Address(RVA = "0x9FEB80", Offset = "0x9FD980", Length = "0x8A")]
	private bool IsWaterTreamentInProgress()
	{
		return false;
	}

	[Token(Token = "0x60032EA")]
	[Address(RVA = "0x9FEC10", Offset = "0x9FDA10", Length = "0x298")]
	private void OnTreatmentComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x60032EB")]
	[Address(RVA = "0x9FEEB0", Offset = "0x9FDCB0", Length = "0x6DC")]
	private void ApplyAlternateTreatment()
	{
	}

	[Token(Token = "0x60032EC")]
	[Address(RVA = "0x9FF590", Offset = "0x9FE390", Length = "0xA4A")]
	private void RefreshStatusLabels()
	{
	}

	[Token(Token = "0x60032ED")]
	[Address(RVA = "0x9FFFE0", Offset = "0x9FEDE0", Length = "0x7E4")]
	private void UpdateBodyIconActiveAnimation(int affLocation, AfflictionType afflictionType)
	{
	}

	[Token(Token = "0x60032EE")]
	[Address(RVA = "0xA007D0", Offset = "0x9FF5D0", Length = "0x340")]
	private void DisableAfflictionButtons()
	{
	}

	[Token(Token = "0x60032EF")]
	[Address(RVA = "0xA00B20", Offset = "0x9FF920", Length = "0x35A")]
	private void UpdateAllButSelectedBodyIconColors()
	{
	}

	[Token(Token = "0x60032F0")]
	[Address(RVA = "0xA00E80", Offset = "0x9FFC80", Length = "0x139")]
	private void HideRightPage()
	{
	}

	[Token(Token = "0x60032F1")]
	[Address(RVA = "0xA00FC0", Offset = "0x9FFDC0", Length = "0xF2")]
	private NPCAffliction GetSelectedAffliction()
	{
		return null;
	}

	[Token(Token = "0x60032F2")]
	[Address(RVA = "0xA010C0", Offset = "0x9FFEC0", Length = "0xC1")]
	private void GatherStatusBars()
	{
	}

	[Token(Token = "0x60032F3")]
	[Address(RVA = "0xA01190", Offset = "0x9FFF90", Length = "0x9C")]
	private void HookupStatusBars()
	{
	}

	[Token(Token = "0x60032F4")]
	[Address(RVA = "0xA01230", Offset = "0xA00030", Length = "0x5A")]
	private void UpdateStatusBars()
	{
	}

	[Token(Token = "0x60032F5")]
	[Address(RVA = "0xA01290", Offset = "0xA00090", Length = "0x7F")]
	private void GetAlternateAfflictionsRemediesInfo(out string[] altRemedySprites, out bool[] altRemedyComplete, out int[] altRemedyNumRequired)
	{
		altRemedySprites = null;
		altRemedyComplete = null;
		altRemedyNumRequired = null;
	}

	[Token(Token = "0x60032F6")]
	[Address(RVA = "0xA01310", Offset = "0xA00110", Length = "0x7F")]
	private void GetAfflictionsRemediesInfo(out string[] remedySprites, out bool[] remedyComplete, out int[] remedyNumRequired)
	{
		remedySprites = null;
		remedyComplete = null;
		remedyNumRequired = null;
	}

	[Token(Token = "0x60032F7")]
	[Address(RVA = "0xA01390", Offset = "0xA00190", Length = "0x1F7")]
	private bool PlayerHasRemedy(AfflictionRemedy remedy, AfflictionDefinition afflictionDefinition)
	{
		return false;
	}

	[Token(Token = "0x60032F8")]
	[Address(RVA = "0xA01590", Offset = "0xA00390", Length = "0x8A")]
	private bool PlayerCanUseRemedy(NPCAffliction npcAffliction, AfflictionRemedy afflictionRemedy1, bool remedy1Complete, AfflictionRemedy afflictionRemedy2, bool remedy2Complete)
	{
		return false;
	}

	[Token(Token = "0x60032F9")]
	[Address(RVA = "0xA01620", Offset = "0xA00420", Length = "0xC1")]
	private bool HasStandardTreatment(NPCAffliction npcAffliction)
	{
		return false;
	}

	[Token(Token = "0x60032FA")]
	[Address(RVA = "0xA016F0", Offset = "0xA004F0", Length = "0xC1")]
	private bool HasAlternateTreatment(NPCAffliction npcAffliction)
	{
		return false;
	}

	[Token(Token = "0x60032FB")]
	[Address(RVA = "0xA017C0", Offset = "0xA005C0", Length = "0xE7")]
	private void EnableMultipleRemedies(TreatmentUI ui, bool enabled)
	{
	}

	[Token(Token = "0x60032FC")]
	[Address(RVA = "0xA018B0", Offset = "0xA006B0", Length = "0x2A")]
	private void EnableAlternateTreatment(bool enabled)
	{
	}

	[Token(Token = "0x60032FD")]
	[Address(RVA = "0xA018E0", Offset = "0xA006E0", Length = "0x322")]
	private void UpdateRestUI(NPCAffliction affliction)
	{
	}

	[Token(Token = "0x60032FE")]
	[Address(RVA = "0xA01C10", Offset = "0xA00A10", Length = "0x71")]
	private bool CanSelectAlternateTreatment()
	{
		return false;
	}

	[Token(Token = "0x60032FF")]
	[Address(RVA = "0xA01C90", Offset = "0xA00A90", Length = "0x71")]
	private bool CanSelectStandardTreatment()
	{
		return false;
	}

	[Token(Token = "0x6003300")]
	[Address(RVA = "0xA01D10", Offset = "0xA00B10", Length = "0x1D5")]
	private void UpdateStandardTreatmentUI(NPCAffliction affliction)
	{
	}

	[Token(Token = "0x6003301")]
	[Address(RVA = "0xA01EF0", Offset = "0xA00CF0", Length = "0x1D5")]
	private void UpdateAlternateTreatmentUI(NPCAffliction affliction)
	{
	}

	[Token(Token = "0x6003302")]
	[Address(RVA = "0xA020D0", Offset = "0xA00ED0", Length = "0x52A")]
	private static void GetAfflictionsRemediesParams(out string[] remedySprites, out bool[] remedyComplete, out int[] remedyNumRequired, AfflictionRemedy afflictionRemedy1, AfflictionRemedy afflictionRemedy2, bool remedy1Complete, bool remedy2Complete)
	{
		remedySprites = null;
		remedyComplete = null;
		remedyNumRequired = null;
	}

	[Token(Token = "0x6003303")]
	[Address(RVA = "0xA02600", Offset = "0xA01400", Length = "0x1520")]
	private void RefreshRightPage()
	{
	}

	[Token(Token = "0x6003304")]
	[Address(RVA = "0xA03B40", Offset = "0xA02940", Length = "0x196")]
	private void DisableMultiAndSingleTreatmentsBG()
	{
	}

	[Token(Token = "0x6003305")]
	[Address(RVA = "0xA03CE0", Offset = "0xA02AE0", Length = "0x196")]
	private void EnableMultiTreatmentBG()
	{
	}

	[Token(Token = "0x6003306")]
	[Address(RVA = "0xA03E80", Offset = "0xA02C80", Length = "0x196")]
	private void EnableSingleTreatmentBG()
	{
	}

	[Token(Token = "0x6003307")]
	[Address(RVA = "0xA04020", Offset = "0xA02E20", Length = "0x21")]
	private void EnableApplyTreatmentUI(bool canApplyTreatment)
	{
	}

	[Token(Token = "0x6003308")]
	[Address(RVA = "0xA04050", Offset = "0xA02E50", Length = "0x13C")]
	private bool CanApplyTreatment()
	{
		return false;
	}

	[Token(Token = "0x6003309")]
	[Address(RVA = "0xA04190", Offset = "0xA02F90", Length = "0x5D")]
	private void RefreshSelection(NPCAffliction npcAffliction)
	{
	}

	[Token(Token = "0x600330A")]
	[Address(RVA = "0xA041F0", Offset = "0xA02FF0", Length = "0x2A")]
	private void EnableAlternateSelectionButtons(bool isEnabled)
	{
	}

	[Token(Token = "0x600330B")]
	[Address(RVA = "0xA04220", Offset = "0xA03020", Length = "0x2A")]
	private void EnableStandardSelectionButtons(bool isEnabled)
	{
	}

	[Token(Token = "0x600330C")]
	[Address(RVA = "0xA04250", Offset = "0xA03050", Length = "0x8F")]
	private void DisableTreatmentSelectionObjects()
	{
	}

	[Token(Token = "0x600330D")]
	[Address(RVA = "0xA042E0", Offset = "0xA030E0", Length = "0x5A")]
	private void RefreshKit()
	{
	}

	[Token(Token = "0x600330E")]
	[Address(RVA = "0xA04340", Offset = "0xA03140", Length = "0x58F")]
	private void UpdateBodyIconColors(NPCAfflictionButton afflictionButton, bool isButtonSelected, int bodyIconIndex)
	{
	}

	[Token(Token = "0x600330F")]
	[Address(RVA = "0xA048D0", Offset = "0xA036D0", Length = "0x214")]
	private void AddAfflictionAtLocation(int bodyIconIndex, AfflictionBodyArea location, AfflictionType type)
	{
	}

	[Token(Token = "0x6003310")]
	[Address(RVA = "0xA04AF0", Offset = "0xA038F0", Length = "0xB80")]
	private void RefreshScrollList()
	{
	}

	[Token(Token = "0x6003311")]
	[Address(RVA = "0xA05680", Offset = "0xA04480", Length = "0x2A7")]
	private void CheckIfSelectedAfflictionHealed()
	{
	}

	[Token(Token = "0x6003312")]
	[Address(RVA = "0xA05930", Offset = "0xA04730", Length = "0xF4")]
	private void CheckIfSelectedItemUsedUp()
	{
	}

	[Token(Token = "0x6003313")]
	[Address(RVA = "0xA05A30", Offset = "0xA04830", Length = "0x32E")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x6003314")]
	[Address(RVA = "0xA05D60", Offset = "0xA04B60", Length = "0x591")]
	public void UpdateWaterRemedyUI(ItemLiquidVolume waterNeeded, RemedyUI ui, AfflictionType afflictionType)
	{
	}

	[Token(Token = "0x6003315")]
	[Address(RVA = "0xA06300", Offset = "0xA05100", Length = "0x1C")]
	public void SelectStandardTreatment()
	{
	}

	[Token(Token = "0x6003316")]
	[Address(RVA = "0xA06320", Offset = "0xA05120", Length = "0x1C")]
	public void SelectAlternateTreatment()
	{
	}

	[Token(Token = "0x6003317")]
	[Address(RVA = "0xA06340", Offset = "0xA05140", Length = "0xB7")]
	public void ApplyTreatment()
	{
	}

	[Token(Token = "0x6003318")]
	[Address(RVA = "0xA06400", Offset = "0xA05200", Length = "0x190")]
	private void UpdateRemedyUI(RemedyUI ui, AfflictionRemedy remedy, bool itemNeeded, ItemLiquidVolume waterNeeded, AfflictionType afflictionType)
	{
	}

	[Token(Token = "0x6003319")]
	[Address(RVA = "0xA065A0", Offset = "0xA053A0", Length = "0x541")]
	private void UpdateHasTreatments(bool hasMainTreatment, bool hasAltTreatment)
	{
	}

	[Token(Token = "0x600331A")]
	[Address(RVA = "0xA06AF0", Offset = "0xA058F0", Length = "0x57")]
	private bool HasAnyFirstAidItem()
	{
		return false;
	}

	[Token(Token = "0x600331B")]
	[Address(RVA = "0xA06B50", Offset = "0xA05950", Length = "0x13")]
	private bool AfflictionTypeNeedsRestAfterItems(AfflictionType affType)
	{
		return false;
	}

	[Token(Token = "0x600331C")]
	[Address(RVA = "0xA06B70", Offset = "0xA05970", Length = "0x2DD")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x600331D")]
	[Address(RVA = "0xA06E50", Offset = "0xA05C50", Length = "0xF0")]
	private void ClearAfflictionsAtLocationArray()
	{
	}

	[Token(Token = "0x600331E")]
	[Address(RVA = "0xA06F50", Offset = "0xA05D50", Length = "0x23A")]
	private void UpdateScrollbar()
	{
	}

	[Token(Token = "0x600331F")]
	[Address(RVA = "0xA07190", Offset = "0xA05F90", Length = "0x271")]
	private void RefreshTintedImages()
	{
	}

	[Token(Token = "0x6003320")]
	[Address(RVA = "0xA07410", Offset = "0xA06210", Length = "0x423")]
	private void CheckForAfflictionListChange()
	{
	}

	[Token(Token = "0x6003321")]
	[Address(RVA = "0xA07840", Offset = "0xA06640", Length = "0x178")]
	private bool AfflictionListHasChanged()
	{
		return false;
	}

	[Token(Token = "0x6003322")]
	[Address(RVA = "0xA079C0", Offset = "0xA067C0", Length = "0x3EC")]
	private void GetAllAfflictions(ref List<NPCAffliction> list)
	{
	}

	[Token(Token = "0x6003323")]
	[Address(RVA = "0xA07DB0", Offset = "0xA06BB0", Length = "0x1A3")]
	private float GetColdPercent()
	{
		return 0f;
	}

	[Token(Token = "0x6003324")]
	[Address(RVA = "0xA07F60", Offset = "0xA06D60", Length = "0x1B0")]
	private float GetConditionPercent()
	{
		return 0f;
	}

	[Token(Token = "0x6003325")]
	[Address(RVA = "0xA08120", Offset = "0xA06F20", Length = "0x1A3")]
	private float GetCriticalHP()
	{
		return 0f;
	}

	[Token(Token = "0x6003326")]
	[Address(RVA = "0xA082D0", Offset = "0xA070D0", Length = "0x1A3")]
	private float GetHP()
	{
		return 0f;
	}

	[Token(Token = "0x6003327")]
	[Address(RVA = "0xA08480", Offset = "0xA07280", Length = "0x377")]
	private void EnableOutline(NPC npc)
	{
	}

	[Token(Token = "0x6003328")]
	[Address(RVA = "0xA08800", Offset = "0xA07600", Length = "0x39A")]
	private void EnableApplyTreatmentButton(bool isEnabled)
	{
	}

	[Token(Token = "0x6003329")]
	[Address(RVA = "0xA08BA0", Offset = "0xA079A0", Length = "0x3A1")]
	public Panel_Diagnosis()
	{
	}
}
