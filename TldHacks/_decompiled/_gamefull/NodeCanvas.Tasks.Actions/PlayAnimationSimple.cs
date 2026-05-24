using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Animation")]
[Token(Token = "0x2001283")]
public class PlayAnimationSimple : ActionTask<Animation>
{
	[RequiredField]
	[Token(Token = "0x4008B22")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<AnimationClip> animationClip;

	[SliderField(0, 1)]
	[Token(Token = "0x4008B23")]
	[FieldOffset(Offset = "0x70")]
	public float crossFadeTime;

	[Token(Token = "0x4008B24")]
	[FieldOffset(Offset = "0x74")]
	public WrapMode animationWrap;

	[Token(Token = "0x4008B25")]
	[FieldOffset(Offset = "0x78")]
	public bool waitActionFinish;

	[Token(Token = "0x4008B26")]
	private static Dictionary<Animation, AnimationClip> lastPlayedClips;

	[Token(Token = "0x170009B7")]
	protected override string info
	{
		[Token(Token = "0x600784E")]
		[Address(RVA = "0x116C8D0", Offset = "0x116B6D0", Length = "0x62")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600784F")]
	[Address(RVA = "0x116C940", Offset = "0x116B740", Length = "0x140")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6007850")]
	[Address(RVA = "0x116CA90", Offset = "0x116B890", Length = "0x490")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007851")]
	[Address(RVA = "0x116CF30", Offset = "0x116BD30", Length = "0x111")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007852")]
	[Address(RVA = "0x116D050", Offset = "0x116BE50", Length = "0x49")]
	public PlayAnimationSimple()
	{
	}
}
