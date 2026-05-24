using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Play 3D Audio", 0)]
[Description("Play audio event from specified emitter")]
[Category("TLD Actions/Audio")]
[Token(Token = "0x20011BD")]
public class Action_Audio : ActionTask
{
	[Token(Token = "0x40088DF")]
	[FieldOffset(Offset = "0x68")]
	public string audioEventName;

	[Token(Token = "0x40088E0")]
	[FieldOffset(Offset = "0x70")]
	public string missionObjectIdentifier;

	[Token(Token = "0x6007612")]
	[Address(RVA = "0x1117AB0", Offset = "0x11168B0", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007613")]
	[Address(RVA = "0x1117AE0", Offset = "0x11168E0", Length = "0x33C")]
	private void DoWork()
	{
	}

	[Token(Token = "0x6007614")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_Audio()
	{
	}
}
