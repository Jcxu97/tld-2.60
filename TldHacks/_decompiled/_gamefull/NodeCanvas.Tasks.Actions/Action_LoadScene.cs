using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Load Scene", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001267")]
public class Action_LoadScene : ActionTask<GraphOwner>
{
	[Token(Token = "0x2001268")]
	public enum ActionCondition
	{
		[Token(Token = "0x4008AE6")]
		AlwaysRun,
		[Token(Token = "0x4008AE7")]
		JustForDebugMissionJump,
		[Token(Token = "0x4008AE8")]
		JustForSaveRestore
	}

	[Token(Token = "0x4008ADB")]
	[FieldOffset(Offset = "0x68")]
	public string sceneName;

	[Token(Token = "0x4008ADC")]
	[FieldOffset(Offset = "0x70")]
	public bool allowReloadOfCurrentScene;

	[Token(Token = "0x4008ADD")]
	[FieldOffset(Offset = "0x71")]
	public bool waitDeserializeCompleted;

	[Token(Token = "0x4008ADE")]
	[FieldOffset(Offset = "0x74")]
	public ActionCondition actionCondition;

	[Token(Token = "0x4008ADF")]
	[FieldOffset(Offset = "0x78")]
	public string audioEventOnStart;

	[Token(Token = "0x4008AE0")]
	[FieldOffset(Offset = "0x80")]
	public bool skipFadeInOnLoad;

	[Token(Token = "0x4008AE1")]
	[FieldOffset(Offset = "0x81")]
	public bool keepAudioPlaying;

	[Token(Token = "0x4008AE2")]
	[FieldOffset(Offset = "0x82")]
	public bool holdCameraFadeAfterLoad;

	[Tooltip("DEBUG ONLY. Mark this jump as a mission jump. Necessary to be set if forcing a load after a mission jump that requires layer loading.")]
	[Token(Token = "0x4008AE3")]
	[FieldOffset(Offset = "0x83")]
	public bool forceMissionJumpState;

	[Token(Token = "0x4008AE4")]
	public static bool m_ForceSceneReload;

	[Token(Token = "0x170009A8")]
	protected override string info
	{
		[Token(Token = "0x60077F9")]
		[Address(RVA = "0x1167B70", Offset = "0x1166970", Length = "0xA9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077FA")]
	[Address(RVA = "0x1167C20", Offset = "0x1166A20", Length = "0x611")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077FB")]
	[Address(RVA = "0x1168240", Offset = "0x1167040", Length = "0xC9")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60077FC")]
	[Address(RVA = "0x1168310", Offset = "0x1167110", Length = "0x44")]
	public Action_LoadScene()
	{
	}
}
