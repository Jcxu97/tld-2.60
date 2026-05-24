using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001DD")]
public class Encumber : MonoBehaviour
{
	[Tooltip("Maximum weight player can carry without being encumbered (without fatigue)")]
	[SerializeField]
	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x20")]
	private ItemWeight m_MaxCarryCapacity;

	[Tooltip("Maximum weight player can carry without being encumbered (when exhausted)")]
	[SerializeField]
	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x28")]
	private ItemWeight m_MaxCarryCapacityWhenExhausted;

	[Tooltip("Start reducing carry capacity when fatigue reaches this level")]
	[Range(0f, 99f)]
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x30")]
	public float m_ReduceCarryCapacityAtFatigue;

	[SerializeField]
	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x38")]
	private ItemWeight m_NoSprintCarryCapacity;

	[SerializeField]
	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x40")]
	private ItemWeight m_NoWalkCarryCapacity;

	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0x48")]
	public float m_HourlyCalorieBurnPerKG;

	[SerializeField]
	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0x50")]
	private ItemWeight m_EncumberLowThreshold;

	[SerializeField]
	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x58")]
	private ItemWeight m_EncumberMedThreshold;

	[SerializeField]
	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0x60")]
	private ItemWeight m_EncumberHighThreshold;

	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0x68")]
	public string m_EncumberLowVoiceOver;

	[Token(Token = "0x400108F")]
	[FieldOffset(Offset = "0x70")]
	public string m_EncumberMedVoiceOver;

	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0x78")]
	public string m_EncumberHighVoiceOver;

	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0x80")]
	public float m_MinSecondsBetweenVoiceOverVariations;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001092")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4001093")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Token(Token = "0x4001094")]
	[FieldOffset(Offset = "0x98")]
	private EncumberLevel m_EcumberLevelForPreviousVoiceOver;

	[Token(Token = "0x4001095")]
	[FieldOffset(Offset = "0x9C")]
	private float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x4001096")]
	[FieldOffset(Offset = "0xA0")]
	private CarryingCapacityBuff.BuffValues m_CarryingCapacityBuffValues;

	[Token(Token = "0x4001097")]
	[FieldOffset(Offset = "0xA8")]
	private ItemWeight m_GearWeightKG;

	[Token(Token = "0x4001098")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_EncumberedInLog;

	[Token(Token = "0x4001099")]
	[FieldOffset(Offset = "0xB1")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x400109A")]
	private static EncumberSaveDataProxy m_EncumberSaveDataProxy;

	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x6357E0", Offset = "0x6345E0", Length = "0x12B")]
	public void Start()
	{
	}

	[Token(Token = "0x60010FD")]
	[Address(RVA = "0x635910", Offset = "0x634710", Length = "0x28D")]
	public void Update()
	{
	}

	[Token(Token = "0x60010FE")]
	[Address(RVA = "0x635BA0", Offset = "0x6349A0", Length = "0x129")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x635CD0", Offset = "0x634AD0", Length = "0x1D3")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001100")]
	[Address(RVA = "0x635EB0", Offset = "0x634CB0", Length = "0x28D")]
	public float GetEncumbranceSlowdownMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x6001101")]
	[Address(RVA = "0x636140", Offset = "0x634F40", Length = "0x7D")]
	public float GetHourlyCalorieBurnFromWeight()
	{
		return 0f;
	}

	[Token(Token = "0x6001102")]
	[Address(RVA = "0x6361C0", Offset = "0x634FC0", Length = "0xA2")]
	public bool IsCapacityBuffed()
	{
		return false;
	}

	[Token(Token = "0x6001103")]
	[Address(RVA = "0x636270", Offset = "0x635070", Length = "0x68")]
	public bool IsEncumbered()
	{
		return false;
	}

	[Token(Token = "0x6001104")]
	[Address(RVA = "0x6362E0", Offset = "0x6350E0", Length = "0x286")]
	public bool IsEncumberedIgnoringPlaceMesh()
	{
		return false;
	}

	[Token(Token = "0x6001105")]
	[Address(RVA = "0x636570", Offset = "0x635370", Length = "0x32C")]
	public ItemWeight GetEffectiveCarryCapacityKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6001106")]
	[Address(RVA = "0x6368A0", Offset = "0x6356A0", Length = "0xCC")]
	public string GetPlayerCarryCapacityString()
	{
		return null;
	}

	[Token(Token = "0x6001107")]
	[Address(RVA = "0x636970", Offset = "0x635770", Length = "0x59E")]
	public string GetCapacityString(ItemWeight weightKG, ItemWeight effectiveCapacityKG, ItemWeight capacityKG, ItemWeight capacityKGBuff)
	{
		return null;
	}

	[Token(Token = "0x6001108")]
	[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
	public ItemWeight GetGearWeightKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6001109")]
	[Address(RVA = "0x636F20", Offset = "0x635D20", Length = "0x99")]
	public ItemWeight GetMaxCarryCapacityKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600110A")]
	[Address(RVA = "0x636FC0", Offset = "0x635DC0", Length = "0x99")]
	public ItemWeight GetMaxCarryCapacityWhenExhaustedKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600110B")]
	[Address(RVA = "0x637060", Offset = "0x635E60", Length = "0x99")]
	public ItemWeight GetNoSprintCarryCapacityKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600110C")]
	[Address(RVA = "0x637100", Offset = "0x635F00", Length = "0x99")]
	public ItemWeight GetNoWalkCarryCapacityKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600110D")]
	[Address(RVA = "0x6371A0", Offset = "0x635FA0", Length = "0x99")]
	public ItemWeight GetEncumberLowThresholdKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600110E")]
	[Address(RVA = "0x637240", Offset = "0x636040", Length = "0x99")]
	public ItemWeight GetEncumberMedThresholdKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x600110F")]
	[Address(RVA = "0x6372E0", Offset = "0x6360E0", Length = "0x99")]
	public ItemWeight GetEncumberHighThresholdKG()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6001110")]
	[Address(RVA = "0x637380", Offset = "0x636180", Length = "0x4B")]
	private bool ShouldPlayEncumbereVoiceOver()
	{
		return false;
	}

	[Token(Token = "0x6001111")]
	[Address(RVA = "0x6373D0", Offset = "0x6361D0", Length = "0x139")]
	private void MaybePlayerEncumberStatusVoiceOver()
	{
	}

	[Token(Token = "0x6001112")]
	[Address(RVA = "0x637510", Offset = "0x636310", Length = "0x244")]
	private EncumberLevel GetEncumberLevel()
	{
		return default(EncumberLevel);
	}

	[Token(Token = "0x6001113")]
	[Address(RVA = "0x637760", Offset = "0x636560", Length = "0x47C")]
	private void UpdateEncumberedStatusOnHUD()
	{
	}

	[Token(Token = "0x6001114")]
	[Address(RVA = "0x637BE0", Offset = "0x6369E0", Length = "0x4E")]
	private void MaybeUpdateEncumberedStatusInLog()
	{
	}

	[Token(Token = "0x6001115")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Encumber()
	{
	}
}
