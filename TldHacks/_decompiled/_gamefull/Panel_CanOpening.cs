using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000617")]
public class Panel_CanOpening : Panel_AutoReferenced
{
	[Token(Token = "0x4003944")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003945")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_TitleLabel;

	[Token(Token = "0x4003946")]
	[FieldOffset(Offset = "0x40")]
	public ScrollList m_ScrollList;

	[Token(Token = "0x4003947")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_ButtonLeft;

	[Token(Token = "0x4003948")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_ButtonRight;

	[Token(Token = "0x4003949")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_InspectGearOffset;

	[Token(Token = "0x400394A")]
	[FieldOffset(Offset = "0x68")]
	public TweenAlpha m_LabelTween;

	[Token(Token = "0x400394B")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_UseLabel;

	[Token(Token = "0x400394C")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_ToolNameLabel;

	[Token(Token = "0x400394D")]
	[FieldOffset(Offset = "0x80")]
	public GameObject[] m_UsableTools;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400394E")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_FeedFire> m_FeedFire;

	[SerializeField]
	[Token(Token = "0x400394F")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[HideInInspector]
	[Token(Token = "0x4003950")]
	[FieldOffset(Offset = "0x98")]
	public bool m_CameFromInventory;

	[HideInInspector]
	[Token(Token = "0x4003951")]
	[FieldOffset(Offset = "0x99")]
	public bool m_RestoreItemInHands;

	[HideInInspector]
	[Token(Token = "0x4003952")]
	[FieldOffset(Offset = "0xA0")]
	public CookingPotItem m_CookingPotInUse;

	[HideInInspector]
	[Token(Token = "0x4003953")]
	[FieldOffset(Offset = "0xA8")]
	public GearItem m_GearItemToOpen;

	[Token(Token = "0x4003954")]
	[FieldOffset(Offset = "0xB0")]
	private List<GearItem> m_AvailableTools;

	[Token(Token = "0x4003955")]
	[FieldOffset(Offset = "0xB8")]
	private List<GearItemCoverflow> m_CoverflowItems;

	[Token(Token = "0x4003956")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_IsGoingToOpenItem;

	[Token(Token = "0x4003957")]
	[FieldOffset(Offset = "0xC4")]
	private Vector3 m_InspectLightOrigPos;

	[Token(Token = "0x4003958")]
	[FieldOffset(Offset = "0xD0")]
	private float m_InspectCamOrigDepth;

	[Token(Token = "0x4003959")]
	[FieldOffset(Offset = "0xD8")]
	private List<string> m_FilteredUsableTools;

	[Token(Token = "0x600302E")]
	[Address(RVA = "0x67CA50", Offset = "0x67B850", Length = "0x44")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600302F")]
	[Address(RVA = "0x9A1B20", Offset = "0x9A0920", Length = "0x693")]
	private void Update()
	{
	}

	[Token(Token = "0x6003030")]
	[Address(RVA = "0x9A21C0", Offset = "0x9A0FC0", Length = "0x264")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003031")]
	[Address(RVA = "0x9A2430", Offset = "0x9A1230", Length = "0x144")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003032")]
	[Address(RVA = "0x9A2580", Offset = "0x9A1380", Length = "0x3CF")]
	public void OnOpen()
	{
	}

	[Token(Token = "0x6003033")]
	[Address(RVA = "0x6BCD20", Offset = "0x6BBB20", Length = "0x8")]
	public bool IsGoingToOpenItem()
	{
		return false;
	}

	[Token(Token = "0x6003034")]
	[Address(RVA = "0x9A2950", Offset = "0x9A1750", Length = "0x11E")]
	public void NextTool()
	{
	}

	[Token(Token = "0x6003035")]
	[Address(RVA = "0x9A2A70", Offset = "0x9A1870", Length = "0x11E")]
	public void PrevTool()
	{
	}

	[Token(Token = "0x6003036")]
	[Address(RVA = "0x9A2B90", Offset = "0x9A1990", Length = "0xBA")]
	public void SelectToolByIndex(int index)
	{
	}

	[Token(Token = "0x6003037")]
	[Address(RVA = "0x9A2C50", Offset = "0x9A1A50", Length = "0x1D8")]
	public void OnSmash()
	{
	}

	[Token(Token = "0x6003038")]
	[Address(RVA = "0x9A2E30", Offset = "0x9A1C30", Length = "0x788")]
	private void SetupScrollList()
	{
	}

	[Token(Token = "0x6003039")]
	[Address(RVA = "0x9A35C0", Offset = "0x9A23C0", Length = "0x49A")]
	private void InitializeFilteredUsableTools()
	{
	}

	[Token(Token = "0x600303A")]
	[Address(RVA = "0x9A3A60", Offset = "0x9A2860", Length = "0x1FA")]
	private void RefreshVisuals()
	{
	}

	[Token(Token = "0x600303B")]
	[Address(RVA = "0x9A3C60", Offset = "0x9A2A60", Length = "0xF5")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x600303C")]
	[Address(RVA = "0x9A3D60", Offset = "0x9A2B60", Length = "0x91")]
	private bool ToolCanOpenSelectedItem(CanOpeningItem ci)
	{
		return false;
	}

	[Token(Token = "0x600303D")]
	[Address(RVA = "0x9A3E00", Offset = "0x9A2C00", Length = "0x16F")]
	public Panel_CanOpening()
	{
	}
}
