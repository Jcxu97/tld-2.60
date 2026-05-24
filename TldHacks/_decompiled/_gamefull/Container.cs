using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas;
using TLD.Gear;
using TLD.Gear.Migration;
using TLD.IntBackedUnit;
using TLD.Logging;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000562")]
public class Container : MonoBehaviour, NCUtils.IItemRequirementsCollection
{
	[HideInInspector]
	[Token(Token = "0x400319A")]
	[FieldOffset(Offset = "0x20")]
	public List<GearItemObject> m_Items;

	[HideInInspector]
	[Token(Token = "0x400319B")]
	[FieldOffset(Offset = "0x28")]
	public List<DecorationItem> m_DecorationItems;

	[HideInInspector]
	[Token(Token = "0x400319C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject[] m_ScriptedItemPrefabs;

	[HideInInspector]
	[Token(Token = "0x400319D")]
	[FieldOffset(Offset = "0x38")]
	public GameModeFilter[] m_ScriptedItemFilter;

	[HideInInspector]
	[Token(Token = "0x400319E")]
	[FieldOffset(Offset = "0x40")]
	public string m_ContainerFilterName;

	[HideInInspector]
	[Token(Token = "0x400319F")]
	[FieldOffset(Offset = "0x48")]
	public string m_ContainerSortName;

	[HideInInspector]
	[Token(Token = "0x40031A0")]
	[FieldOffset(Offset = "0x50")]
	public bool m_DestoryPending;

	[HideInInspector]
	[Token(Token = "0x40031A1")]
	[FieldOffset(Offset = "0x51")]
	public bool m_Restored;

	[HideInInspector]
	[Token(Token = "0x40031A2")]
	[FieldOffset(Offset = "0x52")]
	public bool m_MarkedInactiveInSaveData;

	[Header("Localization")]
	[SerializeField]
	[Token(Token = "0x40031A3")]
	[FieldOffset(Offset = "0x58")]
	private LocalizedString m_LocalizedDisplayName;

	[SerializeField]
	[Token(Token = "0x40031A4")]
	[FieldOffset(Offset = "0x60")]
	private LocalizedString m_EmptyPostfixOverride;

	[SerializeField]
	[Token(Token = "0x40031A5")]
	[FieldOffset(Offset = "0x68")]
	private LocalizedString m_SearchedPostfixOverride;

	[Header("General")]
	[Token(Token = "0x40031A6")]
	[FieldOffset(Offset = "0x70")]
	public ItemWeight m_Capacity;

	[Token(Token = "0x40031A7")]
	[FieldOffset(Offset = "0x78")]
	public float m_SpawnChance;

	[Token(Token = "0x40031A8")]
	[FieldOffset(Offset = "0x7C")]
	public bool m_IsCorpse;

	[Token(Token = "0x40031A9")]
	[FieldOffset(Offset = "0x7D")]
	public bool m_CanStickToGroundAfterBreakdown;

	[SerializeField]
	[Token(Token = "0x40031AA")]
	[FieldOffset(Offset = "0x7E")]
	private bool m_DisableSerialization;

	[SerializeField]
	[Token(Token = "0x40031AB")]
	[FieldOffset(Offset = "0x7F")]
	private bool m_AllowDropAll;

	[SerializeField]
	[Token(Token = "0x40031AC")]
	[FieldOffset(Offset = "0x80")]
	private bool m_AllowDeployDecorationItem;

	[Header("Custom")]
	[Token(Token = "0x40031AD")]
	[FieldOffset(Offset = "0x84")]
	public InventoryFilterType m_DefaultFilter;

	[Token(Token = "0x40031AE")]
	[FieldOffset(Offset = "0x88")]
	public bool m_FilterLocked;

	[Token(Token = "0x40031AF")]
	[FieldOffset(Offset = "0x8C")]
	public GearType m_ShowOnlyGearType;

	[Token(Token = "0x40031B0")]
	[FieldOffset(Offset = "0x90")]
	public bool m_OnlyShowSpecifiedGearType;

	[Token(Token = "0x40031B1")]
	[FieldOffset(Offset = "0x94")]
	public ContainerSelectionMode m_StartSelectionMode;

	[Token(Token = "0x40031B2")]
	[FieldOffset(Offset = "0x98")]
	public bool m_StartInspected;

	[Header("Audio")]
	[Token(Token = "0x40031B3")]
	[FieldOffset(Offset = "0xA0")]
	public string m_OpenAudio;

	[Token(Token = "0x40031B4")]
	[FieldOffset(Offset = "0xA8")]
	public string m_CloseAudio;

	[Token(Token = "0x40031B5")]
	[FieldOffset(Offset = "0xB0")]
	public string m_SearchAudio;

	[Header("Loot Tables")]
	[SerializeField]
	[MigratedLootTable("m_LootTablePrefab")]
	[Token(Token = "0x40031B6")]
	[FieldOffset(Offset = "0xB8")]
	private LootTableData m_LootTableData;

	[SerializeField]
	[MigratedLootTable("m_LockedLootTablePrefab")]
	[Token(Token = "0x40031B7")]
	[FieldOffset(Offset = "0xC0")]
	private LootTableData m_LockedLootTableData;

	[SerializeField]
	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x40031B8")]
	[FieldOffset(Offset = "0xC8")]
	private LootTable m_LootTablePrefab;

	[SerializeField]
	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x40031B9")]
	[FieldOffset(Offset = "0xD0")]
	private LootTable m_LockedLootTablePrefab;

	[Header("Loot")]
	[Token(Token = "0x40031BA")]
	[FieldOffset(Offset = "0xD8")]
	public float m_ChanceEmpty;

	[Token(Token = "0x40031BB")]
	[FieldOffset(Offset = "0xDC")]
	public int m_MinRandomItems;

	[Token(Token = "0x40031BC")]
	[FieldOffset(Offset = "0xE0")]
	public int m_MaxRandomItems;

	[Token(Token = "0x40031BD")]
	[FieldOffset(Offset = "0xE4")]
	public int m_MinRandomItemsLocked;

	[Token(Token = "0x40031BE")]
	[FieldOffset(Offset = "0xE8")]
	public int m_MaxRandomItemsLocked;

	[Token(Token = "0x40031BF")]
	[FieldOffset(Offset = "0xEC")]
	public bool m_SkipInspectVO;

	[Header("Decay")]
	[Range(0f, 1f)]
	[Token(Token = "0x40031C0")]
	[FieldOffset(Offset = "0xF0")]
	public float m_DecayScalar;

	[Header("Mission")]
	[Token(Token = "0x40031C1")]
	[FieldOffset(Offset = "0xF8")]
	public string m_MissionSupplyObjectiveId;

	[HideInInspector]
	[Token(Token = "0x40031C2")]
	[FieldOffset(Offset = "0x100")]
	public MissionObjectIdentifier m_MissionObject;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40031C3")]
	[FieldOffset(Offset = "0x108")]
	private PanelReference<Panel_Container> m_ContainerPanel;

	[Header("Weight based sub meshes")]
	[SerializeField]
	[Token(Token = "0x40031C4")]
	[FieldOffset(Offset = "0x110")]
	private SkinnedMeshRenderer m_SkinnedMeshRenderers;

	[SerializeField]
	[Token(Token = "0x40031C5")]
	[FieldOffset(Offset = "0x118")]
	private List<GameObject> m_DynamicMeshPieces;

	[Token(Token = "0x40031C6")]
	[FieldOffset(Offset = "0x120")]
	protected bool m_Inspected;

	[Token(Token = "0x40031C7")]
	[FieldOffset(Offset = "0x121")]
	private bool m_CanNeverBeOpened;

	[Token(Token = "0x40031C8")]
	[FieldOffset(Offset = "0x128")]
	private Lock m_Lock;

	[Token(Token = "0x40031C9")]
	[FieldOffset(Offset = "0x130")]
	private SafeCracking m_Safe;

	[Token(Token = "0x40031CA")]
	[FieldOffset(Offset = "0x138")]
	private bool m_RolledSpawnChance;

	[Token(Token = "0x40031CB")]
	[FieldOffset(Offset = "0x139")]
	private bool m_NotPopulated;

	[Token(Token = "0x40031CC")]
	[FieldOffset(Offset = "0x13A")]
	protected bool m_SearchInProgress;

	[Token(Token = "0x40031CD")]
	[FieldOffset(Offset = "0x13B")]
	protected bool m_OpenInProgress;

	[Token(Token = "0x40031CE")]
	[FieldOffset(Offset = "0x140")]
	private LootTableData m_LootTable;

	[Token(Token = "0x40031CF")]
	[FieldOffset(Offset = "0x148")]
	private bool m_PendingClose;

	[Token(Token = "0x40031D0")]
	[FieldOffset(Offset = "0x149")]
	private bool m_IsAnimating;

	[Token(Token = "0x40031D1")]
	[FieldOffset(Offset = "0x150")]
	private ObjectAnim[] m_ObjectAnims;

	[Token(Token = "0x40031D2")]
	[FieldOffset(Offset = "0x158")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40031D3")]
	[FieldOffset(Offset = "0x15C")]
	private uint m_SearchAudioID;

	[Token(Token = "0x40031D4")]
	[FieldOffset(Offset = "0x160")]
	private readonly List<GameObject> m_GearToInstantiate;

	[Token(Token = "0x40031D5")]
	private static readonly ContainerSaveDataProxy m_ContainerSaveDataProxy;

	[Token(Token = "0x40031D6")]
	private const int CONTAINER_ITEM_SAVE_DATA_POOL_LEN = 512;

	[Token(Token = "0x40031D7")]
	private static readonly ContainerItemSaveData[] m_ContainerItemSaveDataPool;

	[Token(Token = "0x40031D8")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x170002A5")]
	public bool DisableSerialization
	{
		[Token(Token = "0x600292A")]
		[Address(RVA = "0x8DFB80", Offset = "0x8DE980", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002A6")]
	public bool AllowDropAll
	{
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x8DFB90", Offset = "0x8DE990", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002A7")]
	public bool AllowDeployDecorationItem
	{
		[Token(Token = "0x600292C")]
		[Address(RVA = "0x644520", Offset = "0x643320", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170002A8")]
	public LocalizedString LocalizedDisplayName
	{
		[Token(Token = "0x600292D")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A9")]
	public LocalizedString EmptyPostfixOverride
	{
		[Token(Token = "0x600292E")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002AA")]
	public LocalizedString SearchedPostfixOverride
	{
		[Token(Token = "0x600292F")]
		[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002930")]
	[Address(RVA = "0x8DFBA0", Offset = "0x8DE9A0", Length = "0x1ED")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002931")]
	[Address(RVA = "0x8DFD90", Offset = "0x8DEB90", Length = "0x4CD")]
	public void Start()
	{
	}

	[Token(Token = "0x6002932")]
	[Address(RVA = "0x8E0260", Offset = "0x8DF060", Length = "0x147")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6002933")]
	[Address(RVA = "0x8E03B0", Offset = "0x8DF1B0", Length = "0xD5")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6002934")]
	[Address(RVA = "0x8E0490", Offset = "0x8DF290", Length = "0x221")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002935")]
	[Address(RVA = "0x8E06C0", Offset = "0x8DF4C0", Length = "0x1C0")]
	public void UpdateContainer()
	{
	}

	[Token(Token = "0x6002936")]
	[Address(RVA = "0x8E0890", Offset = "0x8DF690", Length = "0x110C")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002937")]
	[Address(RVA = "0x8E19A0", Offset = "0x8E07A0", Length = "0x1202")]
	public void Deserialize(string text, List<GearItem> loadedItems)
	{
	}

	[Token(Token = "0x6002938")]
	[Address(RVA = "0x8E2BB0", Offset = "0x8E19B0", Length = "0x7BD")]
	public void DeserializeAdditive(string text, List<GearItem> loadedItems)
	{
	}

	[Token(Token = "0x6002939")]
	[Address(RVA = "0x8E3370", Offset = "0x8E2170", Length = "0xC1")]
	public void AssumeMissionObjectResponsibility(string missionObjectSerialized)
	{
	}

	[Token(Token = "0x600293A")]
	[Address(RVA = "0x8E3440", Offset = "0x8E2240", Length = "0x226")]
	public void MaybeDestroyContainerAfterMission()
	{
	}

	[Token(Token = "0x600293B")]
	[Address(RVA = "0x8E3670", Offset = "0x8E2470", Length = "0x363")]
	public static void DeserializeContentsToPos(string text, Vector3 pos, List<GearItem> loadedItems)
	{
	}

	[Token(Token = "0x600293C")]
	[Address(RVA = "0x8E39E0", Offset = "0x8E27E0", Length = "0x54C")]
	public void AddGear(GearItem gi)
	{
	}

	[Token(Token = "0x600293D")]
	[Address(RVA = "0x8E3F30", Offset = "0x8E2D30", Length = "0xB")]
	public void RemoveGear(GearItem gi)
	{
	}

	[Token(Token = "0x600293E")]
	[Address(RVA = "0x8E3F40", Offset = "0x8E2D40", Length = "0x410")]
	public void RemoveGear(GearItem gi, bool toInventory)
	{
	}

	[Token(Token = "0x600293F")]
	[Address(RVA = "0x8E4360", Offset = "0x8E3160", Length = "0x18A")]
	public void AddDecorationItem(DecorationItem di)
	{
	}

	[Token(Token = "0x6002940")]
	[Address(RVA = "0x8E44F0", Offset = "0x8E32F0", Length = "0x1BA")]
	public void RemoveDecorationItem(DecorationItem di)
	{
	}

	[Token(Token = "0x6002941")]
	[Address(RVA = "0x8E46B0", Offset = "0x8E34B0", Length = "0xB9")]
	public void DestroyDecoration(DecorationItem di)
	{
	}

	[Token(Token = "0x6002942")]
	[Address(RVA = "0x8E4770", Offset = "0x8E3570", Length = "0x82")]
	public void DestroyGear(GearItem gi)
	{
	}

	[Token(Token = "0x6002943")]
	[Address(RVA = "0x8E4800", Offset = "0x8E3600", Length = "0x8C2")]
	public void DestroyObject(GameObject go)
	{
	}

	[Token(Token = "0x6002944")]
	[Address(RVA = "0x8E50D0", Offset = "0x8E3ED0", Length = "0x1FC")]
	public void DestroyAllGear()
	{
	}

	[Token(Token = "0x6002945")]
	[Address(RVA = "0x8E52D0", Offset = "0x8E40D0", Length = "0x1AB")]
	public ItemWeight GetTotalWeightKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6002946")]
	[Address(RVA = "0x8E5480", Offset = "0x8E4280", Length = "0x240")]
	public void ShowContainerContents(Action onContainerClosed = null)
	{
	}

	[Token(Token = "0x6002947")]
	[Address(RVA = "0x8E56D0", Offset = "0x8E44D0", Length = "0x316")]
	public void ShowItemsAfterSearch()
	{
	}

	[Token(Token = "0x6002948")]
	[Address(RVA = "0x8E59F0", Offset = "0x8E47F0", Length = "0x254")]
	public void BeginContainerOpen()
	{
	}

	[Token(Token = "0x6002949")]
	[Address(RVA = "0x8E5C50", Offset = "0x8E4A50", Length = "0x1B6")]
	public void BeginContainerClose()
	{
	}

	[Token(Token = "0x600294A")]
	[Address(RVA = "0x8E5E10", Offset = "0x8E4C10", Length = "0x57")]
	private void StopSearchAudio()
	{
	}

	[Token(Token = "0x600294B")]
	[Address(RVA = "0x8E5E70", Offset = "0x8E4C70", Length = "0x8")]
	public bool IsAnimating()
	{
		return false;
	}

	[Token(Token = "0x600294C")]
	[Address(RVA = "0x8E5E80", Offset = "0x8E4C80", Length = "0x138")]
	private void PlayAnimation(string animation)
	{
	}

	[Token(Token = "0x600294D")]
	[Address(RVA = "0x8E5FC0", Offset = "0x8E4DC0", Length = "0x135")]
	private bool IsPlayingAnimation()
	{
		return false;
	}

	[Token(Token = "0x600294E")]
	[Address(RVA = "0x8E6100", Offset = "0x8E4F00", Length = "0x590")]
	private void UpdateActiveMeshFromTotalWeight()
	{
	}

	[Token(Token = "0x600294F")]
	[Address(RVA = "0x8E66A0", Offset = "0x8E54A0", Length = "0x8")]
	public void MakeCanNeverBeOpened()
	{
	}

	[Token(Token = "0x6002950")]
	[Address(RVA = "0x8E66B0", Offset = "0x8E54B0", Length = "0x8")]
	public bool CanNeverBeOpened()
	{
		return false;
	}

	[Token(Token = "0x6002951")]
	[Address(RVA = "0x8E66C0", Offset = "0x8E54C0", Length = "0xF5")]
	public bool IsLocked()
	{
		return false;
	}

	[Token(Token = "0x6002952")]
	[Address(RVA = "0x8E67C0", Offset = "0x8E55C0", Length = "0x8")]
	public SafeCracking GetSafe()
	{
		return null;
	}

	[Token(Token = "0x6002953")]
	[Address(RVA = "0x8E67D0", Offset = "0x8E55D0", Length = "0xF2")]
	public bool IsSafeLocked()
	{
		return false;
	}

	[Token(Token = "0x6002954")]
	[Address(RVA = "0x8E68D0", Offset = "0x8E56D0", Length = "0x90")]
	public bool IsEmpty()
	{
		return false;
	}

	[Token(Token = "0x6002955")]
	[Address(RVA = "0x8E6970", Offset = "0x8E5770", Length = "0x13")]
	public bool IsInspected()
	{
		return false;
	}

	[Token(Token = "0x6002956")]
	[Address(RVA = "0x8E6990", Offset = "0x8E5790", Length = "0x8")]
	public void MarkAsInspected()
	{
	}

	[Token(Token = "0x6002957")]
	[Address(RVA = "0x8E69A0", Offset = "0x8E57A0", Length = "0x222")]
	public bool ContainsFoodItems()
	{
		return false;
	}

	[Token(Token = "0x6002958")]
	[Address(RVA = "0x8E6BD0", Offset = "0x8E59D0", Length = "0x14F")]
	public bool AddToExistingStackable(GearItem gearToAdd, float normalizedCondition, int numUnits)
	{
		return false;
	}

	[Token(Token = "0x6002959")]
	[Address(RVA = "0x8E6D20", Offset = "0x8E5B20", Length = "0xC2A")]
	private void InstantiateGearPrefabInContainer(GameObject prefab)
	{
	}

	[Token(Token = "0x600295A")]
	[Address(RVA = "0x8E7950", Offset = "0x8E6750", Length = "0x1DE")]
	public WaterSupply GetWaterSupply(LiquidQuality quality)
	{
		return null;
	}

	[Token(Token = "0x600295B")]
	[Address(RVA = "0x8E7B30", Offset = "0x8E6930", Length = "0x29")]
	public void PopulateContents()
	{
	}

	[Token(Token = "0x600295C")]
	[Address(RVA = "0x8E7B60", Offset = "0x8E6960", Length = "0x3FF")]
	private void InstantiateContents()
	{
	}

	[Token(Token = "0x600295D")]
	[Address(RVA = "0x8E7F60", Offset = "0x8E6D60", Length = "0x2A4")]
	public int GetTotalCalories()
	{
		return 0;
	}

	[Token(Token = "0x600295E")]
	[Address(RVA = "0x8E8210", Offset = "0x8E7010", Length = "0x216")]
	public bool AllFoodItemsAreNatural()
	{
		return false;
	}

	[Token(Token = "0x600295F")]
	[Address(RVA = "0x8E8430", Offset = "0x8E7230", Length = "0x2A2")]
	public float GetHoursFuel()
	{
		return 0f;
	}

	[Token(Token = "0x6002960")]
	[Address(RVA = "0x8E86E0", Offset = "0x8E74E0", Length = "0x1BD")]
	private GameObject GetPrefabFromName(string gearName)
	{
		return null;
	}

	[Token(Token = "0x6002961")]
	[Address(RVA = "0x8E88A0", Offset = "0x8E76A0", Length = "0x232")]
	private GameObject GetPrefabFromScriptedItems(string gearName)
	{
		return null;
	}

	[Token(Token = "0x6002962")]
	[Address(RVA = "0x8E8AE0", Offset = "0x8E78E0", Length = "0x2EA")]
	private void PopulateWithScriptedGear()
	{
	}

	[Token(Token = "0x6002963")]
	[Address(RVA = "0x8E8DD0", Offset = "0x8E7BD0", Length = "0xA5F")]
	private void PopulateWithRandomGear()
	{
	}

	[Token(Token = "0x6002964")]
	[Address(RVA = "0x8E9830", Offset = "0x8E8630", Length = "0x80")]
	protected void PlayContainerOpenSound()
	{
	}

	[Token(Token = "0x6002965")]
	[Address(RVA = "0x8E98C0", Offset = "0x8E86C0", Length = "0x80")]
	protected void PlayContainerCloseSound()
	{
	}

	[Token(Token = "0x6002966")]
	[Address(RVA = "0x8E9950", Offset = "0x8E8750", Length = "0x108")]
	protected void MaybePlayInspectionAudio()
	{
	}

	[Token(Token = "0x6002967")]
	[Address(RVA = "0x8E9A60", Offset = "0x8E8860", Length = "0xF")]
	public int GetNumGearWithName(string gearName)
	{
		return 0;
	}

	[Token(Token = "0x6002968")]
	[Address(RVA = "0x8E9A70", Offset = "0x8E8870", Length = "0x361")]
	public ItemWeight GetPowderItemAmount(PowderType type)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6002969")]
	[Address(RVA = "0x8E9DE0", Offset = "0x8E8BE0", Length = "0x361")]
	public ItemLiquidVolume GetLiquidItemAmount(LiquidType type)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x600296A")]
	[Address(RVA = "0x8EA150", Offset = "0x8E8F50", Length = "0xC")]
	public ItemWeight GetMeasurableTotalByType(string type)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600296B")]
	[Address(RVA = "0x8EA160", Offset = "0x8E8F60", Length = "0x1DE")]
	public void GetItems(List<GearItem> list)
	{
	}

	[Token(Token = "0x600296C")]
	[Address(RVA = "0x8EA340", Offset = "0x8E9140", Length = "0x2BD")]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[Token(Token = "0x600296D")]
	[Address(RVA = "0x8EA600", Offset = "0x8E9400", Length = "0x2DC")]
	public void GetItems(GearItemComponentFilter gearItemComponentFilter, List<GearItem> list)
	{
	}

	[Token(Token = "0x600296E")]
	[Address(RVA = "0x8EA8E0", Offset = "0x8E96E0", Length = "0x450")]
	public ICraftingResult InstantiateCraftedItem(ICraftingResult craftedItem)
	{
		return null;
	}

	[Token(Token = "0x600296F")]
	[Address(RVA = "0x8EAD40", Offset = "0x8E9B40", Length = "0x3A3")]
	public static bool HasNonSearchedContainer(GameObject owner)
	{
		return false;
	}

	[Token(Token = "0x6002970")]
	[Address(RVA = "0x8EB0F0", Offset = "0x8E9EF0", Length = "0x71C")]
	public static bool HasNonEmptyContainer(GameObject owner)
	{
		return false;
	}

	[Token(Token = "0x6002971")]
	[Address(RVA = "0x8EB810", Offset = "0x8EA610", Length = "0x241")]
	public Container()
	{
	}
}
