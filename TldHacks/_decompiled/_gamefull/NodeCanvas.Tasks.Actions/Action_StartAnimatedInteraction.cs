using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Start Animated Interaction", 0)]
[Description("Sets a variable on an animator")]
[Category("TLD Actions/Animation")]
[Token(Token = "0x20011B9")]
public class Action_StartAnimatedInteraction : ActionTask
{
	[Token(Token = "0x40088D0")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionObjectIdentifier;

	[Token(Token = "0x40088D1")]
	[FieldOffset(Offset = "0x70")]
	public bool forceInteraction;

	[Token(Token = "0x40088D2")]
	[FieldOffset(Offset = "0x74")]
	public float waitBlackedOutDurationSeconds;

	[Token(Token = "0x40088D3")]
	[FieldOffset(Offset = "0x78")]
	private bool hasCalledDoWork;

	[Token(Token = "0x40088D4")]
	[FieldOffset(Offset = "0x7C")]
	private float waitTimeRemainingSeconds;

	[Token(Token = "0x6007602")]
	[Address(RVA = "0x11161F0", Offset = "0x1114FF0", Length = "0x3D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007603")]
	[Address(RVA = "0x1116230", Offset = "0x1115030", Length = "0xBA")]
	private void UpdateFade(float delta)
	{
	}

	[Token(Token = "0x6007604")]
	[Address(RVA = "0x11162F0", Offset = "0x11150F0", Length = "0x47")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007605")]
	[Address(RVA = "0x1116340", Offset = "0x1115140", Length = "0xCB")]
	private bool CanStart()
	{
		return false;
	}

	[Token(Token = "0x6007606")]
	[Address(RVA = "0x1116410", Offset = "0x1115210", Length = "0x2DB")]
	private void DoWork()
	{
	}

	[Token(Token = "0x6007607")]
	[Address(RVA = "0x10C5290", Offset = "0x10C4090", Length = "0xA")]
	private void OnWorkDone()
	{
	}

	[Token(Token = "0x6007608")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_StartAnimatedInteraction()
	{
	}
}
