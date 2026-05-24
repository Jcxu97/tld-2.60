using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.SaveState;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x200060B")]
public class Panel_Badges : Panel_AutoReferenced
{
	[SerializeField]
	[Token(Token = "0x400385A")]
	[FieldOffset(Offset = "0x30")]
	private BadgeUISettings m_UISettings;

	[Token(Token = "0x400385B")]
	[FieldOffset(Offset = "0x38")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400385C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_ButtonLeft;

	[Token(Token = "0x400385D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_ButtonRight;

	[Token(Token = "0x400385E")]
	[FieldOffset(Offset = "0x50")]
	public TweenAlpha m_LabelTween;

	[Token(Token = "0x400385F")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_NameLabel;

	[Token(Token = "0x4003860")]
	[FieldOffset(Offset = "0x60")]
	public UISprite m_LineBreakSprite;

	[Token(Token = "0x4003861")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_DescLabel;

	[Token(Token = "0x4003862")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_ProgressBarSprite;

	[Token(Token = "0x4003863")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_ProgressLabel;

	[Token(Token = "0x4003864")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_FeatsObject;

	[Token(Token = "0x4003865")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_ChallengesObject;

	[Token(Token = "0x4003866")]
	[FieldOffset(Offset = "0x90")]
	public UILabel m_NavButtonHeaderLabel;

	[Token(Token = "0x4003867")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_ScrollListParentObject;

	[Token(Token = "0x4003868")]
	[FieldOffset(Offset = "0xA0")]
	public ScrollList m_FeatsScrollList;

	[Token(Token = "0x4003869")]
	[FieldOffset(Offset = "0xA8")]
	public ScrollList m_ChallengesScrollList;

	[Token(Token = "0x400386A")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_FeatsUpsell;

	[Token(Token = "0x400386B")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_ChallengesUpsell;

	[Token(Token = "0x400386C")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_FeatProgressObject;

	[Token(Token = "0x400386D")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite m_FeatProgressSprite;

	[Token(Token = "0x400386E")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel m_FeatProgressLabel;

	[Token(Token = "0x400386F")]
	[FieldOffset(Offset = "0xD8")]
	public Vector2 m_FeatProgressBarRange;

	[Token(Token = "0x4003870")]
	[FieldOffset(Offset = "0xE0")]
	public List<BadgeUIInfo> m_ChallengeBadges;

	[Token(Token = "0x4003871")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject m_FeatBenefitHeader;

	[Token(Token = "0x4003872")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject m_FeatBenefitDescription;

	[Token(Token = "0x4003873")]
	[FieldOffset(Offset = "0xF8")]
	private ScrollList m_SelectedScrollList;

	[Token(Token = "0x4003874")]
	[FieldOffset(Offset = "0x100")]
	private List<BadgeInfo> m_Feats;

	[Token(Token = "0x4003875")]
	[FieldOffset(Offset = "0x108")]
	private List<BadgeInfo> m_Challenges;

	[Token(Token = "0x4003876")]
	[FieldOffset(Offset = "0x110")]
	private List<BadgeInfo> m_SelectedBadgeInfo;

	[Token(Token = "0x4003877")]
	[FieldOffset(Offset = "0x118")]
	private ButtonLegendConfigure[] m_ButtonLegendConfigureArray_Feats;

	[Token(Token = "0x4003878")]
	[FieldOffset(Offset = "0x120")]
	private ButtonLegendConfigure[] m_ButtonLegendConfigureArray_Challenges;

	[Token(Token = "0x4003879")]
	[FieldOffset(Offset = "0x128")]
	private ComingFromScreenCategory m_CameFrom;

	[Token(Token = "0x400387A")]
	[FieldOffset(Offset = "0x130")]
	private UILabel m_FeatBenefitDescriptionLabel;

	[Token(Token = "0x400387B")]
	[FieldOffset(Offset = "0x138")]
	private UILabel m_FeatBenefitHeaderLabel;

	[Token(Token = "0x6002F38")]
	[Address(RVA = "0x984240", Offset = "0x983040", Length = "0x293")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002F39")]
	[Address(RVA = "0x9844E0", Offset = "0x9832E0", Length = "0xFB")]
	private void Update()
	{
	}

	[Token(Token = "0x6002F3A")]
	[Address(RVA = "0x9845E0", Offset = "0x9833E0", Length = "0xB")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002F3B")]
	[Address(RVA = "0x9845F0", Offset = "0x9833F0", Length = "0x217")]
	public void Enable(bool enable, ComingFromScreenCategory cameFrom)
	{
	}

	[Token(Token = "0x6002F3C")]
	[Address(RVA = "0x984810", Offset = "0x983610", Length = "0x13B")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6002F3D")]
	[Address(RVA = "0x984950", Offset = "0x983750", Length = "0xD7")]
	public void OnBadgeLabelClicked()
	{
	}

	[Token(Token = "0x6002F3E")]
	[Address(RVA = "0x984A30", Offset = "0x983830", Length = "0x146")]
	public void NextTool()
	{
	}

	[Token(Token = "0x6002F3F")]
	[Address(RVA = "0x984B80", Offset = "0x983980", Length = "0x146")]
	public void PrevTool()
	{
	}

	[Token(Token = "0x6002F40")]
	[Address(RVA = "0x984CD0", Offset = "0x983AD0", Length = "0x167")]
	public void BadgeIndexSelected(int index)
	{
	}

	[Token(Token = "0x6002F41")]
	[Address(RVA = "0x984E40", Offset = "0x983C40", Length = "0x11F")]
	public void OnFeats()
	{
	}

	[Token(Token = "0x6002F42")]
	[Address(RVA = "0x984F60", Offset = "0x983D60", Length = "0x11F")]
	public void OnChallenges()
	{
	}

	[Token(Token = "0x6002F43")]
	[Address(RVA = "0x985080", Offset = "0x983E80", Length = "0x4F")]
	public bool HasAnyUnviewedUnlockedBadges()
	{
		return false;
	}

	[Token(Token = "0x6002F44")]
	[Address(RVA = "0x9850D0", Offset = "0x983ED0", Length = "0x1F")]
	private void SetupScrollLists()
	{
	}

	[Token(Token = "0x6002F45")]
	[Address(RVA = "0x9850F0", Offset = "0x983EF0", Length = "0x139")]
	private void AddFeatToList(Feat f)
	{
	}

	[Token(Token = "0x6002F46")]
	[Address(RVA = "0x985230", Offset = "0x984030", Length = "0x63A")]
	private void SetupFeatScrollList()
	{
	}

	[Token(Token = "0x6002F47")]
	[Address(RVA = "0x985870", Offset = "0x984670", Length = "0x3E3")]
	private void CleanupFeatScrollList()
	{
	}

	[Token(Token = "0x6002F48")]
	[Address(RVA = "0x985C60", Offset = "0x984A60", Length = "0x10E")]
	private void AddChallengeToList(BadgeInfo bi)
	{
	}

	[Token(Token = "0x6002F49")]
	[Address(RVA = "0x985D70", Offset = "0x984B70", Length = "0x214")]
	private BadgeUIInfo GetBadgeUIInfo(BadgeInfoType type)
	{
		return null;
	}

	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0x985F90", Offset = "0x984D90", Length = "0x639")]
	private void SetupChallengeScrollList()
	{
	}

	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0x9865D0", Offset = "0x9853D0", Length = "0x3E3")]
	private void CleanupChallengeScrollList()
	{
	}

	[Token(Token = "0x6002F4C")]
	[Address(RVA = "0x9869C0", Offset = "0x9857C0", Length = "0xF8")]
	private void EnableFeatBenefit(bool isEnabled)
	{
	}

	[Token(Token = "0x6002F4D")]
	[Address(RVA = "0x986AC0", Offset = "0x9858C0", Length = "0x347")]
	private void RefreshVisualsMainScreen()
	{
	}

	[Token(Token = "0x6002F4E")]
	[Address(RVA = "0x986E10", Offset = "0x985C10", Length = "0xA1D")]
	private void RefreshVisualsScrollList()
	{
	}

	[Token(Token = "0x6002F4F")]
	[Address(RVA = "0x987830", Offset = "0x986630", Length = "0x211")]
	private void SetTabActive(GameObject tabObj)
	{
	}

	[Token(Token = "0x6002F50")]
	[Address(RVA = "0x987A50", Offset = "0x986850", Length = "0x1C9")]
	private bool ListHasUnviewedUnlockedBadge(List<BadgeInfo> badgeInfoList)
	{
		return false;
	}

	[Token(Token = "0x6002F51")]
	[Address(RVA = "0x987C20", Offset = "0x986A20", Length = "0xB8")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6002F52")]
	[Address(RVA = "0x987CE0", Offset = "0x986AE0", Length = "0x116")]
	private void RefreshButtonConfigure(ButtonLegendConfigure[] buttonLegendConfigureArray)
	{
	}

	[Token(Token = "0x6002F53")]
	[Address(RVA = "0x987E00", Offset = "0x986C00", Length = "0x44E")]
	private void DoGamepadControls()
	{
	}

	[Token(Token = "0x6002F54")]
	[Address(RVA = "0x988250", Offset = "0x987050", Length = "0xC9")]
	private void RefreshVisuals()
	{
	}

	[Token(Token = "0x6002F55")]
	[Address(RVA = "0x988320", Offset = "0x987120", Length = "0x1DF")]
	public Panel_Badges()
	{
	}
}
