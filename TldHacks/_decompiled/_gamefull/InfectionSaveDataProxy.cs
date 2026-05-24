using Cpp2ILInjected;

[Token(Token = "0x200051E")]
public class InfectionSaveDataProxy
{
	[Token(Token = "0x4002EF9")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002EFA")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002EFB")]
	[FieldOffset(Offset = "0x18")]
	public float m_DurationHours;

	[Token(Token = "0x4002EFC")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_AntibioticsTaken;

	[Token(Token = "0x4002EFD")]
	[FieldOffset(Offset = "0x20")]
	public float m_ElapsedRest;

	[Token(Token = "0x4002EFE")]
	[FieldOffset(Offset = "0x28")]
	public string[] m_CausesLocIDs;

	[Token(Token = "0x4002EFF")]
	[FieldOffset(Offset = "0x30")]
	public int[] m_Locations;

	[Token(Token = "0x4002F00")]
	[FieldOffset(Offset = "0x38")]
	public float[] m_ElapsedHoursList;

	[Token(Token = "0x4002F01")]
	[FieldOffset(Offset = "0x40")]
	public float[] m_DurationHoursList;

	[Token(Token = "0x4002F02")]
	[FieldOffset(Offset = "0x48")]
	public bool[] m_AntibioticsTakenList;

	[Token(Token = "0x4002F03")]
	[FieldOffset(Offset = "0x50")]
	public float[] m_ElapsedRestList;

	[Token(Token = "0x60026F0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InfectionSaveDataProxy()
	{
	}
}
