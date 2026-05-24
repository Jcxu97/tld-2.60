using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000197")]
public class AnimationUtils
{
	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x60D5A0", Offset = "0x60C3A0", Length = "0x39")]
	public static float GetValueIn01(float value)
	{
		return 0f;
	}

	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x60D5E0", Offset = "0x60C3E0", Length = "0xFE")]
	public static bool HasParameter(Animator animator, int paramHash)
	{
		return false;
	}

	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x60D6E0", Offset = "0x60C4E0", Length = "0x1C7")]
	public static bool IsStatePlayingOnAnyLayer(Animator animator, int stateHash)
	{
		return false;
	}

	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x60D8B0", Offset = "0x60C6B0", Length = "0x178")]
	public static bool IsAnyLayerInAnimationTransition(Animator animator)
	{
		return false;
	}

	[Token(Token = "0x6000F42")]
	[Address(RVA = "0x60DA30", Offset = "0x60C830", Length = "0x1DC")]
	public static Animator FindAnimatorByMissionId(string missionObjectId)
	{
		return null;
	}

	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AnimationUtils()
	{
	}
}
