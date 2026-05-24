using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Mission - Update Name", 0)]
[Description("Update the name of an existing Mission Info entry on the mission journal")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x2001254")]
public class Action_MissionUpdateName : ActionTask
{
	[Token(Token = "0x4008AAA")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionID;

	[Token(Token = "0x4008AAB")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> nameLocID;

	[Token(Token = "0x4008AAC")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x1700099A")]
	protected override string info
	{
		[Token(Token = "0x60077C1")]
		[Address(RVA = "0x1162DC0", Offset = "0x1161BC0", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077C2")]
	[Address(RVA = "0x1162E90", Offset = "0x1161C90", Length = "0x141")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077C3")]
	[Address(RVA = "0x1162FE0", Offset = "0x1161DE0", Length = "0x2C5")]
	public Action_MissionUpdateName()
	{
	}
}
