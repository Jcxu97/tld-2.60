using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;
using UnityEngine;

[CreateAssetMenu(fileName = "DTContainer", menuName = "Dialogue/DT container", order = 10004)]
[Token(Token = "0x20002CE")]
public class DTContainer : ScriptableObject
{
	[Token(Token = "0x4001922")]
	[FieldOffset(Offset = "0x18")]
	public string m_UniqueId;

	[HideInInspector]
	[Token(Token = "0x4001923")]
	[FieldOffset(Offset = "0x20")]
	public string m_ObjectName;

	[Token(Token = "0x4001924")]
	[FieldOffset(Offset = "0x28")]
	public List<DialogueTreeController> m_DialogueTreeControllers;

	[Token(Token = "0x60017F5")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public DTContainer()
	{
	}
}
