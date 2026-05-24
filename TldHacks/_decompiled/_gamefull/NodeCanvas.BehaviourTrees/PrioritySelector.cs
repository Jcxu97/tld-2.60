using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Category("Composites")]
[Description("Used for Utility AI, the Priority Selector executes the child with the highest priority weight. If it fails, the Priority Selector will continue with the next highest priority child until one Succeeds, or until all Fail (similar to how a normal Selector does).")]
[Icon("Priority", false, null)]
[Color("b3ff7f")]
[Token(Token = "0x2001026")]
public class PrioritySelector : BTComposite
{
	[Token(Token = "0x40084A6")]
	[FieldOffset(Offset = "0x78")]
	public List<BBParameter<float>> priorities;

	[Token(Token = "0x40084A7")]
	[FieldOffset(Offset = "0x80")]
	private List<Connection> orderedConnections;

	[Token(Token = "0x40084A8")]
	[FieldOffset(Offset = "0x88")]
	private int current;

	[Token(Token = "0x6006DA7")]
	[Address(RVA = "0x10AF860", Offset = "0x10AE660", Length = "0x183")]
	public override void OnChildConnected(int index)
	{
	}

	[Token(Token = "0x6006DA8")]
	[Address(RVA = "0x10AF9F0", Offset = "0x10AE7F0", Length = "0x56")]
	public override void OnChildDisconnected(int index)
	{
	}

	[Token(Token = "0x6006DA9")]
	[Address(RVA = "0x10AFA50", Offset = "0x10AE850", Length = "0x2CA")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DAA")]
	[Address(RVA = "0x10AFD20", Offset = "0x10AEB20", Length = "0xB")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DAB")]
	[Address(RVA = "0x10AFD30", Offset = "0x10AEB30", Length = "0x162")]
	public PrioritySelector()
	{
	}
}
