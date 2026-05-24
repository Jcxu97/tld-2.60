using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Movement/Direct")]
[Description("Move & turn the agent based on input values provided ranging from -1 to 1, per second (using delta time)")]
[Token(Token = "0x20012DC")]
public class InputMove : ActionTask<Transform>
{
	[BlackboardOnly]
	[Token(Token = "0x4008C23")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> strafe;

	[BlackboardOnly]
	[Token(Token = "0x4008C24")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> turn;

	[BlackboardOnly]
	[Token(Token = "0x4008C25")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> forward;

	[BlackboardOnly]
	[Token(Token = "0x4008C26")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> up;

	[Token(Token = "0x4008C27")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<float> moveSpeed;

	[Token(Token = "0x4008C28")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<float> rotationSpeed;

	[Token(Token = "0x4008C29")]
	[FieldOffset(Offset = "0x98")]
	public bool repeat;

	[Token(Token = "0x6007959")]
	[Address(RVA = "0x117A2A0", Offset = "0x11790A0", Length = "0xBFF")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600795A")]
	[Address(RVA = "0x117AEA0", Offset = "0x1179CA0", Length = "0x122")]
	public InputMove()
	{
	}
}
