using Cpp2ILInjected;

[Token(Token = "0x20009E7")]
public class ActiveEnvironment
{
	[Token(Token = "0x4006482")]
	[FieldOffset(Offset = "0x10")]
	private TODStateData m_WorkA;

	[Token(Token = "0x4006483")]
	[FieldOffset(Offset = "0x18")]
	private TODStateData m_WorkB;

	[Token(Token = "0x4006484")]
	[FieldOffset(Offset = "0x20")]
	public TODStateData m_TodState;

	[Token(Token = "0x4006485")]
	[FieldOffset(Offset = "0x28")]
	public float m_GrassTintScalar;

	[Token(Token = "0x600570F")]
	[Address(RVA = "0xEC92F0", Offset = "0xEC80F0", Length = "0x169")]
	public ActiveEnvironment()
	{
	}

	[Token(Token = "0x6005710")]
	[Address(RVA = "0xEC9460", Offset = "0xEC8260", Length = "0x39")]
	public void Set(TODStateData tod)
	{
	}

	[Token(Token = "0x6005711")]
	[Address(RVA = "0xEC94A0", Offset = "0xEC82A0", Length = "0x77C")]
	public void Refresh(WeatherStatesData wsA, WeatherStatesData wsB, float weatherBlendFrac, TODBlendState todBlendState, float todBlendFrac, float todBlendBiased, bool isIndoors)
	{
	}
}
