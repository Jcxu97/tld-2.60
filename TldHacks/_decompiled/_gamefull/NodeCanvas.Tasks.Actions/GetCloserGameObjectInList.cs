using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Description("Get the closer game object to the agent from within a list of game objects and save it in the blackboard.")]
[Token(Token = "0x2001297")]
public class GetCloserGameObjectInList : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008B67")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<GameObject>> list;

	[BlackboardOnly]
	[Token(Token = "0x4008B68")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> saveAs;

	[Token(Token = "0x170009CA")]
	protected override string info
	{
		[Token(Token = "0x6007893")]
		[Address(RVA = "0x11708A0", Offset = "0x116F6A0", Length = "0xBF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007894")]
	[Address(RVA = "0x1170960", Offset = "0x116F760", Length = "0x4A3")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007895")]
	[Address(RVA = "0x1170E10", Offset = "0x116FC10", Length = "0x44")]
	public GetCloserGameObjectInList()
	{
	}
}
