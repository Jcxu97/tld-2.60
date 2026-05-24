using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.Missions;

[Token(Token = "0x200137E")]
public class StoryMissionSaveData
{
	[Token(Token = "0x4008F47")]
	[FieldOffset(Offset = "0x10")]
	public List<StoryMissionInfo> m_MissionInfo;

	[Token(Token = "0x4008F48")]
	[FieldOffset(Offset = "0x18")]
	public List<StoryMissionObjective> m_ObjectiveInfo;

	[Token(Token = "0x4008F49")]
	[FieldOffset(Offset = "0x20")]
	public bool m_HasBeenUpdated;

	[Token(Token = "0x6007C77")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public StoryMissionSaveData()
	{
	}
}
