using Cpp2ILInjected;

[Token(Token = "0x200065B")]
public class Panel_GravePopup : PopupBase
{
	[Token(Token = "0x4003E0B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_GraveName;

	[Token(Token = "0x4003E0C")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_GraveQuote;

	[Token(Token = "0x4003E0D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_GraveNumber;

	[Token(Token = "0x600341B")]
	[Address(RVA = "0xA563D0", Offset = "0xA551D0", Length = "0x79")]
	public Panel_GravePopup()
	{
	}
}
