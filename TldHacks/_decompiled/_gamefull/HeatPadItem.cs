using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004B0")]
public class HeatPadItem : MonoBehaviour
{
	[Header("Tuning")]
	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x4002B51")]
	[FieldOffset(Offset = "0x20")]
	private float m_HoursUntilFullyActive;

	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x4002B52")]
	[FieldOffset(Offset = "0x24")]
	private float m_HoursFullyActive;

	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x4002B53")]
	[FieldOffset(Offset = "0x28")]
	private float m_HoursUntilExpired;

	[SerializeField]
	[Min(0f)]
	[Token(Token = "0x4002B54")]
	[FieldOffset(Offset = "0x2C")]
	private float m_MaxHeatBonus;

	[Header("UI")]
	[SerializeField]
	[Token(Token = "0x4002B55")]
	[FieldOffset(Offset = "0x30")]
	private LocalizedString m_ProgressBarMessage;

	[SerializeField]
	[Token(Token = "0x4002B56")]
	[FieldOffset(Offset = "0x38")]
	private float m_ProgressBarTimeSeconds;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4002B57")]
	[FieldOffset(Offset = "0x40")]
	private AK.Wwise.Event m_ActivatingAudio;

	[Token(Token = "0x4002B58")]
	[FieldOffset(Offset = "0x48")]
	private HeatPadState m_State;

	[Token(Token = "0x4002B59")]
	[FieldOffset(Offset = "0x50")]
	private GearItem m_GearItem;

	[Token(Token = "0x1700023C")]
	public string ProgressBarMessage
	{
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x74FF70", Offset = "0x74ED70", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023D")]
	public float ProgressBarTimeSeconds
	{
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x6208B0", Offset = "0x61F6B0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700023E")]
	public AK.Wwise.Event ActivatingAudio
	{
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023F")]
	public bool IsActivated
	{
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x85EA80", Offset = "0x85D880", Length = "0x1B")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000240")]
	public bool CanActivate
	{
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x85EAA0", Offset = "0x85D8A0", Length = "0x35")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000241")]
	public int MinutesRemaining
	{
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x85EAE0", Offset = "0x85D8E0", Length = "0x37")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000242")]
	public int TotalTimeActiveMinutes
	{
		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x85EB20", Offset = "0x85D920", Length = "0x1C")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000243")]
	private float TotalTimeActive
	{
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x85EB40", Offset = "0x85D940", Length = "0x10")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60023E6")]
	[Address(RVA = "0x85EB50", Offset = "0x85D950", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60023E7")]
	[Address(RVA = "0x85EBE0", Offset = "0x85D9E0", Length = "0xC9")]
	public float GetHeatBonus()
	{
		return 0f;
	}

	[Token(Token = "0x60023E8")]
	[Address(RVA = "0x85ECB0", Offset = "0x85DAB0", Length = "0x75")]
	public string GetHeatBonusText()
	{
		return null;
	}

	[Token(Token = "0x60023E9")]
	[Address(RVA = "0x85ED30", Offset = "0x85DB30", Length = "0x8A")]
	public void Activate()
	{
	}

	[Token(Token = "0x60023EA")]
	[Address(RVA = "0x85EDC0", Offset = "0x85DBC0", Length = "0x120")]
	public void ManualUpdate(float deltaTODHours)
	{
	}

	[Token(Token = "0x60023EB")]
	[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
	public HeatPadState Serialize()
	{
		return null;
	}

	[Token(Token = "0x60023EC")]
	[Address(RVA = "0x85EEF0", Offset = "0x85DCF0", Length = "0xF8")]
	public void Deserialize(HeatPadState state, float elapsedHours)
	{
	}

	[Token(Token = "0x60023ED")]
	[Address(RVA = "0x85EFF0", Offset = "0x85DDF0", Length = "0xC2")]
	public HeatPadItem()
	{
	}
}
