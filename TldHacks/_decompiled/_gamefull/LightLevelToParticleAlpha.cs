using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003C4")]
public class LightLevelToParticleAlpha : MonoBehaviour
{
	[Token(Token = "0x40021EF")]
	[FieldOffset(Offset = "0x20")]
	public float m_DefaultAlpha;

	[Token(Token = "0x40021F0")]
	[FieldOffset(Offset = "0x24")]
	public bool m_EstimateColor;

	[Token(Token = "0x40021F1")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystemRenderer m_Renderer;

	[Token(Token = "0x6001D83")]
	[Address(RVA = "0x7A5150", Offset = "0x7A3F50", Length = "0x8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D84")]
	[Address(RVA = "0x7A51E0", Offset = "0x7A3FE0", Length = "0x216")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D85")]
	[Address(RVA = "0x7A5400", Offset = "0x7A4200", Length = "0x4E")]
	public LightLevelToParticleAlpha()
	{
	}
}
