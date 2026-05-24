using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Episode State", 0)]
[Description("Sets an episode state")]
[Category("TLD Actions")]
[Token(Token = "0x2001271")]
public class Action_SetEpisodeState : ActionTask
{
	[Token(Token = "0x4008AFA")]
	[FieldOffset(Offset = "0x68")]
	public Episode episode;

	[Token(Token = "0x4008AFB")]
	[FieldOffset(Offset = "0x6C")]
	public EpisodeState state;

	[Token(Token = "0x600780D")]
	[Address(RVA = "0x1169120", Offset = "0x1167F20", Length = "0x122")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600780E")]
	[Address(RVA = "0x1169250", Offset = "0x1168050", Length = "0xF")]
	public Action_SetEpisodeState()
	{
	}
}
