using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Sequencer", 10)]
[Category("Composites")]
[Description("Execute the child nodes in order or randonly and return Success if all children return Success, else return Failure\nIf is Dynamic, higher priority child status is revaluated. If a child returns Failure the Sequencer will bail out immediately in Failure too.")]
[Icon("Sequencer", false, null)]
[Color("bf7fff")]
[Token(Token = "0x2001029")]
public class Sequencer : BTComposite
{
	[Token(Token = "0x40084B2")]
	[FieldOffset(Offset = "0x78")]
	public bool dynamic;

	[Token(Token = "0x40084B3")]
	[FieldOffset(Offset = "0x79")]
	public bool random;

	[Token(Token = "0x40084B4")]
	[FieldOffset(Offset = "0x7C")]
	private int lastRunningNodeIndex;

	[Token(Token = "0x6006DBA")]
	[Address(RVA = "0x10B0FD0", Offset = "0x10AFDD0", Length = "0x200")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DBB")]
	[Address(RVA = "0x10B11E0", Offset = "0x10AFFE0", Length = "0x1EA")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DBC")]
	[Address(RVA = "0x10B0E30", Offset = "0x10AFC30", Length = "0x11")]
	public override void OnChildDisconnected(int index)
	{
	}

	[Token(Token = "0x6006DBD")]
	[Address(RVA = "0x10B0180", Offset = "0x10AEF80", Length = "0x11")]
	public override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006DBE")]
	[Address(RVA = "0x10B13D0", Offset = "0x10B01D0", Length = "0x174")]
	private List<Connection> Shuffle(List<Connection> list)
	{
		return null;
	}

	[Token(Token = "0x6006DBF")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public Sequencer()
	{
	}
}
