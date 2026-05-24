using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

namespace TLD.BigCarry;

[Token(Token = "0x20014D7")]
public class BigCarrySystemItemSaveData
{
	[Token(Token = "0x400969C")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x400969D")]
	[FieldOffset(Offset = "0x18")]
	public AssetReference m_AssetReference;

	[Token(Token = "0x400969E")]
	[FieldOffset(Offset = "0x20")]
	public BigCarryItemSaveData m_ItemSaveData;

	[Token(Token = "0x400969F")]
	[FieldOffset(Offset = "0x28")]
	public int m_PreviousEquippedItemInstanceID;

	[Token(Token = "0x6008397")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BigCarrySystemItemSaveData()
	{
	}
}
