using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000782")]
public class LineRenderManager
{
	[Token(Token = "0x4005086")]
	private static Material m_AdditiveMaterial;

	[Token(Token = "0x4005087")]
	private static List<LineRenderer> m_LineRenederers;

	[Token(Token = "0x6004672")]
	[Address(RVA = "0xCA6680", Offset = "0xCA5480", Length = "0x21F")]
	public static Material GetAdditiveMaterial()
	{
		return null;
	}

	[Token(Token = "0x6004673")]
	[Address(RVA = "0xCA68A0", Offset = "0xCA56A0", Length = "0x519")]
	public static LineRenderer CreateLineRenderer(string name, Color color, float width, Material material)
	{
		return null;
	}

	[Token(Token = "0x6004674")]
	[Address(RVA = "0xCA6DC0", Offset = "0xCA5BC0", Length = "0x1B0")]
	public static void DestroyLineRenderer(LineRenderer lineRenderer)
	{
	}

	[Token(Token = "0x6004675")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LineRenderManager()
	{
	}
}
