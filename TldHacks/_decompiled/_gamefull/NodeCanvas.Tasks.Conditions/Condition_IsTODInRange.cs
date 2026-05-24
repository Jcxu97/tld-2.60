using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("Returns true if TOD is within specified range, uses 24h values (0 is midnight, 23 is 11 PM)")]
[Name("Is TOD In Range", 0)]
[Token(Token = "0x2001152")]
public class Condition_IsTODInRange : ConditionTask
{
	[Token(Token = "0x40087D1")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<int> hourValMin;

	[Token(Token = "0x40087D2")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<int> hourValMax;

	[Token(Token = "0x17000908")]
	protected override string info
	{
		[Token(Token = "0x6007480")]
		[Address(RVA = "0x1100830", Offset = "0x10FF630", Length = "0xF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007481")]
	[Address(RVA = "0x1100930", Offset = "0x10FF730", Length = "0x26A")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007482")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsTODInRange()
	{
	}
}
