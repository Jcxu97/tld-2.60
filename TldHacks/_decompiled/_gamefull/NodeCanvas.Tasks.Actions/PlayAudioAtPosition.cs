using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("Audio")]
[Token(Token = "0x200128D")]
public class PlayAudioAtPosition : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008B4A")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<AudioClip> audioClip;

	[SliderField(0, 1)]
	[Token(Token = "0x4008B4B")]
	[FieldOffset(Offset = "0x70")]
	public float volume;

	[Token(Token = "0x4008B4C")]
	[FieldOffset(Offset = "0x74")]
	public bool waitActionFinish;

	[Token(Token = "0x170009C1")]
	protected override string info
	{
		[Token(Token = "0x6007875")]
		[Address(RVA = "0x116FA20", Offset = "0x116E820", Length = "0x62")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007876")]
	[Address(RVA = "0x116FA90", Offset = "0x116E890", Length = "0x190")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007877")]
	[Address(RVA = "0x116FC30", Offset = "0x116EA30", Length = "0x108")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007878")]
	[Address(RVA = "0x116FD40", Offset = "0x116EB40", Length = "0x52")]
	public PlayAudioAtPosition()
	{
	}
}
