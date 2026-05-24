using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Utility")]
[Description("Return true or false based on the probability settings. Outcome is calculated EACH time this is checked")]
[Token(Token = "0x200119D")]
public class Probability : ConditionTask
{
	[Token(Token = "0x400888D")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> probability;

	[Token(Token = "0x400888E")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> maxValue;

	[Token(Token = "0x17000956")]
	protected override string info
	{
		[Token(Token = "0x60075B8")]
		[Address(RVA = "0x1110890", Offset = "0x110F690", Length = "0xF2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60075B9")]
	[Address(RVA = "0x1110990", Offset = "0x110F790", Length = "0xB8")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60075BA")]
	[Address(RVA = "0x1110A50", Offset = "0x110F850", Length = "0x112")]
	public Probability()
	{
	}
}
