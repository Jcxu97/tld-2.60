using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Unlocks")]
[Name("Is Blueprint Locked", 0)]
[Token(Token = "0x2001147")]
public class Condition_CheckBlueprintLocked : ConditionTask
{
	[Token(Token = "0x40087B5")]
	[FieldOffset(Offset = "0x68")]
	public string blueprintName;

	[Token(Token = "0x170008FF")]
	protected override string info
	{
		[Token(Token = "0x6007461")]
		[Address(RVA = "0x10FD1C0", Offset = "0x10FBFC0", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007462")]
	[Address(RVA = "0x10FD250", Offset = "0x10FC050", Length = "0xAF")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007463")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_CheckBlueprintLocked()
	{
	}
}
