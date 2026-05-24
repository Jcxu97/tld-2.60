using Cpp2ILInjected;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[Token(Token = "0x2000D3E")]
public class ExportMeshWithEdgeFall : MonoBehaviour
{
	[Token(Token = "0x40082B4")]
	[FieldOffset(Offset = "0x20")]
	public TerrainData terrainData;

	[Token(Token = "0x40082B5")]
	[FieldOffset(Offset = "0x28")]
	public int vertexCountHorizontal;

	[Token(Token = "0x40082B6")]
	[FieldOffset(Offset = "0x2C")]
	public int vertexCountVertical;

	[Token(Token = "0x40082B7")]
	[FieldOffset(Offset = "0x30")]
	public EdgeFall edgeFall;

	[Token(Token = "0x40082B8")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D edgeFallTexture;

	[Token(Token = "0x60067EC")]
	[Address(RVA = "0x105B210", Offset = "0x105A010", Length = "0x36C")]
	private void Start()
	{
	}

	[Token(Token = "0x60067ED")]
	[Address(RVA = "0x105B580", Offset = "0x105A380", Length = "0x124")]
	public ExportMeshWithEdgeFall()
	{
	}
}
