using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Cooking;

[Token(Token = "0x20013F4")]
public class RecipeBook : MonoBehaviour
{
	[Token(Token = "0x40091F1")]
	private const string ERROR_MULTIPLE_INSTANCES = "Multiple RecipeBook instances detected!";

	[SerializeField]
	[Token(Token = "0x40091F2")]
	[FieldOffset(Offset = "0x20")]
	private AssetLabelReference m_RecipeLabel;

	[Token(Token = "0x40091F3")]
	[FieldOffset(Offset = "0x28")]
	private readonly RecipeBookGameState m_GameState;

	[Token(Token = "0x40091F4")]
	[FieldOffset(Offset = "0x30")]
	private AsyncOperationHandle<IList<RecipeData>> m_RecipeLoadOperation;

	[Token(Token = "0x17000AD9")]
	[field: Token(Token = "0x40091F5")]
	public static RecipeBook Instance
	{
		[Token(Token = "0x6007F2C")]
		[Address(RVA = "0x11EFF40", Offset = "0x11EED40", Length = "0x3B")]
		get;
		[Token(Token = "0x6007F2D")]
		[Address(RVA = "0x11EFF80", Offset = "0x11EED80", Length = "0x97")]
		private set;
	}

	[Token(Token = "0x17000ADA")]
	[field: Token(Token = "0x40091F6")]
	[field: FieldOffset(Offset = "0x48")]
	public List<RecipeData> AllRecipes
	{
		[Token(Token = "0x6007F2E")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x6007F2F")]
		[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6007F30")]
	[Address(RVA = "0x11F0020", Offset = "0x11EEE20", Length = "0x116")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007F31")]
	[Address(RVA = "0x11F0140", Offset = "0x11EEF40", Length = "0x147")]
	private void Start()
	{
	}

	[Token(Token = "0x6007F32")]
	[Address(RVA = "0x11F0290", Offset = "0x11EF090", Length = "0xB6")]
	private void OnRecipesLoaded(AsyncOperationHandle<IList<RecipeData>> obj)
	{
	}

	[Token(Token = "0x6007F33")]
	[Address(RVA = "0x11F0350", Offset = "0x11EF150", Length = "0x1D1")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007F34")]
	[Address(RVA = "0x11F0530", Offset = "0x11EF330", Length = "0xD8")]
	public bool UnlockRecipe(RecipeData recipe)
	{
		return false;
	}

	[Token(Token = "0x6007F35")]
	[Address(RVA = "0x11F0610", Offset = "0x11EF410", Length = "0x7F")]
	public bool IsRecipeUnlocked(RecipeData recipe)
	{
		return false;
	}

	[Token(Token = "0x6007F36")]
	[Address(RVA = "0x11F0690", Offset = "0x11EF490", Length = "0x1A")]
	public bool IsRecipeSpecial(RecipeData recipe)
	{
		return false;
	}

	[Token(Token = "0x6007F37")]
	[Address(RVA = "0x11F06B0", Offset = "0x11EF4B0", Length = "0x92")]
	public bool IsRecipeSpecialAndUnlocked(RecipeData recipe)
	{
		return false;
	}

	[Token(Token = "0x6007F38")]
	[Address(RVA = "0x11F0750", Offset = "0x11EF550", Length = "0x26A")]
	public void GetFilteredRecipes(Predicate<RecipeData> filter, List<RecipeData> result)
	{
	}

	[Token(Token = "0x6007F39")]
	[Address(RVA = "0x11F09C0", Offset = "0x11EF7C0", Length = "0x94")]
	public bool HasAnyRecipes()
	{
		return false;
	}

	[Token(Token = "0x6007F3A")]
	[Address(RVA = "0x11F0A60", Offset = "0x11EF860", Length = "0x8B")]
	public void GetAllUnlockedRecipes(List<RecipeData> result)
	{
	}

	[Token(Token = "0x6007F3B")]
	[Address(RVA = "0x11F0AF0", Offset = "0x11EF8F0", Length = "0x8B")]
	public void GetAllSpecialRecipes(List<RecipeData> result)
	{
	}

	[Token(Token = "0x6007F3C")]
	[Address(RVA = "0x11F0B80", Offset = "0x11EF980", Length = "0x8B")]
	public void GetAllSpecialAndUnlockedRecipes(List<RecipeData> result)
	{
	}

	[Token(Token = "0x6007F3D")]
	[Address(RVA = "0x11F0C10", Offset = "0x11EFA10", Length = "0x42D")]
	public RecipeData FindUnlockedRecipeFromCookedItem(GearItem cookedItem)
	{
		return null;
	}

	[Token(Token = "0x6007F3E")]
	[Address(RVA = "0x11F1040", Offset = "0x11EFE40", Length = "0x14F")]
	public void MarkRecipeAsCooked(RecipeData recipe)
	{
	}

	[Token(Token = "0x6007F3F")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public RecipeBookGameState Serialize()
	{
		return null;
	}

	[Token(Token = "0x6007F40")]
	[Address(RVA = "0x11F1190", Offset = "0x11EFF90", Length = "0x13B")]
	public void Deserialize(RecipeBookGameState savedState)
	{
	}

	[Token(Token = "0x6007F41")]
	[Address(RVA = "0x11F12D0", Offset = "0x11F00D0", Length = "0x2A4")]
	public RecipeBook()
	{
	}
}
