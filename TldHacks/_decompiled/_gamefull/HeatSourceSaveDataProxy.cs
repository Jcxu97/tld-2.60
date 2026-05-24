using Cpp2ILInjected;

[Token(Token = "0x2000424")]
public class HeatSourceSaveDataProxy
{
	[Token(Token = "0x4002564")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsEnabledProxy;

	[Token(Token = "0x4002565")]
	[FieldOffset(Offset = "0x14")]
	public float m_MaxTempIncreaseProxy;

	[Token(Token = "0x4002566")]
	[FieldOffset(Offset = "0x18")]
	public float m_MaxTempIncreaseInnerRadiusProxy;

	[Token(Token = "0x4002567")]
	[FieldOffset(Offset = "0x1C")]
	public float m_MaxTempIncreaseOuterRadiusProxy;

	[Token(Token = "0x4002568")]
	[FieldOffset(Offset = "0x20")]
	public float m_TimeToReachMaxTempMinutesProxy;

	[Token(Token = "0x4002569")]
	[FieldOffset(Offset = "0x24")]
	public float m_TempIncreaseProxy;

	[Token(Token = "0x6001F42")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HeatSourceSaveDataProxy()
	{
	}
}
