using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unlock All Maps", 0)]
[Description("Unlock all maps and reveal all fog of war. This actions does NOT reveal icons, use the Reveal Map Icon action to do that.")]
[Category("TLD Mission UI/Map")]
[Token(Token = "0x2001241")]
public class Action_UnlockAllMaps : ActionTask
{
	[Token(Token = "0x6007793")]
	[Address(RVA = "0x115EA30", Offset = "0x115D830", Length = "0x21E")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007794")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_UnlockAllMaps()
	{
	}
}
