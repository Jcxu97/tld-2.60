using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Script Control/Common")]
[Description("Will subscribe to a public event of Action type and return true when the event is raised.\n(eg public static event System.Action [name])")]
[Token(Token = "0x2001186")]
public class CheckStaticCSharpEvent : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x400884F")]
	[FieldOffset(Offset = "0x68")]
	private Type targetType;

	[SerializeField]
	[Token(Token = "0x4008850")]
	[FieldOffset(Offset = "0x70")]
	private string eventName;

	[Token(Token = "0x17000935")]
	protected override string info
	{
		[Token(Token = "0x600752A")]
		[Address(RVA = "0x110AC10", Offset = "0x1109A10", Length = "0xA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600752B")]
	[Address(RVA = "0x110ACC0", Offset = "0x1109AC0", Length = "0x12B")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x600752C")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	public void Raised()
	{
	}

	[Token(Token = "0x600752D")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600752E")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckStaticCSharpEvent()
	{
	}
}
[Category("✫ Script Control/Common")]
[Description("Will subscribe to a public event of Action type and return true when the event is raised.\n(eg public static event System.Action<T> [name])")]
[Token(Token = "0x2001187")]
public class CheckStaticCSharpEvent<T> : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x4008851")]
	[FieldOffset(Offset = "0x0")]
	private Type targetType;

	[SerializeField]
	[Token(Token = "0x4008852")]
	[FieldOffset(Offset = "0x0")]
	private string eventName;

	[SerializeField]
	[BlackboardOnly]
	[Token(Token = "0x4008853")]
	[FieldOffset(Offset = "0x0")]
	private BBParameter<T> saveAs;

	[Token(Token = "0x17000936")]
	protected override string info
	{
		[Token(Token = "0x6007530")]
		[Address(RVA = "0x233E9C0", Offset = "0x233D7C0", Length = "0xA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007531")]
	[Address(RVA = "0x233EA70", Offset = "0x233D870", Length = "0x12E")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007532")]
	[Address(RVA = "0x2333890", Offset = "0x2332690", Length = "0x2E")]
	public void Raised(T eventValue)
	{
	}

	[Token(Token = "0x6007533")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007534")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckStaticCSharpEvent()
	{
	}
}
