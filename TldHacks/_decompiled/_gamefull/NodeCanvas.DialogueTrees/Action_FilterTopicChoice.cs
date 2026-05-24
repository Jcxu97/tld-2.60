using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("TLD Multiple Choice Filter Topics", 0)]
[Description("Topic filter")]
[Token(Token = "0x20010E2")]
public class Action_FilterTopicChoice : DTNode
{
	[Token(Token = "0x40086AB")]
	[FieldOffset(Offset = "0x88")]
	public bool clearFilter;

	[Token(Token = "0x40086AC")]
	[FieldOffset(Offset = "0x90")]
	public List<DialogueOptionTopic> filter;

	[Token(Token = "0x17000883")]
	public override string name
	{
		[Token(Token = "0x6007298")]
		[Address(RVA = "0x10E2350", Offset = "0x10E1150", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007299")]
	[Address(RVA = "0x10E2390", Offset = "0x10E1190", Length = "0x207")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x600729A")]
	[Address(RVA = "0x10E25A0", Offset = "0x10E13A0", Length = "0xE")]
	public Action_FilterTopicChoice()
	{
	}
}
