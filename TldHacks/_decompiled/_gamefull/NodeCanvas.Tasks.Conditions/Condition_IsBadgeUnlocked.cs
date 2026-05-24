using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.SaveState;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Name("Is Badge Unlocked", 0)]
[Token(Token = "0x2001158")]
public class Condition_IsBadgeUnlocked : ConditionTask
{
	[Token(Token = "0x40087DD")]
	[FieldOffset(Offset = "0x68")]
	public BadgeInfoType m_Badge;

	[Token(Token = "0x1700090D")]
	protected override string info
	{
		[Token(Token = "0x600748F")]
		[Address(RVA = "0x1100FA0", Offset = "0x10FFDA0", Length = "0xA3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007490")]
	[Address(RVA = "0x1101050", Offset = "0x10FFE50", Length = "0xBB")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007491")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsBadgeUnlocked()
	{
	}
}
