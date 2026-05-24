using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Parameter Float", 0)]
[Category("Animator")]
[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
[Token(Token = "0x2001286")]
public class MecanimSetFloat : ActionTask<Animator>
{
	[Token(Token = "0x4008B30")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> parameter;

	[Token(Token = "0x4008B31")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<int> parameterHashID;

	[Token(Token = "0x4008B32")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> setTo;

	[SliderField(0, 1)]
	[Token(Token = "0x4008B33")]
	[FieldOffset(Offset = "0x80")]
	public float transitTime;

	[Token(Token = "0x4008B34")]
	[FieldOffset(Offset = "0x84")]
	private float currentValue;

	[Token(Token = "0x170009BA")]
	protected override string info
	{
		[Token(Token = "0x600785B")]
		[Address(RVA = "0x116DA30", Offset = "0x116C830", Length = "0x106")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600785C")]
	[Address(RVA = "0x116DB40", Offset = "0x116C940", Length = "0x88")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600785D")]
	[Address(RVA = "0x116DBD0", Offset = "0x116C9D0", Length = "0xD6")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600785E")]
	[Address(RVA = "0x116DCB0", Offset = "0x116CAB0", Length = "0x180")]
	private float Get()
	{
		return 0f;
	}

	[Token(Token = "0x600785F")]
	[Address(RVA = "0x116DE40", Offset = "0x116CC40", Length = "0x18A")]
	private void Set(float newValue)
	{
	}

	[Token(Token = "0x6007860")]
	[Address(RVA = "0x116DFD0", Offset = "0x116CDD0", Length = "0x58")]
	public MecanimSetFloat()
	{
	}
}
