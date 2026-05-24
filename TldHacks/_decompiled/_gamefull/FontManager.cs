using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000741")]
public class FontManager : MonoBehaviour
{
	[Header("UI Font")]
	[Token(Token = "0x4004CC3")]
	[FieldOffset(Offset = "0x20")]
	public UIFont[] m_DummyUIFonts;

	[Token(Token = "0x4004CC4")]
	[FieldOffset(Offset = "0x28")]
	public UIFont m_LatinUIFont;

	[Token(Token = "0x4004CC5")]
	[FieldOffset(Offset = "0x30")]
	public UIFont m_CyrillicUIFont;

	[Token(Token = "0x4004CC6")]
	[FieldOffset(Offset = "0x38")]
	public UIFont m_InuktitutUIFont;

	[Header("Dialogue Font")]
	[Token(Token = "0x4004CC7")]
	[FieldOffset(Offset = "0x40")]
	public UIFont m_DummyDialogueFont;

	[Token(Token = "0x4004CC8")]
	[FieldOffset(Offset = "0x48")]
	public UIFont m_LatinDialogueFont;

	[Token(Token = "0x4004CC9")]
	[FieldOffset(Offset = "0x50")]
	public UIFont m_CyrillicDialogueFont;

	[Token(Token = "0x4004CCA")]
	[FieldOffset(Offset = "0x58")]
	public UIFont m_InuktitutDialogueFont;

	[Header("TMP Fonts")]
	[Token(Token = "0x4004CCB")]
	[FieldOffset(Offset = "0x60")]
	public TMP_FontAsset m_LatinTMPFont;

	[Token(Token = "0x4004CCC")]
	[FieldOffset(Offset = "0x68")]
	public TMP_FontAsset m_CJKTMPFont;

	[Token(Token = "0x4004CCD")]
	[FieldOffset(Offset = "0x70")]
	public TMP_FontAsset m_CyrillicTMPFont;

	[Token(Token = "0x4004CCE")]
	[FieldOffset(Offset = "0x78")]
	public TMP_FontAsset m_InuktitutTMPFont;

	[Token(Token = "0x4004CCF")]
	private static CharacterSet m_CurrentCharacterSet;

	[Token(Token = "0x600419D")]
	[Address(RVA = "0xC29170", Offset = "0xC27F70", Length = "0x1BC")]
	public void UpdateDummyFonts()
	{
	}

	[Token(Token = "0x600419E")]
	[Address(RVA = "0xC29330", Offset = "0xC28130", Length = "0x1E")]
	public UIFont GetUIFontForCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[Token(Token = "0x600419F")]
	[Address(RVA = "0xC29350", Offset = "0xC28150", Length = "0x1E")]
	public UIFont GetDialogueFontForCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[Token(Token = "0x60041A0")]
	[Address(RVA = "0xC29370", Offset = "0xC28170", Length = "0x23")]
	public TMP_FontAsset GetTMPFontForCharacterSet(CharacterSet characterSet)
	{
		return null;
	}

	[Token(Token = "0x60041A1")]
	[Address(RVA = "0xC293A0", Offset = "0xC281A0", Length = "0x4A")]
	public void ResetCurrentFonts()
	{
	}

	[Token(Token = "0x60041A2")]
	[Address(RVA = "0xC293F0", Offset = "0xC281F0", Length = "0xFA")]
	public void ResetFontsForCharacterSet(CharacterSet characterSet)
	{
	}

	[Token(Token = "0x60041A3")]
	[Address(RVA = "0xC294F0", Offset = "0xC282F0", Length = "0xD8")]
	private void ResetTMPFont(TMP_FontAsset font)
	{
	}

	[Token(Token = "0x60041A4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FontManager()
	{
	}
}
