using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003B0")]
public class HighlightFogManager : MonoBehaviour
{
	[Token(Token = "0x4002103")]
	[FieldOffset(Offset = "0x20")]
	public List<HighlightFogManaged> m_FogQuads;

	[Token(Token = "0x4002104")]
	[FieldOffset(Offset = "0x28")]
	public bool m_FadeAtNight;

	[Token(Token = "0x4002105")]
	[FieldOffset(Offset = "0x30")]
	private UniStormWeatherSystem m_UniStorm;

	[Token(Token = "0x4002106")]
	[FieldOffset(Offset = "0x38")]
	private List<Vector3> m_Headings;

	[Token(Token = "0x4002107")]
	[FieldOffset(Offset = "0x40")]
	private float m_TODMultiplier;

	[Token(Token = "0x6001D1F")]
	[Address(RVA = "0x795A80", Offset = "0x794880", Length = "0x2DE")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D20")]
	[Address(RVA = "0x795D60", Offset = "0x794B60", Length = "0x8D")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D21")]
	[Address(RVA = "0x795DF0", Offset = "0x794BF0", Length = "0x37A")]
	private void UpdateHeadings()
	{
	}

	[Token(Token = "0x6001D22")]
	[Address(RVA = "0x796170", Offset = "0x794F70", Length = "0x1BF")]
	private void UpdateTOD()
	{
	}

	[Token(Token = "0x6001D23")]
	[Address(RVA = "0x796330", Offset = "0x795130", Length = "0x41D")]
	private void UpdateQuads()
	{
	}

	[Token(Token = "0x6001D24")]
	[Address(RVA = "0x796750", Offset = "0x795550", Length = "0x34")]
	private Vector3 Heading3D(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001D25")]
	[Address(RVA = "0x796790", Offset = "0x795590", Length = "0x4E")]
	public HighlightFogManager()
	{
	}
}
