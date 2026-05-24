using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("Input")]
[Token(Token = "0x200117F")]
public class CheckMousePick : ConditionTask
{
	[Token(Token = "0x4008833")]
	[FieldOffset(Offset = "0x68")]
	public ButtonKeys buttonKey;

	[LayerField]
	[Token(Token = "0x4008834")]
	[FieldOffset(Offset = "0x6C")]
	public int layer;

	[BlackboardOnly]
	[Token(Token = "0x4008835")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> saveGoAs;

	[BlackboardOnly]
	[Token(Token = "0x4008836")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> saveDistanceAs;

	[BlackboardOnly]
	[Token(Token = "0x4008837")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<Vector3> savePosAs;

	[Token(Token = "0x4008838")]
	[FieldOffset(Offset = "0x88")]
	private RaycastHit hit;

	[Token(Token = "0x1700092B")]
	protected override string info
	{
		[Token(Token = "0x600750B")]
		[Address(RVA = "0x1109310", Offset = "0x1108110", Length = "0x1C7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600750C")]
	[Address(RVA = "0x11094E0", Offset = "0x11082E0", Length = "0x2E4")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600750D")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckMousePick()
	{
	}
}
