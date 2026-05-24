using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Curve Tween", 0)]
[Category("Movement/Direct")]
[Token(Token = "0x20012D8")]
public class CurveTransformTween : ActionTask<Transform>
{
	[Token(Token = "0x20012D9")]
	public enum TransformMode
	{
		[Token(Token = "0x4008C1A")]
		Position,
		[Token(Token = "0x4008C1B")]
		Rotation,
		[Token(Token = "0x4008C1C")]
		Scale
	}

	[Token(Token = "0x20012DA")]
	public enum TweenMode
	{
		[Token(Token = "0x4008C1E")]
		Absolute,
		[Token(Token = "0x4008C1F")]
		Additive
	}

	[Token(Token = "0x20012DB")]
	public enum PlayMode
	{
		[Token(Token = "0x4008C21")]
		Normal,
		[Token(Token = "0x4008C22")]
		PingPong
	}

	[Token(Token = "0x4008C10")]
	[FieldOffset(Offset = "0x68")]
	public TransformMode transformMode;

	[Token(Token = "0x4008C11")]
	[FieldOffset(Offset = "0x6C")]
	public TweenMode mode;

	[Token(Token = "0x4008C12")]
	[FieldOffset(Offset = "0x70")]
	public PlayMode playMode;

	[Token(Token = "0x4008C13")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<Vector3> targetPosition;

	[Token(Token = "0x4008C14")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<AnimationCurve> curve;

	[Token(Token = "0x4008C15")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<float> time;

	[Token(Token = "0x4008C16")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 original;

	[Token(Token = "0x4008C17")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 final;

	[Token(Token = "0x4008C18")]
	[FieldOffset(Offset = "0xA8")]
	private bool ponging;

	[Token(Token = "0x6007956")]
	[Address(RVA = "0x1179880", Offset = "0x1178680", Length = "0x441")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007957")]
	[Address(RVA = "0x1179CD0", Offset = "0x1178AD0", Length = "0x468")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007958")]
	[Address(RVA = "0x117A140", Offset = "0x1178F40", Length = "0x152")]
	public CurveTransformTween()
	{
	}
}
