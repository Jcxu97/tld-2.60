using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Script Control/Common")]
[Description("Will subscribe to a public event of Action type and return true when the event is raised.\n(eg public event System.Action [name])")]
[Token(Token = "0x2001182")]
public class CheckCSharpEvent : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x4008842")]
	[FieldOffset(Offset = "0x68")]
	private Type targetType;

	[SerializeField]
	[Token(Token = "0x4008843")]
	[FieldOffset(Offset = "0x70")]
	private string eventName;

	[Token(Token = "0x1700092D")]
	public override Type agentType
	{
		[Token(Token = "0x6007513")]
		[Address(RVA = "0x110A180", Offset = "0x1108F80", Length = "0xBB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700092E")]
	protected override string info
	{
		[Token(Token = "0x6007514")]
		[Address(RVA = "0x110A240", Offset = "0x1109040", Length = "0xA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007515")]
	[Address(RVA = "0x110A2F0", Offset = "0x11090F0", Length = "0x17C")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007516")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	public void Raised()
	{
	}

	[Token(Token = "0x6007517")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007518")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckCSharpEvent()
	{
	}
}
[Category("✫ Script Control/Common")]
[Description("Will subscribe to a public event of Action<T> type and return true when the event is raised.\n(eg public event System.Action<T> [name])")]
[Token(Token = "0x2001183")]
public class CheckCSharpEvent<T> : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x4008844")]
	[FieldOffset(Offset = "0x0")]
	private Type targetType;

	[SerializeField]
	[Token(Token = "0x4008845")]
	[FieldOffset(Offset = "0x0")]
	private string eventName;

	[SerializeField]
	[Token(Token = "0x4008846")]
	[FieldOffset(Offset = "0x0")]
	private BBParameter<T> saveAs;

	[Token(Token = "0x1700092F")]
	public override Type agentType
	{
		[Token(Token = "0x6007519")]
		[Address(RVA = "0x23335D0", Offset = "0x23323D0", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000930")]
	protected override string info
	{
		[Token(Token = "0x600751A")]
		[Address(RVA = "0x2333660", Offset = "0x2332460", Length = "0xA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600751B")]
	[Address(RVA = "0x2333710", Offset = "0x2332510", Length = "0x17C")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x600751C")]
	[Address(RVA = "0x2333890", Offset = "0x2332690", Length = "0x2E")]
	public void Raised(T eventValue)
	{
	}

	[Token(Token = "0x600751D")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600751E")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckCSharpEvent()
	{
	}
}
