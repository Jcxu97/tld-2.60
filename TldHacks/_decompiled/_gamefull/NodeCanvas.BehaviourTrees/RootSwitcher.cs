using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[DoNotList]
[Category("Mutators (beta)")]
[Name("Root Switcher", 0)]
[Description("Switch the root node of the behaviour tree to a new one defined by tag\nBeta Feature!")]
[Token(Token = "0x200104B")]
public class RootSwitcher : BTNode
{
	[Token(Token = "0x400851B")]
	[FieldOffset(Offset = "0x78")]
	public string targetNodeTag;

	[Token(Token = "0x400851C")]
	[FieldOffset(Offset = "0x80")]
	private Node targetNode;

	[Token(Token = "0x6006E30")]
	[Address(RVA = "0x10B5E70", Offset = "0x10B4C70", Length = "0xA1")]
	public override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006E31")]
	[Address(RVA = "0x10B5F20", Offset = "0x10B4D20", Length = "0x67")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006E32")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public RootSwitcher()
	{
	}
}
