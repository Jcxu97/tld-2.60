using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "FPAnimationState", menuName = "Cinematic/FP Animation State", order = 10003)]
[Token(Token = "0x20002CF")]
public class FPAnimationState : ScriptableObject
{
	[HideInInspector]
	[Token(Token = "0x4001925")]
	[FieldOffset(Offset = "0x18")]
	public string m_AnimationStateKey;

	[Token(Token = "0x4001926")]
	[FieldOffset(Offset = "0x20")]
	public TextAsset m_SubtitleAsset;

	[Token(Token = "0x4001927")]
	[FieldOffset(Offset = "0x28")]
	public string m_AudioEventStart;

	[Token(Token = "0x4001928")]
	[FieldOffset(Offset = "0x30")]
	public string m_AudioEventStop;

	[Token(Token = "0x4001929")]
	[FieldOffset(Offset = "0x38")]
	public string m_NPCId;

	[Token(Token = "0x400192A")]
	[FieldOffset(Offset = "0x40")]
	public bool m_ShouldLockPlayer;

	[Token(Token = "0x400192B")]
	[FieldOffset(Offset = "0x41")]
	public bool m_FadedOutOnLoad;

	[Token(Token = "0x400192C")]
	[FieldOffset(Offset = "0x42")]
	public bool m_FadedOutOnExit;

	[Token(Token = "0x400192D")]
	[FieldOffset(Offset = "0x43")]
	public bool m_UseMotionFromRef;

	[Token(Token = "0x60017F6")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public FPAnimationState()
	{
	}
}
