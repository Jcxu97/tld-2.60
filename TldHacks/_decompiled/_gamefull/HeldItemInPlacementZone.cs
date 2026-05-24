using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.Logging;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x2000587")]
public class HeldItemInPlacementZone : MonoBehaviour
{
	[Token(Token = "0x40032EC")]
	public static HeldItemInPlacementZone s_ActiveZone;

	[Token(Token = "0x40032ED")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x40032EE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_ZoneToPlace;

	[FormerlySerializedAs("m_OnlyShashLitLightSources")]
	[Token(Token = "0x40032EF")]
	[FieldOffset(Offset = "0x28")]
	public bool m_OnlyStashLitLightSources;

	[Token(Token = "0x40032F0")]
	[FieldOffset(Offset = "0x30")]
	private GearItem m_DroppedItem;

	[Token(Token = "0x40032F1")]
	[FieldOffset(Offset = "0x38")]
	private bool m_NeedsContinuousPositionUpdate;

	[Token(Token = "0x6002A9D")]
	[Address(RVA = "0x907390", Offset = "0x906190", Length = "0x71")]
	private void Update()
	{
	}

	[Token(Token = "0x6002A9E")]
	[Address(RVA = "0x907410", Offset = "0x906210", Length = "0x238")]
	private void MaybeUpdateDroppedItemPosition()
	{
	}

	[Token(Token = "0x6002A9F")]
	[Address(RVA = "0x907650", Offset = "0x906450", Length = "0x15D")]
	public void MaybeHandleItemInHands()
	{
	}

	[Token(Token = "0x6002AA0")]
	[Address(RVA = "0x9077B0", Offset = "0x9065B0", Length = "0xA")]
	public void MaybeProcessPickingUpPlacedItem()
	{
	}

	[Token(Token = "0x6002AA1")]
	[Address(RVA = "0x9077C0", Offset = "0x9065C0", Length = "0xA")]
	public void MaybeProcessPickingUpPlacedItemImmediate()
	{
	}

	[Token(Token = "0x6002AA2")]
	[Address(RVA = "0x9077D0", Offset = "0x9065D0", Length = "0x283")]
	private void ProcessPickingUpPlacedItem(bool immediate)
	{
	}

	[Token(Token = "0x6002AA3")]
	[Address(RVA = "0x907A60", Offset = "0x906860", Length = "0xCA")]
	public bool IsValid()
	{
		return false;
	}

	[Token(Token = "0x6002AA4")]
	[Address(RVA = "0x907B30", Offset = "0x906930", Length = "0x20F")]
	public bool IsValidItemToPlace(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x6002AA5")]
	[Address(RVA = "0x907D40", Offset = "0x906B40", Length = "0x542")]
	private void ProcessMovingHeldItemToZone()
	{
	}

	[Token(Token = "0x6002AA6")]
	[Address(RVA = "0x908290", Offset = "0x907090", Length = "0x126")]
	public ItemWeight GetWeightOfPlacedItem()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6002AA7")]
	[Address(RVA = "0x9083C0", Offset = "0x9071C0", Length = "0x1C1")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002AA8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HeldItemInPlacementZone()
	{
	}
}
