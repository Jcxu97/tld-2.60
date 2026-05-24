using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[RequireComponent(typeof(UIButton))]
[Token(Token = "0x2000240")]
public class GenericGearGridButton : MonoBehaviour
{
	[Token(Token = "0x2000241")]
	public enum State
	{
		[Token(Token = "0x40013EB")]
		Selected,
		[Token(Token = "0x40013EC")]
		NotSelected,
		[Token(Token = "0x40013ED")]
		NotSelectedAndEmpty
	}

	[SerializeField]
	[Token(Token = "0x40013E8")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Token(Token = "0x40013E9")]
	[FieldOffset(Offset = "0x28")]
	private UIButton m_Button;

	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x677AE0", Offset = "0x6768E0", Length = "0x42")]
	private void Awake()
	{
	}

	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x677B30", Offset = "0x676930", Length = "0x206")]
	public void SetButtonState(State state, bool instant = true)
	{
	}

	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x677D40", Offset = "0x676B40", Length = "0x23E")]
	private void SetButtonColors(Color defaultColor, Color hoverColor, Color disabledColor, bool instant)
	{
	}

	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GenericGearGridButton()
	{
	}
}
