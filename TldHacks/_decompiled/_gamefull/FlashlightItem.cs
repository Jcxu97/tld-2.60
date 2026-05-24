using AK.Wwise;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200048D")]
public class FlashlightItem : MonoBehaviour
{
	[Token(Token = "0x200048E")]
	private enum State
	{
		[Token(Token = "0x4002998")]
		Off,
		[Token(Token = "0x4002999")]
		Low,
		[Token(Token = "0x400299A")]
		High,
		[Token(Token = "0x400299B")]
		Paused
	}

	[HideInInspector]
	[Token(Token = "0x400297C")]
	[FieldOffset(Offset = "0x20")]
	public Color m_Color;

	[Header("Objects")]
	[SerializeField]
	[Token(Token = "0x400297D")]
	[FieldOffset(Offset = "0x30")]
	private AuroraField m_AuroraField;

	[SerializeField]
	[Token(Token = "0x400297E")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_FxObjectLow;

	[SerializeField]
	[Token(Token = "0x400297F")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_FxObjectHigh;

	[SerializeField]
	[Token(Token = "0x4002980")]
	[FieldOffset(Offset = "0x48")]
	private Light m_LightIndoor;

	[SerializeField]
	[Token(Token = "0x4002981")]
	[FieldOffset(Offset = "0x50")]
	private Light m_LightOutdoor;

	[SerializeField]
	[Token(Token = "0x4002982")]
	[FieldOffset(Offset = "0x58")]
	private Light m_LightIndoorHigh;

	[SerializeField]
	[Token(Token = "0x4002983")]
	[FieldOffset(Offset = "0x60")]
	private Light m_LightOutdoorHigh;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4002984")]
	[FieldOffset(Offset = "0x68")]
	private AK.Wwise.Event m_TurnOnAudioEvent;

	[SerializeField]
	[Token(Token = "0x4002985")]
	[FieldOffset(Offset = "0x70")]
	private AK.Wwise.Event m_TurnOffAudioEvent;

	[SerializeField]
	[Token(Token = "0x4002986")]
	[FieldOffset(Offset = "0x78")]
	private AK.Wwise.Event m_IntensityAudioEvent;

	[Header("Battery")]
	[Tooltip("How many hours a full charge will last with the low beam on")]
	[SerializeField]
	[Token(Token = "0x4002987")]
	[FieldOffset(Offset = "0x80")]
	private float m_LowBeamDuration;

	[Tooltip("How many hours a full charge will last with the high beam on")]
	[SerializeField]
	[Token(Token = "0x4002988")]
	[FieldOffset(Offset = "0x84")]
	private float m_HighBeamDuration;

	[Tooltip("How many hours it takes the battery to recharge from empty")]
	[SerializeField]
	[Token(Token = "0x4002989")]
	[FieldOffset(Offset = "0x88")]
	private float m_RechargeTime;

	[Header("Misc")]
	[Tooltip("Cooldown on toggling on high intensity effects to prevent seizures.")]
	[SerializeField]
	[Token(Token = "0x400298A")]
	[FieldOffset(Offset = "0x8C")]
	private float m_HighBeamCooldownSeconds;

	[Header("AuroraField offset")]
	[SerializeField]
	[Token(Token = "0x400298B")]
	[FieldOffset(Offset = "0x90")]
	private float m_AuroraFieldForwardOffset;

	[SerializeField]
	[Token(Token = "0x400298C")]
	[FieldOffset(Offset = "0x94")]
	private float m_AuroraFieldVerticalOffset;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400298D")]
	[FieldOffset(Offset = "0x98")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x400298E")]
	[FieldOffset(Offset = "0xA0")]
	private GearItem m_GearItem;

	[Token(Token = "0x400298F")]
	[FieldOffset(Offset = "0xA8")]
	private State m_State;

	[Token(Token = "0x4002990")]
	[FieldOffset(Offset = "0xAC")]
	private State m_PreviousState;

	[Token(Token = "0x4002991")]
	[FieldOffset(Offset = "0xB0")]
	private uint m_TurnOnAudioId;

	[Token(Token = "0x4002992")]
	[FieldOffset(Offset = "0xB4")]
	private float m_CurrentBatteryCharge;

	[Token(Token = "0x4002993")]
	[FieldOffset(Offset = "0xB8")]
	private float m_HighBeamCooldownEndTime;

	[Token(Token = "0x4002994")]
	private static FlashlightItemSaveDataProxy m_FlashlightItemSaveDataProxy;

	[Token(Token = "0x4002995")]
	[FieldOffset(Offset = "0xBC")]
	private uint m_IntensityAudioID;

	[Token(Token = "0x4002996")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_FlareIsPaused;

	[Token(Token = "0x6002259")]
	[Address(RVA = "0x832C80", Offset = "0x831A80", Length = "0x1C9")]
	public void Awake()
	{
	}

	[Token(Token = "0x600225A")]
	[Address(RVA = "0x832E50", Offset = "0x831C50", Length = "0x8E0")]
	public void Update()
	{
	}

	[Token(Token = "0x600225B")]
	[Address(RVA = "0x833740", Offset = "0x832540", Length = "0x130")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600225C")]
	[Address(RVA = "0x833880", Offset = "0x832680", Length = "0xBB")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600225D")]
	[Address(RVA = "0x833940", Offset = "0x832740", Length = "0xDA")]
	public void DoRecharge(float deltaTODHours)
	{
	}

	[Token(Token = "0x600225E")]
	[Address(RVA = "0x833A20", Offset = "0x832820", Length = "0x9F")]
	public float GetNormalizedCharge()
	{
		return 0f;
	}

	[Token(Token = "0x600225F")]
	[Address(RVA = "0x833AC0", Offset = "0x8328C0", Length = "0x61")]
	public bool IsLit()
	{
		return false;
	}

	[Token(Token = "0x6002260")]
	[Address(RVA = "0x833B30", Offset = "0x832930", Length = "0xB")]
	public bool IsLow()
	{
		return false;
	}

	[Token(Token = "0x6002261")]
	[Address(RVA = "0x833B40", Offset = "0x832940", Length = "0x15")]
	public bool IsOn()
	{
		return false;
	}

	[Token(Token = "0x6002262")]
	[Address(RVA = "0x833B60", Offset = "0x832960", Length = "0x246")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6002263")]
	[Address(RVA = "0x833DB0", Offset = "0x832BB0", Length = "0x251")]
	public void TurnOn()
	{
	}

	[Token(Token = "0x6002264")]
	[Address(RVA = "0x834010", Offset = "0x832E10", Length = "0x18A")]
	public void TurnOff()
	{
	}

	[Token(Token = "0x6002265")]
	[Address(RVA = "0x8341A0", Offset = "0x832FA0", Length = "0x2D")]
	public void TurnOffImmediate()
	{
	}

	[Token(Token = "0x6002266")]
	[Address(RVA = "0x8341D0", Offset = "0x832FD0", Length = "0x8B")]
	private void OnTurnOnFXCallback()
	{
	}

	[Token(Token = "0x6002267")]
	[Address(RVA = "0x834260", Offset = "0x833060", Length = "0x11")]
	private void OnTurnOnCompleteCallback()
	{
	}

	[Token(Token = "0x6002268")]
	[Address(RVA = "0x834280", Offset = "0x833080", Length = "0x36")]
	private void OnTurnOffCompleteCallback()
	{
	}

	[Token(Token = "0x6002269")]
	[Address(RVA = "0x8342C0", Offset = "0x8330C0", Length = "0x1E")]
	public void PauseLight()
	{
	}

	[Token(Token = "0x600226A")]
	[Address(RVA = "0x8342E0", Offset = "0x8330E0", Length = "0x14")]
	public void ResumeLight()
	{
	}

	[Token(Token = "0x600226B")]
	[Address(RVA = "0x6BCD20", Offset = "0x6BBB20", Length = "0x8")]
	public bool IsPaused()
	{
		return false;
	}

	[Token(Token = "0x600226C")]
	[Address(RVA = "0x834300", Offset = "0x833100", Length = "0x7F")]
	private void ShowEquipItemPopup()
	{
	}

	[Token(Token = "0x600226D")]
	[Address(RVA = "0x834380", Offset = "0x833180", Length = "0x315")]
	private void EnableLights(State state)
	{
	}

	[Token(Token = "0x600226E")]
	[Address(RVA = "0x8346A0", Offset = "0x8334A0", Length = "0x7D")]
	private void PlayTurnOnAudio()
	{
	}

	[Token(Token = "0x600226F")]
	[Address(RVA = "0x834720", Offset = "0x833520", Length = "0x169")]
	private void PlayTurnOffAudio()
	{
	}

	[Token(Token = "0x6002270")]
	[Address(RVA = "0x834890", Offset = "0x833690", Length = "0x60D")]
	private void DoThreeDaysOfNightBonus()
	{
	}

	[Token(Token = "0x6002271")]
	[Address(RVA = "0x834EA0", Offset = "0x833CA0", Length = "0x12A")]
	private void UpdateAudio()
	{
	}

	[Token(Token = "0x6002272")]
	[Address(RVA = "0x834FD0", Offset = "0x833DD0", Length = "0x89")]
	public FlashlightItem()
	{
	}
}
