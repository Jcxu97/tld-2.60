using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000535")]
public class SprainPain : MonoBehaviour
{
	[Token(Token = "0x2000536")]
	private struct Instance
	{
		[Token(Token = "0x4003007")]
		[FieldOffset(Offset = "0x0")]
		public AfflictionBodyArea m_Location;

		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x8")]
		public string m_Cause;

		[Token(Token = "0x4003009")]
		[FieldOffset(Offset = "0x10")]
		public float m_EndTime;
	}

	[Token(Token = "0x2000537")]
	public class SaveDataProxy
	{
		[Token(Token = "0x400300A")]
		[FieldOffset(Offset = "0x10")]
		public float m_SecondsSinceLastPulseFx;

		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x18")]
		public int[] m_Locations;

		[Token(Token = "0x400300C")]
		[FieldOffset(Offset = "0x20")]
		public string[] m_Causes;

		[Token(Token = "0x400300D")]
		[FieldOffset(Offset = "0x28")]
		public float[] m_EndTimes;

		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveDataProxy()
		{
		}
	}

	[SerializeField]
	[Range(0f, 24f)]
	[Token(Token = "0x4002FFC")]
	[FieldOffset(Offset = "0x20")]
	private float m_AfflictionDurationHours;

	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4002FFD")]
	[FieldOffset(Offset = "0x24")]
	private float m_TreatmentPercent;

	[Header("Pulse FX")]
	[SerializeField]
	[Range(0f, 30f)]
	[Token(Token = "0x4002FFE")]
	[FieldOffset(Offset = "0x28")]
	private float m_PulseFxStartDelaySeconds;

	[SerializeField]
	[Range(0f, 30f)]
	[Token(Token = "0x4002FFF")]
	[FieldOffset(Offset = "0x2C")]
	private float m_PulseFxFrequencySeconds;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4003000")]
	[FieldOffset(Offset = "0x30")]
	private float m_PulseFxIntensity;

	[SerializeField]
	[Token(Token = "0x4003001")]
	[FieldOffset(Offset = "0x38")]
	private string m_PulseFxWwiseRtpcName;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003002")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4003003")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4003004")]
	[FieldOffset(Offset = "0x50")]
	private List<Instance> m_ActiveInstances;

	[Token(Token = "0x4003005")]
	[FieldOffset(Offset = "0x58")]
	private SaveDataProxy m_SaveDataProxy;

	[Token(Token = "0x4003006")]
	[FieldOffset(Offset = "0x60")]
	private float m_SecondsSinceLastPulseFx;

	[Token(Token = "0x60027D1")]
	[Address(RVA = "0x8BA630", Offset = "0x8B9430", Length = "0x4FB")]
	public void Update()
	{
	}

	[Token(Token = "0x60027D2")]
	[Address(RVA = "0x8BAB30", Offset = "0x8B9930", Length = "0x3EA")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60027D3")]
	[Address(RVA = "0x8BAF20", Offset = "0x8B9D20", Length = "0x290")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60027D4")]
	[Address(RVA = "0x8BB1C0", Offset = "0x8B9FC0", Length = "0x45")]
	public bool HasSprainPain()
	{
		return false;
	}

	[Token(Token = "0x60027D5")]
	[Address(RVA = "0x8BB210", Offset = "0x8BA010", Length = "0x41")]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x60027D6")]
	[Address(RVA = "0x8BB260", Offset = "0x8BA060", Length = "0x45")]
	public bool RequiresPainKiller()
	{
		return false;
	}

	[Token(Token = "0x60027D7")]
	[Address(RVA = "0x8BB2B0", Offset = "0x8BA0B0", Length = "0x3F1")]
	public void ApplyAffliction(AfflictionBodyArea location, string cause, AfflictionOptions opts = AfflictionOptions.PlayFX | AfflictionOptions.DoAutoSave)
	{
	}

	[Token(Token = "0x60027D8")]
	[Address(RVA = "0x8BB6B0", Offset = "0x8BA4B0", Length = "0x164")]
	private void CureAffliction(Instance inst, AfflictionOptions opts = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x60027D9")]
	[Address(RVA = "0x8BB820", Offset = "0x8BA620", Length = "0xC0")]
	public void Cure()
	{
	}

	[Token(Token = "0x60027DA")]
	[Address(RVA = "0x8BB8F0", Offset = "0x8BA6F0", Length = "0xD1")]
	public float GetRemainingHours(int index)
	{
		return 0f;
	}

	[Token(Token = "0x60027DB")]
	[Address(RVA = "0x8BB9D0", Offset = "0x8BA7D0", Length = "0x1BF")]
	public void TakePainKillers(int index)
	{
	}

	[Token(Token = "0x60027DC")]
	[Address(RVA = "0x8BBB90", Offset = "0x8BA990", Length = "0x7E")]
	public string GetCauseLocId(int index)
	{
		return null;
	}

	[Token(Token = "0x60027DD")]
	[Address(RVA = "0x8BBC10", Offset = "0x8BAA10", Length = "0x73")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x60027DE")]
	[Address(RVA = "0x8BBC90", Offset = "0x8BAA90", Length = "0x16F")]
	public SprainPain()
	{
	}
}
