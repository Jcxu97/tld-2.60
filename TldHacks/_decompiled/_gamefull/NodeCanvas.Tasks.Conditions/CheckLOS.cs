using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Target In Line Of Sight", 0)]
[Category("GameObject")]
[Description("Check of agent is in line of sight with target by doing a linecast and optionaly save the distance")]
[Token(Token = "0x2001177")]
public class CheckLOS : ConditionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008821")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> LOSTarget;

	[Token(Token = "0x4008822")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<LayerMask> layerMask;

	[Token(Token = "0x4008823")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 offset;

	[BlackboardOnly]
	[Token(Token = "0x4008824")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<float> saveDistanceAs;

	[Token(Token = "0x4008825")]
	[FieldOffset(Offset = "0x90")]
	private RaycastHit hit;

	[Token(Token = "0x17000926")]
	protected override string info
	{
		[Token(Token = "0x60074F2")]
		[Address(RVA = "0x1106B90", Offset = "0x1105990", Length = "0x62")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074F3")]
	[Address(RVA = "0x1106C00", Offset = "0x1105A00", Length = "0x51C")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074F4")]
	[Address(RVA = "0x1107120", Offset = "0x1105F20", Length = "0x48B")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60074F5")]
	[Address(RVA = "0x11075B0", Offset = "0x11063B0", Length = "0xA3")]
	public CheckLOS()
	{
	}
}
