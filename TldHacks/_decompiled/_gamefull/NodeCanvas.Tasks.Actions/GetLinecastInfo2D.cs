using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Physics")]
[Token(Token = "0x20012E9")]
public class GetLinecastInfo2D : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008C63")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x4008C64")]
	[FieldOffset(Offset = "0x70")]
	public LayerMask mask;

	[BlackboardOnly]
	[Token(Token = "0x4008C65")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> saveHitGameObjectAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C66")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> saveDistanceAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C67")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<Vector3> savePointAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C68")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<Vector3> saveNormalAs;

	[Token(Token = "0x4008C69")]
	[FieldOffset(Offset = "0x98")]
	private RaycastHit2D hit;

	[Token(Token = "0x6007988")]
	[Address(RVA = "0x1182FA0", Offset = "0x1181DA0", Length = "0x592")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007989")]
	[Address(RVA = "0x1183540", Offset = "0x1182340", Length = "0x407")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600798A")]
	[Address(RVA = "0x1183950", Offset = "0x1182750", Length = "0x52")]
	public GetLinecastInfo2D()
	{
	}
}
