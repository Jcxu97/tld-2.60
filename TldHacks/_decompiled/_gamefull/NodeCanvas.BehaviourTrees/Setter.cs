using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Override Agent", 0)]
[Category("Decorators")]
[Description("Set another Agent for the rest of the Tree dynamicaly from this point and on. All nodes under this will be executed for the new agent")]
[Icon("Agent", false, null)]
[Token(Token = "0x2001042")]
public class Setter : BTDecorator
{
	[Token(Token = "0x4008505")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> newAgent;

	[Token(Token = "0x6006DF8")]
	[Address(RVA = "0x10B3790", Offset = "0x10B2590", Length = "0xED")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DF9")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public Setter()
	{
	}
}
