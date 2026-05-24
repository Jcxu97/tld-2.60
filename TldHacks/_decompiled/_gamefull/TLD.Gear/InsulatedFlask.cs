using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.Logging;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001422")]
public class InsulatedFlask : MonoBehaviour, ILiquidContainer
{
	[Token(Token = "0x2001423")]
	public class ItemSaveData
	{
		[Token(Token = "0x40092F7")]
		[FieldOffset(Offset = "0x10")]
		public string m_PrefabName;

		[Token(Token = "0x40092F8")]
		[FieldOffset(Offset = "0x18")]
		public GearItemSaveDataProxy m_SerializedGear;

		[Token(Token = "0x6008077")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ItemSaveData()
		{
		}
	}

	[Token(Token = "0x2001424")]
	public class SaveData
	{
		[Token(Token = "0x40092F9")]
		[FieldOffset(Offset = "0x10")]
		public string m_LiquidTypeName;

		[Token(Token = "0x40092FA")]
		[FieldOffset(Offset = "0x18")]
		public float m_HeatPercent;

		[Token(Token = "0x40092FB")]
		[FieldOffset(Offset = "0x1C")]
		public float m_HoursRemainingNextToFire;

		[Token(Token = "0x40092FC")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemSaveData> m_SerializedItems;

		[Token(Token = "0x6008078")]
		[Address(RVA = "0x120A8F0", Offset = "0x12096F0", Length = "0xAD")]
		public SaveData()
		{
		}
	}

	[Token(Token = "0x40092E7")]
	private static readonly LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x40092E8")]
	[FieldOffset(Offset = "0x20")]
	private ItemLiquidVolume m_Capacity;

	[Range(0f, 2f)]
	[SerializeField]
	[Token(Token = "0x40092E9")]
	[FieldOffset(Offset = "0x28")]
	private float m_PercentHeatLossPerMinuteIndoors;

	[Range(0f, 2f)]
	[SerializeField]
	[Token(Token = "0x40092EA")]
	[FieldOffset(Offset = "0x2C")]
	private float m_PercentHeatLossPerMinuteOutdoors;

	[SerializeField]
	[Token(Token = "0x40092EB")]
	[FieldOffset(Offset = "0x30")]
	private float m_RangeToPreventHeatLossWhenNextToFire;

	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x40092EC")]
	[FieldOffset(Offset = "0x34")]
	private float m_FallDamagePerMeter;

	[SerializeField]
	[Token(Token = "0x40092ED")]
	[FieldOffset(Offset = "0x38")]
	private InsulatedFlaskLiquidTypeConstraint m_ItemConstraints;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x40092EE")]
	[FieldOffset(Offset = "0x40")]
	private AK.Wwise.Event m_AddToFlask;

	[SerializeField]
	[Token(Token = "0x40092EF")]
	[FieldOffset(Offset = "0x48")]
	private AK.Wwise.Event m_RemoveFromFlask;

	[SerializeField]
	[Token(Token = "0x40092F0")]
	[FieldOffset(Offset = "0x50")]
	private RTPC m_FlaskVolume;

	[SerializeField]
	[HideInInspector]
	[AutoComponent(ComponentRequirement.Required)]
	[Token(Token = "0x40092F1")]
	[FieldOffset(Offset = "0x58")]
	private GearItem m_GearItem;

	[Token(Token = "0x40092F2")]
	[FieldOffset(Offset = "0x60")]
	private LiquidType m_LiquidType;

