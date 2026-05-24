using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("GO TO", 0)]
[Category("Control")]
[Description("Jump to another Dialogue node. Usefull if that other node is far away to connect, but otherwise it's exactly the same.\n\nPlease enable 'Show Node IDs' in Editor Prefs for convenience")]
[Icon("Set", false, null)]
[Color("00b9e8")]
[Obsolete("Use Jumpers instead")]
[Token(Token = "0x200110B")]
public class GoToNode : DTNode
{
	[SerializeField]
	[Token(Token = "0x400871B")]
	[FieldOffset(Offset = "0x88")]
	private DTNode _targetNode;

	[Token(Token = "0x170008D4")]
	public override int maxOutConnections
	{
		[Token(Token = "0x600738D")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170008D5")]
	public override bool requireActorSelection
	{
		[Token(Token = "0x600738E")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600738F")]
	[Address(RVA = "0x10EDB60", Offset = "0x10EC960", Length = "0x79")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007390")]
	[Address(RVA = "0x10E0B40", Offset = "0x10DF940", Length = "0x7")]
	public GoToNode()
	{
	}
}
