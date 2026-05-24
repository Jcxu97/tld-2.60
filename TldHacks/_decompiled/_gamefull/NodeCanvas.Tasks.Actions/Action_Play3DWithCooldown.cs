using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Play 3D Audio With Cooldown", 0)]
[Description("Play audio event from specified emitter, with a cooldown before this event can be triggered again")]
[Category("TLD Actions/Audio")]
[Token(Token = "0x20011BE")]
public class Action_Play3DWithCooldown : ActionTask
{
	[Token(Token = "0x40088E1")]
	[FieldOffset(Offset = "0x68")]
	public string audioEventName;

	[Token(Token = "0x40088E2")]
	[FieldOffset(Offset = "0x70")]
	public string missionObjectIdentifier;

	[Token(Token = "0x40088E3")]
	[FieldOffset(Offset = "0x78")]
	public float cooldownTime;

	[Token(Token = "0x40088E4")]
	[FieldOffset(Offset = "0x7C")]
	private float m_NextPlayTime;

	[Token(Token = "0x6007615")]
	[Address(RVA = "0x1117E20", Offset = "0x1116C20", Length = "0x21B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007616")]
	[Address(RVA = "0x1118040", Offset = "0x1116E40", Length = "0x1AE")]
	private void DoWork()
	{
	}

	[Token(Token = "0x6007617")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_Play3DWithCooldown()
	{
	}
}
