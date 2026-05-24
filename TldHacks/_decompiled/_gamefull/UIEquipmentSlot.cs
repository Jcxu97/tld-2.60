using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/UI Equipment Slot")]
[Token(Token = "0x200003D")]
public class UIEquipmentSlot : UIItemSlot
{
	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x60")]
	public InvEquipment equipment;

	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x68")]
	public InvBaseItem.Slot slot;

	[Token(Token = "0x17000026")]
	protected override InvGameItem observedItem
	{
		[Token(Token = "0x6000322")]
		[Address(RVA = "0xA180B0", Offset = "0xA16EB0", Length = "0x10E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xA181C0", Offset = "0xA16FC0", Length = "0x105")]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xA182D0", Offset = "0xA170D0", Length = "0x7")]
	public UIEquipmentSlot()
	{
	}
}
