using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("Dialogue")]
[Description("You can use a variable inline with the text by using brackets likeso: [myVarName] or [Global/myVarName].\nThe bracket will be replaced with the variable value ToString")]
[Icon("Dialogue", false, null)]
[Token(Token = "0x20012B8")]
public class Say : ActionTask<IDialogueActor>
{
	[Token(Token = "0x4008BB7")]
	[FieldOffset(Offset = "0x68")]
	public Statement statement;

	[Token(Token = "0x170009E7")]
	protected override string info
	{
		[Token(Token = "0x60078FE")]
		[Address(RVA = "0x1174910", Offset = "0x1173710", Length = "0x138")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078FF")]
	[Address(RVA = "0x1174A50", Offset = "0x1173850", Length = "0x144")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007900")]
	[Address(RVA = "0x1174BA0", Offset = "0x11739A0", Length = "0xD3")]
	public Say()
	{
	}
}
