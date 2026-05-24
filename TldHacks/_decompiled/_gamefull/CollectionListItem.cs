using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000218")]
public class CollectionListItem : MonoBehaviour
{
	[Token(Token = "0x40012E0")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget m_FadeOnDeselectWidget;

	[Token(Token = "0x40012E1")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_CollectionIcon;

	[Token(Token = "0x40012E2")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_CompletionLabel;

	[Token(Token = "0x40012E3")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_CollectionNameLabel;

	[Token(Token = "0x40012E4")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_SelectedObj;

	[Token(Token = "0x40012E5")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_UnselectedObj;

	[Token(Token = "0x40012E6")]
	[FieldOffset(Offset = "0x50")]
	public float m_DeslectedAlphaValue;

	[Token(Token = "0x40012E7")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_NotificationFlag;

	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0x60")]
	public bool m_IsSelected;

	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x68")]
	private CollectionListItemInfo m_ItemInfo;

	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
	public CollectionListItemInfo GetItemInfo()
	{
		return null;
	}

	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x65D9E0", Offset = "0x65C7E0", Length = "0x112")]
	public void SetItemInfo(CollectionListItemInfo itemInfo)
	{
	}

	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x65DB00", Offset = "0x65C900", Length = "0xB7")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60012DE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CollectionListItem()
	{
	}
}
