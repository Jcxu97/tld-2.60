using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Player;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(fileName = "NutrientSettings_Game Mode", menuName = "The Long Dark/Gameplay/Game Mode Nutrient Settings")]
[Token(Token = "0x2001450")]
public class NutrientSettings : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2001451")]
	public class Setting
	{
		[Token(Token = "0x40093B4")]
		[FieldOffset(Offset = "0x10")]
		public AssetReferenceNutrientDefinition m_Nutrient;

		[Token(Token = "0x40093B5")]
		[FieldOffset(Offset = "0x18")]
		public int m_MaxAmount;

		[Token(Token = "0x40093B6")]
		[FieldOffset(Offset = "0x1C")]
		public int m_StartingAmount;

		[Token(Token = "0x40093B7")]
		[FieldOffset(Offset = "0x20")]
		public int m_LossPerDay;

		[Token(Token = "0x6008164")]
		[Address(RVA = "0x121CA80", Offset = "0x121B880", Length = "0x16")]
		public Setting()
		{
		}
	}

	[Token(Token = "0x2001452")]
	private struct RuntimeSetting
	{
		[Token(Token = "0x40093B8")]
		[FieldOffset(Offset = "0x0")]
		public readonly NutrientDefinition m_Nutrient;

		[Token(Token = "0x40093B9")]
		[FieldOffset(Offset = "0x8")]
		public readonly int m_MaxAmount;

		[Token(Token = "0x40093BA")]
		[FieldOffset(Offset = "0xC")]
		public readonly int m_StartingAmount;

		[Token(Token = "0x40093BB")]
		[FieldOffset(Offset = "0x10")]
		public readonly int m_LossPerDay;

		[Token(Token = "0x6008165")]
		[Address(RVA = "0x121CAA0", Offset = "0x121B8A0", Length = "0x62")]
		public RuntimeSetting(NutrientDefinition nutrient, int maxAmount, int startingAmount, int lossPerDay)
		{
			m_Nutrient = null;
			m_MaxAmount = 0;
			m_StartingAmount = 0;
			m_LossPerDay = 0;
		}
	}

	[SerializeField]
	[Token(Token = "0x40093B2")]
	[FieldOffset(Offset = "0x18")]
	private Setting[] m_Settings;

	[NonSerialized]
	[Token(Token = "0x40093B3")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<RuntimeSetting> m_ResolvedSettings;

	[Token(Token = "0x600815D")]
	[Address(RVA = "0x121C0A0", Offset = "0x121AEA0", Length = "0x59")]
	public bool HasSettings()
	{
		return false;
	}

	[Token(Token = "0x600815E")]
	[Address(RVA = "0x121C100", Offset = "0x121AF00", Length = "0x109")]
	public void ApplyStartingValues(Nutrition nutritionComponent)
	{
	}

	[Token(Token = "0x600815F")]
	[Address(RVA = "0x121C210", Offset = "0x121B010", Length = "0x139")]
	public NutrientDefinition GetNutrientDefinitionFromName(string name)
	{
		return null;
	}

	[Token(Token = "0x6008160")]
	[Address(RVA = "0x121C350", Offset = "0x121B150", Length = "0x20C")]
	public int GetDefaultMaxAmount(NutrientDefinition nutrient)
	{
		return 0;
	}

	[Token(Token = "0x6008161")]
	[Address(RVA = "0x121C560", Offset = "0x121B360", Length = "0x21A")]
	public int GetDefaultLossRatePerDay(NutrientDefinition nutrient)
	{
		return 0;
	}

	[Token(Token = "0x6008162")]
	[Address(RVA = "0x121C780", Offset = "0x121B580", Length = "0x234")]
	private void ResolveReferencesIfNeeded()
	{
	}

	[Token(Token = "0x6008163")]
	[Address(RVA = "0x121C9C0", Offset = "0x121B7C0", Length = "0xB6")]
	public NutrientSettings()
	{
	}
}
