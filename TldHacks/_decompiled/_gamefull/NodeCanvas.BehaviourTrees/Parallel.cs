using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Parallel", 8)]
[Category("Composites")]
[Description("Execute all child nodes once but simultaneously and return Success or Failure depending on the selected ParallelPolicy.\nIf set to Repeat, child nodes are repeated until the Policy set is met, or until all children have had a chance to complete at least once.")]
[Icon("Parallel", false, null)]
[Color("ff64cb")]
[Token(Token = "0x2001024")]
public class Parallel : BTComposite
{
	[Token(Token = "0x2001025")]
	public enum ParallelPolicy
	{
		[Token(Token = "0x40084A3")]
		FirstFailure,
		[Token(Token = "0x40084A4")]
		FirstSuccess,
		[Token(Token = "0x40084A5")]
		FirstSuccessOrFailure
	}

	[Token(Token = "0x400849F")]
	[FieldOffset(Offset = "0x78")]
	public ParallelPolicy policy;

	[Name("Repeat", 0)]
	[Token(Token = "0x40084A0")]
	[FieldOffset(Offset = "0x7C")]
	public bool dynamic;

	[Token(Token = "0x40084A1")]
	[FieldOffset(Offset = "0x80")]
	private readonly List<Connection> finishedConnections;

	[Token(Token = "0x6006DA3")]
	[Address(RVA = "0x10AF380", Offset = "0x10AE180", Length = "0x2B5")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DA4")]
	[Address(RVA = "0x10AF640", Offset = "0x10AE440", Length = "0x67")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DA5")]
	[Address(RVA = "0x10AF6B0", Offset = "0x10AE4B0", Length = "0xDD")]
	private void ResetRunning()
	{
	}

	[Token(Token = "0x6006DA6")]
	[Address(RVA = "0x10AF790", Offset = "0x10AE590", Length = "0xC5")]
	public Parallel()
	{
	}
}
