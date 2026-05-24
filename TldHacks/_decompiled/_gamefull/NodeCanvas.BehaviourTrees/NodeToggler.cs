using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[DoNotList]
[Category("Mutators (beta)")]
[Name("Node Toggler", 0)]
[Description("Enable, Disable or Toggle one or more nodes with provided tag. In practise their incomming connections are disabled\nBeta Feature!")]
[Token(Token = "0x2001049")]
public class NodeToggler : BTNode
{
	[Token(Token = "0x200104A")]
	public enum ToggleMode
	{
		[Token(Token = "0x4008518")]
		Enable,
		[Token(Token = "0x4008519")]
		Disable,
		[Token(Token = "0x400851A")]
		Toggle
	}

	[Token(Token = "0x4008514")]
	[FieldOffset(Offset = "0x78")]
	public ToggleMode toggleMode;

	[Token(Token = "0x4008515")]
	[FieldOffset(Offset = "0x80")]
	public string targetNodeTag;

	[Token(Token = "0x4008516")]
	[FieldOffset(Offset = "0x88")]
	private List<Node> targetNodes;

	[Token(Token = "0x6006E2D")]
	[Address(RVA = "0x10B57E0", Offset = "0x10B45E0", Length = "0xA1")]
	public override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006E2E")]
	[Address(RVA = "0x10B5890", Offset = "0x10B4690", Length = "0x5CE")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006E2F")]
	[Address(RVA = "0x10B5E60", Offset = "0x10B4C60", Length = "0xE")]
	public NodeToggler()
	{
	}
}
