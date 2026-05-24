using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("FINISH", 0)]
[Category("Control")]
[Description("End the dialogue in Success or Failure.\nNote: A Dialogue will anyway End in Succcess if it has reached a node without child connections. Thus this node is mostly useful if you want to end a Dialogue in Failure.")]
[Icon("Halt", false, null)]
[Color("00b9e8")]
[Token(Token = "0x20010FC")]
public class FinishNode : DTNode
{
	[Token(Token = "0x40086FB")]
	[FieldOffset(Offset = "0x88")]
	public CompactStatus finishState;

	[Token(Token = "0x170008BD")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6007335")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170008BE")]
	public override bool requireActorSelection
	{
		[Token(Token = "0x6007336")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007337")]
	[Address(RVA = "0x10E9330", Offset = "0x10E8130", Length = "0x41")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007338")]
	[Address(RVA = "0x10E9380", Offset = "0x10E8180", Length = "0x11")]
	public FinishNode()
	{
	}
}
