using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Script Control/Common")]
[Description("Get a variable of a script and save it to the blackboard")]
[Name("Get Field", 10)]
[Token(Token = "0x20012EE")]
public class GetField : ActionTask
{
	[SerializeField]
	[Token(Token = "0x4008C7B")]
	[FieldOffset(Offset = "0x68")]
	protected Type targetType;

	[SerializeField]
	[Token(Token = "0x4008C7C")]
	[FieldOffset(Offset = "0x70")]
	protected string fieldName;

	[SerializeField]
	[BlackboardOnly]
	[Token(Token = "0x4008C7D")]
	[FieldOffset(Offset = "0x78")]
	protected BBObjectParameter saveAs;

	[Token(Token = "0x4008C7E")]
	[FieldOffset(Offset = "0x80")]
	private FieldInfo field;

	[Token(Token = "0x170009FE")]
	public override Type agentType
	{
		[Token(Token = "0x600799A")]
		[Address(RVA = "0x11853C0", Offset = "0x11841C0", Length = "0xBB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009FF")]
	protected override string info
	{
		[Token(Token = "0x600799B")]
		[Address(RVA = "0x1185480", Offset = "0x1184280", Length = "0x14A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600799C")]
	[Address(RVA = "0x11855D0", Offset = "0x11843D0", Length = "0x117")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x600799D")]
	[Address(RVA = "0x11856F0", Offset = "0x11844F0", Length = "0x9F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600799E")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public GetField()
	{
	}
}
