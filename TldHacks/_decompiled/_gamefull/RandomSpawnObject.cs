using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.Gameplay.Tunable;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x20005A6")]
public class RandomSpawnObject : MonoBehaviour
{
	[Token(Token = "0x400342F")]
	public const CustomTunableLMHV NO_GAMEMODE_DEFAULT = CustomTunableLMHV.High;

	[Token(Token = "0x4003430")]
	public const int DEFAULT_LEGACY_VALUE = -777;

	[HideInInspector]
	[Token(Token = "0x4003431")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] m_ObjectList;

	[HideInInspector]
	[Token(Token = "0x4003432")]
	[FieldOffset(Offset = "0x28")]
	public int[] m_Weights;

	[Tooltip("This object will be selected by default if old save data is loaded. Leave null to have everything disabled if old save data is loaded")]
	[Token(Token = "0x4003433")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_OldSaveObject;

	[Tooltip("Note this will not affect random spawners that spawn Gear Items, use the GearSpawnInOldSave component instead")]
	[Token(Token = "0x4003434")]
	[FieldOffset(Offset = "0x38")]
	public bool m_OldSaveRerollIfNoneActive;

	[Tooltip("Reroll activation after specified game hours. Set to 0 for no reroll.")]
	[Token(Token = "0x4003435")]
	[FieldOffset(Offset = "0x3C")]
	public float m_RerollAfterGameHours;

	[HideInInspector]
	[Token(Token = "0x4003436")]
	[FieldOffset(Offset = "0x40")]
	public int[] m_NumObjectsToEnableByLevel;

	[HideInInspector]
	[Obsolete]
	[FormerlySerializedAs("m_NumObjectsToEnable")]
	[Token(Token = "0x4003437")]
	[FieldOffset(Offset = "0x48")]
	public int m_NumObjectsToEnablePilgrim;

	[HideInInspector]
	[Obsolete]
	[FormerlySerializedAs("m_NumObjectsToEnable")]
	[Token(Token = "0x4003438")]
	[FieldOffset(Offset = "0x4C")]
	public int m_NumObjectsToEnableVoyageur;

	[HideInInspector]
	[Obsolete]
	[FormerlySerializedAs("m_NumObjectsToEnable")]
	[Token(Token = "0x4003439")]
	[FieldOffset(Offset = "0x50")]
	public int m_NumObjectsToEnableStalker;

	[HideInInspector]
	[Obsolete]
	[FormerlySerializedAs("m_NumObjectsToEnableNightmare")]
	[Token(Token = "0x400343A")]
	[FieldOffset(Offset = "0x54")]
	public int m_NumObjectsToEnableInterloper;

	[HideInInspector]
	[Token(Token = "0x400343B")]
	[FieldOffset(Offset = "0x58")]
	public bool m_HadSaveData;

	[HideInInspector]
	[Token(Token = "0x400343C")]
	[FieldOffset(Offset = "0x5C")]
	public float m_ElapsedHoursAtLastReroll;

	[Token(Token = "0x400343D")]
	[FieldOffset(Offset = "0x60")]
	private bool m_SucessfullyLoadedObject;

	[Token(Token = "0x400343E")]
	[FieldOffset(Offset = "0x61")]
	private bool m_Inited;

	[Token(Token = "0x400343F")]
	[FieldOffset(Offset = "0x62")]
	private bool m_Rerolled;

	[Token(Token = "0x4003440")]
	[FieldOffset(Offset = "0x63")]
	private bool m_SpawnedOldSaveGearItem;

	[Token(Token = "0x4003441")]
	[FieldOffset(Offset = "0x64")]
	private bool m_ShouldAllSkipSerialization;

	[Token(Token = "0x4003442")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<IShouldDisableForCurrentMode> m_Disablers;

	[Token(Token = "0x6002BBE")]
	[Address(RVA = "0x923440", Offset = "0x922240", Length = "0x1AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002BBF")]
	[Address(RVA = "0x9235F0", Offset = "0x9223F0", Length = "0x564")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6002BC0")]
	[Address(RVA = "0x923B60", Offset = "0x922960", Length = "0x7B")]
	private void Update()
	{
	}

	[Token(Token = "0x6002BC1")]
	[Address(RVA = "0x923BE0", Offset = "0x9229E0", Length = "0x110")]
	public bool HasObject(string objName, Vector3 location)
	{
		return false;
	}

	[Token(Token = "0x6002BC2")]
	[Address(RVA = "0x923CF0", Offset = "0x922AF0", Length = "0x3A7")]
	public void LoadObject(string objName, Vector3 location, float elapsedTimeSinceReroll)
	{
	}

	[Token(Token = "0x6002BC3")]
	[Address(RVA = "0x19D8120", Offset = "0x19D6F20", Length = "0x465")]
	private static void SetActiveAll<T>(GameObject obj, Predicate<T> ShouldBeActive) where T : Component
	{
	}

	[Token(Token = "0x6002BC4")]
	[Address(RVA = "0x9240A0", Offset = "0x922EA0", Length = "0x2E6")]
	public void DisableAll()
	{
	}

	[Token(Token = "0x6002BC5")]
	[Address(RVA = "0x924390", Offset = "0x923190", Length = "0x372")]
	public void DisableAllAndCheckContainers()
	{
	}

	[Token(Token = "0x6002BC6")]
	[Address(RVA = "0x924710", Offset = "0x923510", Length = "0x33B")]
	public void PruneMissingObjects()
	{
	}

	[Token(Token = "0x6002BC7")]
	[Address(RVA = "0x924A50", Offset = "0x923850", Length = "0x7B")]
	public bool ShouldAllSkipSerialization()
	{
		return false;
	}

	[Token(Token = "0x6002BC8")]
	[Address(RVA = "0x924AD0", Offset = "0x9238D0", Length = "0x7B")]
	public bool ShouldAnySkipSerialization()
	{
		return false;
	}

	[Token(Token = "0x6002BC9")]
	[Address(RVA = "0x924B50", Offset = "0x923950", Length = "0x184")]
	public static bool ShouldSkipSerialization(GameObject item)
	{
		return false;
	}

	[Token(Token = "0x6002BCA")]
	[Address(RVA = "0x924CE0", Offset = "0x923AE0", Length = "0x212")]
	public int GetNumObjectsToEnableCurrentXPMode()
	{
		return 0;
	}

	[Token(Token = "0x6002BCB")]
	[Address(RVA = "0x924F00", Offset = "0x923D00", Length = "0x1E4")]
	private GameObject FindObject(string objName, Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6002BCC")]
	[Address(RVA = "0x9250F0", Offset = "0x923EF0", Length = "0x96A")]
	private void ActivateRandomObject()
	{
	}

	[Token(Token = "0x6002BCD")]
	[Address(RVA = "0x925A60", Offset = "0x924860", Length = "0x33F")]
	private Vector3 GetFirstNonZeroPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002BCE")]
	[Address(RVA = "0x925DA0", Offset = "0x924BA0", Length = "0x446")]
	private void CheckForSpawnInOldSaves()
	{
	}

	[Token(Token = "0x6002BCF")]
	[Address(RVA = "0x9261F0", Offset = "0x924FF0", Length = "0x29C")]
	public void MaybeReroll()
	{
	}

	[Token(Token = "0x6002BD0")]
	[Address(RVA = "0x926490", Offset = "0x925290", Length = "0x197")]
	private void RecheckObjectDisablers(GameObject go)
	{
	}

	[Token(Token = "0x6002BD1")]
	[Address(RVA = "0x926630", Offset = "0x925430", Length = "0x176")]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[Token(Token = "0x6002BD2")]
	[Address(RVA = "0x9267B0", Offset = "0x9255B0", Length = "0x1BF")]
	public RandomSpawnObject()
	{
	}
}
