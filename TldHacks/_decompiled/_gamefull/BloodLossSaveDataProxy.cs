using Cpp2ILInjected;

[Token(Token = "0x20004F9")]
public class BloodLossSaveDataProxy
{
	[Token(Token = "0x4002D86")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002D87")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002D88")]
	[FieldOffset(Offset = "0x18")]
	public float m_DurationHours;

	[Token(Token = "0x4002D89")]
	[FieldOffset(Offset = "0x20")]
	public string[] m_CausesLocIDs;

	[Token(Token = "0x4002D8A")]
	[FieldOffset(Offset = "0x28")]
	public int[] m_Locations;

	[Token(Token = "0x4002D8B")]
	[FieldOffset(Offset = "0x30")]
	public float[] m_ElapsedHoursList;

	[Token(Token = "0x4002D8C")]
	[FieldOffset(Offset = "0x38")]
	public float[] m_DurationHoursList;

	[Token(Token = "0x600259D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BloodLossSaveDataProxy()
	{
	}
}
