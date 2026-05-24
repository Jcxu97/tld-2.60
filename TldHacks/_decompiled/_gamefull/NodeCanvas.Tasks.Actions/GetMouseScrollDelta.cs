using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("Input")]
[Token(Token = "0x20012D3")]
public class GetMouseScrollDelta : ActionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008BF8")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> saveAs;

	[Token(Token = "0x4008BF9")]
	[FieldOffset(Offset = "0x70")]
	public bool repeat;

	[Token(Token = "0x170009F7")]
	protected override string info
	{
		[Token(Token = "0x600794B")]
		[Address(RVA = "0x1178F30", Offset = "0x1177D30", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600794C")]
	[Address(RVA = "0x1178FA0", Offset = "0x1177DA0", Length = "0x7")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600794D")]
	[Address(RVA = "0x1178FA0", Offset = "0x1177DA0", Length = "0x7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600794E")]
	[Address(RVA = "0x1178FB0", Offset = "0x1177DB0", Length = "0x84")]
	private void Do()
	{
	}

	[Token(Token = "0x600794F")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public GetMouseScrollDelta()
	{
	}
}
