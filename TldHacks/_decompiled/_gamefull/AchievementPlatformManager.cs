using System.Runtime.CompilerServices;
using Cpp2ILInjected;

[Token(Token = "0x2000133")]
public static class AchievementPlatformManager
{
	[Token(Token = "0x2000134")]
	public delegate void AchievementsChangedHandler();

	[Token(Token = "0x4000970")]
	private static IAchievementPlatform s_AchievementPlatform;

	[Token(Token = "0x4000971")]
	public static readonly int NumStatistics;

	[Token(Token = "0x4000972")]
	public static readonly int NumAchievements;

	[Token(Token = "0x170001A3")]
	public static bool AchievementsEnabledOnThisPlatform
	{
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x5D1D00", Offset = "0x5D0B00", Length = "0x57")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170001A4")]
	public static bool IsFullyOperational
	{
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x5D2000", Offset = "0x5D0E00", Length = "0xA1")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x14000001")]
	public static event AchievementsChangedHandler OnAchievementsChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x5D1D60", Offset = "0x5D0B60", Length = "0x14F")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x5D1EB0", Offset = "0x5D0CB0", Length = "0x14F")]
		remove
		{
		}
	}

	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x5D20B0", Offset = "0x5D0EB0", Length = "0x158")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x5D2210", Offset = "0x5D1010", Length = "0x177")]
	public static void Update()
	{
	}

	[Token(Token = "0x6000B35")]
	[Address(RVA = "0x5D2390", Offset = "0x5D1190", Length = "0x10B")]
	public static void Shutdown()
	{
	}

	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x5D24A0", Offset = "0x5D12A0", Length = "0xA2")]
	public static void ListAllUnlockedAchievements()
	{
	}

	[Token(Token = "0x6000B37")]
	[Address(RVA = "0x5D2550", Offset = "0x5D1350", Length = "0xAB")]
	public static void Unlock(Achievement achievement)
	{
	}

	[Token(Token = "0x6000B38")]
	[Address(RVA = "0x5D2600", Offset = "0x5D1400", Length = "0xAD")]
	public static bool IsUnlocked(Achievement achievement)
	{
		return false;
	}

	[Token(Token = "0x6000B39")]
	[Address(RVA = "0x5D26B0", Offset = "0x5D14B0", Length = "0xB5")]
	public static void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x5D2770", Offset = "0x5D1570", Length = "0xB9")]
	public static void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0x5D2830", Offset = "0x5D1630", Length = "0xAB")]
	public static void SendStatistic(GameEventStatType statistic)
	{
	}

	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0x5D28E0", Offset = "0x5D16E0", Length = "0x35")]
	private static IAchievementPlatform AllocatePlatform()
	{
		return null;
	}
}
