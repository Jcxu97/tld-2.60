using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("Camera")]
[Token(Token = "0x20012B7")]
public class FadeOut : ActionTask
{
	[Token(Token = "0x4008BB6")]
	[FieldOffset(Offset = "0x68")]
	public float fadeTime;

	[Token(Token = "0x60078FB")]
	[Address(RVA = "0x1174840", Offset = "0x1173640", Length = "0xCF")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078FC")]
	[Address(RVA = "0x1174810", Offset = "0x1173610", Length = "0x2E")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60078FD")]
	[Address(RVA = "0x116AAB0", Offset = "0x11698B0", Length = "0xF")]
	public FadeOut()
	{
	}
}
