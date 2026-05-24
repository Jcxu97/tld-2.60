using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Gear/Condition Table")]
[Token(Token = "0x2001411")]
public class ConditionTable : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001412")]
	public class TableEntry
	{
		[Serializable]
		[Token(Token = "0x2001413")]
		public class GearNameSuffixForConditionRange
		{
			[Token(Token = "0x400928C")]
			[FieldOffset(Offset = "0x10")]
			public string m_Suffix;

			[Token(Token = "0x400928D")]
			[FieldOffset(Offset = "0x18")]
			public float m_MinConditionForName;

			[Token(Token = "0x6007FE1")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			public GearNameSuffixForConditionRange()
			{
			}
		}

		[Token(Token = "0x400928B")]
		[FieldOffset(Offset = "0x10")]
		public List<GearNameSuffixForConditionRange> m_NameForConditionRangeList;

		[Token(Token = "0x6007FE0")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public TableEntry()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4009289")]
	[FieldOffset(Offset = "0x18")]
	private TableEntry[] m_Entries;

	[Token(Token = "0x400928A")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, string[]> m_LocIdCache;

	[Token(Token = "0x6007FDC")]
	[Address(RVA = "0x11FE3E0", Offset = "0x11FD1E0", Length = "0x37")]
	public TableEntry GetTableEntry(ConditionTableType type)
	{
		return null;
	}

	[Token(Token = "0x6007FDD")]
	[Address(RVA = "0x11FE420", Offset = "0x11FD220", Length = "0x2DD")]
	public string GetDisplayNameWithCondition(string locID, ConditionTableType type, float normalizedCondition)
	{
		return null;
	}

	[Token(Token = "0x6007FDE")]
	[Address(RVA = "0x11FE700", Offset = "0x11FD500", Length = "0x146")]
	public string GetIconSuffixWithCondition(ConditionTableType type, float normalizedCondition)
	{
		return null;
	}

	[Token(Token = "0x6007FDF")]
	[Address(RVA = "0x11FE850", Offset = "0x11FD650", Length = "0x162")]
	public ConditionTable()
	{
	}
}
