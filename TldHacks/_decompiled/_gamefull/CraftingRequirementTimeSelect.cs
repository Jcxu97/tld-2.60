using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200022A")]
public class CraftingRequirementTimeSelect : MonoBehaviour
{
	[Token(Token = "0x400134E")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> m_ControllerButtons;

	[Token(Token = "0x400134F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_TimeText;

	[Tooltip("How many minutes to increase, or decrease, the current crafting time by. Time is in minutes.")]
	[Token(Token = "0x4001350")]
	[FieldOffset(Offset = "0x30")]
	public int m_Timestep;

	[Tooltip("Minimum crafting duration required to display the time selection option. Time is in minutes")]
	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0x34")]
	public int m_MinimumTimeForDisplay;

	[Tooltip("Used to offset this component when all the requirements are visible.")]
	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0x38")]
	public float m_OffsetY;

	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0x3C")]
	private int m_DisplayedCraftingTime;

	[Token(Token = "0x4001354")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsSelected;

	[Token(Token = "0x4001355")]
	[FieldOffset(Offset = "0x44")]
	private int m_TotalCraftingTime;

	[Token(Token = "0x4001356")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 m_InitialPosition;

	[Token(Token = "0x600134C")]
	[Address(RVA = "0x667C50", Offset = "0x666A50", Length = "0xD1")]
	private void Awake()
	{
	}

	[Token(Token = "0x600134D")]
	[Address(RVA = "0x667D30", Offset = "0x666B30", Length = "0x97")]
	public void Disable()
	{
	}

	[Token(Token = "0x600134E")]
	[Address(RVA = "0x667DD0", Offset = "0x666BD0", Length = "0x1D8")]
	public void Enable(int craftingTime, bool offset)
	{
	}

	[Token(Token = "0x600134F")]
	[Address(RVA = "0x63F4E0", Offset = "0x63E2E0", Length = "0x4")]
	public int GetCraftingTime()
	{
		return 0;
	}

	[Token(Token = "0x6001350")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001351")]
	[Address(RVA = "0x667FB0", Offset = "0x666DB0", Length = "0x5")]
	public bool IsSelected()
	{
		return false;
	}

	[Token(Token = "0x6001352")]
	[Address(RVA = "0x667FC0", Offset = "0x666DC0", Length = "0xC5")]
	public void OnDecrease()
	{
	}

	[Token(Token = "0x6001353")]
	[Address(RVA = "0x668090", Offset = "0x666E90", Length = "0xCC")]
	public void OnIncrease()
	{
	}

	[Token(Token = "0x6001354")]
	[Address(RVA = "0x668160", Offset = "0x666F60", Length = "0x1D6")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6001355")]
	[Address(RVA = "0x668340", Offset = "0x667140", Length = "0x1B7")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6001356")]
	[Address(RVA = "0x668500", Offset = "0x667300", Length = "0xE3")]
	public CraftingRequirementTimeSelect()
	{
	}
}
