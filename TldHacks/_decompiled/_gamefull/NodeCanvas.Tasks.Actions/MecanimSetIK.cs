using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set IK", 0)]
[Category("Animator")]
[EventReceiver(new string[] { "OnAnimatorIK" })]
[Token(Token = "0x2001287")]
public class MecanimSetIK : ActionTask<Animator>
{
	[Token(Token = "0x4008B35")]
	[FieldOffset(Offset = "0x68")]
	public AvatarIKGoal IKGoal;

	[RequiredField]
	[Token(Token = "0x4008B36")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> goal;

	[Token(Token = "0x4008B37")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> weight;

	[Token(Token = "0x170009BB")]
	protected override string info
	{
		[Token(Token = "0x6007861")]
		[Address(RVA = "0x116E030", Offset = "0x116CE30", Length = "0xD9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007862")]
	[Address(RVA = "0x116E110", Offset = "0x116CF10", Length = "0x2BD")]
	public void OnAnimatorIK()
	{
	}

	[Token(Token = "0x6007863")]
	[Address(RVA = "0x116E3D0", Offset = "0x116D1D0", Length = "0x44")]
	public MecanimSetIK()
	{
	}
}
