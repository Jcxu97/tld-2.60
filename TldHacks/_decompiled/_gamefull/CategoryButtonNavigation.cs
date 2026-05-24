using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000212")]
public class CategoryButtonNavigation : MonoBehaviour
{
	[Token(Token = "0x2000213")]
	public delegate void CategoryChangedDelegate(int category);

	[Token(Token = "0x40012A5")]
	[FieldOffset(Offset = "0x20")]
	public CategoryChangedDelegate m_OnCategoryChanged;

	[Token(Token = "0x40012A6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_NavigationArrowPrompt;

	[Token(Token = "0x40012A7")]
	[FieldOffset(Offset = "0x30")]
	public List<UIButton> m_NavigationButtons;

	[Token(Token = "0x40012A8")]
	[FieldOffset(Offset = "0x38")]
	public List<GameObject> m_NotificationFlags;

	[Token(Token = "0x40012A9")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_SelectedHighlight;

	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0x48")]
	public bool m_UseDisabledCategories;

	[Token(Token = "0x40012AB")]
	[FieldOffset(Offset = "0x50")]
	private List<CategoryButton> m_CategoryButtons;

	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0x58")]
	private int m_CurrentIndex;

	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_Selected;

	[Token(Token = "0x600129F")]
	[Address(RVA = "0x6567E0", Offset = "0x6555E0", Length = "0xC")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x6567F0", Offset = "0x6555F0", Length = "0x254")]
	public void Initialize(List<UIButton> navigationButtons)
	{
	}

	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x656A50", Offset = "0x655850", Length = "0x1D1")]
	public void OnNavigationChanged(UIButton button)
	{
	}

	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x656C30", Offset = "0x655A30", Length = "0x58")]
	public void OnNavigateDown()
	{
	}

	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x656C90", Offset = "0x655A90", Length = "0x58")]
	public void OnNavigateUp()
	{
	}

	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x656CF0", Offset = "0x655AF0", Length = "0x67")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x656D60", Offset = "0x655B60", Length = "0x207")]
	public void SetCurrentIndex(int index, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x656F70", Offset = "0x655D70", Length = "0xEA")]
	public CategoryButtonNavigation()
	{
	}
}
