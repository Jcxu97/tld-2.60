using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Token(Token = "0x2001300")]
public class DebugDrawLine : ActionTask
{
	[Token(Token = "0x4008CA7")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> from;

	[Token(Token = "0x4008CA8")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<Vector3> to;

	[Token(Token = "0x4008CA9")]
	[FieldOffset(Offset = "0x78")]
	public Color color;

	[Token(Token = "0x4008CAA")]
	[FieldOffset(Offset = "0x88")]
	public float timeToShow;

	[Token(Token = "0x6007A0C")]
	[Address(RVA = "0x118CB60", Offset = "0x118B960", Length = "0x1C3")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A0D")]
	[Address(RVA = "0x118CD30", Offset = "0x118BB30", Length = "0x1D")]
	public DebugDrawLine()
	{
	}
}
