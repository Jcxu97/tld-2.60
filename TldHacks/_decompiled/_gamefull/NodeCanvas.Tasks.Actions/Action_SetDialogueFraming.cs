using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Dialogue Framing", 0)]
[Description("Set the Framing on the dialogue object")]
[Category("TLD Actions/Animation")]
[Token(Token = "0x20011B8")]
public class Action_SetDialogueFraming : ActionTask
{
	[Token(Token = "0x40088CE")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x40088CF")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> dialogueframing;

	[Token(Token = "0x6007600")]
	[Address(RVA = "0x1116070", Offset = "0x1114E70", Length = "0x17B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007601")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetDialogueFraming()
	{
	}
}
