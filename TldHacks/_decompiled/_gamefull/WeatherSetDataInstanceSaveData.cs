using Cpp2ILInjected;

[Token(Token = "0x2000326")]
public class WeatherSetDataInstanceSaveData
{
	[Token(Token = "0x4001C27")]
	[FieldOffset(Offset = "0x10")]
	public int m_CurrentIndex;

	[Token(Token = "0x4001C28")]
	[FieldOffset(Offset = "0x14")]
	public float m_CurrentStageElapsedTime;

	[Token(Token = "0x4001C29")]
	[FieldOffset(Offset = "0x18")]
	public float[] m_StageDurations;

	[Token(Token = "0x4001C2A")]
	[FieldOffset(Offset = "0x20")]
	public float[] m_StageTransitionTimes;

	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WeatherSetDataInstanceSaveData()
	{
	}
}
