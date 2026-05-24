using Cpp2ILInjected;

[Token(Token = "0x200078D")]
public class NotificationFlagInfo
{
	[Token(Token = "0x40050D9")]
	[FieldOffset(Offset = "0x10")]
	public string m_Key;

	[Token(Token = "0x40050DA")]
	[FieldOffset(Offset = "0x18")]
	public GearItem m_GearItem;

	[Token(Token = "0x40050DB")]
	[FieldOffset(Offset = "0x20")]
	public PanelType m_PanelType;

	[Token(Token = "0x40050DC")]
	[FieldOffset(Offset = "0x24")]
	public MainCategory m_MainCategory;

	[Token(Token = "0x40050DD")]
	[FieldOffset(Offset = "0x28")]
	public SubCategory m_SubCategory;

	[Token(Token = "0x6004695")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public NotificationFlagInfo()
	{
	}
}
