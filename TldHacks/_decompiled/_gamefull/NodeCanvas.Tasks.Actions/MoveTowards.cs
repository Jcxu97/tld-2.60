using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Movement/Direct")]
[Description("Moves the agent towards to target per frame without pathfinding")]
[Token(Token = "0x20012DE")]
public class MoveTowards : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008C2E")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008C2F")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> speed;

	[Token(Token = "0x4008C30")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> stopDistance;

	[Token(Token = "0x4008C31")]
	[FieldOffset(Offset = "0x80")]
	public bool waitActionFinish;

	[Token(Token = "0x600795D")]
	[Address(RVA = "0x117B6D0", Offset = "0x117A4D0", Length = "0x5C8")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600795E")]
	[Address(RVA = "0x117BCA0", Offset = "0x117AAA0", Length = "0x122")]
	public MoveTowards()
	{
	}
}
