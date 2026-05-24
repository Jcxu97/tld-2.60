using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Cooking;
using TLD.Gameplay;
using TLD.Gameplay.Fishing;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.Interactions;
using TLD.Placement;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x200049D")]
public class GearItem : MonoBehaviour, ICraftingResult, IInteraction, ITorchLightInteraction, IAlternativeInteraction
{
	[Token(Token = "0x200049E")]
	public delegate void ConditionChangedEvent(GearItem gi, float previousHP, float currentHP);

	[Token(Token = "0x4002A3D")]
	private const int GEAR_ITEM_SAVE_VERSION = 5;

	[Token(Token = "0x4002A3E")]
	public const string ITEM_PLACED_EVENT_NAME = "GearItem_Placed";

	[Token(Token = "0x4002A3F")]
	public const float DEFAULT_DECAY_SCALE = 1f;

	[HideInInspector]
	[Token(Token = "0x4002A40")]
	[FieldOffset(Offset = "0x20")]
	public int m_InstanceID;

	[HideInInspector]
	[Token(Token = "0x4002A41")]
	[FieldOffset(Offset = "0x24")]
	public bool m_BeenInPlayerInventory;

	[HideInInspector]
	[Token(Token = "0x4002A42")]
	[FieldOffset(Offset = "0x25")]
	public bool m_HasBeenOwnedByPlayer;

	[HideInInspector]
	[Token(Token = "0x4002A43")]
	[FieldOffset(Offset = "0x26")]
	public bool m_BeenInContainer;

	[HideInInspector]
	[Token(Token = "0x4002A44")]
	[FieldOffset(Offset = "0x27")]
	public bool m_BeenInspected;

	[HideInInspector]
	[Token(Token = "0x4002A45")]
	[FieldOffset(Offset = "0x28")]
	public bool m_InPlayerInventory;

	[HideInInspector]
	[Token(Token = "0x4002A46")]
	[FieldOffset(Offset = "0x29")]
	public bool m_ItemLooted;

	[HideInInspector]
	[Token(Token = "0x4002A47")]
	[FieldOffset(Offset = "0x2A")]
	public bool m_InitialDecayApplied;

	[HideInInspector]
	[Token(Token = "0x4002A48")]
	[FieldOffset(Offset = "0x2B")]
	public bool m_IsInSatchel;

	[HideInInspector]
	[Token(Token = "0x4002A49")]
	[FieldOffset(Offset = "0x2C")]
	public int m_SatchelIndex;

	[HideInInspector]
	[Token(Token = "0x4002A4A")]
	[FieldOffset(Offset = "0x30")]
	public bool m_InsideContainer;

	[HideInInspector]
	[Token(Token = "0x4002A4B")]
	[FieldOffset(Offset = "0x34")]
	public float m_NormalizedRevealTimeInContainer;

	[HideInInspector]
	[Token(Token = "0x4002A4C")]
	[FieldOffset(Offset = "0x38")]
	public bool m_LockedInContainer;

	[NonSerialized]
	[Token(Token = "0x4002A4D")]
	[FieldOffset(Offset = "0x39")]
	public bool m_IsHidden;

	[HideInInspector]
	[Token(Token = "0x4002A4E")]
	[FieldOffset(Offset = "0x40")]
	public AmmoItem m_AmmoItem;

	[HideInInspector]
	[Token(Token = "0x4002A4F")]
	[FieldOffset(Offset = "0x48")]
	public AmmoCasingItem m_AmmoCasingItem;

	[HideInInspector]
	[Token(Token = "0x4002A50")]
	[FieldOffset(Offset = "0x50")]
	public ArrowItem m_ArrowItem;

	[HideInInspector]
	[Token(Token = "0x4002A51")]
	[FieldOffset(Offset = "0x58")]
	public BearSpearItem m_BearSpearItem;

	[HideInInspector]
	[Token(Token = "0x4002A52")]
	[FieldOffset(Offset = "0x60")]
	public Bed m_Bed;

	[HideInInspector]
	[Token(Token = "0x4002A53")]
	[FieldOffset(Offset = "0x68")]
	public BlueprintItemUnlock m_BlueprintItemUnlock;

	[HideInInspector]
	[Token(Token = "0x4002A54")]
	[FieldOffset(Offset = "0x70")]
	public BodyHarvestItem m_BodyHarvestItem;

	[HideInInspector]
	[Token(Token = "0x4002A55")]
	[FieldOffset(Offset = "0x78")]
	public BodyHarvest m_BodyHarvest;

	[HideInInspector]
	[Token(Token = "0x4002A56")]
	[FieldOffset(Offset = "0x80")]
	public BowItem m_BowItem;

	[HideInInspector]
	[Token(Token = "0x4002A57")]
	[FieldOffset(Offset = "0x88")]
	public BreakDownItem m_BreakDownItem;

	[HideInInspector]
	[Token(Token = "0x4002A58")]
	[FieldOffset(Offset = "0x90")]
	public CanOpeningItem m_CanOpeningItem;

	[HideInInspector]
	[Token(Token = "0x4002A59")]
	[FieldOffset(Offset = "0x98")]
	public CarryingCapacityBuff m_CarryingCapacityBuff;

	[HideInInspector]
	[Token(Token = "0x4002A5A")]
	[FieldOffset(Offset = "0xA0")]
	public CharcoalItem m_CharcoalItem;

	[HideInInspector]
	[Token(Token = "0x4002A5B")]
	[FieldOffset(Offset = "0xA8")]
	public Cleanable m_Cleanable;

	[HideInInspector]
	[Token(Token = "0x4002A5C")]
	[FieldOffset(Offset = "0xB0")]
	public ClothingItem m_ClothingItem;

	[HideInInspector]
	[Token(Token = "0x4002A5D")]
	[FieldOffset(Offset = "0xB8")]
	public ConditionOverTimeBuff m_ConditionOverTimeBuff;

	[HideInInspector]
	[Token(Token = "0x4002A5E")]
	[FieldOffset(Offset = "0xC0")]
	public ConditionRestBuff m_ConditionRestBuff;

	[HideInInspector]
	[Token(Token = "0x4002A5F")]
	[FieldOffset(Offset = "0xC8")]
	public Cookable m_Cookable;

	[HideInInspector]
	[Token(Token = "0x4002A60")]
	[FieldOffset(Offset = "0xD0")]
	public CookingPotItem m_CookingPotItem;

	[HideInInspector]
	[Token(Token = "0x4002A61")]
	[FieldOffset(Offset = "0xD8")]
	public DegradeOnUse m_DegradeOnUse;

	[HideInInspector]
	[Token(Token = "0x4002A62")]
	[FieldOffset(Offset = "0xE0")]
	public EmergencyStimItem m_EmergencyStim;

	[HideInInspector]
	[Token(Token = "0x4002A63")]
	[FieldOffset(Offset = "0xE8")]
	public EnergyBoostItem m_EnergyBoost;

	[HideInInspector]
	[Token(Token = "0x4002A64")]
	[FieldOffset(Offset = "0xF0")]
	public EvolveItem m_EvolveItem;

	[HideInInspector]
	[Token(Token = "0x4002A65")]
	[FieldOffset(Offset = "0xF8")]
	public FatigueBuff m_FatigueBuff;

