using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Use this to set a variable on any blackboard by overriding the agent")]
[Name("TLD Set Other Blackboard Variable", 0)]
[Token(Token = "0x2001270")]
public class TLDSetOtherBlackboardVariable : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008AF7")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x4008AF8")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> targetVariableName;

	[Token(Token = "0x4008AF9")]
	[FieldOffset(Offset = "0x78")]
	public BBObjectParameter newValue;

	[Token(Token = "0x170009AB")]
	protected override string info
	{
		[Token(Token = "0x6007809")]
		[Address(RVA = "0x1168AD0", Offset = "0x11678D0", Length = "0xE6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600780A")]
	[Address(RVA = "0x1168BC0", Offset = "0x11679C0", Length = "0x24F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600780B")]
	[Address(RVA = "0x1168E10", Offset = "0x1167C10", Length = "0x307")]
	private Blackboard GetBlackboard()
	{
		return null;
	}

	[Token(Token = "0x600780C")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public TLDSetOtherBlackboardVariable()
	{
	}
}
