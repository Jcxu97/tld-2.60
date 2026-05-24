using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(menuName = "The Long Dark/Scenes/Distance Field Settings")]
[Token(Token = "0x20008FE")]
public class SceneDistanceFieldSettings : ScriptableObject
{
	[Token(Token = "0x4005E39")]
	[FieldOffset(Offset = "0x18")]
	public bool m_FullyDisable;

	[Token(Token = "0x4005E3A")]
	[FieldOffset(Offset = "0x19")]
	public bool m_IgnoreNearSDF;

	[Token(Token = "0x4005E3B")]
	[FieldOffset(Offset = "0x1A")]
	public bool m_SkipTerrainForSDF;

	[Token(Token = "0x4005E3C")]
	[FieldOffset(Offset = "0x1B")]
	public bool m_DisableAmbientOcclusion;

	[Token(Token = "0x4005E3D")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_DisableDirectionalShadows;

	[Token(Token = "0x4005E3E")]
	[FieldOffset(Offset = "0x1D")]
	public bool m_DisableTerrainShadows;

	[Token(Token = "0x4005E3F")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask m_SupportedMeshLayers;

	[Token(Token = "0x4005E40")]
	[FieldOffset(Offset = "0x24")]
	public float m_TargetVoxelDensity;

	[Token(Token = "0x4005E41")]
	[FieldOffset(Offset = "0x28")]
	public int m_MaxVolumeResolution;

	[Token(Token = "0x4005E42")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MinimumMeshVolume;

	[Token(Token = "0x4005E43")]
	[FieldOffset(Offset = "0x30")]
	public float m_MaximumMeshVolume;

	[Token(Token = "0x4005E44")]
	[FieldOffset(Offset = "0x34")]
	public Vector3Int m_FarSDFResolution;

	[Token(Token = "0x4005E45")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_FarSDFArea;

	[Token(Token = "0x4005E46")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3Int m_NearSDFResolution;

	[Token(Token = "0x4005E47")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_NearSDFArea;

	[Token(Token = "0x4005E48")]
	[FieldOffset(Offset = "0x68")]
	public AssetReferenceTexture2D m_TerrainShadowHeightmap;

	[Token(Token = "0x4005E49")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 m_TerrainShadowHeightmapMinCoords;

	[Token(Token = "0x4005E4A")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 m_TerrainShadowHeightmapMaxCoords;

	[Token(Token = "0x600524E")]
	[Address(RVA = "0xE468F0", Offset = "0xE456F0", Length = "0x15A")]
	public SceneDistanceFieldSettings()
	{
	}
}
