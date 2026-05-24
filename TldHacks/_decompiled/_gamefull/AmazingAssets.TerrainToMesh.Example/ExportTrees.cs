using Cpp2ILInjected;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[Token(Token = "0x2000D3F")]
public class ExportTrees : MonoBehaviour
{
	[Token(Token = "0x40082B9")]
	[FieldOffset(Offset = "0x20")]
	public TerrainData terrainData;

	[Token(Token = "0x40082BA")]
	[FieldOffset(Offset = "0x28")]
	public int vertexCountHorizontal;

	[Token(Token = "0x40082BB")]
	[FieldOffset(Offset = "0x2C")]
	public int vertexCountVertical;

	[Token(Token = "0x60067EE")]
	[Address(RVA = "0x105B6B0", Offset = "0x105A4B0", Length = "0x5B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60067EF")]
	[Address(RVA = "0x10586F0", Offset = "0x10574F0", Length = "0x51")]
	public ExportTrees()
	{
	}
}
