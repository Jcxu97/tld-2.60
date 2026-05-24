using System;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

[RequireComponent(typeof(NPC))]
[Token(Token = "0x200086C")]
public class NPCThirst : MonoBehaviour
{
	[Token(Token = "0x200086D")]
	private class SaveData
	{
		[Token(Token = "0x4005730")]
		[FieldOffset(Offset = "0x10")]
		public float m_CurrentThirstPercentage;

		[Token(Token = "0x6004D50")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveData()
		{
		}
	}

	[Token(Token = "0x4005727")]
	[FieldOffset(Offset = "0x20")]
	public ItemLiquidVolume m_FullThirstAsLiters;

	[Tooltip("100% Thirst means Dehydration ")]
	[Range(0f, 100f)]
	[Token(Token = "0x4005728")]
	[FieldOffset(Offset = "0x28")]
	public float m_InitialThirstPercentage;

	[Token(Token = "0x4005729")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ThirstIncreasePerHour;

	[Range(0f, 100f)]
	[Token(Token = "0x400572A")]
	[FieldOffset(Offset = "0x30")]
	public float m_DehydrationRiskThresholdPercentage;

	[Token(Token = "0x400572B")]
	[FieldOffset(Offset = "0x38")]
	public ItemLiquidVolume m_MinimumWaterFromPlayerLiters;

	[Token(Token = "0x400572C")]
	[FieldOffset(Offset = "0x40")]
	public bool m_AlwaysHydrated;

	[NonSerialized]
	[Token(Token = "0x400572D")]
	[FieldOffset(Offset = "0x48")]
	public NPC m_NPC;

	[NonSerialized]
	[Token(Token = "0x400572E")]
	[FieldOffset(Offset = "0x50")]
	public float m_CurrentThirstPercentage;

	[Token(Token = "0x400572F")]
	[FieldOffset(Offset = "0x54")]
	private bool m_HasInitialized;

	[Token(Token = "0x6004D42")]
	[Address(RVA = "0xD86330", Offset = "0xD85130", Length = "0x11")]
	private void Start()
	{
	}

	[Token(Token = "0x6004D43")]
	[Address(RVA = "0xD86350", Offset = "0xD85150", Length = "0x141")]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[Token(Token = "0x6004D44")]
	[Address(RVA = "0xD864A0", Offset = "0xD852A0", Length = "0x87")]
	public ItemLiquidVolume GeAfflictionDehydrationRequiredLiters()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6004D45")]
	[Address(RVA = "0xD86530", Offset = "0xD85330", Length = "0xAB")]
	public float GetHealthyDelta(float delta)
	{
		return 0f;
	}

	[Token(Token = "0x6004D46")]
	[Address(RVA = "0xD865E0", Offset = "0xD853E0", Length = "0x10")]
	private bool IsDehydrated()
	{
		return false;
	}

	[Token(Token = "0x6004D47")]
	[Address(RVA = "0xD865F0", Offset = "0xD853F0", Length = "0xD")]
	private bool HasDehydrationRisk()
	{
		return false;
	}

	[Token(Token = "0x6004D48")]
	[Address(RVA = "0xD86600", Offset = "0xD85400", Length = "0xF0")]
	public void ApplyTODHours(float delta)
	{
	}

	[Token(Token = "0x6004D49")]
	[Address(RVA = "0xD86700", Offset = "0xD85500", Length = "0x91")]
	public void Deserialize(string serialized)
	{
	}

	[Token(Token = "0x6004D4A")]
	[Address(RVA = "0xD867A0", Offset = "0xD855A0", Length = "0xBD")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004D4B")]
	[Address(RVA = "0xD86860", Offset = "0xD85660", Length = "0xAA")]
	private void StartDehydrationAffliction()
	{
	}

	[Token(Token = "0x6004D4C")]
	[Address(RVA = "0xD86910", Offset = "0xD85710", Length = "0x66")]
	private void StartDehydrationRiskAffliction()
	{
	}

	[Token(Token = "0x6004D4D")]
	[Address(RVA = "0xD86980", Offset = "0xD85780", Length = "0xB")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6004D4E")]
	[Address(RVA = "0xD86990", Offset = "0xD85790", Length = "0x10E")]
	public void AddWaterLiters(ItemLiquidVolume waterAddedLiters)
	{
	}

	[Token(Token = "0x6004D4F")]
	[Address(RVA = "0xD86AA0", Offset = "0xD858A0", Length = "0xBA")]
	public NPCThirst()
	{
	}
}
