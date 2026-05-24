using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set State of Switch Box", 0)]
[Description("Forces Switch Box object to a specific state")]
[Category("TLD Actions/Objects")]
[Token(Token = "0x200122C")]
public class Action_SetSwitchBoxState : ActionTask
{
	[Token(Token = "0x4008A1F")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x4008A20")]
	[FieldOffset(Offset = "0x70")]
	public SwitchToggleState switchState;

	[Token(Token = "0x4008A21")]
	[FieldOffset(Offset = "0x74")]
	public bool isLocked;

	[Token(Token = "0x600774C")]
	[Address(RVA = "0x115AB10", Offset = "0x1159910", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600774D")]
	[Address(RVA = "0x115AB40", Offset = "0x1159940", Length = "0x1EC")]
	private void DoWork()
	{
	}

	[Token(Token = "0x600774E")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetSwitchBoxState()
	{
	}
}
