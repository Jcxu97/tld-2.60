using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Physics")]
[Description("Gets a lists of game objects that are in the physics overlap sphere at the position of the agent, excluding the agent")]
[Token(Token = "0x20012EC")]
public class GetOverlapSphereObjects : ActionTask<Transform>
{
	[Token(Token = "0x4008C76")]
	[FieldOffset(Offset = "0x68")]
	public LayerMask layerMask;

	[Token(Token = "0x4008C77")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> radius;

	[BlackboardOnly]
	[Token(Token = "0x4008C78")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<List<GameObject>> saveObjectsAs;

	[Token(Token = "0x6007994")]
	[Address(RVA = "0x1184A90", Offset = "0x1183890", Length = "0x4E3")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007995")]
	[Address(RVA = "0x1184F80", Offset = "0x1183D80", Length = "0x2EF")]
	public override void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6007996")]
	[Address(RVA = "0x1185270", Offset = "0x1184070", Length = "0xA7")]
	public GetOverlapSphereObjects()
	{
	}
}
