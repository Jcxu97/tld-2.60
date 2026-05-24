using Cpp2ILInjected;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[Token(Token = "0x2000D3B")]
public class ExportMeshAndBasemap : MonoBehaviour
{
	[Token(Token = "0x40082A1")]
	[FieldOffset(Offset = "0x20")]
	public TerrainData terrainData;

	[Token(Token = "0x40082A2")]
	[FieldOffset(Offset = "0x28")]
	public int vertexCountHorizontal;

	[Token(Token = "0x40082A3")]
	[FieldOffset(Offset = "0x2C")]
	public int vertexCountVertical;

	[Token(Token = "0x40082A4")]
	[FieldOffset(Offset = "0x30")]
	public int mapsResolution;

	[Token(Token = "0x40082A5")]
	[FieldOffset(Offset = "0x34")]
	public bool exportHoles;

	[Token(Token = "0x60067E2")]
	[Address(RVA = "0x1059670", Offset = "0x1058470", Length = "0x4C9")]
	private void Start()
	{
	}

	[Token(Token = "0x60067E3")]
	[Address(RVA = "0x1059B40", Offset = "0x1058940", Length = "0x449")]
	private void InitializeMaterial(Material material)
	{
	}

	[Token(Token = "0x60067E4")]
	[Address(RVA = "0x1059F90", Offset = "0x1058D90", Length = "0x1F6")]
	private void SetupAlphaTest(Material material)
	{
	}

	[Token(Token = "0x60067E5")]
	[Address(RVA = "0x105A190", Offset = "0x1058F90", Length = "0x58")]
	public ExportMeshAndBasemap()
	{
	}
}
