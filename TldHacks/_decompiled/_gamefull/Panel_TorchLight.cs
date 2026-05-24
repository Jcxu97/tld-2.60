using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x20006DB")]
public class Panel_TorchLight : Panel_AutoReferenced
{
	[Token(Token = "0x4004916")]
	private const float MATCH_USE_COOLDOWN = 0.4f;

	[Token(Token = "0x4004917")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4004918")]
	[FieldOffset(Offset = "0x38")]
	public float m_LightTorchDistanceXZ;

	[Token(Token = "0x4004919")]
	[FieldOffset(Offset = "0x40")]
	public ScrollList m_ScrollList;

	[Token(Token = "0x400491A")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_ButtonLeft;

	[Token(Token = "0x400491B")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_ButtonRight;

	[Token(Token = "0x400491C")]
	[FieldOffset(Offset = "0x58")]
	public TweenAlpha m_LabelTween;

	[Token(Token = "0x400491D")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_UseLabel;

	[Token(Token = "0x400491E")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_ToolNameLabel;

	[Token(Token = "0x400491F")]
	[FieldOffset(Offset = "0x70")]
	public UIButton m_ButtonUseFireOnly;

	[Token(Token = "0x4004920")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_AllButtonsObject;

	[Token(Token = "0x4004921")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_FireOnlyObject;

	[Token(Token = "0x4004922")]
	[FieldOffset(Offset = "0x88")]
	private List<GearItem> m_AvailableTools;

	[Token(Token = "0x4004923")]
	[FieldOffset(Offset = "0x90")]
	private List<GearItemCoverflow> m_CoverflowItems;

	[Token(Token = "0x4004924")]
	[FieldOffset(Offset = "0x98")]
	private GearItem m_WoodMatches;

	[Token(Token = "0x4004925")]
	[FieldOffset(Offset = "0xA0")]
	private GearItem m_CardboardMatches;

	[Token(Token = "0x4004926")]
	[FieldOffset(Offset = "0xA8")]
	private GearItem m_Flint;

	[Token(Token = "0x4004927")]
	[FieldOffset(Offset = "0xB0")]
	private GearItem m_Striker;

	[Token(Token = "0x4004928")]
	[FieldOffset(Offset = "0xB8")]
	private float m_LastUseTime;

	[Token(Token = "0x6003C55")]
	[Address(RVA = "0x67CA50", Offset = "0x67B850", Length = "0x44")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003C56")]
	[Address(RVA = "0xB79A20", Offset = "0xB78820", Length = "0x5B3")]
	private void Update()
	{
	}

	[Token(Token = "0x6003C57")]
	[Address(RVA = "0xB79FE0", Offset = "0xB78DE0", Length = "0x2A5")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003C58")]
	[Address(RVA = "0xB7A290", Offset = "0xB79090", Length = "0x187")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003C59")]
	[Address(RVA = "0xB7A420", Offset = "0xB79220", Length = "0x513")]
	public void OnUseSelectedItem()
	{
	}

	[Token(Token = "0x6003C5A")]
	[Address(RVA = "0xB7A940", Offset = "0xB79740", Length = "0x11E")]
	public void NextTool()
	{
	}

	[Token(Token = "0x6003C5B")]
	[Address(RVA = "0xB7AA60", Offset = "0xB79860", Length = "0x11E")]
	public void PrevTool()
	{
	}

	[Token(Token = "0x6003C5C")]
	[Address(RVA = "0xB7AB80", Offset = "0xB79980", Length = "0xBA")]
	public void SelectToolByIndex(int index)
	{
	}

	[Token(Token = "0x6003C5D")]
	[Address(RVA = "0xB7AC40", Offset = "0xB79A40", Length = "0x27F")]
	private void OnUseMatches(GearItem matches, bool consumeResource)
	{
	}

	[Token(Token = "0x6003C5E")]
	[Address(RVA = "0xB7AEC0", Offset = "0xB79CC0", Length = "0x200")]
	private void OnUseFlintAndSteel(bool consumeResource)
	{
	}

	[Token(Token = "0x6003C5F")]
	[Address(RVA = "0xB7B0D0", Offset = "0xB79ED0", Length = "0x200")]
	private void OnUseFireStriker(bool consumeResource)
	{
	}

	[Token(Token = "0x6003C60")]
	[Address(RVA = "0xB7B2E0", Offset = "0xB7A0E0", Length = "0x899")]
	private void SetupScrollList()
	{
	}

	[Token(Token = "0x6003C61")]
	[Address(RVA = "0xB7BB80", Offset = "0xB7A980", Length = "0x1FA")]
	private void RefreshVisuals()
	{
	}

	[Token(Token = "0x6003C62")]
	[Address(RVA = "0xB7BD80", Offset = "0xB7AB80", Length = "0x23F")]
	private void StartTorchIgnite(float delaySeconds, string igniteAudio, bool isFire)
	{
	}

	[Token(Token = "0x6003C63")]
	[Address(RVA = "0xB7BFC0", Offset = "0xB7ADC0", Length = "0xF5")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003C64")]
	[Address(RVA = "0xB7C0C0", Offset = "0xB7AEC0", Length = "0xC3")]
	public Panel_TorchLight()
	{
	}
}
