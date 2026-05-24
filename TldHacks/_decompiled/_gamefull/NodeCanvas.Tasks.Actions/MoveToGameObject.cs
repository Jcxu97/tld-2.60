using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

[Name("Seek (GameObject)", 0)]
[Category("Movement/Pathfinding")]
[Token(Token = "0x20012E3")]
public class MoveToGameObject : ActionTask<NavMeshAgent>
{
	[RequiredField]
	[Token(Token = "0x4008C43")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008C44")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> speed;

	[Token(Token = "0x4008C45")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> keepDistance;

	[Token(Token = "0x4008C46")]
	[FieldOffset(Offset = "0x80")]
	private Vector3? lastRequest;

	[Token(Token = "0x170009FB")]
	protected override string info
	{
		[Token(Token = "0x600796B")]
		[Address(RVA = "0x117E040", Offset = "0x117CE40", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600796C")]
	[Address(RVA = "0x117E0B0", Offset = "0x117CEB0", Length = "0x447")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600796D")]
	[Address(RVA = "0x117E500", Offset = "0x117D300", Length = "0x4AB")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600796E")]
	[Address(RVA = "0x117E9B0", Offset = "0x117D7B0", Length = "0x124")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x600796F")]
	[Address(RVA = "0x10C54D0", Offset = "0x10C42D0", Length = "0x11")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x6007970")]
	[Address(RVA = "0x117EAE0", Offset = "0x117D8E0", Length = "0x25C")]
	public override void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6007971")]
	[Address(RVA = "0x117ED40", Offset = "0x117DB40", Length = "0x122")]
	public MoveToGameObject()
	{
	}
}
