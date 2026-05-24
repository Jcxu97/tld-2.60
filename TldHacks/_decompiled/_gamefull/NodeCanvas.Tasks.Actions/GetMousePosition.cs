using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Input")]
[Token(Token = "0x20012D2")]
public class GetMousePosition : ActionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008BF6")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> saveAs;

	[Token(Token = "0x4008BF7")]
	[FieldOffset(Offset = "0x70")]
	public bool repeat;

	[Token(Token = "0x6007947")]
	[Address(RVA = "0x1178E50", Offset = "0x1177C50", Length = "0x7")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007948")]
	[Address(RVA = "0x1178E50", Offset = "0x1177C50", Length = "0x7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007949")]
	[Address(RVA = "0x1178E60", Offset = "0x1177C60", Length = "0xC8")]
	private void Do()
	{
	}

	[Token(Token = "0x600794A")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public GetMousePosition()
	{
	}
}
