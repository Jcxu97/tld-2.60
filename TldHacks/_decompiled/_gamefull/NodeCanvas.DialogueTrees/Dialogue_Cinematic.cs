using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("TLD Cinematic", 0)]
[Description("Make the selected Dialogue Actor speak.")]
[Token(Token = "0x20010DE")]
public class Dialogue_Cinematic : DTNode
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400869E")]
	[FieldOffset(Offset = "0x88")]
	public DialogueAnimationState m_DialogueAnimationState;

	[Token(Token = "0x400869F")]
	[FieldOffset(Offset = "0x90")]
	public TextAsset m_SubtitleAsset;

	[Token(Token = "0x40086A0")]
	[FieldOffset(Offset = "0x98")]
	public string m_AudioEventStart;

	[Token(Token = "0x40086A1")]
	[FieldOffset(Offset = "0xA0")]
	public string m_AudioEventStop;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40086A2")]
	[FieldOffset(Offset = "0xA8")]
	public string m_DebugDialogueAnimationStateName;

	[Token(Token = "0x1700087E")]
	public override string name
	{
		[Token(Token = "0x6007286")]
		[Address(RVA = "0x10E0E60", Offset = "0x10DFC60", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007287")]
	[Address(RVA = "0x10E0EA0", Offset = "0x10DFCA0", Length = "0x20E")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007288")]
	[Address(RVA = "0x10E0E30", Offset = "0x10DFC30", Length = "0x2D")]
	private void OnCinematicFinish()
	{
	}

	[Token(Token = "0x6007289")]
	[Address(RVA = "0x10E0B40", Offset = "0x10DF940", Length = "0x7")]
	public Dialogue_Cinematic()
	{
	}
}
