using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Objective - Toggle Invisible", 0)]
[Description("Flags an objective that has already been added to the mission journal, making it invisible.")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x200125D")]
public class Action_ObjectiveToggleInvisible : ActionTask
{
	[Token(Token = "0x4008AC3")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> objectiveID;

	[Token(Token = "0x4008AC4")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> invisible;

	[Token(Token = "0x170009A3")]
	protected override string info
	{
		[Token(Token = "0x60077DD")]
		[Address(RVA = "0x1165C30", Offset = "0x1164A30", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077DE")]
	[Address(RVA = "0x1165D00", Offset = "0x1164B00", Length = "0x1C1")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077DF")]
	[Address(RVA = "0x1165ED0", Offset = "0x1164CD0", Length = "0x215")]
	public Action_ObjectiveToggleInvisible()
	{
	}
}
