using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;

namespace TLD.Missions;

[Token(Token = "0x200137F")]
public class ActiveMissionManager
{
	[Token(Token = "0x4008F4A")]
	[FieldOffset(Offset = "0x10")]
	public Action OnUpdateCallback;

	[Token(Token = "0x4008F4B")]
	[FieldOffset(Offset = "0x18")]
	private readonly List<StoryMissionInfo> m_ResourceMissionInfoList;

	[Token(Token = "0x4008F4C")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<StoryMissionObjective> m_ResourceObjectiveInfoList;

	[Token(Token = "0x4008F4D")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<StoryMissionInfo> m_MissionInfoList;

	[Token(Token = "0x4008F4E")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<StoryMissionObjective> m_ObjectiveInfoList;

	[Token(Token = "0x4008F4F")]
	private static ActiveMissionManager s_ActiveMissionManager;

	[Token(Token = "0x4008F50")]
	private static StoryMissionSaveData s_StoryMissionSaveData;

	[Token(Token = "0x4008F51")]
	private const int FRACTION_OBJ_PRECISION_FACTOR = 100;

	[Token(Token = "0x4008F52")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x17000A8D")]
	public static ActiveMissionManager Instance
	{
		[Token(Token = "0x6007C78")]
		[Address(RVA = "0x11B8310", Offset = "0x11B7110", Length = "0x53")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A8E")]
	public List<StoryMissionInfo> MissionInfoList
	{
		[Token(Token = "0x6007C79")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A8F")]
	public List<StoryMissionObjective> ObjectiveInfoList
	{
		[Token(Token = "0x6007C7A")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007C7B")]
	[Address(RVA = "0x11B8370", Offset = "0x11B7170", Length = "0x242")]
	public ActiveMissionManager()
	{
	}

	[Token(Token = "0x6007C7C")]
	[Address(RVA = "0x11B85C0", Offset = "0x11B73C0", Length = "0x17")]
	public bool ObjectiveIsActiveOrComplete(string objectiveID)
	{
		return false;
	}

	[Token(Token = "0x6007C7D")]
	[Address(RVA = "0x11B85E0", Offset = "0x11B73E0", Length = "0xB3")]
	public StoryMissionObjective GetActiveObjective(string objectiveID)
	{
		return null;
	}

	[Token(Token = "0x6007C7E")]
	[Address(RVA = "0x11B86A0", Offset = "0x11B74A0", Length = "0xB5")]
	public bool TryGetObjectiveIsComplete(string objectiveID, out bool result)
	{
		result = default(bool);
		return false;
	}

	[Token(Token = "0x6007C7F")]
	[Address(RVA = "0x11B8760", Offset = "0x11B7560", Length = "0x47E")]
	public void AddMission(string missionID, bool suppressUI, bool suppressMission, bool suppressChapter)
	{
	}

	[Token(Token = "0x6007C80")]
	[Address(RVA = "0x11B8BE0", Offset = "0x11B79E0", Length = "0x1D0")]
	public void UpdateMissionName(string missionID, string nameLocID, bool suppressUI)
	{
	}

	[Token(Token = "0x6007C81")]
	[Address(RVA = "0x11B8DC0", Offset = "0x11B7BC0", Length = "0x1D0")]
	public void UpdateMissionDesc(string missionID, string descriptionLocID, bool suppressUI)
	{
	}

	[Token(Token = "0x6007C82")]
	[Address(RVA = "0x11B8FA0", Offset = "0x11B7DA0", Length = "0x1D0")]
	public void UpdateMissionTexture(string missionID, string textureName, bool suppressUI)
	{
	}

	[Token(Token = "0x6007C83")]
	[Address(RVA = "0x11B9180", Offset = "0x11B7F80", Length = "0x1D0")]
	public void UpdateMissionTimer(string missionID, string timerID, bool suppressUI)
	{
	}

	[Token(Token = "0x6007C84")]
	[Address(RVA = "0x11B9360", Offset = "0x11B8160", Length = "0x205")]
	public void MarkMissionComplete(string missionID, bool missionSuccess, bool suppressUI)
	{
	}

	[Token(Token = "0x6007C85")]
	[Address(RVA = "0x11B9570", Offset = "0x11B8370", Length = "0x411")]
	public void AddObjective(string objectiveID, bool suppressUI)
	{
	}

	[Token(Token = "0x6007C86")]
	[Address(RVA = "0x11B9990", Offset = "0x11B8790", Length = "0x1D0")]
	public void UpdateObjectiveDesc(string objectiveID, string descriptionLocID, bool suppressUI)
	{
	}

	[Token(Token = "0x6007C87")]
	[Address(RVA = "0x11B9B70", Offset = "0x11B8970", Length = "0x1D0")]
	public void UpdateObjectiveTimer(string objectiveID, string timerID, bool suppressUI)
	{
	}

	[Token(Token = "0x6007C88")]
	[Address(RVA = "0x11B9D50", Offset = "0x11B8B50", Length = "0x16C")]
	public void MarkObjectiveComplete(string objectiveID, bool suppressUI)
	{
	}

	[Token(Token = "0x6007C89")]
	[Address(RVA = "0x11B9EC0", Offset = "0x11B8CC0", Length = "0xFB")]
	public void MarkObjectiveInvisible(string objectiveID)
	{
	}

	[Token(Token = "0x6007C8A")]
	[Address(RVA = "0x11B9FC0", Offset = "0x11B8DC0", Length = "0x125")]
	public bool IsSideMission(string missionID)
	{
		return false;
	}

	[Token(Token = "0x6007C8B")]
	[Address(RVA = "0x11BA0F0", Offset = "0x11B8EF0", Length = "0x11B")]
	public StoryMissionInfo GetMissionInfoFromID(string missionID)
	{
		return null;
	}

	[Token(Token = "0x6007C8C")]
	[Address(RVA = "0x11BA210", Offset = "0x11B9010", Length = "0x117")]
	private int GetMissionIndex(string missionID)
	{
		return 0;
	}

	[Token(Token = "0x6007C8D")]
	[Address(RVA = "0x11BA330", Offset = "0x11B9130", Length = "0x92")]
	public StoryMissionObjective GetObjective(string objectiveID)
	{
		return null;
	}

	[Token(Token = "0x6007C8E")]
	[Address(RVA = "0x11BA3D0", Offset = "0x11B91D0", Length = "0x156")]
	public StoryMissionInfo GetActiveStoryMissionInfo()
	{
		return null;
	}

	[Token(Token = "0x6007C8F")]
	[Address(RVA = "0x11BA530", Offset = "0x11B9330", Length = "0xA5")]
	public bool HasSideMissionsInLog()
	{
		return false;
	}

	[Token(Token = "0x6007C90")]
	[Address(RVA = "0x11BA5E0", Offset = "0x11B93E0", Length = "0xA5")]
	public bool HasCompletedMissionsInLog()
	{
		return false;
	}

	[Token(Token = "0x6007C91")]
	[Address(RVA = "0x11BA690", Offset = "0x11B9490", Length = "0x207")]
	public int GetNumCompletedTales()
	{
		return 0;
	}

	[Token(Token = "0x6007C92")]
	[Address(RVA = "0x11BA8A0", Offset = "0x11B96A0", Length = "0xDF")]
	public StoryMissionInfo GetTrackedMainMission()
	{
		return null;
	}

	[Token(Token = "0x6007C93")]
	[Address(RVA = "0x11BA980", Offset = "0x11B9780", Length = "0x101")]
	public StoryMissionInfo GetTrackedMission(bool maybeGetCompleted = false)
	{
		return null;
	}

	[Token(Token = "0x6007C94")]
	[Address(RVA = "0x11BAA90", Offset = "0x11B9890", Length = "0x213")]
	public void GetAllActiveObjectivesForMission(string missionID, ref List<StoryMissionObjective> results)
	{
	}

	[Token(Token = "0x6007C95")]
	[Address(RVA = "0x11BACB0", Offset = "0x11B9AB0", Length = "0x22A")]
	public int GetNumObjectivesForMission(string missionID)
	{
		return 0;
	}

	[Token(Token = "0x6007C96")]
	[Address(RVA = "0x11BAEE0", Offset = "0x11B9CE0", Length = "0x234")]
	public int GetNumCompletedObjectivesForMission(string missionID)
	{
		return 0;
	}

	[Token(Token = "0x6007C97")]
	[Address(RVA = "0x11BB120", Offset = "0x11B9F20", Length = "0xA3")]
	public void ClearMissions()
	{
	}

	[Token(Token = "0x6007C98")]
	[Address(RVA = "0x11BB1D0", Offset = "0x11B9FD0", Length = "0x1AA")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6007C99")]
	[Address(RVA = "0x11BB380", Offset = "0x11BA180", Length = "0x5B7")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6007C9A")]
	[Address(RVA = "0x11BB940", Offset = "0x11BA740", Length = "0x117")]
	private int GetObjectiveIndex(string objectiveID)
	{
		return 0;
	}

	[Token(Token = "0x6007C9B")]
	[Address(RVA = "0x11BBA60", Offset = "0x11BA860", Length = "0xB3C")]
	private void LoadMissionDataFromResources()
	{
	}
}
