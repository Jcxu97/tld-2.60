using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000131")]
public abstract class AchievementPlatformBase : IAchievementPlatform
{
	[Token(Token = "0x2000132")]
	protected class AchievementInfo
	{
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x10")]
		public bool Unlocked;

		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x14")]
		public int OptionalData;

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public AchievementInfo()
		{
		}
	}

	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x10")]
	protected Dictionary<Achievement, AchievementInfo> m_RegisteredAchievements;

	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0x18")]
	protected Dictionary<GameIntStatType, string> m_RegisteredStats;

	[Token(Token = "0x170001A1")]
	[field: Token(Token = "0x400096C")]
	[field: FieldOffset(Offset = "0x20")]
	public bool IsFullyOperational
	{
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
		get;
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x4D3E50", Offset = "0x4D2C50", Length = "0x4")]
		protected set;
	}

	[Token(Token = "0x170001A2")]
	[field: Token(Token = "0x400096D")]
	[field: FieldOffset(Offset = "0x21")]
	public virtual bool DidAchievementsChangeThisUpdate
	{
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x5327B0", Offset = "0x5315B0", Length = "0x5")]
		get;
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x5D13B0", Offset = "0x5D01B0", Length = "0x4")]
		set;
	}

	[Token(Token = "0x6000B23")]
	[Address(RVA = "0x5D13C0", Offset = "0x5D01C0", Length = "0x71D")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x6000B24")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000B25")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void Shutdown()
	{
	}

	[Token(Token = "0x6000B26")]
	public abstract void Unlock(Achievement achievement);

	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x5D1AE0", Offset = "0x5D08E0", Length = "0x7E")]
	public virtual bool IsUnlocked(Achievement achievement)
	{
		return false;
	}

	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void SendStatistic(GameIntStatType statistic, int amount)
	{
	}

	[Token(Token = "0x6000B29")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void SendStatistic(GameFloatStatType statistic, float amount)
	{
	}

	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void SendStatistic(GameEventStatType statistic)
	{
	}

	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void ListAllUnlockedAchievements()
	{
	}

	[Token(Token = "0x6000B2C")]
	[Address(RVA = "0x5D1B60", Offset = "0x5D0960", Length = "0x195")]
	protected AchievementInfo FindAchievementInfoByOptionalData(int optionalID)
	{
		return null;
	}

	[Token(Token = "0x6000B2D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected AchievementPlatformBase()
	{
	}
}
