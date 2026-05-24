using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Icon("Selector", false, null)]
[Name("Multiple Task Condition", 0)]
[Category("Branch")]
[Description("Will continue with the first child node which condition returns true. The Dialogue Actor selected will be used for the checks")]
[Color("b3ff7f")]
[Token(Token = "0x2001102")]
public class MultipleConditionNode : DTNode, ISubTasksContainer
{
	[SerializeField]
	[Token(Token = "0x4008708")]
	[FieldOffset(Offset = "0x88")]
	private List<ConditionTask> conditions;

	[Token(Token = "0x170008C6")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6007350")]
		[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6007351")]
	[Address(RVA = "0x10EA690", Offset = "0x10E9490", Length = "0x4C")]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Token(Token = "0x6007352")]
	[Address(RVA = "0x10EA6E0", Offset = "0x10E94E0", Length = "0x5C")]
	public override void OnChildConnected(int index)
	{
	}

	[Token(Token = "0x6007353")]
	[Address(RVA = "0x10EA740", Offset = "0x10E9540", Length = "0x59")]
	public override void OnChildDisconnected(int index)
	{
	}

	[Token(Token = "0x6007354")]
	[Address(RVA = "0x10EA7A0", Offset = "0x10E95A0", Length = "0x205")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007355")]
	[Address(RVA = "0x10EA9B0", Offset = "0x10E97B0", Length = "0xC5")]
	public MultipleConditionNode()
	{
	}
}
