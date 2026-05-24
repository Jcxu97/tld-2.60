using Cpp2ILInjected;
using TLD.Gameplay;

[Token(Token = "0x2000421")]
public static class GameModeFilterExtensions
{
	[Token(Token = "0x6001F3C")]
	[Address(RVA = "0x7D88D0", Offset = "0x7D76D0", Length = "0x37C")]
	public static bool PassesGameModeFilter(this GameModeFilter mode)
	{
		return false;
	}

	[Token(Token = "0x6001F3D")]
	[Address(RVA = "0x7D8C70", Offset = "0x7D7A70", Length = "0x178")]
	private static GameModeConfig GetChallengeMode(GameModeFilter modeFilter)
	{
		return null;
	}

	[Token(Token = "0x6001F3E")]
	[Address(RVA = "0x7D8E10", Offset = "0x7D7C10", Length = "0x110")]
	private static string GetChallengeModeKey(GameModeFilter modeFilter)
	{
		return null;
	}
}
