using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x200147A")]
public abstract class GameModeWeatherTransitionWeightOverride : ScriptableObject
{
	[Token(Token = "0x600823B")]
	public abstract void ApplyWeights(WeatherTransitionWeights weights);

	[Token(Token = "0x600823C")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	protected GameModeWeatherTransitionWeightOverride()
	{
	}
}
