using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD/AI")]
[Name("SetBaseAiFleeDestination", 0)]
[Description("Sets the baseai to use position on next flee")]
[Token(Token = "0x20011A9")]
public class Action_SetBaseAIFleeDestination : TLD_Action
{
	[Token(Token = "0x40088A8")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x60075D7")]
	[Address(RVA = "0x1112170", Offset = "0x1110F70", Length = "0x2CB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075D8")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetBaseAIFleeDestination()
	{
	}
}
