using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("SetBaseAiSpeedOverride", 0)]
[Description("Sets override speed for a baseai")]
[Category("TLD Actions/BaseAi")]
[Token(Token = "0x20011AF")]
public class Action_SetBaseAiSpeedOverride : TLD_Action
{
	[Token(Token = "0x40088B4")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> doOverride;

	[Token(Token = "0x40088B5")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> overrideSpeed;

	[Token(Token = "0x60075E6")]
	[Address(RVA = "0x1113350", Offset = "0x1112150", Length = "0x22")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075E7")]
	[Address(RVA = "0x1113380", Offset = "0x1112180", Length = "0x1F3")]
	private void DoWork()
	{
	}

	[Token(Token = "0x60075E8")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetBaseAiSpeedOverride()
	{
	}
}
