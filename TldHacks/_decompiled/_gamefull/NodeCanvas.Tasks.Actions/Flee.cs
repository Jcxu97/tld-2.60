using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

[Category("Movement/Pathfinding")]
[Description("Flees away from the target")]
[Token(Token = "0x20012E2")]
public class Flee : ActionTask<NavMeshAgent>
{
	[RequiredField]
	[Token(Token = "0x4008C3F")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008C40")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> speed;

	[Token(Token = "0x4008C41")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> fledDistance;

	[Token(Token = "0x4008C42")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> lookAhead;

	[Token(Token = "0x170009FA")]
	protected override string info
	{
		[Token(Token = "0x6007965")]
		[Address(RVA = "0x117D2C0", Offset = "0x117C0C0", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007966")]
	[Address(RVA = "0x117D350", Offset = "0x117C150", Length = "0x317")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007967")]
	[Address(RVA = "0x117D670", Offset = "0x117C470", Length = "0x6BA")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007968")]
	[Address(RVA = "0x10C54D0", Offset = "0x10C42D0", Length = "0x11")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x6007969")]
	[Address(RVA = "0x117DD30", Offset = "0x117CB30", Length = "0x17A")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x600796A")]
	[Address(RVA = "0x117DEB0", Offset = "0x117CCB0", Length = "0x182")]
	public Flee()
	{
	}
}