	[HideInInspector]
	[Token(Token = "0x4002A66")]
	[FieldOffset(Offset = "0x100")]
	public FireStarterItem m_FireStarterItem;

	[HideInInspector]
	[Token(Token = "0x4002A67")]
	[FieldOffset(Offset = "0x108")]
	public FirstAidItem m_FirstAidItem;

	[HideInInspector]
	[Token(Token = "0x4002A68")]
	[FieldOffset(Offset = "0x110")]
	public FirstPersonItem m_FirstPersonItem;

	[HideInInspector]
	[Token(Token = "0x4002A69")]
	[FieldOffset(Offset = "0x118")]
	public FlareGunRoundItem m_FlareGunRoundItem;

	[HideInInspector]
	[Token(Token = "0x4002A6A")]
	[FieldOffset(Offset = "0x120")]
	public FlareItem m_FlareItem;

	[HideInInspector]
	[Token(Token = "0x4002A6B")]
	[FieldOffset(Offset = "0x128")]
	public FlashlightItem m_FlashlightItem;

	[HideInInspector]
	[Token(Token = "0x4002A6C")]
	[FieldOffset(Offset = "0x130")]
	public FoodItem m_FoodItem;

	[HideInInspector]
	[Token(Token = "0x4002A6D")]
	[FieldOffset(Offset = "0x138")]
	public FoodWeight m_FoodWeight;

	[HideInInspector]
	[Token(Token = "0x4002A6E")]
	[FieldOffset(Offset = "0x140")]
	public ForageItem m_ForageItem;

	[HideInInspector]
	[Token(Token = "0x4002A6F")]
	[FieldOffset(Offset = "0x148")]
	public ForceLockItem m_ForceLockItem;

	[HideInInspector]
	[Token(Token = "0x4002A70")]
	[FieldOffset(Offset = "0x150")]
	public FreezingBuff m_FreezingBuff;

	[HideInInspector]
	[Token(Token = "0x4002A71")]
	[FieldOffset(Offset = "0x158")]
	public FuelSourceItem m_FuelSourceItem;

	[HideInInspector]
	[Token(Token = "0x4002A72")]
	[FieldOffset(Offset = "0x160")]
	public HandheldShortwaveItem m_HandheldShortwaveItem;

	[HideInInspector]
	[Token(Token = "0x4002A73")]
	[FieldOffset(Offset = "0x168")]
	public GunItem m_GunItem;

	[HideInInspector]
	[Token(Token = "0x4002A74")]
	[FieldOffset(Offset = "0x170")]
	public HarvestBase m_Harvest;

	[HideInInspector]
	[Token(Token = "0x4002A75")]
	[FieldOffset(Offset = "0x178")]
	public IceFishingHoleClearItem m_IceFishingHoleClearItem;

	[HideInInspector]
	[Token(Token = "0x4002A76")]
	[FieldOffset(Offset = "0x180")]
	public InProgressCraftItem m_InProgressCraftItem;

	[HideInInspector]
	[Token(Token = "0x4002A77")]
	[FieldOffset(Offset = "0x188")]
	public Inspect m_Inspect;

	[HideInInspector]
	[Token(Token = "0x4002A78")]
	[FieldOffset(Offset = "0x190")]
	public KeroseneLampItem m_KeroseneLampItem;

	[HideInInspector]
	[Token(Token = "0x4002A79")]
	[FieldOffset(Offset = "0x198")]
	public Knowledge m_Knowledge;

	[HideInInspector]
	[Token(Token = "0x4002A7A")]
	[FieldOffset(Offset = "0x1A0")]
	public LiquidItem m_LiquidItem;

	[HideInInspector]
	[Token(Token = "0x4002A7B")]
	[FieldOffset(Offset = "0x1A8")]
	public MatchesItem m_MatchesItem;

	[HideInInspector]
	[Token(Token = "0x4002A7C")]
	[FieldOffset(Offset = "0x1B0")]
	public Millable m_Millable;

	[HideInInspector]
	[Token(Token = "0x4002A7D")]
	[FieldOffset(Offset = "0x1B8")]
	public NarrativeCollectibleItem m_NarrativeCollectibleItem;

	[HideInInspector]
	[Token(Token = "0x4002A7E")]
	[FieldOffset(Offset = "0x1C0")]
	public NoiseMakerItem m_NoiseMakerItem;

	[HideInInspector]
	[Token(Token = "0x4002A7F")]
	[FieldOffset(Offset = "0x1C8")]
	public ShowOnMapItem m_ShowOnMapItem;

	[HideInInspector]
	[Token(Token = "0x4002A80")]
	[FieldOffset(Offset = "0x1D0")]
	public PowderItem m_PowderItem;

	[HideInInspector]
	[Token(Token = "0x4002A81")]
	[FieldOffset(Offset = "0x1D8")]
	public PurifyWater m_PurifyWater;

	[HideInInspector]
	[Token(Token = "0x4002A82")]
	[FieldOffset(Offset = "0x1E0")]
	public Repairable m_Repairable;

	[HideInInspector]
	[Token(Token = "0x4002A83")]
	[FieldOffset(Offset = "0x1E8")]
	public ResearchItem m_ResearchItem;

	[HideInInspector]
	[Token(Token = "0x4002A84")]
	[FieldOffset(Offset = "0x1F0")]
	public Respirator m_Respirator;

	[HideInInspector]
	[Token(Token = "0x4002A85")]
	[FieldOffset(Offset = "0x1F8")]
	public RespiratorCanister m_RespiratorCanister;

	[HideInInspector]
	[Token(Token = "0x4002A86")]
	[FieldOffset(Offset = "0x200")]
	public RopeItem m_RopeItem;

	[HideInInspector]
	[Token(Token = "0x4002A87")]
	[FieldOffset(Offset = "0x208")]
	public Scent m_Scent;

	[HideInInspector]
	[Token(Token = "0x4002A88")]
	[FieldOffset(Offset = "0x210")]
	public Sharpenable m_Sharpenable;

	[HideInInspector]
	[Token(Token = "0x4002A89")]
	[FieldOffset(Offset = "0x218")]
	public SmashableItem m_SmashableItem;

	[HideInInspector]
	[Token(Token = "0x4002A8A")]
	[FieldOffset(Offset = "0x220")]
	public SnareItem m_SnareItem;

	[HideInInspector]
	[Token(Token = "0x4002A8B")]
	[FieldOffset(Offset = "0x228")]
	public SprayPaintCan m_SprayPaintCan;

	[HideInInspector]
	[Token(Token = "0x4002A8C")]
	[FieldOffset(Offset = "0x230")]
	public StackableItem m_StackableItem;

	[HideInInspector]
	[Token(Token = "0x4002A8D")]
	[FieldOffset(Offset = "0x238")]
	public StoneItem m_StoneItem;

	[HideInInspector]
	[Token(Token = "0x4002A8E")]
	[FieldOffset(Offset = "0x240")]
	public StruggleBonus m_StruggleBonus;

	[HideInInspector]
	[Token(Token = "0x4002A8F")]
	[FieldOffset(Offset = "0x248")]
	public ToolsItem m_ToolsItem;

