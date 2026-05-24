using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Mission - Update Desc", 0)]
[Description("Update the description of an existing Mission Info entry on the mission journal")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x2001255")]
public class Action_MissionUpdateDesc : ActionTask
{
	[Token(Token = "0x4008AAD")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionID;

	[Token(Token = "0x4008AAE")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> descID;

	[Token(Token = "0x4008AAF")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x1700099B")]
	protected override string info
	{
		[Token(Token = "0x60077C4")]
		[Address(RVA = "0x11632B0", Offset = "0x11620B0", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077C5")]
	[Address(RVA = "0x1163380", Offset = "0x1162180", Length = "0x141")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077C6")]
	[Address(RVA = "0x11634D0", Offset = "0x11622D0", Length = "0x2C5")]
	public Action_MissionUpdateDesc()
	{
	}
}
