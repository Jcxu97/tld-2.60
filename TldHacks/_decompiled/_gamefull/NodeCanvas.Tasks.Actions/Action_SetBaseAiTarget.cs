using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("SetBaseAiTarget", 0)]
[Description("Forces A BaseAI object to Target a specific mission object identifier")]
[Category("TLD Actions/BaseAi")]
[Token(Token = "0x20011AC")]
public class Action_SetBaseAiTarget : TLD_Action
{
	[Token(Token = "0x40088B0")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x60075DD")]
	[Address(RVA = "0x1112B90", Offset = "0x1111990", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075DE")]
	[Address(RVA = "0x1112BC0", Offset = "0x11119C0", Length = "0x231")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60075DF")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetBaseAiTarget()
	{
	}
}