	[HideInInspector]
	[Token(Token = "0x4002A90")]
	[FieldOffset(Offset = "0x250")]
	public TorchItem m_TorchItem;

	[HideInInspector]
	[Token(Token = "0x4002A91")]
	[FieldOffset(Offset = "0x258")]
	public TravoisItem m_Travois;

	[HideInInspector]
	[Token(Token = "0x4002A92")]
	[FieldOffset(Offset = "0x260")]
	public WaterSupply m_WaterSupply;

	[HideInInspector]
	[Token(Token = "0x4002A93")]
	[FieldOffset(Offset = "0x268")]
	public WildlifeItem m_WildlifeItem;

	[HideInInspector]
	[Token(Token = "0x4002A94")]
	[FieldOffset(Offset = "0x270")]
	public WolfIntimidationBuff m_WolfIntimidationBuff;

	[HideInInspector]
	[Token(Token = "0x4002A95")]
	[FieldOffset(Offset = "0x278")]
	public ClimbingBuff m_ClimbingBuff;

	[HideInInspector]
	[Token(Token = "0x4002A96")]
	[FieldOffset(Offset = "0x280")]
	public ProtectionBuff m_ProtectionBuff;

	[HideInInspector]
	[Token(Token = "0x4002A97")]
	[FieldOffset(Offset = "0x288")]
	public WeightReductionBuff m_WeightReductionBuff;

	[HideInInspector]
	[Token(Token = "0x4002A98")]
	[FieldOffset(Offset = "0x290")]
	public LureItem m_LureItem;

	[HideInInspector]
	[Token(Token = "0x4002A99")]
	[FieldOffset(Offset = "0x298")]
	public BaitItem m_BaitItem;

	[HideInInspector]
	[Token(Token = "0x4002A9A")]
	[FieldOffset(Offset = "0x2A0")]
	public RecipeItem m_RecipeItem;

	[Token(Token = "0x4002A9B")]
	[FieldOffset(Offset = "0x2A8")]
	private InsulatedFlask m_InsulatedFlask;

	[HideInInspector]
	[Token(Token = "0x4002A9C")]
	[FieldOffset(Offset = "0x2B0")]
	public HeatPadItem m_HeatPadItem;

	[HideInInspector]
	[Token(Token = "0x4002A9D")]
	[FieldOffset(Offset = "0x2B8")]
	public MeshRenderer[] m_MeshRenderers;

	[HideInInspector]
	[Token(Token = "0x4002A9E")]
	[FieldOffset(Offset = "0x2C0")]
	public SkinnedMeshRenderer[] m_SkinnedMeshRenderers;

	[HideInInspector]
	[Token(Token = "0x4002A9F")]
	[FieldOffset(Offset = "0x2C8")]
	public ObjectGuid m_ObjectGuid;

	[HideInInspector]
	[Token(Token = "0x4002AA0")]
	[FieldOffset(Offset = "0x2D0")]
	public MissionObjectIdentifier m_MissionObject;

	[HideInInspector]
	[Token(Token = "0x4002AA1")]
	[FieldOffset(Offset = "0x2D8")]
	public OnDroppedInWaterDelegate m_OnDroppedInWater;

	[HideInInspector]
	[Token(Token = "0x4002AA2")]
	[FieldOffset(Offset = "0x2E0")]
	public RadialObjectSpawner m_RadialObjectSpawnerParent;

	[HideInInspector]
	[Token(Token = "0x4002AA3")]
	[FieldOffset(Offset = "0x2E8")]
	public Container m_LastContainer;

	[HideInInspector]
	[Token(Token = "0x4002AA4")]
	[FieldOffset(Offset = "0x2F0")]
	public RecoveryCamp m_RecoveryCampParent;

	[Token(Token = "0x4002AA5")]
	[FieldOffset(Offset = "0x2F8")]
	private string m_PlacePointGuid;

	[Token(Token = "0x4002AA6")]
	[FieldOffset(Offset = "0x300")]
	private string m_PlacePointName;

	[Token(Token = "0x4002AA7")]
	[FieldOffset(Offset = "0x308")]
	private Rigidbody m_RigidBody;

	[Token(Token = "0x4002AA8")]
	[FieldOffset(Offset = "0x310")]
	private Vector3 m_DefaultLocalScale;

	[Token(Token = "0x4002AA9")]
	[FieldOffset(Offset = "0x31C")]
	private bool m_UnequipInProgress;

	[Token(Token = "0x4002AAA")]
	[FieldOffset(Offset = "0x320")]
	private string m_DisplayNameOverrideLocID;

	[Token(Token = "0x4002AAB")]
	[FieldOffset(Offset = "0x328")]
	private string m_DescriptionOverrideLocID;

	[Token(Token = "0x4002AAE")]
	[FieldOffset(Offset = "0x340")]
	private float m_CurrentHP;

	[SerializeField]
	[Token(Token = "0x4002AAF")]
	[FieldOffset(Offset = "0x348")]
	private GearItemData m_GearItemData;

	[Token(Token = "0x4002AB0")]
	[FieldOffset(Offset = "0x350")]
	public bool m_DisableSerialization;

	[Token(Token = "0x4002AB1")]
	[FieldOffset(Offset = "0x351")]
	public bool m_CantDropItem;

	[Header("Spawn Settings")]
	[SerializeField]
	[Token(Token = "0x4002AB2")]
	[FieldOffset(Offset = "0x354")]
	private float m_SpawnChance;

