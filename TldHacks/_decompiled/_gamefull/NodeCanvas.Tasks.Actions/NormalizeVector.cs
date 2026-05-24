using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Token(Token = "0x20012A2")]
public class NormalizeVector : ActionTask
{
	[Token(Token = "0x4008B80")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> targetVector;

	[Token(Token = "0x4008B81")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> multiply;

	[Token(Token = "0x60078B2")]
	[Address(RVA = "0x1171A80", Offset = "0x1170880", Length = "0x18D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078B3")]
	[Address(RVA = "0x1171C10", Offset = "0x1170A10", Length = "0x95")]
	public NormalizeVector()
	{
	}
}
