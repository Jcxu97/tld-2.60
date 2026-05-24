using Cpp2ILInjected;

[Token(Token = "0x200052F")]
public class SprainedAnkleSaveDataProxy
{
	[Token(Token = "0x4002FAE")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002FAF")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002FB0")]
	[FieldOffset(Offset = "0x18")]
	public float m_DurationHours;

	[Token(Token = "0x4002FB1")]
	[FieldOffset(Offset = "0x1C")]
	public float m_ElapsedRest;

	[Token(Token = "0x4002FB2")]
	[FieldOffset(Offset = "0x20")]
	public float m_SecondsSinceLastPainAudio;

	[Token(Token = "0x4002FB3")]
	[FieldOffset(Offset = "0x24")]
	public float m_SecondsUntilNextPainAudio;

	[Token(Token = "0x4002FB4")]
	[FieldOffset(Offset = "0x28")]
	public string[] m_CausesLocIDs;

	[Token(Token = "0x4002FB5")]
	[FieldOffset(Offset = "0x30")]
	public int[] m_Locations;

	[Token(Token = "0x4002FB6")]
	[FieldOffset(Offset = "0x38")]
	public float[] m_ElapsedHoursList;

	[Token(Token = "0x4002FB7")]
	[FieldOffset(Offset = "0x40")]
	public float[] m_DurationHoursList;

	[Token(Token = "0x4002FB8")]
	[FieldOffset(Offset = "0x48")]
	public float[] m_ElapsedRestList;

	[Token(Token = "0x6002798")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SprainedAnkleSaveDataProxy()
	{
	}
}
