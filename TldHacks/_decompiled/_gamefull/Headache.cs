using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001EA")]
public class Headache : MonoBehaviour
{
	[Token(Token = "0x20001EB")]
	private struct HeadacheSaveDataProxy
	{
		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x0")]
		public float m_HeadacheDurationHours;

		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0x4")]
		public float m_HeadachePulseFrequencyStart;

		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x8")]
		public float m_HeadachePulseFrequencyEnd;

		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0xC")]
		public float m_StartTimeInGameHours;

		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x10")]
		public bool m_IsUpdatedProxyVersion;

		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x18")]
		public List<HeadacheParamsSaveDataProxy> m_ListOfParamData;
	}

	[SerializeField]
	[Token(Token = "0x4001125")]
	[FieldOffset(Offset = "0x20")]
	private HeadacheData m_LegacyHeadacheData;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001126")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[Token(Token = "0x4001127")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<HeadacheParams> m_HeadacheInstances;

	[Token(Token = "0x600116D")]
	[Address(RVA = "0x63E1C0", Offset = "0x63CFC0", Length = "0x64")]
	private void Start()
	{
	}

	[Token(Token = "0x600116E")]
	[Address(RVA = "0x63E230", Offset = "0x63D030", Length = "0x64")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600116F")]
	[Address(RVA = "0x63E2A0", Offset = "0x63D0A0", Length = "0x157")]
	private void Update()
	{
	}

	[Token(Token = "0x6001170")]
	[Address(RVA = "0x63E400", Offset = "0x63D200", Length = "0x363")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001171")]
	[Address(RVA = "0x63E770", Offset = "0x63D570", Length = "0x419")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001172")]
	[Address(RVA = "0x63EB90", Offset = "0x63D990", Length = "0x15")]
	public bool HasHeadache()
	{
		return false;
	}

	[Token(Token = "0x6001173")]
	[Address(RVA = "0x63EBB0", Offset = "0x63D9B0", Length = "0x7B")]
	public float GetActiveHoursRemaining(int index)
	{
		return 0f;
	}

	[Token(Token = "0x6001174")]
	[Address(RVA = "0x63EC30", Offset = "0x63DA30", Length = "0x84")]
	public float GetNormalizedTimeRemaining(int index)
	{
		return 0f;
	}

	[Token(Token = "0x6001175")]
	[Address(RVA = "0x63ECC0", Offset = "0x63DAC0", Length = "0xE9")]
	public void ApplyHeadache(HeadacheData headacheData)
	{
	}

	[Token(Token = "0x6001176")]
	[Address(RVA = "0x63EDB0", Offset = "0x63DBB0", Length = "0xCC")]
	public void RemoveHeadache(HeadacheData headacheData)
	{
	}

	[Token(Token = "0x6001177")]
	[Address(RVA = "0x63EE80", Offset = "0x63DC80", Length = "0x18B")]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x6001178")]
	[Address(RVA = "0x63F010", Offset = "0x63DE10", Length = "0xE1")]
	public string GetCause(int index)
	{
		return null;
	}

	[Token(Token = "0x6001179")]
	[Address(RVA = "0x63F100", Offset = "0x63DF00", Length = "0x70")]
	public HeadacheParams GetAfflictionByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600117A")]
	[Address(RVA = "0x63F180", Offset = "0x63DF80", Length = "0xB1")]
	private void RemoveHeadache(HeadacheParams data)
	{
	}

	[Token(Token = "0x600117B")]
	[Address(RVA = "0x63F240", Offset = "0x63E040", Length = "0xD8")]
	private void MaybeUpdateHeadaches()
	{
	}

	[Token(Token = "0x600117C")]
	[Address(RVA = "0x63F320", Offset = "0x63E120", Length = "0xC7")]
	public void Cure()
	{
	}

	[Token(Token = "0x600117D")]
	[Address(RVA = "0x63F3F0", Offset = "0x63E1F0", Length = "0xE3")]
	public Headache()
	{
	}
}
