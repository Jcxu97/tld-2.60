using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("returns true if timer is active")]
[Name("Is Timer Active", 0)]
[Token(Token = "0x2001151")]
public class Condition_IsTimeActive : ConditionTask
{
	[Token(Token = "0x40087D0")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> timerID;

	[Token(Token = "0x17000907")]
	protected override string info
	{
		[Token(Token = "0x600747D")]
		[Address(RVA = "0x1100660", Offset = "0x10FF460", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600747E")]
	[Address(RVA = "0x11006D0", Offset = "0x10FF4D0", Length = "0x159")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600747F")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsTimeActive()
	{
	}
}
