using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Objective - Add New", 0)]
[Description("Add a new objective to its predetermined mission.")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x2001259")]
public class Action_ObjectiveAddNew : ActionTask
{
	[Token(Token = "0x4008AB9")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectiveID;

	[Token(Token = "0x4008ABA")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x1700099F")]
	protected override string info
	{
		[Token(Token = "0x60077D0")]
		[Address(RVA = "0x11646E0", Offset = "0x11634E0", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077D1")]
	[Address(RVA = "0x11647B0", Offset = "0x11635B0", Length = "0x339")]
	private void RegisterGraphLink()
	{
	}

	[Token(Token = "0x60077D2")]
	[Address(RVA = "0x1164AF0", Offset = "0x11638F0", Length = "0x120")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077D3")]
	[Address(RVA = "0x1164C20", Offset = "0x1163A20", Length = "0x215")]
	public Action_ObjectiveAddNew()
	{
	}
}
