using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Movement/Direct")]
[Description("Rotate the agent towards the target per frame")]
[Token(Token = "0x20012E0")]
public class RotateTowards : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008C37")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008C38")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> speed;

	[SliderField(1, 180)]
	[Token(Token = "0x4008C39")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> angleDifference;

	[Token(Token = "0x4008C3A")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<Vector3> upVector;

	[Token(Token = "0x4008C3B")]
	[FieldOffset(Offset = "0x88")]
	public bool waitActionFinish;

	[Token(Token = "0x6007961")]
	[Address(RVA = "0x117C7E0", Offset = "0x117B5E0", Length = "0x7D9")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007962")]
	[Address(RVA = "0x117CFC0", Offset = "0x117BDC0", Length = "0x1D2")]
	public RotateTowards()
	{
	}
}
