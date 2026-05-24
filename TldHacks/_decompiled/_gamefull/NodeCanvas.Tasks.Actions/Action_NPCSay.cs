using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("NPC Say", 0)]
[Description("Make the NPC say a given line of dialogue.")]
[Category("TLD Actions/NPC")]
[Token(Token = "0x20011EB")]
public class Action_NPCSay : ActionTask
{
	[Token(Token = "0x4008953")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> npcIdentifier;

	[Token(Token = "0x4008954")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<List<VoiceOverItem>> speechOptions;

	[Token(Token = "0x4008955")]
	[FieldOffset(Offset = "0x78")]
	public string lastChoiceVar;

	[Token(Token = "0x4008956")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> randomize;

	[Token(Token = "0x4008957")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<bool> blockUntilComplete;

	[Token(Token = "0x600769B")]
	[Address(RVA = "0x114B620", Offset = "0x114A420", Length = "0x46A")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600769C")]
	[Address(RVA = "0x114BA90", Offset = "0x114A890", Length = "0x7B")]
	private static void AkVoiceCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x600769D")]
	[Address(RVA = "0x10C5290", Offset = "0x10C4090", Length = "0xA")]
	private void DialogueCompleted()
	{
	}

	[Token(Token = "0x600769E")]
	[Address(RVA = "0x114BB10", Offset = "0x114A910", Length = "0x40A")]
	public Action_NPCSay()
	{
	}
}
