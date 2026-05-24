using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI.Scroll;

[Token(Token = "0x2001395")]
public class ScrollBehaviour : MonoBehaviour
{
	[Token(Token = "0x2001396")]
	private enum ScrollDirection
	{
		[Token(Token = "0x4008FD0")]
		Vertical,
		[Token(Token = "0x4008FD1")]
		Horizontal,
		[Token(Token = "0x4008FD2")]
		Grid
	}

	[Header("Items")]
	[SerializeField]
	[Token(Token = "0x4008FBD")]
	[FieldOffset(Offset = "0x20")]
	private ScrollBehaviourItem m_ItemPrefab;

	[Header("Layout")]
	[SerializeField]
	[Token(Token = "0x4008FBE")]
	[FieldOffset(Offset = "0x28")]
	private ScrollDirection m_ScrollDirection;

	[SerializeField]
	[Token(Token = "0x4008FBF")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 m_CellSize;

	[SerializeField]
	[Token(Token = "0x4008FC0")]
	[FieldOffset(Offset = "0x34")]
	private int m_VisibleLines;

	[SerializeField]
	[Min(1f)]
	[Token(Token = "0x4008FC1")]
	[FieldOffset(Offset = "0x38")]
	private int m_ItemsPerLine;

	[Header("Scroll Settings")]
	[SerializeField]
	[Token(Token = "0x4008FC2")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_WrapAround;

	[Header("Scroll Bar")]
	[SerializeField]
	[Token(Token = "0x4008FC3")]
	[FieldOffset(Offset = "0x40")]
	private UIWidget m_ScrollBarWidget;

	[SerializeField]
	[Token(Token = "0x4008FC4")]
	[FieldOffset(Offset = "0x48")]
	private UIScrollBar m_ScrollBar;

	[SerializeField]
	[Token(Token = "0x4008FC5")]
	[FieldOffset(Offset = "0x50")]
	private bool m_OnlyShowScrollBarIfNeeded;

	[Token(Token = "0x4008FC8")]
	[FieldOffset(Offset = "0x60")]
	private IScrollModel m_Model;

	[Token(Token = "0x4008FC9")]
	[FieldOffset(Offset = "0x68")]
	private int m_FirstLine;

	[Token(Token = "0x4008FCA")]
	[FieldOffset(Offset = "0x6C")]
	private int m_TotalLines;

	[Token(Token = "0x4008FCB")]
	[FieldOffset(Offset = "0x70")]
	private ScrollBehaviourItem[] m_VisibleItems;

	[Token(Token = "0x4008FCC")]
	[FieldOffset(Offset = "0x78")]
	private int m_TotalItems;

	[Token(Token = "0x4008FCD")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_IgnoreInitialInput;

	[Token(Token = "0x4008FCE")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_IgnoreScrollBarChange;

	[Token(Token = "0x17000A95")]
	[field: Token(Token = "0x4008FC6")]
	[field: FieldOffset(Offset = "0x54")]
	public int SelectedIndex
	{
		[Token(Token = "0x6007D07")]
		[Address(RVA = "0x667470", Offset = "0x666270", Length = "0x4")]
		get;
		[Token(Token = "0x6007D08")]
		[Address(RVA = "0xFE71B0", Offset = "0xFE5FB0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000A96")]
	[field: Token(Token = "0x4008FC7")]
	[field: FieldOffset(Offset = "0x58")]
	public bool IsFocused
	{
		[Token(Token = "0x6007D09")]
		[Address(RVA = "0x67E850", Offset = "0x67D650", Length = "0x5")]
		get;
		[Token(Token = "0x6007D0A")]
		[Address(RVA = "0x10C66B0", Offset = "0x10C54B0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000A97")]
	private bool CanScroll
	{
		[Token(Token = "0x6007D0B")]
		[Address(RVA = "0x11C3510", Offset = "0x11C2310", Length = "0xE0")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007D0C")]
	[Address(RVA = "0x11C35F0", Offset = "0x11C23F0", Length = "0xE")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6007D0D")]
	[Address(RVA = "0x11C3600", Offset = "0x11C2400", Length = "0x93")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007D0E")]
	[Address(RVA = "0x11C36A0", Offset = "0x11C24A0", Length = "0x2FE")]
	public void Initialize(IScrollModel model)
	{
	}

	[Token(Token = "0x6007D0F")]
	[Address(RVA = "0x11C39A0", Offset = "0x11C27A0", Length = "0x2A6")]
	public void RebuildItems(int numberOfItems)
	{
	}

	[Token(Token = "0x6007D10")]
	[Address(RVA = "0x11C3C50", Offset = "0x11C2A50", Length = "0x199")]
	public void RefreshItems()
	{
	}

	[Token(Token = "0x6007D11")]
	[Address(RVA = "0x11C3DF0", Offset = "0x11C2BF0", Length = "0x80")]
	public void RefreshSelectedItem()
	{
	}

	[Token(Token = "0x6007D12")]
	[Address(RVA = "0x11C3E80", Offset = "0x11C2C80", Length = "0x2A3")]
	public void SetSelectedIndex(int newIndex, bool force = false, bool playSFX = false)
	{
	}

	[Token(Token = "0x6007D13")]
	[Address(RVA = "0x11C4130", Offset = "0x11C2F30", Length = "0xE8")]
	private void UpdateSelectedIndex(int newIndex)
	{
	}

	[Token(Token = "0x6007D14")]
	[Address(RVA = "0x11C4220", Offset = "0x11C3020", Length = "0x151")]
	private void UpdateFirstLine(int newFirstLine, bool playSFX, int newIndex)
	{
	}

	[Token(Token = "0x6007D15")]
	[Address(RVA = "0x11C4380", Offset = "0x11C3180", Length = "0x1D7")]
	private bool TryGetVisibleItemFromIndex(int index, out ScrollBehaviourItem scrollBehaviourItem)
	{
		scrollBehaviourItem = null;
		return false;
	}

	[Token(Token = "0x6007D16")]
	[Address(RVA = "0x11C4560", Offset = "0x11C3360", Length = "0xE4")]
	public void SetFocused(bool focused)
	{
	}

	[Token(Token = "0x6007D17")]
	[Address(RVA = "0x11C4650", Offset = "0x11C3450", Length = "0x94")]
	private void OnScrollBarChange()
	{
	}

	[Token(Token = "0x6007D18")]
	[Address(RVA = "0x11C46F0", Offset = "0x11C34F0", Length = "0x45")]
	private void OnScrollBarDragFinished()
	{
	}

	[Token(Token = "0x6007D19")]
	[Address(RVA = "0x11C4740", Offset = "0x11C3540", Length = "0x2D5")]
	public void UpdateSelection()
	{
	}

	[Token(Token = "0x6007D1A")]
	[Address(RVA = "0x11C4A20", Offset = "0x11C3820", Length = "0x1D5")]
	public void ReturnAllItemsToPool()
	{
	}

	[Token(Token = "0x6007D1B")]
	[Address(RVA = "0x11C4C00", Offset = "0x11C3A00", Length = "0x2FE")]
	private void InstantiateVisibleItems()
	{
	}

	[Token(Token = "0x6007D1C")]
	[Address(RVA = "0x11C4F00", Offset = "0x11C3D00", Length = "0x1B5")]
	private void HandleOnItemSelected(GameObject itemObject)
	{
	}

	[Token(Token = "0x6007D1D")]
	[Address(RVA = "0x11C50C0", Offset = "0x11C3EC0", Length = "0x216")]
	private void LayoutItems()
	{
	}

	[Token(Token = "0x6007D1E")]
	[Address(RVA = "0x11C52E0", Offset = "0x11C40E0", Length = "0x227")]
	private void LayoutItemsGrid()
	{
	}

	[Token(Token = "0x6007D1F")]
	[Address(RVA = "0x11C5510", Offset = "0x11C4310", Length = "0xC2")]
	public ScrollBehaviour()
	{
	}
}
