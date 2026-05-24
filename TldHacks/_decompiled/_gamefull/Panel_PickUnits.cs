using System;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006B1")]
public class Panel_PickUnits : Panel_AutoReferenced
{
	[Token(Token = "0x400470C")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400470D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_Label_Description;

	[Token(Token = "0x400470E")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_Label_NumUnits;

	[Token(Token = "0x400470F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_Execute_Button;

	[Token(Token = "0x4004710")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_ExecuteAll_Button;

	[Token(Token = "0x4004711")]
	[FieldOffset(Offset = "0x58")]
	public UITexture m_GearIcon;

	[Token(Token = "0x4004712")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_ButtonIncrease;

	[Token(Token = "0x4004713")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_ButtonDecrease;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004714")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_Container> m_ContainerPanel;

	[SerializeField]
	[Token(Token = "0x4004715")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_Crafting> m_CraftingPanel;

	[SerializeField]
	[Token(Token = "0x4004716")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_Harvest> m_Harvest;

	[SerializeField]
	[Token(Token = "0x4004717")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x4004718")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	[SerializeField]
	[Token(Token = "0x4004719")]
	[FieldOffset(Offset = "0x98")]
	private PanelReference<Panel_Repair> m_Repair;

	[HideInInspector]
	[Token(Token = "0x400471A")]
	[FieldOffset(Offset = "0xA0")]
	public int m_numUnits;

	[HideInInspector]
	[Token(Token = "0x400471B")]
	[FieldOffset(Offset = "0xA4")]
	public int m_maxUnits;

	[HideInInspector]
	[Token(Token = "0x400471C")]
	[FieldOffset(Offset = "0xA8")]
	public EnablePanelOnExit m_EnablePanelOnExit;

	[HideInInspector]
	[Token(Token = "0x400471D")]
	[FieldOffset(Offset = "0xAC")]
	public bool m_CameFromDrag;

	[Token(Token = "0x400471E")]
	[FieldOffset(Offset = "0xB0")]
	private GearItem m_GearItem;

	[Token(Token = "0x400471F")]
	[FieldOffset(Offset = "0xB8")]
	private Container m_Container;

	[Token(Token = "0x4004720")]
	[FieldOffset(Offset = "0xC0")]
	private PickUnitsExecuteAction m_ExecuteAction;

	[Token(Token = "0x4004721")]
	[FieldOffset(Offset = "0xC8")]
	private Action<int> m_OnGenericTransferUnits;

	[Token(Token = "0x6003A51")]
	[Address(RVA = "0xB42190", Offset = "0xB40F90", Length = "0x89")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003A52")]
	[Address(RVA = "0xB42220", Offset = "0xB41020", Length = "0x317")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A53")]
	[Address(RVA = "0xB42540", Offset = "0xB41340", Length = "0x194")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003A54")]
	[Address(RVA = "0xB426E0", Offset = "0xB414E0", Length = "0x53C")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x6003A55")]
	[Address(RVA = "0xB42C40", Offset = "0xB41A40", Length = "0x5F")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003A56")]
	[Address(RVA = "0xB42CA0", Offset = "0xB41AA0", Length = "0x61")]
	public void OnAll()
	{
	}

	[Token(Token = "0x6003A57")]
	[Address(RVA = "0xB42D10", Offset = "0xB41B10", Length = "0x27D")]
	public void OnExecute()
	{
	}

	[Token(Token = "0x6003A58")]
	[Address(RVA = "0xB42F90", Offset = "0xB41D90", Length = "0x2B")]
	public void OnExecuteAll()
	{
	}

	[Token(Token = "0x6003A59")]
	[Address(RVA = "0xB42FC0", Offset = "0xB41DC0", Length = "0x8C")]
	public void OnIncrease()
	{
	}

	[Token(Token = "0x6003A5A")]
	[Address(RVA = "0xB43050", Offset = "0xB41E50", Length = "0x89")]
	public void OnDecrease()
	{
	}

	[Token(Token = "0x6003A5B")]
	[Address(RVA = "0xB430E0", Offset = "0xB41EE0", Length = "0x96")]
	public void SetGearForDrop(GearItem gi)
	{
	}

	[Token(Token = "0x6003A5C")]
	[Address(RVA = "0xB43180", Offset = "0xB41F80", Length = "0x96")]
	public void SetGearForHarvest(GearItem gi)
	{
	}

	[Token(Token = "0x6003A5D")]
	[Address(RVA = "0xB43220", Offset = "0xB42020", Length = "0x103")]
	public void SetGearForTransferToContainer(GearItem gi, Container c)
	{
	}

	[Token(Token = "0x6003A5E")]
	[Address(RVA = "0xB43330", Offset = "0xB42130", Length = "0x103")]
	public void SetGearForTransferToInventory(GearItem gi, Container c)
	{
	}

	[Token(Token = "0x6003A5F")]
	[Address(RVA = "0xB43440", Offset = "0xB42240", Length = "0xE6")]
	public void SetGearItemForGenericTransfer(GearItem gi, int maxUnits, Action<int> onGenericTransferUnits)
	{
	}

	[Token(Token = "0x6003A60")]
	[Address(RVA = "0xB43530", Offset = "0xB42330", Length = "0x80B")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6003A61")]
	[Address(RVA = "0xB43D40", Offset = "0xB42B40", Length = "0x106")]
	public void DropAllGear(GearItem gearItem)
	{
	}

	[Token(Token = "0x6003A62")]
	[Address(RVA = "0xB43E50", Offset = "0xB42C50", Length = "0x2D1")]
	private void DropGear(GearItem gearItem, int units)
	{
	}

	[Token(Token = "0x6003A63")]
	[Address(RVA = "0xB44130", Offset = "0xB42F30", Length = "0x98")]
	private void HarvestGear()
	{
	}

	[Token(Token = "0x6003A64")]
	[Address(RVA = "0xB441D0", Offset = "0xB42FD0", Length = "0x58F")]
	public void TransferGearInventoryToContainer()
	{
	}

	[Token(Token = "0x6003A65")]
	[Address(RVA = "0xB44760", Offset = "0xB43560", Length = "0x5D5")]
	public void TransferGearContainerToInventory()
	{
	}

	[Token(Token = "0x6003A66")]
	[Address(RVA = "0xB44D40", Offset = "0xB43B40", Length = "0xC3")]
	public Panel_PickUnits()
	{
	}
}
