using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Category("Composites")]
[Description("Executes one child based on the provided int or enum and return it's status. If set to Dynamic and 'case' change while a child is running, that child will be interrupted before the new child is executed.")]
[Icon("IndexSwitcher", false, null)]
[Color("b3ff7f")]
[Token(Token = "0x200102B")]
public class Switch : BTComposite
{
	[Token(Token = "0x200102C")]
	public enum CaseSelectionMode
	{
		[Token(Token = "0x40084BE")]
		IndexBased,
		[Token(Token = "0x40084BF")]
		EnumBased
	}

	[Token(Token = "0x200102D")]
	public enum OutOfRangeMode
	{
		[Token(Token = "0x40084C1")]
		ReturnFailure,
		[Token(Token = "0x40084C2")]
		LoopIndex
	}

	[Token(Token = "0x40084B6")]
	[FieldOffset(Offset = "0x78")]
	public bool dynamic;

	[Token(Token = "0x40084B7")]
	[FieldOffset(Offset = "0x7C")]
	public CaseSelectionMode selectionMode;

	[ShowIf("selectionMode", 0)]
	[Token(Token = "0x40084B8")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<int> intCase;

	[ShowIf("selectionMode", 0)]
	[Token(Token = "0x40084B9")]
	[FieldOffset(Offset = "0x88")]
	public OutOfRangeMode outOfRangeMode;

	[ShowIf("selectionMode", 1)]
	[BlackboardOnly]
	[Token(Token = "0x40084BA")]
	[FieldOffset(Offset = "0x90")]
	public BBObjectParameter enumCase;

	[Token(Token = "0x40084BB")]
	[FieldOffset(Offset = "0x98")]
	private int current;

	[Token(Token = "0x40084BC")]
	[FieldOffset(Offset = "0x9C")]
	private int runningIndex;

	[Token(Token = "0x6006DC4")]
	[Address(RVA = "0x10B1650", Offset = "0x10B0450", Length = "0x28E")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DC5")]
	[Address(RVA = "0x10B18E0", Offset = "0x10B06E0", Length = "0x11A")]
	public Switch()
	{
	}
}
