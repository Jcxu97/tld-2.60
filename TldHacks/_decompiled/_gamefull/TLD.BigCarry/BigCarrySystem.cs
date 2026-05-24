using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.Logging;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.BigCarry;

[Token(Token = "0x20014D3")]
public class BigCarrySystem : MonoBehaviour
{
	[Token(Token = "0x20014D4")]
	private enum State
	{
		[Token(Token = "0x4009695")]
		Active,
		[Token(Token = "0x4009696")]
		Removed
	}

	[Token(Token = "0x20014D5")]
	private struct BigCarryItemInfo
	{
		[Token(Token = "0x4009697")]
		[FieldOffset(Offset = "0x0")]
		public BigCarryItem m_Handle;

		[Token(Token = "0x4009698")]
		[FieldOffset(Offset = "0x8")]
		public State m_State;

		[Token(Token = "0x4009699")]
		[FieldOffset(Offset = "0xC")]
		public bool m_TrackRemoval;
	}

	[Token(Token = "0x4009686")]
	public static readonly LogFilter s_LogFilter;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4009688")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x400968C")]
	[FieldOffset(Offset = "0x40")]
	private GearItem m_DummyGearItem;

	[Token(Token = "0x400968D")]
	[FieldOffset(Offset = "0x48")]
	private bool m_ShowEquippedItem;

	[Token(Token = "0x400968E")]
	[FieldOffset(Offset = "0x50")]
	private GearItem m_PreviousEquippedItem;

	[Token(Token = "0x400968F")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsRestoringCarry;

	[Token(Token = "0x4009690")]
	[FieldOffset(Offset = "0x59")]
	private bool m_ReplacedOriginalAfterRestore;

	[Token(Token = "0x4009691")]
	private const string ITEM_ROOT = "DesignBigCarry";

	[Token(Token = "0x4009692")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, BigCarryItemInfo> m_BigCarryItems;

	[Token(Token = "0x4009693")]
	[FieldOffset(Offset = "0x68")]
	private Transform m_BigCarryItemRoot;

	[Token(Token = "0x17000B67")]
	[field: Token(Token = "0x4009687")]
	public static BigCarrySystem Instance
	{
		[Token(Token = "0x600836D")]
		[Address(RVA = "0x1247F60", Offset = "0x1246D60", Length = "0x54")]
		get;
		[Token(Token = "0x600836E")]
		[Address(RVA = "0x1247FC0", Offset = "0x1246DC0", Length = "0xB7")]
		private set;
	}

	[Token(Token = "0x17000B68")]
	[field: Token(Token = "0x4009689")]
	[field: FieldOffset(Offset = "0x28")]
	public bool AllowTransferBetweenZones
	{
		[Token(Token = "0x600836F")]
		[Address(RVA = "0xB97C80", Offset = "0xB96A80", Length = "0x5")]
		get;
		[Token(Token = "0x6008370")]
		[Address(RVA = "0xE3CD40", Offset = "0xE3BB40", Length = "0x4")]
		set;
	}

	[Token(Token = "0x17000B69")]
	[field: Token(Token = "0x400968A")]
	[field: FieldOffset(Offset = "0x30")]
	public BigCarryItem CarriedItem
	{
		[Token(Token = "0x6008371")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get;
		[Token(Token = "0x6008372")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000B6A")]
	[field: Token(Token = "0x400968B")]
	[field: FieldOffset(Offset = "0x38")]
	public bool IsDroppingItem
	{
		[Token(Token = "0x6008373")]
		[Address(RVA = "0x8BE400", Offset = "0x8BD200", Length = "0x5")]
		get;
		[Token(Token = "0x6008374")]
		[Address(RVA = "0x8BE410", Offset = "0x8BD210", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x6008375")]
	[Address(RVA = "0x1248080", Offset = "0x1246E80", Length = "0x4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008376")]
	[Address(RVA = "0x12480D0", Offset = "0x1246ED0", Length = "0x45")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008377")]
	[Address(RVA = "0x1248120", Offset = "0x1246F20", Length = "0x19A")]
	private void Update()
	{
	}

	[Token(Token = "0x6008378")]
	[Address(RVA = "0x12482C0", Offset = "0x12470C0", Length = "0x240")]
	public void Carry(BigCarryItem carryItem)
	{
	}

	[Token(Token = "0x6008379")]
	[Address(RVA = "0x1248510", Offset = "0x1247310", Length = "0x241")]
	private void HandleItemInHands()
	{
	}

	[Token(Token = "0x600837A")]
	[Address(RVA = "0x1248760", Offset = "0x1247560", Length = "0xA")]
	private void BeginCarry()
	{
	}

	[Token(Token = "0x600837B")]
	[Address(RVA = "0x1248770", Offset = "0x1247570", Length = "0xF4")]
	private void PrepareCarry(bool restoringCarry)
	{
	}

	[Token(Token = "0x600837C")]
	[Address(RVA = "0x1248870", Offset = "0x1247670", Length = "0x14B")]
	private void SetupCarry()
	{
	}

	[Token(Token = "0x600837D")]
	[Address(RVA = "0x12489C0", Offset = "0x12477C0", Length = "0x479")]
	private void SetupFPH()
	{
	}

	[Token(Token = "0x600837E")]
	[Address(RVA = "0x1248E40", Offset = "0x1247C40", Length = "0x1C8")]
	public void Restore(BigCarryItem bigCarryItem, BigCarryItemSaveData saveData, bool replacedOriginal)
	{
	}

	[Token(Token = "0x600837F")]
	[Address(RVA = "0x1249010", Offset = "0x1247E10", Length = "0xC")]
	public bool MaybeDrop()
	{
		return false;
	}

	[Token(Token = "0x6008380")]
	[Address(RVA = "0x1249020", Offset = "0x1247E20", Length = "0xC")]
	public bool MaybeDropImmediate()
	{
		return false;
	}

	[Token(Token = "0x6008381")]
	[Address(RVA = "0x1249030", Offset = "0x1247E30", Length = "0x56F")]
	public bool Drop(CarryDropOptions opts)
	{
		return false;
	}

	[Token(Token = "0x6008382")]
	[Address(RVA = "0x12495A0", Offset = "0x12483A0", Length = "0x4D8")]
	private void FinishDrop()
	{
	}

	[Token(Token = "0x6008383")]
	[Address(RVA = "0x1249A80", Offset = "0x1248880", Length = "0x27C")]
	public bool MaybeBeginPlacement()
	{
		return false;
	}

	[Token(Token = "0x6008384")]
	[Address(RVA = "0x1249D00", Offset = "0x1248B00", Length = "0xC2")]
	public void CancelPlacement()
	{
	}

	[Token(Token = "0x6008385")]
	[Address(RVA = "0x1249DD0", Offset = "0x1248BD0", Length = "0x11B")]
	public void PrepareForSceneTransition()
	{
	}

	[Token(Token = "0x6008386")]
	[Address(RVA = "0x1249EF0", Offset = "0x1248CF0", Length = "0x1D2")]
	public bool CanPerformInteractionWhileCarrying(IInteraction interaction)
	{
		return false;
	}

	[Token(Token = "0x6008387")]
	[Address(RVA = "0x124A0D0", Offset = "0x1248ED0", Length = "0x54E")]
	public void ShowError(CarryDisplayError error)
	{
	}

	[Token(Token = "0x6008388")]
	[Address(RVA = "0x124A620", Offset = "0x1249420", Length = "0x90")]
	public BigCarryItem SpawnBigCarryItem(string addressablesKey)
	{
		return null;
	}

	[Token(Token = "0x6008389")]
	[Address(RVA = "0x124A6B0", Offset = "0x12494B0", Length = "0x1C2")]
	public void AddItem(BigCarryItem item, bool trackRemoval)
	{
	}

	[Token(Token = "0x600838A")]
	[Address(RVA = "0x124A880", Offset = "0x1249680", Length = "0x36C")]
	public void RemoveItem(BigCarryItem item)
	{
	}

	[Token(Token = "0x600838B")]
	[Address(RVA = "0x124ABF0", Offset = "0x12499F0", Length = "0x265")]
	private void UpdateItems()
	{
	}

	[Token(Token = "0x600838C")]
	[Address(RVA = "0x124AE60", Offset = "0x1249C60", Length = "0x1B5")]
	public Transform FindOrCreateBigCarryItemRoot()
	{
		return null;
	}

	[Token(Token = "0x600838D")]
	[Address(RVA = "0x124B020", Offset = "0x1249E20", Length = "0x32C")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600838E")]
	[Address(RVA = "0x124B350", Offset = "0x124A150", Length = "0x1F7")]
	public void Deserialize(string data)
	{
	}

	[Token(Token = "0x600838F")]
	[Address(RVA = "0x124B550", Offset = "0x124A350", Length = "0x67D")]
	private bool TryFindBigCarryItemInPlayer(string guid, out BigCarryItem bigCarryItem)
	{
		bigCarryItem = null;
		return false;
	}

	[Token(Token = "0x6008390")]
	[Address(RVA = "0x124BBD0", Offset = "0x124A9D0", Length = "0x5BE")]
	public string SerializeScene()
	{
		return null;
	}

	[Token(Token = "0x6008391")]
	[Address(RVA = "0x124C190", Offset = "0x124AF90", Length = "0x6A8")]
	public void DeserializeScene(string data)
	{
	}

	[Token(Token = "0x6008392")]
	[Address(RVA = "0x124C840", Offset = "0x124B640", Length = "0x1EE")]
	private BigCarryItem FindOrCreateBigCarryItem(string guid, string addressablesKey, out bool instantiated)
	{
		instantiated = default(bool);
		return null;
	}

	[Token(Token = "0x6008393")]
	[Address(RVA = "0x124CA30", Offset = "0x124B830", Length = "0x197")]
	public void DeserializePostSceneLoad()
	{
	}

	[Token(Token = "0x6008394")]
	[Address(RVA = "0x124CBD0", Offset = "0x124B9D0", Length = "0x16A")]
	public BigCarrySystem()
	{
	}
}
