using Cpp2ILInjected;

[Token(Token = "0x20004D2")]
public class SmashableItemSaveDataProxy
{
	[Token(Token = "0x4002C2B")]
	[FieldOffset(Offset = "0x10")]
	public bool m_HasBeenSmashed;

	[Token(Token = "0x60024C4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SmashableItemSaveDataProxy()
	{
	}
}
