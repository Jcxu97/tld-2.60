using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008E0")]
public interface IHDRHandler
{
	[Token(Token = "0x60051A1")]
	void SetPaperWhiteNits(float value);

	[Token(Token = "0x60051A2")]
	void SetPeakBrightnessNits(float value);

	[Token(Token = "0x60051A3")]
	bool IsOutputtingHDR();

	[Token(Token = "0x60051A4")]
	void Initialize(float paperWhiteNits, float peakBrightnessNits);

	[Token(Token = "0x60051A5")]
	void Render(RenderTexture source, RenderTexture destination);

	[Token(Token = "0x60051A6")]
	string GetDebugDisplayText();
}
