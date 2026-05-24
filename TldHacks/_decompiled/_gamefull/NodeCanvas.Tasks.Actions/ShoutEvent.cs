using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Utility")]
[Description("Sends an event to all GraphOwners within range of the agent and over time like a shockwave.")]
[Token(Token = "0x200130E")]
public class ShoutEvent : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008CD4")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> eventName;

	[Token(Token = "0x4008CD5")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> shoutRange;

	[Token(Token = "0x4008CD6")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> completionTime;

	[Token(Token = "0x4008CD7")]
	[FieldOffset(Offset = "0x80")]
	private GraphOwner[] owners;

	[Token(Token = "0x4008CD8")]
	[FieldOffset(Offset = "0x88")]
	private List<GraphOwner> receivedOwners;

	[Token(Token = "0x4008CD9")]
	[FieldOffset(Offset = "0x90")]
	private float traveledDistance;

	[Token(Token = "0x17000A2B")]
	protected override string info
	{
		[Token(Token = "0x6007A34")]
		[Address(RVA = "0x118F120", Offset = "0x118DF20", Length = "0x9B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A35")]
	[Address(RVA = "0x118F1C0", Offset = "0x118DFC0", Length = "0x159")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A36")]
	[Address(RVA = "0x118F320", Offset = "0x118E120", Length = "0x69C")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007A37")]
	[Address(RVA = "0x118F9C0", Offset = "0x118E7C0", Length = "0x43F")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6007A38")]
	[Address(RVA = "0x118FE00", Offset = "0x118EC00", Length = "0x2AA")]
	public ShoutEvent()
	{
	}
}
