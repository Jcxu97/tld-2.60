using Cpp2ILInjected;

[Token(Token = "0x20001DC")]
public class EncumberSaveDataProxy
{
	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x10")]
	public bool m_EncumberedInLog;

	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x14")]
	public float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x18")]
	public EncumberLevel m_EcumberLevelForPreviousVoiceOver;

	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public EncumberSaveDataProxy()
	{
	}
}
