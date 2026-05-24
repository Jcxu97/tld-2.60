using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Input")]
[Token(Token = "0x20012D6")]
public class WaitMousePick2D : ActionTask
{
	[Token(Token = "0x20012D7")]
	public enum ButtonKeys
	{
		[Token(Token = "0x4008C0D")]
		Left,
		[Token(Token = "0x4008C0E")]
		Right,
		[Token(Token = "0x4008C0F")]
		Middle
	}

	[Token(Token = "0x4008C05")]
	[FieldOffset(Offset = "0x68")]
	public ButtonKeys buttonKey;

	[Token(Token = "0x4008C06")]
	[FieldOffset(Offset = "0x6C")]
	public LayerMask mask;

	[BlackboardOnly]
	[Token(Token = "0x4008C07")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> saveObjectAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C08")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> saveDistanceAs;

	[BlackboardOnly]
	[Token(Token = "0x4008C09")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<Vector3> savePositionAs;

	[Token(Token = "0x4008C0A")]
	[FieldOffset(Offset = "0x88")]
	private int buttonID;

	[Token(Token = "0x4008C0B")]
	[FieldOffset(Offset = "0x8C")]
	private RaycastHit2D hit;

	[Token(Token = "0x170009F9")]
	protected override string info
	{
		[Token(Token = "0x6007953")]
		[Address(RVA = "0x1179400", Offset = "0x1178200", Length = "0xB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007954")]
	[Address(RVA = "0x11794B0", Offset = "0x11782B0", Length = "0x3C7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007955")]
	[Address(RVA = "0x11793E0", Offset = "0x11781E0", Length = "0x11")]
	public WaitMousePick2D()
	{
	}
}
