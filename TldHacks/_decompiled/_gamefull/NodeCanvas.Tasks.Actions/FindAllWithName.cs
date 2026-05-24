using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Description("Note that this is slow.\nAction will end in Failure if no objects are found")]
[Token(Token = "0x20012BE")]
public class FindAllWithName : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008BC5")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> searchName;

	[BlackboardOnly]
	[Token(Token = "0x4008BC6")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<List<GameObject>> saveAs;

	[Token(Token = "0x170009EA")]
	protected override string info
	{
		[Token(Token = "0x600790D")]
		[Address(RVA = "0x1175950", Offset = "0x1174750", Length = "0xBF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600790E")]
	[Address(RVA = "0x1175A10", Offset = "0x1174810", Length = "0x25D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600790F")]
	[Address(RVA = "0x1175C70", Offset = "0x1174A70", Length = "0xB3")]
	public FindAllWithName()
	{
	}
}
