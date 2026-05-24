using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20005E0")]
public class GridUI
{
	[Token(Token = "0x20005E1")]
	private struct Item
	{
		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x0")]
		public int m_Index;

		[Token(Token = "0x4003669")]
		[FieldOffset(Offset = "0x8")]
		public LocalizedString m_Label;

		[Token(Token = "0x400366A")]
		[FieldOffset(Offset = "0x10")]
		public Texture m_Icon;

		[Token(Token = "0x400366B")]
		[FieldOffset(Offset = "0x18")]
		public bool m_Disabled;
	}

	[Serializable]
	[Token(Token = "0x20005E2")]
	public class GridSetup
	{
		[Token(Token = "0x400366C")]
		[FieldOffset(Offset = "0x10")]
		public int m_MaxToShowAtOnce;

		[Token(Token = "0x400366D")]
		[FieldOffset(Offset = "0x14")]
		public int m_NumberOfColumns;

		[Token(Token = "0x400366E")]
		[FieldOffset(Offset = "0x18")]
		public int m_PreSelectedIndex;

		[Token(Token = "0x400366F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject m_FirstElementLocation;

		[Token(Token = "0x6002D9E")]
		[Address(RVA = "0x9517E0", Offset = "0x9505E0", Length = "0xF")]
		public GridSetup()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4003650")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_TableObject;

	[SerializeField]
	[Token(Token = "0x4003651")]
	[FieldOffset(Offset = "0x18")]
	private GameObject GridItemPrefab;

	[SerializeField]
	[Token(Token = "0x4003652")]
	[FieldOffset(Offset = "0x20")]
	private UIButton m_LeftArrowButton;

	[SerializeField]
	[Token(Token = "0x4003653")]
	[FieldOffset(Offset = "0x28")]
	private UIButton m_RightArrowButton;

	[Token(Token = "0x4003654")]
	[FieldOffset(Offset = "0x30")]
	public bool m_DragDropEnabled;

	[Token(Token = "0x4003655")]
	[FieldOffset(Offset = "0x34")]
	public float m_DisabledAlpha;

	[SerializeField]
	[Token(Token = "0x4003656")]
	[FieldOffset(Offset = "0x38")]
	private GridSetup m_StandardGripSetup;

	[SerializeField]
	[Token(Token = "0x4003657")]
	[FieldOffset(Offset = "0x40")]
	private GridSetup m_NowhereToHideGridSetup;

	[Header("Table Spacing Values")]
	[SerializeField]
	[Token(Token = "0x4003658")]
	[FieldOffset(Offset = "0x48")]
	private int m_TableNumColumns;

	[SerializeField]
	[Token(Token = "0x4003659")]
	[FieldOffset(Offset = "0x4C")]
	private float m_TableSpacingHorizontal;

	[SerializeField]
	[Token(Token = "0x400365A")]
	[FieldOffset(Offset = "0x50")]
	private float m_TableSpacingVertical;

	[SerializeField]
	[Token(Token = "0x400365B")]
	[FieldOffset(Offset = "0x54")]
	private int m_MaxItemsDisplayAtOnce;

	[SerializeField]
	[Token(Token = "0x400365C")]
	[FieldOffset(Offset = "0x58")]
	private int m_PreSelectedIndex;

	[Token(Token = "0x400365D")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_SelectedSpriteObj;

	[Token(Token = "0x400365E")]
	[FieldOffset(Offset = "0x68")]
	public TweenScale m_SelectedSpriteTweenScale;

	[Token(Token = "0x400365F")]
	[FieldOffset(Offset = "0x70")]
	private Panel_Base m_ParentPanel;

	[Token(Token = "0x4003660")]
	[FieldOffset(Offset = "0x78")]
	private Action m_ConfirmAction;

	[Token(Token = "0x4003661")]
	[FieldOffset(Offset = "0x80")]
	private Action m_OnBackAction;

	[Token(Token = "0x4003662")]
	[FieldOffset(Offset = "0x88")]
	private List<Item> m_ItemList;

	[Token(Token = "0x4003663")]
	[FieldOffset(Offset = "0x90")]
	private GridItem[] m_TableItems;

	[Token(Token = "0x4003664")]
	[FieldOffset(Offset = "0x98")]
	private bool m_HasActiveFocus;

	[Token(Token = "0x4003665")]
	[FieldOffset(Offset = "0x99")]
	private bool m_IsDirty;

	[Token(Token = "0x4003666")]
	[FieldOffset(Offset = "0x9C")]
	private int m_SelectedItemIndex;

	[Token(Token = "0x4003667")]
	[FieldOffset(Offset = "0xA0")]
	private int m_FirstItemDisplayedIndex;

	[Token(Token = "0x6002D8A")]
	[Address(RVA = "0x94F3B0", Offset = "0x94E1B0", Length = "0x1E6")]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[Token(Token = "0x6002D8B")]
	[Address(RVA = "0x94F5A0", Offset = "0x94E3A0", Length = "0xCD5")]
	public void Initialize(Panel_Base parentPanel, Action backAction, Action optionalConfirmAction = null)
	{
	}

	[Token(Token = "0x6002D8C")]
	[Address(RVA = "0x950280", Offset = "0x94F080", Length = "0x12A")]
	private void InitializeNewItem(GridItem item)
	{
	}

	[Token(Token = "0x6002D8D")]
	[Address(RVA = "0x9503B0", Offset = "0x94F1B0", Length = "0x35F")]
	public void AddItem(LocalizedString label, Texture icon, bool disabled)
	{
	}

	[Token(Token = "0x6002D8E")]
	[Address(RVA = "0x950710", Offset = "0x94F510", Length = "0x34C")]
	public void ClearItems()
	{
	}

	[Token(Token = "0x6002D8F")]
	[Address(RVA = "0x950A60", Offset = "0x94F860", Length = "0x48")]
	public bool IsEmpty()
	{
		return false;
	}

	[Token(Token = "0x6002D90")]
	[Address(RVA = "0x950AB0", Offset = "0x94F8B0", Length = "0x2FD")]
	private void RefreshGridItem(int gridItemIndex, int itemIndex)
	{
	}

	[Token(Token = "0x6002D91")]
	[Address(RVA = "0x950DB0", Offset = "0x94FBB0", Length = "0x26")]
	public void SelectItem(GridItem item)
	{
	}

	[Token(Token = "0x6002D92")]
	[Address(RVA = "0x950DE0", Offset = "0x94FBE0", Length = "0xC")]
	public void ScrollLeft()
	{
	}

	[Token(Token = "0x6002D93")]
	[Address(RVA = "0x950DF0", Offset = "0x94FBF0", Length = "0x8B")]
	public void ScrollRight()
	{
	}

	[Token(Token = "0x6002D94")]
	[Address(RVA = "0x950E80", Offset = "0x94FC80", Length = "0x130")]
	private void Scroll(int direction)
	{
	}

	[Token(Token = "0x6002D95")]
	[Address(RVA = "0x40DA90", Offset = "0x40C890", Length = "0x7")]
	public int GetSelectedIndex()
	{
		return 0;
	}

	[Token(Token = "0x6002D96")]
	[Address(RVA = "0x950FC0", Offset = "0x94FDC0", Length = "0x151")]
	public void Update()
	{
	}

	[Token(Token = "0x6002D97")]
	[Address(RVA = "0x951120", Offset = "0x94FF20", Length = "0x75")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Token(Token = "0x6002D98")]
	[Address(RVA = "0x9511A0", Offset = "0x94FFA0", Length = "0x12")]
	public void SetHasActiveFocus(bool active)
	{
	}

	[Token(Token = "0x6002D99")]
	[Address(RVA = "0x9511C0", Offset = "0x94FFC0", Length = "0x2C")]
	private void OnBack()
	{
	}

	[Token(Token = "0x6002D9A")]
	[Address(RVA = "0x9511F0", Offset = "0x94FFF0", Length = "0x1E6")]
	private void UpdateControls()
	{
	}

	[Token(Token = "0x6002D9B")]
	[Address(RVA = "0x9513E0", Offset = "0x9501E0", Length = "0x1EC")]
	private void MoveGridSelection(int horizontal, int vertical)
	{
	}

	[Token(Token = "0x6002D9C")]
	[Address(RVA = "0x9515D0", Offset = "0x9503D0", Length = "0x141")]
	private void RefreshTable()
	{
	}

	[Token(Token = "0x6002D9D")]
	[Address(RVA = "0x951720", Offset = "0x950520", Length = "0xBE")]
	public GridUI()
	{
	}
}
