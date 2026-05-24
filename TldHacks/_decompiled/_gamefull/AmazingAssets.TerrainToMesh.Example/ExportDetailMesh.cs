using Cpp2ILInjected;
using UnityEngine;

namespace AmazingAssets.TerrainToMesh.Example;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[Token(Token = "0x2000D38")]
public class ExportDetailMesh : MonoBehaviour
{
	[Token(Token = "0x4008298")]
	[FieldOffset(Offset = "0x20")]
	public TerrainData terrainData;

	[Token(Token = "0x4008299")]
	[FieldOffset(Offset = "0x28")]
	public int vertexCountHorizontal;

	[Token(Token = "0x400829A")]
	[FieldOffset(Offset = "0x2C")]
	public int vertexCountVertical;

	[Token(Token = "0x60067DB")]
	[Address(RVA = "0x1058130", Offset = "0x1056F30", Length = "0x5BA")]
	private void Start()
	{
	}

	[Token(Token = "0x60067DC")]
	[Address(RVA = "0x10586F0", Offset = "0x10574F0", Length = "0x51")]
	public ExportDetailMesh()
	{
	}
}
