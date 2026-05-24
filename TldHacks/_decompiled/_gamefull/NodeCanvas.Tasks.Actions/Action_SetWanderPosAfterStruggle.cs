using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD/AI")]
[Name("SetWanderPosAfterStruggle", 0)]
[Description("Sets the baseai to use position specified position to wander to after a struggle")]
[Token(Token = "0x20011AA")]
public class Action_SetWanderPosAfterStruggle : TLD_Action
{
	[Token(Token = "0x40088A9")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x60075D9")]
	[Address(RVA = "0x1112440", Offset = "0x1111240", Length = "0x2BC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075DA")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetWanderPosAfterStruggle()
	{
	}
}
