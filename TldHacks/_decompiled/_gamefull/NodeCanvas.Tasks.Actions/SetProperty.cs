using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Property", -2)]
[Category("✫ Script Control/Standalone Only")]
[Description("Set a property on a script")]
[Token(Token = "0x20012FE")]
public class SetProperty : ActionTask, ISubParametersContainer
{
	[SerializeField]
	[Token(Token = "0x4008CA6")]
	[FieldOffset(Offset = "0x68")]
	protected ReflectedActionWrapper functionWrapper;

	[Token(Token = "0x17000A1E")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x6007A02")]
		[Address(RVA = "0x110D4E0", Offset = "0x110C2E0", Length = "0x1A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A1F")]
	public override Type agentType
	{
		[Token(Token = "0x6007A03")]
		[Address(RVA = "0x118C3C0", Offset = "0x118B1C0", Length = "0x1A7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A20")]
	protected override string info
	{
		[Token(Token = "0x6007A04")]
		[Address(RVA = "0x118C570", Offset = "0x118B370", Length = "0x27C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A01")]
	[Address(RVA = "0x110D4C0", Offset = "0x110C2C0", Length = "0x20")]
	BBParameter[] ISubParametersContainer.GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x6007A05")]
	[Address(RVA = "0x118C7F0", Offset = "0x118B5F0", Length = "0x168")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x6007A06")]
	[Address(RVA = "0x118C960", Offset = "0x118B760", Length = "0x18D")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007A07")]
	[Address(RVA = "0x118BA80", Offset = "0x118A880", Length = "0x46")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A08")]
	[Address(RVA = "0x118CAF0", Offset = "0x118B8F0", Length = "0x6C")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x6007A09")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetProperty()
	{
	}
}
