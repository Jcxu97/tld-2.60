using System;
using Cpp2ILInjected;

namespace NodeCanvas.DialogueTrees;

[Token(Token = "0x20010E9")]
public class SubtitlesRequestInfo
{
	[Token(Token = "0x40086D3")]
	[FieldOffset(Offset = "0x10")]
	public IDialogueActor actor;

	[Token(Token = "0x40086D4")]
	[FieldOffset(Offset = "0x18")]
	public IStatement statement;

	[Token(Token = "0x40086D5")]
	[FieldOffset(Offset = "0x20")]
	public Action Continue;

	[Token(Token = "0x60072B1")]
	[Address(RVA = "0x646370", Offset = "0x645170", Length = "0x114")]
	public SubtitlesRequestInfo(IDialogueActor actor, IStatement statement, Action callback)
	{
	}
}
