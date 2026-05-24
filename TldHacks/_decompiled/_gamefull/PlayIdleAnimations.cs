using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Play Idle Animations")]
[Token(Token = "0x2000055")]
public class PlayIdleAnimations : MonoBehaviour
{
	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x20")]
	private Animation mAnim;

	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x28")]
	private AnimationClip mIdle;

	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0x30")]
	private List<AnimationClip> mBreaks;

	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x38")]
	private float mNextBreak;

	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x3C")]
	private int mLastIndex;

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xA1F290", Offset = "0xA1E090", Length = "0x8A5")]
	private void Start()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xA1FB40", Offset = "0xA1E940", Length = "0x2F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xA1FE40", Offset = "0xA1EC40", Length = "0xE3")]
	public PlayIdleAnimations()
	{
	}
}
