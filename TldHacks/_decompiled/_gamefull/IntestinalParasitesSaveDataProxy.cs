using Cpp2ILInjected;

[Token(Token = "0x2000522")]
public class IntestinalParasitesSaveDataProxy
{
	[Token(Token = "0x4002F3E")]
	[FieldOffset(Offset = "0x10")]
	public bool m_HasParasites;

	[Token(Token = "0x4002F3F")]
	[FieldOffset(Offset = "0x11")]
	public bool m_HasParasiteRisk;

	[Token(Token = "0x4002F40")]
	[FieldOffset(Offset = "0x14")]
	public float m_CurrentInfectionChance;

	[Token(Token = "0x4002F41")]
	[FieldOffset(Offset = "0x18")]
	public float m_ParasitesElapsedHours;

	[Token(Token = "0x4002F42")]
	[FieldOffset(Offset = "0x1C")]
	public float m_RiskElapsedHours;

	[Token(Token = "0x4002F43")]
	[FieldOffset(Offset = "0x20")]
	public float m_RiskDurationHours;

	[Token(Token = "0x4002F44")]
	[FieldOffset(Offset = "0x24")]
	public int m_NumDosesTaken;

	[Token(Token = "0x4002F45")]
	[FieldOffset(Offset = "0x28")]
	public bool m_HasTakenDoseToday;

	[Token(Token = "0x4002F46")]
	[FieldOffset(Offset = "0x2C")]
	public int m_DayToAllowNextDose;

	[Token(Token = "0x4002F47")]
	[FieldOffset(Offset = "0x30")]
	public int m_NumPiecesEatenThisRiskCycle;

	[Token(Token = "0x6002724")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public IntestinalParasitesSaveDataProxy()
	{
	}
}
