using Cpp2ILInjected;

[Token(Token = "0x2000139")]
public interface IAchievementPlatform
{
	[Token(Token = "0x170001A5")]
	bool IsFullyOperational
	{
		[Token(Token = "0x6000B42")]
		get;
	}

	[Token(Token = "0x170001A6")]
	bool DidAchievementsChangeThisUpdate
	{
		[Token(Token = "0x6000B43")]
		get;
		[Token(Token = "0x6000B44")]
		set;
	}

	[Token(Token = "0x6000B45")]
	void Initialize();

	[Token(Token = "0x6000B46")]
	void Update();

	[Token(Token = "0x6000B47")]
	void Shutdown();

	[Token(Token = "0x6000B48")]
	void Unlock(Achievement achievement);

	[Token(Token = "0x6000B49")]
	bool IsUnlocked(Achievement achievement);

	[Token(Token = "0x6000B4A")]
	void SendStatistic(GameIntStatType statistic, int amount);

	[Token(Token = "0x6000B4B")]
	void SendStatistic(GameFloatStatType statistic, float amount);

	[Token(Token = "0x6000B4C")]
	void SendStatistic(GameEventStatType statistic);

	[Token(Token = "0x6000B4D")]
	void ListAllUnlockedAchievements();
}
