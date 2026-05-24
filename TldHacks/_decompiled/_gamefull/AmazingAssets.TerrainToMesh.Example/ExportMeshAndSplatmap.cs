using Cpp2ILInjected;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[Token(Token = "0x2000D3D")]
public class ExportMeshAndSplatmap : MonoBehaviour
{
	[Token(Token = "0x40082AF")]
	[FieldOffset(Offset = "0x20")]
	public TerrainData terrainData;

	[Token(Token = "0x40082B0")]
	[FieldOffset(Offset = "0x28")]
	public int vertexCountHorizontal;

	[Token(Token = "0x40082B1")]
	[FieldOffset(Offset = "0x2C")]
	public int vertexCountVertical;

	[Token(Token = "0x40082B2")]
	[FieldOffset(Offset = "0x30")]
	public bool terrainHasHoles;

	[Token(Token = "0x40082B3")]
	[FieldOffset(Offset = "0x31")]
	public bool createFallbackTextures;

	[Token(Token = "0x60067EA")]
	[Address(RVA = "0x105AF80", Offset = "0x1059D80", Length = "0x289")]
	private void Start()
	{
	}

	[Token(Token = "0x60067EB")]
	[Address(RVA = "0x10586F0", Offset = "0x10574F0", Length = "0x51")]
	public ExportMeshAndSplatmap()
	{
	}
}
