using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x2000586")]
public class Harvestable : MonoBehaviour
{
	[Range(0f, 100f)]
	[Token(Token = "0x40032D2")]
	[FieldOffset(Offset = "0x20")]
	public float m_SpawnChance;

	[Token(Token = "0x40032D3")]
	[FieldOffset(Offset = "0x28")]
	public GearItem m_InspectItem;

	[Token(Token = "0x40032D4")]
	[FieldOffset(Offset = "0x30")]
	public GearItem m_GearPrefab;

	[FormerlySerializedAs("m_GearItemCount")]
	[Token(Token = "0x40032D5")]
	[FieldOffset(Offset = "0x38")]
	public int m_GearItemCountMin;

	[FormerlySerializedAs("m_GearItemCount")]
	[Token(Token = "0x40032D6")]
	[FieldOffset(Offset = "0x3C")]
	public int m_GearItemCountMax;

	[Token(Token = "0x40032D7")]
	[FieldOffset(Offset = "0x40")]
	public GearItem m_SecondGearPrefab;

	[FormerlySerializedAs("m_SecondGearItemCount")]
	[Token(Token = "0x40032D8")]
	[FieldOffset(Offset = "0x48")]
	public int m_SecondGearItemCountMin;

	[FormerlySerializedAs("m_SecondGearItemCount")]
	[Token(Token = "0x40032D9")]
	[FieldOffset(Offset = "0x4C")]
	public int m_SecondGearItemCountMax;

	[Token(Token = "0x40032DA")]
	[FieldOffset(Offset = "0x50")]
	public string m_HarvestAudio;

	[Token(Token = "0x40032DB")]
	[FieldOffset(Offset = "0x58")]
	public GameObject[] m_RequiredToolList;

	[Token(Token = "0x40032DC")]
	[FieldOffset(Offset = "0x60")]
	public string m_RequiredToolText;

	[Token(Token = "0x40032DD")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_ActivateObjectPostHarvest;

	[Token(Token = "0x40032DE")]
	[FieldOffset(Offset = "0x70")]
	public bool m_DestroyObjectOnHarvest;

	[Token(Token = "0x40032DF")]
	[FieldOffset(Offset = "0x71")]
	public bool m_IgnoreCustomModeSpawnChance;

	[Token(Token = "0x40032E0")]
	[FieldOffset(Offset = "0x74")]
	public float m_RefreshHoursMin;

	[Token(Token = "0x40032E1")]
	[FieldOffset(Offset = "0x78")]
	public float m_RefreshHoursMax;

	[Token(Token = "0x40032E3")]
	[FieldOffset(Offset = "0x88")]
	private int m_NumPrimary;

	[Token(Token = "0x40032E4")]
	[FieldOffset(Offset = "0x8C")]
	private int m_NumSecondary;

	[Token(Token = "0x40032E5")]
	[FieldOffset(Offset = "0x90")]
	private bool m_Harvested;

	[Token(Token = "0x40032E6")]
	[FieldOffset(Offset = "0x94")]
	private float m_RefreshTime;

	[Token(Token = "0x40032E7")]
	[FieldOffset(Offset = "0x98")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40032E8")]
	[FieldOffset(Offset = "0x99")]
	private bool m_HasInspectedSecondary;

	[SerializeField]
	[Token(Token = "0x40032E9")]
	[FieldOffset(Offset = "0x9A")]
	private bool m_RegisterAsPlantsHaversted;

	[Token(Token = "0x40032EA")]
	private static HarvestableSaveDataProxy m_HarvestableSaveDataProxy;

	[Token(Token = "0x40032EB")]
	[FieldOffset(Offset = "0xA0")]
	private List<string> m_FilteredRequiredTools;

	[Token(Token = "0x170002C1")]
	public bool RegisterAsPlantsHaversted
	{
		[Token(Token = "0x6002A89")]
		[Address(RVA = "0x905060", Offset = "0x903E60", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x14000004")]
	public event Action Harvested
	{
		[CompilerGenerated]
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x905070", Offset = "0x903E70", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6002A8B")]
		[Address(RVA = "0x905160", Offset = "0x903F60", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x6002A8C")]
	[Address(RVA = "0x905250", Offset = "0x904050", Length = "0x145")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002A8D")]
	[Address(RVA = "0x9053A0", Offset = "0x9041A0", Length = "0xDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002A8E")]
	[Address(RVA = "0x905480", Offset = "0x904280", Length = "0x106")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002A8F")]
	[Address(RVA = "0x905590", Offset = "0x904390", Length = "0x274")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002A90")]
	[Address(RVA = "0x905810", Offset = "0x904610", Length = "0x2D3")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002A91")]
	[Address(RVA = "0x89B490", Offset = "0x89A290", Length = "0x8")]
	public bool IsHarvested()
	{
		return false;
	}

	[Token(Token = "0x6002A92")]
	[Address(RVA = "0x905AF0", Offset = "0x9048F0", Length = "0x11F")]
	public bool HasToolRequired()
	{
		return false;
	}

	[Token(Token = "0x6002A93")]
	[Address(RVA = "0x905C10", Offset = "0x904A10", Length = "0x255")]
	public GearItem GetRequiredTool()
	{
		return null;
	}

	[Token(Token = "0x6002A94")]
	[Address(RVA = "0x905E70", Offset = "0x904C70", Length = "0x34")]
	private List<string> GetFilteredRequiredTools()
	{
		return null;
	}

	[Token(Token = "0x6002A95")]
	[Address(RVA = "0x905EB0", Offset = "0x904CB0", Length = "0x48A")]
	private void InitializeRequiredTools()
	{
	}

	[Token(Token = "0x6002A96")]
	[Address(RVA = "0x906340", Offset = "0x905140", Length = "0x34E")]
	public void EnterInspectMode(GearItem gearPrefab)
	{
	}

	[Token(Token = "0x6002A97")]
	[Address(RVA = "0x906690", Offset = "0x905490", Length = "0x5B7")]
	public void Harvest()
	{
	}

	[Token(Token = "0x6002A98")]
	[Address(RVA = "0x906C50", Offset = "0x905A50", Length = "0xEE")]
	public void MaybeShowSecondaryItem()
	{
	}

	[Token(Token = "0x6002A99")]
	[Address(RVA = "0x906D40", Offset = "0x905B40", Length = "0x366")]
	private void ShowItemMessage(GearItem gi, string itemLocID, int num)
	{
	}

	[Token(Token = "0x6002A9A")]
	[Address(RVA = "0x9070B0", Offset = "0x905EB0", Length = "0x1CE")]
	private void RollSpawnChance()
	{
	}

	[Token(Token = "0x6002A9B")]
	[Address(RVA = "0x907280", Offset = "0x906080", Length = "0x51")]
	public Harvestable()
	{
	}
}
