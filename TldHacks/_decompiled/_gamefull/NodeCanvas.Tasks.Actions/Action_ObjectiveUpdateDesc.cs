using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Objective - Update Desc", 0)]
[Description("Update the description of an objective that has already been added to the mission journal.")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x200125A")]
public class Action_ObjectiveUpdateDesc : ActionTask
{
	[Token(Token = "0x4008ABB")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectiveID;

	[Token(Token = "0x4008ABC")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> descLocID;

	[Token(Token = "0x4008ABD")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x170009A0")]
	protected override string info
	{
		[Token(Token = "0x60077D4")]
		[Address(RVA = "0x1164E40", Offset = "0x1163C40", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077D5")]
	[Address(RVA = "0x1164F10", Offset = "0x1163D10", Length = "0x141")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077D6")]
	[Address(RVA = "0x1165060", Offset = "0x1163E60", Length = "0x2C5")]
	public Action_ObjectiveUpdateDesc()
	{
	}
}
