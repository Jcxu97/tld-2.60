using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Execute Static Function (mp)", 0)]
[Category("✫ Script Control/Multiplatform")]
[Description("Execute a static function and optionaly save the return value")]
[Obsolete("Execute Function now supports static functions as well")]
[Token(Token = "0x2001314")]
public class ExecuteStaticFunction_Multiplatform : ActionTask
{
	[SerializeField]
	[Token(Token = "0x4008CE2")]
	[FieldOffset(Offset = "0x68")]
	protected SerializedMethodInfo method;

	[SerializeField]
	[Token(Token = "0x4008CE3")]
	[FieldOffset(Offset = "0x70")]
	protected List<BBObjectParameter> parameters;

	[SerializeField]
	[BlackboardOnly]
	[Token(Token = "0x4008CE4")]
	[FieldOffset(Offset = "0x78")]
	protected BBObjectParameter returnValue;

	[Token(Token = "0x17000A32")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x6007A4D")]
		[Address(RVA = "0x110B0E0", Offset = "0x1109EE0", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A33")]
	protected override string info
	{
		[Token(Token = "0x6007A4E")]
		[Address(RVA = "0x1191520", Offset = "0x1190320", Length = "0x767")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A4F")]
	[Address(RVA = "0x1191C90", Offset = "0x1190A90", Length = "0xF6")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x6007A50")]
	[Address(RVA = "0x1191D90", Offset = "0x1190B90", Length = "0xC3")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007A51")]
	[Address(RVA = "0x1191E60", Offset = "0x1190C60", Length = "0x2A4")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007A52")]
	[Address(RVA = "0x1192110", Offset = "0x1190F10", Length = "0x689")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x6007A53")]
	[Address(RVA = "0x11927A0", Offset = "0x11915A0", Length = "0xB4")]
	public ExecuteStaticFunction_Multiplatform()
	{
	}
}
