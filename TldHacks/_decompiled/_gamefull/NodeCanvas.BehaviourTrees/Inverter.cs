using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Invert", 0)]
[Category("Decorators")]
[Description("Inverts Success to Failure and Failure to Success")]
[Icon("Remap", false, null)]
[Token(Token = "0x2001036")]
public class Inverter : BTDecorator
{
	[Token(Token = "0x6006DE4")]
	[Address(RVA = "0x10B2BA0", Offset = "0x10B19A0", Length = "0xCF")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DE5")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public Inverter()
	{
	}
}
