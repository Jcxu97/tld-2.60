using AK.Wwise;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001428")]
public class KeroseneLampItem : MonoBehaviour
{
	[Token(Token = "0x4009302")]
	public static readonly ItemLiquidVolume HARVEST_FUEL_MIN_YIELD;

	[Token(Token = "0x4009303")]
	[FieldOffset(Offset = "0x20")]
	public ItemLiquidVolume m_MaxFuel;

	[SerializeField]
	[Token(Token = "0x4009304")]
	[FieldOffset(Offset = "0x28")]
	private ItemLiquidVolume m_FuelBurnPerHour;

	[Token(Token = "0x4009305")]
	[FieldOffset(Offset = "0x30")]
	public float m_TurnOnEffectsDelay;

	[Token(Token = "0x4009306")]
	[FieldOffset(Offset = "0x34")]
	public float m_TurnOffDelay;

	[Header("Audio")]
	[Token(Token = "0x4009307")]
	[FieldOffset(Offset = "0x38")]
	public AK.Wwise.Event m_TurnOnEvent;

	[Token(Token = "0x4009308")]
	[FieldOffset(Offset = "0x40")]
	public AK.Wwise.Event m_ExtinguishStartEvent;

	[Token(Token = "0x4009309")]
	[FieldOffset(Offset = "0x48")]
	public AK.Wwise.Event m_TurnOffEvent;

	[Token(Token = "0x400930A")]
	[FieldOffset(Offset = "0x50")]
	public AK.Wwise.Event m_LoopWithDelayEvent;

	[Token(Token = "0x400930B")]
	[FieldOffset(Offset = "0x58")]
	public AK.Wwise.Event m_LoopEvent;

	[Token(Token = "0x400930C")]
	[FieldOffset(Offset = "0x60")]
	public AK.Wwise.Event m_RefuelEvent;

	[Token(Token = "0x400930D")]
	[FieldOffset(Offset = "0x68")]
	public float m_RefuelTimeSeconds;

	[HideInInspector]
	[Token(Token = "0x400930E")]
	[FieldOffset(Offset = "0x6C")]
	public float m_TurnOnEffectsTimer;

	[Token(Token = "0x400930F")]
	[FieldOffset(Offset = "0x70")]
	public ItemLiquidVolume m_CurrentFuelLiters;

	[Token(Token = "0x4009310")]
	public static bool m_InfiniteLampOn;

	[Token(Token = "0x4009311")]
	[FieldOffset(Offset = "0x78")]
	public KeroseneLampIntensity m_IntensityComponent;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4009312")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_HUD> m_HUD;

	[HideInInspector]
	[Token(Token = "0x4009313")]
	[FieldOffset(Offset = "0x88")]
	public Color m_Color;

	[Token(Token = "0x4009314")]
	[FieldOffset(Offset = "0x98")]
	private uint m_TurnOnAudioID;

	[Token(Token = "0x4009315")]
	[FieldOffset(Offset = "0x9C")]
	private uint m_ExtinguishStartAudioID;

	[Token(Token = "0x4009316")]
	[FieldOffset(Offset = "0xA0")]
	private uint m_LoopAudioID;

