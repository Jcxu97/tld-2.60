using System.Collections;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Iterate", 0)]
[Category("Decorators")]
[Description("Iterate any type of list and execute the child node for each element in the list. Keeps iterating until the Termination Condition is met or the whole list is iterated, in which case the last interation's child status is returned.")]
[Icon("List", false, null)]
[Token(Token = "0x2001037")]
public class Iterator : BTDecorator
{
	[Token(Token = "0x2001038")]
	public enum TerminationConditions
	{
		[Token(Token = "0x40084E7")]
		None,
		[Token(Token = "0x40084E8")]
		FirstSuccess,
		[Token(Token = "0x40084E9")]
		FirstFailure
	}

	[RequiredField]
	[BlackboardOnly]
	[Tooltip("The list to iterate")]
	[Token(Token = "0x40084DF")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<IList> targetList;

	[BlackboardOnly]
	[Name("Current Element", 0)]
	[Tooltip("Store the current element")]
	[Token(Token = "0x40084E0")]
	[FieldOffset(Offset = "0x80")]
	public BBObjectParameter current;

	[BlackboardOnly]
	[Name("Current Index", 0)]
	[Tooltip("Store the current index")]
	[Token(Token = "0x40084E1")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<int> storeIndex;

	[Tooltip("The maximum count of iterations. Leave at -1 to iterate the whole list")]
	[Token(Token = "0x40084E2")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<int> maxIteration;

	[Tooltip("The condition when to terminate the iteration and return status")]
	[Token(Token = "0x40084E3")]
	[FieldOffset(Offset = "0x98")]
	public TerminationConditions terminationCondition;

	[Tooltip("Should the iteration start from the begining after a node reset?")]
	[Token(Token = "0x40084E4")]
	[FieldOffset(Offset = "0x9C")]
	public bool resetIndex;

	[Token(Token = "0x40084E5")]
	[FieldOffset(Offset = "0xA0")]
	private int currentIndex;

	[Token(Token = "0x1700077D")]
	private IList list
	{
		[Token(Token = "0x6006DE6")]
		[Address(RVA = "0x10B2C70", Offset = "0x10B1A70", Length = "0x4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006DE7")]
	[Address(RVA = "0x10B2CC0", Offset = "0x10B1AC0", Length = "0x391")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DE8")]
	[Address(RVA = "0x10B3060", Offset = "0x10B1E60", Length = "0x14")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DE9")]
	[Address(RVA = "0x10B3080", Offset = "0x10B1E80", Length = "0x9C")]
	public Iterator()
	{
	}
}
