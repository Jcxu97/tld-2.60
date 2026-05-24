using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[Token(Token = "0x2000BDE")]
public static class MeshGenerator
{
	[Token(Token = "0x4007956")]
	private const float kMinTruncatedRadius = 0.001f;

	[Token(Token = "0x6005D99")]
	[Address(RVA = "0xF676F0", Offset = "0xF664F0", Length = "0x12")]
	private static float GetAngleOffset(int numSides)
	{
		return 0f;
	}

	[Token(Token = "0x6005D9A")]
	[Address(RVA = "0xF67710", Offset = "0xF66510", Length = "0x7F")]
	public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}

	[Token(Token = "0x6005D9B")]
	[Address(RVA = "0xF67790", Offset = "0xF66590", Length = "0x7A")]
	public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}

	[Token(Token = "0x6005D9C")]
	[Address(RVA = "0xF67810", Offset = "0xF66610", Length = "0xB2D")]
	public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}

	[Token(Token = "0x6005D9D")]
	[Address(RVA = "0xF68340", Offset = "0xF67140", Length = "0x59")]
	public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6005D9E")]
	[Address(RVA = "0xF683A0", Offset = "0xF671A0", Length = "0x19")]
	public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
	{
		return 0;
	}

	[Token(Token = "0x6005D9F")]
	[Address(RVA = "0xF683C0", Offset = "0xF671C0", Length = "0x25")]
	public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
	{
		return 0;
	}

	[Token(Token = "0x6005DA0")]
	[Address(RVA = "0xF683F0", Offset = "0xF671F0", Length = "0xAB")]
	public static int GetSharedMeshVertexCount()
	{
		return 0;
	}

	[Token(Token = "0x6005DA1")]
	[Address(RVA = "0xF684A0", Offset = "0xF672A0", Length = "0xAD")]
	public static int GetSharedMeshIndicesCount()
	{
		return 0;
	}
}
