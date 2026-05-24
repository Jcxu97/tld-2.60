using System;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(NPC))]
[Token(Token = "0x2000864")]
public class NPCCondition : MonoBehaviour
{
	[Token(Token = "0x2000865")]
	private enum Level
	{
		[Token(Token = "0x400570C")]
		Dead,
		[Token(Token = "0x400570D")]
		Critical,
		[Token(Token = "0x400570E")]
		Alive
	}

	[Token(Token = "0x2000866")]
	private class SaveData
	{
		[Token(Token = "0x400570F")]
		[FieldOffset(Offset = "0x10")]
		public float m_CurrentHP;

		[Token(Token = "0x6004D2E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveData()
		{
		}
	}

	[Token(Token = "0x40056FF")]
	[FieldOffset(Offset = "0x20")]
	public float m_CurrentHP;

	[Token(Token = "0x4005700")]
	[FieldOffset(Offset = "0x24")]
	public float m_MaxHP;

	[Token(Token = "0x4005701")]
	[FieldOffset(Offset = "0x28")]
	public float m_CriticalHP;

	[Token(Token = "0x4005702")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HPIncreasePerDayWhileHealthy;

	[Token(Token = "0x4005703")]
	[FieldOffset(Offset = "0x30")]
	public float m_HPDecreasePerDayFromFreezing;

	[Token(Token = "0x4005704")]
	[FieldOffset(Offset = "0x34")]
	public float m_HPDecreasePerDayFromDehydration;

	[Token(Token = "0x4005705")]
	[FieldOffset(Offset = "0x38")]
	public float m_HPDecreasePerDayFromBloodLoss;

	[Header("Audio")]
	[Token(Token = "0x4005706")]
	[FieldOffset(Offset = "0x40")]
	public string m_NearDeathVoiceOver;

	[Token(Token = "0x4005707")]
	[FieldOffset(Offset = "0x48")]
	public string m_WolfAttackVoiceOver;

	[NonSerialized]
	[Token(Token = "0x4005708")]
	[FieldOffset(Offset = "0x50")]
	public NPC m_NPC;

	[NonSerialized]
	[Token(Token = "0x4005709")]
	[FieldOffset(Offset = "0x58")]
	public DamageSource m_LastDamageSource;

	[Token(Token = "0x400570A")]
	[FieldOffset(Offset = "0x5C")]
	private Level m_LastVOLevel;

	[Token(Token = "0x6004D1C")]
	[Address(RVA = "0xD83C90", Offset = "0xD82A90", Length = "0x38")]
	private void Start()
	{
	}

	[Token(Token = "0x6004D1D")]
	[Address(RVA = "0xD83CD0", Offset = "0xD82AD0", Length = "0x23F")]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[Token(Token = "0x6004D1E")]
	[Address(RVA = "0xD83F10", Offset = "0xD82D10", Length = "0x14")]
	public void UpdateHealthForFreezing(float dayFraction)
	{
	}

	[Token(Token = "0x6004D1F")]
	[Address(RVA = "0xD83F30", Offset = "0xD82D30", Length = "0x14")]
	public void UpdateHealthForDehydration(float dayFraction)
	{
	}

	[Token(Token = "0x6004D20")]
	[Address(RVA = "0xD83F50", Offset = "0xD82D50", Length = "0x1F1")]
	public void UpdateHealthForHealthy(float dayFraction)
	{
	}

	[Token(Token = "0x6004D21")]
	[Address(RVA = "0xD84150", Offset = "0xD82F50", Length = "0x58")]
	public void UpdateHeathForBloodLoss(float dayFraction)
	{
	}

	[Token(Token = "0x6004D22")]
	[Address(RVA = "0xD841B0", Offset = "0xD82FB0", Length = "0x69")]
	public bool IsAlive()
	{
		return false;
	}

	[Token(Token = "0x6004D23")]
	[Address(RVA = "0x62CEA0", Offset = "0x62BCA0", Length = "0xB")]
	public float GetNormalizedCondition()
	{
		return 0f;
	}

	[Token(Token = "0x6004D24")]
	[Address(RVA = "0xD84220", Offset = "0xD83020", Length = "0x1AA")]
	public float GetAdjustedMaxHP()
	{
		return 0f;
	}

	[Token(Token = "0x6004D25")]
	[Address(RVA = "0xD843D0", Offset = "0xD831D0", Length = "0xAC")]
	public void Deserialize(string serialized)
	{
	}

	[Token(Token = "0x6004D26")]
	[Address(RVA = "0xD84480", Offset = "0xD83280", Length = "0xBD")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004D27")]
	[Address(RVA = "0xD84540", Offset = "0xD83340", Length = "0x11D")]
	public void AddHealth(float amount)
	{
	}

	[Token(Token = "0x6004D28")]
	[Address(RVA = "0xD84660", Offset = "0xD83460", Length = "0x15A")]
	public void ApplyDamage(DamageSource source, float damage)
	{
	}

	[Token(Token = "0x6004D29")]
	[Address(RVA = "0xD847C0", Offset = "0xD835C0", Length = "0x32")]
	private Level GetCurrentConditionLevel()
	{
		return default(Level);
	}

	[Token(Token = "0x6004D2A")]
	[Address(RVA = "0xD84800", Offset = "0xD83600", Length = "0x1C2")]
	private void HandleDeath()
	{
	}

	[Token(Token = "0x6004D2B")]
	[Address(RVA = "0xD849D0", Offset = "0xD837D0", Length = "0x11B")]
	private void MaybePlayVoiceOver()
	{
	}

	[Token(Token = "0x6004D2C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void EndBloodLoss()
	{
	}

	[Token(Token = "0x6004D2D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NPCCondition()
	{
	}
}
