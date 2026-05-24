using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using TLD.Stats;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Name("Check Stat", 0)]
[Token(Token = "0x2001155")]
public class Condition_CheckStat : ConditionTask
{
	[Token(Token = "0x40087D8")]
	[FieldOffset(Offset = "0x68")]
	public StatID Stat;

	[Token(Token = "0x40087D9")]
	[FieldOffset(Offset = "0x6C")]
	public CompareMethod checkType;

	[Token(Token = "0x40087DA")]
	[FieldOffset(Offset = "0x70")]
	public float Value;

	[SliderField(0f, 0.1f)]
	[Token(Token = "0x40087DB")]
	[FieldOffset(Offset = "0x74")]
	public float differenceThreshold;

	[Token(Token = "0x1700090A")]
	protected override string info
	{
		[Token(Token = "0x6007486")]
		[Address(RVA = "0x1100CD0", Offset = "0x10FFAD0", Length = "0x96")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007487")]
	[Address(RVA = "0x1100D70", Offset = "0x10FFB70", Length = "0xD3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007488")]
	[Address(RVA = "0x1100E50", Offset = "0x10FFC50", Length = "0xF")]
	public Condition_CheckStat()
	{
	}
}
