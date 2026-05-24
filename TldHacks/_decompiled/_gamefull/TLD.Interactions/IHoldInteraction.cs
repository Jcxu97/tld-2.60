using Cpp2ILInjected;

namespace TLD.Interactions;

[Token(Token = "0x20013A0")]
public interface IHoldInteraction : IInteraction
{
	[Token(Token = "0x17000AA1")]
	string HoldText
	{
		[Token(Token = "0x6007D59")]
		get;
	}

	[Token(Token = "0x17000AA2")]
	bool IsActive
	{
		[Token(Token = "0x6007D5A")]
		get;
	}

	[Token(Token = "0x17000AA3")]
	bool CanCancel
	{
		[Token(Token = "0x6007D5B")]
		get;
	}

	[Token(Token = "0x17000AA4")]
	float NormalizedProgress
	{
		[Token(Token = "0x6007D5C")]
		get;
	}

	[Token(Token = "0x6007D5D")]
	bool PerformHold();

	[Token(Token = "0x6007D5E")]
	void CancelHold();
}
