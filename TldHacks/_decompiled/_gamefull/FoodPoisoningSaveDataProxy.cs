using Cpp2ILInjected;

[Token(Token = "0x2000516")]
public class FoodPoisoningSaveDataProxy
{
	[Token(Token = "0x4002EA0")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002EA1")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002EA2")]
	[FieldOffset(Offset = "0x18")]
	public float m_DurationHours;

	[Token(Token = "0x4002EA3")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_AntibioticsTaken;

	[Token(Token = "0x4002EA4")]
	[FieldOffset(Offset = "0x20")]
	public float m_ElapsedRest;

	[Token(Token = "0x4002EA5")]
	[FieldOffset(Offset = "0x28")]
	public string m_CauseLocID;

	[Token(Token = "0x60026A6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FoodPoisoningSaveDataProxy()
	{
	}
}
