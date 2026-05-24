using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("GameObject")]
[Description("A combination of line of sight and view angle check")]
[Token(Token = "0x2001175")]
public class CanSeeTarget : ConditionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008817")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008818")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> maxDistance;

	[Token(Token = "0x4008819")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> awarnessDistance;

	[SliderField(1, 180)]
	[Token(Token = "0x400881A")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> viewAngle;

	[Token(Token = "0x400881B")]
	[FieldOffset(Offset = "0x88")]
	public Vector3 offset;

	[Token(Token = "0x400881C")]
	[FieldOffset(Offset = "0x94")]
	private RaycastHit hit;

	[Token(Token = "0x17000924")]
	protected override string info
	{
		[Token(Token = "0x60074EA")]
		[Address(RVA = "0x11047A0", Offset = "0x11035A0", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074EB")]
	[Address(RVA = "0x1104810", Offset = "0x1103610", Length = "0xB32")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074EC")]
	[Address(RVA = "0x1105350", Offset = "0x1104150", Length = "0xEE5")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60074ED")]
	[Address(RVA = "0x1106240", Offset = "0x1105040", Length = "0x172")]
	public CanSeeTarget()
	{
	}
}
