using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Script Control/Common")]
[Description("Will subscribe to a public UnityEvent<T> and return true when that event is raised and it's value is equal to provided value as well.")]
[Token(Token = "0x200118A")]
public class CheckUnityEventValue<T> : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x4008859")]
	[FieldOffset(Offset = "0x0")]
	private Type targetType;

	[SerializeField]
	[Token(Token = "0x400885A")]
	[FieldOffset(Offset = "0x0")]
	private string eventName;

	[SerializeField]
	[Token(Token = "0x400885B")]
	[FieldOffset(Offset = "0x0")]
	private BBParameter<T> checkValue;

	[Token(Token = "0x1700093B")]
	public override Type agentType
	{
		[Token(Token = "0x6007542")]
		[Address(RVA = "0x2341240", Offset = "0x2340040", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700093C")]
	protected override string info
	{
		[Token(Token = "0x6007543")]
		[Address(RVA = "0x23412D0", Offset = "0x23400D0", Length = "0xB2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007544")]
	[Address(RVA = "0x2341390", Offset = "0x2340190", Length = "0x212")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007545")]
	[Address(RVA = "0x23415B0", Offset = "0x23403B0", Length = "0xCF")]
	public void Raised(T eventValue)
	{
	}

	[Token(Token = "0x6007546")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007547")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckUnityEventValue()
	{
	}
}
