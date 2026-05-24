using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.Trader;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace NodeCanvas.Tasks.Conditions;

[Name("Have Had Trader Conversation", 0)]
[Description("Checks if a specific conversation have been had with the trader")]
[Category("TLD Conditions/Trader")]
[Token(Token = "0x2001146")]
public class Condition_HaveHadTraderConversation : ConditionTask
{
	[Token(Token = "0x40087B3")]
	[FieldOffset(Offset = "0x68")]
	public AssetReferenceTraderConversation m_ConversationReference;

	[Token(Token = "0x40087B4")]
	[FieldOffset(Offset = "0x70")]
	private AsyncOperationHandle<TraderConversation> m_ConversationHandle;

	[Token(Token = "0x600745F")]
	[Address(RVA = "0x10FCF60", Offset = "0x10FBD60", Length = "0x25F")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007460")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_HaveHadTraderConversation()
	{
	}
}
