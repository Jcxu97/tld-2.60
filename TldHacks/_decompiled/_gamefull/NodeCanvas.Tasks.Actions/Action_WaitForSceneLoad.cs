using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Wait for Scene to Load", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001276")]
public class Action_WaitForSceneLoad : ActionTask
{
	[Token(Token = "0x4008B02")]
	[FieldOffset(Offset = "0x68")]
	private bool m_HasLoggedLoadingMessage;

	[Token(Token = "0x170009AF")]
	protected override string info
	{
		[Token(Token = "0x600781E")]
		[Address(RVA = "0x116A2A0", Offset = "0x11690A0", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600781F")]
	[Address(RVA = "0x116A2E0", Offset = "0x11690E0", Length = "0x101")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007820")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_WaitForSceneLoad()
	{
	}
}
