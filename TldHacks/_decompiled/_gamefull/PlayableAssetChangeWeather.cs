using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200096D")]
public class PlayableAssetChangeWeather : PlayableAsset
{
	[Token(Token = "0x200096E")]
	public enum TransitionType
	{
		[Token(Token = "0x40061EF")]
		Instant,
		[Token(Token = "0x40061F0")]
		Fade
	}

	[Header("Weather Transition")]
	[Token(Token = "0x40061EC")]
	[FieldOffset(Offset = "0x18")]
	public WeatherStage m_TargetWeatherType;

	[Token(Token = "0x40061ED")]
	[FieldOffset(Offset = "0x1C")]
	public TransitionType m_TransitionType;

	[Token(Token = "0x6005513")]
	[Address(RVA = "0xE94C60", Offset = "0xE93A60", Length = "0x1AE")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005514")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetChangeWeather()
	{
	}
}
