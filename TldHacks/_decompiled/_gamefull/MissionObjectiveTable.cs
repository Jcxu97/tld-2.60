using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "MissionObjectiveTable", menuName = "Mission/MissionObjectiveTable", order = 10005)]
[Token(Token = "0x2000827")]
public class MissionObjectiveTable : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000828")]
	public class MissionObjectiveLink
	{
		[Token(Token = "0x40055B4")]
		[FieldOffset(Offset = "0x10")]
		public string m_ObjectiveName;

		[Token(Token = "0x40055B5")]
		[FieldOffset(Offset = "0x18")]
		public string m_MissionGraphNameOwner;

		[Token(Token = "0x6004BB9")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public MissionObjectiveLink()
		{
		}

		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
		public MissionObjectiveLink(string objectiveName, string missionGraphNameOwner)
		{
		}
	}

	[Token(Token = "0x40055B0")]
	[FieldOffset(Offset = "0x18")]
	public List<MissionObjectiveLink> m_GeneratedLinks;

	[Token(Token = "0x40055B1")]
	[FieldOffset(Offset = "0x20")]
	public List<MissionObjectiveLink> m_AuthoredLinks;

	[NonSerialized]
	[HideInInspector]
	[Token(Token = "0x40055B2")]
	[FieldOffset(Offset = "0x28")]
	public List<MissionObjectiveLink> m_RuntimeLinks;

	[Token(Token = "0x40055B3")]
	private static List<MissionObjectiveLink> s_TmpLinksList;

	[Token(Token = "0x6004BAF")]
	[Address(RVA = "0xD5A3F0", Offset = "0xD591F0", Length = "0x193")]
	private MissionObjectiveLink GetLinkFromList(string objectiveId, List<MissionObjectiveLink> list)
	{
		return null;
	}

	[Token(Token = "0x6004BB0")]
	[Address(RVA = "0xD5A590", Offset = "0xD59390", Length = "0x1BC")]
	private void UpdateLinkListFromList(string objectiveId, List<MissionObjectiveLink> list, List<MissionObjectiveLink> resultlist)
	{
	}

	[Token(Token = "0x6004BB1")]
	[Address(RVA = "0xD5A750", Offset = "0xD59550", Length = "0x73")]
	private void UpdateLinksList(string objectiveId, List<MissionObjectiveLink> resultList)
	{
	}

	[Token(Token = "0x6004BB2")]
	[Address(RVA = "0xD5A7D0", Offset = "0xD595D0", Length = "0x64")]
	public void AddRuntimeLink(MissionObjectiveLink link)
	{
	}

	[Token(Token = "0x6004BB3")]
	[Address(RVA = "0xD5A840", Offset = "0xD59640", Length = "0x88")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004BB4")]
	[Address(RVA = "0xD5A8D0", Offset = "0xD596D0", Length = "0xCC")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004BB5")]
	[Address(RVA = "0xD5A9A0", Offset = "0xD597A0", Length = "0x290")]
	private bool DoesLinkExists(MissionObjectiveLink link)
	{
		return false;
	}

	[Token(Token = "0x6004BB6")]
	[Address(RVA = "0xD5AC40", Offset = "0xD59A40", Length = "0x25B")]
	public string[] GetMissionGraphOwnerList(string objectiveId)
	{
		return null;
	}

	[Token(Token = "0x6004BB7")]
	[Address(RVA = "0xD5AEA0", Offset = "0xD59CA0", Length = "0xB6")]
	public MissionObjectiveTable()
	{
	}
}
