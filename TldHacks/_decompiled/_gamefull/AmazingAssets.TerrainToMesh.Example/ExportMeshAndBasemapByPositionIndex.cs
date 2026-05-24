using Cpp2ILInjected;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[Token(Token = "0x2000D3C")]
public class ExportMeshAndBasemapByPositionIndex : MonoBehaviour
{
	[Token(Token = "0x40082A6")]
	[FieldOffset(Offset = "0x20")]
	public TerrainData terrainData;

	[Token(Token = "0x40082A7")]
	[FieldOffset(Offset = "0x28")]
	public int vertexCountHorizontal;

	[Token(Token = "0x40082A8")]
	[FieldOffset(Offset = "0x2C")]
	public int vertexCountVertical;

	[Token(Token = "0x40082A9")]
	[FieldOffset(Offset = "0x30")]
	public int mapsResolution;

	[Token(Token = "0x40082AA")]
	[FieldOffset(Offset = "0x34")]
	public bool exportHoles;

	[Token(Token = "0x40082AB")]
	[FieldOffset(Offset = "0x38")]
	private int chunkCountHorizontal;

	[Token(Token = "0x40082AC")]
	[FieldOffset(Offset = "0x3C")]
	private int chunkCountVertical;

	[Header("Chunk count is 4x4")]
	[Range(0f, 3f)]
	[Token(Token = "0x40082AD")]
	[FieldOffset(Offset = "0x40")]
	public int positionX;

	[Range(0f, 3f)]
	[Token(Token = "0x40082AE")]
	[FieldOffset(Offset = "0x44")]
	public int positionY;

	[Token(Token = "0x60067E6")]
	[Address(RVA = "0x105A1F0", Offset = "0x1058FF0", Length = "0x6CF")]
	private void Start()
	{
	}

	[Token(Token = "0x60067E7")]
	[Address(RVA = "0x105A8C0", Offset = "0x10596C0", Length = "0x449")]
	private void InitializeMaterial(Material material)
	{
	}

	[Token(Token = "0x60067E8")]
	[Address(RVA = "0x105AD10", Offset = "0x1059B10", Length = "0x1F6")]
	private void SetupAlphaTest(Material material)
	{
	}

	[Token(Token = "0x60067E9")]
	[Address(RVA = "0x105AF10", Offset = "0x1059D10", Length = "0x66")]
	public ExportMeshAndBasemapByPositionIndex()
	{
	}
}
