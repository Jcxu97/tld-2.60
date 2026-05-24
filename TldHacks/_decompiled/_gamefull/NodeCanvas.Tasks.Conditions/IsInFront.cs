using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Target In View Angle", 0)]
[Category("GameObject")]
[Description("Checks whether the target is in the view angle of the agent")]
[Token(Token = "0x200117C")]
public class IsInFront : ConditionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x400882D")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> checkTarget;

	[SliderField(1, 180)]
	[Token(Token = "0x400882E")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> viewAngle;

	[Token(Token = "0x17000928")]
	protected override string info
	{
		[Token(Token = "0x6007501")]
		[Address(RVA = "0x11085E0", Offset = "0x11073E0", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007502")]
	[Address(RVA = "0x1108670", Offset = "0x1107470", Length = "0x303")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007503")]
	[Address(RVA = "0x1108980", Offset = "0x1107780", Length = "0x50C")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6007504")]
	[Address(RVA = "0x1108E90", Offset = "0x1107C90", Length = "0xA5")]
	public IsInFront()
	{
	}
}
