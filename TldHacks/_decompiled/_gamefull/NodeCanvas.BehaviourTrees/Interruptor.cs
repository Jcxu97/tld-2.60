using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Interrupt", 0)]
[Category("Decorators")]
[Description("Interrupt the child node and return Failure if the condition is or becomes true while running. Otherwise execute and return the child Status")]
[Icon("Interruptor", false, null)]
[Token(Token = "0x2001035")]
public class Interruptor : BTDecorator, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	[SerializeField]
	[Token(Token = "0x40084DE")]
	[FieldOffset(Offset = "0x78")]
	private ConditionTask _condition;

	[Token(Token = "0x1700077B")]
	public ConditionTask condition
	{
		[Token(Token = "0x6006DDE")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DDF")]
		[Address(RVA = "0x6E17D0", Offset = "0x6E05D0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700077C")]
	public Task task
	{
		[Token(Token = "0x6006DE0")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006DE1")]
		[Address(RVA = "0x10B29C0", Offset = "0x10B17C0", Length = "0xB4")]
		set
		{
		}
	}

	[Token(Token = "0x6006DE2")]
	[Address(RVA = "0x10B2A80", Offset = "0x10B1880", Length = "0x115")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DE3")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public Interruptor()
	{
	}
}
