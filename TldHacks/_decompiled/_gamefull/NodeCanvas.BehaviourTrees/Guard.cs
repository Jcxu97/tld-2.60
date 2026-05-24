using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Guard", 0)]
[Category("Decorators")]
[Icon("Shield", false, null)]
[Description("Protect the decorated child from running if another Guard with the same token is already guarding (Running) that token.\nGuarding is global for all of the agent's Behaviour Trees.")]
[Token(Token = "0x2001033")]
public class Guard : BTDecorator
{
	[Token(Token = "0x2001034")]
	public enum GuardMode
	{
		[Token(Token = "0x40084DC")]
		ReturnFailure,
		[Token(Token = "0x40084DD")]
		WaitUntilReleased
	}

	[Token(Token = "0x40084D7")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> token;

	[Token(Token = "0x40084D8")]
	[FieldOffset(Offset = "0x80")]
	public GuardMode ifGuarded;

	[Token(Token = "0x40084D9")]
	[FieldOffset(Offset = "0x84")]
	private bool isGuarding;

	[Token(Token = "0x40084DA")]
	private static readonly Dictionary<GameObject, List<Guard>> guards;

	[Token(Token = "0x6006DD7")]
	[Address(RVA = "0x10B21B0", Offset = "0x10B0FB0", Length = "0x9D")]
	private static List<Guard> AgentGuards(Component agent)
	{
		return null;
	}

	[Token(Token = "0x6006DD8")]
	[Address(RVA = "0x10B2250", Offset = "0x10B1050", Length = "0x23")]
	public override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006DD9")]
	[Address(RVA = "0x10B2280", Offset = "0x10B1080", Length = "0x35B")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DDA")]
	[Address(RVA = "0x10B25E0", Offset = "0x10B13E0", Length = "0x8")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DDB")]
	[Address(RVA = "0x10B25F0", Offset = "0x10B13F0", Length = "0x2E1")]
	private void SetGuards(Component guardAgent)
	{
	}

	[Token(Token = "0x6006DDC")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public Guard()
	{
	}
}
