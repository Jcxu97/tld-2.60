using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Player")]
[Description("returns true if interactor variable is valid")]
[Name("Has Interactor", 0)]
[Token(Token = "0x200112D")]
public class Condition_HasInteractor : ConditionTask
{
	[Token(Token = "0x4008789")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> interactor;

	[Token(Token = "0x6007412")]
	[Address(RVA = "0x10F8560", Offset = "0x10F7360", Length = "0xF8")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007413")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_HasInteractor()
	{
	}
}
