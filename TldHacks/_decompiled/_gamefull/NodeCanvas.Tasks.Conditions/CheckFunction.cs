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
[Description("Call a function with none or up to 6 parameters on a component and return whether or not the return value is equal to the check value")]
[Token(Token = "0x200118D")]
public class CheckFunction : ConditionTask, ISubParametersContainer
{
	[SerializeField]
	[Token(Token = "0x4008864")]
	[FieldOffset(Offset = "0x68")]
	protected ReflectedFunctionWrapper functionWrapper;

	[SerializeField]
	[Token(Token = "0x4008865")]
	[FieldOffset(Offset = "0x70")]
	protected BBParameter checkValue;

	[SerializeField]
	[Token(Token = "0x4008866")]
	[FieldOffset(Offset = "0x78")]
	protected CompareMethod comparison;

	[Token(Token = "0x17000943")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x6007559")]
		[Address(RVA = "0x110D4E0", Offset = "0x110C2E0", Length = "0x1A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000944")]
	public override Type agentType
	{
		[Token(Token = "0x600755A")]
		[Address(RVA = "0x110D500", Offset = "0x110C300", Length = "0x1A7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000945")]
	protected override string info
	{
		[Token(Token = "0x600755B")]
		[Address(RVA = "0x110D6B0", Offset = "0x110C4B0", Length = "0x7C5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007558")]
	[Address(RVA = "0x110D4C0", Offset = "0x110C2C0", Length = "0x20")]
	BBParameter[] ISubParametersContainer.GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x600755C")]
	[Address(RVA = "0x110DE80", Offset = "0x110CC80", Length = "0x286")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x600755D")]
	[Address(RVA = "0x110E110", Offset = "0x110CF10", Length = "0x101")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x600755E")]
	[Address(RVA = "0x110E220", Offset = "0x110D020", Length = "0x38E")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600755F")]
	[Address(RVA = "0x110E5B0", Offset = "0x110D3B0", Length = "0x155")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x6007560")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckFunction()
	{
	}
}
