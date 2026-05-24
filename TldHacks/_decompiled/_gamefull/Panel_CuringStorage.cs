using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x200056B")]
public class Panel_CuringStorage : Panel_GenericContainerGearGrid
{
	[Header("Curing Storage Info")]
	[SerializeField]
	[Token(Token = "0x400320E")]
	[FieldOffset(Offset = "0x130")]
	private UILabel m_StorageLabel;

	[SerializeField]
	[Token(Token = "0x400320F")]
	[FieldOffset(Offset = "0x138")]
	private UILabel m_StorageCapacityLabel;

	[SerializeField]
	[Token(Token = "0x4003210")]
	[FieldOffset(Offset = "0x140")]
	private UISprite m_StorageCapacityBarSprite;

	[Header("Salt Info")]
	[SerializeField]
	[Token(Token = "0x4003211")]
	[FieldOffset(Offset = "0x148")]
	private UILabel m_SaltCapacityLabel;

	[Header("Localization")]
	[SerializeField]
	[Token(Token = "0x4003212")]
	[FieldOffset(Offset = "0x150")]
	private LocalizedString m_CuredPostfix;

	[Token(Token = "0x4003213")]
	[FieldOffset(Offset = "0x158")]
	private CuringStorage m_CuringStorage;

	[Token(Token = "0x4003214")]
	[FieldOffset(Offset = "0x160")]
	private readonly List<GearItem> m_LockedItemInventoryList;

	[Token(Token = "0x4003215")]
	[FieldOffset(Offset = "0x168")]
	private readonly List<GearItem> m_LockedItemContainerList;

	[Token(Token = "0x60029AD")]
	[Address(RVA = "0x8F0D20", Offset = "0x8EFB20", Length = "0x107")]
	public void ShowCuringStorage(CuringStorage curingStorage)
	{
	}

	[Token(Token = "0x60029AE")]
	[Address(RVA = "0x7F6DB0", Offset = "0x7F5BB0", Length = "0x13")]
	public override void ClosePanel()
	{
	}

	[Token(Token = "0x60029AF")]
	[Address(RVA = "0x8F0E30", Offset = "0x8EFC30", Length = "0x157")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60029B0")]
	[Address(RVA = "0x8F0F90", Offset = "0x8EFD90", Length = "0x11")]
	public void ForceRefreshTables()
	{
	}

	[Token(Token = "0x60029B1")]
	[Address(RVA = "0x8F0FB0", Offset = "0x8EFDB0", Length = "0x119")]
	protected override void RefreshTables()
	{
	}

	[Token(Token = "0x60029B2")]
	[Address(RVA = "0x8F10D0", Offset = "0x8EFED0", Length = "0x8C7")]
	private void RefreshInventory()
	{
	}

	[Token(Token = "0x60029B3")]
	[Address(RVA = "0x8F19A0", Offset = "0x8F07A0", Length = "0xA0D")]
	private void RefreshCuringStorage()
	{
	}

	[Token(Token = "0x60029B4")]
	[Address(RVA = "0x8F23B0", Offset = "0x8F11B0", Length = "0x6CA")]
	public override void MoveItem()
	{
	}

	[Token(Token = "0x60029B5")]
	[Address(RVA = "0x8F2A80", Offset = "0x8F1880", Length = "0x230")]
	private void HandleOnItemTransfer(GearItem selectedGearItem)
	{
	}

	[Token(Token = "0x60029B6")]
	[Address(RVA = "0x8F2CC0", Offset = "0x8F1AC0", Length = "0xB3")]
	private GearItem GetSelectedGearItem()
	{
		return null;
	}

	[Token(Token = "0x60029B7")]
	[Address(RVA = "0x8F2D80", Offset = "0x8F1B80", Length = "0x210")]
	protected override void UpdateGamepadControls()
	{
	}

	[Token(Token = "0x60029B8")]
	[Address(RVA = "0x8F2FA0", Offset = "0x8F1DA0", Length = "0x38C")]
	private void HandleOnHoverCuringContainer(GenericGearGridItem gridItem)
	{
	}

	[Token(Token = "0x60029B9")]
	[Address(RVA = "0x8F3330", Offset = "0x8F2130", Length = "0x3A7")]
	public override void BuildItem(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem item, int index)
	{
	}

	[Token(Token = "0x60029BA")]
	[Address(RVA = "0x8F36E0", Offset = "0x8F24E0", Length = "0x142")]
	public Panel_CuringStorage()
	{
	}
}
