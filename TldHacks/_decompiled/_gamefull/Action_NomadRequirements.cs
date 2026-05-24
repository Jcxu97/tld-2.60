using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

[Name("Check Nomad Requirements", 0)]
[Description("Fires an event based on requirements for Nomad challenge")]
[Category("TLD Actions/Challenge/Nomad")]
[Token(Token = "0x2000854")]
public class Action_NomadRequirements : ActionTask<GraphOwner>
{
	[Token(Token = "0x4005696")]
	[FieldOffset(Offset = "0x68")]
	public List<string> scenesRequired;

	[Token(Token = "0x4005697")]
	[FieldOffset(Offset = "0x70")]
	public float daysToSpendInEach;

	[Token(Token = "0x4005698")]
	[FieldOffset(Offset = "0x78")]
	public string metRequirements;

	[Token(Token = "0x4005699")]
	[FieldOffset(Offset = "0x80")]
	public float updateIntervalMinutes;

	[Token(Token = "0x400569A")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<string> nomadDataSerialized;

	[Token(Token = "0x400569B")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<bool> usingNewDataFormat;

	[Token(Token = "0x400569C")]
	[FieldOffset(Offset = "0x98")]
	private ulong m_RequirementInMilliseconds;

	[Token(Token = "0x400569D")]
	[FieldOffset(Offset = "0xA0")]
	private ulong m_UpdatePeriodMilliseconds;

	[Token(Token = "0x400569E")]
	[FieldOffset(Offset = "0xA8")]
	private readonly HighResolutionTimer m_Timer;

	[Token(Token = "0x400569F")]
	[FieldOffset(Offset = "0xB0")]
	private readonly Dictionary<string, ulong> m_NomadDataDict;

	[Token(Token = "0x40056A0")]
	[FieldOffset(Offset = "0xB8")]
	private string m_LastSceneKey;

	[Token(Token = "0x40056A1")]
	[FieldOffset(Offset = "0xC0")]
	private string[] m_CheckListNames;

	[Token(Token = "0x40056A2")]
	[FieldOffset(Offset = "0xC8")]
	private string[] m_CheckListValues;

	[Token(Token = "0x40056A3")]
	[FieldOffset(Offset = "0xD0")]
	private bool[] m_CheckListBools;

	[Token(Token = "0x40056A4")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_IsCompleted;

	[Token(Token = "0x17000358")]
	private static bool ShouldUpdate
	{
		[Token(Token = "0x6004CD3")]
		[Address(RVA = "0xD78F50", Offset = "0xD77D50", Length = "0x122")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6004CD4")]
	[Address(RVA = "0xD79080", Offset = "0xD77E80", Length = "0xC02")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6004CD5")]
	[Address(RVA = "0xD79C90", Offset = "0xD78A90", Length = "0x462")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6004CD6")]
	[Address(RVA = "0xD7A100", Offset = "0xD78F00", Length = "0x1C5")]
	private void UpdateTimeForCurrentScene(ulong elapsedMilliseconds)
	{
	}

	[Token(Token = "0x6004CD7")]
	[Address(RVA = "0xD7A2D0", Offset = "0xD790D0", Length = "0x4ED")]
	private void UpdateMissionInfo()
	{
	}

	[Token(Token = "0x6004CD8")]
	[Address(RVA = "0xD7A7C0", Offset = "0xD795C0", Length = "0x480")]
	private string GetCurrentSceneKey()
	{
		return null;
	}

	[Token(Token = "0x6004CD9")]
	[Address(RVA = "0xD7AC50", Offset = "0xD79A50", Length = "0x545")]
	private string GetChecklistNameForKey(string key)
	{
		return null;
	}

	[Token(Token = "0x6004CDA")]
	[Address(RVA = "0xD7B1A0", Offset = "0xD79FA0", Length = "0x377")]
	public Action_NomadRequirements()
	{
	}
}
