using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Description("Will sort the gameobjects in the target list by their distance to the agent (closer first) and save that list to the blackboard")]
[Token(Token = "0x20012A0")]
public class SortGameObjectListByDistance : ActionTask<Transform>
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B7C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<GameObject>> targetList;

	[BlackboardOnly]
	[Token(Token = "0x4008B7D")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<List<GameObject>> saveAs;

	[Token(Token = "0x4008B7E")]
	[FieldOffset(Offset = "0x78")]
	public bool reverse;

	[Token(Token = "0x170009D0")]
	protected override string info
	{
		[Token(Token = "0x60078AB")]
		[Address(RVA = "0x1171310", Offset = "0x1170110", Length = "0xBF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078AC")]
	[Address(RVA = "0x11713D0", Offset = "0x11701D0", Length = "0x1E5")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078AD")]
	[Address(RVA = "0x11715C0", Offset = "0x11703C0", Length = "0x44")]
	public SortGameObjectListByDistance()
	{
	}
}
