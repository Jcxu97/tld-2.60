using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Input")]
[Token(Token = "0x20012D4")]
public class WaitMousePick : ActionTask
{
	[Token(Token = "0x20012D5")]
	public enum ButtonKeys
	{
		[Token(Token = "0x4008C02")]
		Left,
		[Token(Token = "0x4008C03")]
		Right,
		[Token(Token = "0x4008C04")]
		Middle
	}

	[Token(Token = "0x4008BFA")]
	[FieldOffset(Offset = "0x68")]
	public ButtonKeys buttonKey;

	[Token(Token = "0x4008BFB")]
	[FieldOffset(Offset = "0x6C")]
	public LayerMask mask;

	[BlackboardOnly]
	[Token(Token = "0x4008BFC")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> saveObjectAs;

	[BlackboardOnly]
	[Token(Token = "0x4008BFD")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> saveDistanceAs;

	[BlackboardOnly]
	[Token(Token = "0x4008BFE")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<Vector3> savePositionAs;

	[Token(Token = "0x4008BFF")]
	[FieldOffset(Offset = "0x88")]
	private int buttonID;

	[Token(Token = "0x4008C00")]
	[FieldOffset(Offset = "0x8C")]
	private RaycastHit hit;

	[Token(Token = "0x170009F8")]
	protected override string info
	{
		[Token(Token = "0x6007950")]
		[Address(RVA = "0x1179040", Offset = "0x1177E40", Length = "0xB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007951")]
	[Address(RVA = "0x11790F0", Offset = "0x1177EF0", Length = "0x2E4")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007952")]
	[Address(RVA = "0x11793E0", Offset = "0x11781E0", Length = "0x11")]
	public WaitMousePick()
	{
	}
}
