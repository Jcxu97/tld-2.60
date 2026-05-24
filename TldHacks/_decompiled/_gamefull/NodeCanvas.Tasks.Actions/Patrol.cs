using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

[Category("Movement/Pathfinding")]
[Description("Move Randomly or Progressively between various game object positions taken from the list provided")]
[Token(Token = "0x20012E5")]
public class Patrol : ActionTask<NavMeshAgent>
{
	[Token(Token = "0x20012E6")]
	public enum PatrolMode
	{
		[Token(Token = "0x4008C54")]
		Progressive,
		[Token(Token = "0x4008C55")]
		Random
	}

	[RequiredField]
	[Token(Token = "0x4008C4B")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<List<GameObject>> targetList;

	[Token(Token = "0x4008C4C")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<PatrolMode> patrolMode;

	[Token(Token = "0x4008C4D")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> speed;

	[Token(Token = "0x4008C4E")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> keepDistance;

	[Token(Token = "0x4008C4F")]
	[FieldOffset(Offset = "0x88")]
	private int index;

	[Token(Token = "0x4008C50")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3? lastRequest;

	[Token(Token = "0x4008C51")]
	[FieldOffset(Offset = "0xA0")]
	private BipedMoveAgent bma;

	[Token(Token = "0x4008C52")]
	[FieldOffset(Offset = "0xA8")]
	private List<BipedSyncPoint> targetSyncPointList;

	[Token(Token = "0x170009FD")]
	protected override string info
	{
		[Token(Token = "0x6007978")]
		[Address(RVA = "0x117F930", Offset = "0x117E730", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007979")]
	[Address(RVA = "0x117F9C0", Offset = "0x117E7C0", Length = "0x96F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600797A")]
	[Address(RVA = "0x1180330", Offset = "0x117F130", Length = "0x77D")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600797B")]
	[Address(RVA = "0x10C54D0", Offset = "0x10C42D0", Length = "0x11")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x600797C")]
	[Address(RVA = "0x1180AB0", Offset = "0x117F8B0", Length = "0x2CC")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x600797D")]
	[Address(RVA = "0x1180D80", Offset = "0x117FB80", Length = "0x3DA")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600797E")]
	[Address(RVA = "0x1181160", Offset = "0x117FF60", Length = "0x232")]
	public Patrol()
	{
	}
}
