using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000503")]
public class Burns : MonoBehaviour
{
	[Token(Token = "0x4002DE1")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002DE2")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002DE3")]
	[FieldOffset(Offset = "0x30")]
	public float m_MaxHitPointsReduction;

	[Token(Token = "0x4002DE4")]
	[FieldOffset(Offset = "0x34")]
	public float m_DurationHoursMin;

	[Token(Token = "0x4002DE5")]
	[FieldOffset(Offset = "0x38")]
	public float m_DurationHoursMax;

	[Token(Token = "0x4002DE6")]
	[FieldOffset(Offset = "0x3C")]
	public float m_ClothingDamagePerSecondMin;

	[Token(Token = "0x4002DE7")]
	[FieldOffset(Offset = "0x40")]
	public float m_ClothingDamagePerSecondMax;

	[Token(Token = "0x4002DE8")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_PainKillersPrefab;

	[Token(Token = "0x4002DE9")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_BandagePrefab;

	[Header("Audio")]
	[Token(Token = "0x4002DEA")]
	[FieldOffset(Offset = "0x58")]
	public string m_BurnInitialDamageVO;

	[Token(Token = "0x4002DEB")]
	[FieldOffset(Offset = "0x60")]
	public string m_BurnSecondaryDamageVO;

	[Token(Token = "0x4002DEC")]
	[FieldOffset(Offset = "0x68")]
	public string m_BurnDamageReminderVO;

	[Token(Token = "0x4002DED")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_BurnReminderTimesInSeconds;

	[Token(Token = "0x4002DEE")]
	[FieldOffset(Offset = "0x78")]
	public float m_InitialDamageVOCooldown;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002DEF")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002DF0")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002DF1")]
	[FieldOffset(Offset = "0x90")]
	private bool m_Active;

	[Token(Token = "0x4002DF2")]
	[FieldOffset(Offset = "0x94")]
	private float m_ElapsedHours;

	[Token(Token = "0x4002DF3")]
	[FieldOffset(Offset = "0x98")]
	private float m_DurationHours;

	[Token(Token = "0x4002DF4")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_PainKillersTaken;

	[Token(Token = "0x4002DF5")]
	[FieldOffset(Offset = "0x9D")]
	private bool m_BandageApplied;

	[Token(Token = "0x4002DF6")]
	[FieldOffset(Offset = "0xA0")]
	private float m_ClothingDamagePerSecond;

	[Token(Token = "0x4002DF7")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002DF8")]
	[FieldOffset(Offset = "0xA8")]
	private int m_NumBurnRemindersPlayed;

	[Token(Token = "0x4002DF9")]
	[FieldOffset(Offset = "0xAC")]
	private float m_SecondsUntilNextBurnReminder;

	[Token(Token = "0x4002DFA")]
	[FieldOffset(Offset = "0xB0")]
	private string m_CauseLocID;

	[Token(Token = "0x4002DFB")]
	[FieldOffset(Offset = "0xB8")]
	private float m_NextBurnInitialVOTimer;

	[Token(Token = "0x4002DFC")]
	private static BurnsSaveDataProxy m_BurnsSaveDataProxy;

	[Token(Token = "0x60025FC")]
	[Address(RVA = "0x89A930", Offset = "0x899730", Length = "0x18")]
	public void Start()
	{
	}

	[Token(Token = "0x60025FD")]
	[Address(RVA = "0x89A950", Offset = "0x899750", Length = "0x2E3")]
	public void Update()
	{
	}

	[Token(Token = "0x60025FE")]
	[Address(RVA = "0x89AC40", Offset = "0x899A40", Length = "0x223")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60025FF")]
	[Address(RVA = "0x89AE70", Offset = "0x899C70", Length = "0x143")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002600")]
	[Address(RVA = "0x89AFC0", Offset = "0x899DC0", Length = "0x3A3")]
	public void BurnsStart(string causeLocID, bool displayIcon, bool nofx = false, AfflictionOptions options = AfflictionOptions.None)
	{
	}

	[Token(Token = "0x6002601")]
	[Address(RVA = "0x89B370", Offset = "0x89A170", Length = "0x11A")]
	public void BurnsEnd(bool nofx = false)
	{
	}

	[Token(Token = "0x6002602")]
	[Address(RVA = "0x89B490", Offset = "0x89A290", Length = "0x8")]
	public bool HasBurns()
	{
		return false;
	}

	[Token(Token = "0x6002603")]
	[Address(RVA = "0x89B4A0", Offset = "0x89A2A0", Length = "0xB")]
	public bool RequiresBandage()
	{
		return false;
	}

	[Token(Token = "0x6002604")]
	[Address(RVA = "0x89B4B0", Offset = "0x89A2B0", Length = "0xB")]
	public bool RequiresPainkillers()
	{
		return false;
	}

	[Token(Token = "0x6002605")]
	[Address(RVA = "0x89B4C0", Offset = "0x89A2C0", Length = "0x24")]
	public void TakePainKillers()
	{
	}

	[Token(Token = "0x6002606")]
	[Address(RVA = "0x89B4F0", Offset = "0x89A2F0", Length = "0x24")]
	public void ApplyBandage()
	{
	}

	[Token(Token = "0x6002607")]
	[Address(RVA = "0x89B520", Offset = "0x89A320", Length = "0x350")]
	public void UpdateRemedyItems(GameObject[] items)
	{
	}

	[Token(Token = "0x6002608")]
	[Address(RVA = "0x89B880", Offset = "0x89A680", Length = "0xA1")]
	public void ApplyClothingDamage(float realtimeSeconds)
	{
	}

	[Token(Token = "0x6002609")]
	[Address(RVA = "0x89B930", Offset = "0x89A730", Length = "0x49")]
	public string GetCauseLocID()
	{
		return null;
	}

	[Token(Token = "0x600260A")]
	[Address(RVA = "0x89B980", Offset = "0x89A780", Length = "0x113")]
	private void UpdateBurns()
	{
	}

	[Token(Token = "0x600260B")]
	[Address(RVA = "0x89BAA0", Offset = "0x89A8A0", Length = "0x138")]
	private void MaybePlayBurnReminder()
	{
	}

	[Token(Token = "0x600260C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Burns()
	{
	}
}
