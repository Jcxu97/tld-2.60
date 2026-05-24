using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Physics")]
[Description("Get hit info for ALL objects in the linecast, in Lists")]
[Token(Token = "0x20012EA")]
public class GetLinecastInfo2DAll : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008C6A")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008C6B")]
	[FieldOffset(Offset = "0x70")]
	public LayerMask mask;

	[BlackboardOnly]
	[Token(Token = "0x4008C6C")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<List<GameObject>> saveHitGameObjectsAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C6D")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<List<float>> saveDistancesAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C6E")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<List<Vector3>> savePointsAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C6F")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<List<Vector3>> saveNormalsAs;

	[Token(Token = "0x4008C70")]
	[FieldOffset(Offset = "0x98")]
	private RaycastHit2D[] hits;

	[Token(Token = "0x600798B")]
	[Address(RVA = "0x11839B0", Offset = "0x11827B0", Length = "0xB49")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600798C")]
	[Address(RVA = "0x1184500", Offset = "0x1183300", Length = "0x407")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600798D")]
	[Address(RVA = "0x1184910", Offset = "0x1183710", Length = "0x52")]
	public GetLinecastInfo2DAll()
	{
	}
}
