using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Gear/Inventory Icons/Condition")]
[Token(Token = "0x2001437")]
public class GearItemInventoryIconConditionData : GearItemInventoryIconData
{
	[Serializable]
	[Token(Token = "0x2001438")]
	public struct Entry
	{
		[Token(Token = "0x4009366")]
		[FieldOffset(Offset = "0x0")]
		public string m_Suffix;

		[Token(Token = "0x4009367")]
		[FieldOffset(Offset = "0x8")]
		public Texture2D m_Icon;
	}

	[SerializeField]
	[Token(Token = "0x4009363")]
	[FieldOffset(Offset = "0x18")]
	private ConditionTableType m_ConditionType;

	[SerializeField]
	[Token(Token = "0x4009364")]
	[FieldOffset(Offset = "0x20")]
	private Texture2D m_Default;

	[SerializeField]
	[Token(Token = "0x4009365")]
	[FieldOffset(Offset = "0x28")]
	private Entry[] m_Entries;

	[Token(Token = "0x600810E")]
	[Address(RVA = "0x12150E0", Offset = "0x1213EE0", Length = "0x64")]
	public override Texture2D GetInventoryIcon(GearItem item)
	{
		return null;
	}

	[Token(Token = "0x600810F")]
	[Address(RVA = "0x1215150", Offset = "0x1213F50", Length = "0x1F7")]
	public override Texture2D GetInventoryIcon(float conditionPercent)
	{
		return null;
	}

	[Token(Token = "0x6008110")]
	[Address(RVA = "0x1215350", Offset = "0x1214150", Length = "0x187")]
	private static string GetSuffix(ConditionTable.TableEntry conditionTable, float conditionPercent)
	{
		return null;
	}

	[Token(Token = "0x6008111")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public GearItemInventoryIconConditionData()
	{
	}
}
