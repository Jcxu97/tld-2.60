using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace NodeCanvas.DialogueTrees;

[Token(Token = "0x20010EA")]
public class MultipleChoiceRequestInfo
{
	[Token(Token = "0x40086D6")]
	[FieldOffset(Offset = "0x10")]
	public IDialogueActor actor;

	[Token(Token = "0x40086D7")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<IStatement, int> options;

	[Token(Token = "0x40086D8")]
	[FieldOffset(Offset = "0x20")]
	public float availableTime;

	[Token(Token = "0x40086D9")]
	[FieldOffset(Offset = "0x24")]
	public bool showLastStatement;

	[Token(Token = "0x40086DA")]
	[FieldOffset(Offset = "0x28")]
	public Action<int> SelectOption;

	[Token(Token = "0x60072B2")]
	[Address(RVA = "0x10E4E70", Offset = "0x10E3C70", Length = "0x111")]
	public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, bool showLastStatement, Action<int> callback)
	{
	}

	[Token(Token = "0x60072B3")]
	[Address(RVA = "0x10E4F90", Offset = "0x10E3D90", Length = "0x111")]
	public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, Action<int> callback)
	{
	}
}
