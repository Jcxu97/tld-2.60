using Cpp2ILInjected;

[Token(Token = "0x2000341")]
public class Feat_EfficientMachineSaveData
{
	[Token(Token = "0x4001D0D")]
	[FieldOffset(Offset = "0x10")]
	public float m_ElapsedHours;

	[Token(Token = "0x4001D0E")]
	[FieldOffset(Offset = "0x14")]
	public float m_HoursAccumulator;

	[Token(Token = "0x6001AAD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Feat_EfficientMachineSaveData()
	{
	}
}
