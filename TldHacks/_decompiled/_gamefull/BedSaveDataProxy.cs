using Cpp2ILInjected;

[Token(Token = "0x2000545")]
public class BedSaveDataProxy
{
	[Token(Token = "0x4003096")]
	[FieldOffset(Offset = "0x10")]
	public BedRollState m_BedRollState;

	[Token(Token = "0x4003097")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x4003098")]
	[FieldOffset(Offset = "0x20")]
	public string m_BodyGuid;

	[Token(Token = "0x6002859")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BedSaveDataProxy()
	{
	}
}
