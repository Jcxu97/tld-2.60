using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Post Event to Concurrent Graph", 0)]
[Description("Post an event to a named Concurrent Graph.")]
[Category("TLD Actions/Concurrent Graph")]
[Token(Token = "0x20011DC")]
public class Action_PostEventToConcurrentGraph : ActionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x4008935")]
	[FieldOffset(Offset = "0x68")]
	public string graphId;

	[Token(Token = "0x4008936")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> eventName;

	[Token(Token = "0x600766E")]
	[Address(RVA = "0x1147F30", Offset = "0x1146D30", Length = "0x293")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600766F")]
	[Address(RVA = "0x11481D0", Offset = "0x1146FD0", Length = "0x44")]
	public Action_PostEventToConcurrentGraph()
	{
	}
}
[Name("Post Event<T> to Concurrent Graph", 0)]
[Description("Post an event to a named Concurrent Graph.")]
[Category("TLD Actions/Concurrent Graph")]
[Token(Token = "0x20011DD")]
public class Action_PostEventToConcurrentGraph<T> : ActionTask<GraphOwner>
{
	[RequiredField]
	[Token(Token = "0x4008937")]
	[FieldOffset(Offset = "0x0")]
	public string graphId;

	[Token(Token = "0x4008938")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<string> eventName;

	[Token(Token = "0x4008939")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T> eventValue;

	[Token(Token = "0x6007670")]
	[Address(RVA = "0x244F720", Offset = "0x244E520", Length = "0x2E2")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007671")]
	[Address(RVA = "0x244FA10", Offset = "0x244E810", Length = "0x44")]
	public Action_PostEventToConcurrentGraph()
	{
	}
}
