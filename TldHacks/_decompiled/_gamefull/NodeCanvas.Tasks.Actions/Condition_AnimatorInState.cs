using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD Conditions/BaseAi")]
[Description("returns true if true animator is in the state specified")]
[Name("AnimatorInState", 0)]
[Token(Token = "0x20011B0")]
public class Condition_AnimatorInState : TLD_Condition
{
	[Token(Token = "0x40088B6")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<int> layer;

	[Token(Token = "0x40088B7")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<string> state;

	[Token(Token = "0x60075E9")]
	[Address(RVA = "0x1113580", Offset = "0x1112380", Length = "0x83E")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60075EA")]
	[Address(RVA = "0x1113DC0", Offset = "0x1112BC0", Length = "0x93")]
	public Condition_AnimatorInState()
	{
	}
}
