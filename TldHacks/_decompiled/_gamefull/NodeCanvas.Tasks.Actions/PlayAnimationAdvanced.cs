using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Animation")]
[Token(Token = "0x2001282")]
public class PlayAnimationAdvanced : ActionTask<Animation>
{
	[RequiredField]
	[Token(Token = "0x4008B15")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<AnimationClip> animationClip;

	[Token(Token = "0x4008B16")]
	[FieldOffset(Offset = "0x70")]
	public WrapMode animationWrap;

	[Token(Token = "0x4008B17")]
	[FieldOffset(Offset = "0x74")]
	public AnimationBlendMode blendMode;

	[SliderField(0, 2)]
	[Token(Token = "0x4008B18")]
	[FieldOffset(Offset = "0x78")]
	public float playbackSpeed;

	[SliderField(0, 1)]
	[Token(Token = "0x4008B19")]
	[FieldOffset(Offset = "0x7C")]
	public float crossFadeTime;

	[Token(Token = "0x4008B1A")]
	[FieldOffset(Offset = "0x80")]
	public PlayDirections playDirection;

	[Token(Token = "0x4008B1B")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<string> mixTransformName;

	[Token(Token = "0x4008B1C")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<int> animationLayer;

	[Token(Token = "0x4008B1D")]
	[FieldOffset(Offset = "0x98")]
	public bool queueAnimation;

	[Token(Token = "0x4008B1E")]
	[FieldOffset(Offset = "0x99")]
	public bool waitActionFinish;

	[Token(Token = "0x4008B1F")]
	[FieldOffset(Offset = "0xA0")]
	private string animationToPlay;

	[Token(Token = "0x4008B20")]
	[FieldOffset(Offset = "0xA8")]
	private int dir;

	[Token(Token = "0x4008B21")]
	[FieldOffset(Offset = "0xB0")]
	private Transform mixTransform;

	[Token(Token = "0x170009B6")]
	protected override string info
	{
		[Token(Token = "0x6007848")]
		[Address(RVA = "0x116B700", Offset = "0x116A500", Length = "0x62")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007849")]
	[Address(RVA = "0x116B770", Offset = "0x116A570", Length = "0x140")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x600784A")]
	[Address(RVA = "0x116B8C0", Offset = "0x116A6C0", Length = "0xCEC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600784B")]
	[Address(RVA = "0x116C5B0", Offset = "0x116B3B0", Length = "0x133")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600784C")]
	[Address(RVA = "0x116C6F0", Offset = "0x116B4F0", Length = "0x129")]
	private Transform FindTransform(Transform parent, string name)
	{
		return null;
	}

	[Token(Token = "0x600784D")]
	[Address(RVA = "0x116C820", Offset = "0x116B620", Length = "0xAF")]
	public PlayAnimationAdvanced()
	{
	}
}
