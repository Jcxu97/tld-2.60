using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Interactions;

[Token(Token = "0x20013A1")]
public interface IInteraction
{
	[Token(Token = "0x17000AA5")]
	string HoverText
	{
		[Token(Token = "0x6007D5F")]
		get;
	}

	[Token(Token = "0x17000AA6")]
	bool IsEnabled
	{
		[Token(Token = "0x6007D60")]
		get;
	}

	[Token(Token = "0x17000AA7")]
	bool CanInteract
	{
		[Token(Token = "0x6007D61")]
		get;
	}

	[Token(Token = "0x6007D62")]
	void InitializeInteraction();

	[Token(Token = "0x6007D63")]
	void UpdateInteraction();

	[Token(Token = "0x6007D64")]
	bool PerformInteraction();

	[Token(Token = "0x6007D65")]
	void HideInteraction();

	[Token(Token = "0x6007D66")]
	GameObject GetInteractiveObject();
}
