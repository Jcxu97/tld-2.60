using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Input")]
[Token(Token = "0x20012D1")]
public class GetInputAxis : ActionTask
{
	[Token(Token = "0x4008BED")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> xAxisName;

	[Token(Token = "0x4008BEE")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> yAxisName;

	[Token(Token = "0x4008BEF")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> zAxisName;

	[Token(Token = "0x4008BF0")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> multiplier;

	[BlackboardOnly]
	[Token(Token = "0x4008BF1")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<Vector3> saveAs;

	[BlackboardOnly]
	[Token(Token = "0x4008BF2")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<float> saveXAs;

	[BlackboardOnly]
	[Token(Token = "0x4008BF3")]
	[FieldOffset(Offset = "0x98")]
	public BBParameter<float> saveYAs;

	[BlackboardOnly]
	[Token(Token = "0x4008BF4")]
	[FieldOffset(Offset = "0xA0")]
	public BBParameter<float> saveZAs;

	[Token(Token = "0x4008BF5")]
	[FieldOffset(Offset = "0xA8")]
	public bool repeat;

	[Token(Token = "0x6007943")]
	[Address(RVA = "0x11789D0", Offset = "0x11777D0", Length = "0x7")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007944")]
	[Address(RVA = "0x11789D0", Offset = "0x11777D0", Length = "0x7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007945")]
	[Address(RVA = "0x11789E0", Offset = "0x11777E0", Length = "0x2BB")]
	private void Do()
	{
	}

	[Token(Token = "0x6007946")]
	[Address(RVA = "0x1178CA0", Offset = "0x1177AA0", Length = "0x1A2")]
	public GetInputAxis()
	{
	}
}
