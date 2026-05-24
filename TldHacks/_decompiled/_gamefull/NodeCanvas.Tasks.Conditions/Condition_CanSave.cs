using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Name("Can Save", 0)]
[Token(Token = "0x2001156")]
public class Condition_CanSave : ConditionTask
{
	[Token(Token = "0x40087DC")]
	[FieldOffset(Offset = "0x68")]
	public SaveState state;

	[Token(Token = "0x1700090B")]
	protected override string info
	{
		[Token(Token = "0x6007489")]
		[Address(RVA = "0x1100E60", Offset = "0x10FFC60", Length = "0x93")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600748A")]
	[Address(RVA = "0x1100F00", Offset = "0x10FFD00", Length = "0x50")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600748B")]
	[Address(RVA = "0x1100F50", Offset = "0x10FFD50", Length = "0xF")]
	public Condition_CanSave()
	{
	}
}
