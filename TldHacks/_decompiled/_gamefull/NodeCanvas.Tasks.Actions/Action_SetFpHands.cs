using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set FP Hands", 0)]
[Description("Changes which FP hand mesh is shown")]
[Category("TLD Actions/Player")]
[Token(Token = "0x200120D")]
public class Action_SetFpHands : ActionTask
{
	[Token(Token = "0x40089B0")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<HandState> hands;

	[Token(Token = "0x17000979")]
	protected override string info
	{
		[Token(Token = "0x60076F4")]
		[Address(RVA = "0x11525A0", Offset = "0x11513A0", Length = "0xA2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60076F5")]
	[Address(RVA = "0x1152650", Offset = "0x1151450", Length = "0x16F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076F6")]
	[Address(RVA = "0x11527C0", Offset = "0x11515C0", Length = "0x163")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60076F7")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetFpHands()
	{
	}
}
