using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

[Name("Find Closest NavMesh Edge", 0)]
[Category("Movement/Pathfinding")]
[Description("Find the closes Navigation Mesh position to the target position")]
[Token(Token = "0x20012E1")]
public class FindClosestEdge : ActionTask
{
	[Token(Token = "0x4008C3C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> targetPosition;

	[BlackboardOnly]
	[Token(Token = "0x4008C3D")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<Vector3> saveFoundPosition;

	[Token(Token = "0x4008C3E")]
	[FieldOffset(Offset = "0x78")]
	private NavMeshHit hit;

	[Token(Token = "0x6007963")]
	[Address(RVA = "0x117D1A0", Offset = "0x117BFA0", Length = "0x113")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007964")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public FindClosestEdge()
	{
	}
}
