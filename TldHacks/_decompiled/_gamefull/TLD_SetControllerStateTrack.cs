using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[TrackClipType(typeof(PlayableAssetSetAnimControllerState))]
[TrackBindingType(typeof(GameObject))]
[Token(Token = "0x20009A1")]
public class TLD_SetControllerStateTrack : PlayableTrack, TLD_IDynamicBindableTrack
{
	[Token(Token = "0x40062D1")]
	[FieldOffset(Offset = "0xA0")]
	public string m_MissionObjectId;

	[Token(Token = "0x40062D2")]
	[FieldOffset(Offset = "0xA8")]
	public string m_ChildObjectName;

	[Token(Token = "0x60055D4")]
	[Address(RVA = "0xEA8AB0", Offset = "0xEA78B0", Length = "0x162")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Token(Token = "0x60055D5")]
	[Address(RVA = "0xEA8C20", Offset = "0xEA7A20", Length = "0x296")]
	public void RefreshClips()
	{
	}

	[Token(Token = "0x60055D6")]
	[Address(RVA = "0xEA0D60", Offset = "0xE9FB60", Length = "0x4E")]
	public TLD_SetControllerStateTrack()
	{
	}
}
