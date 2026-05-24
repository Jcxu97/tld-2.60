using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Token(Token = "0x2001292")]
public class EvaluateCurve : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008B5B")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<AnimationCurve> curve;

	[Token(Token = "0x4008B5C")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> from;

	[Token(Token = "0x4008B5D")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> to;

	[Token(Token = "0x4008B5E")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> time;

	[BlackboardOnly]
	[Token(Token = "0x4008B5F")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<float> saveAs;

	[Token(Token = "0x6007885")]
	[Address(RVA = "0x1170070", Offset = "0x116EE70", Length = "0x1F7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007886")]
	[Address(RVA = "0x1170270", Offset = "0x116F070", Length = "0x112")]
	public EvaluateCurve()
	{
	}
}
