using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20007DF")]
public class SnowShelterManager : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4005453")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Rest> m_Rest;

	[Header("Build")]
	[Token(Token = "0x4005454")]
	[FieldOffset(Offset = "0x28")]
	public AssetReferenceWithComponent<SnowShelter> m_SnowShelterReference;

	[Token(Token = "0x4005455")]
	[FieldOffset(Offset = "0x30")]
	public float m_BuildRangeMin;

	[Token(Token = "0x4005456")]
	[FieldOffset(Offset = "0x34")]
	public float m_BuildRangeMax;

	[Header("Misc")]
	[Token(Token = "0x4005457")]
	[FieldOffset(Offset = "0x38")]
	public float m_TemperatureIncreaseCelsius;

	[Token(Token = "0x4005458")]
	[FieldOffset(Offset = "0x3C")]
	public float m_FOV;

	[Token(Token = "0x4005459")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 m_PitchLimitDegrees;

	[Token(Token = "0x400545A")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 m_YawLimitDegrees;

	[Token(Token = "0x400545B")]
	[FieldOffset(Offset = "0x50")]
	public float m_FadeOutSeconds;

	[Token(Token = "0x400545C")]
	[FieldOffset(Offset = "0x54")]
	public float m_FadeInSeconds;

	[Header("Audio")]
	[Token(Token = "0x400545D")]
	[FieldOffset(Offset = "0x58")]
	public string m_BuildAudio;

	[Token(Token = "0x400545E")]
	[FieldOffset(Offset = "0x60")]
	public string m_RepairAudio;

	[Token(Token = "0x400545F")]
	[FieldOffset(Offset = "0x68")]
	public string m_DismantleAudio;

	[Token(Token = "0x4005460")]
	[FieldOffset(Offset = "0x70")]
	public string m_EnterAudio;

	[Token(Token = "0x4005461")]
	[FieldOffset(Offset = "0x78")]
	public string m_ExitAudio;

	[Token(Token = "0x4005462")]
	public static bool m_Locked;

	[Token(Token = "0x4005463")]
	public static bool m_SnowSheltersUnlockedInStory;

	[Token(Token = "0x4005464")]
	[FieldOffset(Offset = "0x80")]
	private bool m_PlayerEnteringShelter;

	[Token(Token = "0x4005465")]
	[FieldOffset(Offset = "0x88")]
	private SnowShelter m_PlayerOccupiedSnowShelter;

	[Token(Token = "0x4005466")]
	[FieldOffset(Offset = "0x90")]
	private SnowShelter m_PendingPlayerOccupiedSnowShelter;

	[Token(Token = "0x4005467")]
	[FieldOffset(Offset = "0x98")]
	private float m_StartCameraFOV;

	[Token(Token = "0x4005468")]
	[FieldOffset(Offset = "0x9C")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x4005469")]
	[FieldOffset(Offset = "0xA4")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x400546A")]
	[FieldOffset(Offset = "0xB0")]
	private AsyncOperationHandle<GameObject> m_SnowShelterPrefabHandle;

	[Token(Token = "0x400546B")]
	[FieldOffset(Offset = "0xC8")]
	private SnowShelter m_SnowShelterPrefab;

	[Token(Token = "0x400546C")]
	public static List<SnowShelter> m_SnowShelters;

	[Token(Token = "0x400546D")]
	private const float MaxDistance = 10f;

	[Token(Token = "0x6004A3A")]
	[Address(RVA = "0xD324B0", Offset = "0xD312B0", Length = "0x54")]
	private void Start()
	{
	}

	[Token(Token = "0x6004A3B")]
	[Address(RVA = "0xD32510", Offset = "0xD31310", Length = "0xFC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004A3C")]
	[Address(RVA = "0xD32610", Offset = "0xD31410", Length = "0xBE")]
	public static void Add(SnowShelter ss)
	{
	}

	[Token(Token = "0x6004A3D")]
	[Address(RVA = "0xD326D0", Offset = "0xD314D0", Length = "0x11E")]
	public static void Remove(SnowShelter ss)
	{
	}

	[Token(Token = "0x6004A3E")]
	[Address(RVA = "0xD327F0", Offset = "0xD315F0", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004A3F")]
	[Address(RVA = "0xD32890", Offset = "0xD31690", Length = "0x49D")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6004A40")]
	[Address(RVA = "0xD32D30", Offset = "0xD31B30", Length = "0x7D0")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6004A41")]
	[Address(RVA = "0xD33510", Offset = "0xD32310", Length = "0x266")]
	public static void RegisterAnySnowShelterGuid()
	{
	}

	[Token(Token = "0x6004A42")]
	[Address(RVA = "0xD33780", Offset = "0xD32580", Length = "0x54")]
	public void SnowSheltersUnlockInStory()
	{
	}

	[Token(Token = "0x6004A43")]
	[Address(RVA = "0xD337E0", Offset = "0xD325E0", Length = "0x84")]
	public bool SnowSheltersAreUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6004A44")]
	[Address(RVA = "0x6208B0", Offset = "0x61F6B0", Length = "0x6")]
	public float GetTemperatureIncreaseCelsius()
	{
		return 0f;
	}

	[Token(Token = "0x6004A45")]
	[Address(RVA = "0xD33870", Offset = "0xD32670", Length = "0x81")]
	public int GetNumSticksInInventory()
	{
		return 0;
	}

	[Token(Token = "0x6004A46")]
	[Address(RVA = "0xD33900", Offset = "0xD32700", Length = "0x81")]
	public int GetNumClothInInventory()
	{
		return 0;
	}

	[Token(Token = "0x6004A47")]
	[Address(RVA = "0xD33990", Offset = "0xD32790", Length = "0x68")]
	public bool IsMissingMaterials()
	{
		return false;
	}

	[Token(Token = "0x6004A48")]
	[Address(RVA = "0xD33A00", Offset = "0xD32800", Length = "0x110")]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[Token(Token = "0x6004A49")]
	[Address(RVA = "0xD33B20", Offset = "0xD32920", Length = "0xF8")]
	public bool CanAttemptToPlaceSnowShelter()
	{
		return false;
	}

	[Token(Token = "0x6004A4A")]
	[Address(RVA = "0xD33C20", Offset = "0xD32A20", Length = "0x22")]
	public float GetMinutesToBuild()
	{
		return 0f;
	}

	[Token(Token = "0x6004A4B")]
	[Address(RVA = "0xD33C50", Offset = "0xD32A50", Length = "0x217")]
	public void EnterShelter(SnowShelter ss)
	{
	}

	[Token(Token = "0x6004A4C")]
	[Address(RVA = "0xD33E70", Offset = "0xD32C70", Length = "0x1A9")]
	public void ExitShelter(SnowShelter ss)
	{
	}

	[Token(Token = "0x6004A4D")]
	[Address(RVA = "0xD34020", Offset = "0xD32E20", Length = "0xCD")]
	public bool PlayerInShelter()
	{
		return false;
	}

	[Token(Token = "0x6004A4E")]
	[Address(RVA = "0xD340F0", Offset = "0xD32EF0", Length = "0x187")]
	public SnowShelter GetPlayerOccupiedSnowShelter()
	{
		return null;
	}

	[Token(Token = "0x6004A4F")]
	[Address(RVA = "0xD34280", Offset = "0xD33080", Length = "0xF5")]
	public bool PlayerInNonRuinedShelter()
	{
		return false;
	}

	[Token(Token = "0x6004A50")]
	[Address(RVA = "0x644520", Offset = "0x643320", Length = "0x8")]
	public bool PlayerEnteringShelter()
	{
		return false;
	}

	[Token(Token = "0x6004A51")]
	[Address(RVA = "0xD34380", Offset = "0xD33180", Length = "0x175")]
	public void OnBedroll(GearItem gi = null)
	{
	}

	[Token(Token = "0x6004A52")]
	[Address(RVA = "0xD34500", Offset = "0xD33300", Length = "0x2F1")]
	public void ExitShelterDueToStruggle()
	{
	}

	[Token(Token = "0x6004A53")]
	[Address(RVA = "0xD34800", Offset = "0xD33600", Length = "0x474")]
	public void ForceIntoSnowShelterSilent(Vector3 cameraPos)
	{
	}

	[Token(Token = "0x6004A54")]
	[Address(RVA = "0xD34C80", Offset = "0xD33A80", Length = "0xAB")]
	private void EnterShelterAfterFadeOut()
	{
	}

	[Token(Token = "0x6004A55")]
	[Address(RVA = "0xD34D30", Offset = "0xD33B30", Length = "0xA1F")]
	private void EnterShelterAfterFadeOutCommon()
	{
	}

	[Token(Token = "0x6004A56")]
	[Address(RVA = "0xD35750", Offset = "0xD34550", Length = "0x5CE")]
	private void ExitShelterAfterFadeOut()
	{
	}

	[Token(Token = "0x6004A57")]
	[Address(RVA = "0xD35D20", Offset = "0xD34B20", Length = "0x4CD")]
	private Vector3 GetSafeExitPoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6004A58")]
	[Address(RVA = "0xD361F0", Offset = "0xD34FF0", Length = "0xA8")]
	public SnowShelter InstantiateSnowShelter()
	{
		return null;
	}

	[Token(Token = "0x6004A59")]
	[Address(RVA = "0xD362A0", Offset = "0xD350A0", Length = "0x285")]
	private SnowShelter GetOrLoadSnowShelterPrefab()
	{
		return null;
	}

	[Token(Token = "0x6004A5A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SnowShelterManager()
	{
	}
}
