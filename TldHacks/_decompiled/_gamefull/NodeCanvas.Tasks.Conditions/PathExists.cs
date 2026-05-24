using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Conditions;

[Category("Movement")]
[Description("Check if a path exists for the agent and optionaly save the resulting path positions")]
[Token(Token = "0x2001181")]
public class PathExists : ConditionTask<NavMeshAgent>
{
	[Token(Token = "0x4008840")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> targetPosition;

	[BlackboardOnly]
	[Token(Token = "0x4008841")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<List<Vector3>> savePathAs;

	[Token(Token = "0x6007511")]
	[Address(RVA = "0x1109DA0", Offset = "0x1108BA0", Length = "0x38C")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007512")]
	[Address(RVA = "0x110A130", Offset = "0x1108F30", Length = "0x44")]
	public PathExists()
	{
	}
}
