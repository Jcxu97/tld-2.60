using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Token(Token = "0x20010F7")]
public interface IDialogueActor
{
	[Token(Token = "0x170008A8")]
	string name
	{
		[Token(Token = "0x600730F")]
		get;
	}

	[Token(Token = "0x170008A9")]
	Texture2D portrait
	{
		[Token(Token = "0x6007310")]
		get;
	}

	[Token(Token = "0x170008AA")]
	Sprite portraitSprite
	{
		[Token(Token = "0x6007311")]
		get;
	}

	[Token(Token = "0x170008AB")]
	Color dialogueColor
	{
		[Token(Token = "0x6007312")]
		get;
	}

	[Token(Token = "0x170008AC")]
	Vector3 dialoguePosition
	{
		[Token(Token = "0x6007313")]
		get;
	}

	[Token(Token = "0x170008AD")]
	Transform transform
	{
		[Token(Token = "0x6007314")]
		get;
	}
}
