using Cpp2ILInjected;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x20006E6")]
public class SaveMigrationItem : ScrollBehaviourItem
{
	[Header("List Item")]
	[SerializeField]
	[Token(Token = "0x4004992")]
	[FieldOffset(Offset = "0x38")]
	private UILabel m_SaveName;

	[SerializeField]
	[Token(Token = "0x4004993")]
	[FieldOffset(Offset = "0x40")]
	private UILabel m_Info;

	[SerializeField]
	[Token(Token = "0x4004994")]
	[FieldOffset(Offset = "0x48")]
	private UILabel m_LastSaved;

	[SerializeField]
	[Token(Token = "0x4004995")]
	[FieldOffset(Offset = "0x50")]
	private UILabel m_Size;

	[SerializeField]
	[Token(Token = "0x4004996")]
	[FieldOffset(Offset = "0x58")]
	private UITexture m_ScreenShot;

	[SerializeField]
	[Token(Token = "0x4004997")]
	[FieldOffset(Offset = "0x60")]
	private UISprite m_Background;

	[SerializeField]
	[Token(Token = "0x4004998")]
	[FieldOffset(Offset = "0x68")]
	private UIButton m_Button;

	[SerializeField]
	[Token(Token = "0x4004999")]
	[FieldOffset(Offset = "0x70")]
	private Color m_Normal;

	[SerializeField]
	[Token(Token = "0x400499A")]
	[FieldOffset(Offset = "0x80")]
	private Color m_Selected;

	[Token(Token = "0x6003CBA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SaveMigrationItem()
	{
	}
}
