using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Obsolete("Use CheckVariable(T)")]
[Token(Token = "0x200116E")]
public class CheckUnityObject : ConditionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008807")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<UnityEngine.Object> valueA;

	[Token(Token = "0x4008808")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<UnityEngine.Object> valueB;

	[Token(Token = "0x1700091D")]
	protected override string info
	{
		[Token(Token = "0x60074D5")]
		[Address(RVA = "0x1103FC0", Offset = "0x1102DC0", Length = "0x9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074D6")]
	[Address(RVA = "0x1104060", Offset = "0x1102E60", Length = "0x179")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074D7")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckUnityObject()
	{
	}
}
