using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Category("Composites")]
[Description("Works like a normal Selector, but when a child node returns Success, that child will be moved to the end.\nAs a result, previously Failed children will always be checked first and recently Successful children last")]
[Icon("FlipSelector", false, null)]
[Color("b3ff7f")]
[Token(Token = "0x2001023")]
public class FlipSelector : BTComposite
{
	[Token(Token = "0x400849E")]
	[FieldOffset(Offset = "0x78")]
	private int current;

	[Token(Token = "0x6006D9F")]
	[Address(RVA = "0x10AF100", Offset = "0x10ADF00", Length = "0x149")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DA0")]
	[Address(RVA = "0x10AF250", Offset = "0x10AE050", Length = "0x11A")]
	private void SendToBack(int i)
	{
	}

	[Token(Token = "0x6006DA1")]
	[Address(RVA = "0x10AF370", Offset = "0x10AE170", Length = "0x8")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DA2")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public FlipSelector()
	{
	}
}
