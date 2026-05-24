using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Token(Token = "0x2001174")]
public class StringContains : ConditionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008815")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> targetString;

	[Token(Token = "0x4008816")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> checkString;

	[Token(Token = "0x17000923")]
	protected override string info
	{
		[Token(Token = "0x60074E7")]
		[Address(RVA = "0x1104690", Offset = "0x1103490", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074E8")]
	[Address(RVA = "0x1104720", Offset = "0x1103520", Length = "0x7E")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074E9")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public StringContains()
	{
	}
}
