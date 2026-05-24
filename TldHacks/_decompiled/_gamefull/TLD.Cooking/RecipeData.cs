using System;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Cooking;

[CreateAssetMenu(menuName = "The Long Dark/Cooking/Recipe", fileName = "RECIPE_NewRecipe")]
[Token(Token = "0x20013F5")]
public class RecipeData : ScriptableObject
{
	[Token(Token = "0x20013F6")]
	public enum UnlockType
	{
		[Token(Token = "0x4009201")]
		Unlocked,
		[Token(Token = "0x4009202")]
		CodeUnlock
	}

	[Header("Visuals")]
	[SerializeField]
	[Token(Token = "0x40091F7")]
	[FieldOffset(Offset = "0x18")]
	private LocalizedString m_RecipeName;

	[SerializeField]
	[Token(Token = "0x40091F8")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_RecipeShortName;

	[SerializeField]
	[Token(Token = "0x40091F9")]
	[FieldOffset(Offset = "0x28")]
	private LocalizedString m_RecipeDescription;

	[SerializeField]
	[Token(Token = "0x40091FA")]
	[FieldOffset(Offset = "0x30")]
	private AssetReferenceTexture2D m_RecipeIcon;

	[Header("Config")]
	[SerializeField]
	[Token(Token = "0x40091FB")]
	[FieldOffset(Offset = "0x38")]
	private UnlockType m_UnlockRule;

	[SerializeField]
	[Range(1f, 5f)]
	[Token(Token = "0x40091FC")]
	[FieldOffset(Offset = "0x3C")]
	private int m_RequiredSkillLevel;

	[SerializeField]
	[Token(Token = "0x40091FD")]
	[FieldOffset(Offset = "0x40")]
	private GearItemData[] m_AllowedCookingPots;

	[SerializeField]
	[Token(Token = "0x40091FE")]
	[FieldOffset(Offset = "0x48")]
	private BlueprintData m_DishBlueprint;

	[NonSerialized]
	[Token(Token = "0x40091FF")]
	[FieldOffset(Offset = "0x50")]
	private GearItemData m_CookedGearItemData;

	[Token(Token = "0x17000ADB")]
	public LocalizedString Name
	{
		[Token(Token = "0x6007F42")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADC")]
	public LocalizedString ShortName
	{
		[Token(Token = "0x6007F43")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADD")]
	public LocalizedString Description
	{
		[Token(Token = "0x6007F44")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADE")]
	public AssetReferenceTexture2D IconReference
	{
		[Token(Token = "0x6007F45")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ADF")]
	public bool IsSpecial
	{
		[Token(Token = "0x6007F46")]
		[Address(RVA = "0x11F1580", Offset = "0x11F0380", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AE0")]
	public UnlockType UnlockRule
	{
		[Token(Token = "0x6007F47")]
		[Address(RVA = "0x502760", Offset = "0x501560", Length = "0x4")]
		get
		{
			return default(UnlockType);
		}
	}

	[Token(Token = "0x17000AE1")]
	public int RequiredSkillLevel
	{
		[Token(Token = "0x6007F48")]
		[Address(RVA = "0x63F4E0", Offset = "0x63E2E0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000AE2")]
	public BlueprintData DishBlueprint
	{
		[Token(Token = "0x6007F49")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007F4A")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool CanCauseAfflictions()
	{
		return false;
	}

	[Token(Token = "0x6007F4B")]
	[Address(RVA = "0x11F1590", Offset = "0x11F0390", Length = "0x102")]
	public bool HasCookingSkills()
	{
		return false;
	}

	[Token(Token = "0x6007F4C")]
	[Address(RVA = "0x11F16A0", Offset = "0x11F04A0", Length = "0x4B3")]
	public bool CanBeMadeWithPot(CookingPotItem cookingPot)
	{
		return false;
	}

	[Token(Token = "0x6007F4D")]
	[Address(RVA = "0x11F1B60", Offset = "0x11F0960", Length = "0x3B3")]
	public GearItemData GetCookedGearItemData()
	{
		return null;
	}

	[Token(Token = "0x6007F4E")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public RecipeData()
	{
	}
}
