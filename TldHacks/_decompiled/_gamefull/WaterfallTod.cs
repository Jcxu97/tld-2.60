using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200040C")]
public class WaterfallTod : MonoBehaviour
{
	[Token(Token = "0x40024B1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_WaterfallObject;

	[Token(Token = "0x40024B2")]
	[FieldOffset(Offset = "0x28")]
	public ScaledCurve m_SaturationControl;

	[Token(Token = "0x40024B3")]
	[FieldOffset(Offset = "0x30")]
	public ScaledCurve m_GlowValue;

	[Token(Token = "0x40024B4")]
	[FieldOffset(Offset = "0x38")]
	private Renderer m_Renderer;

	[Token(Token = "0x40024B5")]
	[FieldOffset(Offset = "0x40")]
	private MaterialPropertyBlock m_PropertyBlock;

	[Token(Token = "0x40024B6")]
	[FieldOffset(Offset = "0x48")]
	private float m_OrgSaturation;

	[Token(Token = "0x40024B7")]
	private static readonly int s_SaturationShaderID;

	[Token(Token = "0x40024B8")]
	private static readonly int s_GlowAmountShaderID;

	[Token(Token = "0x6001EC2")]
	[Address(RVA = "0x7CC240", Offset = "0x7CB040", Length = "0x21F")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EC3")]
	[Address(RVA = "0x7CC460", Offset = "0x7CB260", Length = "0x258")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EC4")]
	[Address(RVA = "0x7CC6C0", Offset = "0x7CB4C0", Length = "0x201")]
	public WaterfallTod()
	{
	}
}
