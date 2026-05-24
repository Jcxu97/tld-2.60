using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012CA")]
public class GetDistance : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008BDE")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[BlackboardOnly]
	[Token(Token = "0x4008BDF")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> saveAs;

	[Token(Token = "0x170009F1")]
	protected override string info
	{
		[Token(Token = "0x600792F")]
		[Address(RVA = "0x1177750", Offset = "0x1176550", Length = "0x9B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007930")]
	[Address(RVA = "0x11777F0", Offset = "0x11765F0", Length = "0x2E2")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007931")]
	[Address(RVA = "0x1177AE0", Offset = "0x11768E0", Length = "0x44")]
	public GetDistance()
	{
	}
}
