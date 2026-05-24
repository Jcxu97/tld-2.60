using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Category("Branch")]
[Description("Select a child to execute based on it's chance to be selected. An optional pre-Condition Task can be assigned to filter the child in or out of the selection probability.\nThe actor selected will be used for the condition checks.")]
[Icon("ProbabilitySelector", false, null)]
[Color("b3ff7f")]
[Token(Token = "0x2001103")]
public class ProbabilitySelector : DTNode, ISubParametersContainer, ISubTasksContainer
{
	[Token(Token = "0x2001104")]
	public class Option
	{
		[Token(Token = "0x400870B")]
		[FieldOffset(Offset = "0x10")]
		public BBParameter<float> weight;

		[Token(Token = "0x400870C")]
		[FieldOffset(Offset = "0x18")]
		public ConditionTask condition;

		[Token(Token = "0x600735F")]
		[Address(RVA = "0x10EB6B0", Offset = "0x10EA4B0", Length = "0x20A")]
		public Option(float weightValue, IBlackboard bbValue)
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4008709")]
	[FieldOffset(Offset = "0x88")]
	private List<Option> childOptions;

	[Token(Token = "0x400870A")]
	[FieldOffset(Offset = "0x90")]
	private List<int> successIndeces;

	[Token(Token = "0x170008C7")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6007356")]
		[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6007357")]
	[Address(RVA = "0x10EAA80", Offset = "0x10E9880", Length = "0x1FC")]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Token(Token = "0x6007358")]
	[Address(RVA = "0x10EAC80", Offset = "0x10E9A80", Length = "0x1FC")]
	public BBParameter[] GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x6007359")]
	[Address(RVA = "0x10EAE80", Offset = "0x10E9C80", Length = "0xB6")]
	public override void OnChildConnected(int index)
	{
	}

	[Token(Token = "0x600735A")]
	[Address(RVA = "0x10EAF40", Offset = "0x10E9D40", Length = "0x59")]
	public override void OnChildDisconnected(int index)
	{
	}

	[Token(Token = "0x600735B")]
	[Address(RVA = "0x10EAFA0", Offset = "0x10E9DA0", Length = "0x4A8")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x600735C")]
	[Address(RVA = "0x10EB450", Offset = "0x10EA250", Length = "0x12E")]
	private float GetTotal()
	{
		return 0f;
	}

	[Token(Token = "0x600735D")]
	[Address(RVA = "0x10EB580", Offset = "0x10EA380", Length = "0x52")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x600735E")]
	[Address(RVA = "0x10EB5E0", Offset = "0x10EA3E0", Length = "0xC5")]
	public ProbabilitySelector()
	{
	}
}
