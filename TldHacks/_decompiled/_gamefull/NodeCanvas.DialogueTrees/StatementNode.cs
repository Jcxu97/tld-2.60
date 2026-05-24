using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("Say", 0)]
[Description("Make the selected Dialogue Actor talk. You can make the text more dynamic by using variable names in square brackets\ne.g. [myVarName] or [Global/myVarName]")]
[Token(Token = "0x2001106")]
public class StatementNode : DTNode
{
	[SerializeField]
	[Token(Token = "0x4008710")]
	[FieldOffset(Offset = "0x88")]
	private Statement statement;

	[Token(Token = "0x170008C8")]
	public override bool requireActorSelection
	{
		[Token(Token = "0x6007364")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007365")]
	[Address(RVA = "0x10EB960", Offset = "0x10EA760", Length = "0xFE")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007366")]
	[Address(RVA = "0x10E0E30", Offset = "0x10DFC30", Length = "0x2D")]
	private void OnStatementFinish()
	{
	}

	[Token(Token = "0x6007367")]
	[Address(RVA = "0x10EBA60", Offset = "0x10EA860", Length = "0xC5")]
	public StatementNode()
	{
	}
}
