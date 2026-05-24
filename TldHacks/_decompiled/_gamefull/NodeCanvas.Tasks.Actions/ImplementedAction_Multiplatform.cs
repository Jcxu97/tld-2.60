using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Implemented Action (mp)", 0)]
[Category("✫ Script Control/Multiplatform")]
[Description("Calls a function that has signature of 'public Status NAME()' or 'public Status NAME(T)'. You should return Status.Success, Failure or Running within that function.")]
[Token(Token = "0x20012F7")]
public class ImplementedAction_Multiplatform : ActionTask
{
	[SerializeField]
	[Token(Token = "0x4008C96")]
	[FieldOffset(Offset = "0x68")]
	private SerializedMethodInfo method;

	[SerializeField]
	[Token(Token = "0x4008C97")]
	[FieldOffset(Offset = "0x70")]
	private List<BBObjectParameter> parameters;

	[Token(Token = "0x4008C98")]
	[FieldOffset(Offset = "0x78")]
	private Status actionStatus;

	[Token(Token = "0x17000A0D")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x60079C8")]
		[Address(RVA = "0x110B0E0", Offset = "0x1109EE0", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A0E")]
	public override Type agentType
	{
		[Token(Token = "0x60079C9")]
		[Address(RVA = "0x1188550", Offset = "0x1187350", Length = "0x170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A0F")]
	protected override string info
	{
		[Token(Token = "0x60079CA")]
		[Address(RVA = "0x11886D0", Offset = "0x11874D0", Length = "0x29B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079CB")]
	[Address(RVA = "0x1188970", Offset = "0x1187770", Length = "0xF6")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x60079CC")]
	[Address(RVA = "0x1188A70", Offset = "0x1187870", Length = "0xC3")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x60079CD")]
	[Address(RVA = "0x1188B40", Offset = "0x1187940", Length = "0x2DE")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60079CE")]
	[Address(RVA = "0x1188E20", Offset = "0x1187C20", Length = "0x8")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x60079CF")]
	[Address(RVA = "0x1188E30", Offset = "0x1187C30", Length = "0x3B5")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x60079D0")]
	[Address(RVA = "0x11891F0", Offset = "0x1187FF0", Length = "0xBB")]
	public ImplementedAction_Multiplatform()
	{
	}
}
