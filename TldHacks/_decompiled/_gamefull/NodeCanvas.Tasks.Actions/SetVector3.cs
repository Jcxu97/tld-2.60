using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Set a blackboard Vector3 variable")]
[Token(Token = "0x20012B0")]
public class SetVector3 : ActionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008BA2")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> valueA;

	[Token(Token = "0x4008BA3")]
	[FieldOffset(Offset = "0x70")]
	public OperationMethod operation;

	[Token(Token = "0x4008BA4")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<Vector3> valueB;

	[Token(Token = "0x4008BA5")]
	[FieldOffset(Offset = "0x80")]
	public bool perSecond;

	[Token(Token = "0x170009DD")]
	protected override string info
	{
		[Token(Token = "0x60078D7")]
		[Address(RVA = "0x1173300", Offset = "0x1172100", Length = "0x1FF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078D8")]
	[Address(RVA = "0x1173500", Offset = "0x1172300", Length = "0x17C")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078D9")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public SetVector3()
	{
	}
}
