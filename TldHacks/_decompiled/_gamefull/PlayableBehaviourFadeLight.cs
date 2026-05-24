using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000985")]
public class PlayableBehaviourFadeLight : PlayableBehaviour
{
	[Token(Token = "0x400622A")]
	[FieldOffset(Offset = "0x10")]
	public List<Light> m_Lights;

	[Token(Token = "0x400622B")]
	[FieldOffset(Offset = "0x18")]
	public PlayableAssetFadeLight.FadeType m_FadeType;

	[Token(Token = "0x400622C")]
	[FieldOffset(Offset = "0x1C")]
	public float m_FadedOutPercent;

	[Token(Token = "0x400622D")]
	[FieldOffset(Offset = "0x20")]
	public float m_FadedInPercent;

	[Token(Token = "0x400622E")]
	public static Dictionary<Light, float> s_OriginalIntensitiesDict;

	[Token(Token = "0x400622F")]
	public static bool s_DisableLightFade;

	[Token(Token = "0x4006230")]
	[FieldOffset(Offset = "0x24")]
	private float m_CurrentValue;

	[Token(Token = "0x600554B")]
	[Address(RVA = "0xE99250", Offset = "0xE98050", Length = "0x322")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600554C")]
	[Address(RVA = "0xE99580", Offset = "0xE98380", Length = "0x24F")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600554D")]
	[Address(RVA = "0xE997D0", Offset = "0xE985D0", Length = "0x325")]
	public static void Reset()
	{
	}

	[Token(Token = "0x600554E")]
	[Address(RVA = "0xE99B00", Offset = "0xE98900", Length = "0xC1")]
	public static void ClearCachedValuesForLights(Light[] lights)
	{
	}

	[Token(Token = "0x600554F")]
	[Address(RVA = "0xE99BD0", Offset = "0xE989D0", Length = "0x188")]
	public static void SetCachedValuesForLightsToCurrent(Light[] lights)
	{
	}

	[Token(Token = "0x6005550")]
	[Address(RVA = "0xE99D60", Offset = "0xE98B60", Length = "0x2B0")]
	public static void SetLightFadeDisabled(bool disabled)
	{
	}

	[Token(Token = "0x6005551")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourFadeLight()
	{
	}
}
