using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Video_IsPlaying", 0)]
[Category("TLD Conditions")]
[Description("Check if a movie is currently playing")]
[Token(Token = "0x2001281")]
public class VideoIsPlaying : ConditionTask
{
	[Token(Token = "0x6007846")]
	[Address(RVA = "0x116B6B0", Offset = "0x116A4B0", Length = "0x45")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007847")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public VideoIsPlaying()
	{
	}
}
