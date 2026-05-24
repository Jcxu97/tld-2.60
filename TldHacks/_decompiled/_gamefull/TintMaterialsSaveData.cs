using Cpp2ILInjected;

[Token(Token = "0x2000A3B")]
public class TintMaterialsSaveData
{
	[Token(Token = "0x400669F")]
	[FieldOffset(Offset = "0x10")]
	public int m_TintIndex;

	[Token(Token = "0x40066A0")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x600592D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public TintMaterialsSaveData()
	{
	}
}
