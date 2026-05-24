using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000973")]
public class PlayableAssetPlayAudio : PlayableAsset
{
	[Token(Token = "0x40061FA")]
	[FieldOffset(Offset = "0x18")]
	public string m_AudioEventStart;

	[Token(Token = "0x40061FB")]
	[FieldOffset(Offset = "0x20")]
	public string m_AudioEventStop;

	[Token(Token = "0x40061FC")]
	[FieldOffset(Offset = "0x28")]
	public bool m_AudioDrivesDirectorTime;

	[Token(Token = "0x40061FD")]
	[FieldOffset(Offset = "0x29")]
	public bool m_SeekAudioEnabled;

	[Token(Token = "0x40061FE")]
	[FieldOffset(Offset = "0x30")]
	private TLD_AudioTrack m_Track;

	[Token(Token = "0x600551B")]
	[Address(RVA = "0xE955F0", Offset = "0xE943F0", Length = "0x3D7")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600551C")]
	[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
	public void SetTrack(TLD_AudioTrack tldAudioTrack)
	{
	}

	[Token(Token = "0x600551D")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	public TLD_AudioTrack GetTrack()
	{
		return null;
	}

	[Token(Token = "0x600551E")]
	[Address(RVA = "0xE959D0", Offset = "0xE947D0", Length = "0xB")]
	public PlayableAssetPlayAudio()
	{
	}
}
