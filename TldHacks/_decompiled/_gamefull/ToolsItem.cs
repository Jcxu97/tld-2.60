using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004E0")]
public class ToolsItem : MonoBehaviour
{
	[Token(Token = "0x20004E1")]
	public enum ToolType
	{
		[Token(Token = "0x4002C8D")]
		All,
		[Token(Token = "0x4002C8E")]
		CraftOnly,
		[Token(Token = "0x4002C8F")]
		RepairOnly
	}

	[Token(Token = "0x20004E2")]
	public enum CuttingToolType
	{
		[Token(Token = "0x4002C91")]
		None,
		[Token(Token = "0x4002C92")]
		HackSaw,
		[Token(Token = "0x4002C93")]
		Hatchet,
		[Token(Token = "0x4002C94")]
		Hammer,
		[Token(Token = "0x4002C95")]
		Knife
	}

	[Token(Token = "0x4002C85")]
	[FieldOffset(Offset = "0x20")]
	public float m_CraftingAndRepairSkillModifier;

	[Token(Token = "0x4002C86")]
	[FieldOffset(Offset = "0x24")]
	public float m_CraftingAndRepairTimeModifier;

	[Token(Token = "0x4002C87")]
	[FieldOffset(Offset = "0x28")]
	public bool m_CanOnlyCraftAndRepairClothes;

	[Token(Token = "0x4002C88")]
	[FieldOffset(Offset = "0x2C")]
	public ToolType m_ToolType;

	[Token(Token = "0x4002C89")]
	[FieldOffset(Offset = "0x30")]
	public CuttingToolType m_CuttingToolType;

	[Token(Token = "0x4002C8A")]
	[FieldOffset(Offset = "0x34")]
	public float m_DegradePerHourCrafting;

	[Token(Token = "0x4002C8B")]
	[FieldOffset(Offset = "0x38")]
	public bool m_AppearInStoryOnly;

	[Token(Token = "0x6002512")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ToolsItem()
	{
	}
}
