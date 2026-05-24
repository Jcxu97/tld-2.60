using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Force Uncrouch Enable", 0)]
[Description("Force uncrouched and lock/unlock crouching ability.")]
[Category("TLD Actions/Player")]
[Token(Token = "0x200121E")]
public class Action_ForceUncrouchEnable : ActionTask
{
	[Token(Token = "0x40089F1")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> isLocked;

	[Token(Token = "0x600771C")]
	[Address(RVA = "0x11569E0", Offset = "0x11557E0", Length = "0x1A8")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600771D")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ForceUncrouchEnable()
	{
	}
}
