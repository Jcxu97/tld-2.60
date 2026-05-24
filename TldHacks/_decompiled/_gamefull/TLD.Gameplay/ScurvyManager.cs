using System;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x200149B")]
public class ScurvyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200149C")]
	public struct CommonAfflictionDataSet
	{
		[Token(Token = "0x4009569")]
		[FieldOffset(Offset = "0x0")]
		public AfflictionDefinition m_Definition;

		[Token(Token = "0x400956A")]
		[FieldOffset(Offset = "0x8")]
		public AfflictionType m_Type;

		[Token(Token = "0x400956B")]
		[FieldOffset(Offset = "0x10")]
		public LocalizedString m_Gained;

		[Token(Token = "0x400956C")]
		[FieldOffset(Offset = "0x18")]
		public LocalizedString m_Removed;
	}

	[Token(Token = "0x400955A")]
	public static bool s_EnableInNewGame;

	[Token(Token = "0x400955B")]
	[FieldOffset(Offset = "0x20")]
	public AfflictionBodyArea m_AfflictionBodyArea;

	[Token(Token = "0x400955C")]
	[FieldOffset(Offset = "0x28")]
	public AssetReferenceNutrientDefinition m_VitaminC;

	[Token(Token = "0x400955D")]
	[FieldOffset(Offset = "0x30")]
	public float m_RiskThreshold;

	[Token(Token = "0x400955E")]
	[FieldOffset(Offset = "0x34")]
	public float m_CureThreshold;

	[Token(Token = "0x400955F")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_CauseOfDeath;

	[Tooltip("Numbers below zero are considered a debuff and apply to the total carry capacity of the player when they have scurvy")]
	[Token(Token = "0x4009560")]
	[FieldOffset(Offset = "0x40")]
	public ItemWeight m_CarryCapacityDebuff;

	[Token(Token = "0x4009561")]
	[FieldOffset(Offset = "0x48")]
	public float m_StaminaDrainMultiplier;

	[Token(Token = "0x4009562")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FatigueMultiplier;

	[Token(Token = "0x4009563")]
	[FieldOffset(Offset = "0x50")]
	public AK.Wwise.Event m_Audio_OnScurvyAffliction_VO;

	[Token(Token = "0x4009564")]
	[FieldOffset(Offset = "0x58")]
	public LocalizedString m_AfflictionCausedBy;

	[Token(Token = "0x4009565")]
	[FieldOffset(Offset = "0x60")]
	private NutrientDefinition m_NutrientDefinition;

	[Token(Token = "0x4009566")]
	[FieldOffset(Offset = "0x68")]
	public CommonAfflictionDataSet m_AfflictionData;

	[Token(Token = "0x4009567")]
	[FieldOffset(Offset = "0x88")]
	public CommonAfflictionDataSet m_RiskData;

	[Token(Token = "0x4009568")]
	[FieldOffset(Offset = "0xA8")]
	private ScurvyState m_ScurvyState;

	[Token(Token = "0x60082BC")]
	[Address(RVA = "0x123D200", Offset = "0x123C000", Length = "0x63")]
	public void Awake()
	{
	}

	[Token(Token = "0x60082BD")]
	[Address(RVA = "0x123D270", Offset = "0x123C070", Length = "0x1B4")]
	public void Cure()
	{
	}

	[Token(Token = "0x60082BE")]
	[Address(RVA = "0x87D650", Offset = "0x87C450", Length = "0x1B")]
	public string GetCauseOfDeathLocId()
	{
		return null;
	}

	[Token(Token = "0x60082BF")]
	[Address(RVA = "0x123D430", Offset = "0x123C230", Length = "0x1B")]
	public string GetAfflictionCausedById()
	{
		return null;
	}

	[Token(Token = "0x60082C0")]
	[Address(RVA = "0x123D450", Offset = "0x123C250", Length = "0xB")]
	public bool HasAffliction()
	{
		return false;
	}

	[Token(Token = "0x60082C1")]
	[Address(RVA = "0x833B30", Offset = "0x832930", Length = "0xB")]
	public bool HasRisk()
	{
		return false;
	}

	[Token(Token = "0x60082C2")]
	[Address(RVA = "0x123D460", Offset = "0x123C260", Length = "0x1C3")]
	public float GetRiskNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x60082C3")]
	[Address(RVA = "0x123D630", Offset = "0x123C430", Length = "0x200")]
	public float GetVitaminCNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x60082C4")]
	[Address(RVA = "0x123D840", Offset = "0x123C640", Length = "0xC4")]
	public void Deserialize(ScurvySaveDataGobal data)
	{
	}

	[Token(Token = "0x60082C5")]
	[Address(RVA = "0x123D910", Offset = "0x123C710", Length = "0xE4")]
	public ScurvySaveDataGobal Serialize()
	{
		return null;
	}

	[Token(Token = "0x60082C6")]
	[Address(RVA = "0x123DA00", Offset = "0x123C800", Length = "0xAB")]
	public bool MaybeApplyDamage(float dayFraction)
	{
		return false;
	}

	[Token(Token = "0x60082C7")]
	[Address(RVA = "0x123DAB0", Offset = "0x123C8B0", Length = "0x2ED")]
	private void StartAffliction(NutrientDefinition nutrient)
	{
	}

	[Token(Token = "0x60082C8")]
	[Address(RVA = "0x123DDA0", Offset = "0x123CBA0", Length = "0x11D")]
	private void StopAffliction(NutrientDefinition nutrient, AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x60082C9")]
	[Address(RVA = "0x123DEC0", Offset = "0x123CCC0", Length = "0xCF")]
	private void MaybeStartRisk()
	{
	}

	[Token(Token = "0x60082CA")]
	[Address(RVA = "0x123DF90", Offset = "0x123CD90", Length = "0xD6")]
	private void MaybeStopRisk(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x60082CB")]
	[Address(RVA = "0x123E070", Offset = "0x123CE70", Length = "0x4B6")]
	private void Update()
	{
	}

	[Token(Token = "0x60082CC")]
	[Address(RVA = "0x123E530", Offset = "0x123D330", Length = "0x66")]
	public ScurvyManager()
	{
	}
}
