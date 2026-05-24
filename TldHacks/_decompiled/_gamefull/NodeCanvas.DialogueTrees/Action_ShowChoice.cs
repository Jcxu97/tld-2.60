using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("TLD Multiple Choice Show", 0)]
[Description("Index of choice to show")]
[Token(Token = "0x20010E3")]
public class Action_ShowChoice : DTNode
{
	[Token(Token = "0x40086AD")]
	[FieldOffset(Offset = "0x88")]
	public int choiceIndex;

	[Token(Token = "0x600729B")]
	[Address(RVA = "0x10E25B0", Offset = "0x10E13B0", Length = "0x209")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x600729C")]
	[Address(RVA = "0x10E27C0", Offset = "0x10E15C0", Length = "0x11")]
	public Action_ShowChoice()
	{
	}
}
