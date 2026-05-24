using Cpp2ILInjected;
using UnityEngine.Timeline;

[TrackClipType(typeof(PlayableAssetSubtitle))]
[Token(Token = "0x20009A4")]
public class TLD_SubtitleTrack : PlayableTrack
{
	[Token(Token = "0x60055E6")]
	[Address(RVA = "0xEAA5A0", Offset = "0xEA93A0", Length = "0x7")]
	public void OnValidate()
	{
	}

	[Token(Token = "0x60055E7")]
	[Address(RVA = "0xEAA5B0", Offset = "0xEA93B0", Length = "0x2EB")]
	public void RefreshClips()
	{
	}

	[Token(Token = "0x60055E8")]
	[Address(RVA = "0xEA0D60", Offset = "0xE9FB60", Length = "0x4E")]
	public TLD_SubtitleTrack()
	{
	}
}
