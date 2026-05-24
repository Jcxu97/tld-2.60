using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gameplay.Condition;

[Token(Token = "0x20014CD")]
public class InsomniaManager : MonoBehaviour
{
	[Token(Token = "0x400965B")]
	[FieldOffset(Offset = "0x20")]
	public InsomniaData[] m_InsomniaData;

	[HideInInspector]
	[Token(Token = "0x400965C")]
	[FieldOffset(Offset = "0x28")]
	public List<InsomniaSafeZoneTrigger> m_SafeZoneCollection;

	[Token(Token = "0x400965D")]
	[FieldOffset(Offset = "0x30")]
	private readonly Dictionary<InsomniaCause, InsomniaData> m_InsomniaDataDict;

	[Token(Token = "0x400965E")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<Insomnia> m_InsomniaInstances;

	[Token(Token = "0x400965F")]
	[FieldOffset(Offset = "0x40")]
	private float m_ResistInsomniaBuffHoursRemaining;

	[Token(Token = "0x4009660")]
	[FieldOffset(Offset = "0x44")]
	private float m_ResistInsomniaBuffMultiplier;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4009661")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4009662")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x6008328")]
	[Address(RVA = "0x12439E0", Offset = "0x12427E0", Length = "0x33D")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6008329")]
	[Address(RVA = "0x1243D20", Offset = "0x1242B20", Length = "0x276")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600832A")]
	[Address(RVA = "0x1243FA0", Offset = "0x1242DA0", Length = "0xAD")]
	private void Awake()
	{
	}

	[Token(Token = "0x600832B")]
	[Address(RVA = "0x1244050", Offset = "0x1242E50", Length = "0x64")]
	private void Start()
	{
	}

	[Token(Token = "0x600832C")]
	[Address(RVA = "0x12440C0", Offset = "0x1242EC0", Length = "0x2F9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600832D")]
	[Address(RVA = "0x12443C0", Offset = "0x12431C0", Length = "0x478")]
	public void Update()
	{
	}

	[Token(Token = "0x600832E")]
	[Address(RVA = "0x1244840", Offset = "0x1243640", Length = "0x18D")]
	private void MaybeUpdateResistInsomniaBuff()
	{
	}

	[Token(Token = "0x600832F")]
	[Address(RVA = "0x12449D0", Offset = "0x12437D0", Length = "0x125")]
	private void MaybeAddInsomniaRisk()
	{
	}

	[Token(Token = "0x6008330")]
	[Address(RVA = "0x1244B00", Offset = "0x1243900", Length = "0x147")]
	private void MaybeUpdateInsomnia()
	{
	}

	[Token(Token = "0x6008331")]
	[Address(RVA = "0x1244C50", Offset = "0x1243A50", Length = "0x55C")]
	private void ApplyInsomniaRisk(InsomniaCause InsomniaType)
	{
	}

	[Token(Token = "0x6008332")]
	[Address(RVA = "0x12451B0", Offset = "0x1243FB0", Length = "0x56C")]
	public void ApplyInsomniaAffliction(InsomniaCause InsomniaType)
	{
	}

	[Token(Token = "0x6008333")]
	[Address(RVA = "0x1245720", Offset = "0x1244520", Length = "0xD6")]
	public string GetInsomniaCause(int index)
	{
		return null;
	}

	[Token(Token = "0x6008334")]
	[Address(RVA = "0x1245800", Offset = "0x1244600", Length = "0x70")]
	public Insomnia GetInsomniaByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6008335")]
	[Address(RVA = "0x1245880", Offset = "0x1244680", Length = "0x15")]
	public bool HasInsomniaAffliction()
	{
		return false;
	}

	[Token(Token = "0x6008336")]
	[Address(RVA = "0x12458A0", Offset = "0x12446A0", Length = "0x15")]
	public bool HasInsomniaRisk()
	{
		return false;
	}

	[Token(Token = "0x6008337")]
	[Address(RVA = "0x12458C0", Offset = "0x12446C0", Length = "0x18B")]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x6008338")]
	[Address(RVA = "0x1245A50", Offset = "0x1244850", Length = "0x18B")]
	public int GetRisksCount()
	{
		return 0;
	}

	[Token(Token = "0x6008339")]
	[Address(RVA = "0x1245BE0", Offset = "0x12449E0", Length = "0x11B")]
	public float GetActiveHoursRemaining(int index)
	{
		return 0f;
	}

	[Token(Token = "0x600833A")]
	[Address(RVA = "0x1245D00", Offset = "0x1244B00", Length = "0x7D")]
	public float GetRiskProgress(int index)
	{
		return 0f;
	}

	[Token(Token = "0x600833B")]
	[Address(RVA = "0x1245D80", Offset = "0x1244B80", Length = "0xB")]
	public void ApplyResistInsomniaBuff(float timeHours, float chanceMultiplier)
	{
	}

	[Token(Token = "0x600833C")]
	[Address(RVA = "0x640990", Offset = "0x63F790", Length = "0xF")]
	public bool HasResistInsomniaBuff()
	{
		return false;
	}

	[Token(Token = "0x600833D")]
	[Address(RVA = "0x1245D90", Offset = "0x1244B90", Length = "0x96")]
	public bool ShouldInterruptSleep()
	{
		return false;
	}

	[Token(Token = "0x600833E")]
	[Address(RVA = "0x1245E30", Offset = "0x1244C30", Length = "0x5B")]
	public float GetChanceOfHowBadlySleepIsInterrupted()
	{
		return 0f;
	}

	[Token(Token = "0x600833F")]
	[Address(RVA = "0x1245E90", Offset = "0x1244C90", Length = "0x5A")]
	public bool IsElectrostaticFogActive()
	{
		return false;
	}

	[Token(Token = "0x6008340")]
	[Address(RVA = "0x1245EF0", Offset = "0x1244CF0", Length = "0x45")]
	public bool IsInSafePlace()
	{
		return false;
	}

	[Token(Token = "0x6008341")]
	[Address(RVA = "0x1245F40", Offset = "0x1244D40", Length = "0x1FD")]
	public void RemoveInsomniaAll()
	{
	}

	[Token(Token = "0x6008342")]
	[Address(RVA = "0x1246140", Offset = "0x1244F40", Length = "0xA9")]
	private void RemoveInsomnia(Insomnia data)
	{
	}

	[Token(Token = "0x6008343")]
	[Address(RVA = "0x12461F0", Offset = "0x1244FF0", Length = "0x15F")]
	private Insomnia GetInsomniaDataByCause(InsomniaCause cause)
	{
		return null;
	}

	[Token(Token = "0x6008344")]
	[Address(RVA = "0x1246350", Offset = "0x1245150", Length = "0x182")]
	private bool HasElectrostaticFogAffliction()
	{
		return false;
	}

	[Token(Token = "0x6008345")]
	[Address(RVA = "0x12464E0", Offset = "0x12452E0", Length = "0x180")]
	private Insomnia GetElectrostaticFogAffliction()
	{
		return null;
	}

	[Token(Token = "0x6008346")]
	[Address(RVA = "0x1246670", Offset = "0x1245470", Length = "0x228")]
	public InsomniaManager()
	{
	}
}
