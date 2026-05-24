using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x200021B")]
public class CraftingProgress : MonoBehaviour
{
	[Token(Token = "0x4001300")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_ProgressValueLabel;

	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x65EA60", Offset = "0x65D860", Length = "0x220")]
	public void SetCraftingProgress(ICraftingResult craftedItem)
	{
	}

	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x65EC90", Offset = "0x65DA90", Length = "0x24C")]
	private void SetCraftingProgress(InProgressCraftItem craftInProgressItem)
	{
	}

	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CraftingProgress()
	{
	}
}
