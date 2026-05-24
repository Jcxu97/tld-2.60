using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20006A2")]
public class StoryMissionInfo
{
	[Token(Token = "0x4004596")]
	[FieldOffset(Offset = "0x10")]
	public string missionID;

	[Token(Token = "0x4004597")]
	[FieldOffset(Offset = "0x18")]
	public string nameLocID;

	[Token(Token = "0x4004598")]
	[FieldOffset(Offset = "0x20")]
	public string descriptionLocID;

	[Token(Token = "0x4004599")]
	[FieldOffset(Offset = "0x28")]
	public string textureName;

	[Token(Token = "0x400459A")]
	[FieldOffset(Offset = "0x30")]
	public bool isActive;

	[Token(Token = "0x400459B")]
	[FieldOffset(Offset = "0x31")]
	public bool completedSuccessfully;

	[Token(Token = "0x400459C")]
	[FieldOffset(Offset = "0x38")]
	public string timerID;

	[Token(Token = "0x400459D")]
	[FieldOffset(Offset = "0x40")]
	public bool isSideMission;

	[Token(Token = "0x400459E")]
	[FieldOffset(Offset = "0x48")]
	public string chapterLocID;

	[Token(Token = "0x400459F")]
	[FieldOffset(Offset = "0x50")]
	public bool showWhenCompleted;

	[Token(Token = "0x40045A0")]
	[FieldOffset(Offset = "0x58")]
	public string icon;

	[Token(Token = "0x60038F8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public StoryMissionInfo()
	{
	}
}
