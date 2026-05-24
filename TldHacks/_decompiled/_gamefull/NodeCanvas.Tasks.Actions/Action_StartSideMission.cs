using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Start Side Mission", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001266")]
public class Action_StartSideMission : ActionTask<GraphOwner>
{
	[Token(Token = "0x4008AD8")]
	[FieldOffset(Offset = "0x68")]
	public string missionId;

	[Token(Token = "0x4008AD9")]
	[FieldOffset(Offset = "0x70")]
	public int ifCompletionCountLessThan;

	[Token(Token = "0x4008ADA")]
	[FieldOffset(Offset = "0x74")]
	public bool restartIfAlreadyActive;

	[Token(Token = "0x60077F7")]
	[Address(RVA = "0x1167880", Offset = "0x1166680", Length = "0x23A")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077F8")]
	[Address(RVA = "0x1167AC0", Offset = "0x11668C0", Length = "0xA5")]
	public Action_StartSideMission()
	{
	}
}
