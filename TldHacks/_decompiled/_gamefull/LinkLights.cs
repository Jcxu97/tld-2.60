using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003D2")]
public class LinkLights : MonoBehaviour
{
	[Token(Token = "0x4002288")]
	[FieldOffset(Offset = "0x20")]
	public Light m_SourceLight;

	[Header("Intensity")]
	[Token(Token = "0x4002289")]
	[FieldOffset(Offset = "0x28")]
	public bool m_LinkIntensity;

	[Token(Token = "0x400228A")]
	[FieldOffset(Offset = "0x2C")]
	public float m_IntensityMultiplier;

	[Header("Color")]
	[Token(Token = "0x400228B")]
	[FieldOffset(Offset = "0x30")]
	public bool m_LinkColor;

	[Token(Token = "0x400228C")]
	[FieldOffset(Offset = "0x38")]
	private Light m_ThisLight;

	[Token(Token = "0x6001DD7")]
	[Address(RVA = "0x7AB7D0", Offset = "0x7AA5D0", Length = "0x8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DD8")]
	[Address(RVA = "0x7AB860", Offset = "0x7AA660", Length = "0x1E2")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DD9")]
	[Address(RVA = "0x7ABA50", Offset = "0x7AA850", Length = "0x52")]
	public LinkLights()
	{
	}
}
