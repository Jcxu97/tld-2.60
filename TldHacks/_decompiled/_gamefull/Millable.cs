using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004C0")]
public class Millable : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20004C1")]
	private class SaveData
	{
		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x10")]
		public float m_RestorationProgress;

		[Token(Token = "0x6002449")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveData()
		{
		}
	}

	[HideInInspector]
	[Token(Token = "0x4002BAC")]
	[FieldOffset(Offset = "0x20")]
	public GearItem[] m_RepairRequiredGear;

	[HideInInspector]
	[Token(Token = "0x4002BAD")]
	[FieldOffset(Offset = "0x28")]
	public int[] m_RepairRequiredGearUnits;

	[HideInInspector]
	[Token(Token = "0x4002BAE")]
	[FieldOffset(Offset = "0x30")]
	public GearItem[] m_RestoreRequiredGear;

	[HideInInspector]
	[Token(Token = "0x4002BAF")]
	[FieldOffset(Offset = "0x38")]
	public int[] m_RestoreRequiredGearUnits;

	[Token(Token = "0x4002BB0")]
	[FieldOffset(Offset = "0x40")]
	public bool m_CanRestoreFromWornOut;

	[Tooltip("Minute required to repair the gear item with the milling machine.")]
	[Token(Token = "0x4002BB1")]
	[FieldOffset(Offset = "0x44")]
	public int m_RepairDurationMinutes;

	[Tooltip("Minutes required to recover the gear item from a worn out state at a milling machine. Requires Can Restore From Worn Out to be True.")]
	[Token(Token = "0x4002BB2")]
	[FieldOffset(Offset = "0x48")]
	public int m_RecoveryDurationMinutes;

	[Token(Token = "0x4002BB3")]
	[FieldOffset(Offset = "0x4C")]
	public SkillType m_Skill;

	[Token(Token = "0x17000249")]
	[field: Token(Token = "0x4002BB4")]
	[field: FieldOffset(Offset = "0x50")]
	public float m_RestorationProgress
	{
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x4B4350", Offset = "0x4B3150", Length = "0x6")]
		get;
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x8652A0", Offset = "0x8640A0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x6002444")]
	[Address(RVA = "0x8652B0", Offset = "0x8640B0", Length = "0x3E")]
	public void ApplyRestorationProgress(float percentOfRemaining)
	{
	}

	[Token(Token = "0x6002445")]
	[Address(RVA = "0x8652F0", Offset = "0x8640F0", Length = "0x87")]
	public void Deserialize(string serialized)
	{
	}

	[Token(Token = "0x6002446")]
	[Address(RVA = "0x865380", Offset = "0x864180", Length = "0x8")]
	public void ResetRestorationProgress()
	{
	}

	[Token(Token = "0x6002447")]
	[Address(RVA = "0x865390", Offset = "0x864190", Length = "0xBD")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002448")]
	[Address(RVA = "0x865450", Offset = "0x864250", Length = "0x4A")]
	public Millable()
	{
	}
}
