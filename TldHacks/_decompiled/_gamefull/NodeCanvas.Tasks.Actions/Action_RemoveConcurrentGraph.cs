using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Remove Concurrent Graph", 0)]
[Description("Remove a concurrent graph that was previously created via Invoke Concurrent Graph.")]
[Category("TLD Actions/Concurrent Graph")]
[Token(Token = "0x20011DB")]
public class Action_RemoveConcurrentGraph : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008934")]
	[FieldOffset(Offset = "0x68")]
	public string graphId;

	[Token(Token = "0x600766C")]
	[Address(RVA = "0x1147DB0", Offset = "0x1146BB0", Length = "0x175")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600766D")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_RemoveConcurrentGraph()
	{
	}
}
