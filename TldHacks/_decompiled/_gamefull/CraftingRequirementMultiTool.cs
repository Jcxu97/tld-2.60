using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x2000223")]
public class CraftingRequirementMultiTool : MonoBehaviour
{
	[Token(Token = "0x2000224")]
	public delegate void SelectedToolChanged();

	[Token(Token = "0x2000225")]
	private struct ToolOption : IComparable<ToolOption>
	{
		[Token(Token = "0x4001333")]
		[FieldOffset(Offset = "0x0")]
		public GearItem m_GearItem;

		[Token(Token = "0x4001334")]
		[FieldOffset(Offset = "0x8")]
		public bool m_InInventory;

		[Token(Token = "0x6001329")]
		[Address(RVA = "0x665FE0", Offset = "0x664DE0", Length = "0x1F")]
		public int CompareTo(ToolOption other)
		{
			return 0;
		}
	}

	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0x20")]
	public SelectedToolChanged m_OnSelectedToolChanged;

	[Token(Token = "0x4001323")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_ConditionDisplay;

	[Token(Token = "0x4001324")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_ControllerButtonRoot;

	[Token(Token = "0x4001325")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_ConditionRoot;

	[Token(Token = "0x4001326")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_DisplayName;

	[Token(Token = "0x4001327")]
	[FieldOffset(Offset = "0x48")]
	public UITexture m_Icon;

	[Header("Alignment")]
	[Tooltip("Offset for this element")]
	[Token(Token = "0x4001328")]
	[FieldOffset(Offset = "0x50")]
	public float m_OffsetY;

	[Tooltip("Offset for elements below this one")]
	[Token(Token = "0x4001329")]
	[FieldOffset(Offset = "0x54")]
	public float m_NextOffsetY;

	[Header("No Tool")]
	[Token(Token = "0x400132A")]
	[FieldOffset(Offset = "0x58")]
	public string m_NoToolIcon;

	[Token(Token = "0x400132B")]
	[FieldOffset(Offset = "0x60")]
	public string m_NoToolName;

	[Token(Token = "0x400132C")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<ToolOption> m_ToolOptions;

	[Token(Token = "0x400132D")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsSelected;

	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x74")]
	private int m_SelectedIndex;

	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0x78")]
	private GearItem m_SelectedTool;

	[Token(Token = "0x4001330")]
	[FieldOffset(Offset = "0x80")]
	private Color m_IconColor;

	[Token(Token = "0x4001331")]
	[FieldOffset(Offset = "0x90")]
	private Color m_LabelColor;

	[Token(Token = "0x4001332")]
	[FieldOffset(Offset = "0xA0")]
	private Color m_RequirementNotMetColor;

	[Token(Token = "0x6001317")]
	[Address(RVA = "0x6647D0", Offset = "0x6635D0", Length = "0x8E")]
	public void Start()
	{
	}

	[Token(Token = "0x6001318")]
	[Address(RVA = "0x664860", Offset = "0x663660", Length = "0x3C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001319")]
	[Address(RVA = "0x6648A0", Offset = "0x6636A0", Length = "0x97")]
	public void Disable()
	{
	}

	[Token(Token = "0x600131A")]
	[Address(RVA = "0x664940", Offset = "0x663740", Length = "0x4C9")]
	public void Enable(Panel_Crafting ownerPanel, BlueprintData bp)
	{
	}

	[Token(Token = "0x600131B")]
	[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[Token(Token = "0x600131C")]
	[Address(RVA = "0x664E20", Offset = "0x663C20", Length = "0x8D")]
	public GearItem GetSelectedToolPrefab()
	{
		return null;
	}

	[Token(Token = "0x600131D")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x600131E")]
	[Address(RVA = "0x664EB0", Offset = "0x663CB0", Length = "0x5")]
	public bool IsSelected()
	{
		return false;
	}

	[Token(Token = "0x600131F")]
	[Address(RVA = "0x664EC0", Offset = "0x663CC0", Length = "0x108")]
	public void OnNextTool()
	{
	}

	[Token(Token = "0x6001320")]
	[Address(RVA = "0x664FD0", Offset = "0x663DD0", Length = "0x105")]
	public void OnPreviousTool()
	{
	}

	[Token(Token = "0x6001321")]
	[Address(RVA = "0x6650E0", Offset = "0x663EE0", Length = "0xAB")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6001322")]
	[Address(RVA = "0x665190", Offset = "0x663F90", Length = "0x778")]
	private void AddToolOptions(GearItem gi, bool mustHaveInInventory)
	{
	}

	[Token(Token = "0x6001323")]
	[Address(RVA = "0x665910", Offset = "0x664710", Length = "0x5D4")]
	private void RefreshDisplayed()
	{
	}

	[Token(Token = "0x6001324")]
	[Address(RVA = "0x665EF0", Offset = "0x664CF0", Length = "0xE3")]
	public CraftingRequirementMultiTool()
	{
	}
}
