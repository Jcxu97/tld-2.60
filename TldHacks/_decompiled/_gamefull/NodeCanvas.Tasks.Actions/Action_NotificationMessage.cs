using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Notification Message", 0)]
[Description("Show a brief notification")]
[Category("TLD Mission UI")]
[Token(Token = "0x2001247")]
public class Action_NotificationMessage : ActionTask
{
	[Token(Token = "0x4008A7D")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> titleLocID;

	[Token(Token = "0x4008A7E")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> messageLocID;

	[Token(Token = "0x4008A7F")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> iconName;

	[Token(Token = "0x60077A1")]
	[Address(RVA = "0x115FD50", Offset = "0x115EB50", Length = "0x106")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077A2")]
	[Address(RVA = "0x115FE60", Offset = "0x115EC60", Length = "0x295")]
	public Action_NotificationMessage()
	{
	}
}
