using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Challenges/Archivist Weather Weight Override")]
[Token(Token = "0x2001466")]
public class ChallengeArchivist_WeatherTransitionWeights : GameModeWeatherTransitionWeightOverride
{
	[Token(Token = "0x60081CE")]
	[Address(RVA = "0x1225B20", Offset = "0x1224920", Length = "0x14D")]
	public override void ApplyWeights(WeatherTransitionWeights weights)
	{
	}

	[Token(Token = "0x60081CF")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ChallengeArchivist_WeatherTransitionWeights()
	{
	}
}
