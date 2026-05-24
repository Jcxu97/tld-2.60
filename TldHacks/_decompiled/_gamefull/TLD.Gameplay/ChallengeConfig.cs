using Cpp2ILInjected;
using TLD.Gear;
using TLD.SaveState;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Challenge Config")]
[Token(Token = "0x2001463")]
public class ChallengeConfig : SandboxBaseConfig
{
	[Token(Token = "0x2001464")]
	public enum BestTimeStyle
	{
		[Token(Token = "0x4009400")]
		LowerIsBetter,
		[Token(Token = "0x4009401")]
		HigherIsBetter
	}

	[SerializeField]
	[Token(Token = "0x40093F0")]
	[FieldOffset(Offset = "0xA0")]
	private StartGearData m_StartGearOverride;

	[Header("Challenge UI Data")]
	[SerializeField]
	[Token(Token = "0x40093F1")]
	[FieldOffset(Offset = "0xA8")]
	private AssetReferenceTexture2D m_ChallengeTexture;

	[SerializeField]
	[Token(Token = "0x40093F2")]
	[FieldOffset(Offset = "0xB0")]
	private LocalizedString m_Header;

	[SerializeField]
	[Token(Token = "0x40093F3")]
	[FieldOffset(Offset = "0xB8")]
	private LocalizedString m_StartDescription;

	[SerializeField]
	[Token(Token = "0x40093F4")]
	[FieldOffset(Offset = "0xC0")]
	private LocalizedString m_Instructions;

	[SerializeField]
	[Token(Token = "0x40093F5")]
	[FieldOffset(Offset = "0xC8")]
	private LocalizedString m_Bullets;

	[Range(0f, 6f)]
	[Token(Token = "0x40093F6")]
	[FieldOffset(Offset = "0xD0")]
	public int m_Difficulty;

	[Header("Badge")]
	[SerializeField]
	[Token(Token = "0x40093F7")]
	[FieldOffset(Offset = "0xD8")]
	private BadgeUIInfo m_BadgeToUnlock;

	[Header("Challenge Settings")]
	[Token(Token = "0x40093F8")]
	[FieldOffset(Offset = "0xE0")]
	public bool m_IsTimed;

	[Token(Token = "0x40093F9")]
	[FieldOffset(Offset = "0xE8")]
	public SceneWeatherOverrideData m_SceneWeatherOverrideData;

	[SerializeField]
	[Token(Token = "0x40093FA")]
	[FieldOffset(Offset = "0xF0")]
	private GameModeWeatherTransitionWeightOverride m_WeatherTransitionWeightOverride;

	[SerializeField]
	[Token(Token = "0x40093FB")]
	[FieldOffset(Offset = "0xF8")]
	private ChallengeLockCondition[] m_LockConditions;

	[SerializeField]
	[Token(Token = "0x40093FC")]
	[FieldOffset(Offset = "0x100")]
	private ScriptableAction[] m_EndChallengeActions;

	[SerializeField]
	[Token(Token = "0x40093FD")]
	[FieldOffset(Offset = "0x108")]
	private AlternateElapsedTimeSource m_AlternateElapsedTimeSource;

	[SerializeField]
	[Token(Token = "0x40093FE")]
	[FieldOffset(Offset = "0x110")]
	private BestTimeStyle m_BestTimeStyle;

	[Token(Token = "0x17000B3B")]
	public override StartGearData StartGear
	{
		[Token(Token = "0x60081BA")]
		[Address(RVA = "0x1224840", Offset = "0x1223640", Length = "0x1B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3C")]
	public BadgeInfoType UnlockedBadge
	{
		[Token(Token = "0x60081BB")]
		[Address(RVA = "0x1224A00", Offset = "0x1223800", Length = "0xF1")]
		get
		{
			return default(BadgeInfoType);
		}
	}

	[Token(Token = "0x60081BC")]
	[Address(RVA = "0x1224B00", Offset = "0x1223900", Length = "0xD3")]
	public bool IsLocked()
	{
		return false;
	}

	[Token(Token = "0x60081BD")]
	[Address(RVA = "0x1224BE0", Offset = "0x12239E0", Length = "0x10E")]
	public AssetReferenceTexture2D GetChallengeTexture()
	{
		return null;
	}

	[Token(Token = "0x60081BE")]
	[Address(RVA = "0x1224CF0", Offset = "0x1223AF0", Length = "0xE6")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x60081BF")]
	[Address(RVA = "0x1224DE0", Offset = "0x1223BE0", Length = "0x143")]
	public string GetHeaderText()
	{
		return null;
	}

	[Token(Token = "0x60081C0")]
	[Address(RVA = "0x1224F30", Offset = "0x1223D30", Length = "0x143")]
	public string GetStartDescriptionText()
	{
		return null;
	}

	[Token(Token = "0x60081C1")]
	[Address(RVA = "0x1225080", Offset = "0x1223E80", Length = "0x143")]
	public string GetInstructionText()
	{
		return null;
	}

	[Token(Token = "0x60081C2")]
	[Address(RVA = "0x12251D0", Offset = "0x1223FD0", Length = "0x60")]
	public string GetBulletText()
	{
		return null;
	}

	[Token(Token = "0x60081C3")]
	[Address(RVA = "0x1225240", Offset = "0x1224040", Length = "0xEF")]
	public AssetReferenceTexture2D GetBadgeIcon()
	{
		return null;
	}

	[Token(Token = "0x60081C4")]
	[Address(RVA = "0x1225330", Offset = "0x1224130", Length = "0x7")]
	public BestTimeStyle GetBestTimeStyle()
	{
		return default(BestTimeStyle);
	}

	[Token(Token = "0x60081C5")]
	[Address(RVA = "0x1225340", Offset = "0x1224140", Length = "0x19E")]
	public float MaybeUpdateBestTime()
	{
		return 0f;
	}

	[Token(Token = "0x60081C6")]
	[Address(RVA = "0x12254E0", Offset = "0x12242E0", Length = "0x146")]
	public void MaybeUnlockChallengeBadge()
	{
	}

	[Token(Token = "0x60081C7")]
	[Address(RVA = "0x1225630", Offset = "0x1224430", Length = "0x148")]
	public float GetElapsedTimeInHours()
	{
		return 0f;
	}

	[Token(Token = "0x60081C8")]
	[Address(RVA = "0x1225780", Offset = "0x1224580", Length = "0x134")]
	public override void EndGame()
	{
	}

	[Token(Token = "0x60081C9")]
	[Address(RVA = "0x12258C0", Offset = "0x12246C0", Length = "0xFE")]
	public override void ApplyCustomWeatherTransitionWeights(WeatherTransitionWeights weights)
	{
	}

	[Token(Token = "0x60081CA")]
	[Address(RVA = "0x12259C0", Offset = "0x12247C0", Length = "0x142")]
	private ChallengeLockCondition GetLockedCondition()
	{
		return null;
	}

	[Token(Token = "0x60081CB")]
	[Address(RVA = "0x1225B10", Offset = "0x1224910", Length = "0x7")]
	public ChallengeConfig()
	{
	}
}
