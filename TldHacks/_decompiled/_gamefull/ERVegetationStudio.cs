using Cpp2ILInjected;
using EasyRoads3Dv3;
using UnityEngine;

[Token(Token = "0x2000A9F")]
public class ERVegetationStudio : ScriptableObject
{
	[Token(Token = "0x6005C44")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool VegetationStudio()
	{
		return false;
	}

	[Token(Token = "0x6005C45")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool VegetationStudioPro()
	{
		return false;
	}

	[Token(Token = "0x6005C46")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CreateVegetationMaskLine(GameObject go, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[Token(Token = "0x6005C47")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void UpdateVegetationMaskLine(GameObject go, ERVSData[] vsData, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter)
	{
	}

	[Token(Token = "0x6005C48")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void UpdateHeightmap(Bounds bounds)
	{
	}

	[Token(Token = "0x6005C49")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void RemoveVegetationMaskLine(GameObject go)
	{
	}

	[Token(Token = "0x6005C4A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CreateBiomeArea(GameObject go, float distance, float blendDistance, float noise)
	{
	}

	[Token(Token = "0x6005C4B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void UpdateBiomeArea(GameObject go, ERVSData[] vsData, float distance, float blendDistance, float noise)
	{
	}

	[Token(Token = "0x6005C4C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void RemoveBiomeArea(GameObject go)
	{
	}

	[Token(Token = "0x6005C4D")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ERVegetationStudio()
	{
	}
}
