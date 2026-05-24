using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Suppress Condition Voice Over", 0)]
[Description("Suppress or restore player voice overs for conditional level changes. Applies to Condition, Fatigue, Frezing, Hunger, and Thirst.")]
[Category("TLD Actions/Audio")]
[Token(Token = "0x20011C1")]
public class Action_SuppressConditionVoiceOver : ActionTask
{
	[Token(Token = "0x40088E8")]
	[FieldOffset(Offset = "0x68")]
	public bool suppress;

	[Token(Token = "0x1700095E")]
	protected override string info
	{
		[Token(Token = "0x600761E")]
		[Address(RVA = "0x11185F0", Offset = "0x11173F0", Length = "0x73")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600761F")]
	[Address(RVA = "0x1118670", Offset = "0x1117470", Length = "0xBA")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007620")]
	[Address(RVA = "0x11185E0", Offset = "0x11173E0", Length = "0xC")]
	public Action_SuppressConditionVoiceOver()
	{
	}
}
