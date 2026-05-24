using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008DF")]
public class DefaultHDRHandler : IHDRHandler
{
	[Token(Token = "0x600519A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void SetPaperWhiteNits(float value)
	{
	}

	[Token(Token = "0x600519B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void SetPeakBrightnessNits(float value)
	{
	}

	[Token(Token = "0x600519C")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool IsOutputtingHDR()
	{
		return false;
	}

	[Token(Token = "0x600519D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Initialize(float paperWhiteNits, float peakBrightnessNits)
	{
	}

	[Token(Token = "0x600519E")]
	[Address(RVA = "0xE2F9C0", Offset = "0xE2E7C0", Length = "0x5E")]
	public void Render(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600519F")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetDebugDisplayText()
	{
		return null;
	}

	[Token(Token = "0x60051A0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DefaultHDRHandler()
	{
	}
}
