using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Phone")]
[Description("Check if Player is in Phone conversation.")]
[Name("In Conversation On Phone ", 0)]
[Token(Token = "0x2001160")]
public class TLD_InPhoneConversation : ConditionTask
{
	[Token(Token = "0x40087EC")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> phoneMissionId;

	[Token(Token = "0x40087ED")]
	[FieldOffset(Offset = "0x70")]
	private Phone m_Phone;

	[Token(Token = "0x40087EE")]
	[FieldOffset(Offset = "0x78")]
	private bool m_HasRetrievedPhone;

	[Token(Token = "0x60074A7")]
	[Address(RVA = "0x1101E70", Offset = "0x1100C70", Length = "0x22F")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074A8")]
	[Address(RVA = "0x11020A0", Offset = "0x1100EA0", Length = "0x70")]
	private void RetrievePhone()
	{
	}

	[Token(Token = "0x60074A9")]
	[Address(RVA = "0x1102110", Offset = "0x1100F10", Length = "0x335")]
	private Phone GetPhone()
	{
		return null;
	}

	[Token(Token = "0x60074AA")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TLD_InPhoneConversation()
	{
	}
}
