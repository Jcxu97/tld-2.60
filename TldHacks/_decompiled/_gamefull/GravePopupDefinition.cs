using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "GravePopupDefinition", menuName = "Interface/GravePopupDefinition", order = 10003)]
[Token(Token = "0x20005DF")]
public class GravePopupDefinition : PopupDefinition
{
	[Token(Token = "0x400364D")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_GraveName;

	[Token(Token = "0x400364E")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_GraveQuote;

	[Token(Token = "0x400364F")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_GraveNumber;

	[Token(Token = "0x6002D88")]
	[Address(RVA = "0x94F150", Offset = "0x94DF50", Length = "0x252")]
	protected override void ConfigurePopup(GameObject go)
	{
	}

	[Token(Token = "0x6002D89")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public GravePopupDefinition()
	{
	}
}
