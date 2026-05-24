using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Skill Level", 0)]
[Description("Set a certain skill level.")]
[Category("TLD Actions/Skills")]
[Token(Token = "0x200122B")]
public class Action_SetSkillLevel : ActionTask
{
	[Token(Token = "0x4008A1C")]
	[FieldOffset(Offset = "0x68")]
	public SkillType skillType;

	[Token(Token = "0x4008A1D")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<SkillTiers> skillTier;

	[Token(Token = "0x4008A1E")]
	[FieldOffset(Offset = "0x78")]
	public SkillsManager.PointAssignmentMode assignmentMode;

	[Token(Token = "0x17000980")]
	protected override string info
	{
		[Token(Token = "0x6007749")]
		[Address(RVA = "0x115A7D0", Offset = "0x11595D0", Length = "0x109")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600774A")]
	[Address(RVA = "0x115A8E0", Offset = "0x11596E0", Length = "0x228")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600774B")]
	[Address(RVA = "0x115A7C0", Offset = "0x11595C0", Length = "0xF")]
	public Action_SetSkillLevel()
	{
	}
}
