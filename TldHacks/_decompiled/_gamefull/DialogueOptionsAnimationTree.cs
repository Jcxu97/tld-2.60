using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002C9")]
public class DialogueOptionsAnimationTree : MonoBehaviour
{
	[Token(Token = "0x40018F3")]
	[FieldOffset(Offset = "0x20")]
	private List<DialogueSequenceFP> m_DialogueSequenceFPList;

	[Token(Token = "0x40018F4")]
	public static string m_DebugCurrentTextSelected;

	[Token(Token = "0x60017C4")]
	[Address(RVA = "0x6DFBA0", Offset = "0x6DE9A0", Length = "0x268")]
	public void InstantiateLabels(GameObject labelPrefab)
	{
	}

	[Token(Token = "0x60017C5")]
	[Address(RVA = "0x6DFE10", Offset = "0x6DEC10", Length = "0xC5")]
	private Vector3 GetScreenCenterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60017C6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Update()
	{
	}

	[Token(Token = "0x60017C7")]
	[Address(RVA = "0x6DFEE0", Offset = "0x6DECE0", Length = "0x76A")]
	public void UpdateClosestToCenter()
	{
	}

	[Token(Token = "0x60017C8")]
	[Address(RVA = "0x6E0650", Offset = "0x6DF450", Length = "0xE3")]
	public DialogueOptionsAnimationTree()
	{
	}
}
