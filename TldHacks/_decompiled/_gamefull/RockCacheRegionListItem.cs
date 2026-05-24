using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000274")]
public class RockCacheRegionListItem : MonoBehaviour
{
	[Token(Token = "0x4001672")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget m_FadeOnDeselectWidget;

	[Token(Token = "0x4001673")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_SelectedObj;

	[Token(Token = "0x4001674")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_UnselectedObj;

	[Token(Token = "0x4001675")]
	[FieldOffset(Offset = "0x38")]
	public float m_DeslectedAlphaValue;

	[Token(Token = "0x6001579")]
	[Address(RVA = "0x6A1590", Offset = "0x6A0390", Length = "0xB3")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x600157A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RockCacheRegionListItem()
	{
	}
}
