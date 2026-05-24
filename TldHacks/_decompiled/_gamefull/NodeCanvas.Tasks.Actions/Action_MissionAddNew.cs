using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Mission - Add New", 0)]
[Description("Add new Mission Info to the mission journal")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x2001253")]
public class Action_MissionAddNew : ActionTask
{
	[Token(Token = "0x4008AA6")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionID;

	[Token(Token = "0x4008AA7")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x4008AA8")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> suppressUIMission;

	[Token(Token = "0x4008AA9")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> suppressUIChapter;

	[Token(Token = "0x17000999")]
	protected override string info
	{
		[Token(Token = "0x60077BE")]
		[Address(RVA = "0x1162800", Offset = "0x1161600", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077BF")]
	[Address(RVA = "0x11628D0", Offset = "0x11616D0", Length = "0x173")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077C0")]
	[Address(RVA = "0x1162A50", Offset = "0x1161850", Length = "0x366")]
	public Action_MissionAddNew()
	{
	}
}
