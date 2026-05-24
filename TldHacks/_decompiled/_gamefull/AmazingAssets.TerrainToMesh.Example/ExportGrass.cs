using Cpp2ILInjected;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[Token(Token = "0x2000D39")]
public class ExportGrass : MonoBehaviour
{
	[Token(Token = "0x400829B")]
	[FieldOffset(Offset = "0x20")]
	public TerrainData terrainData;

	[Token(Token = "0x400829C")]
	[FieldOffset(Offset = "0x28")]
	public int vertexCountHorizontal;

	[Token(Token = "0x400829D")]
	[FieldOffset(Offset = "0x2C")]
	public int vertexCountVertical;

	[Token(Token = "0x60067DD")]
	[Address(RVA = "0x1058750", Offset = "0x1057550", Length = "0xA65")]
	private void Start()
	{
	}

	[Token(Token = "0x60067DE")]
	[Address(RVA = "0x10591C0", Offset = "0x1057FC0", Length = "0x2EB")]
	private void BakeHealthyAndDryColorsInsideVertexColor(Mesh mesh, DetailPrototype detailPrototype)
	{
	}

	[Token(Token = "0x60067DF")]
	[Address(RVA = "0x10586F0", Offset = "0x10574F0", Length = "0x51")]
	public ExportGrass()
	{
	}
}
