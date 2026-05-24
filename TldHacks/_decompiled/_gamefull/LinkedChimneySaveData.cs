using Cpp2ILInjected;

[Token(Token = "0x200073B")]
public class LinkedChimneySaveData
{
	[Token(Token = "0x4004C9F")]
	[FieldOffset(Offset = "0x10")]
	public float m_LifetimeMinutes;

	[Token(Token = "0x4004CA0")]
	[FieldOffset(Offset = "0x14")]
	public bool m_UseClosestChimney;

	[Token(Token = "0x4004CA1")]
	[FieldOffset(Offset = "0x18")]
	public string m_ChimneyGuid;

	[Token(Token = "0x600416C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LinkedChimneySaveData()
	{
	}
}
