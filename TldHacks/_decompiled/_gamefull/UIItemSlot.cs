using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200003E")]
public abstract class UIItemSlot : MonoBehaviour
{
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x20")]
	public UISprite icon;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget background;

	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x30")]
	public UILabel label;

	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip grabSound;

	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip placeSound;

	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip errorSound;

	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x50")]
	private InvGameItem mItem;

	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x58")]
	private string mText;

	[Token(Token = "0x4000301")]
	private static InvGameItem mDraggedItem;

	[Token(Token = "0x17000027")]
	protected abstract InvGameItem observedItem
	{
		[Token(Token = "0x6000325")]
		get;
	}

	[Token(Token = "0x6000326")]
	protected abstract InvGameItem Replace(InvGameItem item);

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xA182E0", Offset = "0xA170E0", Length = "0x6F9")]
	private void OnTooltip(bool show)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xA189E0", Offset = "0xA177E0", Length = "0x2B0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xA18C90", Offset = "0xA17A90", Length = "0x16E")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xA18E00", Offset = "0xA17C00", Length = "0x186")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xA18F90", Offset = "0xA17D90", Length = "0xBC")]
	private void UpdateCursor()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xA19050", Offset = "0xA17E50", Length = "0x475")]
	private void Update()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xA194D0", Offset = "0xA182D0", Length = "0xC2")]
	protected UIItemSlot()
	{
	}
}
