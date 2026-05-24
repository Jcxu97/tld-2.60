using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x2000876")]
public class NPC_NeedPrefab : MonoBehaviour
{
	[Token(Token = "0x2000877")]
	public enum NPCNeedType
	{
		[Token(Token = "0x40057A6")]
		Food,
		[Token(Token = "0x40057A7")]
		Water,
		[Token(Token = "0x40057A8")]
		Fuel,
		[Token(Token = "0x40057A9")]
		Item
	}

	[Token(Token = "0x4005799")]
	[FieldOffset(Offset = "0x20")]
	public NPCNeedType m_NeedType;

	[Token(Token = "0x400579A")]
	[FieldOffset(Offset = "0x24")]
	public float m_NumCalories;

	[Token(Token = "0x400579B")]
	[FieldOffset(Offset = "0x28")]
	public ItemLiquidVolume m_NumLiters;

	[Token(Token = "0x400579C")]
	[FieldOffset(Offset = "0x30")]
	public float m_NumHours;

	[Token(Token = "0x400579D")]
	[FieldOffset(Offset = "0x34")]
	public int m_NumItems;

	[Token(Token = "0x400579E")]
	[FieldOffset(Offset = "0x38")]
	public string m_ItemPrefabNameMain;

	[Token(Token = "0x400579F")]
	[FieldOffset(Offset = "0x40")]
	public string m_ItemPrefabNameAlt;

	[Token(Token = "0x40057A0")]
	[FieldOffset(Offset = "0x48")]
	public int m_MinTrustToShowNeed;

	[Token(Token = "0x40057A1")]
	[FieldOffset(Offset = "0x4C")]
	public int m_MaxTrustToShowNeed;

	[Token(Token = "0x40057A2")]
	[FieldOffset(Offset = "0x50")]
	public int m_TrustIncrease;

	[Token(Token = "0x40057A3")]
	[FieldOffset(Offset = "0x54")]
	public bool m_IsRepeatable;

	[Token(Token = "0x40057A4")]
	[FieldOffset(Offset = "0x58")]
	public float m_HoursBetweenRepeat;

	[Token(Token = "0x6004D95")]
	[Address(RVA = "0xD8EAD0", Offset = "0xD8D8D0", Length = "0x138")]
	public NPC_NeedPrefabInfo GetPrefabInfo()
	{
		return null;
	}

	[Token(Token = "0x6004D96")]
	[Address(RVA = "0xD8EC10", Offset = "0xD8DA10", Length = "0x47")]
	public NPC_NeedPrefab()
	{
	}
}
