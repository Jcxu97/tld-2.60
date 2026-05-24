using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Description("Checks the current speed of the agent against a value based on it's Rigidbody velocity")]
[Token(Token = "0x2001312")]
public class CheckSpeed : ConditionTask<Rigidbody>
{
	[Token(Token = "0x4008CDE")]
	[FieldOffset(Offset = "0x68")]
	public CompareMethod checkType;

	[Token(Token = "0x4008CDF")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> value;

	[SliderField(0f, 0.1f)]
	[Token(Token = "0x4008CE0")]
	[FieldOffset(Offset = "0x78")]
	public float differenceThreshold;

	[Token(Token = "0x17000A2F")]
	protected override string info
	{
		[Token(Token = "0x6007A42")]
		[Address(RVA = "0x1190660", Offset = "0x118F460", Length = "0x7E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A43")]
	[Address(RVA = "0x11906E0", Offset = "0x118F4E0", Length = "0x1C4")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007A44")]
	[Address(RVA = "0x11908B0", Offset = "0x118F6B0", Length = "0x52")]
	public CheckSpeed()
	{
	}
}
