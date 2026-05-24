using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Full Screen Message", 0)]
[Description("Show a full screen message, either overlaid on a black screen or over the game world.")]
[Category("TLD Mission UI")]
[Token(Token = "0x2001246")]
public class Action_FullScreenMessage : ActionTask
{
	[Token(Token = "0x4008A79")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> messageLocID;

	[Token(Token = "0x4008A7A")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> displayTime;

	[Token(Token = "0x4008A7B")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> blackOutScreen;

	[Token(Token = "0x4008A7C")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> fadeInText;

	[Token(Token = "0x600779F")]
	[Address(RVA = "0x115F860", Offset = "0x115E660", Length = "0x134")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077A0")]
	[Address(RVA = "0x115F9A0", Offset = "0x115E7A0", Length = "0x3A7")]
	public Action_FullScreenMessage()
	{
	}
}
