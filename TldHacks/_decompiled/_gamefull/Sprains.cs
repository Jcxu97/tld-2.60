using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000538")]
public class Sprains : MonoBehaviour
{
	[Token(Token = "0x2000539")]
	public class SaveDataProxy
	{
		[Token(Token = "0x4003023")]
		[FieldOffset(Offset = "0x10")]
		public bool m_HadSprainRiskAffliction;

		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveDataProxy()
		{
		}
	}

	[Token(Token = "0x400300E")]
	private const int SLOPE_IGNORE_MASK = 2048;

	[Token(Token = "0x400300F")]
	[FieldOffset(Offset = "0x20")]
	private readonly int m_AnimParameter_ShowSprainWarning;

	[SerializeField]
	[Token(Token = "0x4003010")]
	[FieldOffset(Offset = "0x24")]
	private bool m_IsDebugging;

	[SerializeField]
	[Range(0f, 30f)]
	[Token(Token = "0x4003011")]
	[FieldOffset(Offset = "0x28")]
	private float m_CheckSecondsIntervalWhileSprainRisk;

	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4003012")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ChanceOfWristSprainWhenMoving;

	[Header("Risk of Sprains from Slopes")]
	[SerializeField]
	[Range(0f, 90f)]
	[Token(Token = "0x4003013")]
	[FieldOffset(Offset = "0x30")]
	private int m_MinSlopeDegreesForSprain;

	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4003014")]
	[FieldOffset(Offset = "0x34")]
	private float m_BaseChanceWhenMovingOnSlope;

	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4003015")]
	[FieldOffset(Offset = "0x38")]
	private float m_ChanceIncreaseEachDegreeAboveMinSlope;

	[Tooltip("How long the player has to move on a slope to be at risk. Should be longer than Min Seconds To Show Warning.")]
	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x4003016")]
	[FieldOffset(Offset = "0x3C")]
	private float m_MinSecondsForSlopeRisk;

