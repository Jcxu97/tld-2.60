using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000669")]
public class Panel_IceFishingHoleClear : Panel_AutoReferenced
{
	[SerializeField]
	[Token(Token = "0x4004012")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[Token(Token = "0x4004013")]
	[FieldOffset(Offset = "0x38")]
	public List<GameObject> m_UsableToolItems;

	[Token(Token = "0x4004014")]
	[FieldOffset(Offset = "0x40")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4004015")]
	[FieldOffset(Offset = "0x48")]
	public ScrollList m_ScrollList;

	[Token(Token = "0x4004016")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_ButtonLeft;

	[Token(Token = "0x4004017")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_ButtonRight;

	[Token(Token = "0x4004018")]
	[FieldOffset(Offset = "0x60")]
	public TweenAlpha m_LabelTween;

	[Token(Token = "0x4004019")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_UseLabel;

	[Token(Token = "0x400401A")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_ToolNameLabel;

	[Token(Token = "0x400401B")]
	[FieldOffset(Offset = "0x78")]
	public float m_ProgressBarSeconds;

	[SerializeField]
	[Token(Token = "0x400401C")]
	[FieldOffset(Offset = "0x7C")]
	private float m_BuildHoleMultiplier;

	[Header("Fishing Hole Errors")]
	[SerializeField]
	[Token(Token = "0x400401D")]
	[FieldOffset(Offset = "0x80")]
	private LocalizedString m_IndoorsErrorText;

	[SerializeField]
	[Token(Token = "0x400401E")]
	[FieldOffset(Offset = "0x88")]
	private LocalizedString m_NoSuitableIceErrorText;

	[SerializeField]
	[Token(Token = "0x400401F")]
	[FieldOffset(Offset = "0x90")]
	private LocalizedString m_NoToolsErrorText;

	[Token(Token = "0x4004020")]
	[FieldOffset(Offset = "0x98")]
	private GearItem m_ToolUsed;

	[Token(Token = "0x4004021")]
	[FieldOffset(Offset = "0xA0")]
	private IceFishingHole m_IceFishingHole;

	[Token(Token = "0x4004022")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_IsBuildingHole;

	[Token(Token = "0x4004023")]
	[FieldOffset(Offset = "0xB0")]
	private List<string> m_FilteredUsableTools;

	[Token(Token = "0x4004024")]
	[FieldOffset(Offset = "0xB8")]
	private readonly List<GearItem> m_AvailableTools;

	[Token(Token = "0x4004025")]
	[FieldOffset(Offset = "0xC0")]
	private readonly List<GearItemCoverflow> m_CoverflowItems;

	[Token(Token = "0x4004026")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_IsClearingIce;

	[Token(Token = "0x60034EF")]
	[Address(RVA = "0xA71520", Offset = "0xA70320", Length = "0x44")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60034F0")]
	[Address(RVA = "0xA71570", Offset = "0xA70370", Length = "0x58B")]
	private void Update()
	{
	}

	[Token(Token = "0x60034F1")]
	[Address(RVA = "0xA71B00", Offset = "0xA70900", Length = "0x11E")]
	public void NextTool()
	{
	}

	[Token(Token = "0x60034F2")]
	[Address(RVA = "0xA71C20", Offset = "0xA70A20", Length = "0x11E")]
	public void PrevTool()
	{
	}

	[Token(Token = "0x60034F3")]
	[Address(RVA = "0xA71D40", Offset = "0xA70B40", Length = "0xBA")]
	public void SelectToolByIndex(int index)
	{
	}

	[Token(Token = "0x60034F4")]
	[Address(RVA = "0xA71E00", Offset = "0xA70C00", Length = "0x9A")]
	public void Launch(IceFishingHole ifh, bool isBuildingHole)
	{
	}

	[Token(Token = "0x60034F5")]
	[Address(RVA = "0xA71EA0", Offset = "0xA70CA0", Length = "0x1A8")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60034F6")]
	[Address(RVA = "0xA72050", Offset = "0xA70E50", Length = "0x82")]
	public void OnBreakIce()
	{
	}

	[Token(Token = "0x60034F7")]
	[Address(RVA = "0xA720E0", Offset = "0xA70EE0", Length = "0x106")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x60034F8")]
	[Address(RVA = "0xA721F0", Offset = "0xA70FF0", Length = "0x254")]
	public void OnBreakIceComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x60034F9")]
	[Address(RVA = "0xA72450", Offset = "0xA71250", Length = "0x73")]
	private void UnlinkFishingHole()
	{
	}

	[Token(Token = "0x60034FA")]
	[Address(RVA = "0xA724D0", Offset = "0xA712D0", Length = "0x8")]
	public bool IsClearingIce()
	{
		return false;
	}

	[Token(Token = "0x60034FB")]
	[Address(RVA = "0xA724E0", Offset = "0xA712E0", Length = "0x4E3")]
	private void UseTool(GearItem gi)
	{
	}

	[Token(Token = "0x60034FC")]
	[Address(RVA = "0xA729D0", Offset = "0xA717D0", Length = "0x1FA")]
	private void RefreshVisuals()
	{
	}

	[Token(Token = "0x60034FD")]
	[Address(RVA = "0xA72BD0", Offset = "0xA719D0", Length = "0xF5")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x60034FE")]
	[Address(RVA = "0xA72CD0", Offset = "0xA71AD0", Length = "0x2F2")]
	private void SetupScrollList()
	{
	}

	[Token(Token = "0x60034FF")]
	[Address(RVA = "0xA72FD0", Offset = "0xA71DD0", Length = "0x304")]
	private void UpdateAvailableTools()
	{
	}

	[Token(Token = "0x6003500")]
	[Address(RVA = "0xA732E0", Offset = "0xA720E0", Length = "0x587")]
	private void InitializeFilteredUsableTools()
	{
	}

	[Token(Token = "0x6003501")]
	[Address(RVA = "0xA73870", Offset = "0xA72670", Length = "0x360")]
	public bool CanBuildFishingHole(out string fishingHoleError)
	{
		fishingHoleError = null;
		return false;
	}

	[Token(Token = "0x6003502")]
	[Address(RVA = "0xA73BE0", Offset = "0xA729E0", Length = "0x201")]
	public Panel_IceFishingHoleClear()
	{
	}
}
