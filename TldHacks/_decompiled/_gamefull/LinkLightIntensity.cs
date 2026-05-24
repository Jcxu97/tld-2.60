using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003D0")]
public class LinkLightIntensity : MonoBehaviour
{
	[Token(Token = "0x4002282")]
	[FieldOffset(Offset = "0x20")]
	public Light m_SourceLight;

	[Token(Token = "0x4002283")]
	[FieldOffset(Offset = "0x28")]
	public float m_IntensityMultiplier;

	[Token(Token = "0x4002284")]
	[FieldOffset(Offset = "0x30")]
	private Light m_ThisLight;

	[Token(Token = "0x6001DD2")]
	[Address(RVA = "0x7AB5A0", Offset = "0x7AA3A0", Length = "0x8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DD3")]
	[Address(RVA = "0x7AB630", Offset = "0x7AA430", Length = "0xCA")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DD4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LinkLightIntensity()
	{
	}
}
