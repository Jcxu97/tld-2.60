using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unlock Map", 0)]
[Description("Unlock a map and reveal all fog of war. This actions does NOT reveal icons, use the Reveal Map Icon action to do that.")]
[Category("TLD Mission UI/Map")]
[Token(Token = "0x2001240")]
public class Action_UnlockMap : ActionTask
{
	[Token(Token = "0x4008A6F")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> sceneName;

	[Token(Token = "0x6007791")]
	[Address(RVA = "0x115E650", Offset = "0x115D450", Length = "0x2A6")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007792")]
	[Address(RVA = "0x115E900", Offset = "0x115D700", Length = "0x128")]
	public Action_UnlockMap()
	{
	}
}
