using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Script Control/Standalone Only")]
[Description("Execute a static function of up to 6 parameters and optionaly save the return value")]
[Obsolete("Execute Function now supports static functions as well")]
[Token(Token = "0x2001313")]
public class ExecuteStaticFunction : ActionTask, ISubParametersContainer
{
	[SerializeField]
	[Token(Token = "0x4008CE1")]
	[FieldOffset(Offset = "0x68")]
	protected ReflectedWrapper functionWrapper;

	[Token(Token = "0x17000A30")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x6007A46")]
		[Address(RVA = "0x110D4E0", Offset = "0x110C2E0", Length = "0x1A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A31")]
	protected override string info
	{
		[Token(Token = "0x6007A47")]
		[Address(RVA = "0x1190910", Offset = "0x118F710", Length = "0x83D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A45")]
	[Address(RVA = "0x110D4C0", Offset = "0x110C2C0", Length = "0x20")]
	BBParameter[] ISubParametersContainer.GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x6007A48")]
	[Address(RVA = "0x1191150", Offset = "0x118FF50", Length = "0x168")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x6007A49")]
	[Address(RVA = "0x11912C0", Offset = "0x11900C0", Length = "0x138")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007A4A")]
	[Address(RVA = "0x1191400", Offset = "0x1190200", Length = "0x11B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A4B")]
	[Address(RVA = "0x118B1B0", Offset = "0x1189FB0", Length = "0x6C")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x6007A4C")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public ExecuteStaticFunction()
	{
	}
}
