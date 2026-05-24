using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD/AI")]
[Name("SetGameObject", 0)]
[Description("Sets the target variable")]
[Token(Token = "0x20011A4")]
public class Action_SetGameObject : ActionTask
{
	[Token(Token = "0x20011A5")]
	public enum TargetType
	{
		[Token(Token = "0x400889F")]
		Player,
		[Token(Token = "0x40088A0")]
		PlayerCamera,
		[Token(Token = "0x40088A1")]
		MissionObjectIdentifier
	}

	[Token(Token = "0x4008899")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x400889A")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<TargetType> targetType;

	[Token(Token = "0x400889B")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> missionObjectIdentifierString;

	[Token(Token = "0x400889C")]
	[FieldOffset(Offset = "0x80")]
	private int retryCounter;

	[Token(Token = "0x400889D")]
	[FieldOffset(Offset = "0x84")]
	private int maxRetries;

	[Token(Token = "0x1700095A")]
	protected override string info
	{
		[Token(Token = "0x60075CB")]
		[Address(RVA = "0x1111450", Offset = "0x1110250", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075CC")]
	[Address(RVA = "0x10B3A40", Offset = "0x10B2840", Length = "0xB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075CD")]
	[Address(RVA = "0x11114E0", Offset = "0x11102E0", Length = "0x1B1")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60075CE")]
	[Address(RVA = "0x11116A0", Offset = "0x11104A0", Length = "0x2A6")]
	protected bool SetTarget()
	{
		return false;
	}

	[Token(Token = "0x60075CF")]
	[Address(RVA = "0x1111950", Offset = "0x1110750", Length = "0x12")]
	public Action_SetGameObject()
	{
	}
}
