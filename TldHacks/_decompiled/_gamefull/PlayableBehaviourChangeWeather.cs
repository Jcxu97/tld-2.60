using System;
using Cpp2ILInjected;
using UnityEngine.Playables;

[Serializable]
[Token(Token = "0x2000984")]
public class PlayableBehaviourChangeWeather : PlayableBehaviour
{
	[Token(Token = "0x4006228")]
	[FieldOffset(Offset = "0x10")]
	public WeatherStage m_TargetWeatherType;

	[Token(Token = "0x4006229")]
	[FieldOffset(Offset = "0x14")]
	public PlayableAssetChangeWeather.TransitionType m_TransitionType;

	[Token(Token = "0x6005548")]
	[Address(RVA = "0xE98DD0", Offset = "0xE97BD0", Length = "0x3FA")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005549")]
	[Address(RVA = "0xE991D0", Offset = "0xE97FD0", Length = "0x76")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600554A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourChangeWeather()
	{
	}
}
