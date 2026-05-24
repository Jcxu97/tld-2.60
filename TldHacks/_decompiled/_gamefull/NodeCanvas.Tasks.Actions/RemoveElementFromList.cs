using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Description("Remove an element from the target list")]
[Token(Token = "0x200129D")]
public class RemoveElementFromList<T> : ActionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B76")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<T>> targetList;

	[Token(Token = "0x4008B77")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> targetElement;

	[Token(Token = "0x170009CF")]
	protected override string info
	{
		[Token(Token = "0x60078A4")]
		[Address(RVA = "0x1FC34F0", Offset = "0x1FC22F0", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078A5")]
	[Address(RVA = "0x1FC3580", Offset = "0x1FC2380", Length = "0x92")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078A6")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public RemoveElementFromList()
	{
	}
}
