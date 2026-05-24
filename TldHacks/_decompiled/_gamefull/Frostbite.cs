using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000519")]
public class Frostbite : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200051A")]
	public class BodyAreaFrostbiteHP
	{
		[Token(Token = "0x4002ED4")]
		[FieldOffset(Offset = "0x10")]
		public AfflictionBodyArea m_BodyArea;

		[Token(Token = "0x4002ED5")]
		[FieldOffset(Offset = "0x14")]
		public float m_HP;

		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public BodyAreaFrostbiteHP()
		{
		}
	}

	[Token(Token = "0x4002EBD")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002EBE")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002EBF")]
	[FieldOffset(Offset = "0x30")]
	public float m_TemperatureToBeginFrostbiteDamage;

	[Token(Token = "0x4002EC0")]
	[FieldOffset(Offset = "0x34")]
	public float m_DamagePerHourBase;

	[Token(Token = "0x4002EC1")]
	[FieldOffset(Offset = "0x38")]
	public float m_DamagePerHourIncreasePerDegree;

	[Token(Token = "0x4002EC2")]
	[FieldOffset(Offset = "0x3C")]
	public float m_MaxDamagePerHour;

	[Token(Token = "0x4002EC3")]
	[FieldOffset(Offset = "0x40")]
	public float m_DamageMultiplierInnerFrozenClothing;

	[Token(Token = "0x4002EC4")]
	[FieldOffset(Offset = "0x44")]
	public float m_TemperatureToBeginFrostbiteHeal;

	[Token(Token = "0x4002EC5")]
	[FieldOffset(Offset = "0x48")]
	public float m_HealPerHourBase;

	[Token(Token = "0x4002EC6")]
	[FieldOffset(Offset = "0x4C")]
	public float m_HealPerHourIncreasePerDegree;

	[Token(Token = "0x4002EC7")]
	[FieldOffset(Offset = "0x50")]
	public float m_MaxHealPerHour;

	[Token(Token = "0x4002EC8")]
	[FieldOffset(Offset = "0x58")]
	public BodyAreaFrostbiteHP[] m_BodyAreaFrostbiteMaxHPList;

	[Token(Token = "0x4002EC9")]
	[FieldOffset(Offset = "0x60")]
	public float m_HPPercentThresholdToStartRisk;

	[Token(Token = "0x4002ECA")]
	[FieldOffset(Offset = "0x64")]
	public float m_MaxPlayerHPReductionPerInstance;

	[Header("Audio")]
	[Token(Token = "0x4002ECB")]
	[FieldOffset(Offset = "0x68")]
	public string m_FrostbiteVO;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002ECC")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002ECD")]
	[FieldOffset(Offset = "0x78")]
	private List<int> m_LocationsWithActiveFrostbite;

	[Token(Token = "0x4002ECE")]
	[FieldOffset(Offset = "0x80")]
	private List<int> m_LocationsWithFrostbiteRisk;

	[Token(Token = "0x4002ECF")]
	[FieldOffset(Offset = "0x88")]
	private List<float> m_LocationsCurrentFrostbiteDamage;

	[Token(Token = "0x4002ED0")]
	[FieldOffset(Offset = "0x90")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002ED1")]
	[FieldOffset(Offset = "0x91")]
	private bool m_SuppressFrostbite;

	[Token(Token = "0x4002ED2")]
	[FieldOffset(Offset = "0x98")]
	private float[] m_MaxHPList;

	[Token(Token = "0x4002ED3")]
	private static FrostbiteSaveDataProxy m_FrostbiteSaveDataProxy;

	[Token(Token = "0x17000270")]
	public string m_DisplayName
	{
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000271")]
	public string m_Description
	{
		[Token(Token = "0x60026BA")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60026BB")]
	[Address(RVA = "0x8A5580", Offset = "0x8A4380", Length = "0x165")]
	public void Start()
	{
	}

	[Token(Token = "0x60026BC")]
	[Address(RVA = "0x8A56F0", Offset = "0x8A44F0", Length = "0xE4")]
	public void Update()
	{
	}

	[Token(Token = "0x60026BD")]
	[Address(RVA = "0x8A57E0", Offset = "0x8A45E0", Length = "0x283")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60026BE")]
	[Address(RVA = "0x8A5A70", Offset = "0x8A4870", Length = "0x3D0")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60026BF")]
	[Address(RVA = "0x8A5E50", Offset = "0x8A4C50", Length = "0x38F")]
	public void FrostbiteStart(int location, bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x60026C0")]
	[Address(RVA = "0x8A61E0", Offset = "0x8A4FE0", Length = "0xE0")]
	public void FrostbiteEnd()
	{
	}

	[Token(Token = "0x60026C1")]
	[Address(RVA = "0x8A62D0", Offset = "0x8A50D0", Length = "0xDB")]
	public float GetTotalHitPointReduction()
	{
		return 0f;
	}

	[Token(Token = "0x60026C2")]
	[Address(RVA = "0x8A63B0", Offset = "0x8A51B0", Length = "0xBE")]
	public int NumInstancesFrostbite()
	{
		return 0;
	}

	[Token(Token = "0x60026C3")]
	[Address(RVA = "0x8A6470", Offset = "0x8A5270", Length = "0xAA")]
	public int NumInstancesFrostbiteAtLocation(int location)
	{
		return 0;
	}

	[Token(Token = "0x60026C4")]
	[Address(RVA = "0x8A6520", Offset = "0x8A5320", Length = "0x45")]
	public bool HasFrostbite()
	{
		return false;
	}

	[Token(Token = "0x60026C5")]
	[Address(RVA = "0x8A6570", Offset = "0x8A5370", Length = "0x48")]
	public bool HasFrostbiteRisk()
	{
		return false;
	}

	[Token(Token = "0x60026C6")]
	[Address(RVA = "0x8A65C0", Offset = "0x8A53C0", Length = "0x15")]
	public bool HasFrostbiteAffliction()
	{
		return false;
	}

	[Token(Token = "0x60026C7")]
	[Address(RVA = "0x8A65E0", Offset = "0x8A53E0", Length = "0x15")]
	public bool HasFrostbiteRiskAffliction()
	{
		return false;
	}

	[Token(Token = "0x60026C8")]
	[Address(RVA = "0x8A6600", Offset = "0x8A5400", Length = "0xAA")]
	public int GetFrostbiteRiskAfflictionCount()
	{
		return 0;
	}

	[Token(Token = "0x60026C9")]
	[Address(RVA = "0x8A66B0", Offset = "0x8A54B0", Length = "0xC3")]
	public int GetFrostbiteAfflictionCount()
	{
		return 0;
	}

	[Token(Token = "0x60026CA")]
	[Address(RVA = "0x8A6780", Offset = "0x8A5580", Length = "0xC9")]
	public float GetFrostbiteRiskValue(int location)
	{
		return 0f;
	}

	[Token(Token = "0x60026CB")]
	[Address(RVA = "0x8A6850", Offset = "0x8A5650", Length = "0x11E")]
	public AfflictionBodyArea GetFrostBiteRiskLocation(int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x60026CC")]
	[Address(RVA = "0x8A6970", Offset = "0x8A5770", Length = "0x11A")]
	public AfflictionBodyArea GetFrostBiteLocation(int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x60026CD")]
	[Address(RVA = "0x8A6A90", Offset = "0x8A5890", Length = "0x7")]
	public void SetSuppressFrostbite(bool suppress)
	{
	}

	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x4BB380", Offset = "0x4BA180", Length = "0x8")]
	public bool GetSuppressFrostbite()
	{
		return false;
	}

	[Token(Token = "0x60026CF")]
	[Address(RVA = "0x8A6AA0", Offset = "0x8A58A0", Length = "0x1A")]
	public bool LocationIsIgnored(int location)
	{
		return false;
	}

	[Token(Token = "0x60026D0")]
	[Address(RVA = "0x8A6AC0", Offset = "0x8A58C0", Length = "0x58E")]
	private void UpdateFrostbite()
	{
	}

	[Token(Token = "0x60026D1")]
	[Address(RVA = "0x8A7050", Offset = "0x8A5E50", Length = "0xF6")]
	private void DealFrostbiteDamageToRegion(float damageValue, ClothingRegion region)
	{
	}

	[Token(Token = "0x60026D2")]
	[Address(RVA = "0x8A7150", Offset = "0x8A5F50", Length = "0x3D5")]
	private void DealFrostbiteDamageToLocation(float damageValue, AfflictionBodyArea bodyArea)
	{
	}

	[Token(Token = "0x60026D3")]
	[Address(RVA = "0x8A7530", Offset = "0x8A6330", Length = "0x205")]
	private float CalculateBodyTemperatureWithoutClothing()
	{
		return 0f;
	}

	[Token(Token = "0x60026D4")]
	[Address(RVA = "0x8A7740", Offset = "0x8A6540", Length = "0x1F4")]
	private float GetXPModeMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x60026D5")]
	[Address(RVA = "0x8A7940", Offset = "0x8A6740", Length = "0x36D")]
	public Frostbite()
	{
	}
}
