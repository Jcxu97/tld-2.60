using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Script Control/Common")]
[Description("Will subscribe to a public event of Action<T> type and return true when the event is raised and it's value is equal to provided value as well.\n(eg public event System.Action<T> [name])")]
[Token(Token = "0x2001184")]
public class CheckCSharpEventValue<T> : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x4008847")]
	[FieldOffset(Offset = "0x0")]
	private Type targetType;

	[SerializeField]
	[Token(Token = "0x4008848")]
	[FieldOffset(Offset = "0x0")]
	private string eventName;

	[SerializeField]
	[Token(Token = "0x4008849")]
	[FieldOffset(Offset = "0x0")]
	private BBParameter<T> checkValue;

	[Token(Token = "0x17000931")]
	public override Type agentType
	{
		[Token(Token = "0x600751F")]
		[Address(RVA = "0x232EA90", Offset = "0x232D890", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000932")]
	protected override string info
	{
		[Token(Token = "0x6007520")]
		[Address(RVA = "0x232EB20", Offset = "0x232D920", Length = "0xB2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007521")]
	[Address(RVA = "0x232EBE0", Offset = "0x232D9E0", Length = "0x17C")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007522")]
	[Address(RVA = "0x232ED60", Offset = "0x232DB60", Length = "0xCF")]
	public void Raised(T eventValue)
	{
	}

	[Token(Token = "0x6007523")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007524")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckCSharpEventValue()
	{
	}
}
