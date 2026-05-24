using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Name("Should Skip Next Conversation", 0)]
[Token(Token = "0x2001157")]
public class Condition_ShouldSkipConversations : ConditionTask
{
	[Token(Token = "0x1700090C")]
	protected override string info
	{
		[Token(Token = "0x600748C")]
		[Address(RVA = "0x1100F60", Offset = "0x10FFD60", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600748D")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600748E")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_ShouldSkipConversations()
	{
	}
}
