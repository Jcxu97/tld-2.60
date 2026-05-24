using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Gear/Blueprint")]
[Token(Token = "0x20013FD")]
public class BlueprintData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20013FE")]
	public class RequiredGearItem
	{
		[Token(Token = "0x20013FF")]
		public enum Units
		{
			[Token(Token = "0x400924B")]
			Count,
			[Token(Token = "0x400924C")]
			Kilograms
		}

		[Token(Token = "0x4009246")]
		[FieldOffset(Offset = "0x10")]
		public GearItem m_Item;

		[Token(Token = "0x4009247")]
		[FieldOffset(Offset = "0x18")]
		public int m_Count;

		[Token(Token = "0x4009248")]
		[FieldOffset(Offset = "0x20")]
		public ItemWeight m_Weight;

		[Token(Token = "0x4009249")]
		[FieldOffset(Offset = "0x28")]
		public Units m_Units;

		[Token(Token = "0x6007F90")]
		[Address(RVA = "0x1195710", Offset = "0x1194510", Length = "0x8")]
		public RequiredGearItem()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001400")]
	public class RequiredPowder
	{
		[Token(Token = "0x400924D")]
		[FieldOffset(Offset = "0x10")]
		public PowderType m_Powder;

		[Token(Token = "0x400924E")]
		[FieldOffset(Offset = "0x18")]
		public ItemWeight m_Quantity;

		[Token(Token = "0x6007F91")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RequiredPowder()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001401")]
	public class RequiredLiquid
	{
		[Token(Token = "0x400924F")]
		[FieldOffset(Offset = "0x10")]
		public LiquidType m_Liquid;

		[Token(Token = "0x4009250")]
		[FieldOffset(Offset = "0x18")]
		public ItemLiquidVolume m_Volume;

		[Token(Token = "0x6007F92")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RequiredLiquid()
		{
		}
	}

	[Token(Token = "0x2001402")]
	public static class PropertyNames
	{
		[Token(Token = "0x4009251")]
		public const string CraftingResultType = "m_CraftingResultType";

		[Token(Token = "0x4009252")]
		public const string CraftedResultGear = "m_CraftedResultGear";

		[Token(Token = "0x4009253")]
		public const string CraftedResultDecoration = "m_CraftedResultDecoration";
	}

	[Token(Token = "0x400922C")]
	[FieldOffset(Offset = "0x18")]
	public List<ExperienceModeType> m_XPModesToDisable;

	[HideInInspector]
	[Token(Token = "0x400922D")]
	[FieldOffset(Offset = "0x20")]
	public RequiredGearItem[] m_RequiredGear;

	[HideInInspector]
	[Token(Token = "0x400922E")]
	[FieldOffset(Offset = "0x28")]
	public ToolsItem m_RequiredTool;

	[HideInInspector]
	[Token(Token = "0x400922F")]
	[FieldOffset(Offset = "0x30")]
	public ToolsItem[] m_OptionalTools;

	[HideInInspector]
	[Token(Token = "0x4009230")]
	[FieldOffset(Offset = "0x38")]
	public RequiredPowder[] m_RequiredPowder;

	[HideInInspector]
	[Token(Token = "0x4009231")]
	[FieldOffset(Offset = "0x40")]
	public RequiredLiquid[] m_RequiredLiquid;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4009232")]
	[FieldOffset(Offset = "0x48")]
	private CraftingResult m_CraftingResultType;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4009233")]
	[FieldOffset(Offset = "0x50")]
	private DecorationItem m_CraftedResultDecoration;

	[HideInInspector]
	[SerializeField]
	[FormerlySerializedAs("m_CraftedResult")]
	[Token(Token = "0x4009234")]
	[FieldOffset(Offset = "0x58")]
	private GearItem m_CraftedResultGear;

	[Token(Token = "0x4009235")]
	[FieldOffset(Offset = "0x60")]
	public AssetReferenceTexture2D m_CraftingIcon;

	[Token(Token = "0x4009236")]
	[FieldOffset(Offset = "0x68")]
	public int m_CraftedResultCount;

	[Token(Token = "0x4009237")]
	[FieldOffset(Offset = "0x6C")]
	public int m_DurationMinutes;

	[Token(Token = "0x4009238")]
	[FieldOffset(Offset = "0x70")]
	public AK.Wwise.Event m_CraftingAudio;

	[Token(Token = "0x4009239")]
	[FieldOffset(Offset = "0x78")]
	public bool m_RequiresLight;

	[Token(Token = "0x400923A")]
	[FieldOffset(Offset = "0x79")]
	public bool m_Locked;

	[Token(Token = "0x400923B")]
	[FieldOffset(Offset = "0x7A")]
	public bool m_IgnoreLockInSurvival;

	[Token(Token = "0x400923C")]
	[FieldOffset(Offset = "0x7B")]
	public bool m_AppearsInStoryOnly;

	[Token(Token = "0x400923D")]
	[FieldOffset(Offset = "0x7C")]
	public bool m_AppearsInSurvivalOnly;

	[Tooltip("This skill is applied to the quality of the crafted blueprint.")]
	[Token(Token = "0x400923E")]
	[FieldOffset(Offset = "0x80")]
	public SkillType m_AppliedSkill;

	[Tooltip("This skill is increased by crafting this blueprint.")]
	[Token(Token = "0x400923F")]
	[FieldOffset(Offset = "0x84")]
	public SkillType m_ImprovedSkill;

	[Token(Token = "0x4009240")]
	[FieldOffset(Offset = "0x88")]
	public CraftingLocation m_RequiredCraftingLocation;

	[Token(Token = "0x4009241")]
	[FieldOffset(Offset = "0x8C")]
	public bool m_RequiresLitFire;

	[Token(Token = "0x4009242")]
	[FieldOffset(Offset = "0x8D")]
	public bool m_CanIncreaseRepairSkill;

	[Token(Token = "0x4009243")]
	[FieldOffset(Offset = "0x8E")]
	public bool m_UsesPhoto;

	[NonSerialized]
	[Token(Token = "0x4009245")]
	[FieldOffset(Offset = "0x90")]
	private List<ToolsItem> m_FilteredOptionalTools;

	[Token(Token = "0x17000AE4")]
	[field: Token(Token = "0x4009244")]
	[field: FieldOffset(Offset = "0x8F")]
	public bool Locked
	{
		[Token(Token = "0x6007F74")]
		[Address(RVA = "0x11F6720", Offset = "0x11F5520", Length = "0x8")]
		get;
		[Token(Token = "0x6007F75")]
		[Address(RVA = "0x11F6730", Offset = "0x11F5530", Length = "0x7")]
		set;
	}

	[Token(Token = "0x6007F76")]
	[Address(RVA = "0x11F6740", Offset = "0x11F5540", Length = "0xB")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007F77")]
	[Address(RVA = "0x11F6740", Offset = "0x11F5540", Length = "0xB")]
	public void ResetLockedState()
	{
	}

	[Token(Token = "0x6007F78")]
	[Address(RVA = "0x11F6750", Offset = "0x11F5550", Length = "0xD2")]
	public bool ShouldDisableForCurrentMode()
	{
		return false;
	}

	[Token(Token = "0x6007F79")]
	[Address(RVA = "0x11F6830", Offset = "0x11F5630", Length = "0xFF")]
	public string GetDisplayedNameWithCount()
	{
		return null;
	}

	[Token(Token = "0x6007F7A")]
	[Address(RVA = "0x11F6930", Offset = "0x11F5730", Length = "0x19")]
	public ICraftingResult GetCraftedResult()
	{
		return null;
	}

	[Token(Token = "0x6007F7B")]
	[Address(RVA = "0x11F6950", Offset = "0x11F5750", Length = "0x52")]
	public void SetCraftedResult(GearItem gearItem)
	{
	}

	[Token(Token = "0x6007F7C")]
	[Address(RVA = "0x11F69B0", Offset = "0x11F57B0", Length = "0x1A8")]
	public bool CanCraftBlueprint(Inventory inventory, PlayerManager playerManager, CraftingLocationInterface cli)
	{
		return false;
	}

	[Token(Token = "0x6007F7D")]
	[Address(RVA = "0x11F6B60", Offset = "0x11F5960", Length = "0x13")]
	public bool CanCraftAtLocation(CraftingLocation craftingLocation)
	{
		return false;
	}

	[Token(Token = "0x6007F7E")]
	[Address(RVA = "0x11F6B80", Offset = "0x11F5980", Length = "0x56F")]
	public bool GetToolsAvailableToCraft(Inventory inventory, List<GearItem> result)
	{
		return false;
	}

	[Token(Token = "0x6007F7F")]
	[Address(RVA = "0x11F70F0", Offset = "0x11F5EF0", Length = "0x659")]
	public bool HasRequiredMaterials(Inventory inventory, Container container, PlayerManager playerManager)
	{
		return false;
	}

	[Token(Token = "0x6007F80")]
	[Address(RVA = "0x11F7750", Offset = "0x11F6550", Length = "0x1BA")]
	public ItemWeight AmountNeedsConsuming(int requiredGearIndex, InProgressCraftItem wip)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6007F81")]
	[Address(RVA = "0x11F7910", Offset = "0x11F6710", Length = "0x173")]
	public int NumNeedsConsuming(int requiredGearIndex, InProgressCraftItem wip)
	{
		return 0;
	}

	[Token(Token = "0x6007F82")]
	[Address(RVA = "0x11F7A90", Offset = "0x11F6890", Length = "0x19B")]
	public int NumToConsumeNow(int requiredGearIndex, InProgressCraftItem wip, float newTotalPercent)
	{
		return 0;
	}

	[Token(Token = "0x6007F83")]
	[Address(RVA = "0x11F7C30", Offset = "0x11F6A30", Length = "0x1E9")]
	public ItemWeight AmountToConsumeNow(int requiredGearIndex, InProgressCraftItem wip, float newTotalPercent)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6007F84")]
	[Address(RVA = "0x11F7E20", Offset = "0x11F6C20", Length = "0x14")]
	public bool IsLocked(bool isStoryMode)
	{
		return false;
	}

	[Token(Token = "0x6007F85")]
	[Address(RVA = "0x11F7E40", Offset = "0x11F6C40", Length = "0x14C")]
	public Texture2D GetCraftingIcon()
	{
		return null;
	}

	[Token(Token = "0x6007F86")]
	[Address(RVA = "0x11F7F90", Offset = "0x11F6D90", Length = "0x3FF")]
	public InProgressCraftItem GetInProgressItem(Container container)
	{
		return null;
	}

	[Token(Token = "0x6007F87")]
	[Address(RVA = "0x11F8390", Offset = "0x11F7190", Length = "0x443")]
	public InProgressCraftItem GetInProgressItem(Inventory inventory, Container container)
	{
		return null;
	}

	[Token(Token = "0x6007F88")]
	[Address(RVA = "0x11F87E0", Offset = "0x11F75E0", Length = "0x1E9")]
	private bool HasRequiredTool(Inventory inventory)
	{
		return false;
	}

	[Token(Token = "0x6007F89")]
	[Address(RVA = "0x11F89D0", Offset = "0x11F77D0", Length = "0xBC")]
	private bool HasRequiredPhotos()
	{
		return false;
	}

	[Token(Token = "0x6007F8A")]
	[Address(RVA = "0x11F8A90", Offset = "0x11F7890", Length = "0x34")]
	public List<ToolsItem> GetFilteredOptionalTools()
	{
		return null;
	}

	[Token(Token = "0x6007F8B")]
	[Address(RVA = "0x11F8AD0", Offset = "0x11F78D0", Length = "0x485")]
	private void InitializeOptionalTools()
	{
	}

	[Token(Token = "0x6007F8C")]
	[Address(RVA = "0x11F8F60", Offset = "0x11F7D60", Length = "0x317")]
	private void AddAlternateTools(AlternateTools altTools)
	{
	}

	[Token(Token = "0x6007F8D")]
	[Address(RVA = "0x11F9280", Offset = "0x11F8080", Length = "0x88")]
	private int GetQuantityMultiplier()
	{
		return 0;
	}

	[Token(Token = "0x6007F8E")]
	[Address(RVA = "0x11F9310", Offset = "0x11F8110", Length = "0x100")]
	internal static int CompareBlueprintDataByName(BlueprintData x, BlueprintData y)
	{
		return 0;
	}

	[Token(Token = "0x6007F8F")]
	[Address(RVA = "0x11F9420", Offset = "0x11F8220", Length = "0x218")]
	public BlueprintData()
	{
	}
}
