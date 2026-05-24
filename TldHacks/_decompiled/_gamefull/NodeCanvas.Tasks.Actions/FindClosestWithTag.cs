using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Description("Find the closest game object of tag to the agent")]
[Token(Token = "0x20012C1")]
public class FindClosestWithTag : ActionTask<Transform>
{
	[TagField]
	[RequiredField]
	[Token(Token = "0x4008BCB")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> searchTag;

	[Token(Token = "0x4008BCC")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> ignoreChildren;

	[BlackboardOnly]
	[Token(Token = "0x4008BCD")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> saveObjectAs;

	[BlackboardOnly]
	[Token(Token = "0x4008BCE")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> saveDistanceAs;

	[Token(Token = "0x6007916")]
	[Address(RVA = "0x1176310", Offset = "0x1175110", Length = "0x593")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007917")]
	[Address(RVA = "0x11768B0", Offset = "0x11756B0", Length = "0x44")]
	public FindClosestWithTag()
	{
	}
}
