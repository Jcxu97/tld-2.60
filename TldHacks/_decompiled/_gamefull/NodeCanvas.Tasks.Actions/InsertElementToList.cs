using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x200129A")]
public class InsertElementToList<T> : ActionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B6E")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<T>> targetList;

	[Token(Token = "0x4008B6F")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> targetElement;

	[Token(Token = "0x4008B70")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<int> targetIndex;

	[Token(Token = "0x170009CC")]
	protected override string info
	{
		[Token(Token = "0x600789B")]
		[Address(RVA = "0x1B194F0", Offset = "0x1B182F0", Length = "0x95")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600789C")]
	[Address(RVA = "0x1B19590", Offset = "0x1B18390", Length = "0xEF")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600789D")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public InsertElementToList()
	{
	}
}
