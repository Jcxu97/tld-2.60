using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x2000227")]
public class CraftingRequirementQuantitySelect : MonoBehaviour
{
	[Token(Token = "0x2000228")]
	public delegate void SelectedQunatityChanged();

	[Token(Token = "0x400133E")]
	[FieldOffset(Offset = "0x20")]
	public SelectedQunatityChanged m_OnSelectedQuantityChanged;

	[Token(Token = "0x400133F")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> m_ControllerButtons;

	[Token(Token = "0x4001340")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_QuantityText;

	[Token(Token = "0x4001341")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_UnitsText;

	[Token(Token = "0x4001342")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_DefaultMultipleUnit;

	[Token(Token = "0x4001343")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_DefaultSingleUnit;

	[Token(Token = "0x4001344")]
	public const int MINIMUM = 1;

	[Token(Token = "0x4001345")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsSelected;

	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0x54")]
	private int m_Current;

	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0x58")]
	private int m_Maximum;

	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0x5C")]
	private int m_UnitsPerItem;

	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 m_InitialPosition;

	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x70")]
	private string m_StackMultipleLocID;

	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0x78")]
	private string m_StackSingleLocID;

	[Token(Token = "0x400134C")]
	[FieldOffset(Offset = "0x80")]
	private bool m_NeedsRefresh;

	[Token(Token = "0x6001338")]
	[Address(RVA = "0x666DF0", Offset = "0x665BF0", Length = "0xD1")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001339")]
	[Address(RVA = "0x666ED0", Offset = "0x665CD0", Length = "0x9E")]
	public void Disable()
	{
	}

	[Token(Token = "0x600133A")]
	[Address(RVA = "0x666F70", Offset = "0x665D70", Length = "0x4FF")]
	public void Enable(BlueprintData bp)
	{
	}

	[Token(Token = "0x600133B")]
	[Address(RVA = "0x667470", Offset = "0x666270", Length = "0x4")]
	public int GetCurrent()
	{
		return 0;
	}

	[Token(Token = "0x600133C")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x600133D")]
	[Address(RVA = "0x667480", Offset = "0x666280", Length = "0x29")]
	public bool IsMinimumSelected()
	{
		return false;
	}

	[Token(Token = "0x600133E")]
	[Address(RVA = "0x6674B0", Offset = "0x6662B0", Length = "0x5")]
	public bool IsSelected()
	{
		return false;
	}

	[Token(Token = "0x600133F")]
	[Address(RVA = "0x6674C0", Offset = "0x6662C0", Length = "0x26")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6001340")]
	[Address(RVA = "0x6674F0", Offset = "0x6662F0", Length = "0xCD")]
	public void OnDecrease()
	{
	}

	[Token(Token = "0x6001341")]
	[Address(RVA = "0x6675C0", Offset = "0x6663C0", Length = "0xCD")]
	public void OnIncrease()
	{
	}

	[Token(Token = "0x6001342")]
	[Address(RVA = "0x667690", Offset = "0x666490", Length = "0x1D6")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6001343")]
	[Address(RVA = "0x667870", Offset = "0x666670", Length = "0x13B")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6001344")]
	[Address(RVA = "0x6679B0", Offset = "0x6667B0", Length = "0xE3")]
	public CraftingRequirementQuantitySelect()
	{
	}
}
