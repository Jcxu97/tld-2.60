using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Equipment")]
[Token(Token = "0x2000045")]
public class InvEquipment : MonoBehaviour
{
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x20")]
	private InvGameItem[] mItems;

	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x28")]
	private InvAttachmentPoint[] mAttachments;

	[Token(Token = "0x1700002B")]
	public InvGameItem[] equippedItems
	{
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xA1B610", Offset = "0xA1A410", Length = "0x4C7")]
	public InvGameItem Replace(InvBaseItem.Slot slot, InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xA1BAE0", Offset = "0xA1A8E0", Length = "0xC6")]
	public InvGameItem Equip(InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xA1BBB0", Offset = "0xA1A9B0", Length = "0x4D")]
	public InvGameItem Unequip(InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xA1BC00", Offset = "0xA1AA00", Length = "0xB")]
	public InvGameItem Unequip(InvBaseItem.Slot slot)
	{
		return null;
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xA1BC10", Offset = "0xA1AA10", Length = "0x41")]
	public bool HasEquipped(InvGameItem item)
	{
		return false;
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xA1BC60", Offset = "0xA1AA60", Length = "0x88")]
	public bool HasEquipped(InvBaseItem.Slot slot)
	{
		return false;
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xA1BCF0", Offset = "0xA1AAF0", Length = "0x37")]
	public InvGameItem GetItem(InvBaseItem.Slot slot)
	{
		return null;
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InvEquipment()
	{
	}
}
