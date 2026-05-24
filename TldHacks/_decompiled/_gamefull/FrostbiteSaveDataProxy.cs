using Cpp2ILInjected;

[Token(Token = "0x2000518")]
public class FrostbiteSaveDataProxy
{
	[Token(Token = "0x4002EBA")]
	[FieldOffset(Offset = "0x10")]
	public int[] m_LocationsWithActiveFrostbite;

	[Token(Token = "0x4002EBB")]
	[FieldOffset(Offset = "0x18")]
	public int[] m_LocationsWithFrostbiteRisk;

	[Token(Token = "0x4002EBC")]
	[FieldOffset(Offset = "0x20")]
	public float[] m_LocationsCurrentFrostbiteDamage;

	[Token(Token = "0x60026B8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FrostbiteSaveDataProxy()
	{
	}
}
