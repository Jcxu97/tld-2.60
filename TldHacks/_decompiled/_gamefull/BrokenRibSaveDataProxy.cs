using Cpp2ILInjected;

[Token(Token = "0x20004FC")]
public class BrokenRibSaveDataProxy
{
	[Token(Token = "0x4002DAA")]
	[FieldOffset(Offset = "0x10")]
	public string[] m_CausesLocIDs;

	[Token(Token = "0x4002DAB")]
	[FieldOffset(Offset = "0x18")]
	public int[] m_Locations;

	[Token(Token = "0x4002DAC")]
	[FieldOffset(Offset = "0x20")]
	public int[] m_PainKillersTaken;

	[Token(Token = "0x4002DAD")]
	[FieldOffset(Offset = "0x28")]
	public int[] m_BandagesApplied;

	[Token(Token = "0x4002DAE")]
	[FieldOffset(Offset = "0x30")]
	public float[] m_ElapsedRestList;

	[Token(Token = "0x4002DAF")]
	[FieldOffset(Offset = "0x38")]
	public float[] m_NumHoursRestForCureList;

	[Token(Token = "0x60025BE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BrokenRibSaveDataProxy()
	{
	}
}
