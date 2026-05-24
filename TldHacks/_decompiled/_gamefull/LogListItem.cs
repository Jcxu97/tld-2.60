using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000259")]
public class LogListItem : MonoBehaviour
{
	[Token(Token = "0x400153B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_Label;

	[Token(Token = "0x400153C")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_BG;

	[Token(Token = "0x400153D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_LeftLine;

	[Token(Token = "0x400153E")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_RightLine;

	[Token(Token = "0x400153F")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_NoteSprite;

	[Token(Token = "0x4001540")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsDay;

	[Token(Token = "0x60014BD")]
	[Address(RVA = "0x6921A0", Offset = "0x690FA0", Length = "0x89")]
	public void SetText(string itemText, bool isDay, bool hasNotes)
	{
	}

	[Token(Token = "0x60014BE")]
	[Address(RVA = "0x692230", Offset = "0x691030", Length = "0x5B")]
	public void SetHasNotes(bool hasNotes)
	{
	}

	[Token(Token = "0x60014BF")]
	[Address(RVA = "0x692290", Offset = "0x691090", Length = "0x7C")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LogListItem()
	{
	}
}
