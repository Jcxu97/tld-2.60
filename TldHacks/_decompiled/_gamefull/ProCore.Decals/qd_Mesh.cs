using Cpp2ILInjected;
using UnityEngine;

namespace ProCore.Decals;

[Token(Token = "0x2001511")]
public class qd_Mesh
{
	[Token(Token = "0x4009863")]
	private static int[] BILLBOARD_TRIANGLES;

	[Token(Token = "0x4009864")]
	private static Vector3[] BILLBOARD_VERTICES;

	[Token(Token = "0x4009865")]
	private static Vector3[] BILLBOARD_NORMALS;

	[Token(Token = "0x4009866")]
	private static Vector4[] BILLBOARD_TANGENTS;

	[Token(Token = "0x4009867")]
	private static Vector2[] BILLBOARD_UV2;

	[Token(Token = "0x600851E")]
	[Address(RVA = "0x1272750", Offset = "0x1271550", Length = "0x583")]
	public static GameObject CreateDecal(string decalId, Material mat, Rect uvCoords, float scale, Material fullscreenDecalMaterial)
	{
		return null;
	}

	[Token(Token = "0x600851F")]
	[Address(RVA = "0x1272CE0", Offset = "0x1271AE0", Length = "0x7CC")]
	public static Mesh DecalMesh(string name, Material mat, Rect uvCoords, float scale)
	{
		return null;
	}

	[Token(Token = "0x6008520")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public qd_Mesh()
	{
	}
}
