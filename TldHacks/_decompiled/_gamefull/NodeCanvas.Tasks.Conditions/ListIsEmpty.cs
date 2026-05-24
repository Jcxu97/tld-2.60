using System.Collections;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x2001173")]
public class ListIsEmpty : ConditionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008814")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<IList> targetList;

	[Token(Token = "0x17000922")]
	protected override string info
	{
		[Token(Token = "0x60074E4")]
		[Address(RVA = "0x1104580", Offset = "0x1103380", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074E5")]
	[Address(RVA = "0x1104610", Offset = "0x1103410", Length = "0x79")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074E6")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public ListIsEmpty()
	{
	}
}