	[Token(Token = "0x40092F3")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<GearItemObject> m_Items;

	[Token(Token = "0x40092F4")]
	[FieldOffset(Offset = "0x70")]
	private ItemLiquidVolume m_VolumeLitres;

	[Token(Token = "0x40092F5")]
	[FieldOffset(Offset = "0x78")]
	private float m_HeatPercent;

	[Token(Token = "0x40092F6")]
	[FieldOffset(Offset = "0x80")]
	private readonly SaveData m_SaveData;

	[Token(Token = "0x17000B15")]
	public LiquidType LiquidType
	{
		[Token(Token = "0x6008055")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B16")]
	public bool ShouldDestroyWhenEmpty
	{
		[Token(Token = "0x6008056")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B17")]
	public GearItem GearItem
	{
		[Token(Token = "0x6008057")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008058")]
	[Address(RVA = "0x1206D00", Offset = "0x1205B00", Length = "0x42")]
	public int GetItemCount()
	{
		return 0;
	}

	[Token(Token = "0x6008059")]
	[Address(RVA = "0x1206D50", Offset = "0x1205B50", Length = "0x1A9")]
	public void GetAllItems(List<GearItem> items)
	{
	}

	[Token(Token = "0x600805A")]
	[Address(RVA = "0x1206F00", Offset = "0x1205D00", Length = "0x1F")]
	public bool IsItemCompatibleWithFlask(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x600805B")]
	[Address(RVA = "0x1206F20", Offset = "0x1205D20", Length = "0x3BD")]
	public bool TryAddItem(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x600805C")]
	[Address(RVA = "0x12072E0", Offset = "0x12060E0", Length = "0x234")]
	public bool TryRemoveItem(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x600805D")]
	[Address(RVA = "0x1207520", Offset = "0x1206320", Length = "0xC")]
	public void PlayItemAddedToFlaskAudio(GameObject target)
	{
	}

	[Token(Token = "0x600805E")]
	[Address(RVA = "0x1207530", Offset = "0x1206330", Length = "0xC")]
	public void PlayItemRemovedFromFlaskAudio(GameObject target)
	{
	}

	[Token(Token = "0x600805F")]
	[Address(RVA = "0x1207540", Offset = "0x1206340", Length = "0x309")]
	public void ManualUpdate(float deltaTODHours)
	{
	}

	[Token(Token = "0x6008060")]
	[Address(RVA = "0x1207850", Offset = "0x1206650", Length = "0x2E3")]
	public string GetFullnessLabelWithContents()
	{
		return null;
	}

	[Token(Token = "0x6008061")]
	[Address(RVA = "0x1207B40", Offset = "0x1206940", Length = "0x26")]
	public void ApplyFallDamage(float damageCausingFallHeight)
	{
	}

	[Token(Token = "0x6008062")]
	[Address(RVA = "0x1207B70", Offset = "0x1206970", Length = "0x3D4")]
	private bool IsItemCompatibleWithFlask(GearItem gearItem, out ILiquidContainer liquidContainer)
	{
		liquidContainer = null;
		return false;
	}

	[Token(Token = "0x6008063")]
	[Address(RVA = "0x1207F50", Offset = "0x1206D50", Length = "0x280")]
	public void SetAudioGameSyncs(GameObject gameObject)
	{
	}

	[Token(Token = "0x6008064")]
	[Address(RVA = "0x12081E0", Offset = "0x1206FE0", Length = "0x162")]
	public static bool IsFlask(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x6008065")]
	[Address(RVA = "0x1208350", Offset = "0x1207150", Length = "0x151")]
	private void PostAudioEvent(GameObject target, AK.Wwise.Event audioEvent)
	{
	}

	[Token(Token = "0x6008066")]
	[Address(RVA = "0x12084B0", Offset = "0x12072B0", Length = "0x167")]
	private void CalculateHeatLoss(float deltaTODHours)
	{
	}

	[Token(Token = "0x6008067")]
	[Address(RVA = "0x1208620", Offset = "0x1207420", Length = "0x1DE")]
	private void UpdateCachedValues()
	{
	}

	[Token(Token = "0x6008068")]
	[Address(RVA = "0x1208800", Offset = "0x1207600", Length = "0x21F")]
	private void UpdateVolume()
	{
	}

	[Token(Token = "0x6008069")]
	[Address(RVA = "0x1208A20", Offset = "0x1207820", Length = "0x291")]
	private void UpdateWeight()
	{
	}

	[Token(Token = "0x600806A")]
	[Address(RVA = "0x1208CC0", Offset = "0x1207AC0", Length = "0x3A5")]
	private bool IsNearFire()
	{
		return false;
	}

	[Token(Token = "0x600806B")]
	[Address(RVA = "0x1209070", Offset = "0x1207E70", Length = "0x41A")]
	private float GetRemainingTimeNextToFire()
	{
		return 0f;
	}

	[Token(Token = "0x600806C")]
	[Address(RVA = "0x1209490", Offset = "0x1208290", Length = "0x410")]
	public SaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x600806D")]
	[Address(RVA = "0x12098B0", Offset = "0x12086B0", Length = "0x8ED")]
	public void Deserialize(SaveData data, float elapsedHours)
	{
	}

	[Token(Token = "0x600806E")]
	[Address(RVA = "0x120A1A0", Offset = "0x1208FA0", Length = "0x53")]
	public ItemLiquidVolume AddLiquid(LiquidType type, ItemLiquidVolume volumeLitres, float heatPercent)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x600806F")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public ItemLiquidVolume GetCapacityLitres()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6008070")]
	[Address(RVA = "0x562C30", Offset = "0x561A30", Length = "0x6")]
	public float GetHeatPercent()
	{
		return 0f;
	}

	[Token(Token = "0x6008071")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void SetHeatPercent(float _)
	{
	}

	[Token(Token = "0x6008072")]
	[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
	public ItemLiquidVolume GetVolumeLitres()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6008073")]
	[Address(RVA = "0x120A200", Offset = "0x1209000", Length = "0x392")]
	public ItemLiquidVolume RemoveLiquid(ItemLiquidVolume volumeLitres, out float heatPercent)
	{
		heatPercent = default(float);
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6008074")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6008075")]
	[Address(RVA = "0x120A5A0", Offset = "0x12093A0", Length = "0x226")]
	public InsulatedFlask()
	{
	}
}
