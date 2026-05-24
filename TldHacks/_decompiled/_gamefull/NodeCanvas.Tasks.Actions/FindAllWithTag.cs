using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Description("Action will end in Failure if no objects are found")]
[Token(Token = "0x20012BF")]
public class FindAllWithTag : ActionTask
{
	[RequiredField]
	[TagField]
	[Token(Token = "0x4008BC7")]
	[FieldOffset(Offset = "0x68")]
	public string searchTag;

	[BlackboardOnly]
	[Token(Token = "0x4008BC8")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<List<GameObject>> saveAs;

	[Token(Token = "0x170009EB")]
	protected override string info
	{
		[Token(Token = "0x6007910")]
		[Address(RVA = "0x1175D30", Offset = "0x1174B30", Length = "0xA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007911")]
	[Address(RVA = "0x1175DD0", Offset = "0x1174BD0", Length = "0x15D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007912")]
	[Address(RVA = "0x1175F30", Offset = "0x1174D30", Length = "0x8E")]
	public FindAllWithTag()
	{
	}
}
