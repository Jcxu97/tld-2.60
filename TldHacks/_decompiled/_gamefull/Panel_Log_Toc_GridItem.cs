using Cpp2ILInjected;
using TLD.UI.Generics;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x200068A")]
public class Panel_Log_Toc_GridItem : ScrollBehaviourItem
{
	[SerializeField]
	[Token(Token = "0x40043FB")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_Log> m_Log;

	[Token(Token = "0x40043FC")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_LabelTitle;

	[Token(Token = "0x40043FD")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_SpriteSelection;

	[Token(Token = "0x40043FE")]
	[FieldOffset(Offset = "0x50")]
	public float m_TextAlphaSelected;

	[Token(Token = "0x40043FF")]
	[FieldOffset(Offset = "0x54")]
	public float m_TextAlphaHover;

	[Token(Token = "0x4004400")]
	[FieldOffset(Offset = "0x58")]
	public float m_TextAlphaUnselected;

	[Token(Token = "0x4004401")]
	[FieldOffset(Offset = "0x5C")]
	public float m_AlphaSelected;

	[Token(Token = "0x4004402")]
	[FieldOffset(Offset = "0x60")]
	public float m_AlphaUnselected;

	[Token(Token = "0x4004403")]
	[FieldOffset(Offset = "0x64")]
	public float m_AlphaHover;

	[Token(Token = "0x60037B9")]
	[Address(RVA = "0xADF620", Offset = "0xADE420", Length = "0xEB")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60037BA")]
	[Address(RVA = "0xADF710", Offset = "0xADE510", Length = "0xA9")]
	protected override void OnItemDoubleClick()
	{
	}

	[Token(Token = "0x60037BB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_Log_Toc_GridItem()
	{
	}
}
