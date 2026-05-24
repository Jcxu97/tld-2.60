using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Use this to set a variable on any blackboard by overriding the agent")]
[Token(Token = "0x20012AD")]
public class SetOtherBlackboardVariable : ActionTask<Blackboard>
{
	[RequiredField]
	[Token(Token = "0x4008B9C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> targetVariableName;

	[Token(Token = "0x4008B9D")]
	[FieldOffset(Offset = "0x70")]
	public BBObjectParameter newValue;

	[Token(Token = "0x170009DA")]
	protected override string info
	{
		[Token(Token = "0x60078CE")]
		[Address(RVA = "0x1172F80", Offset = "0x1171D80", Length = "0xE6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078CF")]
	[Address(RVA = "0x1173070", Offset = "0x1171E70", Length = "0x10A")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078D0")]
	[Address(RVA = "0x1173180", Offset = "0x1171F80", Length = "0x44")]
	public SetOtherBlackboardVariable()
	{
	}
}
