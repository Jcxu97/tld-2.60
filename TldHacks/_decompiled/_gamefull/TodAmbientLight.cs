using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000317")]
public class TodAmbientLight : MonoBehaviour
{
	[Token(Token = "0x4001B4C")]
	[FieldOffset(Offset = "0x20")]
	public Color m_AmbientIndoorsDay;

	[Token(Token = "0x4001B4D")]
	[FieldOffset(Offset = "0x30")]
	public Color m_AmbientIndoorsNight;

	[Tooltip("Add a fractional value between whole numbers.")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001B4E")]
	[FieldOffset(Offset = "0x40")]
	public float m_FineTuneDay;

	[Tooltip("Add a fractional value between whole numbers.")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001B4F")]
	[FieldOffset(Offset = "0x44")]
	public float m_FineTuneNight;

	[Token(Token = "0x6001948")]
	[Address(RVA = "0x730F40", Offset = "0x72FD40", Length = "0x13")]
	private void Start()
	{
	}

	[Token(Token = "0x6001949")]
	[Address(RVA = "0x730F60", Offset = "0x72FD60", Length = "0x1D5")]
	public void SetAmbientLightValue(float todValue, float multiplier)
	{
	}

	[Token(Token = "0x600194A")]
	[Address(RVA = "0x731140", Offset = "0x72FF40", Length = "0x42")]
	private Color FineTune(Color c, float a)
	{
		return default(Color);
	}

	[Token(Token = "0x600194B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TodAmbientLight()
	{
	}
}
