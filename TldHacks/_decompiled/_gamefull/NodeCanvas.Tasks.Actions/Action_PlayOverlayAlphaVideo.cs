using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("PlayOverlayAlphaVideo", 0)]
[Category("TLD Actions")]
[Token(Token = "0x200127F")]
public class Action_PlayOverlayAlphaVideo : ActionTask
{
	[Token(Token = "0x4008B14")]
	[FieldOffset(Offset = "0x68")]
	public string videoPathWithExt;

	[Token(Token = "0x170009B5")]
	protected override string info
	{
		[Token(Token = "0x6007841")]
		[Address(RVA = "0x116B550", Offset = "0x116A350", Length = "0x8A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007842")]
	[Address(RVA = "0x116B5E0", Offset = "0x116A3E0", Length = "0x6F")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007843")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_PlayOverlayAlphaVideo()
	{
	}
}
