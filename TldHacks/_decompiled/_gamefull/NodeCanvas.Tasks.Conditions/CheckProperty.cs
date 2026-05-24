using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Script Control/Standalone Only")]
[Description("Check a property on a script and return if it's equal or not to the check value")]
[Token(Token = "0x200118E")]
public class CheckProperty : ConditionTask, ISubParametersContainer
{
	[SerializeField]
	[Token(Token = "0x4008867")]
	[FieldOffset(Offset = "0x68")]
	protected ReflectedFunctionWrapper functionWrapper;

	[SerializeField]
	[Token(Token = "0x4008868")]
	[FieldOffset(Offset = "0x70")]
	protected BBParameter checkValue;

	[SerializeField]
	[Token(Token = "0x4008869")]
	[FieldOffset(Offset = "0x78")]
	protected CompareMethod comparison;

	[Token(Token = "0x17000946")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x6007562")]
		[Address(RVA = "0x110D4E0", Offset = "0x110C2E0", Length = "0x1A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000947")]
	public override Type agentType
	{
		[Token(Token = "0x6007563")]
		[Address(RVA = "0x110E710", Offset = "0x110D510", Length = "0x1A7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000948")]
	protected override string info
	{
		[Token(Token = "0x6007564")]
		[Address(RVA = "0x110E8C0", Offset = "0x110D6C0", Length = "0x28E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007561")]
	[Address(RVA = "0x110D4C0", Offset = "0x110C2C0", Length = "0x20")]
	BBParameter[] ISubParametersContainer.GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x6007565")]
	[Address(RVA = "0x110EB50", Offset = "0x110D950", Length = "0x286")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x6007566")]
	[Address(RVA = "0x110EDE0", Offset = "0x110DBE0", Length = "0x101")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007567")]
	[Address(RVA = "0x110E220", Offset = "0x110D020", Length = "0x38E")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007568")]
	[Address(RVA = "0x110EEF0", Offset = "0x110DCF0", Length = "0x155")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x6007569")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckProperty()
	{
	}
}
