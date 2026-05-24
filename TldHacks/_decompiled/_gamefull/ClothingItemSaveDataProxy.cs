using Cpp2ILInjected;

[Token(Token = "0x2000471")]
public class ClothingItemSaveDataProxy
{
	[Token(Token = "0x4002806")]
	[FieldOffset(Offset = "0x10")]
	public bool m_WearingProxy;

	[Token(Token = "0x4002807")]
	[FieldOffset(Offset = "0x14")]
	public float m_PercentWet;

	[Token(Token = "0x4002808")]
	[FieldOffset(Offset = "0x18")]
	public float m_PercentFrozen;

	[Token(Token = "0x4002809")]
	[FieldOffset(Offset = "0x1C")]
	public float m_HoursPlayed;

	[Token(Token = "0x400280A")]
	[FieldOffset(Offset = "0x20")]
	public float m_HoursRemainingOnCloseFire;

	[Token(Token = "0x400280B")]
	[FieldOffset(Offset = "0x24")]
	public bool m_DroppedIndoors;

	[Token(Token = "0x400280C")]
	[FieldOffset(Offset = "0x25")]
	public bool m_HasEquippedData;

	[Token(Token = "0x400280D")]
	[FieldOffset(Offset = "0x28")]
	public int m_EquippedLayerIndex;

	[Token(Token = "0x600214C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ClothingItemSaveDataProxy()
	{
	}
}