	[Header("Risk of Sprains from Encumberance")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4003017")]
	[FieldOffset(Offset = "0x40")]
	private float m_ChanceIncreaseEncumbered;

	[Header("Risk of Sprains from Exhaustion")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4003018")]
	[FieldOffset(Offset = "0x44")]
	private float m_ChanceIncreaseExhausted;

	[Header("Risk of Sprains from Sprinting")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x4003019")]
	[FieldOffset(Offset = "0x48")]
	private float m_ChanceIncreaseSprinting;

	[Header("Risk of Sprains from Crouching")]
	[Tooltip("The amount to reduce the chance of sprains when moving while crouched. 100: never sprain when crouched.")]
	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x400301A")]
	[FieldOffset(Offset = "0x4C")]
	private float m_ChanceReduceWhenCrouchedPercent;

	[Header("Sprain Risk UI")]
	[Tooltip("How long the player has to move on a slope before the warning UI is shown. Should be shorter than Min Seconds For Slope Risk.")]
	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x400301B")]
	[FieldOffset(Offset = "0x50")]
	private float m_MinSecondsToShowWarning;

	[Tooltip("How long the player has to be off the slope before the warning UI is hidden. Should be shorter than Min Seconds For Slope Risk.")]
	[SerializeField]
	[Range(0f, 10f)]
	[Token(Token = "0x400301C")]
	[FieldOffset(Offset = "0x54")]
	private float m_MinSecondsBeforeHidingWarning;

	[SerializeField]
	[Token(Token = "0x400301D")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x400301E")]
	[FieldOffset(Offset = "0x60")]
	private SaveDataProxy m_SaveDataProxy;

	[Token(Token = "0x400301F")]
	[FieldOffset(Offset = "0x68")]
	private float m_SecondsOnSlope;

	[Token(Token = "0x4003020")]
	[FieldOffset(Offset = "0x6C")]
	private float m_SecondsOffSlope;

	[Token(Token = "0x4003021")]
	[FieldOffset(Offset = "0x70")]
	private float m_SecondsSprainRisk;

	[Token(Token = "0x4003022")]
	[FieldOffset(Offset = "0x74")]
	private bool m_HadSprainRiskAffliction;

	[Token(Token = "0x60027E0")]
	[Address(RVA = "0x8BBE00", Offset = "0x8BAC00", Length = "0x283")]
	private void Update()
	{
	}

	[Token(Token = "0x60027E1")]
	[Address(RVA = "0x8BC090", Offset = "0x8BAE90", Length = "0x9D")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60027E2")]
	[Address(RVA = "0x8BC130", Offset = "0x8BAF30", Length = "0x88")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60027E3")]
	[Address(RVA = "0x8BC1C0", Offset = "0x8BAFC0", Length = "0x846")]
	private void MaybeSprainWhileMoving()
	{
	}

	[Token(Token = "0x60027E4")]
	[Address(RVA = "0x8BCA10", Offset = "0x8BB810", Length = "0xCD")]
	private void UpdateSprainRiskWarning(float slopeDegrees)
	{
	}

	[Token(Token = "0x60027E5")]
	[Address(RVA = "0x8BCAE0", Offset = "0x8BB8E0", Length = "0x31")]
	private float ComputeSprainChanceForSlope(float slopeDegrees)
	{
		return 0f;
	}

	[Token(Token = "0x60027E6")]
	[Address(RVA = "0x8BCB20", Offset = "0x8BB920", Length = "0x70")]
	private float ComputeSprainChanceForEncumberance()
	{
		return 0f;
	}

	[Token(Token = "0x60027E7")]
	[Address(RVA = "0x8BCBA0", Offset = "0x8BB9A0", Length = "0x6D")]
	private float ComputeSprainChanceForExhaustion()
	{
		return 0f;
	}

	[Token(Token = "0x60027E8")]
	[Address(RVA = "0x8BCC10", Offset = "0x8BBA10", Length = "0x80")]
	private float ComputeSprainChanceForWeakJoints()
	{
		return 0f;
	}

	[Token(Token = "0x60027E9")]
	[Address(RVA = "0x8BCCA0", Offset = "0x8BBAA0", Length = "0xB4")]
	private float ModifyChanceForSprinting(float sprainChance)
	{
		return 0f;
	}

	[Token(Token = "0x60027EA")]
	[Address(RVA = "0x8BCD60", Offset = "0x8BBB60", Length = "0x106")]
	private float ModifyChanceForCrouching(float sprainChance)
	{
		return 0f;
	}

	[Token(Token = "0x60027EB")]
	[Address(RVA = "0x8BCE70", Offset = "0x8BBC70", Length = "0xD")]
	private bool AreSprainsFromSlopesBlocked()
	{
		return false;
	}

	[Token(Token = "0x60027EC")]
	[Address(RVA = "0x8BCE80", Offset = "0x8BBC80", Length = "0x7E")]
	private bool IsSlopeWarningShowing()
	{
		return false;
	}

	[Token(Token = "0x60027ED")]
	[Address(RVA = "0x8BCF00", Offset = "0x8BBD00", Length = "0x97")]
	private void ShowSlopeWarning(bool enable)
	{
	}

	[Token(Token = "0x60027EE")]
	[Address(RVA = "0x8BCFA0", Offset = "0x8BBDA0", Length = "0x18A")]
	private bool RollForSprainWhenMoving(float sprainChance)
	{
		return false;
	}

	[Token(Token = "0x60027EF")]
	[Address(RVA = "0x8BD130", Offset = "0x8BBF30", Length = "0x9D")]
	private void MaybeSprainWrist()
	{
	}

	[Token(Token = "0x60027F0")]
	[Address(RVA = "0x8BD1D0", Offset = "0x8BBFD0", Length = "0x9D")]
	private void MaybeSprainAnkle()
	{
	}

	[Token(Token = "0x60027F1")]
	[Address(RVA = "0x8BD270", Offset = "0x8BC070", Length = "0x8E")]
	public bool HasSprainsRiskAffliction()
	{
		return false;
	}

	[Token(Token = "0x60027F2")]
	[Address(RVA = "0x8BD300", Offset = "0x8BC100", Length = "0xD5")]
	public string GetSprainRiskAfflictionReason()
	{
		return null;
	}

	[Token(Token = "0x60027F3")]
	[Address(RVA = "0x8BD3E0", Offset = "0x8BC1E0", Length = "0x14E")]
	private void UpdateSprainRiskAffliction()
	{
	}

	[Token(Token = "0x60027F4")]
	[Address(RVA = "0x8BD530", Offset = "0x8BC330", Length = "0xE2")]
	public Sprains()
	{
	}
}
