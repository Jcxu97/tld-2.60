using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Mission Selector", 0)]
[Category("TLD Actions")]
[Token(Token = "0x20011E8")]
public class Action_MissionSelector : ActionTask
{
	[Token(Token = "0x4008949")]
	[FieldOffset(Offset = "0x68")]
	public string missionDataVar;

	[Token(Token = "0x400894A")]
	[FieldOffset(Offset = "0x70")]
	public MissionTriggerType missionTriggerType;

	[Token(Token = "0x1700096E")]
	protected override string info
	{
		[Token(Token = "0x6007693")]
		[Address(RVA = "0x114A390", Offset = "0x1149190", Length = "0x5A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007694")]
	[Address(RVA = "0x114A3F0", Offset = "0x11491F0", Length = "0x6AC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007695")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_MissionSelector()
	{
	}
}
