using Cpp2ILInjected;

[Token(Token = "0x20007C0")]
public class QualitySettingsManagerSaveData
{
	[Token(Token = "0x400536D")]
	[FieldOffset(Offset = "0x10")]
	public Quality m_CurrentQuality;

	[Token(Token = "0x400536E")]
	[FieldOffset(Offset = "0x18")]
	public QualityLevelSettings m_QualityCustom;

	[Token(Token = "0x600493B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public QualitySettingsManagerSaveData()
	{
	}
}
