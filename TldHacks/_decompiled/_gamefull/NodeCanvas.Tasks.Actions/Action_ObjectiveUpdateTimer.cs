using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Objective - Update Timer", 0)]
[Description("Update the timer ID of an objective that has already been added to the mission journal.")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x200125B")]
public class Action_ObjectiveUpdateTimer : ActionTask
{
	[Token(Token = "0x4008ABE")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectiveID;

	[Token(Token = "0x4008ABF")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> timerID;

	[Token(Token = "0x4008AC0")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x170009A1")]
	protected override string info
	{
		[Token(Token = "0x60077D7")]
		[Address(RVA = "0x1165330", Offset = "0x1164130", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077D8")]
	[Address(RVA = "0x1165400", Offset = "0x1164200", Length = "0x141")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077D9")]
	[Address(RVA = "0x1165550", Offset = "0x1164350", Length = "0x2C5")]
	public Action_ObjectiveUpdateTimer()
	{
	}
}
