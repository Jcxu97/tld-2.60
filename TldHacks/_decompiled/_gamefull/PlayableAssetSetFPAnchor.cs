using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000978")]
public class PlayableAssetSetFPAnchor : PlayableAsset
{
	[Token(Token = "0x4006209")]
	[FieldOffset(Offset = "0x18")]
	public string m_ObjectName;

	[Token(Token = "0x400620A")]
	[FieldOffset(Offset = "0x20")]
	public bool m_AttemptToFindObjectInChildren;

	[Token(Token = "0x400620B")]
	[FieldOffset(Offset = "0x28")]
	public string m_SyncNodeInfoId;

	[Token(Token = "0x600552A")]
	[Address(RVA = "0xE961D0", Offset = "0xE94FD0", Length = "0x6A8")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600552B")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetSetFPAnchor()
	{
	}
}
