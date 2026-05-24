using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003D3")]
public class LinkParticlesToPanel : MonoBehaviour
{
	[Token(Token = "0x400228D")]
	[FieldOffset(Offset = "0x20")]
	public Panel_MainMenu m_Panel;

	[Token(Token = "0x400228E")]
	[FieldOffset(Offset = "0x28")]
	private Material m_Material;

	[Token(Token = "0x400228F")]
	[FieldOffset(Offset = "0x30")]
	private Color m_Color;

	[Token(Token = "0x4002290")]
	[FieldOffset(Offset = "0x40")]
	private float m_Alpha;

	[Token(Token = "0x6001DDA")]
	[Address(RVA = "0x7ABAB0", Offset = "0x7AA8B0", Length = "0xE2")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DDB")]
	[Address(RVA = "0x7ABBA0", Offset = "0x7AA9A0", Length = "0x94")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DDC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LinkParticlesToPanel()
	{
	}
}
