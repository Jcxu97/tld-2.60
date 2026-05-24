using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Movement/Direct")]
[Description("Rotate the agent away from target per frame")]
[Token(Token = "0x20012DF")]
public class RotateAway : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008C32")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008C33")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> speed;

	[SliderField(1, 180)]
	[Token(Token = "0x4008C34")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> angleDifference;

	[Token(Token = "0x4008C35")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<Vector3> upVector;

	[Token(Token = "0x4008C36")]
	[FieldOffset(Offset = "0x88")]
	public bool waitActionFinish;

	[Token(Token = "0x600795F")]
	[Address(RVA = "0x117BDD0", Offset = "0x117ABD0", Length = "0x829")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007960")]
	[Address(RVA = "0x117C600", Offset = "0x117B400", Length = "0x1D2")]
	public RotateAway()
	{
	}
}
