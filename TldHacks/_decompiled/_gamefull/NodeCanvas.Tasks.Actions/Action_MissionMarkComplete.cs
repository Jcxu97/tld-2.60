using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Mission - Mark Complete", 0)]
[Description("Mark the completion status of an existing Mission Info entry on the mission journal")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x2001258")]
public class Action_MissionMarkComplete : ActionTask
{
	[Token(Token = "0x4008AB6")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionID;

	[Token(Token = "0x4008AB7")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> completedSuccessfully;

	[Token(Token = "0x4008AB8")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x1700099E")]
	protected override string info
	{
		[Token(Token = "0x60077CD")]
		[Address(RVA = "0x1164180", Offset = "0x1162F80", Length = "0x13C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077CE")]
	[Address(RVA = "0x11642C0", Offset = "0x11630C0", Length = "0x142")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077CF")]
	[Address(RVA = "0x1164410", Offset = "0x1163210", Length = "0x2C5")]
	public Action_MissionMarkComplete()
	{
	}
}
