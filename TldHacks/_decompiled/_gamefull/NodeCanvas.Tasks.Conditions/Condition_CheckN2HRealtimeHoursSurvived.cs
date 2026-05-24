using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Name("Check Realtime Hours Survived in Nowhere To Hide", 0)]
[Token(Token = "0x2001159")]
public class Condition_CheckN2HRealtimeHoursSurvived : ConditionTask
{
	[Token(Token = "0x40087DE")]
	[FieldOffset(Offset = "0x68")]
	public float m_Value;

	[Token(Token = "0x40087DF")]
	[FieldOffset(Offset = "0x6C")]
	public CompareMethod m_CheckType;

	[SliderField(0f, 0.1f)]
	[Token(Token = "0x40087E0")]
	[FieldOffset(Offset = "0x70")]
	public float differenceThreshold;

	[Token(Token = "0x1700090E")]
	protected override string info
	{
		[Token(Token = "0x6007492")]
		[Address(RVA = "0x1101110", Offset = "0x10FFF10", Length = "0xAF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007493")]
	[Address(RVA = "0x11011C0", Offset = "0x10FFFC0", Length = "0xE1")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007494")]
	[Address(RVA = "0x11012B0", Offset = "0x11000B0", Length = "0xF")]
	public Condition_CheckN2HRealtimeHoursSurvived()
	{
	}
}
