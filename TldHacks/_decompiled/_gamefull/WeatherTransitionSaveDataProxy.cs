using Cpp2ILInjected;

[Token(Token = "0x200032C")]
public class WeatherTransitionSaveDataProxy
{
	[Token(Token = "0x4001C59")]
	[FieldOffset(Offset = "0x10")]
	public bool m_UseUnmanagedWeatherStage;

	[Token(Token = "0x4001C5A")]
	[FieldOffset(Offset = "0x14")]
	public WeatherStage m_UnmanagedWeatherStage;

	[Token(Token = "0x4001C5B")]
	[FieldOffset(Offset = "0x18")]
	public string m_CurrentWeatherSetName;

	[Token(Token = "0x4001C5C")]
	[FieldOffset(Offset = "0x20")]
	public float m_CurrentWeatherSetProgressFrac;

	[Token(Token = "0x4001C5D")]
	[FieldOffset(Offset = "0x28")]
	public string m_CurrentWeatherSetSerialized;

	[Token(Token = "0x4001C5E")]
	[FieldOffset(Offset = "0x30")]
	public int m_CurrentWeatherSetType;

	[Token(Token = "0x4001C5F")]
	[FieldOffset(Offset = "0x34")]
	public int m_PreviousWeatherSetType;

	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WeatherTransitionSaveDataProxy()
	{
	}
}