	[SerializeField]
	[Token(Token = "0x4002AB3")]
	[FieldOffset(Offset = "0x358")]
	private GearStartCondition m_StartCondition;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002AB4")]
	[FieldOffset(Offset = "0x360")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvestPanel;

	[SerializeField]
	[Token(Token = "0x4002AB5")]
	[FieldOffset(Offset = "0x368")]
	private PanelReference<Panel_IceFishing> m_IceFishingPanel;

	[SerializeField]
	[Token(Token = "0x4002AB6")]
	[FieldOffset(Offset = "0x370")]
	private PanelReference<Panel_Inventory> m_InventoryPanel;

	[Token(Token = "0x4002AB7")]
	[FieldOffset(Offset = "0x378")]
	private bool m_RolledSpawnChance;

	[Token(Token = "0x4002AB8")]
	[FieldOffset(Offset = "0x379")]
	private bool m_WornOut;

	[Token(Token = "0x4002AB9")]
	[FieldOffset(Offset = "0x37A")]
	private bool m_HaltDecay;

	[Token(Token = "0x4002ABA")]
	[FieldOffset(Offset = "0x37C")]
	private float m_DecayAccumulator;

	[Token(Token = "0x4002ABB")]
	[FieldOffset(Offset = "0x380")]
	private bool m_HarvestedByPlayer;

	[Token(Token = "0x4002ABC")]
	[FieldOffset(Offset = "0x384")]
	private float m_LastUpdateDamageShaderCondition;

	[Token(Token = "0x4002ABD")]
	[FieldOffset(Offset = "0x388")]
	private bool m_MarkedForNextUpdateDestroy;

	[Token(Token = "0x4002ABE")]
	[FieldOffset(Offset = "0x389")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002ABF")]
	[FieldOffset(Offset = "0x38C")]
	private float m_DecayScalar;

	[Token(Token = "0x4002AC0")]
	[FieldOffset(Offset = "0x390")]
	private float m_LastUpdatedTODHours;

	[Token(Token = "0x4002AC1")]
	[FieldOffset(Offset = "0x394")]
	private bool m_LastUpdatedTODHoursInitialized;

	[Token(Token = "0x4002AC2")]
	[FieldOffset(Offset = "0x395")]
	private bool m_HasBeenEquippedAndUsed;

	[Token(Token = "0x4002AC3")]
	[FieldOffset(Offset = "0x396")]
	private bool m_IsTextureStreamingDisabled;

	[Token(Token = "0x4002AC4")]
	private static readonly GearItemSaveDataProxy m_GearItemSaveDataProxy;

	[Token(Token = "0x4002AC5")]
	private static readonly Collider[] s_InaccessibleResults;

	[Token(Token = "0x4002AC6")]
	private static readonly RaycastHit[] s_RaycastResults;

	[Token(Token = "0x4002AC7")]
	private static readonly Dictionary<Texture2D, int> s_GearTextureReferenceCounts;

	[Token(Token = "0x4002AC8")]
	public static readonly int s_DamageBlendAmountShaderID;

	[Token(Token = "0x17000225")]
	public string DisplayName
	{
		[Token(Token = "0x6002298")]
		[Address(RVA = "0x8369A0", Offset = "0x8357A0", Length = "0xA7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000226")]
	public string DisplayNameWithCondition
	{
		[Token(Token = "0x6002299")]
		[Address(RVA = "0x836A50", Offset = "0x835850", Length = "0x135")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000227")]
	public string Description
	{
		[Token(Token = "0x600229A")]
		[Address(RVA = "0x836B90", Offset = "0x835990", Length = "0xA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000228")]
	public InsulatedFlask InsulatedFlask
	{
		[Token(Token = "0x600229B")]
		[Address(RVA = "0x836C40", Offset = "0x835A40", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000229")]
	public GearItemData GearItemData
	{
		[Token(Token = "0x600229C")]
		[Address(RVA = "0x836C50", Offset = "0x835A50", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022A")]
	public bool DisableSerialization
	{
		[Token(Token = "0x600229D")]
		[Address(RVA = "0x836C60", Offset = "0x835A60", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700022B")]
	[field: Token(Token = "0x4002AAC")]
	[field: FieldOffset(Offset = "0x330")]
	public ItemWeight WeightKG
	{
		[Token(Token = "0x600229E")]
		[Address(RVA = "0x836C70", Offset = "0x835A70", Length = "0x8")]
		get;
		[Token(Token = "0x600229F")]
		[Address(RVA = "0x836C80", Offset = "0x835A80", Length = "0x8")]
		set;
	}

	[Token(Token = "0x1700022C")]
	public float CurrentHP
	{
		[Token(Token = "0x60022A2")]
		[Address(RVA = "0x836E70", Offset = "0x835C70", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60022A3")]
		[Address(RVA = "0x836E80", Offset = "0x835C80", Length = "0x43")]
		set
		{
		}
	}

	[Token(Token = "0x1700022D")]
	public string HoverText
	{
		[Token(Token = "0x600232C")]
		[Address(RVA = "0x850870", Offset = "0x84F670", Length = "0x7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022E")]
	public bool IsEnabled
	{
		[Token(Token = "0x600232D")]
		[Address(RVA = "0x850880", Offset = "0x84F680", Length = "0xCE")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700022F")]
	[field: Token(Token = "0x4002AC9")]
	[field: FieldOffset(Offset = "0x397")]
	public bool CanInteract
	{
		[Token(Token = "0x600232E")]
		[Address(RVA = "0x850950", Offset = "0x84F750", Length = "0x8")]
		get;
		[Token(Token = "0x600232F")]
		[Address(RVA = "0x850960", Offset = "0x84F760", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x17000230")]
	[field: Token(Token = "0x4002ACA")]
	[field: FieldOffset(Offset = "0x398")]
	public bool NonInteractive
	{
		[Token(Token = "0x6002330")]
		[Address(RVA = "0x850970", Offset = "0x84F770", Length = "0x8")]
		get;
		[Token(Token = "0x6002331")]
		[Address(RVA = "0x850980", Offset = "0x84F780", Length = "0x7")]
		set;
	}

	[Token(Token = "0x14000002")]
	public event ConditionChangedEvent ConditionChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x60022A0")]
		[Address(RVA = "0x836C90", Offset = "0x835A90", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60022A1")]
		[Address(RVA = "0x836D80", Offset = "0x835B80", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x836ED0", Offset = "0x835CD0", Length = "0x653")]
	public void Awake()
	{
	}

	[Token(Token = "0x60022A5")]
	[Address(RVA = "0x837530", Offset = "0x836330", Length = "0x1BC8")]
	public void CacheComponents()
	{
	}

	[Token(Token = "0x60022A6")]
	[Address(RVA = "0x839100", Offset = "0x837F00", Length = "0x371")]
	public void CompleteSpawnFromCONSOLE()
	{
	}

	[Token(Token = "0x60022A7")]
	[Address(RVA = "0x839480", Offset = "0x838280", Length = "0x15A")]
	public void ForceGUIDSetup()
	{
	}

	[Token(Token = "0x60022A8")]
	[Address(RVA = "0x8395E0", Offset = "0x8383E0", Length = "0x267")]
	public void ResetLocalScale()
	{
	}

	[Token(Token = "0x60022A9")]
	[Address(RVA = "0x839850", Offset = "0x838650", Length = "0xAA")]
	public void SetLocalizationOverride(string displayNameOverrideLocID, string descriptionOverrideLocID)
	{
	}

	[Token(Token = "0x60022AA")]
	[Address(RVA = "0x839900", Offset = "0x838700", Length = "0x8")]
	public bool IsUnequipInProgress()
	{
		return false;
	}

	[Token(Token = "0x60022AB")]
	[Address(RVA = "0x839910", Offset = "0x838710", Length = "0x2AB")]
	private void MaybeDestroyBodyHarvest()
	{
	}

	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x839BC0", Offset = "0x8389C0", Length = "0x1E9")]
	private void AddGearToContainer(GearItem containedGearItem, GearItem newItem)
	{
	}

	[Token(Token = "0x60022AD")]
	[Address(RVA = "0x839DB0", Offset = "0x838BB0", Length = "0x213")]
	private void RemoveGearFromContainer(GearItem gi)
	{
	}

	[Token(Token = "0x60022AE")]
	[Address(RVA = "0x839FD0", Offset = "0x838DD0", Length = "0xD44")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x60022AF")]
	[Address(RVA = "0x83AD20", Offset = "0x839B20", Length = "0xF7")]
	private bool HasPhysicsEnabled()
	{
		return false;
	}

	[Token(Token = "0x60022B0")]
	[Address(RVA = "0x83AE20", Offset = "0x839C20", Length = "0x45E")]
	public string SerializeRigidBody()
	{
		return null;
	}

	[Token(Token = "0x60022B1")]
	[Address(RVA = "0x83B280", Offset = "0x83A080", Length = "0x50E")]
	public void DeserializeRigidBody(string rigidBodySerialized)
	{
	}

	[Token(Token = "0x60022B2")]
	[Address(RVA = "0x83B790", Offset = "0x83A590", Length = "0xCB")]
	public string SerializeToString()
	{
		return null;
	}

	[Token(Token = "0x60022B3")]
	[Address(RVA = "0x83B860", Offset = "0x83A660", Length = "0x24DF")]
	public GearItemSaveDataProxy Serialize(bool useStaticProxy = false)
	{
		return null;
	}

	[Token(Token = "0x60022B4")]
	[Address(RVA = "0x83DD40", Offset = "0x83CB40", Length = "0x2B32")]
	public void Deserialize(GearItemSaveDataProxy proxy, bool applyPositioningFix)
	{
	}

	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x840880", Offset = "0x83F680", Length = "0x121")]
	public GearSaveData CreateSaveData()
	{
		return null;
	}

	[Token(Token = "0x60022B6")]
	[Address(RVA = "0x8409B0", Offset = "0x83F7B0", Length = "0x15B")]
	public void OnWield(bool immediate)
	{
	}

	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x840B10", Offset = "0x83F910", Length = "0x12D")]
	public void OnBeginUnwield()
	{
	}

	[Token(Token = "0x60022B8")]
	[Address(RVA = "0x840C40", Offset = "0x83FA40", Length = "0x180")]
	public void OnUnwieldComplete()
	{
	}

	[Token(Token = "0x60022B9")]
	[Address(RVA = "0x840DD0", Offset = "0x83FBD0", Length = "0x16A8")]
	public void MaybeAddToLostAndFound()
	{
	}

	[Token(Token = "0x60022BA")]
	[Address(RVA = "0x842840", Offset = "0x841640", Length = "0x18")]
	public bool IsAttachedToPlacePoint()
	{
		return false;
	}

	[Token(Token = "0x60022BB")]
	[Address(RVA = "0x842860", Offset = "0x841660", Length = "0xC1")]
	public void AssumeMissionObjectResponsibility(string missionObjectSerialized)
	{
	}

	[Token(Token = "0x60022BC")]
	[Address(RVA = "0x842930", Offset = "0x841730", Length = "0x2C8")]
	public void MaybeDestroyGearItemAfterMission()
	{
	}

	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x842C00", Offset = "0x841A00", Length = "0x769")]
	public void WearOut()
	{
	}

	[Token(Token = "0x60022BE")]
	[Address(RVA = "0x843370", Offset = "0x842170", Length = "0x178")]
	public void Degrade(float hp)
	{
	}

	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x8434F0", Offset = "0x8422F0", Length = "0x1DD")]
	public void SetNormalizedHP(float condition, bool roundToWholeNumber = true)
	{
	}

	[Token(Token = "0x60022C0")]
	[Address(RVA = "0x8436D0", Offset = "0x8424D0", Length = "0x230")]
	public void DisplayDegradedHUDMessage()
	{
	}

	[Token(Token = "0x60022C1")]
	[Address(RVA = "0x843910", Offset = "0x842710", Length = "0x61E")]
	public void DegradeOnUse()
	{
	}

	[Token(Token = "0x60022C2")]
	[Address(RVA = "0x843F30", Offset = "0x842D30", Length = "0xE3")]
	public bool CheckForBreakOnUse()
	{
		return false;
	}

	[Token(Token = "0x60022C3")]
	[Address(RVA = "0x844020", Offset = "0x842E20", Length = "0x102")]
	public int CheckForHoursToBreak(float decayPerHour, int maxHours)
	{
		return 0;
	}

	[Token(Token = "0x60022C4")]
	[Address(RVA = "0x844130", Offset = "0x842F30", Length = "0x42A")]
	public void BreakOnUse()
	{
	}

	[Token(Token = "0x60022C5")]
	[Address(RVA = "0x844560", Offset = "0x843360", Length = "0x10A")]
	public float GetMaxHPFromRepair()
	{
		return 0f;
	}

	[Token(Token = "0x60022C6")]
	[Address(RVA = "0x844670", Offset = "0x843470", Length = "0x8")]
	public void SetHasBeenEquippedAndUsed()
	{
	}

	[Token(Token = "0x60022C7")]
	[Address(RVA = "0x844680", Offset = "0x843480", Length = "0x31")]
	public bool ShouldKeepButtonPromptsOnScreen()
	{
		return false;
	}

	[Token(Token = "0x60022C8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void HideOrRevealBasedOnRequiredKnowledge()
	{
	}

	[Token(Token = "0x60022C9")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public GameObject InstantiateKnowledge()
	{
		return null;
	}

	[Token(Token = "0x60022CA")]
	[Address(RVA = "0x8446C0", Offset = "0x8434C0", Length = "0x4B")]
	public string GetTitleToDisplayWhenSelected()
	{
		return null;
	}

	[Token(Token = "0x60022CB")]
	[Address(RVA = "0x844710", Offset = "0x843510", Length = "0xCC6")]
	public string GetTextToDisplayWhenSelected()
	{
		return null;
	}

	[Token(Token = "0x60022CC")]
	[Address(RVA = "0x8453E0", Offset = "0x8441E0", Length = "0x64")]
	public string GetDescriptionToDisplayOnInventoryScreen()
	{
		return null;
	}

	[Token(Token = "0x60022CD")]
	[Address(RVA = "0x845450", Offset = "0x844250", Length = "0x122")]
	public ItemWeight GetItemWeightKG(bool ignoreClothingBonus = false)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x60022CE")]
	[Address(RVA = "0x845580", Offset = "0x844380", Length = "0x14")]
	public ItemWeight GetSingleItemWeightKG(bool ignoreClothingBonus = false)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x60022CF")]
	[Address(RVA = "0x8455A0", Offset = "0x8443A0", Length = "0xA39")]
	public ItemWeight GetItemWeightKG(float stackMultiplier, bool ignoreClothingBonus = false)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x60022D0")]
	[Address(RVA = "0x845FE0", Offset = "0x844DE0", Length = "0x39")]
	public static float CalculateLiquidVolume(float kilograms, LiquidType liquidType)
	{
		return 0f;
	}

	[Token(Token = "0x60022D1")]
	[Address(RVA = "0x846020", Offset = "0x844E20", Length = "0xF6")]
	private void SyncAudioValues(GameObject source)
	{
	}

	[Token(Token = "0x60022D2")]
	[Address(RVA = "0x846120", Offset = "0x844F20", Length = "0xAA")]
	public uint Play3DSound(AK.Wwise.Event wwevent, GameObject source)
	{
		return 0u;
	}

	[Token(Token = "0x60022D3")]
	[Address(RVA = "0x8461D0", Offset = "0x844FD0", Length = "0xAA")]
	public uint PlaySound(AK.Wwise.Event wwevent, GameObject source)
	{
		return 0u;
	}

	[Token(Token = "0x60022D4")]
	[Address(RVA = "0x846280", Offset = "0x845080", Length = "0x223")]
	public void PlayPickUpClip()
	{
	}

	[Token(Token = "0x60022D5")]
	[Address(RVA = "0x8464B0", Offset = "0x8452B0", Length = "0x93")]
	public string GetDisplayNameWithoutConditionForInventoryInterfaces()
	{
		return null;
	}

	[Token(Token = "0x60022D6")]
	[Address(RVA = "0x846550", Offset = "0x845350", Length = "0x56")]
	public string GetDisplayNameForInventoryInterfaces()
	{
		return null;
	}

	[Token(Token = "0x60022D7")]
	[Address(RVA = "0x8465B0", Offset = "0x8453B0", Length = "0x163")]
	public string GetBasicDisplayNameForInventoryInterfaces()
	{
		return null;
	}

	[Token(Token = "0x60022D8")]
	[Address(RVA = "0x846720", Offset = "0x845520", Length = "0xAD3")]
	public GearItem Drop(int numUnits, bool playSound = true, bool stickToFeet = true, bool force = false)
	{
		return null;
	}

	[Token(Token = "0x60022D9")]
	[Address(RVA = "0x847200", Offset = "0x846000", Length = "0x483")]
	public GearItem InstantiateStackable(int numUnits)
	{
		return null;
	}

	[Token(Token = "0x60022DA")]
	[Address(RVA = "0x847690", Offset = "0x846490", Length = "0x1D2")]
	public static GameObject InstantiateWater(GameObject prefab, ItemLiquidVolume volume, LiquidType type)
	{
		return null;
	}

	[Token(Token = "0x60022DB")]
	[Address(RVA = "0x847870", Offset = "0x846670", Length = "0x223")]
	public static GameObject InstantiateDepletedGearPrefab(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x60022DC")]
	[Address(RVA = "0x847AA0", Offset = "0x8468A0", Length = "0x13B")]
	public void ToggleColliders(bool enable)
	{
	}

	[Token(Token = "0x60022DD")]
	[Address(RVA = "0x847BE0", Offset = "0x8469E0", Length = "0x47")]
	public float GetNormalizedCondition()
	{
		return 0f;
	}

	[Token(Token = "0x60022DE")]
	[Address(RVA = "0x847C30", Offset = "0x846A30", Length = "0x42")]
	public float GetNormalizedCondition(float hp)
	{
		return 0f;
	}

	[Token(Token = "0x60022DF")]
	[Address(RVA = "0x847C80", Offset = "0x846A80", Length = "0x136")]
	public bool IsGearType(GearType type)
	{
		return false;
	}

	[Token(Token = "0x60022E0")]
	[Address(RVA = "0x847DC0", Offset = "0x846BC0", Length = "0x1F7")]
	public bool IsAnyGearType(GearType types)
	{
		return false;
	}

	[Token(Token = "0x60022E1")]
	[Address(RVA = "0x847FC0", Offset = "0x846DC0", Length = "0xF5")]
	public bool IsLitFlare()
	{
		return false;
	}

	[Token(Token = "0x60022E2")]
	[Address(RVA = "0x8480C0", Offset = "0x846EC0", Length = "0xFD")]
	public bool IsLitFlareGunRound()
	{
		return false;
	}

	[Token(Token = "0x60022E3")]
	[Address(RVA = "0x8481C0", Offset = "0x846FC0", Length = "0xF8")]
	public bool IsLitFlashlight()
	{
		return false;
	}

	[Token(Token = "0x60022E4")]
	[Address(RVA = "0x8482C0", Offset = "0x8470C0", Length = "0xF6")]
	public bool IsLitLamp()
	{
		return false;
	}

	[Token(Token = "0x60022E5")]
	[Address(RVA = "0x8483C0", Offset = "0x8471C0", Length = "0xF3")]
	public bool IsLitMatch()
	{
		return false;
	}

	[Token(Token = "0x60022E6")]
	[Address(RVA = "0x8484C0", Offset = "0x8472C0", Length = "0xF5")]
	public bool IsLitNoiseMaker()
	{
		return false;
	}

	[Token(Token = "0x60022E7")]
	[Address(RVA = "0x8485C0", Offset = "0x8473C0", Length = "0xF6")]
	public bool IsLitTorch()
	{
		return false;
	}

	[Token(Token = "0x60022E8")]
	[Address(RVA = "0x8486C0", Offset = "0x8474C0", Length = "0x55")]
	public bool IsLitLightsource()
	{
		return false;
	}

	[Token(Token = "0x60022E9")]
	[Address(RVA = "0x848720", Offset = "0x847520", Length = "0xF7")]
	public void ExtinguishLitItem()
	{
	}

	[Token(Token = "0x60022EA")]
	[Address(RVA = "0x848820", Offset = "0x847620", Length = "0x8")]
	public bool IsWornOut()
	{
		return false;
	}

	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x848830", Offset = "0x847630", Length = "0x5F")]
	public void ForceWornOut()
	{
	}

	[Token(Token = "0x60022EC")]
	[Address(RVA = "0x848890", Offset = "0x847690", Length = "0x8")]
	public void ForceNotWornOut()
	{
	}

	[Token(Token = "0x60022ED")]
	[Address(RVA = "0x8488A0", Offset = "0x8476A0", Length = "0xEF")]
	public FPSItem GetFPSItem()
	{
		return null;
	}

	[Token(Token = "0x60022EE")]
	[Address(RVA = "0x848990", Offset = "0x847790", Length = "0x108")]
	public Color GetColorBasedOnCondition()
	{
		return default(Color);
	}

	[Token(Token = "0x60022EF")]
	[Address(RVA = "0x848AA0", Offset = "0x8478A0", Length = "0x74")]
	public string GetColorStringBasedOnCondition()
	{
		return null;
	}

	[Token(Token = "0x60022F0")]
	[Address(RVA = "0x848B20", Offset = "0x847920", Length = "0x33")]
	public int GetRoundedCondition()
	{
		return 0;
	}

	[Token(Token = "0x60022F1")]
	[Address(RVA = "0x848B60", Offset = "0x847960", Length = "0x10")]
	public int GetRoundedCondition(float normalizedCondition)
	{
		return 0;
	}

	[Token(Token = "0x60022F2")]
	[Address(RVA = "0x848B70", Offset = "0x847970", Length = "0x7")]
	public void SetHaltDecay(bool haltDecay)
	{
	}

	[Token(Token = "0x60022F3")]
	[Address(RVA = "0x848B80", Offset = "0x847980", Length = "0x211")]
	public bool RollForFoodPoisoning(float startingCalories)
	{
		return false;
	}

	[Token(Token = "0x60022F4")]
	[Address(RVA = "0x848DA0", Offset = "0x847BA0", Length = "0x7B0")]
	public void ApplyBuffs(float normalizedValue)
	{
	}

	[Token(Token = "0x60022F5")]
	[Address(RVA = "0x849560", Offset = "0x848360", Length = "0xC44")]
	public string GetItemPostFixForInventoryInterfaces()
	{
		return null;
	}

	[Token(Token = "0x60022F6")]
	[Address(RVA = "0x84A1B0", Offset = "0x848FB0", Length = "0x3D1")]
	public void MaybeAdjustTransformWithDropDummy()
	{
	}

	[Token(Token = "0x60022F7")]
	[Address(RVA = "0x84A590", Offset = "0x849390", Length = "0x2C4")]
	private Vector3 UpdateOrientationForCorpse(ref RaycastHit hit, Vector3 desiredNormal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60022F8")]
	[Address(RVA = "0x84A860", Offset = "0x849660", Length = "0x84B")]
	public bool StickToGroundAndOrientOnSlope(Vector3 desiredPosition, NavMeshCheck navMeshCheck, float verticalOffset, bool ignoreCorpseLayer = false)
	{
		return false;
	}

	[Token(Token = "0x60022F9")]
	[Address(RVA = "0x84B0B0", Offset = "0x849EB0", Length = "0x32F")]
	public bool StickToGroundAtPlayerFeet(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x60022FA")]
	[Address(RVA = "0x5027A0", Offset = "0x5015A0", Length = "0x5")]
	public bool IsInsideContainer()
	{
		return false;
	}

	[Token(Token = "0x60022FB")]
	[Address(RVA = "0x84B3E0", Offset = "0x84A1E0", Length = "0x8")]
	public void SkipSpawnChanceRoll()
	{
	}

	[Token(Token = "0x60022FC")]
	[Address(RVA = "0x84B3F0", Offset = "0x84A1F0", Length = "0xED")]
	public void SkipSpawnChanceRollInitialDecayAndAutoEvolve()
	{
	}

	[Token(Token = "0x60022FD")]
	[Address(RVA = "0x84B4E0", Offset = "0x84A2E0", Length = "0x48A")]
	public void DisablePhysics()
	{
	}

	[Token(Token = "0x60022FE")]
	[Address(RVA = "0x84B970", Offset = "0x84A770", Length = "0x8")]
	public void MarkAsHarvested()
	{
	}

	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x84B980", Offset = "0x84A780", Length = "0x2E")]
	public bool WasHarvested()
	{
		return false;
	}

	[Token(Token = "0x6002300")]
	[Address(RVA = "0x84B9B0", Offset = "0x84A7B0", Length = "0x100")]
	public void CopyHarvestedState(GearItem gi)
	{
	}

	[Token(Token = "0x6002301")]
	[Address(RVA = "0x84BAC0", Offset = "0x84A8C0", Length = "0x57")]
	public float GetDamageBlendValue()
	{
		return 0f;
	}

	[Token(Token = "0x6002302")]
	[Address(RVA = "0x84BB20", Offset = "0x84A920", Length = "0x4C")]
	public float GetDamageBlendValue(float hp)
	{
		return 0f;
	}

	[Token(Token = "0x6002303")]
	[Address(RVA = "0x84BB70", Offset = "0x84A970", Length = "0x3C8")]
	public void SetDamageBlendValue(float blendVal)
	{
	}

	[Token(Token = "0x6002304")]
	[Address(RVA = "0x84BF40", Offset = "0x84AD40", Length = "0xBA")]
	public void UpdateDamageShader()
	{
	}

	[Token(Token = "0x6002305")]
	[Address(RVA = "0x84C000", Offset = "0x84AE00", Length = "0x275")]
	public void DropIntoWater(Collider collider, float waterY)
	{
	}

	[Token(Token = "0x6002306")]
	[Address(RVA = "0x84C280", Offset = "0x84B080", Length = "0x143")]
	public bool IsIndestructibleRespirator()
	{
		return false;
	}

	[Token(Token = "0x6002307")]
	[Address(RVA = "0x84C3D0", Offset = "0x84B1D0", Length = "0x156")]
	public bool IsUndegradableAccelerant()
	{
		return false;
	}

	[Token(Token = "0x6002308")]
	[Address(RVA = "0x84C530", Offset = "0x84B330", Length = "0x7")]
	public void MarkForNextUpdateDestroy(bool value)
	{
	}

	[Token(Token = "0x6002309")]
	[Address(RVA = "0x84C540", Offset = "0x84B340", Length = "0x8")]
	public bool IsMarkedForNextUpdateDestroy()
	{
		return false;
	}

	[Token(Token = "0x600230A")]
	[Address(RVA = "0x84C550", Offset = "0x84B350", Length = "0x9")]
	public void SetDecayScale(float scale)
	{
	}

	[Token(Token = "0x600230B")]
	[Address(RVA = "0x84C560", Offset = "0x84B360", Length = "0x171")]
	public void MaybePlayCookingSlotPlacementAudio(GearPlacePoint placePoint)
	{
	}

	[Token(Token = "0x600230C")]
	[Address(RVA = "0x84C6E0", Offset = "0x84B4E0", Length = "0x494")]
	public void SetPlacePoint(GearPlacePoint placePoint)
	{
	}

	[Token(Token = "0x600230D")]
	[Address(RVA = "0x84CB80", Offset = "0x84B980", Length = "0x2C0")]
	public void RollSeededGearConditionAndWeight()
	{
	}

	[Token(Token = "0x600230E")]
	[Address(RVA = "0x84CE50", Offset = "0x84BC50", Length = "0x26")]
	public void RollGearConditionAndWeight()
	{
	}

	[Token(Token = "0x600230F")]
	[Address(RVA = "0x84CE80", Offset = "0x84BC80", Length = "0x87")]
	public void RollGearCondition(GearStartCondition gearStartCondition)
	{
	}

	[Token(Token = "0x6002310")]
	[Address(RVA = "0x84CF10", Offset = "0x84BD10", Length = "0x270")]
	private void MaybeRollRandomWeightAndCalories()
	{
	}

	[Token(Token = "0x6002311")]
	[Address(RVA = "0x84D190", Offset = "0x84BF90", Length = "0x426")]
	private void MaybeFallIntoWater()
	{
	}

	[Token(Token = "0x6002312")]
	[Address(RVA = "0x84D5C0", Offset = "0x84C3C0", Length = "0x10E")]
	private void RollSpawnChance()
	{
	}

	[Token(Token = "0x6002313")]
	[Address(RVA = "0x84D6D0", Offset = "0x84C4D0", Length = "0x13E")]
	private string GetItemPrefixForInventoryInterfaces(bool condition)
	{
		return null;
	}

	[Token(Token = "0x6002314")]
	[Address(RVA = "0x84D810", Offset = "0x84C610", Length = "0x7F")]
	private void InitializeLastUpdatedTodHours()
	{
	}

	[Token(Token = "0x6002315")]
	[Address(RVA = "0x84D890", Offset = "0x84C690", Length = "0x135")]
	private void ManualStart()
	{
	}

	[Token(Token = "0x6002316")]
	[Address(RVA = "0x84D9D0", Offset = "0x84C7D0", Length = "0x58B")]
	private void DecayOverTODHours(float deltaTODHours, float scale)
	{
	}

	[Token(Token = "0x6002317")]
	[Address(RVA = "0x84DF60", Offset = "0x84CD60", Length = "0x30D")]
	private bool MaybePlaceGear()
	{
		return false;
	}

	[Token(Token = "0x6002318")]
	[Address(RVA = "0x84E270", Offset = "0x84D070", Length = "0x3BA")]
	public void ApplyForce(Vector3 force, Vector3 torgue)
	{
	}

	[Token(Token = "0x6002319")]
	[Address(RVA = "0x84E630", Offset = "0x84D430", Length = "0xBE")]
	public GearItem Clone()
	{
		return null;
	}

	[Token(Token = "0x600231A")]
	[Address(RVA = "0x84E6F0", Offset = "0x84D4F0", Length = "0x25B")]
	public void EnablePhysics()
	{
	}

	[Token(Token = "0x600231B")]
	[Address(RVA = "0x84E950", Offset = "0x84D750", Length = "0x2A9")]
	public bool IsWeapon()
	{
		return false;
	}

	[Token(Token = "0x600231C")]
	[Address(RVA = "0x84EC00", Offset = "0x84DA00", Length = "0x251")]
	public bool IsGunOrAmmoOrCasingOfType(GunType gunType)
	{
		return false;
	}

	[Token(Token = "0x600231D")]
	[Address(RVA = "0x84EE60", Offset = "0x84DC60", Length = "0x22C")]
	public bool IsTwoHandedWeapon()
	{
		return false;
	}

	[Token(Token = "0x600231E")]
	[Address(RVA = "0x84F090", Offset = "0x84DE90", Length = "0x109")]
	public bool IsDummy()
	{
		return false;
	}

	[Token(Token = "0x600231F")]
	[Address(RVA = "0x84F1A0", Offset = "0x84DFA0", Length = "0x127")]
	public bool Equals(GearItem other)
	{
		return false;
	}

	[Token(Token = "0x6002320")]
	[Address(RVA = "0x84F2D0", Offset = "0x84E0D0", Length = "0xD32")]
	public void DisableTextureStreaming(bool disable)
	{
	}

	[Token(Token = "0x6002321")]
	[Address(RVA = "0x850010", Offset = "0x84EE10", Length = "0x325")]
	private Vector3 GetDefaultLocalScale()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002322")]
	[Address(RVA = "0x850340", Offset = "0x84F140", Length = "0x98")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002323")]
	[Address(RVA = "0x8503E0", Offset = "0x84F1E0", Length = "0x110")]
	public static string GetGearDisplayName(string gearPrefabName)
	{
		return null;
	}

	[Token(Token = "0x6002324")]
	[Address(RVA = "0x8504F0", Offset = "0x84F2F0", Length = "0x7")]
	public string GetCraftingDisplayName()
	{
		return null;
	}

	[Token(Token = "0x6002325")]
	[Address(RVA = "0x850500", Offset = "0x84F300", Length = "0x4E")]
	public Texture2D GetInventoryIconTexture()
	{
		return null;
	}

	[Token(Token = "0x6002326")]
	[Address(RVA = "0x549450", Offset = "0x548250", Length = "0x8")]
	public StackableItem GetStackableItem()
	{
		return null;
	}

	[Token(Token = "0x6002327")]
	[Address(RVA = "0x850550", Offset = "0x84F350", Length = "0x7")]
	public string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6002328")]
	[Address(RVA = "0x850560", Offset = "0x84F360", Length = "0x116")]
	public InProgressCraftItem InitializeCraftInProgress()
	{
		return null;
	}

	[Token(Token = "0x6002329")]
	[Address(RVA = "0x850680", Offset = "0x84F480", Length = "0x1E6")]
	public bool IsConsideredClothing()
	{
		return false;
	}

	[Token(Token = "0x600232A")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool AllowedInInventory()
	{
		return false;
	}

	[Token(Token = "0x600232B")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	public PlaceMeshRules GetPlacementRules()
	{
		return default(PlaceMeshRules);
	}

	[Token(Token = "0x6002332")]
	[Address(RVA = "0x850990", Offset = "0x84F790", Length = "0x151")]
	public void InitializeInteraction()
	{
	}

	[Token(Token = "0x6002333")]
	[Address(RVA = "0x850AF0", Offset = "0x84F8F0", Length = "0x2C7")]
	private string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x6002334")]
	[Address(RVA = "0x850DC0", Offset = "0x84FBC0", Length = "0x6AC")]
	private string GetHoverStateText()
	{
		return null;
	}

	[Token(Token = "0x6002335")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdateInteraction()
	{
	}

	[Token(Token = "0x6002336")]
	[Address(RVA = "0x851470", Offset = "0x850270", Length = "0x682")]
	public bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6002337")]
	[Address(RVA = "0x851B00", Offset = "0x850900", Length = "0x6E")]
	public bool PerformAlternativeInteraction()
	{
		return false;
	}

	[Token(Token = "0x6002338")]
	[Address(RVA = "0x851B70", Offset = "0x850970", Length = "0x1DE")]
	private bool MaybePickUpItem()
	{
		return false;
	}

	[Token(Token = "0x6002339")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void HideInteraction()
	{
	}

	[Token(Token = "0x600233A")]
	[Address(RVA = "0x851D50", Offset = "0x850B50", Length = "0xCE")]
	public GameObject GetInteractiveObject()
	{
		return null;
	}

	[Token(Token = "0x600233B")]
	[Address(RVA = "0x851E20", Offset = "0x850C20", Length = "0x2A")]
	public void SetInteractive(bool interactive, bool invisibleToRaycasts)
	{
	}

	[Token(Token = "0x600233C")]
	[Address(RVA = "0x851E50", Offset = "0x850C50", Length = "0x1A7")]
	public bool CanLightTorch()
	{
		return false;
	}

	[Token(Token = "0x600233D")]
	[Address(RVA = "0x852000", Offset = "0x850E00", Length = "0x17B")]
	public static GearItem LoadGearItemPrefab(string name)
	{
		return null;
	}

	[Token(Token = "0x600233E")]
	[Address(RVA = "0x852180", Offset = "0x850F80", Length = "0x93")]
	public static GearItem InstantiateGearItem(string prefabName)
	{
		return null;
	}

	[Token(Token = "0x600233F")]
	[Address(RVA = "0x852220", Offset = "0x851020", Length = "0x93")]
	public static GearItem InstantiateGearItem(AssetReference assetReference)
	{
		return null;
	}

	[Token(Token = "0x6002340")]
	[Address(RVA = "0x8522C0", Offset = "0x8510C0", Length = "0xF1")]
	public static GearItem InstantiateAndDeserializeGearItem(string prefabName, string serializedGearItem, Transform parent = null, bool applyPositioningFix = false, bool instantiatedInContainer = false)
	{
		return null;
	}

	[Token(Token = "0x6002341")]
	[Address(RVA = "0x8523C0", Offset = "0x8511C0", Length = "0x171")]
	public static GearItem InstantiateAndDeserializeGearItem(string prefabName, GearItemSaveDataProxy proxy, Transform parent = null, bool applyPositioningFix = false, bool instantiatedInContainer = false)
	{
		return null;
	}

	[Token(Token = "0x6002342")]
	[Address(RVA = "0x852540", Offset = "0x851340", Length = "0xF1")]
	public static GearItem InstantiateAndDeserializeGearItem(AssetReference assetReference, string serializedGearItem, Transform parent = null, bool applyPositioningFix = false, bool instantiatedInContainer = false)
	{
		return null;
	}

	[Token(Token = "0x6002343")]
	[Address(RVA = "0x852640", Offset = "0x851440", Length = "0x171")]
	public static GearItem InstantiateAndDeserializeGearItem(AssetReference assetReference, GearItemSaveDataProxy proxy, Transform parent = null, bool applyPositioningFix = false, bool instantiatedInContainer = false)
	{
		return null;
	}

	[Token(Token = "0x6002344")]
	[Address(RVA = "0x8527C0", Offset = "0x8515C0", Length = "0x57")]
	public GearItem()
	{
	}
}
