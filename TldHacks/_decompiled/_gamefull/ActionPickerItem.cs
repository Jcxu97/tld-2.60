using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001F9")]
public class ActionPickerItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40011E3")]
	[FieldOffset(Offset = "0x20")]
	private Panel_ActionPicker m_ActionPicker;

	[Token(Token = "0x40011E4")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_Sprite;

	[Token(Token = "0x40011E5")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_Label;

	[Token(Token = "0x40011E6")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget m_Widget;

	[Token(Token = "0x40011E7")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_HoverSprite;

	[Token(Token = "0x40011E8")]
	[FieldOffset(Offset = "0x48")]
	private int m_Index;

	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x6461A0", Offset = "0x644FA0", Length = "0x10F")]
	public void Setup(ActionPickerItemData itemData, int index)
	{
	}

	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x6462B0", Offset = "0x6450B0", Length = "0x8A")]
	public void UpdateGamepadSelection(bool isSelected)
	{
	}

	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x646340", Offset = "0x645140", Length = "0x24")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ActionPickerItem()
	{
	}
}
