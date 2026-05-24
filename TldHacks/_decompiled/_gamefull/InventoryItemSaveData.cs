using Cpp2ILInjected;

[Token(Token = "0x200089A")]
public class InventoryItemSaveData
{
	[Token(Token = "0x40058A3")]
	[FieldOffset(Offset = "0x10")]
	public string m_PrefabName;

	[Token(Token = "0x40058A4")]
	[FieldOffset(Offset = "0x18")]
	public string m_SerializedGear;

	[Token(Token = "0x6004E66")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InventoryItemSaveData()
	{
	}
}
