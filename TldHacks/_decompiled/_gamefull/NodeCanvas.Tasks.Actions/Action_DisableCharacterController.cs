using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Disable Character Controller", 0)]
[Description("Disables the character controller while active")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001206")]
public class Action_DisableCharacterController : ActionTask
{
	[Token(Token = "0x60076E1")]
	[Address(RVA = "0x1150520", Offset = "0x114F320", Length = "0x57")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076E2")]
	[Address(RVA = "0x1150580", Offset = "0x114F380", Length = "0x57")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x60076E3")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_DisableCharacterController()
	{
	}
}
