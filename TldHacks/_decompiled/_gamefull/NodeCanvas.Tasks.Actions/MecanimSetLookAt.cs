using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Look At", 0)]
[Category("Animator")]
[EventReceiver(new string[] { "OnAnimatorIK" })]
[Token(Token = "0x200128A")]
public class MecanimSetLookAt : ActionTask<Animator>
{
	[Token(Token = "0x4008B3F")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> targetPosition;

	[Token(Token = "0x4008B40")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> targetWeight;

	[Token(Token = "0x4008B41")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> targetkWeightBody;

	[Token(Token = "0x4008B42")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> targetWeightHead;

	[Token(Token = "0x4008B43")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<float> targetWeightEyes;

	[Token(Token = "0x4008B44")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<float> targetWeightClamp;

	[Token(Token = "0x4008B45")]
	[FieldOffset(Offset = "0x98")]
	private BipedMoveAgent bma;

	[Token(Token = "0x170009BE")]
	protected override string info
	{
		[Token(Token = "0x600786B")]
		[Address(RVA = "0x116EB10", Offset = "0x116D910", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600786C")]
	[Address(RVA = "0x116EB80", Offset = "0x116D980", Length = "0x37A")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600786D")]
	[Address(RVA = "0x116EF00", Offset = "0x116DD00", Length = "0x500")]
	public void OnAnimatorIK()
	{
	}

	[Token(Token = "0x600786E")]
	[Address(RVA = "0x116F410", Offset = "0x116E210", Length = "0x1C2")]
	public MecanimSetLookAt()
	{
	}
}
