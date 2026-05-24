using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x200129E")]
public class SetListElement<T> : ActionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B78")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<T>> targetList;

	[Token(Token = "0x4008B79")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<int> index;

	[Token(Token = "0x4008B7A")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> newValue;

	[Token(Token = "0x60078A7")]
	[Address(RVA = "0x1FE3920", Offset = "0x1FE2720", Length = "0x15D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078A8")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetListElement()
	{
	}
}
