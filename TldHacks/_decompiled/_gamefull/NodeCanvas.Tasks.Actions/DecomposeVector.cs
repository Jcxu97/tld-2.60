using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Create up to 3 floats from a Vector and save them to blackboard")]
[Token(Token = "0x200128F")]
public class DecomposeVector : ActionTask
{
	[Token(Token = "0x4008B51")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Vector3> targetVector;

	[BlackboardOnly]
	[Token(Token = "0x4008B52")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> x;

	[BlackboardOnly]
	[Token(Token = "0x4008B53")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> y;

	[BlackboardOnly]
	[Token(Token = "0x4008B54")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> z;

	[Token(Token = "0x170009C3")]
	protected override string info
	{
		[Token(Token = "0x600787C")]
		[Address(RVA = "0x116FF00", Offset = "0x116ED00", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600787D")]
	[Address(RVA = "0x116FF70", Offset = "0x116ED70", Length = "0xF9")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600787E")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public DecomposeVector()
	{
	}
}
