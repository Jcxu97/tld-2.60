using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(fileName = "Nutrient_New Nutrient Type", menuName = "The Long Dark/Gameplay/Nutrient Definition")]
[Token(Token = "0x200144D")]
public class NutrientDefinition : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200144E")]
	public struct SourceLevel
	{
		[Token(Token = "0x40093B0")]
		[FieldOffset(Offset = "0x0")]
		public int m_Level;

		[Token(Token = "0x40093B1")]
		[FieldOffset(Offset = "0x8")]
		public LocalizedString m_Label;
	}

	[SerializeField]
	[Token(Token = "0x40093AE")]
	[FieldOffset(Offset = "0x18")]
	private LocalizedString m_NutrientName;

	[Tooltip("List sorted from most to least")]
	[SerializeField]
	[Token(Token = "0x40093AF")]
	[FieldOffset(Offset = "0x20")]
	private List<SourceLevel> m_SourceLevels;

	[Token(Token = "0x17000B2F")]
	public LocalizedString Name
	{
		[Token(Token = "0x6008159")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600815A")]
	[Address(RVA = "0x121BF50", Offset = "0x121AD50", Length = "0xF5")]
	public string GetLabelForSourceLevel(int sourceLevel)
	{
		return null;
	}

	[Token(Token = "0x600815B")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public NutrientDefinition()
	{
	}
}
