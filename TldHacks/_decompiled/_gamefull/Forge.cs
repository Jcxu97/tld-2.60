using Cpp2ILInjected;
using TLD.Gear;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000580")]
public class Forge : MonoBehaviour, CraftingLocationInterface
{
	[Token(Token = "0x40032BA")]
	[FieldOffset(Offset = "0x20")]
	public float m_MinTemperatureForCrafting;

	[Token(Token = "0x40032BB")]
	[FieldOffset(Offset = "0x28")]
	public Fire m_Fire;

	[Token(Token = "0x40032BC")]
	[FieldOffset(Offset = "0x30")]
	public PanelReference<Panel_Crafting> m_CraftingPanel;

	[Token(Token = "0x6002A61")]
	[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
	public CraftingLocation GetLocation()
	{
		return default(CraftingLocation);
	}

	[Token(Token = "0x6002A62")]
	[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
	public int ModifyCraftingTime(int minutes)
	{
		return 0;
	}

	[Token(Token = "0x6002A63")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ReadyForBlueprint(BlueprintData bp)
	{
		return false;
	}

	[Token(Token = "0x6002A64")]
	[Address(RVA = "0x901E70", Offset = "0x900C70", Length = "0x7")]
	public bool ReadyToCraft()
	{
		return false;
	}

	[Token(Token = "0x6002A65")]
	[Address(RVA = "0x901E80", Offset = "0x900C80", Length = "0x7")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[Token(Token = "0x6002A66")]
	[Address(RVA = "0x901E90", Offset = "0x900C90", Length = "0x27E")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6002A67")]
	[Address(RVA = "0x902110", Offset = "0x900F10", Length = "0x8A")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002A68")]
	[Address(RVA = "0x9021A0", Offset = "0x900FA0", Length = "0xFD")]
	private bool ForgeHotEnoughForUse()
	{
		return false;
	}

	[Token(Token = "0x6002A69")]
	[Address(RVA = "0x9022A0", Offset = "0x9010A0", Length = "0x12A")]
	private void DisplayNotHotEnoughMessage()
	{
	}

	[Token(Token = "0x6002A6A")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool HoldsCraftingResult()
	{
		return false;
	}

	[Token(Token = "0x6002A6B")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public Container GetContainer()
	{
		return null;
	}

	[Token(Token = "0x6002A6C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Forge()
	{
	}
}
