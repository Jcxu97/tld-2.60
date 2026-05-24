using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Icon("List", false, null)]
[Name("Multiple Choice", 0)]
[Category("Branch")]
[Description("Prompt a Dialogue Multiple Choice. A choice will be available if the connection's condition is true or there is no condition on that connection. The Actor selected is used for the Condition checks as well as will Say the selection if the option is checked.")]
[Color("b3ff7f")]
[Token(Token = "0x20010FE")]
public class MultipleChoiceNode : DTNode, ISubTasksContainer
{
	[Serializable]
	[Token(Token = "0x20010FF")]
	public class Choice
	{
		[Token(Token = "0x4008701")]
		[FieldOffset(Offset = "0x10")]
		public bool isUnfolded;

		[Token(Token = "0x4008702")]
		[FieldOffset(Offset = "0x18")]
		public Statement statement;

		[Token(Token = "0x4008703")]
		[FieldOffset(Offset = "0x20")]
		public ConditionTask condition;

		[Token(Token = "0x6007349")]
		[Address(RVA = "0x4A1DD0", Offset = "0x4A0BD0", Length = "0x5")]
		public Choice()
		{
		}

		[Token(Token = "0x600734A")]
		[Address(RVA = "0x10EA530", Offset = "0x10E9330", Length = "0x52")]
		public Choice(Statement statement)
		{
		}
	}

	[SliderField(0f, 10f)]
	[Token(Token = "0x40086FE")]
	[FieldOffset(Offset = "0x88")]
	public float availableTime;

	[Token(Token = "0x40086FF")]
	[FieldOffset(Offset = "0x8C")]
	public bool saySelection;

	[SerializeField]
	[Token(Token = "0x4008700")]
	[FieldOffset(Offset = "0x90")]
	private List<Choice> availableChoices;

	[Token(Token = "0x170008C4")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6007344")]
		[Address(RVA = "0x10E9AF0", Offset = "0x10E88F0", Length = "0x44")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170008C5")]
	public override bool requireActorSelection
	{
		[Token(Token = "0x6007345")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007343")]
	[Address(RVA = "0x10E98C0", Offset = "0x10E86C0", Length = "0x224")]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Token(Token = "0x6007346")]
	[Address(RVA = "0x10E9B40", Offset = "0x10E8940", Length = "0x712")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007347")]
	[Address(RVA = "0x10EA260", Offset = "0x10E9060", Length = "0x1F2")]
	private void OnOptionSelected(int index)
	{
	}

	[Token(Token = "0x6007348")]
	[Address(RVA = "0x10EA460", Offset = "0x10E9260", Length = "0xC5")]
	public MultipleChoiceNode()
	{
	}
}
