using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Queue Hint", 0)]
[Category("TLD Load Screen")]
[Token(Token = "0x2001250")]
public class Action_QueueLoadScreenHint : ActionTask
{
	[Token(Token = "0x4008A9E")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> locID;

	[Token(Token = "0x4008A9F")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> titleLocID;

	[Token(Token = "0x4008AA0")]
	private const int LOC_PREVIEW_LENGTH = 60;

	[Token(Token = "0x17000996")]
	protected override string info
	{
		[Token(Token = "0x60077B5")]
		[Address(RVA = "0x11616D0", Offset = "0x11604D0", Length = "0x2CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077B6")]
	[Address(RVA = "0x11619A0", Offset = "0x11607A0", Length = "0x231")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077B7")]
	[Address(RVA = "0x1161BE0", Offset = "0x11609E0", Length = "0x1F5")]
	public Action_QueueLoadScreenHint()
	{
	}
}
