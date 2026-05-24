using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Mission - Update Timer", 0)]
[Description("Update the timer ID of an existing Mission Info entry on the mission journal")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x2001257")]
public class Action_MissionUpdateTimer : ActionTask
{
	[Token(Token = "0x4008AB3")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionID;

	[Token(Token = "0x4008AB4")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> timerID;

	[Token(Token = "0x4008AB5")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x1700099D")]
	protected override string info
	{
		[Token(Token = "0x60077CA")]
		[Address(RVA = "0x1163C90", Offset = "0x1162A90", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077CB")]
	[Address(RVA = "0x1163D60", Offset = "0x1162B60", Length = "0x141")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077CC")]
	[Address(RVA = "0x1163EB0", Offset = "0x1162CB0", Length = "0x2C5")]
	public Action_MissionUpdateTimer()
	{
	}
}
