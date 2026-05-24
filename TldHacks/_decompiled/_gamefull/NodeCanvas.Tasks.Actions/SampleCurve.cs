using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Token(Token = "0x20012A3")]
public class SampleCurve : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008B82")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<AnimationCurve> curve;

	[SliderField(0, 1)]
	[Token(Token = "0x4008B83")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> sampleAt;

	[BlackboardOnly]
	[Token(Token = "0x4008B84")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> saveAs;

	[Token(Token = "0x60078B4")]
	[Address(RVA = "0x1171CB0", Offset = "0x1170AB0", Length = "0x12E")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078B5")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SampleCurve()
	{
	}
}
