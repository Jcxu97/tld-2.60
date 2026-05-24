using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200021C")]
public class CraftingRequirementContainer : MonoBehaviour
{
	[Token(Token = "0x200021D")]
	private enum HighlightItems
	{
		[Token(Token = "0x4001311")]
		None,
		[Token(Token = "0x4001312")]
		Tool,
		[Token(Token = "0x4001313")]
		Time,
		[Token(Token = "0x4001314")]
		Quantity,
		[Token(Token = "0x4001315")]
		Photos
	}

	[Token(Token = "0x4001301")]
	[FieldOffset(Offset = "0x20")]
	public CraftingRequirementLocation m_Location;

	[Token(Token = "0x4001302")]
	[FieldOffset(Offset = "0x28")]
	public List<CraftingRequirementMaterial> m_Materials;

	[Token(Token = "0x4001303")]
	[FieldOffset(Offset = "0x30")]
	public CraftingRequirementMultiTool m_MultiTool;

	[Token(Token = "0x4001304")]
	[FieldOffset(Offset = "0x38")]
	public CraftingRequirementTool m_SingleTool;

	[Token(Token = "0x4001305")]
	[FieldOffset(Offset = "0x40")]
	public CraftingRequirementTime m_Time;

	[Token(Token = "0x4001306")]
	[FieldOffset(Offset = "0x48")]
	public CraftingRequirementTimeSelect m_TimeSelect;

	[Token(Token = "0x4001307")]
	[FieldOffset(Offset = "0x50")]
	public CraftingRequirementQuantitySelect m_QuantitySelect;

	[Token(Token = "0x4001308")]
	[FieldOffset(Offset = "0x58")]
	public CraftingRequirementPhoto m_PhotoSelect;

	[Token(Token = "0x4001309")]
	[FieldOffset(Offset = "0x60")]
	private HighlightItems m_CurrentHighlight;

	[Token(Token = "0x400130A")]
	[FieldOffset(Offset = "0x68")]
	private Panel_Crafting m_OwnerPanel;

	[Token(Token = "0x400130B")]
	[FieldOffset(Offset = "0x70")]
	private readonly List<Vector3> m_Positions;

	[Token(Token = "0x400130C")]
	[FieldOffset(Offset = "0x78")]
	private int m_PositionIndex;

	[Token(Token = "0x400130D")]
	[FieldOffset(Offset = "0x7C")]
	private float m_PositionOffsetY;

	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x80")]
	private int m_DisplayedMaterials;

	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x84")]
	private bool m_RequiresForge;

	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x65EEE0", Offset = "0x65DCE0", Length = "0x97")]
	public void Disable()
	{
	}

	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x65EF80", Offset = "0x65DD80", Length = "0x10A4")]
	public void Enable(Panel_Crafting panel)
	{
	}

	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x660030", Offset = "0x65EE30", Length = "0x64")]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[Token(Token = "0x60012EE")]
	[Address(RVA = "0x6600A0", Offset = "0x65EEA0", Length = "0xE3")]
	public GearItem GetSelectedToolPrefab()
	{
		return null;
	}

	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x660190", Offset = "0x65EF90", Length = "0xFF")]
	public int GetQuantity()
	{
		return 0;
	}

	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x660290", Offset = "0x65F090", Length = "0x106")]
	public void HandleNavigation()
	{
	}

	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x6603A0", Offset = "0x65F1A0", Length = "0x3D")]
	public bool HasMultipleNavigationOptions()
	{
		return false;
	}

	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x6603E0", Offset = "0x65F1E0", Length = "0x34")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x660420", Offset = "0x65F220", Length = "0x440")]
	public void OnNext()
	{
	}

	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x660870", Offset = "0x65F670", Length = "0x430")]
	public void OnPrevious()
	{
	}

	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x660CB0", Offset = "0x65FAB0", Length = "0x8B4")]
	public void Start()
	{
	}

	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x661570", Offset = "0x660370", Length = "0x226")]
	private void AddPosition(GameObject go)
	{
	}

	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x6617A0", Offset = "0x6605A0", Length = "0x160")]
	private void ApplyNextPosition(Transform trans)
	{
	}

	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x661910", Offset = "0x660710", Length = "0x4C")]
	private void SkipToNextPosition()
	{
	}

	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x661960", Offset = "0x660760", Length = "0x1F")]
	private void OnSelectedQuantityChanged()
	{
	}

	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x661980", Offset = "0x660780", Length = "0x7")]
	private void OnSelectedToolChanged()
	{
	}

	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x661990", Offset = "0x660790", Length = "0x3A7")]
	private void RefreshCraftingTimeDisplay()
	{
	}

	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x661D40", Offset = "0x660B40", Length = "0x42C")]
	private void RefreshMaterialDisplay()
	{
	}

	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x662170", Offset = "0x660F70", Length = "0xB2")]
	private void RefreshHighlight()
	{
	}

	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x662230", Offset = "0x661030", Length = "0x7")]
	private void ResetNextPosition()
	{
	}

	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x662240", Offset = "0x661040", Length = "0x1AC")]
	private void SetHighlightedItem(HighlightItems item)
	{
	}

	[Token(Token = "0x6001300")]
	[Address(RVA = "0x6623F0", Offset = "0x6611F0", Length = "0x4BB")]
	private void SetOwnerPanel(Panel_Crafting panel)
	{
	}

	[Token(Token = "0x6001301")]
	[Address(RVA = "0x6628B0", Offset = "0x6616B0", Length = "0x18F")]
	public CraftingRequirementContainer()
	{
	}
}
