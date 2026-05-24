using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace TLD.Scenes;

[CreateAssetMenu(menuName = "The Long Dark/Scenes/Zone Specification")]
[Token(Token = "0x2001369")]
public class ZoneSpecification : ScriptableObject
{
	[Token(Token = "0x4008ECE")]
	public const string ZONE_LABEL = "Zone";

	[Token(Token = "0x4008ECF")]
	public static readonly IList<string> ZONE_KEYS;

	[SerializeField]
	[Token(Token = "0x4008ED0")]
	[FieldOffset(Offset = "0x18")]
	private WorldMapSpecification m_WorldMap;

	[SerializeField]
	[Token(Token = "0x4008ED1")]
	[FieldOffset(Offset = "0x20")]
	private WorldToMap m_WorldToMap;

	[GameObjectWithComponentAsset(typeof(FogOfWar))]
	[SerializeField]
	[Token(Token = "0x4008ED2")]
	[FieldOffset(Offset = "0x40")]
	private AssetReferenceGameObject m_RegionMap;

	[GameObjectWithComponentAsset(typeof(MapIcon))]
	[SerializeField]
	[Token(Token = "0x4008ED3")]
	[FieldOffset(Offset = "0x48")]
	private AssetReferenceGameObject m_MainMapIcon;

	[SerializeField]
	[Token(Token = "0x4008ED4")]
	[FieldOffset(Offset = "0x50")]
	private AssetReferenceTexture2D m_TOCTexture;

	[SerializeField]
	[Token(Token = "0x4008ED5")]
	[FieldOffset(Offset = "0x58")]
	private SceneSet m_Scenes;

	[SerializeField]
	[Token(Token = "0x4008ED6")]
	[FieldOffset(Offset = "0x60")]
	private ZoneSpecification m_ParentZoneSpecification;

	[Token(Token = "0x17000A6B")]
	public SceneSet Scenes
	{
		[Token(Token = "0x6007BF3")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A6C")]
	public ZoneSpecification ParentZoneSpecification
	{
		[Token(Token = "0x6007BF4")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A6D")]
	public string ZoneName
	{
		[Token(Token = "0x6007BF5")]
		[Address(RVA = "0x11ADEE0", Offset = "0x11ACCE0", Length = "0x140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A6E")]
	public string ZoneNameId
	{
		[Token(Token = "0x6007BF6")]
		[Address(RVA = "0x11AE030", Offset = "0x11ACE30", Length = "0x101")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A6F")]
	public bool HasRegionMap
	{
		[Token(Token = "0x6007BF7")]
		[Address(RVA = "0x11AE140", Offset = "0x11ACF40", Length = "0x2A")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A70")]
	public bool HasMapIcon
	{
		[Token(Token = "0x6007BF8")]
		[Address(RVA = "0x11AE170", Offset = "0x11ACF70", Length = "0x2A")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A71")]
	public WorldMapSpecification WorldMap
	{
		[Token(Token = "0x6007BF9")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A72")]
	public WorldToMap WorldToMap
	{
		[Token(Token = "0x6007BFA")]
		[Address(RVA = "0x11AE1A0", Offset = "0x11ACFA0", Length = "0x1B")]
		get
		{
			return default(WorldToMap);
		}
	}

	[Token(Token = "0x6007BFB")]
	[Address(RVA = "0x11AE1C0", Offset = "0x11ACFC0", Length = "0x96")]
	public AsyncOperationHandle<GameObject> InstantiateRegionMapAsync(Transform parent)
	{
		return default(AsyncOperationHandle<GameObject>);
	}

	[Token(Token = "0x6007BFC")]
	[Address(RVA = "0x11AE260", Offset = "0x11AD060", Length = "0x96")]
	public AsyncOperationHandle<GameObject> InstantiateMapIconAsync(Transform parent)
	{
		return default(AsyncOperationHandle<GameObject>);
	}

	[Token(Token = "0x6007BFD")]
	[Address(RVA = "0x11AE300", Offset = "0x11AD100", Length = "0xBE")]
	public Texture2D GetTOCTexture()
	{
		return null;
	}

	[Token(Token = "0x6007BFE")]
	[Address(RVA = "0x11AE3C0", Offset = "0x11AD1C0", Length = "0x173")]
	public IList<AsyncOperationHandle<SceneInstance>> LoadRegionAsync(ICollection<SceneLoadCondition> conditions = null)
	{
		return null;
	}

	[Token(Token = "0x6007BFF")]
	[Address(RVA = "0x11AE540", Offset = "0x11AD340", Length = "0x151")]
	public IList<AsyncOperationHandle<SceneInstance>> UnloadRegionAsync()
	{
		return null;
	}

	[Token(Token = "0x6007C00")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ZoneSpecification()
	{
	}
}
