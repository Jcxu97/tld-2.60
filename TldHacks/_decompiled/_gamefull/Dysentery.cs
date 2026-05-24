using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000512")]
public class Dysentery : MonoBehaviour
{
	[Token(Token = "0x4002E69")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002E6A")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002E6B")]
	[FieldOffset(Offset = "0x30")]
	public float m_ChanceDysenteryAfterDrinkingUnsafeWater;

	[Token(Token = "0x4002E6C")]
	[FieldOffset(Offset = "0x34")]
	public float m_DurationHoursMin;

	[Token(Token = "0x4002E6D")]
	[FieldOffset(Offset = "0x38")]
	public float m_DurationHoursMax;

	[Token(Token = "0x4002E6E")]
	[FieldOffset(Offset = "0x3C")]
	public float m_HPDrainPerHour;

	[Token(Token = "0x4002E6F")]
	[FieldOffset(Offset = "0x40")]
	public float m_FatigueIncreasePerHour;

	[Token(Token = "0x4002E70")]
	[FieldOffset(Offset = "0x44")]
	public float m_ThirstIncreasePerHour;

	[Token(Token = "0x4002E71")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_AntibioticsPrefab;

	[Token(Token = "0x4002E72")]
	[FieldOffset(Offset = "0x50")]
	public ItemLiquidVolume m_LitersCleanWaterForCure;

	[Token(Token = "0x4002E73")]
	[FieldOffset(Offset = "0x58")]
	public float m_NumHoursRestForCure;

	[Header("Audio")]
	[Token(Token = "0x4002E74")]
	[FieldOffset(Offset = "0x60")]
	public string m_DysenteryVO;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002E75")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002E76")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002E77")]
	[FieldOffset(Offset = "0x78")]
	private bool m_Active;

	[Token(Token = "0x4002E78")]
	[FieldOffset(Offset = "0x7C")]
	private float m_ElapsedHours;

	[Token(Token = "0x4002E79")]
	[FieldOffset(Offset = "0x80")]
	private float m_DurationHours;

	[Token(Token = "0x4002E7A")]
	[FieldOffset(Offset = "0x84")]
	private bool m_AntibioticsTaken;

	[Token(Token = "0x4002E7B")]
	[FieldOffset(Offset = "0x88")]
	private float m_ElapsedRest;

	[Token(Token = "0x4002E7C")]
	[FieldOffset(Offset = "0x90")]
	private ItemLiquidVolume m_CleanWaterConsumedLiters;

	[Token(Token = "0x4002E7D")]
	[FieldOffset(Offset = "0x98")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002E7E")]
	private static DysenterySaveDataProxy m_DysenterySaveDataProxy;

	[Token(Token = "0x1700026C")]
	public string m_DisplayName
	{
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026D")]
	public string m_Description
	{
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002679")]
	[Address(RVA = "0x8A1190", Offset = "0x89FF90", Length = "0x15")]
	public void Start()
	{
	}

	[Token(Token = "0x600267A")]
	[Address(RVA = "0x8A11B0", Offset = "0x89FFB0", Length = "0xB9")]
	public void Update()
	{
	}

	[Token(Token = "0x600267B")]
	[Address(RVA = "0x8A1270", Offset = "0x8A0070", Length = "0x18F")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600267C")]
	[Address(RVA = "0x8A1400", Offset = "0x8A0200", Length = "0xCE")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600267D")]
	[Address(RVA = "0x8A14D0", Offset = "0x8A02D0", Length = "0x359")]
	public void DysenteryStart(bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x600267E")]
	[Address(RVA = "0x8A1830", Offset = "0x8A0630", Length = "0x114")]
	public void DysenteryEnd(bool nofx = false)
	{
	}

	[Token(Token = "0x600267F")]
	[Address(RVA = "0x502700", Offset = "0x501500", Length = "0x5")]
	public bool HasDysentery()
	{
		return false;
	}

	[Token(Token = "0x6002680")]
	[Address(RVA = "0x6348A0", Offset = "0x6336A0", Length = "0x17B")]
	public bool HasTakenAntibiotics()
	{
		return false;
	}

	[Token(Token = "0x6002681")]
	[Address(RVA = "0x8A1950", Offset = "0x8A0750", Length = "0xE")]
	public float GetRestAmountRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x6002682")]
	[Address(RVA = "0x8A1960", Offset = "0x8A0760", Length = "0x5F")]
	public ItemLiquidVolume GetWaterAmountRemaining()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002683")]
	[Address(RVA = "0x8A19C0", Offset = "0x8A07C0", Length = "0x866")]
	public void UpdateRemedyItems(GameObject[] items)
	{
	}

	[Token(Token = "0x6002684")]
	[Address(RVA = "0x8A2230", Offset = "0x8A1030", Length = "0xE")]
	public void TakeAntibiotics()
	{
	}

	[Token(Token = "0x6002685")]
	[Address(RVA = "0x8A2240", Offset = "0x8A1040", Length = "0x91")]
	public void DrinkCleanWater(ItemLiquidVolume numLiters)
	{
	}

	[Token(Token = "0x6002686")]
	[Address(RVA = "0x8A22E0", Offset = "0x8A10E0", Length = "0x9E")]
	public void AddRest(float hours)
	{
	}

	[Token(Token = "0x6002687")]
	[Address(RVA = "0x8A2380", Offset = "0x8A1180", Length = "0x63")]
	public bool RollForDysentery()
	{
		return false;
	}

	[Token(Token = "0x6002688")]
	[Address(RVA = "0x8A23F0", Offset = "0x8A11F0", Length = "0x288")]
	private void UpdateDysentery()
	{
	}

	[Token(Token = "0x6002689")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Dysentery()
	{
	}
}
