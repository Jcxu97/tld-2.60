using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unlock Snow Shelter", 0)]
[Description("Unlock the use of snow shelters.")]
[Category("TLD Unlocks")]
[Token(Token = "0x2001261")]
public class Action_UnlockSnowShelter : ActionTask
{
	[Token(Token = "0x60077E8")]
	[Address(RVA = "0x1166690", Offset = "0x1165490", Length = "0xAB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077E9")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_UnlockSnowShelter()
	{
	}
}
