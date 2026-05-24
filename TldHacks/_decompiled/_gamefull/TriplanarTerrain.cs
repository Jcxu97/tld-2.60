using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Terrain))]
[Token(Token = "0x200031E")]
public class TriplanarTerrain : MonoBehaviour
{
	[Token(Token = "0x4001B99")]
	[FieldOffset(Offset = "0x20")]
	public Shader m_Shader;

	[Range(1f, 16f)]
	[Tooltip("Lower values have more blending")]
	[Token(Token = "0x4001B9A")]
	[FieldOffset(Offset = "0x28")]
	public float m_BlendExponent;

	[Token(Token = "0x4001B9B")]
	[FieldOffset(Offset = "0x30")]
	private Material m_Material;

	[Token(Token = "0x4001B9C")]
	[FieldOffset(Offset = "0x38")]
	private Terrain m_Terrain;

	[Token(Token = "0x6001967")]
	[Address(RVA = "0x7353E0", Offset = "0x7341E0", Length = "0x2D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001968")]
	[Address(RVA = "0x7356C0", Offset = "0x7344C0", Length = "0x2ED")]
	private static void SetTerrainDimensions(Terrain t, Material m)
	{
	}

	[Token(Token = "0x6001969")]
	[Address(RVA = "0x7359B0", Offset = "0x7347B0", Length = "0x74C")]
	private static void SetTerrainTextures(Terrain t, Material m)
	{
	}

	[Token(Token = "0x600196A")]
	[Address(RVA = "0x736100", Offset = "0x734F00", Length = "0x4A")]
	public TriplanarTerrain()
	{
	}
}
