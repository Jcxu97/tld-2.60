using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A31")]
public class QualityLevelFilter : MonoBehaviour
{
	[Token(Token = "0x2000A32")]
	public enum GraphicsQuality
	{
		[Token(Token = "0x400667A")]
		Low,
		[Token(Token = "0x400667B")]
		Medium,
		[Token(Token = "0x400667C")]
		High,
		[Token(Token = "0x400667D")]
		Ultra,
		[Token(Token = "0x400667E")]
		XboxOne
	}

	[Token(Token = "0x4006675")]
	[FieldOffset(Offset = "0x20")]
	public GraphicsQuality m_MinimumQualityLevel;

	[Token(Token = "0x4006676")]
	[FieldOffset(Offset = "0x24")]
	private Quality m_MinQualityLevel;

	[Token(Token = "0x4006677")]
	[FieldOffset(Offset = "0x28")]
	private bool m_Enabled;

	[Token(Token = "0x4006678")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_Children;

	[Token(Token = "0x600590E")]
	[Address(RVA = "0xEEF270", Offset = "0xEEE070", Length = "0x4A0")]
	public void Start()
	{
	}

	[Token(Token = "0x600590F")]
	[Address(RVA = "0xEEF720", Offset = "0xEEE520", Length = "0x23C")]
	public void Update()
	{
	}

	[Token(Token = "0x6005910")]
	[Address(RVA = "0xEEF960", Offset = "0xEEE760", Length = "0xA1")]
	private bool PassesFilter()
	{
		return false;
	}

	[Token(Token = "0x6005911")]
	[Address(RVA = "0xEEFA10", Offset = "0xEEE810", Length = "0x33")]
	private Quality GetQualityLevelFromLegacyQuality(GraphicsQuality legacyQualityLevel)
	{
		return default(Quality);
	}

	[Token(Token = "0x6005912")]
	[Address(RVA = "0xEEFA50", Offset = "0xEEE850", Length = "0xE3")]
	public QualityLevelFilter()
	{
	}
}
