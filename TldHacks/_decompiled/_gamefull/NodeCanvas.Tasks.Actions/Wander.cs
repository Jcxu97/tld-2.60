using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions;

[Category("Movement/Pathfinding")]
[Description("Makes the agent wander randomly within the navigation map")]
[Token(Token = "0x20012E7")]
public class Wander : ActionTask<NavMeshAgent>
{
	[Token(Token = "0x4008C56")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> speed;

	[Token(Token = "0x4008C57")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> keepDistance;

	[Token(Token = "0x4008C58")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> minWanderDistance;

	[Token(Token = "0x4008C59")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> maxWanderDistance;

	[Token(Token = "0x4008C5A")]
	[FieldOffset(Offset = "0x88")]
	public bool repeat;

	[Token(Token = "0x4008C5B")]
	[FieldOffset(Offset = "0x90")]
	private BipedMoveAgent bma;

	[Token(Token = "0x600797F")]
	[Address(RVA = "0x11813A0", Offset = "0x11801A0", Length = "0x269")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007980")]
	[Address(RVA = "0x1181610", Offset = "0x1180410", Length = "0x276")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007981")]
	[Address(RVA = "0x1181890", Offset = "0x1180690", Length = "0x998")]
	private void DoWander()
	{
	}

	[Token(Token = "0x6007982")]
	[Address(RVA = "0x10C54D0", Offset = "0x10C42D0", Length = "0x11")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x6007983")]
	[Address(RVA = "0x1182230", Offset = "0x1181030", Length = "0x2CC")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x6007984")]
	[Address(RVA = "0x1182500", Offset = "0x1181300", Length = "0x1E9")]
	public Wander()
	{
	}
}
