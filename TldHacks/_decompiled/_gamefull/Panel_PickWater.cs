using System;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006B3")]
public class Panel_PickWater : Panel_AutoReferenced
{
	[Token(Token = "0x4004728")]
	public static readonly ItemLiquidVolume s_DeltaLiters;

	[Token(Token = "0x4004729")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400472A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_Label_Description;

	[Token(Token = "0x400472B")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_Label_Title;

	[Token(Token = "0x400472C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_Label_NumUnits;

	[Token(Token = "0x400472D")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_Execute_Button;

	[Token(Token = "0x400472E")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_ExecuteAll_Button;

	[Token(Token = "0x400472F")]
	[FieldOffset(Offset = "0x60")]
	public LocalizedString m_LocalizedProgressBarMessage;

	[Token(Token = "0x4004730")]
	[FieldOffset(Offset = "0x68")]
	public float m_ProgressBarDurationSecondsBase;

	[Token(Token = "0x4004731")]
	[FieldOffset(Offset = "0x6C")]
	public float m_ProgressBarDurationSecondsPerLiter;

	[Token(Token = "0x4004732")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_WaterBottle_1000ml;

	[Token(Token = "0x4004733")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_WaterBottle_500ml;

	[Token(Token = "0x4004734")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_WaterSupply_Potable;

	[Token(Token = "0x4004735")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_WaterSupply_NonPotable;

	[Token(Token = "0x4004736")]
	[FieldOffset(Offset = "0x90")]
	private ItemLiquidVolume m_numLiters;

	[Token(Token = "0x4004737")]
	[FieldOffset(Offset = "0x98")]
	private ItemLiquidVolume m_maxLiters;

	[HideInInspector]
	[Token(Token = "0x4004738")]
	[FieldOffset(Offset = "0xA0")]
	public EnablePanelOnExit m_EnablePanelOnExit;

	[HideInInspector]
	[Token(Token = "0x4004739")]
	[FieldOffset(Offset = "0xA4")]
	public bool m_CameFromDrag;

	[Token(Token = "0x400473A")]
	[FieldOffset(Offset = "0xA8")]
	private WaterSupply m_WaterSupply;

	[Token(Token = "0x400473B")]
	[FieldOffset(Offset = "0xB0")]
	private WaterSource m_WaterSource;

	[Token(Token = "0x400473C")]
	[FieldOffset(Offset = "0xB8")]
	private Container m_Container;

	[Token(Token = "0x400473D")]
	[FieldOffset(Offset = "0xC0")]
	private PickWaterExecuteAction m_ExecuteAction;

	[Token(Token = "0x400473E")]
	[FieldOffset(Offset = "0xC8")]
	private Action<ItemLiquidVolume> m_OnGenericTransferWater;

	[Token(Token = "0x400473F")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_IsTakingWater;

	[Token(Token = "0x4004740")]
	[FieldOffset(Offset = "0xD8")]
	public UITexture m_GearIcon;

	[Token(Token = "0x4004741")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_ButtonIncrease;

	[Token(Token = "0x4004742")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject m_ButtonDecrease;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004743")]
	[FieldOffset(Offset = "0xF0")]
	private PanelReference<Panel_Container> m_ContainerPanel;

	[SerializeField]
	[Token(Token = "0x4004744")]
	[FieldOffset(Offset = "0xF8")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4004745")]
	[FieldOffset(Offset = "0x100")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4004746")]
	[FieldOffset(Offset = "0x108")]
	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	[Token(Token = "0x17000309")]
	public string m_ProgressBarMessage
	{
		[Token(Token = "0x6003A67")]
		[Address(RVA = "0x6BCD50", Offset = "0x6BBB50", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A68")]
	[Address(RVA = "0xB42190", Offset = "0xB40F90", Length = "0x89")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003A69")]
	[Address(RVA = "0xB44E10", Offset = "0xB43C10", Length = "0x3A9")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A6A")]
	[Address(RVA = "0xB451C0", Offset = "0xB43FC0", Length = "0x1D5")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003A6B")]
	[Address(RVA = "0xB453A0", Offset = "0xB441A0", Length = "0x19E")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x6003A6C")]
	[Address(RVA = "0xB45540", Offset = "0xB44340", Length = "0x96")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003A6D")]
	[Address(RVA = "0xB455E0", Offset = "0xB443E0", Length = "0x63")]
	public void OnAll()
	{
	}

	[Token(Token = "0x6003A6E")]
	[Address(RVA = "0xB45650", Offset = "0xB44450", Length = "0x3D9")]
	public void OnExecute()
	{
	}

	[Token(Token = "0x6003A6F")]
	[Address(RVA = "0xB45A30", Offset = "0xB44830", Length = "0x2D")]
	public void OnExecuteAll()
	{
	}

	[Token(Token = "0x6003A70")]
	[Address(RVA = "0xB45A60", Offset = "0xB44860", Length = "0x158")]
	public void OnIncrease()
	{
	}

	[Token(Token = "0x6003A71")]
	[Address(RVA = "0xB45BC0", Offset = "0xB449C0", Length = "0x1FA")]
	public void OnDecrease()
	{
	}

	[Token(Token = "0x6003A72")]
	[Address(RVA = "0xB45DC0", Offset = "0xB44BC0", Length = "0xEC")]
	private ItemLiquidVolume ReduceToNearestDeltaMultiple(ItemLiquidVolume numLiters)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6003A73")]
	[Address(RVA = "0xB45EB0", Offset = "0xB44CB0", Length = "0xE4")]
	public void SetWaterSupplyForDrop(WaterSupply ws)
	{
	}

	[Token(Token = "0x6003A74")]
	[Address(RVA = "0xB45FA0", Offset = "0xB44DA0", Length = "0x151")]
	public void SetWaterSourceForTaking(WaterSource source, WaterSupply ws)
	{
	}

	[Token(Token = "0x6003A75")]
	[Address(RVA = "0xB46100", Offset = "0xB44F00", Length = "0x151")]
	public void SetWaterSupplyForTransferFromInventoryToContainer(WaterSupply ws, Container c)
	{
	}

	[Token(Token = "0x6003A76")]
	[Address(RVA = "0xB46260", Offset = "0xB45060", Length = "0x151")]
	public void SetWaterSupplyForTransferFromContainerToInventory(WaterSupply ws, Container c)
	{
	}

	[Token(Token = "0x6003A77")]
	[Address(RVA = "0xB463C0", Offset = "0xB451C0", Length = "0x148")]
	public void SetWaterSupplyForGenericTransfer(WaterSupply ws, ItemLiquidVolume maxLiters, Action<ItemLiquidVolume> onGenericTransferWater)
	{
	}

	[Token(Token = "0x6003A78")]
	[Address(RVA = "0x6A2C40", Offset = "0x6A1A40", Length = "0x8")]
	public bool IsTakingWater()
	{
		return false;
	}

	[Token(Token = "0x6003A79")]
	[Address(RVA = "0xB46510", Offset = "0xB45310", Length = "0x9E6")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6003A7A")]
	[Address(RVA = "0xB46F00", Offset = "0xB45D00", Length = "0x15C")]
	private void InstantiateAndDropWaterBottle(GameObject prefab, ItemLiquidVolume volume, LiquidType type)
	{
	}

	[Token(Token = "0x6003A7B")]
	[Address(RVA = "0xB47060", Offset = "0xB45E60", Length = "0x1EB")]
	private GearItem InstantiateWaterSupply(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6003A7C")]
	[Address(RVA = "0xB47250", Offset = "0xB46050", Length = "0x2E")]
	public void DropAllWaterFromContainer(Container container, WaterSupply waterSupply)
	{
	}

	[Token(Token = "0x6003A7D")]
	[Address(RVA = "0xB47280", Offset = "0xB46080", Length = "0x455")]
	private void DropWater(WaterSupply waterSupply, ItemLiquidVolume liters, Container container = null)
	{
	}

	[Token(Token = "0x6003A7E")]
	[Address(RVA = "0xB476E0", Offset = "0xB464E0", Length = "0x298")]
	private void TakeWater()
	{
	}

	[Token(Token = "0x6003A7F")]
	[Address(RVA = "0xB47980", Offset = "0xB46780", Length = "0x25")]
	public void TransferAllWaterContainerToInventory(Container container, WaterSupply waterSupplyContainer)
	{
	}

	[Token(Token = "0x6003A80")]
	[Address(RVA = "0xB479B0", Offset = "0xB467B0", Length = "0x289")]
	public void TransferWaterContainerToInventory(Container container, WaterSupply waterSupplyContainer, ItemLiquidVolume liters)
	{
	}

	[Token(Token = "0x6003A81")]
	[Address(RVA = "0xB47C40", Offset = "0xB46A40", Length = "0x25")]
	public void TransferAllWaterInventoryToContainer(Container container, WaterSupply waterSupplyInventory)
	{
	}

	[Token(Token = "0x6003A82")]
	[Address(RVA = "0xB47C70", Offset = "0xB46A70", Length = "0x2A5")]
	public void TransferWaterInventoryToContainer(Container container, WaterSupply waterSupplyInventory, ItemLiquidVolume liters)
	{
	}

	[Token(Token = "0x6003A83")]
	[Address(RVA = "0xB47F20", Offset = "0xB46D20", Length = "0x422")]
	private void OnTakeWaterComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6003A84")]
	[Address(RVA = "0xB48350", Offset = "0xB47150", Length = "0xC3")]
	public Panel_PickWater()
	{
	}
}
