using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/UI Storage Slot")]
[Token(Token = "0x2000040")]
public class UIStorageSlot : UIItemSlot
{
	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x60")]
	public UIItemStorage storage;

	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x68")]
	public int slot;

	[Token(Token = "0x17000029")]
	protected override InvGameItem observedItem
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA1A020", Offset = "0xA18E20", Length = "0x16A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xA1A190", Offset = "0xA18F90", Length = "0x1A9")]
	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xA182D0", Offset = "0xA170D0", Length = "0x7")]
	public UIStorageSlot()
	{
	}
}
