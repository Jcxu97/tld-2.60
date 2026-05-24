using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x2000268")]
public class Panel_List<T, U> : Panel_AutoReferenced
{
	[Token(Token = "0x2000269")]
	protected enum StickMode
	{
		[Token(Token = "0x400160D")]
		VerticalStick,
		[Token(Token = "0x400160E")]
		VerticalRightStick
	}

	[Header("Displays")]
	[Token(Token = "0x40015FC")]
	[FieldOffset(Offset = "0x0")]
	public List<T> m_Displays;

	[Token(Token = "0x40015FD")]
	[FieldOffset(Offset = "0x0")]
	public GameObject m_ScrollbarSpawner;

	[Header("Button Legend")]
	[Token(Token = "0x40015FE")]
	[FieldOffset(Offset = "0x0")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40015FF")]
	[FieldOffset(Offset = "0x0")]
	protected UISlider m_Slider;

	[Token(Token = "0x4001600")]
	[FieldOffset(Offset = "0x0")]
	protected GameObject m_SliderRoot;

	[Token(Token = "0x4001601")]
	[FieldOffset(Offset = "0x0")]
	protected List<U> m_Items;

	[Token(Token = "0x4001602")]
	[FieldOffset(Offset = "0x0")]
	protected GamepadButtonSprite[] m_GamepadButtonSprites;

	[Token(Token = "0x4001603")]
	[FieldOffset(Offset = "0x0")]
	protected int m_CurrentIndex;

	[Token(Token = "0x4001604")]
	[FieldOffset(Offset = "0x0")]
	protected int m_CurrentDisplayOffset;

	[Token(Token = "0x4001605")]
	[FieldOffset(Offset = "0x0")]
	protected U m_SelectedItem;

	[Token(Token = "0x4001606")]
	[FieldOffset(Offset = "0x0")]
	protected bool m_RefreshingSelected;

	[Token(Token = "0x4001607")]
	[FieldOffset(Offset = "0x0")]
	protected bool m_NeedsSelectedRefresh;

	[Token(Token = "0x4001608")]
	[FieldOffset(Offset = "0x0")]
	protected bool m_NeedsUpdate;

	[Token(Token = "0x4001609")]
	[FieldOffset(Offset = "0x0")]
	protected int m_ScrollWheelIndexStep;

	[Token(Token = "0x400160A")]
	protected const int INVALID_INDEX = -1;

	[Token(Token = "0x400160B")]
	[FieldOffset(Offset = "0x0")]
	protected StickMode m_StickMode;

	[Token(Token = "0x6001509")]
	[Address(RVA = "0x1E5D670", Offset = "0x1E5C470", Length = "0x33")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600150A")]
	[Address(RVA = "0x1E5D6B0", Offset = "0x1E5C4B0", Length = "0x755")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600150B")]
	[Address(RVA = "0x1E5DE10", Offset = "0x1E5CC10", Length = "0x1FD")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600150C")]
	[Address(RVA = "0x1E5E010", Offset = "0x1E5CE10", Length = "0x13F")]
	public void Update()
	{
	}

	[Token(Token = "0x600150D")]
	[Address(RVA = "0x1E5E150", Offset = "0x1E5CF50", Length = "0x6B")]
	public void OnBackButton()
	{
	}

	[Token(Token = "0x600150E")]
	[Address(RVA = "0x1E5E1C0", Offset = "0x1E5CFC0", Length = "0x1B4")]
	public void OnScrollbarChanged()
	{
	}

	[Token(Token = "0x600150F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Start_Internal()
	{
	}

	[Token(Token = "0x6001510")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Awake_Internal()
	{
	}

	[Token(Token = "0x6001511")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Enable_Internal(bool isEnabled)
	{
	}

	[Token(Token = "0x6001512")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Update_Internal()
	{
	}

	[Token(Token = "0x6001513")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void ConfigureDisplay(T display, int index)
	{
	}

	[Token(Token = "0x6001514")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void SetSelected(T display, bool selected)
	{
	}

	[Token(Token = "0x6001515")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void ClearDisplay(T display)
	{
	}

	[Token(Token = "0x6001516")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void SetupDisplay(T display, U item)
	{
	}

	[Token(Token = "0x6001517")]
	[Address(RVA = "0x1E5E380", Offset = "0x1E5D180", Length = "0x60")]
	protected virtual List<U> GatherItems()
	{
		return null;
	}

	[Token(Token = "0x6001518")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnDeleteItemRequested(int itemIndex)
	{
	}

	[Token(Token = "0x6001519")]
	[Address(RVA = "0x1E5E3E0", Offset = "0x1E5D1E0", Length = "0x12D")]
	protected int GetItemIndex(U item)
	{
		return 0;
	}

	[Token(Token = "0x600151A")]
	[Address(RVA = "0x1E5E510", Offset = "0x1E5D310", Length = "0x1CA")]
	protected void RefreshItemsDisplay()
	{
	}

	[Token(Token = "0x600151B")]
	[Address(RVA = "0x1E5E6E0", Offset = "0x1E5D4E0", Length = "0x4B")]
	protected void OnDisplayClicked(int index)
	{
	}

	[Token(Token = "0x600151C")]
	[Address(RVA = "0x1E5E730", Offset = "0x1E5D530", Length = "0x36")]
	protected void OnDisplayClickedDelete(int index)
	{
	}

	[Token(Token = "0x600151D")]
	[Address(RVA = "0x1E5E770", Offset = "0x1E5D570", Length = "0x2D")]
	protected void ItemDeleted()
	{
	}

	[Token(Token = "0x600151E")]
	[Address(RVA = "0x1E5E7A0", Offset = "0x1E5D5A0", Length = "0xE8")]
	protected void ResetIndex()
	{
	}

	[Token(Token = "0x600151F")]
	[Address(RVA = "0x1E5E890", Offset = "0x1E5D690", Length = "0x251")]
	protected void RefreshSelected()
	{
	}

	[Token(Token = "0x6001520")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6001521")]
	[Address(RVA = "0x1E5EAF0", Offset = "0x1E5D8F0", Length = "0x1D0")]
	private int GetCurrentDisplayOffset()
	{
		return 0;
	}

	[Token(Token = "0x6001522")]
	[Address(RVA = "0x1E5ECD0", Offset = "0x1E5DAD0", Length = "0x13A")]
	private void CollectItems()
	{
	}

	[Token(Token = "0x6001523")]
	[Address(RVA = "0x1E5EE10", Offset = "0x1E5DC10", Length = "0x45D")]
	private void HandleInput()
	{
	}

	[Token(Token = "0x6001524")]
	[Address(RVA = "0x1E5F270", Offset = "0x1E5E070", Length = "0xF7")]
	private void HandleVerticalNavigation(float movement)
	{
	}

	[Token(Token = "0x6001525")]
	[Address(RVA = "0x1E5F370", Offset = "0x1E5E170", Length = "0x2EF")]
	private void RefreshDisplayList()
	{
	}

	[Token(Token = "0x6001526")]
	[Address(RVA = "0x1E5F660", Offset = "0x1E5E460", Length = "0x1D")]
	private void UpdateMouseKeyboardButtons()
	{
	}

	[Token(Token = "0x6001527")]
	[Address(RVA = "0x1E5F680", Offset = "0x1E5E480", Length = "0x21E")]
	private void UpdateControllerButtons()
	{
	}

	[Token(Token = "0x6001528")]
	[Address(RVA = "0x1E5F8A0", Offset = "0x1E5E6A0", Length = "0x122")]
	private void ClearSelected()
	{
	}

	[Token(Token = "0x6001529")]
	[Address(RVA = "0x1E5F9D0", Offset = "0x1E5E7D0", Length = "0x19B")]
	public Panel_List()
	{
	}
}
