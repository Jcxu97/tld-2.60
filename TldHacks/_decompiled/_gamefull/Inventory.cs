using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas;
using TLD.Gameplay;
using TLD.Gear;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200089C")]
public class Inventory : MonoBehaviour, NCUtils.IItemRequirementsCollection
{
	[SerializeField]
	[Token(Token = "0x40058AE")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Inventory> m_InventoryPanel;

	[SerializeField]
	[Token(Token = "0x40058AF")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_Inventory_Examine> m_InventoryExaminePanel;

	[HideInInspector]
	[Token(Token = "0x40058B0")]
	[FieldOffset(Offset = "0x30")]
	public List<GearItemObject> m_Items;

	[HideInInspector]
	[Token(Token = "0x40058B1")]
	[FieldOffset(Offset = "0x38")]
	public List<GearItem> m_ItemsToDestroy;

	[HideInInspector]
	[Token(Token = "0x40058B2")]
	[FieldOffset(Offset = "0x40")]
	public List<DecorationItem> m_DecorationItems;

	[HideInInspector]
	[Token(Token = "0x40058B3")]
	public static readonly ItemLiquidVolume UseWaterFromGeneralSupply;

	[Token(Token = "0x40058B4")]
	public const string ITEM_ADDED_EVENT_NAME = "Inventory_ItemAdded";

	[Token(Token = "0x40058B5")]
	public const string ITEM_REMOVED_EVENT_NAME = "Inventory_ItemRemoved";

	[Token(Token = "0x40058B6")]
	public const string ITEM_EQUIPPED_EVENT_NAME = "Inventory_ItemEquipped";

	[Token(Token = "0x40058B7")]
	public const string FIRED_EQUIPPED_WEAPON_EVENT_NAME = "Inventory_FiredEquippedWeapon";

	[Tooltip("Minimum amount of water that can be added to the player's water sources. In Litres.")]
	[Token(Token = "0x40058BA")]
	[FieldOffset(Offset = "0x58")]
	public ItemLiquidVolume m_MinimumViableWaterAmount;

	[Header("Decoration Dropping")]
	[SerializeField]
	[Token(Token = "0x40058BB")]
	[FieldOffset(Offset = "0x60")]
	private AssetReferenceCustomSpawnedItem m_DroppedDecorationItem;

	[SerializeField]
	[Token(Token = "0x40058BC")]
	[FieldOffset(Offset = "0x68")]
	private float m_DroppedDecorationItemOffset;

	[SerializeField]
	[Token(Token = "0x40058BD")]
	[FieldOffset(Offset = "0x6C")]
	private float m_DecorationDropMaxHeightOffset;

	[SerializeField]
	[Token(Token = "0x40058BE")]
	[FieldOffset(Offset = "0x70")]
	private float m_DecorationDropMaxDistanceOffset;

	[Token(Token = "0x40058BF")]
	[FieldOffset(Offset = "0x78")]
	private GearItem m_WaterSupplyPotable;

	[Token(Token = "0x40058C0")]
	[FieldOffset(Offset = "0x80")]
	private GearItem m_WaterSupplyNotPotable;

	[Token(Token = "0x40058C1")]
	[FieldOffset(Offset = "0x88")]
	private ItemWeight m_WeightGeneral;

	[Token(Token = "0x40058C2")]
	[FieldOffset(Offset = "0x90")]
	private ItemWeight m_WeightMetal;

	[Token(Token = "0x40058C3")]
	[FieldOffset(Offset = "0x98")]
	private ItemWeight m_WeightWater;

	[Token(Token = "0x40058C4")]
	[FieldOffset(Offset = "0xA0")]
	private ItemWeight m_WeightWood;

	[Token(Token = "0x40058C5")]
	[FieldOffset(Offset = "0xA8")]
	private ItemWeight m_TotalWeight;

	[Token(Token = "0x40058C6")]
	[FieldOffset(Offset = "0xB0")]
	private ItemWeight m_WeightGeneral_LastSent;

	[Token(Token = "0x40058C7")]
	[FieldOffset(Offset = "0xB8")]
	private ItemWeight m_WeightMetal_LastSent;

	[Token(Token = "0x40058C8")]
	[FieldOffset(Offset = "0xC0")]
	private ItemWeight m_WeightWater_LastSent;

	[Token(Token = "0x40058C9")]
	[FieldOffset(Offset = "0xC8")]
	private ItemWeight m_WeightWood_LastSent;

	[Token(Token = "0x40058CA")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40058CB")]
	[FieldOffset(Offset = "0xD1")]
	private bool m_ForceOverrideWeight;

	[Token(Token = "0x40058CC")]
	[FieldOffset(Offset = "0xD8")]
	private ItemWeight m_OverridedWeight;

	[Token(Token = "0x40058CD")]
	[FieldOffset(Offset = "0xE0")]
	private float m_TotalScentIntensity;

	[Token(Token = "0x40058CE")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_ConsumedCoffee;

	[Token(Token = "0x40058CF")]
	[FieldOffset(Offset = "0xE5")]
	private bool m_ConsumedRosehipTea;

	[Token(Token = "0x40058D0")]
	[FieldOffset(Offset = "0xE6")]
	private bool m_ConsumedReishiTea;

	[Token(Token = "0x40058D1")]
	[FieldOffset(Offset = "0xE7")]
	private bool m_ConsumedOldMansBeardDressing;

	[Token(Token = "0x40058D2")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_SuppressScentIndicator;

	[Token(Token = "0x40058D3")]
	[FieldOffset(Offset = "0xE9")]
	private bool m_HaveAddedCookingPotItemToScatter;

	[Token(Token = "0x40058D4")]
	[FieldOffset(Offset = "0xF0")]
	private List<WeightReductionBuff> m_WeightReductionBuffs;

	[Token(Token = "0x40058D5")]
	private static InventorySaveDataProxy m_InventorySaveDataProxy;

	[Token(Token = "0x40058D6")]
	private const int INV_ITEM_SAVE_DATA_POOL_LEN = 512;

	[Token(Token = "0x40058D7")]
	private static InventoryItemSaveData[] m_InventoryItemSaveDataPool;

	[Token(Token = "0x40058D8")]
	public const int NUM_QUICK_SELECT_SLOTS = 4;

	[HideInInspector]
	[Token(Token = "0x40058D9")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject[] m_QuickSelectSlots;

	[Token(Token = "0x14000013")]
	public event Action<GearItem> m_OnInventoryItemAdded
	{
		[CompilerGenerated]
		[Token(Token = "0x6004E68")]
		[Address(RVA = "0xDA5EB0", Offset = "0xDA4CB0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004E69")]
		[Address(RVA = "0xDA6020", Offset = "0xDA4E20", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public event Action<GearItem> m_OnInventoryItemRemoved
	{
		[CompilerGenerated]
		[Token(Token = "0x6004E6A")]
		[Address(RVA = "0xDA6190", Offset = "0xDA4F90", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004E6B")]
		[Address(RVA = "0xDA6300", Offset = "0xDA5100", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6004E6C")]
	[Address(RVA = "0xDA6470", Offset = "0xDA5270", Length = "0x2A7")]
	public void Start()
	{
	}

	[Token(Token = "0x6004E6D")]
	[Address(RVA = "0xDA6720", Offset = "0xDA5520", Length = "0x327")]
	public void Update()
	{
	}

	[Token(Token = "0x6004E6E")]
	[Address(RVA = "0xDA6A50", Offset = "0xDA5850", Length = "0x6FC")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004E6F")]
	[Address(RVA = "0xDA7150", Offset = "0xDA5F50", Length = "0x247")]
	private bool TryStackingItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004E70")]
	[Address(RVA = "0xDA73A0", Offset = "0xDA61A0", Length = "0x662")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004E71")]
	[Address(RVA = "0xDA7A10", Offset = "0xDA6810", Length = "0x18F")]
	public GearItem FindByInstanceID(int id)
	{
		return null;
	}

	[Token(Token = "0x6004E72")]
	[Address(RVA = "0xDA7BA0", Offset = "0xDA69A0", Length = "0x1D3")]
	public bool GameObjectInInventory(GameObject searchItem)
	{
		return false;
	}

	[Token(Token = "0x6004E73")]
	[Address(RVA = "0xDA7D80", Offset = "0xDA6B80", Length = "0x1494")]
	public void AddGear(GearItem gi, bool enableNotificationFlag = false)
	{
	}

	[Token(Token = "0x6004E74")]
	[Address(RVA = "0xDA9320", Offset = "0xDA8120", Length = "0xB")]
	public void RemoveGear(GameObject go)
	{
	}

	[Token(Token = "0x6004E75")]
	[Address(RVA = "0xDA9330", Offset = "0xDA8130", Length = "0x43C")]
	public void RemoveGear(GameObject go, bool toContainer)
	{
	}

	[Token(Token = "0x6004E76")]
	[Address(RVA = "0xDA9770", Offset = "0xDA8570", Length = "0x57F")]
	public void AddDecoration(DecorationItem di, PlayerManager.InventoryInstantiateFlags flags = PlayerManager.InventoryInstantiateFlags.None)
	{
	}

	[Token(Token = "0x6004E77")]
	[Address(RVA = "0xDA9CF0", Offset = "0xDA8AF0", Length = "0x51")]
	public bool DecorationInInventory(DecorationItem item)
	{
		return false;
	}

	[Token(Token = "0x6004E78")]
	[Address(RVA = "0xDA9D50", Offset = "0xDA8B50", Length = "0x1EC")]
	public void RemoveDecoration(DecorationItem di)
	{
	}

	[Token(Token = "0x6004E79")]
	[Address(RVA = "0xDA9F40", Offset = "0xDA8D40", Length = "0x1BB")]
	public ItemWeight GetTotalDecorationWeight()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6004E7A")]
	[Address(RVA = "0xDAA100", Offset = "0xDA8F00", Length = "0x189")]
	public bool DropDecorationItemsAtFeet(DecorationItem decorationItem)
	{
		return false;
	}

	[Token(Token = "0x6004E7B")]
	[Address(RVA = "0xDAA290", Offset = "0xDA9090", Length = "0xAC1")]
	public bool DropDecorationItemsAtFeet(List<DecorationItem> decorationItems)
	{
		return false;
	}

	[Token(Token = "0x6004E7C")]
	[Address(RVA = "0xDAAD60", Offset = "0xDA9B60", Length = "0xA13")]
	private DropppedDecorationStorageCustomSpawnedItem SpawnNewDroppedDecorationStorage(Transform playerTransform, out string errorMessage)
	{
		errorMessage = null;
		return null;
	}

	[Token(Token = "0x6004E7D")]
	[Address(RVA = "0xDAB780", Offset = "0xDAA580", Length = "0x16D")]
	public void MaybeAdd(GameObject go, PlayerManager.InventoryInstantiateFlags flags)
	{
	}

	[Token(Token = "0x6004E7E")]
	[Address(RVA = "0xDAB8F0", Offset = "0xDAA6F0", Length = "0xBE4")]
	public void MaybeCycleLightSourceInHands()
	{
	}

	[Token(Token = "0x6004E7F")]
	[Address(RVA = "0xDAC4E0", Offset = "0xDAB2E0", Length = "0xE14")]
	public void MaybeCycleFirearmInHands()
	{
	}

	[Token(Token = "0x6004E80")]
	[Address(RVA = "0xDAD300", Offset = "0xDAC100", Length = "0x1ED")]
	private void RemoveGameObjectInInventory(GameObject objectToRemove)
	{
	}

	[Token(Token = "0x6004E81")]
	[Address(RVA = "0xDAD4F0", Offset = "0xDAC2F0", Length = "0x146")]
	public void DestroyGear(GameObject go)
	{
	}

	[Token(Token = "0x6004E82")]
	[Address(RVA = "0xDAD640", Offset = "0xDAC440", Length = "0x1C8")]
	public void DestroyDecoration(DecorationItem di)
	{
	}

	[Token(Token = "0x6004E83")]
	[Address(RVA = "0xDAD810", Offset = "0xDAC610", Length = "0x2A9")]
	public void DestroyGear(GearItem gi)
	{
	}

	[Token(Token = "0x6004E84")]
	[Address(RVA = "0xDADAC0", Offset = "0xDAC8C0", Length = "0x185")]
	public void DestroyAllGear()
	{
	}

	[Token(Token = "0x6004E85")]
	[Address(RVA = "0xDADC50", Offset = "0xDACA50", Length = "0x37")]
	public float GetCurrentTotalScentIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6004E86")]
	[Address(RVA = "0xDADC90", Offset = "0xDACA90", Length = "0x42F")]
	private ItemWeight GetExtraWeightKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6004E87")]
	[Address(RVA = "0xDAE0C0", Offset = "0xDACEC0", Length = "0x426")]
	private float GetExtraScentIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6004E88")]
	[Address(RVA = "0xDAE4F0", Offset = "0xDAD2F0", Length = "0x2C6")]
	public ItemWeight GetTotalWeightKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6004E89")]
	[Address(RVA = "0xDAE7C0", Offset = "0xDAD5C0", Length = "0x433")]
	public GearItem GetWarmestBedroll()
	{
		return null;
	}

	[Token(Token = "0x6004E8A")]
	[Address(RVA = "0xDAEC00", Offset = "0xDADA00", Length = "0x1FC")]
	public void GetGearItems(Predicate<GearItem> predicate, List<GearItem> results)
	{
	}

	[Token(Token = "0x6004E8B")]
	[Address(RVA = "0xDAEE00", Offset = "0xDADC00", Length = "0x3BD")]
	public GearItem GetHighestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[Token(Token = "0x6004E8C")]
	[Address(RVA = "0xDAF1C0", Offset = "0xDADFC0", Length = "0x32F")]
	public GearItem GetLowestConditionGearThatMatchesName(string name)
	{
		return null;
	}

	[Token(Token = "0x6004E8D")]
	[Address(RVA = "0xDAF4F0", Offset = "0xDAE2F0", Length = "0x324")]
	public GearItem GetHighestConditionGearThatMatchesCanOpeningType(CanOpeningItem.CanOpeningType type)
	{
		return null;
	}

	[Token(Token = "0x6004E8E")]
	[Address(RVA = "0xDAF820", Offset = "0xDAE620", Length = "0x29C")]
	public GearItem GearInInventory(string gearName, int numUnits)
	{
		return null;
	}

	[Token(Token = "0x6004E8F")]
	[Address(RVA = "0xDAFAC0", Offset = "0xDAE8C0", Length = "0x43A")]
	public GearItem GearInInventory(GearItem gearType, int numUnits, bool ignoreWornOut)
	{
		return null;
	}

	[Token(Token = "0x6004E90")]
	[Address(RVA = "0xDAFF00", Offset = "0xDAED00", Length = "0x304")]
	public GearItem GearInInventoryAtCondition(string gearName, int numUnits, int conditionInPercent)
	{
		return null;
	}

	[Token(Token = "0x6004E91")]
	[Address(RVA = "0xDB0210", Offset = "0xDAF010", Length = "0xE8")]
	public bool HasNonRuinedItem(string gearName)
	{
		return false;
	}

	[Token(Token = "0x6004E92")]
	[Address(RVA = "0xDB0300", Offset = "0xDAF100", Length = "0x234")]
	public GearItem GetNonRuinedItem(string gearName)
	{
		return null;
	}

	[Token(Token = "0x6004E93")]
	[Address(RVA = "0xDB0540", Offset = "0xDAF340", Length = "0x2D6")]
	public void GearInInventory(string gearName, List<GearItem> gear)
	{
	}

	[Token(Token = "0x6004E94")]
	[Address(RVA = "0xDB0820", Offset = "0xDAF620", Length = "0x25B")]
	public int GetNumMatches()
	{
		return 0;
	}

	[Token(Token = "0x6004E95")]
	[Address(RVA = "0xDB0A80", Offset = "0xDAF880", Length = "0x24F")]
	public int GetNumFlares(FlareType type)
	{
		return 0;
	}

	[Token(Token = "0x6004E96")]
	[Address(RVA = "0xDB0CD0", Offset = "0xDAFAD0", Length = "0x240")]
	public int GetNumTorches()
	{
		return 0;
	}

	[Token(Token = "0x6004E97")]
	[Address(RVA = "0xDB0F20", Offset = "0xDAFD20", Length = "0x277")]
	public int GetNumStones()
	{
		return 0;
	}

	[Token(Token = "0x6004E98")]
	[Address(RVA = "0xDB11A0", Offset = "0xDAFFA0", Length = "0x240")]
	public int GetNumNoiseMakers()
	{
		return 0;
	}

	[Token(Token = "0x6004E99")]
	[Address(RVA = "0xDB13F0", Offset = "0xDB01F0", Length = "0xC")]
	public int NumGearInInventory(string gearName, bool ignoreWornOut = false)
	{
		return 0;
	}

	[Token(Token = "0x6004E9A")]
	[Address(RVA = "0xDB1400", Offset = "0xDB0200", Length = "0xC")]
	public int NumGearInInventory(GearItemData gearItemData)
	{
		return 0;
	}

	[Token(Token = "0x6004E9B")]
	[Address(RVA = "0xDB1410", Offset = "0xDB0210", Length = "0x352")]
	public int GetNumGearWithName(string gearName)
	{
		return 0;
	}

	[Token(Token = "0x6004E9C")]
	[Address(RVA = "0xDB1770", Offset = "0xDB0570", Length = "0xC")]
	public ItemWeight GetMeasurableTotalByType(string type)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6004E9D")]
	[Address(RVA = "0xDB1780", Offset = "0xDB0580", Length = "0x16F")]
	public void RemoveUnits(GearItem gi, int numUnits)
	{
	}

	[Token(Token = "0x6004E9E")]
	[Address(RVA = "0xDB18F0", Offset = "0xDB06F0", Length = "0x25A")]
	public void GetItems(string gearName, List<GearItem> list)
	{
	}

	[Token(Token = "0x6004E9F")]
	[Address(RVA = "0xDB1B50", Offset = "0xDB0950", Length = "0x480")]
	public void RemoveGearFromInventory(string gearName, int numUnits, bool ignoreWornOut = false)
	{
	}

	[Token(Token = "0x6004EA0")]
	[Address(RVA = "0xDB1FE0", Offset = "0xDB0DE0", Length = "0x210")]
	private static bool IsDecomposable(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004EA1")]
	[Address(RVA = "0xDB2200", Offset = "0xDB1000", Length = "0x405")]
	private static ItemWeight RemoveAmountFromGearItem(GearItem gi, ItemWeight amountToRemove)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6004EA2")]
	[Address(RVA = "0xDB2610", Offset = "0xDB1410", Length = "0x338")]
	public ItemWeight GetTotalAmountInInventory(GearItemData gearItemData, bool onlyConsiderDecomposableItems = false, bool ignoreWornOut = false)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6004EA3")]
	[Address(RVA = "0xDB2950", Offset = "0xDB1750", Length = "0x6A3")]
	public void RemoveAmountFromInventory(GearItemData itemType, ItemWeight amountToRemove, bool onlyConsiderDecomposableItems = false, bool ignoreWornOut = false)
	{
	}

	[Token(Token = "0x6004EA4")]
	[Address(RVA = "0xDB3000", Offset = "0xDB1E00", Length = "0x1BC")]
	public int GetAmmoAvailableForWeapon(GearItem weapon)
	{
		return 0;
	}

	[Token(Token = "0x6004EA5")]
	[Address(RVA = "0xDB31C0", Offset = "0xDB1FC0", Length = "0x1BC")]
	public int RemoveAmmoForWeaponSingle(GearItem weapon)
	{
		return 0;
	}

	[Token(Token = "0x6004EA6")]
	[Address(RVA = "0xDB3380", Offset = "0xDB2180", Length = "0x1BE")]
	public List<int> RemoveAmmoForWeapon(GearItem weapon, int ammoNeeded)
	{
		return null;
	}

	[Token(Token = "0x6004EA7")]
	[Address(RVA = "0xDB3540", Offset = "0xDB2340", Length = "0x137")]
	public bool AddToPotableWaterSupply(ItemLiquidVolume volumeLiters)
	{
		return false;
	}

	[Token(Token = "0x6004EA8")]
	[Address(RVA = "0xDB3680", Offset = "0xDB2480", Length = "0x289")]
	public GearItem GetBestMatches()
	{
		return null;
	}

	[Token(Token = "0x6004EA9")]
	[Address(RVA = "0xDB3910", Offset = "0xDB2710", Length = "0x2AC")]
	public GearItem GetBestMatches(MatchesType matchesType)
	{
		return null;
	}

	[Token(Token = "0x6004EAA")]
	[Address(RVA = "0xDB3BC0", Offset = "0xDB29C0", Length = "0x153")]
	public GearItem GetBestBed()
	{
		return null;
	}

	[Token(Token = "0x6004EAB")]
	[Address(RVA = "0xDB3D20", Offset = "0xDB2B20", Length = "0x212")]
	public GearItem GetFirstItem(Predicate<GearItem> match)
	{
		return null;
	}

	[Token(Token = "0x6004EAC")]
	[Address(RVA = "0xDB3F40", Offset = "0xDB2D40", Length = "0x2EC")]
	public GearItem GetBestItemByCurrentHP(Predicate<GearItem> match)
	{
		return null;
	}

	[Token(Token = "0x6004EAD")]
	[Address(RVA = "0xDB4230", Offset = "0xDB3030", Length = "0x2F3")]
	private GearItem GetBestItemUsingComparison(Predicate<GearItem> match, Comparison<GearItem> comparison)
	{
		return null;
	}

	[Token(Token = "0x6004EAE")]
	[Address(RVA = "0xDB4530", Offset = "0xDB3330", Length = "0x8A")]
	private GearItem GetBestItemByNormalizedCondition(Predicate<GearItem> match)
	{
		return null;
	}

	[Token(Token = "0x6004EAF")]
	[Address(RVA = "0xDB45C0", Offset = "0xDB33C0", Length = "0x107")]
	public GearItem GetBestFromGearItemData(GearItemData gearItemData)
	{
		return null;
	}

	[Token(Token = "0x6004EB0")]
	[Address(RVA = "0xDB46D0", Offset = "0xDB34D0", Length = "0x224")]
	public int GetNumNonRuinedItemsByPredicate(Predicate<GearItem> match)
	{
		return 0;
	}

	[Token(Token = "0x6004EB1")]
	[Address(RVA = "0xDB4900", Offset = "0xDB3700", Length = "0x326")]
	private GearItem GetBestGun(GunType type)
	{
		return null;
	}

	[Token(Token = "0x6004EB2")]
	[Address(RVA = "0xDB4C30", Offset = "0xDB3A30", Length = "0x1B0")]
	public GearItem GetBestStone()
	{
		return null;
	}

	[Token(Token = "0x6004EB3")]
	[Address(RVA = "0xDB4DF0", Offset = "0xDB3BF0", Length = "0x30D")]
	public GearItem GetBestDecoy()
	{
		return null;
	}

	[Token(Token = "0x6004EB4")]
	[Address(RVA = "0xDB5100", Offset = "0xDB3F00", Length = "0x153")]
	public GearItem GetBestRopeItem()
	{
		return null;
	}

	[Token(Token = "0x6004EB5")]
	[Address(RVA = "0xDB5260", Offset = "0xDB4060", Length = "0x2A9")]
	public GearItem GetBestStuggleBonusItem()
	{
		return null;
	}

	[Token(Token = "0x6004EB6")]
	[Address(RVA = "0xDB5510", Offset = "0xDB4310", Length = "0x34F")]
	public GearItem GetLowestConditionArrow(GearItemData arrowData)
	{
		return null;
	}

	[Token(Token = "0x6004EB7")]
	[Address(RVA = "0xDB5860", Offset = "0xDB4660", Length = "0x237")]
	public bool HasRawMeat()
	{
		return false;
	}

	[Token(Token = "0x6004EB8")]
	[Address(RVA = "0xDB5AA0", Offset = "0xDB48A0", Length = "0x3E4")]
	public ItemWeight GetTotalPowderWeight(PowderType type)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6004EB9")]
	[Address(RVA = "0xDB5E90", Offset = "0xDB4C90", Length = "0x624")]
	public ItemLiquidVolume GetTotalLiquidVolume(LiquidType liquid)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6004EBA")]
	[Address(RVA = "0xDB64C0", Offset = "0xDB52C0", Length = "0x21")]
	private static bool IsLiquidQualityTheSame(LiquidType.LiquidQuality liquidQuality, LiquidQuality legacyQuality)
	{
		return false;
	}

	[Token(Token = "0x6004EBB")]
	[Address(RVA = "0xDB64F0", Offset = "0xDB52F0", Length = "0x2D9")]
	public GearItem GetPotableWaterSupply()
	{
		return null;
	}

	[Token(Token = "0x6004EBC")]
	[Address(RVA = "0xDB67D0", Offset = "0xDB55D0", Length = "0x2E8")]
	public GearItem GetNonPotableWaterSupply()
	{
		return null;
	}

	[Token(Token = "0x6004EBD")]
	[Address(RVA = "0xDB6AC0", Offset = "0xDB58C0", Length = "0x12")]
	public GearItem GetWaterSupply(LiquidQuality quality)
	{
		return null;
	}

	[Token(Token = "0x6004EBE")]
	[Address(RVA = "0xDB6AE0", Offset = "0xDB58E0", Length = "0xC3")]
	public bool AddToWaterSupply(ItemLiquidVolume numLiters, LiquidQuality quality)
	{
		return false;
	}

	[Token(Token = "0x6004EBF")]
	[Address(RVA = "0xDB6BB0", Offset = "0xDB59B0", Length = "0x77")]
	public void SetActive(GearItem gi, bool active)
	{
	}

	[Token(Token = "0x6004EC0")]
	[Address(RVA = "0xDB6C30", Offset = "0xDB5A30", Length = "0x9FB")]
	public void HideInventoryItem(GearItem gi, bool hide)
	{
	}

	[Token(Token = "0x6004EC1")]
	[Address(RVA = "0xDB7630", Offset = "0xDB6430", Length = "0x17B")]
	public int DropAndScatterItems(int count, float minRadius, float maxRadius, GearItem forceDropItem, int minAngleDegrees, int maxAngleDegrees)
	{
		return 0;
	}

	[Token(Token = "0x6004EC2")]
	[Address(RVA = "0xDB77B0", Offset = "0xDB65B0", Length = "0x36")]
	private GearItem DropScatterItem(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x6004EC3")]
	[Address(RVA = "0xDB77F0", Offset = "0xDB65F0", Length = "0x23C")]
	private bool CanDropAndScatterItem(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004EC4")]
	[Address(RVA = "0xDB7A30", Offset = "0xDB6830", Length = "0xC")]
	public GearItem GetBestGearItemWithName(string name)
	{
		return null;
	}

	[Token(Token = "0x6004EC5")]
	[Address(RVA = "0xDB7A40", Offset = "0xDB6840", Length = "0xF")]
	public void SetOverrideGearWeight(ItemWeight weight)
	{
	}

	[Token(Token = "0x6004EC6")]
	[Address(RVA = "0xDB7A50", Offset = "0xDB6850", Length = "0x67")]
	public void ResetOverrideGearWeight()
	{
	}

	[Token(Token = "0x6004EC7")]
	[Address(RVA = "0xDB7AC0", Offset = "0xDB68C0", Length = "0x124")]
	public void OnConsumed(GearItem gearItem)
	{
	}

	[Token(Token = "0x6004EC8")]
	[Address(RVA = "0xDB7BF0", Offset = "0xDB69F0", Length = "0x204")]
	public void OnFirstAidCompleted(GearItem gearItem)
	{
	}

	[Token(Token = "0x6004EC9")]
	[Address(RVA = "0x6FBDF0", Offset = "0x6FABF0", Length = "0x8")]
	public bool HasConsumedCoffee()
	{
		return false;
	}

	[Token(Token = "0x6004ECA")]
	[Address(RVA = "0xDB7E00", Offset = "0xDB6C00", Length = "0x8")]
	public bool HasConsumedRosehipTea()
	{
		return false;
	}

	[Token(Token = "0x6004ECB")]
	[Address(RVA = "0xDB7E10", Offset = "0xDB6C10", Length = "0x8")]
	public bool HasConsumedReishiTea()
	{
		return false;
	}

	[Token(Token = "0x6004ECC")]
	[Address(RVA = "0xDB7E20", Offset = "0xDB6C20", Length = "0x8")]
	public bool HasConsumedOldMansBeardDressing()
	{
		return false;
	}

	[Token(Token = "0x6004ECD")]
	[Address(RVA = "0xDB7E30", Offset = "0xDB6C30", Length = "0x7")]
	public void SetSuppressScentIndicator(bool shouldSuppress)
	{
	}

	[Token(Token = "0x6004ECE")]
	[Address(RVA = "0xDB7E40", Offset = "0xDB6C40", Length = "0xCAB")]
	private void ProcessItems()
	{
	}

	[Token(Token = "0x6004ECF")]
	[Address(RVA = "0xDB8AF0", Offset = "0xDB78F0", Length = "0x2E2")]
	private void MaybeUpdateWeightRTPCs()
	{
	}

	[Token(Token = "0x6004ED0")]
	[Address(RVA = "0xDB8DE0", Offset = "0xDB7BE0", Length = "0x73B")]
	private void PositionAndRotateScatteredItem(GearItem item, Vector3 dropPosition, Vector3 dropNormal)
	{
	}

	[Token(Token = "0x6004ED1")]
	[Address(RVA = "0xDB9520", Offset = "0xDB8320", Length = "0x3DE")]
	private bool ShouldMakeItemInHandsActive(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004ED2")]
	[Address(RVA = "0xDB9900", Offset = "0xDB8700", Length = "0x1DF")]
	private void HanksHack()
	{
	}

	[Token(Token = "0x6004ED3")]
	[Address(RVA = "0xDB9AE0", Offset = "0xDB88E0", Length = "0x7")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004ED4")]
	[Address(RVA = "0xDB9AF0", Offset = "0xDB88F0", Length = "0x519")]
	public int GetAmmoAvailableForWeapon(GearItemData ammoData)
	{
		return 0;
	}

	[Token(Token = "0x6004ED5")]
	[Address(RVA = "0xDBA010", Offset = "0xDB8E10", Length = "0x9C8")]
	public List<int> RemoveBestQualityAmmoForWeapon(GearItemData ammoData, int ammoNeeded)
	{
		return null;
	}

	[Token(Token = "0x6004ED6")]
	[Address(RVA = "0xDBA9E0", Offset = "0xDB97E0", Length = "0x809")]
	public int RemoveBestQualityAmmoForWeaponSingle(GearItemData ammoData)
	{
		return 0;
	}

	[Token(Token = "0x6004ED7")]
	[Address(RVA = "0xDBB1F0", Offset = "0xDB9FF0", Length = "0x6CA")]
	private void FilterFPItemsToList(List<GearItem> gearItems, Predicate<GearItem> filter, Comparison<GearItem> comparison)
	{
	}

	[Token(Token = "0x6004ED8")]
	[Address(RVA = "0xDBB8C0", Offset = "0xDBA6C0", Length = "0xA1")]
	private void FilterFPItemsToList(List<GearItem> gearItems, Predicate<GearItem> filter)
	{
	}

	[Token(Token = "0x6004ED9")]
	[Address(RVA = "0xDBB970", Offset = "0xDBA770", Length = "0x11D")]
	private void FilterBestItemToList(List<GearItem> gearItems, Predicate<GearItem> filter, Comparison<GearItem> comparison)
	{
	}

	[Token(Token = "0x6004EDA")]
	[Address(RVA = "0xDBBA90", Offset = "0xDBA890", Length = "0xA1")]
	private void FilterBestItemToList(List<GearItem> gearItems, Predicate<GearItem> filter)
	{
	}

	[Token(Token = "0x6004EDB")]
	[Address(RVA = "0xDBBB40", Offset = "0xDBA940", Length = "0x111")]
	private static bool IsGearItemGunOfType(GearItem gi, GunType targetType)
	{
		return false;
	}

	[Token(Token = "0x6004EDC")]
	[Address(RVA = "0xDBBC60", Offset = "0xDBAA60", Length = "0x10F")]
	private static int SortByNormalizedCondition(GearItem gix, GearItem giy)
	{
		return 0;
	}

	[Token(Token = "0x6004EDD")]
	[Address(RVA = "0xDBBD70", Offset = "0xDBAB70", Length = "0x90")]
	private void InitQuickSelectSlots()
	{
	}

	[Token(Token = "0x6004EDE")]
	[Address(RVA = "0xDBBE10", Offset = "0xDBAC10", Length = "0x155")]
	private void UpdateQuickSelectionSlots()
	{
	}

	[Token(Token = "0x6004EDF")]
	[Address(RVA = "0xDBBF70", Offset = "0xDBAD70", Length = "0x15D")]
	private bool AssignedToQuickSlot(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x6004EE0")]
	[Address(RVA = "0xDBC0D0", Offset = "0xDBAED0", Length = "0x484")]
	private void QuickSelectionHandleInventoryItemRemoval(GameObject deader)
	{
	}

	[Token(Token = "0x6004EE1")]
	[Address(RVA = "0xDBC560", Offset = "0xDBB360", Length = "0x42F")]
	public Inventory()
	{
	}
}
