using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20005F8")]
public class MissionsProgressBar
{
	[Token(Token = "0x400370C")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_Panel;

	[Token(Token = "0x400370D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel m_CountLabel;

	[Token(Token = "0x400370E")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_BarSprite;

	[Token(Token = "0x400370F")]
	[FieldOffset(Offset = "0x28")]
	public float m_FillSpriteOffset;

	[Token(Token = "0x6002E1B")]
	[Address(RVA = "0x95E760", Offset = "0x95D560", Length = "0x1E")]
	public void Enable(bool enabled)
	{
	}

	[Token(Token = "0x6002E1C")]
	[Address(RVA = "0x95E780", Offset = "0x95D580", Length = "0xD7")]
	public void Refresh(List<StoryMissionObjective> objectives)
	{
	}

	[Token(Token = "0x6002E1D")]
	[Address(RVA = "0x95E860", Offset = "0x95D660", Length = "0x15F")]
	public static StoryMissionObjective FindActiveObjectiveToTrack(List<StoryMissionObjective> objectives)
	{
		return null;
	}

	[Token(Token = "0x6002E1E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MissionsProgressBar()
	{
	}
}
