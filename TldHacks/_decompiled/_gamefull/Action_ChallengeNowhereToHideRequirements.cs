using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

[Name("Requirements for NowhereToHide Challenge", 0)]
[Description("Requirements for NowhereToHide challenge")]
[Category("TLD Actions/Challenge/NowhereToHide")]
[Token(Token = "0x2000855")]
public class Action_ChallengeNowhereToHideRequirements : ActionTask<GraphOwner>
{
	[Token(Token = "0x40056A5")]
	[FieldOffset(Offset = "0x68")]
	public string ChallengeListHeaderLocId;

	[Token(Token = "0x40056A6")]
	[FieldOffset(Offset = "0x70")]
	public string ChallengeListDescLocId;

	[Token(Token = "0x40056A7")]
	[FieldOffset(Offset = "0x78")]
	public string ChallengeObjectiveLocId;

	[Token(Token = "0x40056A8")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<int> ObjectiveCurrentCount;

	[Token(Token = "0x40056A9")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<int> ObjectiveTotalCount;

	[Token(Token = "0x40056AA")]
	[FieldOffset(Offset = "0x90")]
	public string metRequirements;

	[Token(Token = "0x40056AB")]
	[FieldOffset(Offset = "0x98")]
	public string notMetRequirements;

	[Token(Token = "0x40056AC")]
	[FieldOffset(Offset = "0xA0")]
	private string m_ChecklistHeader;

	[Token(Token = "0x40056AD")]
	[FieldOffset(Offset = "0xA8")]
	private string m_ChecklistDesc;

	[Token(Token = "0x40056AE")]
	[FieldOffset(Offset = "0xB0")]
	private string m_ChallengeObjective;

	[Token(Token = "0x40056AF")]
	[FieldOffset(Offset = "0xB8")]
	private List<string> m_ChecklistNames;

	[Token(Token = "0x40056B0")]
	[FieldOffset(Offset = "0xC0")]
	private List<string> m_ChecklistVals;

	[Token(Token = "0x40056B1")]
	[FieldOffset(Offset = "0xC8")]
	private List<bool> m_ChecklistBools;

	[Token(Token = "0x40056B2")]
	[FieldOffset(Offset = "0xD0")]
	private string m_RequirementString;

	[Token(Token = "0x6004CDB")]
	[Address(RVA = "0xD7B520", Offset = "0xD7A320", Length = "0x997")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6004CDC")]
	[Address(RVA = "0xD7BEC0", Offset = "0xD7ACC0", Length = "0x330")]
	public Action_ChallengeNowhereToHideRequirements()
	{
	}
}
