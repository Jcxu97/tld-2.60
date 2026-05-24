using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005F9")]
public class MissionUI : MonoBehaviour
{
	[Token(Token = "0x4003710")]
	[FieldOffset(Offset = "0x20")]
	public Transform m_ObjectiveTransform;

	[Token(Token = "0x4003711")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_MainObjectiveLabel;

	[Token(Token = "0x4003712")]
	[FieldOffset(Offset = "0x30")]
	public MissionSubobjectiveEntry[] m_ChecklistEntries;

	[Token(Token = "0x4003713")]
	[FieldOffset(Offset = "0x38")]
	public float m_ChallengeChecklistOffsetY;

	[Token(Token = "0x4003714")]
	[FieldOffset(Offset = "0x3C")]
	public float m_ChallengeChecklistVerticalSpacing;

	[Token(Token = "0x4003715")]
	[FieldOffset(Offset = "0x40")]
	public int m_PixelBufferTimer;

	[Token(Token = "0x4003716")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_MainObjectiveSprite;

	[Token(Token = "0x4003717")]
	[FieldOffset(Offset = "0x50")]
	private StoryMissionObjective m_ObjectiveToShow;

	[Token(Token = "0x6002E1F")]
	[Address(RVA = "0x95E9C0", Offset = "0x95D7C0", Length = "0x417")]
	public void UpdateObjectives(string missionObjectiveId)
	{
	}

	[Token(Token = "0x6002E20")]
	[Address(RVA = "0x95EDE0", Offset = "0x95DBE0", Length = "0x51")]
	public MissionUI()
	{
	}
}
