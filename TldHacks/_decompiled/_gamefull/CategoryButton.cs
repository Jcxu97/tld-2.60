using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000210")]
public class CategoryButton
{
	[Token(Token = "0x2000211")]
	public enum ButtonState
	{
		[Token(Token = "0x40012A2")]
		Selected,
		[Token(Token = "0x40012A3")]
		NotSelected,
		[Token(Token = "0x40012A4")]
		NotSelectedAndEmpty
	}

	[Token(Token = "0x170001C3")]
	[field: Token(Token = "0x40012A0")]
	[field: FieldOffset(Offset = "0x10")]
	public UIButton Button
	{
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x600129C")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public CategoryButton(UIButton button)
	{
	}

	[Token(Token = "0x600129D")]
	[Address(RVA = "0x656370", Offset = "0x655170", Length = "0x228")]
	public void SetButtonState(ButtonState state, bool instant = true)
	{
	}

	[Token(Token = "0x600129E")]
	[Address(RVA = "0x6565A0", Offset = "0x6553A0", Length = "0x23E")]
	private void SetButtonColors(Color defaultColor, Color hoverColor, Color disabledColor, bool instant)
	{
	}
}
