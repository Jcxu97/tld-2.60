using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unlock Knowledge", 0)]
[Category("TLD Unlocks")]
[Token(Token = "0x200125F")]
public class Action_UnlockKnowledge : ActionTask
{
	[Token(Token = "0x4008AC7")]
	[FieldOffset(Offset = "0x68")]
	public KnowledgeCateogry category;

	[Token(Token = "0x4008AC8")]
	[FieldOffset(Offset = "0x70")]
	public string nameLocID;

	[Token(Token = "0x4008AC9")]
	[FieldOffset(Offset = "0x78")]
	public string descLocID;

	[Token(Token = "0x4008ACA")]
	[FieldOffset(Offset = "0x80")]
	public string notificationLocID;

	[Token(Token = "0x4008ACB")]
	[FieldOffset(Offset = "0x88")]
	public bool showNotificationFlag;

	[Token(Token = "0x60077E4")]
	[Address(RVA = "0x11663B0", Offset = "0x11651B0", Length = "0xBD")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077E5")]
	[Address(RVA = "0x1166470", Offset = "0x1165270", Length = "0xF")]
	public Action_UnlockKnowledge()
	{
	}
}
