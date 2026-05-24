using Cpp2ILInjected;

[Token(Token = "0x2000520")]
public class InfectionRiskSaveDataProxy
{
	[Token(Token = "0x4002F17")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002F18")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002F19")]
	[FieldOffset(Offset = "0x18")]
	public float m_DurationHours;

	[Token(Token = "0x4002F1A")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_AntisepticTaken;

	[Token(Token = "0x4002F1B")]
	[FieldOffset(Offset = "0x20")]
	public float m_CommentTime;

	[Token(Token = "0x4002F1C")]
	[FieldOffset(Offset = "0x24")]
	public float m_CurrentInfectionChance;

	[Token(Token = "0x4002F1D")]
	[FieldOffset(Offset = "0x28")]
	public string[] m_CausesLocIDs;

	[Token(Token = "0x4002F1E")]
	[FieldOffset(Offset = "0x30")]
	public int[] m_Locations;

	[Token(Token = "0x4002F1F")]
	[FieldOffset(Offset = "0x38")]
	public float[] m_ElapsedHoursList;

	[Token(Token = "0x4002F20")]
	[FieldOffset(Offset = "0x40")]
	public float[] m_DurationHoursList;

	[Token(Token = "0x4002F21")]
	[FieldOffset(Offset = "0x48")]
	public bool[] m_AntisepticTakenList;

	[Token(Token = "0x4002F22")]
	[FieldOffset(Offset = "0x50")]
	public float[] m_CurrentInfectionChanceList;

	[Token(Token = "0x4002F23")]
	[FieldOffset(Offset = "0x58")]
	public int[] m_ConstantAfflictionIndices;

	[Token(Token = "0x6002709")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InfectionRiskSaveDataProxy()
	{
	}
}
