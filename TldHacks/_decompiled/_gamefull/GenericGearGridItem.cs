using System;
using Cpp2ILInjected;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x2000243")]
public class GenericGearGridItem : ScrollBehaviourItem
{
	[Header("Grid Item Labels")]
	[SerializeField]
	[Token(Token = "0x40013EF")]
	[FieldOffset(Offset = "0x38")]
	private UILabel m_LiquidLabel;

	[SerializeField]
	[Token(Token = "0x40013F0")]
	[FieldOffset(Offset = "0x40")]
	private UILabel m_StackLabel;

	[SerializeField]
	[Token(Token = "0x40013F1")]
	[FieldOffset(Offset = "0x48")]
	private UILabel m_UnitLabel;

	[SerializeField]
	[Token(Token = "0x40013F2")]
	[FieldOffset(Offset = "0x50")]
	private UILabel m_ConditionLabel;

	[SerializeField]
	[Token(Token = "0x40013F3")]
	[FieldOffset(Offset = "0x58")]
	private UILabel m_WeightLabel;

	[Header("Grid Item Sprites")]
	[SerializeField]
	[Token(Token = "0x40013F4")]
	[FieldOffset(Offset = "0x60")]
	private UISprite m_BackgroundSprite;

	[SerializeField]
	[Token(Token = "0x40013F5")]
	[FieldOffset(Offset = "0x68")]
	private UITexture m_GearSprite;

	[SerializeField]
	[Token(Token = "0x40013F6")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_EquippedSprite;

	[SerializeField]
	[Token(Token = "0x40013F7")]
	[FieldOffset(Offset = "0x78")]
	private GameObject m_LockedSprite;

	[SerializeField]
	[Token(Token = "0x40013F8")]
	[FieldOffset(Offset = "0x80")]
	private GameObject m_RuinedSprite;

	[SerializeField]
	[Token(Token = "0x40013F9")]
	[FieldOffset(Offset = "0x88")]
	private GameObject m_HoverSprite;

	[SerializeField]
	[Token(Token = "0x40013FA")]
	[FieldOffset(Offset = "0x90")]
	private UISprite m_UnitSprite;

	[SerializeField]
	[Token(Token = "0x40013FB")]
	[FieldOffset(Offset = "0x98")]
	private UISprite m_ConditionSprite;

	[SerializeField]
	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_HotIndicatorSprite;

	[SerializeField]
	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_ColdIndicatorSprite;

	[Header("Grid Item Colors")]
	[SerializeField]
	[Token(Token = "0x40013FE")]
	[FieldOffset(Offset = "0xB0")]
	private Color m_EquippedColor;

	[SerializeField]
	[Token(Token = "0x40013FF")]
	[FieldOffset(Offset = "0xC0")]
	private Color m_UnequippedColor;

	[SerializeField]
	[Token(Token = "0x4001400")]
	[FieldOffset(Offset = "0xD0")]
	private Color m_GoodConditionSpriteColor;

	[Header("Miscellaneous")]
	[SerializeField]
	[Token(Token = "0x4001401")]
	[FieldOffset(Offset = "0xE0")]
	private UITweener m_SelectTweenScale;

	[SerializeField]
	[Token(Token = "0x4001402")]
	[FieldOffset(Offset = "0xE8")]
	private GameObject m_NotificationFlag;

	[Token(Token = "0x4001403")]
	[FieldOffset(Offset = "0xF0")]
	private DragDropItem m_DragDropItem;

	[Token(Token = "0x4001404")]
	[FieldOffset(Offset = "0xF8")]
	private Action<GenericGearGridItem> m_OnClickAction;

	[Token(Token = "0x4001405")]
	[FieldOffset(Offset = "0x100")]
	private Action<GenericGearGridItem> m_OnDoubleClickAction;

	[Token(Token = "0x4001406")]
	[FieldOffset(Offset = "0x108")]
	private Action<GenericGearGridItem> m_OnHoverAction;

	[Token(Token = "0x400140A")]
	[FieldOffset(Offset = "0x11A")]
	private bool m_DragDropEnabled;

	[Token(Token = "0x170001C5")]
	[field: Token(Token = "0x4001407")]
	[field: FieldOffset(Offset = "0x110")]
	public GearItem GearItem
	{
		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x677F90", Offset = "0x676D90", Length = "0x8")]
		get;
		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x677FA0", Offset = "0x676DA0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170001C6")]
	public string DisplayName
	{
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x678000", Offset = "0x676E00", Length = "0x20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C7")]
	public bool IsHovered
	{
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x678030", Offset = "0x676E30", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170001C8")]
	[field: Token(Token = "0x4001408")]
	[field: FieldOffset(Offset = "0x118")]
	public bool IsDragging
	{
		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x678040", Offset = "0x676E40", Length = "0x8")]
		get;
		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x678050", Offset = "0x676E50", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170001C9")]
	[field: Token(Token = "0x4001409")]
	[field: FieldOffset(Offset = "0x119")]
	public bool IsLocked
	{
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x678060", Offset = "0x676E60", Length = "0x8")]
		get;
		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x678070", Offset = "0x676E70", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x678080", Offset = "0x676E80", Length = "0x8D")]
	private void Awake()
	{
	}

	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x678110", Offset = "0x676F10", Length = "0x11")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x678130", Offset = "0x676F30", Length = "0x7EC")]
	public void BuildItem(GearItem gearItem, Action<GenericGearGridItem> onClick, Action<GenericGearGridItem> onDoubleClick, Action<GenericGearGridItem> onHover)
	{
	}

	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x678920", Offset = "0x677720", Length = "0x15B")]
	private void SetupStackLabel(int units, string unitSpriteName)
	{
	}

	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x678A80", Offset = "0x677880", Length = "0x2B6")]
	private bool IsEquipped()
	{
		return false;
	}

	[Token(Token = "0x60013E7")]
	[Address(RVA = "0x678D40", Offset = "0x677B40", Length = "0x2AD")]
	private void UpdateConditionDisplay()
	{
	}

	[Token(Token = "0x60013E8")]
	[Address(RVA = "0x678FF0", Offset = "0x677DF0", Length = "0x59")]
	public void SetLocked(bool locked)
	{
	}

	[Token(Token = "0x60013E9")]
	[Address(RVA = "0x679050", Offset = "0x677E50", Length = "0x38")]
	public void SetDragDropEnabled(bool dragDropEnabled)
	{
	}

	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x679090", Offset = "0x677E90", Length = "0x105")]
	public void ShowHotColdIndicators()
	{
	}

	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x64B780", Offset = "0x64A580", Length = "0x21")]
	public void SetNotificationFlagEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x6791A0", Offset = "0x677FA0", Length = "0x23")]
	public void TryForceDrop()
	{
	}

	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x6791D0", Offset = "0x677FD0", Length = "0x90")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x679270", Offset = "0x678070", Length = "0xAB")]
	public override void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x679320", Offset = "0x678120", Length = "0x1C")]
	protected override void OnItemClick()
	{
	}

	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x679340", Offset = "0x678140", Length = "0x1C")]
	protected override void OnItemDoubleClick()
	{
	}

	[Token(Token = "0x60013F1")]
	[Address(RVA = "0x679360", Offset = "0x678160", Length = "0x4C")]
	protected override void OnItemHovered()
	{
	}

	[Token(Token = "0x60013F2")]
	[Address(RVA = "0x6793B0", Offset = "0x6781B0", Length = "0x1F")]
	private void OnItemDragged(bool isDragging)
	{
	}

	[Token(Token = "0x60013F3")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GenericGearGridItem()
	{
	}
}
