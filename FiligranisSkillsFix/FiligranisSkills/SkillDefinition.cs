using Il2Cpp;
using UnityEngine;

namespace FiligranisSkills;

public class SkillDefinition
{
	public string Name { get; set; }

	public LocalizedString DisplayNameLocalized { get; set; }

	public string IconId { get; set; }

	public string IconBackgroundId { get; set; }

	public string ImageId { get; set; }

	public LocalizedString[] TiersDescriptionLocalized { get; set; }

	public LocalizedString[] TiersBenefitsLocalized { get; set; }

	public int[] TierThresholds { get; set; }

	public Texture2D? Image { get; set; }

	public SkillDefinition(string name = null, LocalizedString displayNameLocalized = null, string iconId = null, string iconBackgroundId = null, string imageId = null, LocalizedString[] tiersDescriptionLocalized = null, LocalizedString[] tiersBenefitsLocalized = null, int[] tierThresholds = null, Texture2D? image = null)
	{
		Name = name;
		DisplayNameLocalized = displayNameLocalized;
		IconId = iconId;
		IconBackgroundId = iconBackgroundId;
		ImageId = imageId;
		TiersDescriptionLocalized = tiersDescriptionLocalized;
		TiersBenefitsLocalized = tiersBenefitsLocalized;
		TierThresholds = tierThresholds;
		Image = image;
	}
}
