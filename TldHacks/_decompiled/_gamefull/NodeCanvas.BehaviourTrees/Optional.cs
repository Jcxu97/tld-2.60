using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Optional", 0)]
[Category("Decorators")]
[Description("Executes the decorated node without taking into account it's return status, thus making it optional to the parent node for whether it returns Success or Failure.\nThis has the same effect as disabling the node, but instead it executes normaly")]
[Icon("UpwardsArrow", false, null)]
[Token(Token = "0x200103C")]
public class Optional : BTDecorator
{
	[Token(Token = "0x6006DF1")]
	[Address(RVA = "0x10B3350", Offset = "0x10B2150", Length = "0xE5")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DF2")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public Optional()
	{
	}
}
