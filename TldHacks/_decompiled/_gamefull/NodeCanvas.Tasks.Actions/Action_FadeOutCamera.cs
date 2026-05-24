using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Fade Out Camera", 0)]
[Category("TLD Actions")]
[Token(Token = "0x200127D")]
public class Action_FadeOutCamera : ActionTask
{
	[Token(Token = "0x4008B0A")]
	[FieldOffset(Offset = "0x68")]
	public float m_Time;

	[Token(Token = "0x4008B0B")]
	[FieldOffset(Offset = "0x6C")]
	public float m_Delay;

	[Token(Token = "0x6007833")]
	[Address(RVA = "0x116AAC0", Offset = "0x11698C0", Length = "0x73")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007834")]
	[Address(RVA = "0x116AA70", Offset = "0x1169870", Length = "0x37")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007835")]
	[Address(RVA = "0x116AAB0", Offset = "0x11698B0", Length = "0xF")]
	public Action_FadeOutCamera()
	{
	}
}
