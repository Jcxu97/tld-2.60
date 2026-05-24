using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Check Property (mp)", 0)]
[Category("✫ Script Control/Multiplatform")]
[Description("Check a property on a script and return if it's equal or not to the check value")]
[Token(Token = "0x200118C")]
public class CheckProperty_Multiplatform : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x4008861")]
	[FieldOffset(Offset = "0x68")]
	protected SerializedMethodInfo method;

	[SerializeField]
	[Token(Token = "0x4008862")]
	[FieldOffset(Offset = "0x70")]
	protected BBObjectParameter checkValue;

	[SerializeField]
	[Token(Token = "0x4008863")]
	[FieldOffset(Offset = "0x78")]
	protected CompareMethod comparison;

	[Token(Token = "0x17000940")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x6007550")]
		[Address(RVA = "0x110B0E0", Offset = "0x1109EE0", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000941")]
	public override Type agentType
	{
		[Token(Token = "0x6007551")]
		[Address(RVA = "0x110C8D0", Offset = "0x110B6D0", Length = "0x170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000942")]
	protected override string info
	{
		[Token(Token = "0x6007552")]
		[Address(RVA = "0x110CA50", Offset = "0x110B850", Length = "0x249")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007553")]
	[Address(RVA = "0x110CCA0", Offset = "0x110BAA0", Length = "0x229")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x6007554")]
	[Address(RVA = "0x110CED0", Offset = "0x110BCD0", Length = "0x4F")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007555")]
	[Address(RVA = "0x110CF20", Offset = "0x110BD20", Length = "0x44D")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007556")]
	[Address(RVA = "0x110D370", Offset = "0x110C170", Length = "0x142")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x6007557")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckProperty_Multiplatform()
	{
	}
}
