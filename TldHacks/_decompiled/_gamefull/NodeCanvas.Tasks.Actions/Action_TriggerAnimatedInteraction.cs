using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Trigger Animation Interaction", 0)]
[Description("Sets a variable on an animator")]
[Category("TLD Actions/Animation")]
[Token(Token = "0x20011B5")]
public class Action_TriggerAnimatedInteraction : ActionTask
{
	[Token(Token = "0x40088C6")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> parameter;

	[Token(Token = "0x40088C7")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> waitForComplete;

	[Token(Token = "0x40088C8")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> worldSpace;

	[Token(Token = "0x40088C9")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<bool> unequipItem;

	[Token(Token = "0x60075F8")]
	[Address(RVA = "0x1115A30", Offset = "0x1114830", Length = "0x7")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075F9")]
	[Address(RVA = "0x1115A40", Offset = "0x1114840", Length = "0x2C7")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60075FA")]
	[Address(RVA = "0x10C5290", Offset = "0x10C4090", Length = "0xA")]
	private void OnWorkDone()
	{
	}

	[Token(Token = "0x60075FB")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_TriggerAnimatedInteraction()
	{
	}
}
