using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Play Animation", 0)]
[Category("Animator")]
[Token(Token = "0x2001284")]
public class MecanimPlayAnimation : ActionTask<Animator>
{
	[Token(Token = "0x4008B27")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<int> layerIndex;

	[RequiredField]
	[Token(Token = "0x4008B28")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> stateName;

	[SliderField(0, 1)]
	[Token(Token = "0x4008B29")]
	[FieldOffset(Offset = "0x78")]
	public float transitTime;

	[Token(Token = "0x4008B2A")]
	[FieldOffset(Offset = "0x7C")]
	public bool waitUntilFinish;

	[Token(Token = "0x4008B2B")]
	[FieldOffset(Offset = "0x80")]
	private AnimatorStateInfo stateInfo;

	[Token(Token = "0x4008B2C")]
	[FieldOffset(Offset = "0xA4")]
	private bool played;

	[Token(Token = "0x170009B8")]
	protected override string info
	{
		[Token(Token = "0x6007854")]
		[Address(RVA = "0x116D180", Offset = "0x116BF80", Length = "0x7A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007855")]
	[Address(RVA = "0x116D200", Offset = "0x116C000", Length = "0x212")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007856")]
	[Address(RVA = "0x116D420", Offset = "0x116C220", Length = "0x27D")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007857")]
	[Address(RVA = "0x116D6A0", Offset = "0x116C4A0", Length = "0x52")]
	public MecanimPlayAnimation()
	{
	}
}
