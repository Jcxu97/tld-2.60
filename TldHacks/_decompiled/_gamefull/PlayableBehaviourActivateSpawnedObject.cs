using Cpp2ILInjected;
using UnityEngine.Playables;

[Token(Token = "0x2000981")]
public class PlayableBehaviourActivateSpawnedObject : PlayableBehaviour
{
	[Token(Token = "0x400621B")]
	[FieldOffset(Offset = "0x10")]
	public TLD_SpawnedAnimationTrack m_SpawnedAnimationTrack;

	[Token(Token = "0x600553E")]
	[Address(RVA = "0xE98240", Offset = "0xE97040", Length = "0xE2")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600553F")]
	[Address(RVA = "0xE98330", Offset = "0xE97130", Length = "0xE2")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005540")]
	[Address(RVA = "0xE98420", Offset = "0xE97220", Length = "0xE2")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005541")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourActivateSpawnedObject()
	{
	}
}
