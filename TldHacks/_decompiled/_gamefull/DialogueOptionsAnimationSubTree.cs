using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;
using UnityEngine;

[Token(Token = "0x20002C8")]
public class DialogueOptionsAnimationSubTree : MonoBehaviour
{
	[Token(Token = "0x40018F1")]
	[FieldOffset(Offset = "0x20")]
	private List<DialogueSequenceFP> m_DialogueSequenceFPList;

	[Token(Token = "0x40018F2")]
	[FieldOffset(Offset = "0x28")]
	public Dialogue_MultipleChoiceNode.ChoiceCategory m_Category;

	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x6DF010", Offset = "0x6DDE10", Length = "0xA9D")]
	public List<DialogueSequenceFP> InstantiateLabels(GameObject labelPrefab)
	{
		return null;
	}

	[Token(Token = "0x60017C3")]
	[Address(RVA = "0x6DFAB0", Offset = "0x6DE8B0", Length = "0xE3")]
	public DialogueOptionsAnimationSubTree()
	{
	}
}
