using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Token(Token = "0x200116A")]
public class CheckEnum : ConditionTask
{
	[BlackboardOnly]
	[Token(Token = "0x40087FC")]
	[FieldOffset(Offset = "0x68")]
	public BBObjectParameter valueA;

	[Token(Token = "0x40087FD")]
	[FieldOffset(Offset = "0x70")]
	public BBObjectParameter valueB;

	[Token(Token = "0x17000919")]
	protected override string info
	{
		[Token(Token = "0x60074C9")]
		[Address(RVA = "0x11038C0", Offset = "0x11026C0", Length = "0x9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074CA")]
	[Address(RVA = "0x1103960", Offset = "0x1102760", Length = "0xAE")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074CB")]
	[Address(RVA = "0x1103A10", Offset = "0x1102810", Length = "0x1B5")]
	public CheckEnum()
	{
	}
}
