using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Skill Points", 0)]
[Description("Set a certain skill points.")]
[Category("TLD Actions/Skills")]
[Token(Token = "0x200122A")]
public class Action_SetSkillPoints : ActionTask
{
	[Token(Token = "0x4008A19")]
	[FieldOffset(Offset = "0x68")]
	public SkillType skillType;

	[Token(Token = "0x4008A1A")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<int> skillpoints;

	[Token(Token = "0x4008A1B")]
	[FieldOffset(Offset = "0x78")]
	public SkillsManager.PointAssignmentMode assignmentMode;

	[Token(Token = "0x1700097F")]
	protected override string info
	{
		[Token(Token = "0x6007746")]
		[Address(RVA = "0x115A3D0", Offset = "0x11591D0", Length = "0x161")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007747")]
	[Address(RVA = "0x115A540", Offset = "0x1159340", Length = "0x27D")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007748")]
	[Address(RVA = "0x115A7C0", Offset = "0x11595C0", Length = "0xF")]
	public Action_SetSkillPoints()
	{
	}
}
