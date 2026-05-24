using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000403")]
public class TerrainMaterialBlendingManager : MonoBehaviour
{
	[Token(Token = "0x400240C")]
	private static readonly int s_TerrainBlendingDiffuseArrayID;

	[Token(Token = "0x400240D")]
	private static readonly int s_TerrainBlendingTerrainCountID;

	[Token(Token = "0x400240E")]
	private static readonly int s_TerrainBlendingLayerParamsID;

	[Token(Token = "0x400240F")]
	private static readonly int s_TerrainBlendingMipBiasesID;

	[Token(Token = "0x4002410")]
	private static readonly int s_TerrainDitherID;

	[Token(Token = "0x4002411")]
	private static readonly int s_TerrainWorldPositionsID;

	[Token(Token = "0x4002412")]
	private static readonly int s_TerrainWorldSizesID;

	[Token(Token = "0x4002413")]
	private static readonly int s_TerrainVerticalSizesID;

	[Token(Token = "0x4002414")]
	private static readonly int s_TerrainResolutionsMinusOneID;

	[Token(Token = "0x4002415")]
	private static readonly int s_TerrainBlendingEnabledID;

	[Token(Token = "0x4002416")]
	private static readonly int s_TerrainBlendingHeightThresholdID;

	[Token(Token = "0x4002417")]
	private static readonly int s_TerrainBlendingDitherScale;

	[Token(Token = "0x4002418")]
	private static readonly int s_TerrainBlendingDitherStrength;

	[Token(Token = "0x4002419")]
	private static readonly int s_TerrainBlendingDitherOffset;

	[Token(Token = "0x400241A")]
	private static readonly int s_TerrainBlendTessellationEnabled;

	[Token(Token = "0x400241B")]
	private static readonly int s_TerrainBlendTessellationMinDist;

	[Token(Token = "0x400241C")]
	private static readonly int s_TerrainBlendTessellationMaxDist;

	[Token(Token = "0x400241D")]
	private static readonly int s_TerrainBlendTessellationValue;

	[Token(Token = "0x400241E")]
	private static readonly int s_TerrainBlendTessellationEdgeLength;

	[Token(Token = "0x400241F")]
	private static readonly int s_TerrainBlendSpreadPower;

	[Token(Token = "0x4002420")]
	private static readonly int s_TerrainBlendPower;

	[Token(Token = "0x4002421")]
	private static readonly int s_TerrainBlendHeight;

	[Token(Token = "0x4002422")]
	private static readonly int s_TerrainBlendMaxSpread;

	[Token(Token = "0x4002423")]
	[FieldOffset(Offset = "0x20")]
	public bool m_EnableBlending;

	[Token(Token = "0x4002424")]
	[FieldOffset(Offset = "0x21")]
	public bool m_EnableTessellation;

	[Token(Token = "0x4002425")]
	[FieldOffset(Offset = "0x24")]
	public float m_heightBlendingThreshold;

