using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("SubTree", 0)]
[Category("Nested")]
[Description("SubTree Node can be assigned an entire Sub BehaviorTree. The root node of that behaviour will be considered child node of this node and will return whatever it returns.\nThe target SubTree can also be set by using a Blackboard variable as normal.")]
[Icon("BT", false, null)]
[Token(Token = "0x2001048")]
public class SubTree : BTNode, IGraphAssignable
{
	[SerializeField]
	[Token(Token = "0x4008511")]
	[FieldOffset(Offset = "0x78")]
	private BBParameter<BehaviourTree> _subTree;

	[Token(Token = "0x4008512")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<BehaviourTree, BehaviourTree> instances;

	[Token(Token = "0x4008513")]
	[FieldOffset(Offset = "0x88")]
	private BehaviourTree currentInstance;

	[Token(Token = "0x1700078B")]
	public override string name
	{
		[Token(Token = "0x6006E21")]
		[Address(RVA = "0x10AEDD0", Offset = "0x10ADBD0", Length = "0x23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700078C")]
	public BehaviourTree subTree
	{
		[Token(Token = "0x6006E22")]
		[Address(RVA = "0x10B4C30", Offset = "0x10B3A30", Length = "0x49")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E23")]
		[Address(RVA = "0x10B4C80", Offset = "0x10B3A80", Length = "0x58")]
		set
		{
		}
	}

	[Token(Token = "0x1700078D")]
	Graph IGraphAssignable.nestedGraph
	{
		[Token(Token = "0x6006E24")]
		[Address(RVA = "0x10B4C30", Offset = "0x10B3A30", Length = "0x49")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E25")]
		[Address(RVA = "0x10B4CE0", Offset = "0x10B3AE0", Length = "0xAE")]
		set
		{
		}
	}

	[Token(Token = "0x6006E26")]
	[Address(RVA = "0x10B4D90", Offset = "0x10B3B90", Length = "0xE2")]
	Graph[] IGraphAssignable.GetInstances()
	{
		return null;
	}

	[Token(Token = "0x6006E27")]
	[Address(RVA = "0x10B4E80", Offset = "0x10B3C80", Length = "0x253")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006E28")]
	[Address(RVA = "0x10B50E0", Offset = "0x10B3EE0", Length = "0xE8")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006E29")]
	[Address(RVA = "0x10B51D0", Offset = "0x10B3FD0", Length = "0xE5")]
	public override void OnGraphPaused()
	{
	}

	[Token(Token = "0x6006E2A")]
	[Address(RVA = "0x10B52C0", Offset = "0x10B40C0", Length = "0xE8")]
	public override void OnGraphStoped()
	{
	}

	[Token(Token = "0x6006E2B")]
	[Address(RVA = "0x10B53B0", Offset = "0x10B41B0", Length = "0x354")]
	private BehaviourTree CheckInstance()
	{
		return null;
	}

	[Token(Token = "0x6006E2C")]
	[Address(RVA = "0x10B5710", Offset = "0x10B4510", Length = "0xC5")]
	public SubTree()
	{
	}
}
