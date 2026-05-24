using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Get Property (mp)", -1)]
[Category("✫ Script Control/Multiplatform")]
[Description("Get a property of a script and save it to the blackboard")]
[Token(Token = "0x20012F6")]
public class GetProperty_Multiplatform : ActionTask
{
	[SerializeField]
	[Token(Token = "0x4008C94")]
	[FieldOffset(Offset = "0x68")]
	protected SerializedMethodInfo method;

	[SerializeField]
	[BlackboardOnly]
	[Token(Token = "0x4008C95")]
	[FieldOffset(Offset = "0x70")]
	protected BBObjectParameter returnValue;

	[Token(Token = "0x17000A0A")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x60079C0")]
		[Address(RVA = "0x110B0E0", Offset = "0x1109EE0", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A0B")]
	public override Type agentType
	{
		[Token(Token = "0x60079C1")]
		[Address(RVA = "0x1187C80", Offset = "0x1186A80", Length = "0x170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A0C")]
	protected override string info
	{
		[Token(Token = "0x60079C2")]
		[Address(RVA = "0x1187E00", Offset = "0x1186C00", Length = "0x21D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079C3")]
	[Address(RVA = "0x1188020", Offset = "0x1186E20", Length = "0x222")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x60079C4")]
	[Address(RVA = "0x1188250", Offset = "0x1187050", Length = "0xC3")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x60079C5")]
	[Address(RVA = "0x1188320", Offset = "0x1187120", Length = "0xE8")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60079C6")]
	[Address(RVA = "0x1188410", Offset = "0x1187210", Length = "0x136")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x60079C7")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public GetProperty_Multiplatform()
	{
	}
}
