using Cpp2ILInjected;

[Token(Token = "0x2000490")]
public class FoodItemSaveDataProxy
{
	[Token(Token = "0x40029A1")]
	[FieldOffset(Offset = "0x10")]
	public float m_CaloriesRemainingProxy;

	[Token(Token = "0x40029A2")]
	[FieldOffset(Offset = "0x14")]
	public float m_CaloriesTotal;

	[Token(Token = "0x40029A3")]
	[FieldOffset(Offset = "0x18")]
	public bool m_Opened;

	[Token(Token = "0x40029A4")]
	[FieldOffset(Offset = "0x1C")]
	public float m_HeatPercent;

	[Token(Token = "0x40029A5")]
	[FieldOffset(Offset = "0x20")]
	public float m_HoursPlayed;

	[Token(Token = "0x40029A6")]
	[FieldOffset(Offset = "0x24")]
	public bool m_HarvestedByPlayer;

	[Token(Token = "0x40029A7")]
	[FieldOffset(Offset = "0x28")]
	public int m_NumTimesHeatedUp;

	[Token(Token = "0x40029A8")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_Packaged;

	[Token(Token = "0x6002274")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FoodItemSaveDataProxy()
	{
	}
}
