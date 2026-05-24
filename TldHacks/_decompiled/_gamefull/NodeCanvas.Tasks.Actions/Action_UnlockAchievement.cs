using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unlock Achievement", 0)]
[Category("TLD Achievement")]
[Token(Token = "0x20011A0")]
public class Action_UnlockAchievement : ActionTask
{
	[Token(Token = "0x4008892")]
	[FieldOffset(Offset = "0x68")]
	public Achievement achievement;

	[Token(Token = "0x60075C1")]
	[Address(RVA = "0x1110E30", Offset = "0x110FC30", Length = "0x66")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075C2")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_UnlockAchievement()
	{
	}
}
