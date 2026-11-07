using Il2Cpp;

namespace FiligranisSkills;

public readonly record struct ReadOnlySkillHandle(Skill Skill)
{
	public int Tier => Skill.GetCurrentTierNumber();

	public int Points => Skill.GetPoints();
}
