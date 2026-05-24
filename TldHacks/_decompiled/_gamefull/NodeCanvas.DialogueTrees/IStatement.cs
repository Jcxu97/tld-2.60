using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Token(Token = "0x2001108")]
public interface IStatement
{
	[Token(Token = "0x170008CC")]
	string text
	{
		[Token(Token = "0x6007378")]
		get;
	}

	[Token(Token = "0x170008CD")]
	AudioClip audio
	{
		[Token(Token = "0x6007379")]
		get;
	}

	[Token(Token = "0x170008CE")]
	string meta
	{
		[Token(Token = "0x600737A")]
		get;
	}

	[Token(Token = "0x170008CF")]
	VoiceOverAnimationState anim
	{
		[Token(Token = "0x600737B")]
		get;
	}
}
