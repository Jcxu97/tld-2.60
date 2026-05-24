using Cpp2ILInjected;
using TLD.AddressableAssets;
using TLD.IntBackedUnit;
using TLD.Utility;
using UnityEngine;

[CreateAssetMenu(order = 10002)]
[Token(Token = "0x20004F3")]
public class AfflictionDefinition : ScriptableObject
{
	[Token(Token = "0x20004F4")]
	public enum RemedyIndex
	{
		[Token(Token = "0x4002D6F")]
		FirstRemedy,
		[Token(Token = "0x4002D70")]
		SecondRemedy
	}

	[Token(Token = "0x4002D5B")]
	[FieldOffset(Offset = "0x18")]
	public AfflictionType m_AfflictionType;

	[Token(Token = "0x4002D5C")]
	[FieldOffset(Offset = "0x20")]
	public AfflictionRemedies m_AlternateRemedies;

	[Token(Token = "0x4002D5D")]
	[FieldOffset(Offset = "0x28")]
	public string m_DescriptionLocId;

	[Token(Token = "0x4002D5E")]
	[FieldOffset(Offset = "0x30")]
	public string m_DisplayNameLocId;

	[Token(Token = "0x4002D5F")]
	[FieldOffset(Offset = "0x38")]
	public float m_HPReduction;

	[SpriteAtlasIconName]
	[Token(Token = "0x4002D60")]
	[FieldOffset(Offset = "0x40")]
	public string m_IconName;

	[Token(Token = "0x4002D61")]
	[FieldOffset(Offset = "0x48")]
	public AfflictionRemedies m_Remedies;

	[Token(Token = "0x4002D62")]
	[FieldOffset(Offset = "0x50")]
	public float m_RestHoursRequired;

	[Token(Token = "0x4002D63")]
	[FieldOffset(Offset = "0x58")]
	public string m_TreatmentDescriptionLocId;

	[Token(Token = "0x4002D64")]
	[FieldOffset(Offset = "0x60")]
	public string m_TreatmentLocId;

	[Token(Token = "0x4002D65")]
	[FieldOffset(Offset = "0x68")]
	public string m_NPCTreatmentLocId;

	[Token(Token = "0x4002D66")]
	[FieldOffset(Offset = "0x70")]
	public ItemLiquidVolume m_WaterRequired;

	[Token(Token = "0x4002D67")]
	[FieldOffset(Offset = "0x78")]
	public RemedyIndex m_StandardRemedyUsedForSFX;

	[Token(Token = "0x4002D68")]
	[FieldOffset(Offset = "0x7C")]
	public RemedyIndex m_AlternateRemedyUsedForSFX;

	[Header("Progress ui overrides")]
	[Token(Token = "0x4002D69")]
	[FieldOffset(Offset = "0x80")]
	public string m_OnHealSFXOverride;

	[Token(Token = "0x4002D6A")]
	[FieldOffset(Offset = "0x88")]
	public string m_OnHealLocIdOverride;

	[Token(Token = "0x4002D6B")]
	[FieldOffset(Offset = "0x90")]
	public float m_OnHealDurationSecondsOverride;

	[Header("Diagnose animation overrides")]
	[Token(Token = "0x4002D6C")]
	[FieldOffset(Offset = "0x98")]
	public AssetReferenceTimeline m_HealedDiagnoseExitLeftTimelineOverride;

	[Token(Token = "0x4002D6D")]
	[FieldOffset(Offset = "0xA0")]
	public AssetReferenceTimeline m_HealedDiagnoseExitRightTimelineOverride;

	[Token(Token = "0x600257B")]
	[Address(RVA = "0x87C350", Offset = "0x87B150", Length = "0x121")]
	public string GetStandardMessageLocIdUsed()
	{
		return null;
	}

	[Token(Token = "0x600257C")]
	[Address(RVA = "0x87C480", Offset = "0x87B280", Length = "0x121")]
	public string GetAlternateMessageLocIdUsed()
	{
		return null;
	}

	[Token(Token = "0x600257D")]
	[Address(RVA = "0x87C5B0", Offset = "0x87B3B0", Length = "0x118")]
	public string GetStandardAudioUsed()
	{
		return null;
	}

	[Token(Token = "0x600257E")]
	[Address(RVA = "0x87C6D0", Offset = "0x87B4D0", Length = "0x118")]
	public string GetAlternateAudioUsed()
	{
		return null;
	}

	[Token(Token = "0x600257F")]
	[Address(RVA = "0x87C7F0", Offset = "0x87B5F0", Length = "0x16C")]
	public float GetStandardDurationdUsed()
	{
		return 0f;
	}

	[Token(Token = "0x6002580")]
	[Address(RVA = "0x87C960", Offset = "0x87B760", Length = "0x16C")]
	public float GetAlternateDurationUsed()
	{
		return 0f;
	}

	[Token(Token = "0x6002581")]
	[Address(RVA = "0x87CAD0", Offset = "0x87B8D0", Length = "0xFB")]
	private FirstAidItem GetFirstAidItemUsed(AfflictionRemedy remedy)
	{
		return null;
	}

	[Token(Token = "0x6002582")]
	[Address(RVA = "0x87CBD0", Offset = "0x87B9D0", Length = "0x112")]
	public AfflictionDefinition()
	{
	}
}
