using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Phone")]
[Description("Check if Player has completed a Phone conversation from a sequence.")]
[Name("Is Phone Conversation Complete", 0)]
[Token(Token = "0x200115E")]
public class TLD_IsConversationComplete : ConditionTask
{
	[Token(Token = "0x40087E9")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<DTContainer> dialogueTreeContainer;

	[Token(Token = "0x40087EA")]
	[FieldOffset(Offset = "0x70")]
	public int conversationIndex;

	[Token(Token = "0x17000910")]
	protected override string info
	{
		[Token(Token = "0x60074A1")]
		[Address(RVA = "0x11017E0", Offset = "0x11005E0", Length = "0x1BA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074A2")]
	[Address(RVA = "0x11019A0", Offset = "0x11007A0", Length = "0x1AB")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074A3")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TLD_IsConversationComplete()
	{
	}
}
