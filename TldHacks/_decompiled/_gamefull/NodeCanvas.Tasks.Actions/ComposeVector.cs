using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Create a new Vector out of 3 floats and save it to the blackboard")]
[Token(Token = "0x200128E")]
public class ComposeVector : ActionTask
{
	[Token(Token = "0x4008B4D")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> x;

	[Token(Token = "0x4008B4E")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> y;

	[Token(Token = "0x4008B4F")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> z;

	[BlackboardOnly]
	[Token(Token = "0x4008B50")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<Vector3> saveAs;

	[Token(Token = "0x170009C2")]
	protected override string info
	{
		[Token(Token = "0x6007879")]
		[Address(RVA = "0x116FDA0", Offset = "0x116EBA0", Length = "0x67")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600787A")]
	[Address(RVA = "0x116FE10", Offset = "0x116EC10", Length = "0xEA")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600787B")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public ComposeVector()
	{
	}
}
