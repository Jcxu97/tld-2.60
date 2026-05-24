using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackClipType(typeof(PlayableAssetSay))]
[TrackBindingType(typeof(GameObject))]
[Token(Token = "0x20009A0")]
public class TLD_SayTrack : PlayableTrack, TLD_IDynamicBindableTrack
{
	[Token(Token = "0x40062CE")]
	[FieldOffset(Offset = "0xA0")]
	public string m_MissionObjectId;

	[Token(Token = "0x40062CF")]
	[FieldOffset(Offset = "0xA8")]
	public string m_ChildObjectName;

	[Token(Token = "0x40062D0")]
	[FieldOffset(Offset = "0xB0")]
	public VoiceInstigatorType m_InstigatorType;

	[Token(Token = "0x60055D1")]
	[Address(RVA = "0xEA85F0", Offset = "0xEA73F0", Length = "0x162")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Token(Token = "0x60055D2")]
	[Address(RVA = "0xEA8760", Offset = "0xEA7560", Length = "0x34A")]
	public void RefreshClips()
	{
	}

	[Token(Token = "0x60055D3")]
	[Address(RVA = "0xEA0D60", Offset = "0xE9FB60", Length = "0x4E")]
	public TLD_SayTrack()
	{
	}
}
