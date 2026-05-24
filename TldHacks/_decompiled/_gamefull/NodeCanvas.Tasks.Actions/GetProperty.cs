using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Get Property", -1)]
[Category("✫ Script Control/Standalone Only")]
[Description("Get a property of a script and save it to the blackboard")]
[Token(Token = "0x20012FC")]
public class GetProperty : ActionTask, ISubParametersContainer
{
	[SerializeField]
	[Token(Token = "0x4008CA3")]
	[FieldOffset(Offset = "0x68")]
	protected ReflectedFunctionWrapper functionWrapper;

	[Token(Token = "0x17000A18")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x60079EF")]
		[Address(RVA = "0x110D4E0", Offset = "0x110C2E0", Length = "0x1A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A19")]
	public override Type agentType
	{
		[Token(Token = "0x60079F0")]
		[Address(RVA = "0x118B350", Offset = "0x118A150", Length = "0x1A7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1A")]
	protected override string info
	{
		[Token(Token = "0x60079F1")]
		[Address(RVA = "0x118B500", Offset = "0x118A300", Length = "0x27B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079EE")]
	[Address(RVA = "0x110D4C0", Offset = "0x110C2C0", Length = "0x20")]
	BBParameter[] ISubParametersContainer.GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x60079F2")]
	[Address(RVA = "0x118B780", Offset = "0x118A580", Length = "0x168")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x60079F3")]
	[Address(RVA = "0x118B8F0", Offset = "0x118A6F0", Length = "0x18D")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x60079F4")]
	[Address(RVA = "0x118BA80", Offset = "0x118A880", Length = "0x46")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60079F5")]
	[Address(RVA = "0x118BAD0", Offset = "0x118A8D0", Length = "0x6C")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x60079F6")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public GetProperty()
	{
	}
}
