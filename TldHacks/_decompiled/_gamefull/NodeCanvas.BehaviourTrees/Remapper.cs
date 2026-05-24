using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Remap", 0)]
[Category("Decorators")]
[Description("Remap the child node's status to another status. Used to either invert the child's return status or to always return a specific status.")]
[Icon("Remap", false, null)]
[Token(Token = "0x200103D")]
public class Remapper : BTDecorator
{
	[Token(Token = "0x200103E")]
	public enum RemapStatus
	{
		[Token(Token = "0x40084F8")]
		Failure,
		[Token(Token = "0x40084F9")]
		Success
	}

	[Token(Token = "0x40084F5")]
	[FieldOffset(Offset = "0x78")]
	public RemapStatus successRemap;

	[Token(Token = "0x40084F6")]
	[FieldOffset(Offset = "0x7C")]
	public RemapStatus failureRemap;

	[Token(Token = "0x6006DF3")]
	[Address(RVA = "0x10B3440", Offset = "0x10B2240", Length = "0xCE")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DF4")]
	[Address(RVA = "0x10B3510", Offset = "0x10B2310", Length = "0xE")]
	public Remapper()
	{
	}
}
