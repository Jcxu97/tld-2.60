using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Target In Line Of Sight 2D", 0)]
[Category("GameObject")]
[Description("Check of agent is in line of sight with target by doing a linecast and optionaly save the distance")]
[Token(Token = "0x2001178")]
public class CheckLOS2D : ConditionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008826")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> LOSTarget;

	[Token(Token = "0x4008827")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<LayerMask> layerMask;

	[BlackboardOnly]
	[Token(Token = "0x4008828")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> saveDistanceAs;

	[GetFromAgent]
	[Token(Token = "0x4008829")]
	[FieldOffset(Offset = "0x80")]
	protected Collider2D agentCollider;

	[Token(Token = "0x400882A")]
	[FieldOffset(Offset = "0x88")]
	private RaycastHit2D[] hits;

	[Token(Token = "0x17000927")]
	protected override string info
	{
		[Token(Token = "0x60074F6")]
		[Address(RVA = "0x1107660", Offset = "0x1106460", Length = "0x62")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074F7")]
	[Address(RVA = "0x11076D0", Offset = "0x11064D0", Length = "0x818")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074F8")]
	[Address(RVA = "0x1107EF0", Offset = "0x1106CF0", Length = "0x407")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60074F9")]
	[Address(RVA = "0x1108300", Offset = "0x1107100", Length = "0xA3")]
	public CheckLOS2D()
	{
	}
}
