using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("Timeline Cinematic", 0)]
[Description("Make the selected Dialogue Actor speak.")]
[Token(Token = "0x20010DD")]
public class Dialogue_TimelineCinematic : DTNode
{
	[Token(Token = "0x400869C")]
	[FieldOffset(Offset = "0x88")]
	public DialogueTimelineScript m_DialogueTimelineScript;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400869D")]
	[FieldOffset(Offset = "0x90")]
	public string m_DebugDialogueTimelineScriptName;

	[Token(Token = "0x1700087D")]
	public override string name
	{
		[Token(Token = "0x6007282")]
		[Address(RVA = "0x10E0B50", Offset = "0x10DF950", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007283")]
	[Address(RVA = "0x10E0B90", Offset = "0x10DF990", Length = "0x292")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007284")]
	[Address(RVA = "0x10E0E30", Offset = "0x10DFC30", Length = "0x2D")]
	private void OnCinematicFinish()
	{
	}

	[Token(Token = "0x6007285")]
	[Address(RVA = "0x10E0B40", Offset = "0x10DF940", Length = "0x7")]
	public Dialogue_TimelineCinematic()
	{
	}
}
