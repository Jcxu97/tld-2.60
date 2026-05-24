using Cpp2ILInjected;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Description("Switch the entire Behaviour Tree of BehaviourTreeOwner")]
[Token(Token = "0x200130F")]
public class SwitchBehaviourTree : ActionTask<BehaviourTreeOwner>
{
	[RequiredField]
	[Token(Token = "0x4008CDA")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<BehaviourTree> behaviourTree;

	[Token(Token = "0x17000A2C")]
	protected override string info
	{
		[Token(Token = "0x6007A39")]
		[Address(RVA = "0x11900B0", Offset = "0x118EEB0", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A3A")]
	[Address(RVA = "0x1190140", Offset = "0x118EF40", Length = "0x112")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A3B")]
	[Address(RVA = "0x1190260", Offset = "0x118F060", Length = "0x44")]
	public SwitchBehaviourTree()
	{
	}
}
