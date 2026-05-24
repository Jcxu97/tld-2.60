using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Token(Token = "0x2001168")]
public class CheckBoolean : ConditionTask
{
	[BlackboardOnly]
	[Token(Token = "0x40087F9")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> valueA;

	[Token(Token = "0x40087FA")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> valueB;

	[Token(Token = "0x17000917")]
	protected override string info
	{
		[Token(Token = "0x60074C3")]
		[Address(RVA = "0x11035F0", Offset = "0x11023F0", Length = "0x9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074C4")]
	[Address(RVA = "0x1103690", Offset = "0x1102490", Length = "0x72")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074C5")]
	[Address(RVA = "0x1103710", Offset = "0x1102510", Length = "0x93")]
	public CheckBoolean()
	{
	}
}
