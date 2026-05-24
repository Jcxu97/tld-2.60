using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200053E")]
public class AmmoWorkBench : MonoBehaviour, CraftingLocationInterface
{
	[Token(Token = "0x400303F")]
	[FieldOffset(Offset = "0x20")]
	public Fire m_Fire;

	[Token(Token = "0x4003040")]
	[FieldOffset(Offset = "0x28")]
	public PanelReference<Panel_Crafting> m_CraftingPanel;

	[Token(Token = "0x600281B")]
	[Address(RVA = "0x457130", Offset = "0x455F30", Length = "0x6")]
	public CraftingLocation GetLocation()
	{
		return default(CraftingLocation);
	}

	[Token(Token = "0x600281C")]
	[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
	public int ModifyCraftingTime(int minutes)
	{
		return 0;
	}

	[Token(Token = "0x600281D")]
	[Address(RVA = "0x8BE820", Offset = "0x8BD620", Length = "0x129")]
	public bool ReadyForBlueprint(BlueprintData bp)
	{
		return false;
	}

	[Token(Token = "0x600281E")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ReadyToCraft()
	{
		return false;
	}

	[Token(Token = "0x600281F")]
	[Address(RVA = "0x8BE950", Offset = "0x8BD750", Length = "0xAA")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[Token(Token = "0x6002820")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool HoldsCraftingResult()
	{
		return false;
	}

	[Token(Token = "0x6002821")]
	[Address(RVA = "0x8BEA00", Offset = "0x8BD800", Length = "0x6C")]
	public void InteractWithWorkbench()
	{
	}

	[Token(Token = "0x6002822")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public Container GetContainer()
	{
		return null;
	}

	[Token(Token = "0x6002823")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AmmoWorkBench()
	{
	}
}
