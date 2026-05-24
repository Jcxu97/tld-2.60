using Cpp2ILInjected;

namespace InteractiveObjects;

[Token(Token = "0x2001323")]
public class TrackableItemSaveData
{
	[Token(Token = "0x4008D6C")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsUncovered;

	[Token(Token = "0x6007AAB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public TrackableItemSaveData()
	{
	}
}
