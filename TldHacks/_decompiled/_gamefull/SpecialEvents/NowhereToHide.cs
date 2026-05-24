using Cpp2ILInjected;
using TLD.Gameplay;

namespace SpecialEvents;

[Token(Token = "0x2000D42")]
public static class NowhereToHide
{
	[Token(Token = "0x2000D43")]
	public enum GlyphTypes
	{
		[Token(Token = "0x40082C7")]
		None,
		[Token(Token = "0x40082C8")]
		DispelFog,
		[Token(Token = "0x40082C9")]
		Lure,
		[Token(Token = "0x40082CA")]
		Ward
	}

	[Token(Token = "0x40082C2")]
	private const string GAME_MODE_CONFIG_KEY = "ChallengeNowhereToHide";

	[Token(Token = "0x40082C3")]
	private const int LAST_DW_EVENT_CHANGELIST = 69021;

	[Token(Token = "0x40082C4")]
	public static bool s_Debug;

	[Token(Token = "0x40082C5")]
	private static GameModeConfig s_NowhereToHideGameMode;

	[Token(Token = "0x6006802")]
	[Address(RVA = "0x105DE40", Offset = "0x105CC40", Length = "0x8D")]
	public static bool IsCurrentExperienceMode()
	{
		return false;
	}

	[Token(Token = "0x6006803")]
	[Address(RVA = "0x105DED0", Offset = "0x105CCD0", Length = "0x185")]
	public static bool MatchesExperienceMode(GameModeConfig xpMode)
	{
		return false;
	}

	[Token(Token = "0x6006804")]
	[Address(RVA = "0x105E060", Offset = "0x105CE60", Length = "0x6E")]
	public static void PostEventDeleteSaveSlot(SaveSlotInfo ssi)
	{
	}

	[Token(Token = "0x6006805")]
	[Address(RVA = "0x105E0D0", Offset = "0x105CED0", Length = "0x1F9")]
	private static GameModeConfig GetChallengeConfig()
	{
		return null;
	}
}
