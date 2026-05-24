using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unlock Blueprint", 0)]
[Description("Unlock a blueprint. The blueprintName must match prefab name of the crafted result.")]
[Category("TLD Unlocks")]
[Token(Token = "0x2001260")]
public class Action_UnlockBlueprint : ActionTask
{
	[Token(Token = "0x4008ACC")]
	[FieldOffset(Offset = "0x68")]
	public string blueprintName;

	[Token(Token = "0x4008ACD")]
	[FieldOffset(Offset = "0x70")]
	public bool showNotification;

	[Token(Token = "0x60077E6")]
	[Address(RVA = "0x1166480", Offset = "0x1165280", Length = "0x1FD")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077E7")]
	[Address(RVA = "0x1166680", Offset = "0x1165480", Length = "0xC")]
	public Action_UnlockBlueprint()
	{
	}
}
