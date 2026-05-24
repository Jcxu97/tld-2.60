using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("Dialogue")]
[Icon("Dialogue", false, null)]
[Description("A random statement will be chosen each time for the actor to say")]
[Token(Token = "0x20012B9")]
public class SayRandom : ActionTask<IDialogueActor>
{
	[Token(Token = "0x4008BB8")]
	[FieldOffset(Offset = "0x68")]
	public List<Statement> statements;

	[Token(Token = "0x6007901")]
	[Address(RVA = "0x1174C80", Offset = "0x1173A80", Length = "0x1F8")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007902")]
	[Address(RVA = "0x1174E80", Offset = "0x1173C80", Length = "0xD3")]
	public SayRandom()
	{
	}
}
