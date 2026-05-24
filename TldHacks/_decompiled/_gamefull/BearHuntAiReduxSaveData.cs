using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001CC")]
public class BearHuntAiReduxSaveData
{
	[Token(Token = "0x4000FA1")]
	[FieldOffset(Offset = "0x10")]
	public bool m_BearEarGiven;

	[Token(Token = "0x4000FA2")]
	[FieldOffset(Offset = "0x11")]
	public bool m_UseForceBearFleePosition;

	[Token(Token = "0x4000FA3")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 m_ForceBearFleePosition;

	[Token(Token = "0x4000FA4")]
	[FieldOffset(Offset = "0x20")]
	public BearEncounter.PostStruggleBehavior m_PostStruggleBehavior;

	[Token(Token = "0x600106A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BearHuntAiReduxSaveData()
	{
	}
}
