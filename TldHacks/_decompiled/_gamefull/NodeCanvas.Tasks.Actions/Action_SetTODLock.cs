using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set TOD Lock", 0)]
[Description("If set to true, prevents time from passing.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001215")]
public class Action_SetTODLock : ActionTask
{
	[Token(Token = "0x40089D6")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> setTODLock;

	[Token(Token = "0x1700097C")]
	protected override string info
	{
		[Token(Token = "0x600770C")]
		[Address(RVA = "0x1154E50", Offset = "0x1153C50", Length = "0xC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600770B")]
	[Address(RVA = "0x1154DB0", Offset = "0x1153BB0", Length = "0x98")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600770D")]
	[Address(RVA = "0x1154F20", Offset = "0x1153D20", Length = "0x93")]
	public Action_SetTODLock()
	{
	}
}
