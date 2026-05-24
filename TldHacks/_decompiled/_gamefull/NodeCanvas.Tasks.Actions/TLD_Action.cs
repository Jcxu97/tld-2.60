using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Token(Token = "0x20011A2")]
public class TLD_Action : ActionTask
{
	[Token(Token = "0x4008895")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> agentIsMissionObject;

	[Token(Token = "0x4008896")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> agentMissionObjectIdentifier;

	[Token(Token = "0x17000958")]
	protected new Component agent
	{
		[Token(Token = "0x60075C6")]
		[Address(RVA = "0x11110C0", Offset = "0x110FEC0", Length = "0x19E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075C7")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public TLD_Action()
	{
	}
}
