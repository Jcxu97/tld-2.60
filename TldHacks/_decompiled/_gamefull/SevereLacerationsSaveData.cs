using Cpp2ILInjected;

[Token(Token = "0x200052C")]
public class SevereLacerationsSaveData
{
	[Token(Token = "0x4002F99")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsActive;

	[Token(Token = "0x4002F9A")]
	[FieldOffset(Offset = "0x14")]
	public float m_TimeWhenActivated;

	[Token(Token = "0x4002F9B")]
	[FieldOffset(Offset = "0x18")]
	public float m_TimeWhenLastWoundEscalation;

	[Token(Token = "0x4002F9C")]
	[FieldOffset(Offset = "0x20")]
	public string m_CauseLocID;

	[Token(Token = "0x600277D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SevereLacerationsSaveData()
	{
	}
}
