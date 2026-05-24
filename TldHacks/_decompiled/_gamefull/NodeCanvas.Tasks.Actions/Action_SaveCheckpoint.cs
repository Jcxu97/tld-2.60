using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Save Checkpoint", 0)]
[Description("Creates a checkpoint savegame parallel to normal savegame")]
[Category("TLD Actions")]
[Token(Token = "0x2001224")]
public class Action_SaveCheckpoint : ActionTask
{
	[Token(Token = "0x40089FC")]
	private static float s_NextSaveTime;

	[Token(Token = "0x40089FD")]
	private const float SAVE_DELAY_TIME = 5f;

	[Token(Token = "0x600772B")]
	[Address(RVA = "0x1157490", Offset = "0x1156290", Length = "0xC1")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600772C")]
	[Address(RVA = "0x1157560", Offset = "0x1156360", Length = "0x623")]
	public static bool MaybeSave()
	{
		return false;
	}

	[Token(Token = "0x600772D")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SaveCheckpoint()
	{
	}
}
