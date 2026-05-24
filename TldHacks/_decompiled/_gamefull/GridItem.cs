using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200024A")]
public class GridItem : MonoBehaviour
{
	[Header("Essential Values")]
	[Token(Token = "0x400144D")]
	[FieldOffset(Offset = "0x20")]
	public UIButton m_Button;

	[Token(Token = "0x400144E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_ItemElements;

	[Token(Token = "0x400144F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_NameLabel;

	[Token(Token = "0x4001450")]
	[FieldOffset(Offset = "0x38")]
	public UITexture m_GearSprite;

	[Token(Token = "0x4001451")]
	[FieldOffset(Offset = "0x40")]
	public TweenScale m_TweenScale;

	[Header("Optional Values")]
	[Token(Token = "0x4001452")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_SelectedSprite;

	[Token(Token = "0x4001453")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_EquippedSprite;

	[Token(Token = "0x4001454")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_RuinedSprite;

	[Token(Token = "0x4001455")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_LiquidLabel;

	[Token(Token = "0x4001456")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_StackLabel;

	[Token(Token = "0x4001457")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_ConditionLabel;

	[Token(Token = "0x4001458")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_WeightLabel;

	[Token(Token = "0x4001459")]
	[FieldOffset(Offset = "0x80")]
	public UISprite m_WeightSprite;

	[Token(Token = "0x400145A")]
	[FieldOffset(Offset = "0x88")]
	public UISprite m_ConditionSprite;

	[Token(Token = "0x400145B")]
	[FieldOffset(Offset = "0x90")]
	public UISprite m_FavoritedSprite;

	[Token(Token = "0x400145C")]
	[FieldOffset(Offset = "0x98")]
	public Color m_BlueGreenColor;

	[Token(Token = "0x400145D")]
	[FieldOffset(Offset = "0xA8")]
	public Color m_WhiteColor;

	[Token(Token = "0x400145E")]
	[FieldOffset(Offset = "0xB8")]
	public Color m_GoodConditionSpriteColor;

	[Token(Token = "0x400145F")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject m_HoverEffect;

	[Token(Token = "0x4001460")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel m_UnitLabel;

	[Token(Token = "0x4001461")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite m_UnitSprite;

	[Token(Token = "0x4001462")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_IsSelected;

	[Token(Token = "0x4001463")]
	[FieldOffset(Offset = "0xE8")]
	private GridUI m_GridUi;

	[Token(Token = "0x4001464")]
	[FieldOffset(Offset = "0xF0")]
	private int m_SelectionIndex;

	[Token(Token = "0x6001430")]
	[Address(RVA = "0x67F370", Offset = "0x67E170", Length = "0x727")]
	public void Initialize(GridUI gridUi)
	{
	}

	[Token(Token = "0x6001431")]
	[Address(RVA = "0x67FAA0", Offset = "0x67E8A0", Length = "0x7")]
	public void SetSelectionIndex(int value)
	{
	}

	[Token(Token = "0x6001432")]
	[Address(RVA = "0x5025F0", Offset = "0x5013F0", Length = "0x7")]
	public int GetSelectionIndex()
	{
		return 0;
	}

	[Token(Token = "0x6001433")]
	[Address(RVA = "0x67FAB0", Offset = "0x67E8B0", Length = "0x20")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6001434")]
	[Address(RVA = "0x67FAD0", Offset = "0x67E8D0", Length = "0x4D3")]
	public void ToggleSelection(bool toggleVal)
	{
	}

	[Token(Token = "0x6001435")]
	[Address(RVA = "0x67FFB0", Offset = "0x67EDB0", Length = "0x8")]
	public bool IsSelected()
	{
		return false;
	}

	[Token(Token = "0x6001436")]
	[Address(RVA = "0x67FFC0", Offset = "0x67EDC0", Length = "0x4D")]
	public GridItem()
	{
	}
}
