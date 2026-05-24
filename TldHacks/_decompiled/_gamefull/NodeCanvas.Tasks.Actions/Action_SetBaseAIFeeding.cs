using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("TLD/AI")]
[Name("SetBaseAiFeeding", 0)]
[Description("Sets the baseai to feed on specified target for an optional amount of time. -1 is default forever.")]
[Token(Token = "0x20011A8")]
public class Action_SetBaseAIFeeding : TLD_Action
{
	[Token(Token = "0x40088A4")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> target;

	[Token(Token = "0x40088A5")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> attackRadius;

	[Token(Token = "0x40088A6")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<float> holdGroundRadius;

	[Token(Token = "0x40088A7")]
	[FieldOffset(Offset = "0x90")]
	public float m_FeedingDurationHours;

	[Token(Token = "0x60075D5")]
	[Address(RVA = "0x1111DC0", Offset = "0x1110BC0", Length = "0x380")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60075D6")]
	[Address(RVA = "0x1112150", Offset = "0x1110F50", Length = "0x12")]
	public Action_SetBaseAIFeeding()
	{
	}
}
