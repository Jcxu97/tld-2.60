using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x200073E")]
public class FireManager : MonoBehaviour
{
	[Token(Token = "0x4004CA6")]
	[FieldOffset(Offset = "0x20")]
	public float m_WindSpeedThatMakeStartingFireImpossible;

	[Token(Token = "0x4004CA7")]
	[FieldOffset(Offset = "0x24")]
	public float m_WindSpeedThatBlowsOutFires;

	[Token(Token = "0x4004CA8")]
	[FieldOffset(Offset = "0x28")]
	public float m_SkillIncreaseChanceOnSuccess;

	[Token(Token = "0x4004CA9")]
	[FieldOffset(Offset = "0x2C")]
	public float m_SkillIncreaseChanceOnFailure;

	[Token(Token = "0x4004CAA")]
	[FieldOffset(Offset = "0x30")]
	public float m_StartFireTimeSeconds;

	[Token(Token = "0x4004CAB")]
	[FieldOffset(Offset = "0x34")]
	public float m_StartFireTimeSecondsWet;

	[Token(Token = "0x4004CAC")]
	[FieldOffset(Offset = "0x38")]
	public float m_TODMinutesFadeOutFireAudio;

	[Token(Token = "0x4004CAD")]
	[FieldOffset(Offset = "0x3C")]
	public float m_MinimumNormalizedFadeOutVolume;

	[Token(Token = "0x4004CAE")]
	[FieldOffset(Offset = "0x40")]
	public float m_MaxHeatIncreaseOfFireInForge;

	[Token(Token = "0x4004CAF")]
	[FieldOffset(Offset = "0x44")]
	public float m_MaxHeatIncreaseOfFire;

	[Token(Token = "0x4004CB0")]
	[FieldOffset(Offset = "0x48")]
	public float m_MaxDurationHoursOfFire;

