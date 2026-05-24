using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Invoke Concurrent Graph", 0)]
[Description("Invoke a new graph to run concurrently with the calling FSM. 'varAssignments' will copy from the current FSM blackboard into a *new* blackboard belonging to the new graph.")]
[Category("TLD Actions/Concurrent Graph")]
[Token(Token = "0x20011DA")]
public class Action_InvokeConcurrentGraph : ActionTask
{
	[RequiredField]
	[Token(Token = "0x400892F")]
	[FieldOffset(Offset = "0x68")]
	public string graphId;

	[RequiredField]
	[Token(Token = "0x4008930")]
	[FieldOffset(Offset = "0x70")]
	public FSM graphAsset;

	[Token(Token = "0x4008931")]
	[FieldOffset(Offset = "0x78")]
	public bool useParentBlackboard;

	[Token(Token = "0x4008932")]
	[FieldOffset(Offset = "0x80")]
	public string customGlobalBlackboardId;

	[Token(Token = "0x4008933")]
	[FieldOffset(Offset = "0x88")]
	public string varAssignments;

	[Token(Token = "0x600766A")]
	[Address(RVA = "0x1147590", Offset = "0x1146390", Length = "0x788")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600766B")]
	[Address(RVA = "0x1147D20", Offset = "0x1146B20", Length = "0x8E")]
	public Action_InvokeConcurrentGraph()
	{
	}
}
