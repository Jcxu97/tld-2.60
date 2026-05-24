using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Layer Weight", 0)]
[Category("Animator")]
[Token(Token = "0x2001289")]
public class MecanimSetLayerWeight : ActionTask<Animator>
{
	[Token(Token = "0x4008B3B")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<int> layerIndex;

	[SliderField(0, 1)]
	[Token(Token = "0x4008B3C")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<float> layerWeight;

	[SliderField(0, 1)]
	[Token(Token = "0x4008B3D")]
	[FieldOffset(Offset = "0x78")]
	public float transitTime;

	[Token(Token = "0x4008B3E")]
	[FieldOffset(Offset = "0x7C")]
	private float currentValue;

	[Token(Token = "0x170009BD")]
	protected override string info
	{
		[Token(Token = "0x6007867")]
		[Address(RVA = "0x116E740", Offset = "0x116D540", Length = "0xBF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007868")]
	[Address(RVA = "0x116E800", Offset = "0x116D600", Length = "0x14A")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007869")]
	[Address(RVA = "0x116E950", Offset = "0x116D750", Length = "0x16F")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600786A")]
	[Address(RVA = "0x116EAC0", Offset = "0x116D8C0", Length = "0x44")]
	public MecanimSetLayerWeight()
	{
	}
}
