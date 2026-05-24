using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Check Field", 10)]
[Category("✫ Script Control/Common")]
[Description("Check a field on a script and return if it's equal or not to a value")]
[Token(Token = "0x2001185")]
public class CheckField : ConditionTask
{
	[SerializeField]
	[Token(Token = "0x400884A")]
	[FieldOffset(Offset = "0x68")]
	protected BBParameter checkValue;

	[SerializeField]
	[Token(Token = "0x400884B")]
	[FieldOffset(Offset = "0x70")]
	protected Type targetType;

	[SerializeField]
	[Token(Token = "0x400884C")]
	[FieldOffset(Offset = "0x78")]
	protected string fieldName;

	[SerializeField]
	[Token(Token = "0x400884D")]
	[FieldOffset(Offset = "0x80")]
	protected CompareMethod comparison;

	[Token(Token = "0x400884E")]
	[FieldOffset(Offset = "0x88")]
	private FieldInfo field;

	[Token(Token = "0x17000933")]
	public override Type agentType
	{
		[Token(Token = "0x6007525")]
		[Address(RVA = "0x110A480", Offset = "0x1109280", Length = "0xBB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000934")]
	protected override string info
	{
		[Token(Token = "0x6007526")]
		[Address(RVA = "0x110A540", Offset = "0x1109340", Length = "0x21F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007527")]
	[Address(RVA = "0x110A760", Offset = "0x1109560", Length = "0xF5")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007528")]
	[Address(RVA = "0x110A860", Offset = "0x1109660", Length = "0x3AB")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007529")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckField()
	{
	}
}
