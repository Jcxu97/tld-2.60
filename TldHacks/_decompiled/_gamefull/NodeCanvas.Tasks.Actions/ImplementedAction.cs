using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Script Control/Standalone Only")]
[Description("Calls a function that has signature of 'public Status NAME()' or 'public Status NAME(T)'. You should return Status.Success, Failure or Running within that function.")]
[Token(Token = "0x20012FD")]
public class ImplementedAction : ActionTask, ISubParametersContainer
{
	[SerializeField]
	[Token(Token = "0x4008CA4")]
	[FieldOffset(Offset = "0x68")]
	protected ReflectedFunctionWrapper functionWrapper;

	[Token(Token = "0x4008CA5")]
	[FieldOffset(Offset = "0x70")]
	private Status actionStatus;

	[Token(Token = "0x17000A1B")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x60079F8")]
		[Address(RVA = "0x110D4E0", Offset = "0x110C2E0", Length = "0x1A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1C")]
	public override Type agentType
	{
		[Token(Token = "0x60079F9")]
		[Address(RVA = "0x118BB40", Offset = "0x118A940", Length = "0x1A7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1D")]
	protected override string info
	{
		[Token(Token = "0x60079FA")]
		[Address(RVA = "0x118BCF0", Offset = "0x118AAF0", Length = "0x2F5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079F7")]
	[Address(RVA = "0x110D4C0", Offset = "0x110C2C0", Length = "0x20")]
	BBParameter[] ISubParametersContainer.GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x60079FB")]
	[Address(RVA = "0x118BFF0", Offset = "0x118ADF0", Length = "0x168")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x60079FC")]
	[Address(RVA = "0x118C160", Offset = "0x118AF60", Length = "0x18D")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x60079FD")]
	[Address(RVA = "0x118C2F0", Offset = "0x118B0F0", Length = "0xA9")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60079FE")]
	[Address(RVA = "0x118C3A0", Offset = "0x118B1A0", Length = "0x8")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x60079FF")]
	[Address(RVA = "0x118BAD0", Offset = "0x118A8D0", Length = "0x6C")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x6007A00")]
	[Address(RVA = "0x118C3B0", Offset = "0x118B1B0", Length = "0xF")]
	public ImplementedAction()
	{
	}
}
