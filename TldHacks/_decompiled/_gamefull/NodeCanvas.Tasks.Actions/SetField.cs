using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Script Control/Common")]
[Description("Set a variable on a script")]
[Name("Set Field", 9)]
[Token(Token = "0x20012F2")]
public class SetField : ActionTask
{
	[SerializeField]
	[Token(Token = "0x4008C84")]
	[FieldOffset(Offset = "0x68")]
	protected BBObjectParameter setValue;

	[SerializeField]
	[Token(Token = "0x4008C85")]
	[FieldOffset(Offset = "0x70")]
	protected Type targetType;

	[SerializeField]
	[Token(Token = "0x4008C86")]
	[FieldOffset(Offset = "0x78")]
	protected string fieldName;

	[Token(Token = "0x4008C87")]
	[FieldOffset(Offset = "0x80")]
	private FieldInfo field;

	[Token(Token = "0x17000A03")]
	public override Type agentType
	{
		[Token(Token = "0x60079A8")]
		[Address(RVA = "0x1185960", Offset = "0x1184760", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A04")]
	protected override string info
	{
		[Token(Token = "0x60079A9")]
		[Address(RVA = "0x11859F0", Offset = "0x11847F0", Length = "0x113")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079AA")]
	[Address(RVA = "0x1185B10", Offset = "0x1184910", Length = "0x117")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x60079AB")]
	[Address(RVA = "0x1185C30", Offset = "0x1184A30", Length = "0x93")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60079AC")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetField()
	{
	}
}
