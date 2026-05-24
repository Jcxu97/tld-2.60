using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Token(Token = "0x200116D")]
public class CheckString : ConditionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008805")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> valueA;

	[Token(Token = "0x4008806")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> valueB;

	[Token(Token = "0x1700091C")]
	protected override string info
	{
		[Token(Token = "0x60074D2")]
		[Address(RVA = "0x1103E60", Offset = "0x1102C60", Length = "0x9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074D3")]
	[Address(RVA = "0x1103F00", Offset = "0x1102D00", Length = "0xB3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074D4")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckString()
	{
	}
}
