using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Override Pos Before Interior Load", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001269")]
public class Action_OverridePosBeforeInteriorLoad : ActionTask<GraphOwner>
{
	[Token(Token = "0x4008AE9")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 overridePos;

	[Token(Token = "0x60077FD")]
	[Address(RVA = "0x1168360", Offset = "0x1167160", Length = "0x80")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077FE")]
	[Address(RVA = "0x11683F0", Offset = "0x11671F0", Length = "0x44")]
	public Action_OverridePosBeforeInteriorLoad()
	{
	}
}
