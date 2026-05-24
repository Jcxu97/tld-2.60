using Cpp2ILInjected;

[Token(Token = "0x2000331")]
public class WindSaveDataProxy
{
	[Token(Token = "0x4001C79")]
	[FieldOffset(Offset = "0x10")]
	public int m_Version;

	[Token(Token = "0x4001C7A")]
	[FieldOffset(Offset = "0x14")]
	public WindDirection m_windDirectionProxy;

	[Token(Token = "0x4001C7B")]
	[FieldOffset(Offset = "0x18")]
	public WindStrength m_windStrengthProxy;

	[Token(Token = "0x4001C7C")]
	[FieldOffset(Offset = "0x1C")]
	public float m_windMPHProxy;

	[Token(Token = "0x4001C7D")]
	[FieldOffset(Offset = "0x20")]
	public bool m_FirstPhaseSetProxy;

	[Token(Token = "0x4001C7E")]
	[FieldOffset(Offset = "0x24")]
	public float m_PhaseElapsedTODSecondsProxy;

	[Token(Token = "0x4001C7F")]
	[FieldOffset(Offset = "0x28")]
	public float m_PhaseDurationHoursProxy;

	[Token(Token = "0x4001C80")]
	[FieldOffset(Offset = "0x2C")]
	public float m_TransitionTimeTODSecondsProxy;

	[Token(Token = "0x4001C81")]
	[FieldOffset(Offset = "0x30")]
	public string m_ActiveSettingsSerialized;

	[Token(Token = "0x4001C82")]
	[FieldOffset(Offset = "0x38")]
	public string m_SourceSettingsSerialized;

	[Token(Token = "0x4001C83")]
	[FieldOffset(Offset = "0x40")]
	public string m_TargetSettingsSerialized;

	[Token(Token = "0x6001A24")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WindSaveDataProxy()
	{
	}
}
