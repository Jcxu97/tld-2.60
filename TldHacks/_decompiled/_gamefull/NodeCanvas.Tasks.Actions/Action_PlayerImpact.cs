using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Apply Player Impact", 0)]
[Description("Apply an impact to the player")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001221")]
public class Action_PlayerImpact : ActionTask
{
	[Token(Token = "0x40089F7")]
	[FieldOffset(Offset = "0x68")]
	public ImpactDefinition impactDefinition;

	[Token(Token = "0x40089F8")]
	[FieldOffset(Offset = "0x70")]
	public float waitTimeSeconds;

	[Token(Token = "0x6007722")]
	[Address(RVA = "0x1156DC0", Offset = "0x1155BC0", Length = "0x135")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007723")]
	[Address(RVA = "0x1156F00", Offset = "0x1155D00", Length = "0x2E")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007724")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_PlayerImpact()
	{
	}
}
