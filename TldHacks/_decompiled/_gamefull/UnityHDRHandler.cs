using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000903")]
public class UnityHDRHandler : IHDRHandler
{
	[Token(Token = "0x600525F")]
	[Address(RVA = "0xE48D60", Offset = "0xE47B60", Length = "0x8")]
	public void Initialize(float paperWhiteNits, float peakBrightnessNits)
	{
	}

	[Token(Token = "0x6005260")]
	[Address(RVA = "0xE48D70", Offset = "0xE47B70", Length = "0x109")]
	public bool IsOutputtingHDR()
	{
		return false;
	}

	[Token(Token = "0x6005261")]
	[Address(RVA = "0xE48E80", Offset = "0xE47C80", Length = "0x5E")]
	public void Render(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6005262")]
	[Address(RVA = "0xE48EE0", Offset = "0xE47CE0", Length = "0x22E")]
	public void SetPaperWhiteNits(float value)
	{
	}

	[Token(Token = "0x6005263")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void SetPeakBrightnessNits(float value)
	{
	}

	[Token(Token = "0x6005264")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetDebugDisplayText()
	{
		return null;
	}

	[Token(Token = "0x6005265")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public UnityHDRHandler()
	{
	}
}
