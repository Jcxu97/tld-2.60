using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x2000246")]
public abstract class Panel_GenericGearGrid : Panel_AutoReferenced
{
	[Token(Token = "0x2000247")]
	public enum Sorting
	{
		[Token(Token = "0x400143D")]
		Alphabetic,
		[Token(Token = "0x400143E")]
		Condition,
		[Token(Token = "0x400143F")]
		Weight
	}

	[Token(Token = "0x400142C")]
	public const string FILTER_ALL = "GAMEPLAY_FilterAll";

	[Token(Token = "0x400142D")]
	public const string FILTER_FIRESTARTING = "GAMEPLAY_FilterFirestarting";

	[Token(Token = "0x400142E")]
	public const string FILTER_FIRSTAID = "GAMEPLAY_FilterFirstAid";

	[Token(Token = "0x400142F")]
	public const string FILTER_CLOTHING = "GAMEPLAY_FilterClothing";

	[Token(Token = "0x4001430")]
	public const string FILTER_FOOD = "GAMEPLAY_FilterFoodAndDrink";

	[Token(Token = "0x4001431")]
	public const string FILTER_TOOL = "GAMEPLAY_FilterTool";

	[Token(Token = "0x4001432")]
	public const string FILTER_MATERIAL = "GAMEPLAY_FilterMaterial";

	[Token(Token = "0x4001433")]
	public const string FILTER_DECOR = "GAMEPLAY_FilterDecor";

	[Token(Token = "0x4001434")]
	protected const string GAMEPLAY_BUTTON_BACK = "GAMEPLAY_ButtonBack";

	[Token(Token = "0x4001435")]
	protected const string GAMEPLAY_SELECT = "GAMEPLAY_Select";

	[Token(Token = "0x4001436")]
	private static readonly Vector3 NAMEPLATE_OFFSET;

	[SerializeField]
	[Token(Token = "0x4001437")]
	[FieldOffset(Offset = "0x30")]
	protected ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Basic Grid Elements")]
	[SerializeField]
	[Token(Token = "0x4001438")]
	[FieldOffset(Offset = "0x38")]
	protected UILabel m_NameplateLabel;

	[SerializeField]
	[Token(Token = "0x4001439")]
	[FieldOffset(Offset = "0x40")]
	protected GameObject m_SelectedSprite;

	[SerializeField]
	[Token(Token = "0x400143A")]
	[FieldOffset(Offset = "0x48")]
	private TweenScale m_SelectedSpriteTweenScale;

	[Token(Token = "0x400143B")]
	[FieldOffset(Offset = "0x50")]
	protected ScrollBehaviour m_SelectedTable;

	[Token(Token = "0x6001413")]
	[Address(RVA = "0x67CA50", Offset = "0x67B850", Length = "0x44")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6001414")]
	[Address(RVA = "0x67CAA0", Offset = "0x67B8A0", Length = "0x10B")]
	protected void MoveSelectedSpriteAndTween(Vector3 position)
	{
	}

	[Token(Token = "0x6001415")]
	[Address(RVA = "0x67CBB0", Offset = "0x67B9B0", Length = "0xC0")]
	protected void HoverItem(Vector3 gridItemPosition, string displayName, bool isOver, UIWidget.Pivot pivot)
	{
	}

	[Token(Token = "0x6001416")]
	[Address(RVA = "0x67CC80", Offset = "0x67BA80", Length = "0x2AA")]
	protected void UpdateNameplatePosition(Vector3 gridItemPosition)
	{
	}

	[Token(Token = "0x6001417")]
	[Address(RVA = "0x67CF30", Offset = "0x67BD30", Length = "0x3C3")]
	protected bool ItemPassesFilter(GearItem gearItem, InventoryFilterType filter)
	{
		return false;
	}

	[Token(Token = "0x6001418")]
	[Address(RVA = "0x67D300", Offset = "0x67C100", Length = "0x138")]
	private bool IgnoreWaterSupplyItem(WaterSupply ws)
	{
		return false;
	}

	[Token(Token = "0x6001419")]
	[Address(RVA = "0x67D440", Offset = "0x67C240", Length = "0x2BE")]
	protected bool FilterHasNoItemsInInventory(List<GearItemObject> gearItems, InventoryFilterType filterType)
	{
		return false;
	}

	[Token(Token = "0x600141A")]
	[Address(RVA = "0x67D700", Offset = "0x67C500", Length = "0xB4")]
	protected string GetLocIdFromFilterType(InventoryFilterType filterType)
	{
		return null;
	}

	[Token(Token = "0x600141B")]
	[Address(RVA = "0x67D850", Offset = "0x67C650", Length = "0x2E9")]
	protected virtual void SetSelectedTable(ScrollBehaviour selectedTable, bool focusNewTable)
	{
	}

	[Token(Token = "0x600141C")]
	[Address(RVA = "0x67DB40", Offset = "0x67C940", Length = "0xC3")]
	protected Panel_GenericGearGrid()
	{
	}
}
