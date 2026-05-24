using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Objective - Mark Complete", 0)]
[Description("Mark completion status of an objective that has already been added to the mission journal.")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x200125C")]
public class Action_ObjectiveCompleteMain : ActionTask
{
	[Token(Token = "0x4008AC1")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectiveID;

	[Token(Token = "0x4008AC2")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x170009A2")]
	protected override string info
	{
		[Token(Token = "0x60077DA")]
		[Address(RVA = "0x1165820", Offset = "0x1164620", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077DB")]
	[Address(RVA = "0x11658F0", Offset = "0x11646F0", Length = "0x116")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077DC")]
	[Address(RVA = "0x1165A10", Offset = "0x1164810", Length = "0x215")]
	public Action_ObjectiveCompleteMain()
	{
	}
}
