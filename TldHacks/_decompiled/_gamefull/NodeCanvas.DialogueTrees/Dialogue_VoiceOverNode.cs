using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("TLD Say", 0)]
[Description("Make the selected Dialogue Actor speak.")]
[Token(Token = "0x20010DF")]
public class Dialogue_VoiceOverNode : DTNode
{
	[Token(Token = "0x40086A3")]
	[FieldOffset(Offset = "0x88")]
	public VoiceOverItem statement;

	[Token(Token = "0x600728A")]
	[Address(RVA = "0x10E10B0", Offset = "0x10DFEB0", Length = "0x445")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x600728B")]
	[Address(RVA = "0x10E0E30", Offset = "0x10DFC30", Length = "0x2D")]
	private void OnStatementFinish()
	{
	}

	[Token(Token = "0x600728C")]
	[Address(RVA = "0x10E1500", Offset = "0x10E0300", Length = "0xA5")]
	public Dialogue_VoiceOverNode()
	{
	}
}
