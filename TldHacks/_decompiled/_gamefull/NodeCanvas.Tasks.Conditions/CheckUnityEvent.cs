using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Script Control/Common")]
[Description("Will subscribe to a public UnityEvent and return true when that event is raised.")]
[Token(Token = "0x2001188")]
public class CheckUnityEvent : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x4008854")]
	[FieldOffset(Offset = "0x68")]
	private Type targetType;

	[SerializeField]
	[Token(Token = "0x4008855")]
	[FieldOffset(Offset = "0x70")]
	private string eventName;

	[Token(Token = "0x17000937")]
	public override Type agentType
	{
		[Token(Token = "0x6007536")]
		[Address(RVA = "0x110ADF0", Offset = "0x1109BF0", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000938")]
	protected override string info
	{
		[Token(Token = "0x6007537")]
		[Address(RVA = "0x110AE80", Offset = "0x1109C80", Length = "0xA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007538")]
	[Address(RVA = "0x110AF30", Offset = "0x1109D30", Length = "0x1A9")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007539")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	public void Raised()
	{
	}

	[Token(Token = "0x600753A")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600753B")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckUnityEvent()
	{
	}
}
[Category("✫ Script Control/Common")]
[Description("Will subscribe to a public UnityEvent<T> and return true when that event is raised.")]
[Token(Token = "0x2001189")]
public class CheckUnityEvent<T> : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x4008856")]
	[FieldOffset(Offset = "0x0")]
	private Type targetType;

	[SerializeField]
	[Token(Token = "0x4008857")]
	[FieldOffset(Offset = "0x0")]
	private string eventName;

	[SerializeField]
	[Token(Token = "0x4008858")]
	[FieldOffset(Offset = "0x0")]
	private BBParameter<T> saveAs;

	[Token(Token = "0x17000939")]
	public override Type agentType
	{
		[Token(Token = "0x600753C")]
		[Address(RVA = "0x2346A00", Offset = "0x2345800", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700093A")]
	protected override string info
	{
		[Token(Token = "0x600753D")]
		[Address(RVA = "0x2346A90", Offset = "0x2345890", Length = "0xA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600753E")]
	[Address(RVA = "0x2346B40", Offset = "0x2345940", Length = "0x212")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x600753F")]
	[Address(RVA = "0x2333890", Offset = "0x2332690", Length = "0x2E")]
	public void Raised(T eventValue)
	{
	}

	[Token(Token = "0x6007540")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007541")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckUnityEvent()
	{
	}
}
