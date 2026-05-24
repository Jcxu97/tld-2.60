using System;
using System.Reflection;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Property (mp)", -2)]
[Category("✫ Script Control/Multiplatform")]
[Description("Set a property on a script")]
[Token(Token = "0x20012F9")]
public class SetProperty_Multiplatform : ActionTask
{
	[SerializeField]
	[Token(Token = "0x4008C9B")]
	[FieldOffset(Offset = "0x68")]
	protected SerializedMethodInfo method;

	[SerializeField]
	[Token(Token = "0x4008C9C")]
	[FieldOffset(Offset = "0x70")]
	protected BBObjectParameter parameter;

	[Token(Token = "0x17000A10")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x60079D4")]
		[Address(RVA = "0x110B0E0", Offset = "0x1109EE0", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A11")]
	public override Type agentType
	{
		[Token(Token = "0x60079D5")]
		[Address(RVA = "0x11893A0", Offset = "0x11881A0", Length = "0x170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A12")]
	protected override string info
	{
		[Token(Token = "0x60079D6")]
		[Address(RVA = "0x1189520", Offset = "0x1188320", Length = "0x21E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079D7")]
	[Address(RVA = "0x1189740", Offset = "0x1188540", Length = "0x25B")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x60079D8")]
	[Address(RVA = "0x11899A0", Offset = "0x11887A0", Length = "0xC3")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x60079D9")]
	[Address(RVA = "0x1189A70", Offset = "0x1188870", Length = "0x120")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60079DA")]
	[Address(RVA = "0x1189BA0", Offset = "0x11889A0", Length = "0x163")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x60079DB")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetProperty_Multiplatform()
	{
	}
}
