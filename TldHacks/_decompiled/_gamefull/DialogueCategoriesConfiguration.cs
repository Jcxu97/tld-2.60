using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueCategoriesConfiguration", menuName = "Dialogue/Categories Configuration", order = 10004)]
[Token(Token = "0x20002BA")]
public class DialogueCategoriesConfiguration : ScriptableObject
{
	[Token(Token = "0x4001818")]
	[FieldOffset(Offset = "0x18")]
	public List<DialogueModeRigFP.DialogueChoiceCategoryConfiguration> m_CategoryConfigurations;

	[Token(Token = "0x600170D")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public DialogueCategoriesConfiguration()
	{
	}
}
