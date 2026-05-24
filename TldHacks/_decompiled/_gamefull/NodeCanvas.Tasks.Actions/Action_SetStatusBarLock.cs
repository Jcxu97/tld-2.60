using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Status Bar Lock", 0)]
[Description("If set to true, prevents hunger/thirst/cold/fatigue from moving up or down and hides them on the HUD")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001216")]
public class Action_SetStatusBarLock : ActionTask
{
	[Token(Token = "0x40089D7")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> setStatusBarLock;

	[Token(Token = "0x1700097D")]
	protected override string info
	{
		[Token(Token = "0x600770F")]
		[Address(RVA = "0x1155060", Offset = "0x1153E60", Length = "0xC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600770E")]
	[Address(RVA = "0x1154FC0", Offset = "0x1153DC0", Length = "0x98")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007710")]
	[Address(RVA = "0x1155130", Offset = "0x1153F30", Length = "0x93")]
	public Action_SetStatusBarLock()
	{
	}
}
