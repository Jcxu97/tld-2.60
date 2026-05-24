using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x200089B")]
public class InventorySaveDataProxy
{
	[Token(Token = "0x40058A5")]
	[FieldOffset(Offset = "0x10")]
	public List<InventoryItemSaveData> m_SerializedItems;

	[Token(Token = "0x40058A6")]
	[FieldOffset(Offset = "0x18")]
	public int[] m_QuickSelectInstanceIDs;

	[Token(Token = "0x40058A7")]
	[FieldOffset(Offset = "0x20")]
	public bool m_ForceOverrideWeight;

	[Token(Token = "0x40058A8")]
	[FieldOffset(Offset = "0x28")]
	public ItemWeight m_OverridedWeight;

	[Token(Token = "0x40058A9")]
	[FieldOffset(Offset = "0x30")]
	public bool m_ConsumedCoffee;

	[Token(Token = "0x40058AA")]
	[FieldOffset(Offset = "0x31")]
	public bool m_ConsumedRosehipTea;

	[Token(Token = "0x40058AB")]
	[FieldOffset(Offset = "0x32")]
	public bool m_ConsumedReishiTea;

	[Token(Token = "0x40058AC")]
	[FieldOffset(Offset = "0x33")]
	public bool m_ConsumedOldMansBeardDressing;

	[Token(Token = "0x40058AD")]
	[FieldOffset(Offset = "0x34")]
	public bool m_SuppressScentIndicator;

	[Token(Token = "0x6004E67")]
	[Address(RVA = "0xDA5D70", Offset = "0xDA4B70", Length = "0x139")]
	public InventorySaveDataProxy()
	{
	}
}
