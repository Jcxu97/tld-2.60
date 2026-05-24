using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Name("Check Challenge is Active", 0)]
[Token(Token = "0x200113E")]
public class Condition_CheckIfChallengeActive : ConditionTask
{
	[Token(Token = "0x170008FA")]
	protected override string info
	{
		[Token(Token = "0x6007449")]
		[Address(RVA = "0x10FC0B0", Offset = "0x10FAEB0", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600744A")]
	[Address(RVA = "0x10FC0F0", Offset = "0x10FAEF0", Length = "0x97")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600744B")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_CheckIfChallengeActive()
	{
	}
}