	[Token(Token = "0x4004CB1")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FireOuterRadiusScaleIndoors;

	[Token(Token = "0x4004CB2")]
	[FieldOffset(Offset = "0x50")]
	public float m_TempBeginBurnRateAdjustment;

	[Token(Token = "0x4004CB3")]
	[FieldOffset(Offset = "0x54")]
	public float m_TempEndBurnRateAdjustment;

	[Range(0f, 1f)]
	[Token(Token = "0x4004CB4")]
	[FieldOffset(Offset = "0x58")]
	public float m_MaxBurnRateAdjustment;

	[Token(Token = "0x4004CB5")]
	[FieldOffset(Offset = "0x5C")]
	public float m_TakeTorchReduceBurnMinutes;

	[Tooltip("How many liters of kerosene is required to be used as an accelerant")]
	[Token(Token = "0x4004CB6")]
	[FieldOffset(Offset = "0x60")]
	public ItemLiquidVolume m_KeroseneAccelerant;

	[Token(Token = "0x4004CB7")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_KeroseneAccelerantPrefab;

	[Token(Token = "0x4004CB8")]
	[FieldOffset(Offset = "0x70")]
	public AssetReferenceWithComponent<Campfire> m_CampFireReference;

	[Tooltip("How many kilograms of kerosene is required to be used as an accelerant")]
	[Token(Token = "0x4004CB9")]
	[FieldOffset(Offset = "0x78")]
	public ItemWeight m_GunpowderAccelerant;

	[Token(Token = "0x4004CBA")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_GunpowderAccelerantPrefab;

	[HideInInspector]
	[Token(Token = "0x4004CBB")]
	public static List<Fire> m_Fires;

	[Token(Token = "0x4004CBC")]
	private static readonly HashSet<string> m_DestroyedFireGuids;

	[Token(Token = "0x4004CBD")]
	private static readonly List<WoodStove> m_WoodStoves;

	[Token(Token = "0x4004CBE")]
	private static readonly List<Campfire> m_Campfires;

	[Token(Token = "0x4004CBF")]
	[FieldOffset(Offset = "0x88")]
	private GearItem m_FireStarterToDestroy;

	[Token(Token = "0x4004CC0")]
	[FieldOffset(Offset = "0x90")]
	private bool m_ForceFireStartingSuccess;

	[Token(Token = "0x600416F")]
	[Address(RVA = "0xC22B30", Offset = "0xC21930", Length = "0x61B")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004170")]
	[Address(RVA = "0xC23150", Offset = "0xC21F50", Length = "0x750")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004171")]
	[Address(RVA = "0xC238B0", Offset = "0xC226B0", Length = "0x479")]
	public static string SerializeChimneyData()
	{
		return null;
	}

	[Token(Token = "0x6004172")]
	[Address(RVA = "0xC23D30", Offset = "0xC22B30", Length = "0x585")]
	public static void DeserializeChimneyData(string text)
	{
	}

	[Token(Token = "0x6004173")]
	[Address(RVA = "0xC242C0", Offset = "0xC230C0", Length = "0x129")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004174")]
	[Address(RVA = "0xC243F0", Offset = "0xC231F0", Length = "0xBE")]
	public static void AddWoodStove(WoodStove ws)
	{
	}

	[Token(Token = "0x6004175")]
	[Address(RVA = "0xC244B0", Offset = "0xC232B0", Length = "0x1D6")]
	public static void AddCampfire(Campfire cf)
	{
	}

	[Token(Token = "0x6004176")]
	[Address(RVA = "0xC24690", Offset = "0xC23490", Length = "0xFE")]
	public static void DestroyFireObject(Fire f)
	{
	}

	[Token(Token = "0x6004177")]
	[Address(RVA = "0xC24790", Offset = "0xC23590", Length = "0x738")]
	public void PlayerStartFire(Fire fire, FireStarterItem starter, FuelSourceItem tinder, FuelSourceItem fuel, FireStarterItem accelerant, Action<bool> onDoneStartingFire)
	{
	}

	[Token(Token = "0x6004178")]
	[Address(RVA = "0xC24ED0", Offset = "0xC23CD0", Length = "0xE0")]
	public void UpdateSkillAfterFireCreationAttempt(bool success)
	{
	}

	[Token(Token = "0x6004179")]
	[Address(RVA = "0xC24FC0", Offset = "0xC23DC0", Length = "0x234")]
	public float CalculateFireStartSuccess(FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant)
	{
		return 0f;
	}

	[Token(Token = "0x600417A")]
	[Address(RVA = "0xC25200", Offset = "0xC24000", Length = "0xCC")]
	public static void AddFire(Fire f)
	{
	}

	[Token(Token = "0x600417B")]
	[Address(RVA = "0xC252D0", Offset = "0xC240D0", Length = "0x51")]
	public static void RemoveFire(Fire f)
	{
	}

	[Token(Token = "0x600417C")]
	[Address(RVA = "0xC25330", Offset = "0xC24130", Length = "0x168")]
	public static void RemoveFire(Fire f, bool permanent)
	{
	}

	[Token(Token = "0x600417D")]
	[Address(RVA = "0xC254A0", Offset = "0xC242A0", Length = "0x2CA")]
	public void GetMissingMaterials(out bool hasStarter, out bool hasTinder, out bool hasFuel)
	{
		hasStarter = default(bool);
		hasTinder = default(bool);
		hasFuel = default(bool);
	}

	[Token(Token = "0x600417E")]
	[Address(RVA = "0xC25770", Offset = "0xC24570", Length = "0x1C1")]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[Token(Token = "0x600417F")]
	[Address(RVA = "0xC25940", Offset = "0xC24740", Length = "0x17B")]
	public float GetDistanceToClosestFire(Vector3 pos)
	{
		return 0f;
	}

	[Token(Token = "0x6004180")]
	[Address(RVA = "0xC25AC0", Offset = "0xC248C0", Length = "0x19F")]
	public Fire GetClosestFire(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6004181")]
	[Address(RVA = "0xC25C60", Offset = "0xC24A60", Length = "0x1D2")]
	public void GetFiresWithinRangeOfPosition(Vector3 position, float range, List<Fire> results)
	{
	}

	[Token(Token = "0x6004182")]
	[Address(RVA = "0xC25E40", Offset = "0xC24C40", Length = "0x1A1")]
	public bool PointInRadiusOfBurningFire(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6004183")]
	[Address(RVA = "0xC25FF0", Offset = "0xC24DF0", Length = "0x1A1")]
	public bool PointInRadiusOfFullyBurningFire(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6004184")]
	[Address(RVA = "0xC261A0", Offset = "0xC24FA0", Length = "0x1A1")]
	public bool PointInInnerRadiusOfBurningFire(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6004185")]
	[Address(RVA = "0xC26350", Offset = "0xC25150", Length = "0xE5")]
	public void ExitFireStarting()
	{
	}

	[Token(Token = "0x6004186")]
	[Address(RVA = "0xC26440", Offset = "0xC25240", Length = "0x79")]
	private bool PlayerRollFireStartSuccess(float percentChanceSuccess)
	{
		return false;
	}

	[Token(Token = "0x6004187")]
	[Address(RVA = "0x89B490", Offset = "0x89A290", Length = "0x8")]
	public bool GetForceFireStartingSuccess()
	{
		return false;
	}

	[Token(Token = "0x6004188")]
	[Address(RVA = "0xC264C0", Offset = "0xC252C0", Length = "0x7")]
	public void SetForceFireStartingSuccess(bool forceFireStartingSuccess)
	{
	}

	[Token(Token = "0x6004189")]
	[Address(RVA = "0xC264D0", Offset = "0xC252D0", Length = "0x23E")]
	private float PlayerCalculateFireStartTime(FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant)
	{
		return 0f;
	}

	[Token(Token = "0x600418A")]
	[Address(RVA = "0xC26710", Offset = "0xC25510", Length = "0x278")]
	private FireStarterItem PlayerGetFirestarterChoice()
	{
		return null;
	}

	[Token(Token = "0x600418B")]
	[Address(RVA = "0xC26990", Offset = "0xC25790", Length = "0x2C3")]
	private FuelSourceItem PlayerGetTinderChoice()
	{
		return null;
	}

	[Token(Token = "0x600418C")]
	[Address(RVA = "0xC26C60", Offset = "0xC25A60", Length = "0x291")]
	private FuelSourceItem PlayerGetFuelChoice()
	{
		return null;
	}

	[Token(Token = "0x600418D")]
	[Address(RVA = "0xC26F00", Offset = "0xC25D00", Length = "0x278")]
	private FireStarterItem PlayerGetAccelerantChoice()
	{
		return null;
	}

	[Token(Token = "0x600418E")]
	[Address(RVA = "0xC27180", Offset = "0xC25F80", Length = "0x5CE")]
	private bool PlayerHasMaterialsToStartFire(out FireStarterItem starter, out FuelSourceItem tinder, out FuelSourceItem fuel, out FireStarterItem accelerant)
	{
		starter = null;
		tinder = null;
		fuel = null;
		accelerant = null;
		return false;
	}

	[Token(Token = "0x600418F")]
	[Address(RVA = "0xC27750", Offset = "0xC26550", Length = "0x6E")]
	private bool RollForSkillIncrease(bool success)
	{
		return false;
	}

	[Token(Token = "0x6004190")]
	[Address(RVA = "0xC277C0", Offset = "0xC265C0", Length = "0x68B")]
	private static Fire FindFireByPosition(FireSaveData fsd)
	{
		return null;
	}

	[Token(Token = "0x6004191")]
	[Address(RVA = "0xC27E50", Offset = "0xC26C50", Length = "0x117")]
	private static Fire FindFireByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6004192")]
	[Address(RVA = "0xC27F70", Offset = "0xC26D70", Length = "0x72")]
	public Fire InstantiateCampFire()
	{
		return null;
	}

	[Token(Token = "0x6004193")]
	[Address(RVA = "0xC27FF0", Offset = "0xC26DF0", Length = "0x1E3")]
	private static Fire InstantiateFireFromAddress(string address)
	{
		return null;
	}

	[Token(Token = "0x6004194")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FireManager()
	{
	}
}
