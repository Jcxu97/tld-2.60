using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Enable AuroraField", 0)]
[Description("Enable/Disable AuroraField")]
[Category("TLD Actions/Objects")]
[Token(Token = "0x20011C7")]
public class Action_AuroraFielEnable : ActionTask
{
	[Token(Token = "0x40088F0")]
	[FieldOffset(Offset = "0x68")]
	public string missionObjectIdentifier;

	[Token(Token = "0x40088F1")]
	[FieldOffset(Offset = "0x70")]
	public bool enabled;

	[Token(Token = "0x600762E")]
	[Address(RVA = "0x1118F80", Offset = "0x1117D80", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600762F")]
	[Address(RVA = "0x1118FB0", Offset = "0x1117DB0", Length = "0x1F2")]
	private void DoWork()
	{
	}

	[Token(Token = "0x6007630")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_AuroraFielEnable()
	{
	}
}