	[Token(Token = "0x4002426")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D m_ditherTexture;

	[Token(Token = "0x4002427")]
	[FieldOffset(Offset = "0x30")]
	public float m_ditherScale;

	[Token(Token = "0x4002428")]
	[FieldOffset(Offset = "0x34")]
	public float m_ditherStrength;

	[Range(-1f, 1f)]
	[Token(Token = "0x4002429")]
	[FieldOffset(Offset = "0x38")]
	public float m_ditherOffset;

	[Token(Token = "0x400242A")]
	[FieldOffset(Offset = "0x3C")]
	public float m_TessellationMinDistance;

	[Token(Token = "0x400242B")]
	[FieldOffset(Offset = "0x40")]
	public float m_TessellationMaxDistance;

	[Token(Token = "0x400242C")]
	[FieldOffset(Offset = "0x44")]
	public float m_TessellationValue;

	[Token(Token = "0x400242D")]
	[FieldOffset(Offset = "0x48")]
	public float m_TessellationEdgeLength;

	[Token(Token = "0x400242E")]
	[FieldOffset(Offset = "0x4C")]
	public float m_BlendSpreadPower;

	[Token(Token = "0x400242F")]
	[FieldOffset(Offset = "0x50")]
	public float m_BlendPower;

	[Token(Token = "0x4002430")]
	[FieldOffset(Offset = "0x54")]
	public float m_BlendHeight;

	[Token(Token = "0x4002431")]
	[FieldOffset(Offset = "0x58")]
	public float m_MaxSpread;

	[Token(Token = "0x4002432")]
	[FieldOffset(Offset = "0x5C")]
	private int m_splatmapCount;

	[Token(Token = "0x4002433")]
	[FieldOffset(Offset = "0x60")]
	private int m_diffuseCount;

	[Token(Token = "0x4002434")]
	[FieldOffset(Offset = "0x64")]
	private int m_terrainCount;

	[Token(Token = "0x4002435")]
	private const int MAX_SAMPLED_TERRAINS = 4;

	[Token(Token = "0x4002436")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsBlendingEnabled;

	[Token(Token = "0x4002437")]
	[FieldOffset(Offset = "0x70")]
	private List<Terrain> m_ActiveTerrains;

	[Token(Token = "0x4002438")]
	[FieldOffset(Offset = "0x78")]
	private Terrain[] m_SampledTerrains;

	[Token(Token = "0x4002439")]
	[FieldOffset(Offset = "0x80")]
	private HashSet<Terrain> m_SampledTerrainsPrev;

	[Token(Token = "0x400243A")]
	[FieldOffset(Offset = "0x88")]
	private HashSet<Terrain> m_SampledTerrainsNext;

	[Token(Token = "0x400243B")]
	[FieldOffset(Offset = "0x90")]
	private readonly Vector4[] m_blendingParams;

	[Token(Token = "0x400243C")]
	[FieldOffset(Offset = "0x98")]
	private readonly float[] m_blendingMipBiases;

	[Token(Token = "0x400243D")]
	[FieldOffset(Offset = "0xA0")]
	private readonly Vector4[] m_terrainWorldPositions;

	[Token(Token = "0x400243E")]
	[FieldOffset(Offset = "0xA8")]
	private readonly Vector4[] m_terrainResolutionsMinusOne;

	[Token(Token = "0x400243F")]
	[FieldOffset(Offset = "0xB0")]
	private readonly Vector4[] m_terrainWorldSizes;

	[Token(Token = "0x4002440")]
	[FieldOffset(Offset = "0xB8")]
	private readonly Vector4[] m_terrainVerticalSizes;

	[Token(Token = "0x4002441")]
	[FieldOffset(Offset = "0xC0")]
	private Texture2DArray m_terrainBlendingDiffuseArray;

	[Token(Token = "0x6001E99")]
	[Address(RVA = "0x7C3490", Offset = "0x7C2290", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001E9A")]
	[Address(RVA = "0x7C34A0", Offset = "0x7C22A0", Length = "0x5FF")]
	public void EnableBlending()
	{
	}

	[Token(Token = "0x6001E9B")]
	[Address(RVA = "0x7C3AA0", Offset = "0x7C28A0", Length = "0xFD5")]
	public void DisableBlending()
	{
	}

	[Token(Token = "0x6001E9C")]
	[Address(RVA = "0x7C4A80", Offset = "0x7C3880", Length = "0xD2")]
	private bool CheckIfTerrainIsExcluded(Terrain terrain)
	{
		return false;
	}

	[Token(Token = "0x6001E9D")]
	[Address(RVA = "0x7C4B60", Offset = "0x7C3960", Length = "0xE")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E9E")]
	[Address(RVA = "0x7C4B70", Offset = "0x7C3970", Length = "0x1B93")]
	private void MaybeUpdateSampledTerrains()
	{
	}

	[Token(Token = "0x6001E9F")]
	[Address(RVA = "0x7C6710", Offset = "0x7C5510", Length = "0x221")]
	private Bounds Get2DTerrainBounds(Terrain t)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6001EA0")]
	[Address(RVA = "0x7C6940", Offset = "0x7C5740", Length = "0x491")]
	public TerrainMaterialBlendingManager()
	{
	}
}
