using Cpp2ILInjected;

[Token(Token = "0x200031F")]
public class WeatherSaveDataProxy
{
	[Token(Token = "0x4001B9D")]
	[FieldOffset(Offset = "0x10")]
	public float m_PrevBodyTempProxy;

	[Token(Token = "0x4001B9E")]
	[FieldOffset(Offset = "0x14")]
	public float m_TempHighProxy;

	[Token(Token = "0x4001B9F")]
	[FieldOffset(Offset = "0x18")]
	public float m_TempLowProxy;

	[Token(Token = "0x4001BA0")]
	[FieldOffset(Offset = "0x1C")]
	public WeatherStage m_WeatherStageProxy;

	[Token(Token = "0x4001BA1")]
	[FieldOffset(Offset = "0x20")]
	public float m_UniStormElapsedHoursProxy;

	[Token(Token = "0x4001BA2")]
	[FieldOffset(Offset = "0x24")]
	public float m_UniStormNextWeatherChangeElapsedHoursProxy;

	[Token(Token = "0x4001BA3")]
	[FieldOffset(Offset = "0x28")]
	public bool m_UseMinAirTemperature;

	[Token(Token = "0x4001BA4")]
	[FieldOffset(Offset = "0x2C")]
	public int m_MinAirTemperature;

	[Token(Token = "0x600196B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WeatherSaveDataProxy()
	{
	}
}
