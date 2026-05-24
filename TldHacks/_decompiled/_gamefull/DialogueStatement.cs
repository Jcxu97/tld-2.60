using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;

[Token(Token = "0x200085A")]
public class DialogueStatement : Statement
{
	[Token(Token = "0x17000359")]
	[field: Token(Token = "0x40056CD")]
	[field: FieldOffset(Offset = "0x30")]
	public new VoiceOverAnimationState anim
	{
		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x677F80", Offset = "0x676D80", Length = "0x4")]
		get;
		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0xD7E9C0", Offset = "0xD7D7C0", Length = "0x4")]
		set;
	}

	[Token(Token = "0x6004CE9")]
	[Address(RVA = "0xD7E9D0", Offset = "0xD7D7D0", Length = "0xCA")]
	public DialogueStatement()
	{
	}
}
