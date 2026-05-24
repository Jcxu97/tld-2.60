using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20006A4")]
public class StoryMissionObjective
{
	[Token(Token = "0x40045A1")]
	[FieldOffset(Offset = "0x10")]
	public string objectiveID;

	[Token(Token = "0x40045A2")]
	[FieldOffset(Offset = "0x18")]
	public string descriptionLocID;

	[Token(Token = "0x40045A3")]
	[FieldOffset(Offset = "0x20")]
	public string descriptionLocUnitsID;

	[Token(Token = "0x40045A4")]
	[FieldOffset(Offset = "0x28")]
	public string hudDescriptionLocID;

	[Token(Token = "0x40045A5")]
	[FieldOffset(Offset = "0x30")]
	public bool completed;

	[Token(Token = "0x40045A6")]
	[FieldOffset(Offset = "0x38")]
	public string timerID;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045A7")]
	[FieldOffset(Offset = "0x40")]
	public string countCurrentBBName;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045A8")]
	[FieldOffset(Offset = "0x48")]
	public string countRequiredBBName;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045A9")]
	[FieldOffset(Offset = "0x50")]
	public MissionObjectiveCountType countType;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045AA")]
	[FieldOffset(Offset = "0x54")]
	public bool isChildObjective;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045AB")]
	[FieldOffset(Offset = "0x58")]
	public List<string> childObjectiveIDList;

	[Token(Token = "0x40045AC")]
	[FieldOffset(Offset = "0x60")]
	public string missionID;

	[Token(Token = "0x40045AD")]
	[FieldOffset(Offset = "0x68")]
	public bool invisibleInJournal;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045AE")]
	[FieldOffset(Offset = "0x69")]
	public bool showWhenCompleted;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045AF")]
	[FieldOffset(Offset = "0x6A")]
	public bool showInSummary;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045B0")]
	[FieldOffset(Offset = "0x6B")]
	public bool showSmallKicker;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045B1")]
	[FieldOffset(Offset = "0x6C")]
	public bool ignoreInProgressionCalculation;

	[StoryMissionObjectiveResources]
	[Token(Token = "0x40045B2")]
	[FieldOffset(Offset = "0x6D")]
	public bool useAsFraction;

	[Token(Token = "0x60038FA")]
	[Address(RVA = "0xB368D0", Offset = "0xB356D0", Length = "0x235")]
	public void CopyConstantDataFromResources(StoryMissionObjective other)
	{
	}

	[Token(Token = "0x60038FB")]
	[Address(RVA = "0xB36B10", Offset = "0xB35910", Length = "0xB8")]
	private static bool HasStoryMissionObjectiveResourcesAttribute(FieldInfo field)
	{
		return false;
	}

	[Token(Token = "0x60038FC")]
	[Address(RVA = "0xB36BD0", Offset = "0xB359D0", Length = "0x14")]
	public string GetDescriptionLocIdForHud()
	{
		return null;
	}

	[Token(Token = "0x60038FD")]
	[Address(RVA = "0xB36BF0", Offset = "0xB359F0", Length = "0x12D")]
	public bool TryGetCurrentAndRequired(out float outCurrent, out float outRequired)
	{
		outCurrent = default(float);
		outRequired = default(float);
		return false;
	}

	[Token(Token = "0x60038FE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public StoryMissionObjective()
	{
	}
}
