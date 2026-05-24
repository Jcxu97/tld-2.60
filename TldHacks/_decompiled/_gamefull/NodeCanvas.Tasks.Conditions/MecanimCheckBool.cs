using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Check Parameter Bool", 0)]
[Category("Animator")]
[Token(Token = "0x2001164")]
public class MecanimCheckBool : ConditionTask<Animator>
{
	[RequiredField]
	[Token(Token = "0x40087F0")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> parameter;

	[Token(Token = "0x40087F1")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> value;

	[Token(Token = "0x17000913")]
	protected override string info
	{
		[Token(Token = "0x60074B7")]
		[Address(RVA = "0x1102D40", Offset = "0x1101B40", Length = "0xC2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074B8")]
	[Address(RVA = "0x1102E10", Offset = "0x1101C10", Length = "0xFB")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074B9")]
	[Address(RVA = "0x1102F10", Offset = "0x1101D10", Length = "0x44")]
	public MecanimCheckBool()
	{
	}
}
