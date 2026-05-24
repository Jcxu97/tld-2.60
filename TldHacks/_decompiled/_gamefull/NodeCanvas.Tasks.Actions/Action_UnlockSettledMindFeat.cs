using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unlock Settled Mind Feat", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001277")]
public class Action_UnlockSettledMindFeat : ActionTask
{
	[Token(Token = "0x170009B0")]
	protected override string info
	{
		[Token(Token = "0x6007821")]
		[Address(RVA = "0x116A3F0", Offset = "0x11691F0", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007822")]
	[Address(RVA = "0x116A430", Offset = "0x1169230", Length = "0xFA")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007823")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_UnlockSettledMindFeat()
	{
	}
}
