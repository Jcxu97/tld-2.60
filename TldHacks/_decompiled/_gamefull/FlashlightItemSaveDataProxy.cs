using Cpp2ILInjected;

[Token(Token = "0x200048C")]
public class FlashlightItemSaveDataProxy
{
	[Token(Token = "0x4002979")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsOn;

	[Token(Token = "0x400297A")]
	[FieldOffset(Offset = "0x11")]
	public bool m_IsHigh;

	[Token(Token = "0x400297B")]
	[FieldOffset(Offset = "0x14")]
	public float m_CurrentBatteryCharge;

	[Token(Token = "0x6002258")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FlashlightItemSaveDataProxy()
	{
	}
}