	[Token(Token = "0x4009317")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_On;

	[Token(Token = "0x4009318")]
	[FieldOffset(Offset = "0xA5")]
	private bool m_TurnOnComplete;

	[Token(Token = "0x4009319")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_FXGameObject;

	[Token(Token = "0x400931A")]
	[FieldOffset(Offset = "0xB0")]
	private Light m_LightIndoor;

	[Token(Token = "0x400931B")]
	[FieldOffset(Offset = "0xB8")]
	private Light m_LightIndoorCore;

	[Token(Token = "0x400931C")]
	[FieldOffset(Offset = "0xC0")]
	private Light m_LightOutdoor;

	[Token(Token = "0x400931D")]
	[FieldOffset(Offset = "0xC8")]
	private float m_TurnOffTimer;

	[Token(Token = "0x400931E")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_TurningOff;

	[Token(Token = "0x400931F")]
	[FieldOffset(Offset = "0xD0")]
	private HeatSource m_HeatSource;

	[Token(Token = "0x4009320")]
	[FieldOffset(Offset = "0xD8")]
	private float m_TimeToBreak;

	[Token(Token = "0x4009321")]
	[FieldOffset(Offset = "0xE0")]
	private GearItem m_GearItem;

	[Token(Token = "0x4009322")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_FlareIsPaused;

	[Token(Token = "0x4009323")]
	private static KeroseneLampItemSaveDataProxy m_KeroseneLampItemSaveDataProxy;

	[Token(Token = "0x600808F")]
	[Address(RVA = "0x120AD30", Offset = "0x1209B30", Length = "0x6A6")]
	public void Awake()
	{
	}

	[Token(Token = "0x6008090")]
	[Address(RVA = "0x120B3E0", Offset = "0x120A1E0", Length = "0x2EF")]
	public void Update()
	{
	}

	[Token(Token = "0x6008091")]
	[Address(RVA = "0x120B6D0", Offset = "0x120A4D0", Length = "0x185")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6008092")]
	[Address(RVA = "0x120B860", Offset = "0x120A660", Length = "0x1AE")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6008093")]
	[Address(RVA = "0x120BA10", Offset = "0x120A810", Length = "0x8")]
	public bool IsOn()
	{
		return false;
	}

	[Token(Token = "0x6008094")]
	[Address(RVA = "0x120BA20", Offset = "0x120A820", Length = "0xA")]
	private void TurnOnAfterDelay()
	{
	}

	[Token(Token = "0x6008095")]
	[Address(RVA = "0x120BA30", Offset = "0x120A830", Length = "0x2D1")]
	private void TurnOn(bool supressStartAudio)
	{
	}

	[Token(Token = "0x6008096")]
	[Address(RVA = "0x120BD10", Offset = "0x120AB10", Length = "0x238")]
	public void TurnOff(bool playAudio = true)
	{
	}

	[Token(Token = "0x6008097")]
	[Address(RVA = "0x120BF50", Offset = "0x120AD50", Length = "0x1E6")]
	public void TurnOffDelayed()
	{
	}

	[Token(Token = "0x6008098")]
	[Address(RVA = "0x120C140", Offset = "0x120AF40", Length = "0xA")]
	private void OnExtinguishCompleteCallback()
	{
	}

	[Token(Token = "0x6008099")]
	[Address(RVA = "0x120C150", Offset = "0x120AF50", Length = "0x8")]
	public void PauseLight()
	{
	}

	[Token(Token = "0x600809A")]
	[Address(RVA = "0x120C160", Offset = "0x120AF60", Length = "0x8")]
	public void ResumeLight()
	{
	}

	[Token(Token = "0x600809B")]
	[Address(RVA = "0xA10E20", Offset = "0xA0FC20", Length = "0x8")]
	public bool IsPaused()
	{
		return false;
	}

	[Token(Token = "0x600809C")]
	[Address(RVA = "0x120C170", Offset = "0x120AF70", Length = "0x3B3")]
	public void Toggle()
	{
	}

	[Token(Token = "0x600809D")]
	[Address(RVA = "0x120C530", Offset = "0x120B330", Length = "0x1A3")]
	public void CancelAction()
	{
	}

	[Token(Token = "0x600809E")]
	[Address(RVA = "0x120C6E0", Offset = "0x120B4E0", Length = "0x113")]
	public ItemLiquidVolume AddFuel(ItemLiquidVolume fuelLiters)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x600809F")]
	[Address(RVA = "0x120C800", Offset = "0x120B600", Length = "0x5C")]
	public ItemLiquidVolume GetMaxFuelToAdd()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x60080A0")]
	[Address(RVA = "0x120C860", Offset = "0x120B660", Length = "0xA4")]
	public float GetPercentFuelRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x60080A1")]
	[Address(RVA = "0x120C910", Offset = "0x120B710", Length = "0xE5")]
	public void DestroyHeatSource()
	{
	}

	[Token(Token = "0x60080A2")]
	[Address(RVA = "0x120CA00", Offset = "0x120B800", Length = "0x4B")]
	public void HideEffects(bool hide)
	{
	}

	[Token(Token = "0x60080A3")]
	[Address(RVA = "0x120CA50", Offset = "0x120B850", Length = "0x5A")]
	public ItemLiquidVolume GetModifiedFuelBurnLitersPerHour()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x60080A4")]
	[Address(RVA = "0x120CAB0", Offset = "0x120B8B0", Length = "0xA")]
	public void OnDroppedInWater()
	{
	}

	[Token(Token = "0x60080A5")]
	[Address(RVA = "0x120CAC0", Offset = "0x120B8C0", Length = "0x57")]
	public void StopLoopingAudio()
	{
	}

	[Token(Token = "0x60080A6")]
	[Address(RVA = "0x120CB20", Offset = "0x120B920", Length = "0x132")]
	private void ReduceFuel(float hoursBurned)
	{
	}

	[Token(Token = "0x60080A7")]
	[Address(RVA = "0x120CC60", Offset = "0x120BA60", Length = "0x94")]
	private void UpdateLoopingAudioPosition()
	{
	}

	[Token(Token = "0x60080A8")]
	[Address(RVA = "0x120CD00", Offset = "0x120BB00", Length = "0x221")]
	private void UpdateEffects()
	{
	}

	[Token(Token = "0x60080A9")]
	[Address(RVA = "0x120CF30", Offset = "0x120BD30", Length = "0xB2")]
	private void OnIgniteComplete()
	{
	}

	[Token(Token = "0x60080AA")]
	[Address(RVA = "0x120CFF0", Offset = "0x120BDF0", Length = "0x24")]
	public bool IsIgniting()
	{
		return false;
	}

	[Token(Token = "0x60080AB")]
	[Address(RVA = "0x120D020", Offset = "0x120BE20", Length = "0x2E")]
	public bool IsIgnitingOrExtinguishing()
	{
		return false;
	}

	[Token(Token = "0x60080AC")]
	[Address(RVA = "0x120D050", Offset = "0x120BE50", Length = "0x47D")]
	private void PlayerSparkParticlesOnSpecific(GameObject turningOnFX)
	{
	}

	[Token(Token = "0x60080AD")]
	[Address(RVA = "0x120D4D0", Offset = "0x120C2D0", Length = "0x355")]
	private void PlaySparkParticles()
	{
	}

	[Token(Token = "0x60080AE")]
	[Address(RVA = "0x120D830", Offset = "0x120C630", Length = "0x503")]
	private void StopSparkParticles()
	{
	}

	[Token(Token = "0x60080AF")]
	[Address(RVA = "0x120DD40", Offset = "0x120CB40", Length = "0x90")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60080B0")]
	[Address(RVA = "0x120CAC0", Offset = "0x120B8C0", Length = "0x57")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60080B1")]
	[Address(RVA = "0x120CAC0", Offset = "0x120B8C0", Length = "0x57")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60080B2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public KeroseneLampItem()
	{
	}
}
