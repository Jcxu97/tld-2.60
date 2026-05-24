using Cpp2ILInjected;
using Steamworks;

[Token(Token = "0x200013A")]
public class SteamAchievementPlatform : AchievementPlatformBase
{
	[Token(Token = "0x200013B")]
	private enum InternalState
	{
		[Token(Token = "0x40009E5")]
		BootStrapping,
		[Token(Token = "0x40009E6")]
		StatsAndAchievementsQueryRequested,
		[Token(Token = "0x40009E7")]
		StatsAndAchievementsQueryPending,
		[Token(Token = "0x40009E8")]
		StatsAndAchievementsQuerySuccessful,
		[Token(Token = "0x40009E9")]
		SystemOperational,
		[Token(Token = "0x40009EA")]
		SystemNotInitializedProperly
	}

	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x28")]
	private Callback<UserStatsReceived_t> m_OnUserStatsReceived;

	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x30")]
	private Callback<UserStatsStored_t> m_OnUserStatsStored;

	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x38")]
	private InternalState m_InternalState;

	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x5D2B50", Offset = "0x5D1950", Length = "0x13C")]
	public static void ResetAllAchievements()
	{
	}

	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x5D2C90", Offset = "0x5D1A90", Length = "0x381")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x5D3020", Offset = "0x5D1E20", Length = "0xA4")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x5D3240", Offset = "0x5D2040", Length = "0x162")]
	public override void Shutdown()
	{
	}

	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x5D33B0", Offset = "0x5D21B0", Length = "0x11F")]
	public override void Unlock(Achievement achievement)
	{
	}

	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x5D34D0", Offset = "0x5D22D0", Length = "0x109")]
	public override void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x5D35E0", Offset = "0x5D23E0", Length = "0x147")]
	private void RequestStatsAndAchievements()
	{
	}

	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x5D3730", Offset = "0x5D2530", Length = "0x3EC")]
	private void OnUserStatsReceived(UserStatsReceived_t callback)
	{
	}

	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x5D3B20", Offset = "0x5D2920", Length = "0xE")]
	private static void OnUserStatsStored(UserStatsStored_t callback)
	{
	}

	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SteamAchievementPlatform()
	{
	}
}
