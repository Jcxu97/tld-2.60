using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Episode Progress", 0)]
[Description("Sets the completion percentage for the episode. Value must be between 0 and 100.")]
[Category("TLD Actions")]
[Token(Token = "0x2001272")]
public class Action_SetEpisodeProgress : ActionTask
{
	[Token(Token = "0x4008AFC")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<int> m_EpisodeProgress;

	[Token(Token = "0x170009AC")]
	protected override string info
	{
		[Token(Token = "0x600780F")]
		[Address(RVA = "0x1169260", Offset = "0x1168060", Length = "0xE2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007810")]
	[Address(RVA = "0x1169350", Offset = "0x1168150", Length = "0x33E")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007811")]
	[Address(RVA = "0x1169690", Offset = "0x1168490", Length = "0xE3")]
	public Action_SetEpisodeProgress()
	{
	}
}
