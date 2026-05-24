using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Category("Decorators")]
[Description("Interupts decorated child node and returns Failure if the child node is still Running after the timeout period")]
[Icon("Timeout", false, null)]
[Token(Token = "0x2001043")]
public class Timeout : BTDecorator
{
	[Token(Token = "0x4008506")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> timeout;

	[Token(Token = "0x4008507")]
	[FieldOffset(Offset = "0x80")]
	private float timer;

	[Token(Token = "0x6006DFA")]
	[Address(RVA = "0x10B3880", Offset = "0x10B2680", Length = "0x1BD")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DFB")]
	[Address(RVA = "0x10B3A40", Offset = "0x10B2840", Length = "0xB")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DFC")]
	[Address(RVA = "0x10B3A50", Offset = "0x10B2850", Length = "0x97")]
	public Timeout()
	{
	}
}
