using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012C5")]
public class FindWithName : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008BD5")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> gameObjectName;

	[BlackboardOnly]
	[Token(Token = "0x4008BD6")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<GameObject> saveAs;

	[Token(Token = "0x170009ED")]
	protected override string info
	{
		[Token(Token = "0x600791F")]
		[Address(RVA = "0x1176900", Offset = "0x1175700", Length = "0xBF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007920")]
	[Address(RVA = "0x11769C0", Offset = "0x11757C0", Length = "0x95")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007921")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public FindWithName()
	{
	}
}
