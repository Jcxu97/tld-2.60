using AK.Wwise;
using Cpp2ILInjected;
using TLD.GameplayTags;
using TLD.IntBackedUnit;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gear;

[Token(Token = "0x200141A")]
public class GearItemData : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x40092C1")]
	[FieldOffset(Offset = "0x18")]
	private AssetReferenceGearItem m_PrefabReference;

	[Header("Config")]
	[SerializeField]
	[Token(Token = "0x40092C2")]
	[FieldOffset(Offset = "0x20")]
	private GearType m_Type;

	[SerializeField]
	[Token(Token = "0x40092C3")]
	[FieldOffset(Offset = "0x28")]
	private GameplayTag m_GameplayTag;

	[Tooltip("Will leave this gear item in the inventory even when the last unit is dropped")]
	[SerializeField]
	[Token(Token = "0x40092C4")]
	[FieldOffset(Offset = "0x38")]
	private bool m_RemainInInventoryOnDrop;

	[SerializeField]
	[Token(Token = "0x40092C5")]
	[FieldOffset(Offset = "0x39")]
	private bool m_AlwaysConsiderHarvested;

	[SerializeField]
	[Token(Token = "0x40092C6")]
	[FieldOffset(Offset = "0x3A")]
	private bool m_IsPlaceable;

	[SerializeField]
	[Token(Token = "0x40092C7")]
	[FieldOffset(Offset = "0x3C")]
	private GearDummyType m_GearDummyType;

	[Tooltip("Item is un-droppable")]
	[SerializeField]
	[Token(Token = "0x40092C8")]
	[FieldOffset(Offset = "0x40")]
	private bool m_CantDrop;

	[SerializeField]
	[Token(Token = "0x40092C9")]
	[FieldOffset(Offset = "0x41")]
	private bool m_DisableMove;

	[Header("Physical Settings")]
	[SerializeField]
	[Token(Token = "0x40092CA")]
	[FieldOffset(Offset = "0x48")]
	private ItemWeight m_BaseWeight;

	[SerializeField]
	[Token(Token = "0x40092CB")]
	[FieldOffset(Offset = "0x50")]
	private float m_MaxHP;

	[SerializeField]
	[Token(Token = "0x40092CC")]
	[FieldOffset(Offset = "0x54")]
	private float m_DailyHPDecay;

	[SerializeField]
	[Token(Token = "0x40092CD")]
	[FieldOffset(Offset = "0x58")]
	private bool m_SkipInitialDecay;

	[SerializeField]
	[Token(Token = "0x40092CE")]
	[FieldOffset(Offset = "0x5C")]
	private float m_ScentIntensity;

	[Range(0f, 100f)]
	[SerializeField]
	[Token(Token = "0x40092CF")]
	[FieldOffset(Offset = "0x60")]
	private float m_GearBreakConditionThreshold;

	[SerializeField]
	[Token(Token = "0x40092D0")]
	[FieldOffset(Offset = "0x64")]
	private bool m_AffectedByProjectilePhysics;

	[Header("UI")]
	[SerializeField]
	[Token(Token = "0x40092D1")]
	[FieldOffset(Offset = "0x68")]
	private LocalizedString m_LocalizedName;

	[SerializeField]
	[Token(Token = "0x40092D2")]
	[FieldOffset(Offset = "0x70")]
	private LocalizedString m_LocalizedDescription;

	[SerializeField]
	[Token(Token = "0x40092D3")]
	[FieldOffset(Offset = "0x78")]
	private ConditionTableType m_ConditionType;

	[SerializeField]
	[Token(Token = "0x40092D4")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_PromptsPersistUntilUsed;

	[SerializeField]
	[Token(Token = "0x40092D5")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_AllowFavoriting;

	[Header("Visualization")]
	[SerializeField]
	[Token(Token = "0x40092D6")]
	[FieldOffset(Offset = "0x80")]
	private GearItemInventoryIconData m_IconData;

	[Range(0f, 1f)]
	[SerializeField]
	[Token(Token = "0x40092D7")]
	[FieldOffset(Offset = "0x88")]
	private float m_DamageBlendStartPercent;

	[Range(0f, 1f)]
	[SerializeField]
	[Token(Token = "0x40092D8")]
	[FieldOffset(Offset = "0x8C")]
	private float m_DamageShaderUpdateThreshold;

	[Header("CoverFlow Textures")]
	[SerializeField]
	[Token(Token = "0x40092D9")]
	[FieldOffset(Offset = "0x90")]
	private AssetReferenceTexture2D m_CoverFlowMainTexture;

	[SerializeField]
	[Token(Token = "0x40092DA")]
	[FieldOffset(Offset = "0x98")]
	private AssetReferenceTexture2D m_CoverFlowDamageTexture;

	[SerializeField]
	[Token(Token = "0x40092DB")]
	[FieldOffset(Offset = "0xA0")]
	private AssetReferenceTexture2D m_CoverFlowBlendTexture;

	[SerializeField]
	[Token(Token = "0x40092DC")]
	[FieldOffset(Offset = "0xA8")]
	private AssetReferenceTexture2D m_CoverFlowOpenedTexture;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x40092DD")]
	[FieldOffset(Offset = "0xB0")]
	private GearMovementSound m_MovementSoundCategory;

	[SerializeField]
	[Token(Token = "0x40092DE")]
	[FieldOffset(Offset = "0xB8")]
	private AK.Wwise.Event m_PickupAudio;

	[SerializeField]
	[Token(Token = "0x40092DF")]
	[FieldOffset(Offset = "0xC0")]
	private AK.Wwise.Event m_StowAudio;

	[SerializeField]
	[Token(Token = "0x40092E0")]
	[FieldOffset(Offset = "0xC8")]
	private AK.Wwise.Event m_PutBackAudio;

	[SerializeField]
	[Token(Token = "0x40092E1")]
	[FieldOffset(Offset = "0xD0")]
	private AK.Wwise.Event m_WornOutAudio;

	[SerializeField]
	[Token(Token = "0x40092E2")]
	[FieldOffset(Offset = "0xD8")]
	private AK.Wwise.Event m_CookingSlotPlacementAudio;

	[Token(Token = "0x17000AF0")]
	public AssetReferenceGearItem PrefabReference
	{
		[Token(Token = "0x6008008")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AF1")]
	public GameplayTag GameplayTag
	{
		[Token(Token = "0x6008009")]
		[Address(RVA = "0x1202900", Offset = "0x1201700", Length = "0xB")]
		get
		{
			return default(GameplayTag);
		}
	}

	[Token(Token = "0x17000AF2")]
	public bool RemainInInventoryOnDrop
	{
		[Token(Token = "0x600800A")]
		[Address(RVA = "0x8BE400", Offset = "0x8BD200", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AF3")]
	public bool AlwaysConsiderHarvested
	{
		[Token(Token = "0x600800B")]
		[Address(RVA = "0xEADDA0", Offset = "0xEACBA0", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AF4")]
	public bool IsPlaceable
	{
		[Token(Token = "0x600800C")]
		[Address(RVA = "0x1202910", Offset = "0x1201710", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AF5")]
	public GearDummyType GearDummyType
	{
		[Token(Token = "0x600800D")]
		[Address(RVA = "0x63F4E0", Offset = "0x63E2E0", Length = "0x4")]
		get
		{
			return default(GearDummyType);
		}
	}

	[Token(Token = "0x17000AF6")]
	public bool CantDrop
	{
		[Token(Token = "0x600800E")]
		[Address(RVA = "0x667FB0", Offset = "0x666DB0", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AF7")]
	public bool DisableMove
	{
		[Token(Token = "0x600800F")]
		[Address(RVA = "0x1202920", Offset = "0x1201720", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AF8")]
	public ItemWeight BaseWeightKG
	{
		[Token(Token = "0x6008010")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return default(ItemWeight);
		}
	}

	[Token(Token = "0x17000AF9")]
	public float MaxHP
	{
		[Token(Token = "0x6008011")]
		[Address(RVA = "0x4B4350", Offset = "0x4B3150", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000AFA")]
	public float DailyHPDecay
	{
		[Token(Token = "0x6008012")]
		[Address(RVA = "0x5024C0", Offset = "0x5012C0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000AFB")]
	public bool SkipInitialDecay
	{
		[Token(Token = "0x6008013")]
		[Address(RVA = "0x67E850", Offset = "0x67D650", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AFC")]
	public float ScentIntensity
	{
		[Token(Token = "0x6008014")]
		[Address(RVA = "0x502520", Offset = "0x501320", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000AFD")]
	public float GearBreakConditionThreshold
	{
		[Token(Token = "0x6008015")]
		[Address(RVA = "0x5024F0", Offset = "0x5012F0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000AFE")]
	public bool AffectedByProjectilePhysics
	{
		[Token(Token = "0x6008016")]
		[Address(RVA = "0x502540", Offset = "0x501340", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AFF")]
	public string DisplayName
	{
		[Token(Token = "0x6008017")]
		[Address(RVA = "0x6BE0D0", Offset = "0x6BCED0", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B00")]
	public string DisplayNameLocID
	{
		[Token(Token = "0x6008018")]
		[Address(RVA = "0x11A8420", Offset = "0x11A7220", Length = "0x1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B01")]
	public string Description
	{
		[Token(Token = "0x6008019")]
		[Address(RVA = "0x1202930", Offset = "0x1201730", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B02")]
	public string DescriptionLocID
	{
		[Token(Token = "0x600801A")]
		[Address(RVA = "0x1202990", Offset = "0x1201790", Length = "0x1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B03")]
	public ConditionTableType ConditionType
	{
		[Token(Token = "0x600801B")]
		[Address(RVA = "0x657EE0", Offset = "0x656CE0", Length = "0x4")]
		get
		{
			return default(ConditionTableType);
		}
	}

	[Token(Token = "0x17000B04")]
	public bool PromptsPersistUntilUsed
	{
		[Token(Token = "0x600801C")]
		[Address(RVA = "0x634890", Offset = "0x633690", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B05")]
	public bool AllowFavoriting
	{
		[Token(Token = "0x600801D")]
		[Address(RVA = "0x69CF60", Offset = "0x69BD60", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B06")]
	public float DamageBlendStartPercent
	{
		[Token(Token = "0x600801E")]
		[Address(RVA = "0x760E30", Offset = "0x75FC30", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B07")]
	public float DamageShaderUpdateThreshold
	{
		[Token(Token = "0x600801F")]
		[Address(RVA = "0x502360", Offset = "0x501160", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B08")]
	public GearItemInventoryIconData IconData
	{
		[Token(Token = "0x6008020")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B09")]
	public AssetReferenceTexture2D CoverFlowMainTexture
	{
		[Token(Token = "0x6008021")]
		[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0A")]
	public AssetReferenceTexture2D CoverFlowDamageTexture
	{
		[Token(Token = "0x6008022")]
		[Address(RVA = "0x4B3EA0", Offset = "0x4B2CA0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0B")]
	public AssetReferenceTexture2D CoverFlowBlendTexture
	{
		[Token(Token = "0x6008023")]
		[Address(RVA = "0x40DAB0", Offset = "0x40C8B0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0C")]
	public AssetReferenceTexture2D CoverFlowOpenedTexture
	{
		[Token(Token = "0x6008024")]
		[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0D")]
	public GearMovementSound MovementSoundCategory
	{
		[Token(Token = "0x6008025")]
		[Address(RVA = "0x5DEE90", Offset = "0x5DDC90", Length = "0x7")]
		get
		{
			return default(GearMovementSound);
		}
	}

	[Token(Token = "0x17000B0E")]
	public AK.Wwise.Event PickupAudio
	{
		[Token(Token = "0x6008026")]
		[Address(RVA = "0x502320", Offset = "0x501120", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0F")]
	public AK.Wwise.Event StowAudio
	{
		[Token(Token = "0x6008027")]
		[Address(RVA = "0x502640", Offset = "0x501440", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B10")]
	public AK.Wwise.Event PutBackAudio
	{
		[Token(Token = "0x6008028")]
		[Address(RVA = "0x502670", Offset = "0x501470", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B11")]
	public AK.Wwise.Event WornOutAudio
	{
		[Token(Token = "0x6008029")]
		[Address(RVA = "0x502680", Offset = "0x501480", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B12")]
	public AK.Wwise.Event CookingSlotPlacementAudio
	{
		[Token(Token = "0x600802A")]
		[Address(RVA = "0x502650", Offset = "0x501450", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600802B")]
	[Address(RVA = "0x12029B0", Offset = "0x12017B0", Length = "0x102")]
	public string GetDisplayNameWithCondition(float normalizedCondition, string overrideDisplayLocID = null)
	{
		return null;
	}

	[Token(Token = "0x600802C")]
	[Address(RVA = "0x1202AC0", Offset = "0x12018C0", Length = "0xB")]
	public bool IsGearType(GearType type)
	{
		return false;
	}

	[Token(Token = "0x600802D")]
	[Address(RVA = "0x1202AD0", Offset = "0x12018D0", Length = "0x12C")]
	public GearItemData()
	{
	}
}
