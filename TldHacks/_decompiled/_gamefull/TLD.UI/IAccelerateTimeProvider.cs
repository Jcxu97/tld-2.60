using System;
using Cpp2ILInjected;

namespace TLD.UI;

[Token(Token = "0x200138B")]
public interface IAccelerateTimeProvider
{
	[Token(Token = "0x6007CD7")]
	bool IsAcceleratingTime();

	[Token(Token = "0x6007CD8")]
	bool ShowCameraEffects();

	[Token(Token = "0x6007CD9")]
	UIProgressBar GetActionProgress();

	[Token(Token = "0x6007CDA")]
	string GetActionText();

	[Token(Token = "0x6007CDB")]
	string GetSpriteName();

	[Token(Token = "0x6007CDC")]
	UIRect GetElementToFade();

	[Token(Token = "0x6007CDD")]
	Action GetCancelAction();
}
