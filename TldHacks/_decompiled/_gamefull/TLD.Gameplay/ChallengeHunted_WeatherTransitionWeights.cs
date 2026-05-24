using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Challenges/Hunted Weather Weight Override")]
[Token(Token = "0x2001467")]
public class ChallengeHunted_WeatherTransitionWeights : GameModeWeatherTransitionWeightOverride
{
	[Token(Token = "0x60081D0")]
	[Address(RVA = "0x1225C70", Offset = "0x1224A70", Length = "0x9E")]
	public override void ApplyWeights(WeatherTransitionWeights weights)
	{
	}

	[Token(Token = "0x60081D1")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ChallengeHunted_WeatherTransitionWeights()
	{
	}
}
