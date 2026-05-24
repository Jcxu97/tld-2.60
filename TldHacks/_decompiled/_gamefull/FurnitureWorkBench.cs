using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000581")]
public class FurnitureWorkBench : MonoBehaviour, CraftingLocationInterface
{
	[Token(Token = "0x40032BD")]
	[FieldOffset(Offset = "0x20")]
	public PanelReference<Panel_Crafting> m_CraftingPanel;

	[Token(Token = "0x40032BE")]
	[FieldOffset(Offset = "0x28")]
	private Container m_Container;

	[Token(Token = "0x6002A6D")]
	[Address(RVA = "0x9023D0", Offset = "0x9011D0", Length = "0x8C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002A6E")]
	[Address(RVA = "0x902460", Offset = "0x901260", Length = "0x6")]
	public CraftingLocation GetLocation()
	{
		return default(CraftingLocation);
	}

	[Token(Token = "0x6002A6F")]
	[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
	public int ModifyCraftingTime(int minutes)
	{
		return 0;
	}

	[Token(Token = "0x6002A70")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ReadyForBlueprint(BlueprintData bp)
	{
		return false;
	}

	[Token(Token = "0x6002A71")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ReadyToCraft()
	{
		return false;
	}

	[Token(Token = "0x6002A72")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[Token(Token = "0x6002A73")]
	[Address(RVA = "0x902470", Offset = "0x901270", Length = "0x6C")]
	public void InteractWithWorkbench()
	{
	}

	[Token(Token = "0x6002A74")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool HoldsCraftingResult()
	{
		return false;
	}

	[Token(Token = "0x6002A75")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public Container GetContainer()
	{
		return null;
	}

	[Token(Token = "0x6002A76")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FurnitureWorkBench()
	{
	}
}
