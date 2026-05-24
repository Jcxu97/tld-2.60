using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200052D")]
public class SevereLacerations : MonoBehaviour
{
	[Header("General")]
	[SerializeField]
	[Token(Token = "0x4002F9D")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_DisplayName;

	[SerializeField]
	[Token(Token = "0x4002F9E")]
	[FieldOffset(Offset = "0x28")]
	private float m_TimeActiveHours;

	[Header("Damage")]
	[SerializeField]
	[Token(Token = "0x4002F9F")]
	[FieldOffset(Offset = "0x2C")]
	private float m_MinimumDamage;

	[SerializeField]
	[Token(Token = "0x4002FA0")]
	[FieldOffset(Offset = "0x30")]
	private float m_MaximumDamage;

	[Header("Wounds")]
	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4002FA1")]
	[FieldOffset(Offset = "0x34")]
	private int m_MinWounds;

	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4002FA2")]
	[FieldOffset(Offset = "0x38")]
	private int m_MaxWounds;

	[SerializeField]
	[Token(Token = "0x4002FA3")]
	[FieldOffset(Offset = "0x3C")]
	private float m_WoundEscalationInterval;

	[Header("Pain")]
	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4002FA4")]
	[FieldOffset(Offset = "0x40")]
	private float m_PainPulseIntensity;

	[Header("Debuffs")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4002FA5")]
	[FieldOffset(Offset = "0x44")]
	private float m_ConditionCap;

	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4002FA6")]
	[FieldOffset(Offset = "0x48")]
	private float m_StaminaReduction;

	[Token(Token = "0x4002FA7")]
	[FieldOffset(Offset = "0x50")]
	private SevereLacerationsSaveData m_CurrentState;

	[Token(Token = "0x1700027C")]
	public float ConditionCap
	{
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x509B50", Offset = "0x508950", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700027D")]
	public float StaminaReduction
	{
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x5737C0", Offset = "0x5725C0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700027E")]
	[field: Token(Token = "0x4002FA8")]
	[field: FieldOffset(Offset = "0x58")]
	public float DurationLeftHours
	{
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x5094E0", Offset = "0x5082E0", Length = "0x6")]
		get;
		[Token(Token = "0x6002781")]
		[Address(RVA = "0x5094F0", Offset = "0x5082F0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x1700027F")]
	public float DurationLeftNormalized
	{
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x8B3E50", Offset = "0x8B2C50", Length = "0xB")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000280")]
	public string CauseLocID
	{
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x8B3E60", Offset = "0x8B2C60", Length = "0x1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002784")]
	[Address(RVA = "0x8B3E80", Offset = "0x8B2C80", Length = "0xE")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6002785")]
	[Address(RVA = "0x8B3E90", Offset = "0x8B2C90", Length = "0x1B")]
	public bool HasAffliction()
	{
		return false;
	}

	[Token(Token = "0x6002786")]
	[Address(RVA = "0x8B3EB0", Offset = "0x8B2CB0", Length = "0x616")]
	public void ApplySevereLacerations(string causeID, AfflictionOptions options = AfflictionOptions.PlayFX | AfflictionOptions.DoAutoSave)
	{
	}

	[Token(Token = "0x6002787")]
	[Address(RVA = "0x8B44D0", Offset = "0x8B32D0", Length = "0x15D")]
	private void ApplyChestWound()
	{
	}

	[Token(Token = "0x6002788")]
	[Address(RVA = "0x8B4630", Offset = "0x8B3430", Length = "0x11B")]
	private void ApplyWound()
	{
	}

	[Token(Token = "0x6002789")]
	[Address(RVA = "0x8B4750", Offset = "0x8B3550", Length = "0x1BF")]
	private void Update()
	{
	}

	[Token(Token = "0x600278A")]
	[Address(RVA = "0x8B4910", Offset = "0x8B3710", Length = "0x3E6")]
	private bool HaveAnyActiveWounds()
	{
		return false;
	}

	[Token(Token = "0x600278B")]
	[Address(RVA = "0x8B4D00", Offset = "0x8B3B00", Length = "0x139")]
	public void Cure(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x600278C")]
	[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
	public SevereLacerationsSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x600278D")]
	[Address(RVA = "0x8B4E40", Offset = "0x8B3C40", Length = "0x10F")]
	public void Deserialize(SevereLacerationsSaveData lacerationSaveData)
	{
	}

	[Token(Token = "0x600278E")]
	[Address(RVA = "0x8B4F50", Offset = "0x8B3D50", Length = "0xC2")]
	public SevereLacerations()
	{
	}
}
