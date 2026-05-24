using Cpp2ILInjected;

[Token(Token = "0x2000734")]
public class EpisodeManager
{
	[Token(Token = "0x4004C4D")]
	public const Episode MOST_RECENTLY_RELEASED_EPISODE = Episode.Four;

	[Token(Token = "0x4004C4E")]
	public static readonly int NumEpisodes;

	[Token(Token = "0x4004C4F")]
	public static EpisodeData[] m_Episodes;

	[Token(Token = "0x60040FC")]
	[Address(RVA = "0xC190A0", Offset = "0xC17EA0", Length = "0x379")]
	public static void Init()
	{
	}

	[Token(Token = "0x60040FD")]
	[Address(RVA = "0xC19420", Offset = "0xC18220", Length = "0x1CF")]
	public static void Shutdown()
	{
	}

	[Token(Token = "0x60040FE")]
	[Address(RVA = "0xC195F0", Offset = "0xC183F0", Length = "0xBC")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60040FF")]
	[Address(RVA = "0xC196B0", Offset = "0xC184B0", Length = "0x18C")]
	public static void Deserialize(string data)
	{
	}

	[Token(Token = "0x6004100")]
	[Address(RVA = "0xC19840", Offset = "0xC18640", Length = "0x7")]
	public static bool CanPlayEpisode(Episode episode)
	{
		return false;
	}

	[Token(Token = "0x6004101")]
	[Address(RVA = "0xC19850", Offset = "0xC18650", Length = "0x187")]
	public static Episode GetActiveEpisode()
	{
		return default(Episode);
	}

	[Token(Token = "0x6004102")]
	[Address(RVA = "0xC199E0", Offset = "0xC187E0", Length = "0x233")]
	public static void SetActiveEpisode(Episode episode)
	{
	}

	[Token(Token = "0x6004103")]
	[Address(RVA = "0xC19C20", Offset = "0xC18A20", Length = "0x73")]
	public static EpisodeState GetState(Episode episode)
	{
		return default(EpisodeState);
	}

	[Token(Token = "0x6004104")]
	[Address(RVA = "0xC19CA0", Offset = "0xC18AA0", Length = "0x7E")]
	public static void SetState(Episode episode, EpisodeState state)
	{
	}

	[Token(Token = "0x6004105")]
	[Address(RVA = "0xC19D20", Offset = "0xC18B20", Length = "0x14")]
	public static VoicePersona GetVoicePersona(Episode episode)
	{
		return default(VoicePersona);
	}

	[Token(Token = "0x6004106")]
	[Address(RVA = "0xC19D40", Offset = "0xC18B40", Length = "0x8E")]
	public static string GetDescriptionLocId(Episode episode)
	{
		return null;
	}

	[Token(Token = "0x6004107")]
	[Address(RVA = "0xC19DD0", Offset = "0xC18BD0", Length = "0x8E")]
	public static string GetNamedTitleLocId(Episode episode)
	{
		return null;
	}

	[Token(Token = "0x6004108")]
	[Address(RVA = "0xC19E60", Offset = "0xC18C60", Length = "0x76")]
	public static string GetHeaderLocId(Episode episode)
	{
		return null;
	}

	[Token(Token = "0x6004109")]
	[Address(RVA = "0xC19EE0", Offset = "0xC18CE0", Length = "0xDE")]
	public static string EpisodeLockedDestcription(Episode episode)
	{
		return null;
	}

	[Token(Token = "0x600410A")]
	[Address(RVA = "0xC19FC0", Offset = "0xC18DC0", Length = "0x31")]
	public static string GetLockedDescriptionFutureEpisode()
	{
		return null;
	}

	[Token(Token = "0x600410B")]
	[Address(RVA = "0xC1A000", Offset = "0xC18E00", Length = "0xB1")]
	public static bool NextEpisodeIsUnlocked(Episode episode)
	{
		return false;
	}

	[Token(Token = "0x600410C")]
	[Address(RVA = "0xC1A0C0", Offset = "0xC18EC0", Length = "0xD7")]
	public static bool HasCompletedEpisode(Episode episode)
	{
		return false;
	}

	[Token(Token = "0x600410D")]
	[Address(RVA = "0xC1A1A0", Offset = "0xC18FA0", Length = "0x76")]
	public static string GetEpisodeGenericNameLocId(Episode episode)
	{
		return null;
	}

	[Token(Token = "0x600410E")]
	[Address(RVA = "0xC1A220", Offset = "0xC19020", Length = "0xC6")]
	public static string GetEpisodeLargeTexturePath(Episode episode)
	{
		return null;
	}

	[Token(Token = "0x600410F")]
	[Address(RVA = "0xC1A2F0", Offset = "0xC190F0", Length = "0xFF")]
	public static Episode GetNextEpisode(Episode episode)
	{
		return default(Episode);
	}

	[Token(Token = "0x6004110")]
	[Address(RVA = "0xC1A3F0", Offset = "0xC191F0", Length = "0xD0")]
	public static Episode GetEpisodeFromInteger(int episode)
	{
		return default(Episode);
	}

	[Token(Token = "0x6004111")]
	[Address(RVA = "0xC1A4C0", Offset = "0xC192C0", Length = "0x1BA")]
	public static void UnlockAllToEpisode(Episode episode)
	{
	}

	[Token(Token = "0x6004112")]
	[Address(RVA = "0xC1A680", Offset = "0xC19480", Length = "0xE8")]
	private static void OnAchievementsChanged()
	{
	}

	[Token(Token = "0x6004113")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public EpisodeManager()
	{
	}
}
