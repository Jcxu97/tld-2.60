using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("Dialogue")]
[Description("Starts the Dialogue Tree assigned on a Dialogue Tree Controller object with specified agent used for 'Instigator'.")]
[Icon("Dialogue", false, null)]
[Token(Token = "0x20012BA")]
public class StartDialogueTree : ActionTask<IDialogueActor>
{
	[RequiredField]
	[Token(Token = "0x4008BB9")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<DialogueTreeController> dialogueTreeController;

	[Token(Token = "0x4008BBA")]
	[FieldOffset(Offset = "0x70")]
	public bool waitActionFinish;

	[Token(Token = "0x170009E8")]
	protected override string info
	{
		[Token(Token = "0x6007903")]
		[Address(RVA = "0x1174F60", Offset = "0x1173D60", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007904")]
	[Address(RVA = "0x1174FF0", Offset = "0x1173DF0", Length = "0x1A8")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007905")]
	[Address(RVA = "0x11751A0", Offset = "0x1173FA0", Length = "0x4C")]
	public StartDialogueTree()
	{
	}
}
