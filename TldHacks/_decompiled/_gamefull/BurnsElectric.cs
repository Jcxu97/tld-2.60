using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000505")]
public class BurnsElectric : MonoBehaviour
{
	[Token(Token = "0x4002E04")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002E05")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002E06")]
	[FieldOffset(Offset = "0x30")]
	public float m_MaxHitPointsReduction;

	[Token(Token = "0x4002E07")]
	[FieldOffset(Offset = "0x34")]
	public float m_DurationHoursMin;

	[Token(Token = "0x4002E08")]
	[FieldOffset(Offset = "0x38")]
	public float m_DurationHoursMax;

	[Token(Token = "0x4002E09")]
	[FieldOffset(Offset = "0x3C")]
	public float m_ClothingDamagePerSecondMin;

	[Token(Token = "0x4002E0A")]
	[FieldOffset(Offset = "0x40")]
	public float m_ClothingDamagePerSecondMax;

	[Token(Token = "0x4002E0B")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_PainKillersPrefab;

	[Token(Token = "0x4002E0C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_BandagePrefab;

	[Header("Audio")]
	[Token(Token = "0x4002E0D")]
	[FieldOffset(Offset = "0x58")]
	public string m_BurnInitialDamageVO;

	[Token(Token = "0x4002E0E")]
	[FieldOffset(Offset = "0x60")]
	public string m_BurnSecondaryDamageVO;

	[Token(Token = "0x4002E0F")]
	[FieldOffset(Offset = "0x68")]
	public string m_BurnDamageReminderVO;

	[Token(Token = "0x4002E10")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_BurnReminderTimesInSeconds;

	[Token(Token = "0x4002E11")]
	[FieldOffset(Offset = "0x78")]
	public string m_IconSpriteName;

	[Token(Token = "0x4002E12")]
	[FieldOffset(Offset = "0x80")]
	public float m_InitialDamageVOCooldown;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002E13")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002E14")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002E15")]
	[FieldOffset(Offset = "0x98")]
	private bool m_Active;

	[Token(Token = "0x4002E16")]
	[FieldOffset(Offset = "0x9C")]
	private float m_ElapsedHours;

	[Token(Token = "0x4002E17")]
	[FieldOffset(Offset = "0xA0")]
	private float m_DurationHours;

	[Token(Token = "0x4002E18")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_PainKillersTaken;

	[Token(Token = "0x4002E19")]
	[FieldOffset(Offset = "0xA5")]
	private bool m_BandageApplied;

	[Token(Token = "0x4002E1A")]
	[FieldOffset(Offset = "0xA8")]
	private float m_ClothingDamagePerSecond;

	[Token(Token = "0x4002E1B")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002E1C")]
	[FieldOffset(Offset = "0xB0")]
	private int m_NumBurnRemindersPlayed;

	[Token(Token = "0x4002E1D")]
	[FieldOffset(Offset = "0xB4")]
	private float m_SecondsUntilNextBurnReminder;

	[Token(Token = "0x4002E1E")]
	[FieldOffset(Offset = "0xB8")]
	private float m_NextBurnInitialVOTimer;

	[Token(Token = "0x4002E1F")]
	private static BurnsElectricSaveDataProxy m_BurnsElectricSaveDataProxy;

	[Token(Token = "0x1700025D")]
	public string m_DisplayName
	{
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025E")]
	public string m_Description
	{
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002611")]
	[Address(RVA = "0x89BC90", Offset = "0x89AA90", Length = "0x18")]
	public void Start()
	{
	}

	[Token(Token = "0x6002612")]
	[Address(RVA = "0x89BCB0", Offset = "0x89AAB0", Length = "0x2E3")]
	public void Update()
	{
	}

	[Token(Token = "0x6002613")]
	[Address(RVA = "0x89BFA0", Offset = "0x89ADA0", Length = "0x1B7")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002614")]
	[Address(RVA = "0x89C160", Offset = "0x89AF60", Length = "0xE7")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002615")]
	[Address(RVA = "0x89C250", Offset = "0x89B050", Length = "0x307")]
	public void BurnsElectricStart(bool displayIcon, bool nofx = false)
	{
	}

	[Token(Token = "0x6002616")]
	[Address(RVA = "0x89C560", Offset = "0x89B360", Length = "0x11A")]
	public void BurnsElectricEnd(bool nofx = false)
	{
	}

	[Token(Token = "0x6002617")]
	[Address(RVA = "0x5023A0", Offset = "0x5011A0", Length = "0x8")]
	public bool HasBurnsElectric()
	{
		return false;
	}

	[Token(Token = "0x6002618")]
	[Address(RVA = "0x89C680", Offset = "0x89B480", Length = "0xB")]
	public bool RequiresBandage()
	{
		return false;
	}

	[Token(Token = "0x6002619")]
	[Address(RVA = "0x89C690", Offset = "0x89B490", Length = "0xB")]
	public bool RequiresPainkillers()
	{
		return false;
	}

	[Token(Token = "0x600261A")]
	[Address(RVA = "0x89C6A0", Offset = "0x89B4A0", Length = "0x24")]
	public void TakePainKillers()
	{
	}

	[Token(Token = "0x600261B")]
	[Address(RVA = "0x89C6D0", Offset = "0x89B4D0", Length = "0x24")]
	public void ApplyBandage()
	{
	}

	[Token(Token = "0x600261C")]
	[Address(RVA = "0x89C700", Offset = "0x89B500", Length = "0x350")]
	public void UpdateRemedyItems(GameObject[] items)
	{
	}

	[Token(Token = "0x600261D")]
	[Address(RVA = "0x89CA60", Offset = "0x89B860", Length = "0xA1")]
	public void ApplyClothingDamage(float realtimeSeconds)
	{
	}

	[Token(Token = "0x600261E")]
	[Address(RVA = "0x89CB10", Offset = "0x89B910", Length = "0x113")]
	private void UpdateBurnsElectric()
	{
	}

	[Token(Token = "0x600261F")]
	[Address(RVA = "0x89CC30", Offset = "0x89BA30", Length = "0x138")]
	private void MaybePlayBurnReminder()
	{
	}

	[Token(Token = "0x6002620")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BurnsElectric()
	{
	}
}
