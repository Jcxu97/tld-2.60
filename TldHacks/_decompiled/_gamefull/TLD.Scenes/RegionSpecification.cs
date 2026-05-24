using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.Stats;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Scenes;

[CreateAssetMenu(menuName = "The Long Dark/Scenes/Region Specification")]
[Token(Token = "0x200135E")]
public class RegionSpecification : ZoneSpecification
{
	[Flags]
	[Token(Token = "0x200135F")]
	public enum UnlockMode
	{
		[Token(Token = "0x4008EA0")]
		Unlocked = 0,
		[Token(Token = "0x4008EA1")]
		Visited = 1,
		[Token(Token = "0x4008EA2")]
		Code = 2
	}

	[Header("Region Info")]
	[SerializeField]
	[Token(Token = "0x4008E97")]
	[FieldOffset(Offset = "0x68")]
	private LocalizedString m_RegionDescription;

	[SerializeField]
	[Token(Token = "0x4008E98")]
	[FieldOffset(Offset = "0x70")]
	private AssetReferenceTexture2D m_MiniMap;

	[GameObjectWithComponentAsset(typeof(SelectRegionItem))]
	[SerializeField]
	[Token(Token = "0x4008E99")]
	[FieldOffset(Offset = "0x78")]
	private AssetReferenceGameObject m_SelectRegionPrefab;

	[SerializeField]
	[Token(Token = "0x4008E9A")]
	[FieldOffset(Offset = "0x80")]
	private List<SceneSet> m_InteriorSpawnScenes;

	[SerializeField]
	[Token(Token = "0x4008E9B")]
	[FieldOffset(Offset = "0x88")]
	private UnlockMode m_UnlockMode;

	[Header("Stats")]
	[Token(Token = "0x4008E9C")]
	[FieldOffset(Offset = "0x8C")]
	public StatID m_HoursInRegionStat;

	[Header("Life After Death")]
	[SerializeField]
	[Token(Token = "0x4008E9D")]
	[FieldOffset(Offset = "0x90")]
	private List<AssetReferenceT<SceneSet>> m_SafeRespawnScenes;

	[SerializeField]
	[Token(Token = "0x4008E9E")]
	[FieldOffset(Offset = "0x98")]
	private List<AssetReferenceT<SceneSet>> m_RiskyRespawnScenes;

	[Token(Token = "0x17000A58")]
	public string RegionDescription
	{
		[Token(Token = "0x6007BA9")]
		[Address(RVA = "0x11A8420", Offset = "0x11A7220", Length = "0x1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A59")]
	public string LocalizedRegionDescription
	{
		[Token(Token = "0x6007BAA")]
		[Address(RVA = "0x6BE0D0", Offset = "0x6BCED0", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A5A")]
	public bool HasMiniMapTexture
	{
		[Token(Token = "0x6007BAB")]
		[Address(RVA = "0x11A8440", Offset = "0x11A7240", Length = "0x2A")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A5B")]
	public bool HasSelectRegionItem
	{
		[Token(Token = "0x6007BAC")]
		[Address(RVA = "0x11A8470", Offset = "0x11A7270", Length = "0x2A")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A5C")]
	public int IndoorSpawnCount
	{
		[Token(Token = "0x6007BAD")]
		[Address(RVA = "0x11A84A0", Offset = "0x11A72A0", Length = "0x44")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6007BAE")]
	[Address(RVA = "0x11A84F0", Offset = "0x11A72F0", Length = "0x73")]
	public SceneSet GetIndoorSpawnScene(int index)
	{
		return null;
	}

	[Token(Token = "0x6007BAF")]
	[Address(RVA = "0x11A8570", Offset = "0x11A7370", Length = "0x93")]
	public AsyncOperationHandle<Texture2D> GetMiniMapTextureAsync()
	{
		return default(AsyncOperationHandle<Texture2D>);
	}

	[Token(Token = "0x6007BB0")]
	[Address(RVA = "0x11A8610", Offset = "0x11A7410", Length = "0x96")]
	public AsyncOperationHandle<GameObject> InstantiateSelectRegionItemAsync(Transform parent)
	{
		return default(AsyncOperationHandle<GameObject>);
	}

	[Token(Token = "0x6007BB1")]
	[Address(RVA = "0x11A86B0", Offset = "0x11A74B0", Length = "0x15")]
	public List<AssetReferenceT<SceneSet>> GetRespawnScenes(LifeAfterDeathSpawnPointType spawnType)
	{
		return null;
	}

	[Token(Token = "0x6007BB2")]
	[Address(RVA = "0x11A86D0", Offset = "0x11A74D0", Length = "0xC0")]
	public bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6007BB3")]
	[Address(RVA = "0x11A87A0", Offset = "0x11A75A0", Length = "0xC")]
	public void Visit()
	{
	}

	[Token(Token = "0x6007BB4")]
	[Address(RVA = "0x11A87B0", Offset = "0x11A75B0", Length = "0xC")]
	public void ForceUnlock()
	{
	}

	[Token(Token = "0x6007BB5")]
	[Address(RVA = "0x11A87C0", Offset = "0x11A75C0", Length = "0x139")]
	private void MaybeUnlock(UnlockMode reason)
	{
	}

	[Token(Token = "0x6007BB6")]
	[Address(RVA = "0x11A8900", Offset = "0x11A7700", Length = "0xA7")]
	private bool HasBeenVisited()
	{
		return false;
	}

	[Token(Token = "0x6007BB7")]
	[Address(RVA = "0x11A89B0", Offset = "0x11A77B0", Length = "0x58")]
	public RegionSpecification()
	{
	}
}
