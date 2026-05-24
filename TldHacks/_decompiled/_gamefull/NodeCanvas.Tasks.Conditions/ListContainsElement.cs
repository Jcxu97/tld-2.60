using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard/Lists")]
[Description("Check if an element is contained in the target list")]
[Token(Token = "0x2001172")]
public class ListContainsElement<T> : ConditionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008812")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<T>> targetList;

	[Token(Token = "0x4008813")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> checkElement;

	[Token(Token = "0x17000921")]
	protected override string info
	{
		[Token(Token = "0x60074E1")]
		[Address(RVA = "0x1BB5A70", Offset = "0x1BB4870", Length = "0x9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074E2")]
	[Address(RVA = "0x1BB5B10", Offset = "0x1BB4910", Length = "0xDF")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074E3")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public ListContainsElement()
	{
	}
}
