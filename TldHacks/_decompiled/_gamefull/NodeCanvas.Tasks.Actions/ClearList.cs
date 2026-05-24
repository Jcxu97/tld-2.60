using System.Collections;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x2001296")]
public class ClearList : ActionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B66")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<IList> targetList;

	[Token(Token = "0x170009C9")]
	protected override string info
	{
		[Token(Token = "0x6007890")]
		[Address(RVA = "0x1170780", Offset = "0x116F580", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007891")]
	[Address(RVA = "0x1170810", Offset = "0x116F610", Length = "0x80")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007892")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public ClearList()
	{
	}
}
