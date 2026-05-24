using Cpp2ILInjected;

[Token(Token = "0x2000464")]
public interface IFoodEffect
{
	[Token(Token = "0x2000465")]
	public enum EffectType
	{
		[Token(Token = "0x40027C0")]
		MaxCondition,
		[Token(Token = "0x40027C1")]
		MaxStamina,
		[Token(Token = "0x40027C2")]
		MaxCarryWeight,
		[Token(Token = "0x40027C3")]
		Rest,
		[Token(Token = "0x40027C4")]
		Fatigue,
		[Token(Token = "0x40027C5")]
		Condition,
		[Token(Token = "0x40027C6")]
		Stamina,
		[Token(Token = "0x40027C7")]
		CabinFever,
		[Token(Token = "0x40027C8")]
		Headache
	}

	[Token(Token = "0x2000466")]
	public enum Effect
	{
		[Token(Token = "0x40027CA")]
		Detriment = -1,
		[Token(Token = "0x40027CB")]
		Neutral,
		[Token(Token = "0x40027CC")]
		Benefit
	}

	[Token(Token = "0x6002125")]
	Effect GetEffect(EffectType effectType);
}
