using Cpp2ILInjected;

[Token(Token = "0x20001D6")]
public class ConditionSaveDataProxy
{
	[Token(Token = "0x4001004")]
	[FieldOffset(Offset = "0x10")]
	public float m_CurrentHPProxy;

	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0x14")]
	public float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x4001006")]
	[FieldOffset(Offset = "0x18")]
	public bool m_NeverDieProxy;

	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x19")]
	public bool m_Invulnerable;

	[Token(Token = "0x4001008")]
	[FieldOffset(Offset = "0x1A")]
	public bool m_HideDamageEvents;

	[Token(Token = "0x4001009")]
	[FieldOffset(Offset = "0x1B")]
	public bool m_FoceUncrouched;

	[Token(Token = "0x400100A")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_CanPlayNearDeathMusic;

	[Token(Token = "0x400100B")]
	[FieldOffset(Offset = "0x20")]
	public ConditionLevel m_ConditionLevelForPreviousVoiceOver;

	[Token(Token = "0x400100C")]
	[FieldOffset(Offset = "0x24")]
	public bool m_SuppressVoiceOver;

	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ConditionSaveDataProxy()
	{
	}
}
