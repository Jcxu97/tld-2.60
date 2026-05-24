using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200098A")]
public class PlayableBehaviourSetAnimControllerState : PlayableBehaviour
{
	[Token(Token = "0x4006255")]
	[FieldOffset(Offset = "0x10")]
	public string m_StateName;

	[Token(Token = "0x4006256")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_TrackGameObject;

	[Token(Token = "0x4006257")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_TrackAnimator;

	[Token(Token = "0x6005569")]
	[Address(RVA = "0xE9BE00", Offset = "0xE9AC00", Length = "0x2E1")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600556A")]
	[Address(RVA = "0xE9C0F0", Offset = "0xE9AEF0", Length = "0x7")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600556B")]
	[Address(RVA = "0xE9C100", Offset = "0xE9AF00", Length = "0x1F3")]
	private void SetAnimControllerState()
	{
	}

	[Token(Token = "0x600556C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourSetAnimControllerState()
	{
	}
}
