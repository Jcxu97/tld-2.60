using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000976")]
public class PlayableAssetSetAnimControllerState : PlayableAsset
{
	[Token(Token = "0x4006205")]
	[FieldOffset(Offset = "0x18")]
	public string m_StateName;

	[Token(Token = "0x4006206")]
	[FieldOffset(Offset = "0x20")]
	private TLD_SetControllerStateTrack m_Track;

	[Token(Token = "0x4006207")]
	[FieldOffset(Offset = "0x28")]
	public string m_ControllerAssetName;

	[Token(Token = "0x6005524")]
	[Address(RVA = "0xE95EB0", Offset = "0xE94CB0", Length = "0x1F1")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005525")]
	[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
	public void SetTrack(TLD_SetControllerStateTrack track)
	{
	}

	[Token(Token = "0x6005526")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public TLD_SetControllerStateTrack GetTrack()
	{
		return null;
	}

	[Token(Token = "0x6005527")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetSetAnimControllerState()
	{
	}
}
