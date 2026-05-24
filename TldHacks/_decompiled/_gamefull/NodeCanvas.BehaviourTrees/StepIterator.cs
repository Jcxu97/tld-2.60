using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Step Sequencer", 0)]
[Category("Composites")]
[Description("Executes AND immediately returns children node status ONE-BY-ONE. Step Sequencer always moves forward by one and loops it's index")]
[Icon("StepIterator", false, null)]
[Color("bf7fff")]
[Token(Token = "0x200102A")]
public class StepIterator : BTComposite
{
	[Token(Token = "0x40084B5")]
	[FieldOffset(Offset = "0x78")]
	private int current;

	[Token(Token = "0x6006DC0")]
	[Address(RVA = "0x10AF370", Offset = "0x10AE170", Length = "0x8")]
	public override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006DC1")]
	[Address(RVA = "0x10B1550", Offset = "0x10B0350", Length = "0xE2")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DC2")]
	[Address(RVA = "0x10B1640", Offset = "0x10B0440", Length = "0x4")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DC3")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public StepIterator()
	{
	}
}
