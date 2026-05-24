using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;
using UnityEngine;

[Token(Token = "0x2000857")]
public class ClickToStartDialogue : MonoBehaviour
{
	[Token(Token = "0x40056C0")]
	[FieldOffset(Offset = "0x20")]
	public DialogueTree dialogue;

	[Token(Token = "0x6004CE3")]
	[Address(RVA = "0xD7E860", Offset = "0xD7D660", Length = "0x4D")]
	private void Start()
	{
	}

	[Token(Token = "0x6004CE4")]
	[Address(RVA = "0xD7E8B0", Offset = "0xD7D6B0", Length = "0xD9")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x6004CE5")]
	[Address(RVA = "0xD7E990", Offset = "0xD7D790", Length = "0x26")]
	private void OnDialogueEnd(bool success)
	{
	}

	[Token(Token = "0x6004CE6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ClickToStartDialogue()
	{
	}
}
