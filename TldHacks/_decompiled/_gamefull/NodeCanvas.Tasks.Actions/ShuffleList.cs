using System.Collections;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x200129F")]
public class ShuffleList : ActionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B7B")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<IList> targetList;

	[Token(Token = "0x60078A9")]
	[Address(RVA = "0x1170FA0", Offset = "0x116FDA0", Length = "0x365")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078AA")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public ShuffleList()
	{
	}
}
