using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x2000875")]
public class NPC_NeedPrefabInfo
{
	[Token(Token = "0x400578D")]
	[FieldOffset(Offset = "0x10")]
	public NPC_NeedPrefab.NPCNeedType m_NeedType;

	[Token(Token = "0x400578E")]
	[FieldOffset(Offset = "0x14")]
	public float m_NumCalories;

	[Token(Token = "0x400578F")]
	[FieldOffset(Offset = "0x18")]
	public ItemLiquidVolume m_NumLiters;

	[Token(Token = "0x4005790")]
	[FieldOffset(Offset = "0x20")]
	public float m_NumHours;

	[Token(Token = "0x4005791")]
	[FieldOffset(Offset = "0x24")]
	public int m_NumItems;

	[Token(Token = "0x4005792")]
	[FieldOffset(Offset = "0x28")]
	public string m_ItemPrefabNameMain;

	[Token(Token = "0x4005793")]
	[FieldOffset(Offset = "0x30")]
	public string m_ItemPrefabNameAlt;

	[Token(Token = "0x4005794")]
	[FieldOffset(Offset = "0x38")]
	public int m_MinTrustToShowNeed;

	[Token(Token = "0x4005795")]
	[FieldOffset(Offset = "0x3C")]
	public int m_MaxTrustToShowNeed;

	[Token(Token = "0x4005796")]
	[FieldOffset(Offset = "0x40")]
	public int m_TrustIncrease;

	[Token(Token = "0x4005797")]
	[FieldOffset(Offset = "0x44")]
	public bool m_IsRepeatable;

	[Token(Token = "0x4005798")]
	[FieldOffset(Offset = "0x48")]
	public float m_HoursBetweenRepeat;

	[Token(Token = "0x6004D94")]
	[Address(RVA = "0xD8EAC0", Offset = "0xD8D8C0", Length = "0x5")]
	public NPC_NeedPrefabInfo()
	{
	}
}
