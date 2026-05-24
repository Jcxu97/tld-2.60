using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x200099A")]
public class TLD_ControlPlayableAsset : ControlPlayableAsset
{
	[Token(Token = "0x40062C5")]
	[FieldOffset(Offset = "0x60")]
	public string m_MissionObjectId;

	[Token(Token = "0x40062C6")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsPlaying;

	[Token(Token = "0x60055BA")]
	[Address(RVA = "0xEA6180", Offset = "0xEA4F80", Length = "0x397")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x60055BB")]
	[Address(RVA = "0xEA6520", Offset = "0xEA5320", Length = "0x1B2")]
	private GameObject FindGameObject(string missionObjectId)
	{
		return null;
	}

	[Token(Token = "0x60055BC")]
	[Address(RVA = "0xEA66E0", Offset = "0xEA54E0", Length = "0xB2")]
	public TLD_ControlPlayableAsset()
	{
	}
}
