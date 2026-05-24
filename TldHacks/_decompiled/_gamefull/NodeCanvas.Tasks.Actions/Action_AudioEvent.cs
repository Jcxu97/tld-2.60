using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Audio Event", 0)]
[Description("Play audio event from specified emitter")]
[Category("TLD Actions/Audio")]
[Token(Token = "0x20011BF")]
public class Action_AudioEvent : ActionTask
{
	[Token(Token = "0x40088E5")]
	[FieldOffset(Offset = "0x68")]
	public string audioEventName;

	[Token(Token = "0x1700095C")]
	protected override string info
	{
		[Token(Token = "0x6007618")]
		[Address(RVA = "0x11181F0", Offset = "0x1116FF0", Length = "0x6B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007619")]
	[Address(RVA = "0x1118260", Offset = "0x1117060", Length = "0x131")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600761A")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_AudioEvent()
	{
	}
}
