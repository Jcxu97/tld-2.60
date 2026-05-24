using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Physics")]
[Token(Token = "0x20012E8")]
public class GetLinecastInfo : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008C5C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008C5D")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<LayerMask> layerMask;

	[BlackboardOnly]
	[Token(Token = "0x4008C5E")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> saveHitGameObjectAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C5F")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> saveDistanceAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C60")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<Vector3> savePointAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C61")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<Vector3> saveNormalAs;

	[Token(Token = "0x4008C62")]
	[FieldOffset(Offset = "0x98")]
	private RaycastHit hit;

	[Token(Token = "0x6007985")]
	[Address(RVA = "0x11826F0", Offset = "0x11814F0", Length = "0x3ED")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007986")]
	[Address(RVA = "0x1182AE0", Offset = "0x11818E0", Length = "0x407")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6007987")]
	[Address(RVA = "0x1182EF0", Offset = "0x1181CF0", Length = "0xA3")]
	public GetLinecastInfo()
	{
	}
}
