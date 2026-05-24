using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("Input")]
[Token(Token = "0x2001180")]
public class CheckMousePick2D : ConditionTask
{
	[Token(Token = "0x4008839")]
	[FieldOffset(Offset = "0x68")]
	public ButtonKeys buttonKey;

	[Token(Token = "0x400883A")]
	[FieldOffset(Offset = "0x6C")]
	public LayerMask mask;

	[BlackboardOnly]
	[Token(Token = "0x400883B")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> saveGoAs;

	[BlackboardOnly]
	[Token(Token = "0x400883C")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> saveDistanceAs;

	[BlackboardOnly]
	[Token(Token = "0x400883D")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<Vector3> savePosAs;

	[Token(Token = "0x400883E")]
	[FieldOffset(Offset = "0x88")]
	private int buttonID;

	[Token(Token = "0x400883F")]
	[FieldOffset(Offset = "0x8C")]
	private RaycastHit2D hit;

	[Token(Token = "0x1700092C")]
	protected override string info
	{
		[Token(Token = "0x600750E")]
		[Address(RVA = "0x11097D0", Offset = "0x11085D0", Length = "0x1D2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600750F")]
	[Address(RVA = "0x11099B0", Offset = "0x11087B0", Length = "0x3C0")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007510")]
	[Address(RVA = "0x1109D80", Offset = "0x1108B80", Length = "0x11")]
	public CheckMousePick2D()
	{
	}
}
