using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Suppress Footstep Audio", 0)]
[Description("Allow or suppress the footstep audio sounds.")]
[Category("TLD Actions/Audio")]
[Token(Token = "0x20011C4")]
public class Audio_SuppressFootsteps : ActionTask
{
	[Token(Token = "0x40088EA")]
	[FieldOffset(Offset = "0x68")]
	public bool m_Suppress;

	[Token(Token = "0x6007626")]
	[Address(RVA = "0x1118A40", Offset = "0x1117840", Length = "0x67")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007627")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Audio_SuppressFootsteps()
	{
	}
}
