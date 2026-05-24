using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x200087A")]
public class NPC_NeedTracker : MonoBehaviour
{
	[Token(Token = "0x40057B2")]
	[FieldOffset(Offset = "0x20")]
	public string m_NPCTrustID;

	[Token(Token = "0x40057B3")]
	[FieldOffset(Offset = "0x28")]
	public bool m_NoTrustDecayUntilPlayerInteraction;

	[Token(Token = "0x40057B4")]
	[FieldOffset(Offset = "0x30")]
	public NPC_NeedPrefab[] m_DefaultNeeds;

	[HideInInspector]
	[Token(Token = "0x40057B5")]
	[FieldOffset(Offset = "0x38")]
	public List<NeedPrefabSaveData> m_NeedPrefabsActive;

	[Token(Token = "0x40057B6")]
	[FieldOffset(Offset = "0x40")]
	private bool m_HasBeenInteractedWith;

	[Token(Token = "0x40057B7")]
	private static NeedTrackerSaveData m_NeedTrackerSaveData;

	[Token(Token = "0x6004D99")]
	[Address(RVA = "0xD8EC60", Offset = "0xD8DA60", Length = "0xAD")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004D9A")]
	[Address(RVA = "0xD8ED10", Offset = "0xD8DB10", Length = "0x21B")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004D9B")]
	[Address(RVA = "0xD8EF30", Offset = "0xD8DD30", Length = "0x178")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004D9C")]
	[Address(RVA = "0xD8F0B0", Offset = "0xD8DEB0", Length = "0x12")]
	public bool IsTrustDecayAllowed()
	{
		return false;
	}

	[Token(Token = "0x6004D9D")]
	[Address(RVA = "0x76D350", Offset = "0x76C150", Length = "0x5")]
	public void SetHasBeenInteractedWith()
	{
	}

	[Token(Token = "0x6004D9E")]
	[Address(RVA = "0xD8F0D0", Offset = "0xD8DED0", Length = "0x3A3")]
	public void AddNeed(NPC_NeedPrefab needToAdd)
	{
	}

	[Token(Token = "0x6004D9F")]
	[Address(RVA = "0xD8F480", Offset = "0xD8E280", Length = "0x150")]
	public void RemoveNeed(NPC_NeedPrefab needToAdd)
	{
	}

	[Token(Token = "0x6004DA0")]
	[Address(RVA = "0xD8F5E0", Offset = "0xD8E3E0", Length = "0x145")]
	public bool IsNeedMet(NPC_NeedPrefab needToCheck)
	{
		return false;
	}

	[Token(Token = "0x6004DA1")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool IsTrustWithinNeedRange(NeedPrefabSaveData needData)
	{
		return false;
	}

	[Token(Token = "0x6004DA2")]
	[Address(RVA = "0xD8F730", Offset = "0xD8E530", Length = "0xB3")]
	public bool IsReadyToBeCompleted(NeedPrefabSaveData needData)
	{
		return false;
	}

	[Token(Token = "0x6004DA3")]
	[Address(RVA = "0xD8F7F0", Offset = "0xD8E5F0", Length = "0x3AA")]
	public string GetStringForNeed(NeedPrefabSaveData needData)
	{
		return null;
	}

	[Token(Token = "0x6004DA4")]
	[Address(RVA = "0xD8FBA0", Offset = "0xD8E9A0", Length = "0xA9")]
	public bool GearItemMeetsCurrentNeed(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6004DA5")]
	[Address(RVA = "0xD8FC50", Offset = "0xD8EA50", Length = "0xC9")]
	public int GetTrustIncreaseFromItemList(List<GearItem> gearList, float numCalories, ItemLiquidVolume numLitersWater, float numHoursFuel)
	{
		return 0;
	}

	[Token(Token = "0x6004DA6")]
	[Address(RVA = "0xD8FD20", Offset = "0xD8EB20", Length = "0xC7")]
	public void GiveItemsToCompleteNeeds(List<GearItem> gearList, float numCalories, ItemLiquidVolume numLitersWater, float numHoursFuel)
	{
	}

	[Token(Token = "0x6004DA7")]
	[Address(RVA = "0xD8EC60", Offset = "0xD8DA60", Length = "0xAD")]
	private void AddDefaultNeeds()
	{
	}

	[Token(Token = "0x6004DA8")]
	[Address(RVA = "0xD8FDF0", Offset = "0xD8EBF0", Length = "0x100")]
	private void CompleteNeedAtIndex(int index, int trustIncrease)
	{
	}

	[Token(Token = "0x6004DA9")]
	[Address(RVA = "0xD8FF00", Offset = "0xD8ED00", Length = "0x16F")]
	public NPC_NeedTracker()
	{
	}
}
