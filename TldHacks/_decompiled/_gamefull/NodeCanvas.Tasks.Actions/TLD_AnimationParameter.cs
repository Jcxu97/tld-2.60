using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD Conditions")]
[Description("Check if an event is received and return true for one frame")]
[Token(Token = "0x20011BA")]
public class TLD_AnimationParameter : ConditionTask
{
	[Token(Token = "0x40088D5")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x40088D6")]
	[FieldOffset(Offset = "0x70")]
	public string animatorControllerName;

	[Token(Token = "0x40088D7")]
	[FieldOffset(Offset = "0x78")]
	public string parameter;

	[Token(Token = "0x40088D8")]
	[FieldOffset(Offset = "0x80")]
	public AnimatorControllerParameterType parameterType;

	[Token(Token = "0x40088D9")]
	[FieldOffset(Offset = "0x88")]
	public string value;

	[Token(Token = "0x6007609")]
	[Address(RVA = "0x11166F0", Offset = "0x11154F0", Length = "0x5A1")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600760A")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public TLD_AnimationParameter()
	{
	}
}
