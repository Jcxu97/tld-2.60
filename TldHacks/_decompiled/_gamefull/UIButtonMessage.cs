using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Message (Legacy)")]
[Token(Token = "0x2000066")]
public class UIButtonMessage : MonoBehaviour
{
	[Token(Token = "0x2000067")]
	public enum Trigger
	{
		[Token(Token = "0x40003C6")]
		OnClick,
		[Token(Token = "0x40003C7")]
		OnMouseOver,
		[Token(Token = "0x40003C8")]
		OnMouseOut,
		[Token(Token = "0x40003C9")]
		OnPress,
		[Token(Token = "0x40003CA")]
		OnRelease,
		[Token(Token = "0x40003CB")]
		OnDoubleClick
	}

	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x28")]
	public string functionName;

	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x30")]
	public Trigger trigger;

	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x34")]
	public bool includeChildren;

	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x35")]
	private bool mStarted;

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xA28270", Offset = "0xA27070", Length = "0x5")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xA28280", Offset = "0xA27080", Length = "0x7A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xA28300", Offset = "0xA27100", Length = "0xD7")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xA283E0", Offset = "0xA271E0", Length = "0xD7")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xA284C0", Offset = "0xA272C0", Length = "0x104")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xA285D0", Offset = "0xA273D0", Length = "0xAC")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xA28680", Offset = "0xA27480", Length = "0xAC")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xA28730", Offset = "0xA27530", Length = "0x3A1")]
	private void Send()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIButtonMessage()
	{
	}
}
