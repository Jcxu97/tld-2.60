using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Token(Token = "0x20011A3")]
public class TLD_Condition : ConditionTask
{
	[Token(Token = "0x4008897")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> agentIsMissionObject;

	[Token(Token = "0x4008898")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> agentMissionObjectIdentifier;

	[Token(Token = "0x17000959")]
	protected new Component agent
	{
		[Token(Token = "0x60075C9")]
		[Address(RVA = "0x11112B0", Offset = "0x11100B0", Length = "0x19E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075C8")]
	[Address(RVA = "0x1111260", Offset = "0x1110060", Length = "0x49")]
	protected string GetAgentMissionObjectIdentifierValue()
	{
		return null;
	}

	[Token(Token = "0x60075CA")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TLD_Condition()
	{
	}
}
