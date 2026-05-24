using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("TLD Multiple Choice Hide", 0)]
[Description("Index of choice to hide")]
[Token(Token = "0x20010E4")]
public class Action_HideChoice : DTNode
{
	[Token(Token = "0x40086AE")]
	[FieldOffset(Offset = "0x88")]
	public int choiceIndex;

	[Token(Token = "0x600729D")]
	[Address(RVA = "0x10E27E0", Offset = "0x10E15E0", Length = "0x209")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x600729E")]
	[Address(RVA = "0x10E27C0", Offset = "0x10E15C0", Length = "0x11")]
	public Action_HideChoice()
	{
	}
}
