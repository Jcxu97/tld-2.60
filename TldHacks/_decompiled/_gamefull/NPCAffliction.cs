using System;
using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Serializable]
[Token(Token = "0x2000524")]
public class NPCAffliction
{
	[Token(Token = "0x2000525")]
	public enum TreatmentSelected
	{
		[Token(Token = "0x4002F68")]
		None,
		[Token(Token = "0x4002F69")]
		Standard,
		[Token(Token = "0x4002F6A")]
		Alternate
	}

	[Token(Token = "0x4002F5C")]
	[FieldOffset(Offset = "0x10")]
	public AfflictionDefinition m_Definition;

	[Token(Token = "0x4002F5D")]
	[FieldOffset(Offset = "0x18")]
	public AfflictionBodyArea m_Location;

	[Token(Token = "0x4002F5E")]
	[FieldOffset(Offset = "0x20")]
	public string m_CauseLocId;

	[NonSerialized]
	[Token(Token = "0x4002F5F")]
	[FieldOffset(Offset = "0x28")]
	public TreatmentSelected m_TreatmentSelected;

	[Token(Token = "0x4002F60")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_Remedy1Complete;

	[Token(Token = "0x4002F61")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_Remedy2Complete;

	[Token(Token = "0x4002F62")]
	[FieldOffset(Offset = "0x2E")]
	private bool m_AlternateRemedy1Complete;

	[Token(Token = "0x4002F63")]
	[FieldOffset(Offset = "0x2F")]
	private bool m_AlternateRemedy2Complete;

	[Token(Token = "0x4002F64")]
	[FieldOffset(Offset = "0x30")]
	private ItemLiquidVolume m_WaterLiters;

	[Token(Token = "0x4002F65")]
	[FieldOffset(Offset = "0x38")]
	private float m_RestHours;

	[Token(Token = "0x4002F66")]
	[FieldOffset(Offset = "0x3C")]
	private int m_PerTypeIndex;

	[Token(Token = "0x600273B")]
	[Address(RVA = "0x8AEEF0", Offset = "0x8ADCF0", Length = "0xE")]
	public bool IsRemedyComplete(int index)
	{
		return false;
	}

	[Token(Token = "0x600273C")]
	[Address(RVA = "0x8AEF00", Offset = "0x8ADD00", Length = "0xE")]
	public bool IsAlternateRemedyComplete(int index)
	{
		return false;
	}

	[Token(Token = "0x600273D")]
	[Address(RVA = "0x8AEF10", Offset = "0x8ADD10", Length = "0x3D")]
	public bool SupportAlternateTreatment()
	{
		return false;
	}

	[Token(Token = "0x600273E")]
	[Address(RVA = "0x63F4E0", Offset = "0x63E2E0", Length = "0x4")]
	public int GetPerTypeIndex()
	{
		return 0;
	}

	[Token(Token = "0x600273F")]
	[Address(RVA = "0x620C80", Offset = "0x61FA80", Length = "0x4")]
	public void SetPerTypeIndex(int index)
	{
	}

	[Token(Token = "0x6002740")]
	[Address(RVA = "0x8AEF50", Offset = "0x8ADD50", Length = "0x3F")]
	public AfflictionRemedy GetStandardRemedy(int index)
	{
		return null;
	}

	[Token(Token = "0x6002741")]
	[Address(RVA = "0x8AEF90", Offset = "0x8ADD90", Length = "0x3F")]
	public AfflictionRemedy GetAlternateRemedy(int index)
	{
		return null;
	}

	[Token(Token = "0x6002742")]
	[Address(RVA = "0x8AEFD0", Offset = "0x8ADDD0", Length = "0x109")]
	public ItemLiquidVolume GetTreatmentWaterVolumeLiters(NPC npc)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002743")]
	[Address(RVA = "0x8AF0E0", Offset = "0x8ADEE0", Length = "0x1A9")]
	public void ApplyStandardRemedy(int remedyIndex, NPC npc)
	{
	}

	[Token(Token = "0x6002744")]
	[Address(RVA = "0x8AF290", Offset = "0x8AE090", Length = "0x1A9")]
	public void ApplyAlternateRemedy(int remedyIndex, NPC npc)
	{
	}

	[Token(Token = "0x6002745")]
	[Address(RVA = "0x8AF440", Offset = "0x8AE240", Length = "0x74")]
	public bool IsTreated()
	{
		return false;
	}

	[Token(Token = "0x6002746")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	public ItemLiquidVolume GetWaterLitersUsed()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002747")]
	[Address(RVA = "0x6208B0", Offset = "0x61F6B0", Length = "0x6")]
	public float GetRestHoursCompleted()
	{
		return 0f;
	}

	[Token(Token = "0x6002748")]
	[Address(RVA = "0x8AF4C0", Offset = "0x8AE2C0", Length = "0x25C")]
	public ItemLiquidVolume GetWaterRequiredForTreatment(NPC npc)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002749")]
	[Address(RVA = "0x8AF720", Offset = "0x8AE520", Length = "0x15E")]
	public NPCAfflictionSavedData Save()
	{
		return null;
	}

	[Token(Token = "0x600274A")]
	[Address(RVA = "0x8AF880", Offset = "0x8AE680", Length = "0x8D")]
	public void Load(NPCAfflictionSavedData saveData)
	{
	}

	[Token(Token = "0x600274B")]
	[Address(RVA = "0x8AF910", Offset = "0x8AE710", Length = "0x2EB")]
	public void UseWater(NPC npc, ItemLiquidVolume waterLiters)
	{
	}

	[Token(Token = "0x600274C")]
	[Address(RVA = "0x8AFC00", Offset = "0x8AEA00", Length = "0xB")]
	private void RestHours(float restHours)
	{
	}

	[Token(Token = "0x600274D")]
	[Address(RVA = "0x8AFC10", Offset = "0x8AEA10", Length = "0x12")]
	private void UseStandardRemedy(int remedyIndex)
	{
	}

	[Token(Token = "0x600274E")]
	[Address(RVA = "0x8AFC30", Offset = "0x8AEA30", Length = "0x12")]
	private void UseAlternateRemedy(int remedyIndex)
	{
	}

	[Token(Token = "0x600274F")]
	[Address(RVA = "0x8AFC50", Offset = "0x8AEA50", Length = "0x60")]
	public bool RequiresRemdy()
	{
		return false;
	}

	[Token(Token = "0x6002750")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public NPCAffliction()
	{
	}
}
