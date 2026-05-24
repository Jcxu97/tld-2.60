using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Fade In Camera", 0)]
[Category("TLD Actions")]
[Token(Token = "0x200127C")]
public class Action_FadeInCamera : ActionTask
{
	[Token(Token = "0x4008B08")]
	[FieldOffset(Offset = "0x68")]
	public float m_Time;

	[Token(Token = "0x4008B09")]
	[FieldOffset(Offset = "0x6C")]
	public float m_Delay;

	[Token(Token = "0x6007830")]
	[Address(RVA = "0x116A9F0", Offset = "0x11697F0", Length = "0x73")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007831")]
	[Address(RVA = "0x116AA70", Offset = "0x1169870", Length = "0x37")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007832")]
	[Address(RVA = "0x116AAB0", Offset = "0x11698B0", Length = "0xF")]
	public Action_FadeInCamera()
	{
	}
}
