using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x2001295")]
public class AddElementToList<T> : ActionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B64")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<List<T>> targetList;

	[Token(Token = "0x4008B65")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> targetElement;

	[Token(Token = "0x170009C8")]
	protected override string info
	{
		[Token(Token = "0x600788D")]
		[Address(RVA = "0x25106A0", Offset = "0x250F4A0", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600788E")]
	[Address(RVA = "0x2510730", Offset = "0x250F530", Length = "0xDB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600788F")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public AddElementToList()
	{
	}
}
