using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackClipType(typeof(PlayableAssetPlayAudio))]
[TrackBindingType(typeof(GameObject))]
[Token(Token = "0x2000998")]
public class TLD_AudioTrack : PlayableTrack, TLD_IDynamicBindableTrack
{
	[Token(Token = "0x4006297")]
	[FieldOffset(Offset = "0xA0")]
	public string m_MissionObjectId;

	[Token(Token = "0x4006298")]
	[FieldOffset(Offset = "0xA8")]
	public string m_ChildObjectName;

	[Token(Token = "0x60055A5")]
	[Address(RVA = "0xEA0950", Offset = "0xE9F750", Length = "0x162")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Token(Token = "0x60055A6")]
	[Address(RVA = "0xEA0AC0", Offset = "0xE9F8C0", Length = "0x296")]
	public void RefreshClips()
	{
	}

	[Token(Token = "0x60055A7")]
	[Address(RVA = "0xEA0D60", Offset = "0xE9FB60", Length = "0x4E")]
	public TLD_AudioTrack()
	{
	}
}
