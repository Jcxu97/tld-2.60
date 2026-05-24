using Cpp2ILInjected;

[Token(Token = "0x2000532")]
public class SprainedWristSaveDataProxy
{
	[Token(Token = "0x4002FD9")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002FDA")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002FDB")]
	[FieldOffset(Offset = "0x18")]
	public float m_DurationHours;

	[Token(Token = "0x4002FDC")]
	[FieldOffset(Offset = "0x1C")]
	public float m_ElapsedRest;

	[Token(Token = "0x4002FDD")]
	[FieldOffset(Offset = "0x20")]
	public string[] m_CausesLocIDs;

	[Token(Token = "0x4002FDE")]
	[FieldOffset(Offset = "0x28")]
	public int[] m_Locations;

	[Token(Token = "0x4002FDF")]
	[FieldOffset(Offset = "0x30")]
	public float[] m_ElapsedHoursList;

	[Token(Token = "0x4002FE0")]
	[FieldOffset(Offset = "0x38")]
	public float[] m_DurationHoursList;

	[Token(Token = "0x4002FE1")]
	[FieldOffset(Offset = "0x40")]
	public float[] m_ElapsedRestList;

	[Token(Token = "0x4002FE2")]
	[FieldOffset(Offset = "0x48")]
	public bool m_IsNoSprainWristForced;

	[Token(Token = "0x60027B5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SprainedWristSaveDataProxy()
	{
	}
}
