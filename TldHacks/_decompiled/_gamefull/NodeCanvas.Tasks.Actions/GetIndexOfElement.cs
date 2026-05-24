using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x2001298")]
public class GetIndexOfElement<T> : ActionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B69")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<T>> targetList;

	[Token(Token = "0x4008B6A")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> targetElement;

	[BlackboardOnly]
	[Token(Token = "0x4008B6B")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<int> saveIndexAs;

	[Token(Token = "0x6007896")]
	[Address(RVA = "0x2956BE0", Offset = "0x29559E0", Length = "0xF7")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007897")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public GetIndexOfElement()
	{
	}
}
