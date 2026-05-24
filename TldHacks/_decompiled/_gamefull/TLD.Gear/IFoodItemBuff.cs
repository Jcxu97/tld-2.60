using Cpp2ILInjected;

namespace TLD.Gear;

[Token(Token = "0x200140F")]
public interface IFoodItemBuff : IFoodEffect
{
	[Token(Token = "0x6007FD8")]
	void Apply(float fractionConsumed);
}
