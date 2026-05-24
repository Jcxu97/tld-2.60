using Cpp2ILInjected;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[Token(Token = "0x2000D3A")]
public class ExportMesh : MonoBehaviour
{
	[Token(Token = "0x400829E")]
	[FieldOffset(Offset = "0x20")]
	public TerrainData terrainData;

	[Token(Token = "0x400829F")]
	[FieldOffset(Offset = "0x28")]
	public int vertexCountHorizontal;

	[Token(Token = "0x40082A0")]
	[FieldOffset(Offset = "0x2C")]
	public int vertexCountVertical;

	[Token(Token = "0x60067E0")]
	[Address(RVA = "0x10594B0", Offset = "0x10582B0", Length = "0x1BF")]
	private void Start()
	{
	}

	[Token(Token = "0x60067E1")]
	[Address(RVA = "0x10586F0", Offset = "0x10574F0", Length = "0x51")]
	public ExportMesh()
	{
	}
}
