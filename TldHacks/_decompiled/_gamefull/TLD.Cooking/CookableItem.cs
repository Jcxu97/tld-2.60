using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Cooking;

[Token(Token = "0x20013F0")]
public readonly struct CookableItem
{
	[Flags]
	[Token(Token = "0x20013F1")]
	public enum Cookablility
	{
		[Token(Token = "0x40091DF")]
		Cookable = 0,
		[Token(Token = "0x40091E0")]
		SkillTooLow = 1,
		[Token(Token = "0x40091E1")]
		WrongPot = 2,
		[Token(Token = "0x40091E2")]
		MissingIngredients = 4,
		[Token(Token = "0x40091E3")]
		InternalError = 0x10000
	}

	[Token(Token = "0x40091DC")]
	[FieldOffset(Offset = "0x0")]
	public readonly GearItem m_GearItem;

	[Token(Token = "0x40091DD")]
	[FieldOffset(Offset = "0x8")]
	public readonly RecipeData m_Recipe;

	[Token(Token = "0x6007F16")]
	[Address(RVA = "0xF34360", Offset = "0xF33160", Length = "0xAA")]
	public CookableItem(GearItem cookable)
	{
		m_GearItem = null;
		m_Recipe = null;
	}

	[Token(Token = "0x6007F17")]
	[Address(RVA = "0x11EDC50", Offset = "0x11ECA50", Length = "0x289")]
	public CookableItem(RecipeData recipe)
	{
		m_GearItem = null;
		m_Recipe = null;
	}

	[Token(Token = "0x6007F18")]
	[Address(RVA = "0x11EDEE0", Offset = "0x11ECCE0", Length = "0x39")]
	internal static int CompareCookableByName(CookableItem x, CookableItem y)
	{
		return 0;
	}

	[Token(Token = "0x6007F19")]
	[Address(RVA = "0x11EDF20", Offset = "0x11ECD20", Length = "0x9B")]
	internal static int CompareByCookTime(CookableItem x, CookableItem y)
	{
		return 0;
	}

	[Token(Token = "0x6007F1A")]
	[Address(RVA = "0x11EDFC0", Offset = "0x11ECDC0", Length = "0x9B")]
	internal static int CompareByCaloricContent(CookableItem x, CookableItem y)
	{
		return 0;
	}

	[Token(Token = "0x6007F1B")]
	[Address(RVA = "0x11EE060", Offset = "0x11ECE60", Length = "0x1F5")]
	public string GetDisplayName()
	{
		return null;
	}

	[Token(Token = "0x6007F1C")]
	[Address(RVA = "0x11EE260", Offset = "0x11ED060", Length = "0x29F")]
	public float GetCookTimeInMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x6007F1D")]
	[Address(RVA = "0x11EE500", Offset = "0x11ED300", Length = "0x13B")]
	public float GetCookTimeInMinutes(CookingPotItem pot)
	{
		return 0f;
	}

	[Token(Token = "0x6007F1E")]
	[Address(RVA = "0x11EE640", Offset = "0x11ED440", Length = "0xD8")]
	public float GetCaloricContent()
	{
		return 0f;
	}

	[Token(Token = "0x6007F1F")]
	[Address(RVA = "0x11EE720", Offset = "0x11ED520", Length = "0x100")]
	public string GetVitaminCContentString(float fractionOfBaseMass)
	{
		return null;
	}

	[Token(Token = "0x6007F20")]
	[Address(RVA = "0x11EE820", Offset = "0x11ED620", Length = "0x1E9")]
	public Texture2D GetInventoryIcon()
	{
		return null;
	}

	[Token(Token = "0x6007F21")]
	[Address(RVA = "0x11EEA10", Offset = "0x11ED810", Length = "0x10D")]
	public bool CanCookItem(CookingPotItem cookingPot, Inventory inventory)
	{
		return false;
	}

	[Token(Token = "0x6007F22")]
	[Address(RVA = "0x11EEB20", Offset = "0x11ED920", Length = "0x108")]
	public Cookablility GetCookability(CookingPotItem cookingPot, Inventory inventory)
	{
		return default(Cookablility);
	}

	[Token(Token = "0x6007F23")]
	[Address(RVA = "0x11EEC30", Offset = "0x11EDA30", Length = "0x101")]
	public Cookablility GetPotCookability(CookingPotItem cookingPot)
	{
		return default(Cookablility);
	}

	[Token(Token = "0x6007F24")]
	[Address(RVA = "0x11EED40", Offset = "0x11EDB40", Length = "0x25F")]
	private Cookablility GetCookableItemCookability(CookingPotItem cookingPot, Inventory inventory)
	{
		return default(Cookablility);
	}

	[Token(Token = "0x6007F25")]
	[Address(RVA = "0x11EEFA0", Offset = "0x11EDDA0", Length = "0x42A")]
	private Cookablility GetCookableItemPotCookability(CookingPotItem cookingPot)
	{
		return default(Cookablility);
	}

	[Token(Token = "0x6007F26")]
	[Address(RVA = "0x11EF3D0", Offset = "0x11EE1D0", Length = "0x1AE")]
	private static bool HasRequiredWater(Inventory inventory, Cookable cookable)
	{
		return false;
	}

	[Token(Token = "0x6007F27")]
	[Address(RVA = "0x11EF580", Offset = "0x11EE380", Length = "0x541")]
	private Cookablility GetRecipeCookability(CookingPotItem cookingPot, Inventory inventory)
	{
		return default(Cookablility);
	}

	[Token(Token = "0x6007F28")]
	[Address(RVA = "0x11EFAD0", Offset = "0x11EE8D0", Length = "0x120")]
	private Cookablility GetRecipePotCookability(CookingPotItem cookingPot)
	{
		return default(Cookablility);
	}

	[Token(Token = "0x6007F29")]
	[Address(RVA = "0x11EFC00", Offset = "0x11EEA00", Length = "0x1FF")]
	private FoodItem GetFinalFoodItem()
	{
		return null;
	}
}
