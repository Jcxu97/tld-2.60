using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Check Parameter Int", 0)]
[Category("Animator")]
[Token(Token = "0x2001166")]
public class MecanimCheckInt : ConditionTask<Animator>
{
	[RequiredField]
	[Token(Token = "0x40087F5")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> parameter;

	[Token(Token = "0x40087F6")]
	[FieldOffset(Offset = "0x70")]
	public CompareMethod comparison;

	[Token(Token = "0x40087F7")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<int> value;

	[Token(Token = "0x17000915")]
	protected override string info
	{
		[Token(Token = "0x60074BD")]
		[Address(RVA = "0x1103210", Offset = "0x1102010", Length = "0xB7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074BE")]
	[Address(RVA = "0x11032D0", Offset = "0x11020D0", Length = "0x16D")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074BF")]
	[Address(RVA = "0x1103440", Offset = "0x1102240", Length = "0x44")]
	public MecanimCheckInt()
	{
	}
}
