using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x200022B")]
public class CraftingRequirementTool : MonoBehaviour
{
	[Token(Token = "0x4001357")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_DisplayName;

	[Token(Token = "0x4001358")]
	[FieldOffset(Offset = "0x28")]
	public UITexture m_Icon;

	[Token(Token = "0x4001359")]
	[FieldOffset(Offset = "0x30")]
	private Color m_DisplayNameTint;

	[Token(Token = "0x400135A")]
	[FieldOffset(Offset = "0x40")]
	private Color m_IconTint;

	[Token(Token = "0x400135B")]
	[FieldOffset(Offset = "0x50")]
	private GearItem m_SelectedTool;

	[Token(Token = "0x6001357")]
	[Address(RVA = "0x663440", Offset = "0x662240", Length = "0x36")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001358")]
	[Address(RVA = "0x6685F0", Offset = "0x6673F0", Length = "0xEC")]
	public void Disable()
	{
	}

	[Token(Token = "0x6001359")]
	[Address(RVA = "0x6686E0", Offset = "0x6674E0", Length = "0xF5E")]
	public void Enable(Panel_Crafting panel, BlueprintData bp)
	{
	}

	[Token(Token = "0x600135A")]
	[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[Token(Token = "0x600135B")]
	[Address(RVA = "0x669650", Offset = "0x668450", Length = "0x1FE")]
	public GearItem GetSelectedToolPrefab()
	{
		return null;
	}

	[Token(Token = "0x600135C")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x600135D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CraftingRequirementTool()
	{
	}
}
