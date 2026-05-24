using Cpp2ILInjected;
using NodeCanvas.Framework;
using TLD.GameplayTags;

namespace NodeCanvas.Tasks.Conditions;

[Token(Token = "0x2001140")]
public class Condition_CheckGameModeForActiveTag : ConditionTask
{
	[Token(Token = "0x40087AE")]
	[FieldOffset(Offset = "0x68")]
	public GameplayTag m_GameplayTag;

	[Token(Token = "0x170008FC")]
	protected override string info
	{
		[Token(Token = "0x600744F")]
		[Address(RVA = "0x10FC2B0", Offset = "0x10FB0B0", Length = "0xA5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007450")]
	[Address(RVA = "0x10FC360", Offset = "0x10FB160", Length = "0x141")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007451")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_CheckGameModeForActiveTag()
	{
	}
}
