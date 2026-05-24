using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20007C2")]
public class RadialSpawnManager : MonoBehaviour
{
	[Token(Token = "0x4005393")]
	private const int NUM_PROCESS_PER_FRAME = 5;

	[Token(Token = "0x4005394")]
	private const int MAX_OBJECT_POOL_SIZE_PER_PREFAB = 128;

	[Token(Token = "0x4005395")]
	private const int MAX_OBJECT_POOL_SIZE_PER_UNCOMMON_PREFAB = 32;

	[Token(Token = "0x4005396")]
	public static bool m_Debug;

	[Token(Token = "0x4005397")]
	private static List<RadialObjectSpawner> m_RadialSpawnObjects;

	[Token(Token = "0x4005398")]
	private static List<RadialObjectSpawner> m_ActiveRadialSpawnObjects;

	[Token(Token = "0x4005399")]
	[FieldOffset(Offset = "0x20")]
	private bool m_DoneFirstUpdate;

	[Token(Token = "0x400539A")]
	[FieldOffset(Offset = "0x21")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x400539B")]
	[FieldOffset(Offset = "0x24")]
	private int m_CurrentIndex;

	[Token(Token = "0x400539C")]
	private static readonly List<RadialObjectSpawner> m_RadialSpawnObjectsToSerialize;

	[Token(Token = "0x400539D")]
	private static Dictionary<string, Stack<GameObject>> m_ObjectPoolDict;

	[Token(Token = "0x400539E")]
	private static List<AsyncOperationHandle<GameObject>> m_OperationHandles;

	[Token(Token = "0x600495D")]
	[Address(RVA = "0xD1B9B0", Offset = "0xD1A7B0", Length = "0xF4")]
	public void Start()
	{
	}

	[Token(Token = "0x600495E")]
	[Address(RVA = "0xD1BAB0", Offset = "0xD1A8B0", Length = "0xBE")]
	public static void Register(RadialObjectSpawner ros)
	{
	}

	[Token(Token = "0x600495F")]
	[Address(RVA = "0xD1BB70", Offset = "0xD1A970", Length = "0xA9")]
	public static void Unregister(RadialObjectSpawner ros)
	{
	}

	[Token(Token = "0x6004960")]
	[Address(RVA = "0xD1BC20", Offset = "0xD1AA20", Length = "0x295")]
	public void Update()
	{
	}

	[Token(Token = "0x6004961")]
	[Address(RVA = "0xD1BEC0", Offset = "0xD1ACC0", Length = "0x48F")]
	public string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6004962")]
	[Address(RVA = "0xD1C350", Offset = "0xD1B150", Length = "0x35E")]
	public void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6004963")]
	[Address(RVA = "0xD1C6B0", Offset = "0xD1B4B0", Length = "0x228")]
	private void MaybeAllocateForObjectPool(GameObject prefab)
	{
	}

	[Token(Token = "0x6004964")]
	[Address(RVA = "0xD1C8E0", Offset = "0xD1B6E0", Length = "0x1A6")]
	private RadialObjectSpawner FindRadialObjectSpawnerByPosition(RadialObjectSpawnerSaveData proxy, RadialObjectSpawner[] spawners)
	{
		return null;
	}

	[Token(Token = "0x6004965")]
	[Address(RVA = "0xD1CA90", Offset = "0xD1B890", Length = "0x117")]
	private RadialObjectSpawner FindRadialObjectSpawnerByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6004966")]
	[Address(RVA = "0xD1CBB0", Offset = "0xD1B9B0", Length = "0x1A1")]
	private void DoFirstUpdateForAllRadialSpawnObjects()
	{
	}

	[Token(Token = "0x6004967")]
	[Address(RVA = "0xD1CD60", Offset = "0xD1BB60", Length = "0x3E6")]
	private void UpdateRadialSpawnObjectsActiveList()
	{
	}

	[Token(Token = "0x6004968")]
	[Address(RVA = "0xD1D150", Offset = "0xD1BF50", Length = "0x2B9")]
	private void ProcessActiveRadialSpawnObjects()
	{
	}

	[Token(Token = "0x6004969")]
	[Address(RVA = "0xD1D410", Offset = "0xD1C210", Length = "0xCC")]
	public static void ResetRadialSpawnerList()
	{
	}

	[Token(Token = "0x600496A")]
	[Address(RVA = "0xD1D4E0", Offset = "0xD1C2E0", Length = "0x2C3")]
	public static void InitObjectPools()
	{
	}

	[Token(Token = "0x600496B")]
	[Address(RVA = "0xD1D7B0", Offset = "0xD1C5B0", Length = "0xBC")]
	private static int GetCountInObjectPool(string prefabName)
	{
		return 0;
	}

	[Token(Token = "0x600496C")]
	[Address(RVA = "0xD1D870", Offset = "0xD1C670", Length = "0x27F")]
	public static GameObject TakeFromObjectPool(string prefabName)
	{
		return null;
	}

	[Token(Token = "0x600496D")]
	[Address(RVA = "0xD1DAF0", Offset = "0xD1C8F0", Length = "0x185")]
	public static bool ReturnToObjectPool(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x600496E")]
	[Address(RVA = "0xD1DC80", Offset = "0xD1CA80", Length = "0x13B")]
	private static void AddToPools(GameObject go)
	{
	}

	[Token(Token = "0x600496F")]
	[Address(RVA = "0xD1DDC0", Offset = "0xD1CBC0", Length = "0x1A3")]
	public static void InstantiateForObjectPool(AssetReferenceGearItem assetReference, int count)
	{
	}

	[Token(Token = "0x6004970")]
	[Address(RVA = "0xD1DF70", Offset = "0xD1CD70", Length = "0x18F")]
	public static void InstantiateForObjectPool(string prefabName, int count)
	{
	}

	[Token(Token = "0x6004971")]
	[Address(RVA = "0xD1E100", Offset = "0xD1CF00", Length = "0x348")]
	private static void InstantiatePrefabForObjectPool(GameObject prefab, int count)
	{
	}

	[Token(Token = "0x6004972")]
	[Address(RVA = "0xD1E450", Offset = "0xD1D250", Length = "0x15A")]
	private static GameObject GetPrefabFromAssetReference(AssetReferenceGearItem assetReference)
	{
		return null;
	}

	[Token(Token = "0x6004973")]
	[Address(RVA = "0xD1E5B0", Offset = "0xD1D3B0", Length = "0x146")]
	private static GameObject GetPrefabFromName(string name)
	{
		return null;
	}

	[Token(Token = "0x6004974")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RadialSpawnManager()
	{
	}
}
