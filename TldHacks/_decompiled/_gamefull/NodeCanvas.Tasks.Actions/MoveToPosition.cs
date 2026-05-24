using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

[Name("Seek (Vector3)", 0)]
[Category("Movement/Pathfinding")]
[Token(Token = "0x20012E4")]
public class MoveToPosition : ActionTask<NavMeshAgent>
{
	[Token(Token = "0x4008C47")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> targetPosition;

	[Token(Token = "0x4008C48")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> speed;

	[Token(Token = "0x4008C49")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> keepDistance;

	[Token(Token = "0x4008C4A")]
	[FieldOffset(Offset = "0x80")]
	private Vector3? lastRequest;

	[Token(Token = "0x170009FC")]
	protected override string info
	{
		[Token(Token = "0x6007972")]
		[Address(RVA = "0x117EE70", Offset = "0x117DC70", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007973")]
	[Address(RVA = "0x117EEE0", Offset = "0x117DCE0", Length = "0x39C")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007974")]
	[Address(RVA = "0x117F280", Offset = "0x117E080", Length = "0x44B")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007975")]
	[Address(RVA = "0x117F6D0", Offset = "0x117E4D0", Length = "0x124")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x6007976")]
	[Address(RVA = "0x10C54D0", Offset = "0x10C42D0", Length = "0x11")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x6007977")]
	[Address(RVA = "0x117F800", Offset = "0x117E600", Length = "0x122")]
	public MoveToPosition()
	{
	}
}
