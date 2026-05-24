using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Selector", 9)]
[Category("Composites")]
[Description("Execute the child nodes in order or randonly until the first that returns Success and return Success as well. If none returns Success, then returns Failure.\nIf is Dynamic, then higher priority children Status are revaluated and if one returns Success the Selector will select that one and bail out immediately in Success too")]
[Icon("Selector", false, null)]
[Color("b3ff7f")]
[Token(Token = "0x2001028")]
public class Selector : BTComposite
{
	[Token(Token = "0x40084AF")]
	[FieldOffset(Offset = "0x78")]
	public bool dynamic;

	[Token(Token = "0x40084B0")]
	[FieldOffset(Offset = "0x79")]
	public bool random;

	[Token(Token = "0x40084B1")]
	[FieldOffset(Offset = "0x7C")]
	private int lastRunningNodeIndex;

	[Token(Token = "0x6006DB4")]
	[Address(RVA = "0x10B0A30", Offset = "0x10AF830", Length = "0x200")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DB5")]
	[Address(RVA = "0x10B0C40", Offset = "0x10AFA40", Length = "0x1EA")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DB6")]
	[Address(RVA = "0x10B0E30", Offset = "0x10AFC30", Length = "0x11")]
	public override void OnChildDisconnected(int index)
	{
	}

	[Token(Token = "0x6006DB7")]
	[Address(RVA = "0x10B0180", Offset = "0x10AEF80", Length = "0x11")]
	public override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006DB8")]
	[Address(RVA = "0x10B0E50", Offset = "0x10AFC50", Length = "0x174")]
	private List<Connection> Shuffle(List<Connection> list)
	{
		return null;
	}

	[Token(Token = "0x6006DB9")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public Selector()
	{
	}
}
