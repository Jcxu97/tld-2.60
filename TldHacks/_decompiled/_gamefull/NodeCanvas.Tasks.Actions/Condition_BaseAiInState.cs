using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD Conditions/BaseAi")]
[Description("returns true if ai agent is in the state specified")]
[Name("IsBaseAIState", 0)]
[Token(Token = "0x20011A7")]
public class Condition_BaseAiInState : TLD_Condition
{
	[Token(Token = "0x40088A3")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<AiMode> state;

	[Token(Token = "0x1700095B")]
	protected override string info
	{
		[Token(Token = "0x60075D2")]
		[Address(RVA = "0x1111B60", Offset = "0x1110960", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075D3")]
	[Address(RVA = "0x1111BD0", Offset = "0x11109D0", Length = "0x1E1")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60075D4")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_BaseAiInState()
	{
	}
}
