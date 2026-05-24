using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Check Function (mp)", 0)]
[Category("✫ Script Control/Multiplatform")]
[Description("Call a function on a component and return whether or not the return value is equal to the check value")]
[Token(Token = "0x200118B")]
public class CheckFunction_Multiplatform : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x400885C")]
	[FieldOffset(Offset = "0x68")]
	protected SerializedMethodInfo method;

	[SerializeField]
	[Token(Token = "0x400885D")]
	[FieldOffset(Offset = "0x70")]
	protected List<BBObjectParameter> parameters;

	[SerializeField]
	[BlackboardOnly]
	[Token(Token = "0x400885E")]
	[FieldOffset(Offset = "0x78")]
	protected BBObjectParameter checkValue;

	[SerializeField]
	[Token(Token = "0x400885F")]
	[FieldOffset(Offset = "0x80")]
	protected CompareMethod comparison;

	[Token(Token = "0x4008860")]
	[FieldOffset(Offset = "0x88")]
	private object[] args;

	[Token(Token = "0x1700093D")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x6007548")]
		[Address(RVA = "0x110B0E0", Offset = "0x1109EE0", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700093E")]
	public override Type agentType
	{
		[Token(Token = "0x6007549")]
		[Address(RVA = "0x110B0F0", Offset = "0x1109EF0", Length = "0x170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700093F")]
	protected override string info
	{
		[Token(Token = "0x600754A")]
		[Address(RVA = "0x110B270", Offset = "0x110A070", Length = "0x7A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600754B")]
	[Address(RVA = "0x110BA20", Offset = "0x110A820", Length = "0xF6")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x600754C")]
	[Address(RVA = "0x110BB20", Offset = "0x110A920", Length = "0xF0")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x600754D")]
	[Address(RVA = "0x110BC20", Offset = "0x110AA20", Length = "0x622")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600754E")]
	[Address(RVA = "0x110C250", Offset = "0x110B050", Length = "0x5B1")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x600754F")]
	[Address(RVA = "0x110C810", Offset = "0x110B610", Length = "0xB4")]
	public CheckFunction_Multiplatform()
	{
	}
}
