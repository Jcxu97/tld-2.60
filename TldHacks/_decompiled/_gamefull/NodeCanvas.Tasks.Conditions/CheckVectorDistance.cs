using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Token(Token = "0x2001170")]
public class CheckVectorDistance : ConditionTask
{
	[BlackboardOnly]
	[Token(Token = "0x400880B")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> vectorA;

	[BlackboardOnly]
	[Token(Token = "0x400880C")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<Vector3> vectorB;

	[Token(Token = "0x400880D")]
	[FieldOffset(Offset = "0x78")]
	public CompareMethod comparison;

	[Token(Token = "0x400880E")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> distance;

	[Token(Token = "0x1700091F")]
	protected override string info
	{
		[Token(Token = "0x60074DB")]
		[Address(RVA = "0x11041E0", Offset = "0x1102FE0", Length = "0x1CD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074DC")]
	[Address(RVA = "0x11043B0", Offset = "0x11031B0", Length = "0x1C0")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074DD")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckVectorDistance()
	{
	}
}
