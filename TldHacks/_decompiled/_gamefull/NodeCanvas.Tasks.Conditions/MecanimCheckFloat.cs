using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Check Parameter Float", 0)]
[Category("Animator")]
[Token(Token = "0x2001165")]
public class MecanimCheckFloat : ConditionTask<Animator>
{
	[RequiredField]
	[Token(Token = "0x40087F2")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> parameter;

	[Token(Token = "0x40087F3")]
	[FieldOffset(Offset = "0x70")]
	public CompareMethod comparison;

	[Token(Token = "0x40087F4")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> value;

	[Token(Token = "0x17000914")]
	protected override string info
	{
		[Token(Token = "0x60074BA")]
		[Address(RVA = "0x1102F60", Offset = "0x1101D60", Length = "0xB7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074BB")]
	[Address(RVA = "0x1103020", Offset = "0x1101E20", Length = "0x193")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074BC")]
	[Address(RVA = "0x11031C0", Offset = "0x1101FC0", Length = "0x44")]
	public MecanimCheckFloat()
	{
	}
}
