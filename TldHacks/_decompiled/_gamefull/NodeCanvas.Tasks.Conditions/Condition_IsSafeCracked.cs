using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("returns true if safe has been cracked")]
[Name("Is Safe Cracked", 0)]
[Token(Token = "0x200114F")]
public class Condition_IsSafeCracked : ConditionTask
{
	[Token(Token = "0x40087CB")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> safeId;

	[Token(Token = "0x17000905")]
	protected override string info
	{
		[Token(Token = "0x6007477")]
		[Address(RVA = "0x10FFC50", Offset = "0x10FEA50", Length = "0x6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007478")]
	[Address(RVA = "0x10FFCC0", Offset = "0x10FEAC0", Length = "0x294")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007479")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsSafeCracked()
	{
	}
}
