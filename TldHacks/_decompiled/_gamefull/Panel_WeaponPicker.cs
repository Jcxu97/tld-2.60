using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x20006DE")]
public class Panel_WeaponPicker : Panel_AutoReferenced
{
	[Token(Token = "0x400493E")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Items list")]
	[Token(Token = "0x400493F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_ListRoot;

	[Token(Token = "0x4004940")]
	[FieldOffset(Offset = "0x40")]
	public WeaponPickerGridItem m_Item1;

	[Token(Token = "0x4004941")]
	[FieldOffset(Offset = "0x48")]
	public WeaponPickerGridItem m_Item2;

	[Token(Token = "0x4004942")]
	[FieldOffset(Offset = "0x50")]
	public WeaponPickerGridItem m_Item3;

	[Token(Token = "0x4004943")]
	[FieldOffset(Offset = "0x58")]
	public WeaponPickerGridItem m_Item4;

	[Header("Labels list")]
	[Token(Token = "0x4004944")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_Label1;

	[Token(Token = "0x4004945")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_Label2;

	[Token(Token = "0x4004946")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_Label3;

	[Token(Token = "0x4004947")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_Label4;

	[Header("Bar")]
	[Token(Token = "0x4004948")]
	[FieldOffset(Offset = "0x80")]
	public UISprite m_StruggleBar;

	[Token(Token = "0x4004949")]
	[FieldOffset(Offset = "0x88")]
	public float m_StruggleBarFillOffset;

	[Header("Selected effect")]
	[Token(Token = "0x400494A")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_SelectedEffect;

	[Token(Token = "0x400494B")]
	[FieldOffset(Offset = "0x98")]
	public TweenScale m_SelectedSpriteTweenScale;

	[Header("Optional Background")]
	[SerializeField]
	[Token(Token = "0x400494C")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject m_Background;

	[Token(Token = "0x400494D")]
	[FieldOffset(Offset = "0xA8")]
	private List<GearItem> m_GearItems;

	[Token(Token = "0x400494E")]
	[FieldOffset(Offset = "0xB0")]
	private List<WeaponPickerGridItem> m_GridItemsList;

	[Token(Token = "0x400494F")]
	[FieldOffset(Offset = "0xB8")]
	private List<UILabel> m_LabelsList;

	[Token(Token = "0x4004950")]
	[FieldOffset(Offset = "0xC0")]
	private List<UISprite> m_HoverEffectSpriteList;

	[Token(Token = "0x4004951")]
	[FieldOffset(Offset = "0xC8")]
	private int m_SelectedItemIndex;

	[Token(Token = "0x4004952")]
	[FieldOffset(Offset = "0xD0")]
	private GearItem m_SelectedItem;

	[Token(Token = "0x4004953")]
	[FieldOffset(Offset = "0xD8")]
	private float m_DurationSeconds;

	[Token(Token = "0x4004954")]
	[FieldOffset(Offset = "0xDC")]
	private float m_TimerSeconds;

	[Token(Token = "0x4004955")]
	[FieldOffset(Offset = "0xE0")]
	private float m_ListOffsetWhen2;

	[Token(Token = "0x4004956")]
	[FieldOffset(Offset = "0xE4")]
	private float m_ListOffsetWhen3;

	[Token(Token = "0x4004957")]
	[FieldOffset(Offset = "0xE8")]
	private float m_ListOriginalOffset;

	[Token(Token = "0x6003C7A")]
	[Address(RVA = "0xB7DFF0", Offset = "0xB7CDF0", Length = "0x819")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003C7B")]
	[Address(RVA = "0xB7E810", Offset = "0xB7D610", Length = "0x24C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003C7C")]
	[Address(RVA = "0xB7EA60", Offset = "0xB7D860", Length = "0x388")]
	private void InitializeLayout()
	{
	}

	[Token(Token = "0x6003C7D")]
	[Address(RVA = "0xB7EDF0", Offset = "0xB7DBF0", Length = "0x39B")]
	private void MaybeSelectGear()
	{
	}

	[Token(Token = "0x6003C7E")]
	[Address(RVA = "0xB7F190", Offset = "0xB7DF90", Length = "0x1D")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003C7F")]
	[Address(RVA = "0xB7F1B0", Offset = "0xB7DFB0", Length = "0x3A5")]
	public void Enable(bool enable, List<GearItem> listItems, float durationSeconds)
	{
	}

	[Token(Token = "0x6003C80")]
	[Address(RVA = "0xB7F560", Offset = "0xB7E360", Length = "0x65")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003C81")]
	[Address(RVA = "0xB7F5D0", Offset = "0xB7E3D0", Length = "0x21")]
	public void BackgroundEnable(bool enable)
	{
	}

	[Token(Token = "0x6003C82")]
	[Address(RVA = "0xB7F600", Offset = "0xB7E400", Length = "0x3D2")]
	public void SelectGridItem(WeaponPickerGridItem gridItem, bool isInContainer)
	{
	}

	[Token(Token = "0x6003C83")]
	[Address(RVA = "0xB7F9E0", Offset = "0xB7E7E0", Length = "0x4B6")]
	public static List<GearItem> GetPrioritizedWeaponList()
	{
		return null;
	}

	[Token(Token = "0x6003C84")]
	[Address(RVA = "0xB7FEA0", Offset = "0xB7ECA0", Length = "0xD9")]
	public static GearItem GetBestItemScare()
	{
		return null;
	}

	[Token(Token = "0x6003C85")]
	[Address(RVA = "0xB7FF80", Offset = "0xB7ED80", Length = "0x1A7")]
	public static GearItem GetBestItemPuncture()
	{
		return null;
	}

	[Token(Token = "0x6003C86")]
	[Address(RVA = "0xB80130", Offset = "0xB7EF30", Length = "0xD9")]
	public static GearItem GetBestItemSlash()
	{
		return null;
	}

	[Token(Token = "0x6003C87")]
	[Address(RVA = "0xB80210", Offset = "0xB7F010", Length = "0xA")]
	public static GearItem GetBestItemShootRevolver()
	{
		return null;
	}

	[Token(Token = "0x6003C88")]
	[Address(RVA = "0xB80220", Offset = "0xB7F020", Length = "0xA")]
	public static GearItem GetBestItemShootRifle()
	{
		return null;
	}

	[Token(Token = "0x6003C89")]
	[Address(RVA = "0xB80230", Offset = "0xB7F030", Length = "0xA")]
	public static GearItem GetBestItemShootBow()
	{
		return null;
	}

	[Token(Token = "0x6003C8A")]
	[Address(RVA = "0xB80240", Offset = "0xB7F040", Length = "0x28D")]
	public static GearItem GetBestItemPerCategory(StruggleBonus.StruggleWeaponType type)
	{
		return null;
	}

	[Token(Token = "0x6003C8B")]
	[Address(RVA = "0xB804D0", Offset = "0xB7F2D0", Length = "0x1BB")]
	private void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[Token(Token = "0x6003C8C")]
	[Address(RVA = "0xB80690", Offset = "0xB7F490", Length = "0x1A5")]
	private int GetHoveredItemIndex()
	{
		return 0;
	}

	[Token(Token = "0x6003C8D")]
	[Address(RVA = "0xB80840", Offset = "0xB7F640", Length = "0x312")]
	private void UpdateMouseIndex()
	{
	}

	[Token(Token = "0x6003C8E")]
	[Address(RVA = "0xB80B60", Offset = "0xB7F960", Length = "0x2E7")]
	private void InitializeListItem(int i)
	{
	}

	[Token(Token = "0x6003C8F")]
	[Address(RVA = "0xB80E50", Offset = "0xB7FC50", Length = "0x12F")]
	private void InitializeListItems()
	{
	}

	[Token(Token = "0x6003C90")]
	[Address(RVA = "0xB80F80", Offset = "0xB7FD80", Length = "0x264")]
	private string GetCategoryForItem(GearItem item)
	{
		return null;
	}

	[Token(Token = "0x6003C91")]
	[Address(RVA = "0xB81210", Offset = "0xB80010", Length = "0x203")]
	private void UpdateGamepadSelection()
	{
	}

	[Token(Token = "0x6003C92")]
	[Address(RVA = "0xB81420", Offset = "0xB80220", Length = "0x9A")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003C93")]
	[Address(RVA = "0xB814C0", Offset = "0xB802C0", Length = "0x1F3")]
	private void OnSelectedIndexChanged(int newIndex)
	{
	}

	[Token(Token = "0x6003C94")]
	[Address(RVA = "0xB816C0", Offset = "0xB804C0", Length = "0x6A")]
	private void UpdateIndexSelected(int newIndex)
	{
	}

	[Token(Token = "0x6003C95")]
	[Address(RVA = "0xB81730", Offset = "0xB80530", Length = "0x9B")]
	private void UpdateBar()
	{
	}

	[Token(Token = "0x6003C96")]
	[Address(RVA = "0xB817D0", Offset = "0xB805D0", Length = "0x34")]
	private void InitializeTimerBar(float durationSeconds)
	{
	}

	[Token(Token = "0x6003C97")]
	[Address(RVA = "0xB81810", Offset = "0xB80610", Length = "0x7F")]
	private void SetStruggleBarFillAmount(float value)
	{
	}

	[Token(Token = "0x6003C98")]
	[Address(RVA = "0xB81890", Offset = "0xB80690", Length = "0x46A")]
	private void InitializeSelection()
	{
	}

	[Token(Token = "0x6003C99")]
	[Address(RVA = "0xB81D00", Offset = "0xB80B00", Length = "0x341")]
	public Panel_WeaponPicker()
	{
	}
}
