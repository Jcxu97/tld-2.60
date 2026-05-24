using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay.Challenges.DarkWalker;
using TLD.Scenes;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20007F1")]
public class ToxicFogManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007F2")]
	public struct ToxicFogGlobalDataProxy
	{
		[Token(Token = "0x40054B5")]
		[FieldOffset(Offset = "0x0")]
		public List<uint> m_TimeAccumulationKeys;

		[Token(Token = "0x40054B6")]
		[FieldOffset(Offset = "0x8")]
		public List<string> m_SceneKeys;

		[Token(Token = "0x40054B7")]
		[FieldOffset(Offset = "0x10")]
		public List<float> m_TimeAccumulationValues;

		[Token(Token = "0x40054B8")]
		[FieldOffset(Offset = "0x18")]
		public bool m_HasUsedDispelFogGlyph;
	}

	[SerializeField]
	[Token(Token = "0x40054A5")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x40054A6")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	[SerializeField]
	[Token(Token = "0x40054A7")]
	[FieldOffset(Offset = "0x30")]
	private ToxicFogConfig m_Config;

	[Token(Token = "0x40054A8")]
	public static bool s_IsPaused;

	[Token(Token = "0x40054A9")]
	[FieldOffset(Offset = "0x38")]
	private readonly Dictionary<SceneSet, float> m_AccumulatedTimeSeconds;

	[Token(Token = "0x40054AA")]
	[FieldOffset(Offset = "0x40")]
	private SceneSet m_CurrentSceneSet;

	[Token(Token = "0x40054AB")]
	[FieldOffset(Offset = "0x48")]
	private bool m_DetermineRegion;

	[Token(Token = "0x40054AC")]
	[FieldOffset(Offset = "0x49")]
	private bool m_HasAffliction;

	[Token(Token = "0x40054AD")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<GearItem> m_FoodItemsToRuin;

	[Token(Token = "0x40054AE")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<BaseAi> m_OnBaseAiToKill;

	[Token(Token = "0x40054AF")]
	[FieldOffset(Offset = "0x60")]
	private readonly List<GearItem> m_WornOut;

	[Token(Token = "0x40054B0")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<string> m_SceneKeys;

	[Token(Token = "0x40054B1")]
	[FieldOffset(Offset = "0x70")]
	private readonly List<float> m_TimeValues;

	[Token(Token = "0x40054B2")]
	[FieldOffset(Offset = "0x78")]
	private bool m_HasUsedDispelFogGlyph;

	[Token(Token = "0x40054B3")]
	private const uint INVALID_REGION = 4294967295u;

	[Token(Token = "0x40054B4")]
	private static readonly Dictionary<string, uint> s_RegionCodes;

	[Token(Token = "0x6004AB9")]
	[Address(RVA = "0xD42780", Offset = "0xD41580", Length = "0x277")]
	private void Start()
	{
	}

	[Token(Token = "0x6004ABA")]
	[Address(RVA = "0xD42A00", Offset = "0xD41800", Length = "0x7F")]
	public float DetermineScaleForPlayerCondition()
	{
		return 0f;
	}

	[Token(Token = "0x6004ABB")]
	[Address(RVA = "0xD42A80", Offset = "0xD41880", Length = "0x248")]
	public void Reset()
	{
	}

	[Token(Token = "0x6004ABC")]
	[Address(RVA = "0xD42CD0", Offset = "0xD41AD0", Length = "0x57")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004ABD")]
	[Address(RVA = "0xD42D30", Offset = "0xD41B30", Length = "0x128")]
	public void ResetTimeAccumulation(bool allregions)
	{
	}

	[Token(Token = "0x6004ABE")]
	[Address(RVA = "0xD42E60", Offset = "0xD41C60", Length = "0x60")]
	public void SetAccumulationPercent(float pct)
	{
	}

	[Token(Token = "0x6004ABF")]
	[Address(RVA = "0xD42EC0", Offset = "0xD41CC0", Length = "0x274")]
	public float GetFogProgressForRegion(string regionName)
	{
		return 0f;
	}

	[Token(Token = "0x6004AC0")]
	[Address(RVA = "0x502700", Offset = "0x501500", Length = "0x5")]
	public bool HasPlacedDispelFogGlyph()
	{
		return false;
	}

	[Token(Token = "0x6004AC1")]
	[Address(RVA = "0xD43140", Offset = "0xD41F40", Length = "0xB5")]
	public void PlaceGlyph(DecalProjectorInstance instance)
	{
	}

	[Token(Token = "0x6004AC2")]
	[Address(RVA = "0xD43200", Offset = "0xD42000", Length = "0x4AF")]
	public void Deserialize(string serialized)
	{
	}

	[Token(Token = "0x6004AC3")]
	[Address(RVA = "0xD436B0", Offset = "0xD424B0", Length = "0x4D6")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004AC4")]
	[Address(RVA = "0xD43B90", Offset = "0xD42990", Length = "0xFC")]
	public void StartFogWeatherTransition()
	{
	}

	[Token(Token = "0x6004AC5")]
	[Address(RVA = "0xD43C90", Offset = "0xD42A90", Length = "0x88")]
	private float GetTimeSecondsToFillUpCurrentScene()
	{
		return 0f;
	}

	[Token(Token = "0x6004AC6")]
	[Address(RVA = "0xD43D20", Offset = "0xD42B20", Length = "0x37")]
	private float GetTimeSecondsToFillUpScene(SceneSet sceneSet)
	{
		return 0f;
	}

	[Token(Token = "0x6004AC7")]
	[Address(RVA = "0xD43D60", Offset = "0xD42B60", Length = "0x278")]
	private ToxicFogConfig.SceneSetTunables GetSceneOverrideTunable(SceneSet sceneSet)
	{
		return null;
	}

	[Token(Token = "0x6004AC8")]
	[Address(RVA = "0xD43FE0", Offset = "0xD42DE0", Length = "0x49")]
	private float GetPercentInCurrentRegion()
	{
		return 0f;
	}

	[Token(Token = "0x6004AC9")]
	[Address(RVA = "0xD44030", Offset = "0xD42E30", Length = "0x97")]
	public float GetRemainingTimeToFullFogSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x6004ACA")]
	[Address(RVA = "0xD440D0", Offset = "0xD42ED0", Length = "0x7D7")]
	private void Update()
	{
	}

	[Token(Token = "0x6004ACB")]
	[Address(RVA = "0xB0C3B0", Offset = "0xB0B1B0", Length = "0x7")]
	private bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6004ACC")]
	[Address(RVA = "0xD448B0", Offset = "0xD436B0", Length = "0xCA")]
	public bool IsCurrentRegionValid()
	{
		return false;
	}

	[Token(Token = "0x6004ACD")]
	[Address(RVA = "0xD44980", Offset = "0xD43780", Length = "0x13C")]
	private void SetFogDensity(float fogScale)
	{
	}

	[Token(Token = "0x6004ACE")]
	[Address(RVA = "0xD44AC0", Offset = "0xD438C0", Length = "0x113")]
	private void OnGearItemAddedToWorld(GearItem gearItem)
	{
	}

	[Token(Token = "0x6004ACF")]
	[Address(RVA = "0xD44BE0", Offset = "0xD439E0", Length = "0x111")]
	private void OnGearItemRemovedFromWorld(GearItem gearItem)
	{
	}

	[Token(Token = "0x6004AD0")]
	[Address(RVA = "0xD44D00", Offset = "0xD43B00", Length = "0x98")]
	private void OnBaseAiAddedToWorld(BaseAi baseAi)
	{
	}

	[Token(Token = "0x6004AD1")]
	[Address(RVA = "0xD44DA0", Offset = "0xD43BA0", Length = "0x58")]
	private void OnBaseAiRemovedFromWorld(BaseAi baseAi)
	{
	}

	[Token(Token = "0x6004AD2")]
	[Address(RVA = "0xD44E00", Offset = "0xD43C00", Length = "0x489")]
	private void MaybeRuinFood()
	{
	}

	[Token(Token = "0x6004AD3")]
	[Address(RVA = "0xD45290", Offset = "0xD44090", Length = "0x1C4")]
	private void MaybeKillAllWildlife()
	{
	}

	[Token(Token = "0x6004AD4")]
	[Address(RVA = "0xD45460", Offset = "0xD44260", Length = "0x342")]
	private void MaybeReducePlayerCondition()
	{
	}

	[Token(Token = "0x6004AD5")]
	[Address(RVA = "0xD457B0", Offset = "0xD445B0", Length = "0x150")]
	private void AddSecondsInCurrentRegion(float seconds)
	{
	}

	[Token(Token = "0x6004AD6")]
	[Address(RVA = "0xD45910", Offset = "0xD44710", Length = "0x140")]
	private float GetSecondsInCurrentRegion()
	{
		return 0f;
	}

	[Token(Token = "0x6004AD7")]
	[Address(RVA = "0xD45A60", Offset = "0xD44860", Length = "0x15E")]
	private void InitCurrentRegion()
	{
	}

	[Token(Token = "0x6004AD8")]
	[Address(RVA = "0xD45BC0", Offset = "0xD449C0", Length = "0x123")]
	private void SetSecondsInCurrentRegion(float seconds)
	{
	}

	[Token(Token = "0x6004AD9")]
	[Address(RVA = "0xD45CF0", Offset = "0xD44AF0", Length = "0xC3")]
	private static KeyValuePair<string, uint> MakeRegionCodeEntry(GameRegion region)
	{
		return default(KeyValuePair<string, uint>);
	}

	[Token(Token = "0x6004ADA")]
	[Address(RVA = "0xD45DC0", Offset = "0xD44BC0", Length = "0x164")]
	private uint GetRegionHashName(string regionName)
	{
		return 0u;
	}

	[Token(Token = "0x6004ADB")]
	[Address(RVA = "0xD45F30", Offset = "0xD44D30", Length = "0x47F")]
	private Dictionary<uint, SceneSet> GetHashLookupTable()
	{
		return null;
	}

	[Token(Token = "0x6004ADC")]
	[Address(RVA = "0xD463B0", Offset = "0xD451B0", Length = "0x207")]
	private void MigrateSaveData(List<uint> keys, List<float> values)
	{
	}

	[Token(Token = "0x6004ADD")]
	[Address(RVA = "0xD465C0", Offset = "0xD453C0", Length = "0x3BF")]
	public ToxicFogManager()
	{
	}
}
