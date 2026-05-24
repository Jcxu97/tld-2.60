using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000838")]
public class MissionTrigger : MissionObjectIdentifier
{
	[Token(Token = "0x400562E")]
	public const string ON_ENTER_EVENT_NAME = "MissionTrigger_OnEnter";

	[Token(Token = "0x400562F")]
	public const string ON_EXIT_EVENT_NAME = "MissionTrigger_OnExit";

	[Header("Trigger Vars")]
	[Token(Token = "0x4005630")]
	[FieldOffset(Offset = "0x48")]
	public MissionTriggerType m_Type;

	[Token(Token = "0x4005631")]
	[FieldOffset(Offset = "0x50")]
	public string[] m_AssociatedData;

	[Token(Token = "0x4005632")]
	[FieldOffset(Offset = "0x58")]
	public string m_RequiredTag;

	[Token(Token = "0x6004C65")]
	[Address(RVA = "0xD6F420", Offset = "0xD6E220", Length = "0x12A")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004C66")]
	[Address(RVA = "0xD6F550", Offset = "0xD6E350", Length = "0x2B7")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6004C67")]
	[Address(RVA = "0xD6F810", Offset = "0xD6E610", Length = "0x2BA")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6004C68")]
	[Address(RVA = "0xD6FAD0", Offset = "0xD6E8D0", Length = "0x5E3")]
	public Dictionary<string, object>[] ParseAssociatedData()
	{
		return null;
	}

	[Token(Token = "0x6004C69")]
	[Address(RVA = "0xD700C0", Offset = "0xD6EEC0", Length = "0x50")]
	private bool MatchesTag(Collider c)
	{
		return false;
	}

	[Token(Token = "0x6004C6A")]
	[Address(RVA = "0xD70120", Offset = "0xD6EF20", Length = "0x79")]
	public MissionTrigger()
	{
	}
}
