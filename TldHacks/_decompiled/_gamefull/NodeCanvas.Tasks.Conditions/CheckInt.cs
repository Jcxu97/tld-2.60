using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions;

[Category("✫ Blackboard")]
[Token(Token = "0x200116C")]
public class CheckInt : ConditionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008802")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<int> valueA;

	[Token(Token = "0x4008803")]
	[FieldOffset(Offset = "0x70")]
	public CompareMethod checkType;

	[Token(Token = "0x4008804")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<int> valueB;

	[Token(Token = "0x1700091B")]
	protected override string info
	{
		[Token(Token = "0x60074CF")]
		[Address(RVA = "0x1103BD0", Offset = "0x11029D0", Length = "0x8F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074D0")]
	[Address(RVA = "0x1103D70", Offset = "0x1102B70", Length = "0xE0")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074D1")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public CheckInt()
	{
	}
}
